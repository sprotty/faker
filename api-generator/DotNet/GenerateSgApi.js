const { Writer, Utils, config } = require('./GeneratorCommon.js');
const { exit } = require('node:process');

config.classes = config.classes.filter((cls) => cls.lttdg_exclude != true);
config.classes.forEach(cls => cls.classes = cls.classes.filter((clsSub) => clsSub.lttdg_exclude != true));
config.classes.forEach((cls) =>
    cls.methods = cls.methods.filter(m =>
        m.private != true && m.lttdg_exclude != true));
config.classes.forEach(cls =>
    cls.classes.forEach(clsSub =>
        clsSub.methods = clsSub.methods.filter((m) =>
            m.private != true && m.lttdg_exclude != true)));

var myWriter = new Writer();

myWriter.output('using LiquidTechnologies.MetaTypeSystem;\n');
myWriter.output('using FakerNet;\n');
myWriter.output('using System.Diagnostics.CodeAnalysis;\n');
myWriter.output('using System.Globalization;\n');
myWriter.output('using System.CodeDom.Compiler;\n');
myWriter.output('using System.ComponentModel.DataAnnotations;\n');
myWriter.output('using System.Text;\n');
myWriter.output('using System.Diagnostics;\n');
myWriter.output('\n');
myWriter.output('namespace LiquidTechnologies.SampleDataGeneratorModel\n');
myWriter.output('{\n');
myWriter.outputIndentPush();
{
    for (const cls of config.classes) {
        generateClass(cls, []);
    }
}
myWriter.outputIndentPop();
myWriter.output('}\n');

myWriter.write('./FakerMethodsAdapter.cs');

exit(0);

function generateClass(cls, class_path) {
    const nativeClsName = 'FakerAdapter' + class_path.join() + cls.name;
    myWriter.output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
    myWriter.output('[NativeContainer]\n');
    myWriter.output('public partial class ' + nativeClsName + '\n');
    myWriter.output('{\n');
    myWriter.outputIndentPush();
    {
        for (const method of cls.methods ?? [])
            writeMethod(method, [...class_path, cls.name]);
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
    myWriter.output('\n');

    for (const clsChild of cls.classes ?? [])
        generateClass(clsChild, [...class_path, cls.name]);
}

function writeMethod(method, class_path) {
    if (Utils.isNullOrWhitespace(method.name) || Utils.isNullOrWhitespace(method.return_type)) {
        myWriter.output('#warning Failed processing method ' + method.name + ' : method has no name or return type.\n');
        return;
    }
    // find the best implementation
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => Utils.isNullOrWhitespace(d.platform))
    if (impl == null) {
        myWriter.output('#warning No implementation defined for method ' + method.name + '\n');
        return;
    }

    const fakerMethodName = Utils.GetNativeMethodName(method.name);
    const tdgMethodName = getTsgMethodName(method);
    const tsgGroupName = getTsgGroupName(class_path, method);
    const rubyMethodType = method.return_type;
    const tsgMethodType = GetTdgType(rubyMethodType);

    var methodDesc = method.descriptions.find(d => d.platform == 'C#')?.text ?? method.descriptions.find(d => d.platform == null)?.text ?? '';

    const returnValueDesc = method.return_desc ?? ('The result of ' + tdgMethodName);
    myWriter.output('[NativeFunction("' + Utils.getNativeEscapedString(tdgMethodName) + '", "' + Utils.getNativeEscapedString(methodDesc) + '", "' + tsgGroupName + '", "function-' + class_path.map(g => g.toLowerCase()).join('-') + '-' + tdgMethodName + '.png", AccessorType.Method)]\n');
    myWriter.output('[return: ArgumentProperty("Value", "' + Utils.getNativeEscapedString(returnValueDesc) + '")]\n')
    myWriter.output('public static ' + tsgMethodType + ' ' + tdgMethodName + '(\n');
    myWriter.outputIndentPush();
    {
        myWriter.output('  [ArgumentProperty("context", "internal use")] IEvaluationContext context');
        myWriter.output(getArgs(method.arguments));
        if (method.usesLocale != false)
            myWriter.output('\n, [ArgumentProperty("Locale", "The locale from which the name should be created", IsOptional = true, OptionalDesc = "Inherit Value", IsAdvanced = true)] CultureInfo? locale');
        myWriter.output(')\n');
    }
    myWriter.outputIndentPop();
    myWriter.output('{\n');
    myWriter.outputIndentPush();
    {
        var fn;
        if (method.usesLocale != false)
            fn = 'context.GetFakerInstance(locale).';
        else
            fn = 'context.GetFakerInstance(CultureInfo.CurrentCulture).FakerEn.';

        fn += class_path.join('.') + '.' + fakerMethodName + '(' + method.arguments.map(a => getArgValue(a)).join(', ') + ')';

        if (rubyMethodType == 'Binary')
            fn = 'new Binary(' + fn + ')';

        myWriter.output('return ' + fn + ';\n');
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
}

function getArgs(args) {
    return args.map(a => getArg(a)).join('');
}
function getArg(arg) {
    // [ArgumentProperty("Gender", "The gender of the name to create", IsOptional = true, OptionalDesc = "Random Value")] GenderType? gender,
    const argFakerName = Utils.GetNativeArgName(arg.name);
    const argRubyType = arg.type;
    // const argFakerType = Utils.GetNativeType(argRubyType);
    var argTdgType = GetTdgType(argRubyType);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var nameParam = '"' + Utils.getNativeEscapedString(argFakerName) + '"';
    var descParam = ', "' + Utils.getNativeEscapedString(arg.descriptions.find(d => d.platform == 'C#')?.text ?? arg.descriptions.find(d => d.platform == null)?.text ?? '') + '"';
    var argDefaultDecl = '';
    var optionalParam = '';
    var optionalDescParam = '';
    var safeDefaultValue = arg.default == null ? null : arg.default == 'nil' ? 'null' : '"' + Utils.getNativeEscapedString(arg.default) + '"';

    if (Utils.isNullOrWhitespace(arg.default) == false) {
        optionalParam += ', IsOptional = true';
        if (Utils.isNullOrWhitespace(arg.default_value_desc) == false)
            optionalDescParam += ', OptionalDesc = "' + Utils.getNativeEscapedString(arg.default_value_desc) + '"';
        else
            optionalDescParam += ', OptionalDesc = "' + Utils.getNativeEscapedString(safeDefaultValue) + '"';

        if (arg.default == 'nil') {
            // String Fn(ARG_TYPE? arg = null)
            //argDefaultDecl = '';
            argTdgType += '?';
        }
        else if (argTdgType == 'string' && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = 'DEFAULT_VALUE')
            argDefaultDecl = ', Default = "' + Utils.getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + '"';
        }
        else if (canDefault == false) {
            // Implemented within the function
            // String Fn(ARG_TYPE? arg = null){
            //  arg ??= DEFAULT_VALUE;
            // }
            // argDefaultDecl = '';
            argTdgType += '?';
        }
        else {
            // String Fn(ARG_TYPE arg = DEFAULT_VALUE)
            argDefaultDecl = ', Default = ' + safeDefaultValue;
        }
        // argDefaultDecl = ' = ' + argDefaultDecl;
    }

    return '\n, [ArgumentProperty(' + nameParam + descParam + optionalParam + optionalDescParam + argDefaultDecl + ')] ' + argTdgType + ' ' + argFakerName; // + ' ' +  + argDefaultDecl;
}
function getArgValue(arg) {
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argRubyType = arg.type;
    var argFakerType = Utils.GetNativeType(argRubyType);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var argDefault = arg.default;
    var argExpr = argNativeName;



    if (Utils.isNullOrWhitespace(argDefault) == false && canDefault == false) {
        const strLiteral = '"' + Utils.getNativeEscapedString(argDefault) + '"';

        // if (argFakerType == 'IntegerRange')
        //     argExpr = argNativeName + ' ?? IntegerRange.Parse(' + strLiteral + ')';
        // else 
        if (argFakerType.startsWith('UNKNOWN_'))
            argExpr = argNativeName + ' ?? ' + argFakerType + '.Parse(' + strLiteral + ')';
        else if (argFakerType.startsWith('List<'))
            argExpr = argNativeName + ' ?? ' + argFakerType + '.Parse(' + strLiteral + ')';
        else
            argExpr = argNativeName + ' ?? ' + Utils.GetCastStringToCode(strLiteral, arg.type);
        // else
        //     throw new Error('Missing initilization code for ' + argNativeType);
    }

    if (argRubyType == 'Binary') {
        // convert from byte[] to Binary
        argExpr = argExpr + '?.Data';
    }

    return argExpr;
}
function GetTdgType(rubyType) {
    if (rubyType == "Binary")
        return 'Binary';
    else
        return Utils.GetNativeType(rubyType);
}

function getTsgMethodName(method) {
    if (Utils.isNullOrWhitespace(method.lttdg_name))
        return Utils.GetNativeMethodName(method.name);
    else {
        const index = method.lttdg_name.lastIndexOf('.');
        if (index >= 0)
            return method.lttdg_name.substring(index + 1);
        else
            return method.lttdg_name;
    }
}
function getTsgGroupName(class_path, method) {
    if (Utils.isNullOrWhitespace(method.lttdg_name)) {
        return class_path.map(g => Utils.getNativeEscapedString(g)).join('.');
    }
    else {
        return method.lttdg_name
            .split('|')
            .map(g => (g.lastIndexOf('.') < 0) ? class_path.map(g => Utils.getNativeEscapedString(g)).join('.') : g.substring(0, g.lastIndexOf('.')))
            .join('|');
    }
}
