const { Writer, Utils, config } = require('./GeneratorCommon.js');
const { exit } = require('node:process');

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
    const nativeMethodName = Utils.isNullOrWhitespace(method.lttdg_name) ? fakerMethodName : method.lttdg_name;
    const rubyMethodType = method.return_type;
    const nativeMethodType = Utils.GetNativeType(rubyMethodType);

    var methodDesc = method.descriptions.find(d => d.platform == 'C#') ?? method.descriptions.find(d => d.platform == null)?.text ?? '';

    const returnValueDesc = method.return_desc ?? ('The result of ' + nativeMethodName);
    myWriter.output('[NativeFunction("' + Utils.getNativeEscapedString(nativeMethodName) + '", "' + Utils.getNativeEscapedString(methodDesc) + '", "' + class_path.map(g => Utils.getNativeEscapedString(g)).join('.') + '", "function-' + class_path.map(g => g.toLowerCase()).join('-') + '-' + nativeMethodName + '.png", AccessorType.Method)]\n');
    myWriter.output('[return: ArgumentProperty("Value", "' + Utils.getNativeEscapedString(returnValueDesc) + '")]\n')
    myWriter.output('public static ' + nativeMethodType + ' ' + nativeMethodName + '(\n');
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
        if (method.usesLocale != false)
            myWriter.output('return context.GetFakerInstance(locale).');
        else
            myWriter.output('return context.GetFakerInstance(new CultureInfo("en")).');
        myWriter.output(class_path.join('.') + '.' + fakerMethodName + '(' + method.arguments.map(a => getArgValue(a)).join(', ') + ');\n');
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
}

function getArgs(args) {
    return args.map(a => getArg(a)).join('');
}
function getArg(arg) {
    // [ArgumentProperty("Gender", "The gender of the name to create", IsOptional = true, OptionalDesc = "Random Value")] GenderType? gender,
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argNativeType = Utils.GetNativeType(arg.type);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var nameParam = '"' + Utils.getNativeEscapedString(argNativeName) + '"';
    var descParam = ', "' + Utils.getNativeEscapedString(arg.text ?? '') + '"';
    var argDefaultDecl = '';
    var optionalParam = '';
    var optionalDescParam = '';

    if (Utils.isNullOrWhitespace(arg.default) == false) {
        optionalParam += ', IsOptional = true';
        optionalDescParam += ', OptionalDesc = "' + Utils.getNativeEscapedString(arg.default) + '"';

        if (arg.default == 'nil') {
            // String Fn(ARG_TYPE? arg = null)
            //argDefaultDecl = '';
            argNativeType += '?';
        }
        else if (argNativeType == 'string' && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = 'DEFAULT_VALUE')
            argDefaultDecl = ', Default = "' + Utils.getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + '"';
        }
        else if (canDefault == false) {
            // Implemented within the function
            // String Fn(ARG_TYPE? arg = null){
            //  arg ??= DEFAULT_VALUE;
            // }
            // argDefaultDecl = '';
            argNativeType += '?';
        }
        else {
            // String Fn(ARG_TYPE arg = DEFAULT_VALUE)
            argDefaultDecl = ', Default = "' + arg.default + '"';
        }
        // argDefaultDecl = ' = ' + argDefaultDecl;
    }

    return '\n, [ArgumentProperty(' + nameParam + descParam + optionalParam + optionalDescParam + argDefaultDecl + ')] ' + argNativeType + ' ' + argNativeName; // + ' ' +  + argDefaultDecl;
}
function getArgValue(arg) {
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argNativeType = Utils.GetNativeType(arg.type);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var argDefault = arg.default;

    if (Utils.isNullOrWhitespace(argDefault) == false && canDefault == false) {
        if (argNativeType == 'IntegerRange')
            return argNativeName + ' ??= IntegerRange.Parse(\"' + Utils.getNativeEscapedString(argDefault) + '\")';
        else if (argNativeType.startsWith('UNKNOWN_'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + Utils.getNativeEscapedString(argDefault) + '")';
        else if (argNativeType.startsWith('List<'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + Utils.getNativeEscapedString(argDefault) + '")';
        else
            throw new Error('Missing initilization code for ' + argNativeType);
    }
    return argNativeName;
}
