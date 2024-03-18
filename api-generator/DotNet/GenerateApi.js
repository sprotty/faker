const { Writer, Utils, config } = require('./GeneratorCommon.js');
const { exit } = require('node:process');

var myWriter = new Writer();

myWriter.output('using System.Diagnostics.CodeAnalysis;\n');
myWriter.output('using System.Globalization;\n');
myWriter.output('using System.CodeDom.Compiler;\n');
myWriter.output('using System.ComponentModel.DataAnnotations;\n');
myWriter.output('using System.Text;\n');
myWriter.output('using System.Diagnostics;\n');
myWriter.output('\n');
myWriter.output('namespace FakerNet\n');
myWriter.output('{\n');
myWriter.outputIndentPush();
{
    for (const enm of config.enums) {
        myWriter.output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
        myWriter.output('/// <summary>\n');
        writeDocsString(enm.description);
        myWriter.output('/// </summary>\n');
        myWriter.output('public enum ' + Utils.GetNativeEnumName(enm.name) + '\n');
        myWriter.output('{\n');
        myWriter.outputIndentPush();
        {
            for (const enmVal of enm.values) {
                if (Utils.isNullOrWhitespace(enmVal.description) == false) {
                    myWriter.output('/// <summary>\n');
                    writeDocsString(enmVal.description);
                    myWriter.output('/// </summary>\n');
                }
                myWriter.output('[Display(Name = "' + (enmVal.value ?? enmVal.name) + '", Description = "' + (enmVal.description ?? enmVal.name) + '", ShortName = "' + (enmVal.value ?? enmVal.name) + '")]\n');
                myWriter.output(Utils.GetNativeEnumValue(enmVal.name) + ',\n');
            }
        }
        myWriter.outputIndentPop();
        myWriter.output('}\n');
        myWriter.output('\n');
    }

    for (const cls of config.classes) {
        generateClass(cls);
    }

    myWriter.output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
    myWriter.output('partial class Faker\n');
    myWriter.output('{\n');
    myWriter.outputIndentPush();
    {
        for (const cls of config.classes) {
            myWriter.output('[FakerProperty]\n');
            myWriter.output('public ' + cls.name + 'Generator ' + cls.name + ' { get; }\n');
        }
        myWriter.output('\n');
        myWriter.output('public Faker(CultureInfo locale, Random random)\n');
        myWriter.output('{\n');
        myWriter.outputIndentPush();
        {
            myWriter.output('this.Random = random;\n');
            myWriter.output('\n');
            myWriter.output('// Create the Faker Generators\n');
            for (const cls of config.classes) {
                myWriter.output(cls.name + ' = new ' + cls.name + 'Generator(this);\n');
            }
            myWriter.output('\n');
            myWriter.output('Init(locale);\n');
        }
        myWriter.outputIndentPop();
        myWriter.output('}\n');
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
}
myWriter.outputIndentPop();
myWriter.output('}\n');

myWriter.write('./FakerNet/Generators/FakerGenerators.cs');

exit(0);

function generateClass(cls) {
    writeDocsSummary(cls.descriptions);
    myWriter.output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
    myWriter.output('[FakerGenerator("' + (cls.ruby_qualified_name ?? cls.name) + '")]\n');
    myWriter.output('public partial class ' + cls.name + 'Generator : GeneratorBase\n');
    myWriter.output('{\n');
    myWriter.outputIndentPush();
    {
        for (const nestedCls of cls.classes ?? []) {
            //myWriter.output('[FakerMethod("' + nestedCls.name + '")]\n');
            myWriter.output('[FakerProperty]\n');
            myWriter.output('public ' + nestedCls.name + 'Generator ' + nestedCls.name + ' { get; }\n');
        }

        myWriter.output('internal ' + cls.name + 'Generator(Faker faker)\n');
        myWriter.output('         : base(faker)\n');
        myWriter.output('{\n');
        myWriter.outputIndentPush();
        {
            for (const nestedCls of cls.classes ?? []) {
                myWriter.output(nestedCls.name + ' = new ' + nestedCls.name + 'Generator(this.Faker);\n');
            }
        }
        myWriter.outputIndentPop();
        myWriter.output('}\n');
        myWriter.output('\n');

        for (const clsChild of cls.classes ?? [])
            generateClass(clsChild);

        for (const method of cls.methods ?? [])
            writeMethod(method);
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
    myWriter.output('\n');
}

function writeDocsSummary(descriptions) {
    var desc = descriptions.find(d => d.platform == 'C#') ?? descriptions.find(d => d.platform == null)
    if (desc && Utils.isNullOrWhitespace(desc.text) == false) {
        myWriter.output('/// <summary>\n');
        writeDocsString(desc.text);
        myWriter.output('/// </summary>\n');
    }
}

function writeDocsArgs(args) {
    for (const arg of args) {
        var desc = arg.descriptions.find(d => d.platform == 'C#') ?? arg.descriptions.find(d => d.platform == null)

        myWriter.output('/// <param name="' + Utils.GetNativeArgName(arg.name) + '">\n');
        if (desc && Utils.isNullOrWhitespace(desc.text) == false) {
            writeDocsString(desc.text);
        }
        if (Utils.isNullOrWhitespace(arg.default) == false) {
            {
                var docs = '(default value ';
                if (arg.default == 'nil')
                    docs += 'null';
                else
                    docs += '"' + arg.default + '"';
                if (Utils.isNullOrWhitespace(arg.default_value_desc) == false) {
                    docs += ' [' + arg.default_value_desc + ']';
                }
                docs += ')';
                writeDocsString(docs);
            }
            myWriter.output('/// </param>\n');
        }
    }
}

function writeDocsReturn(method) {
    if (Utils.isNullOrWhitespace(method.return_desc) == false) {
        myWriter.output('/// <return>\n');
        writeDocsString(method.return_desc);
        myWriter.output('/// </return>\n');
    }
}

function writeDocsExamples(examples) {
    var csExamples = examples.filter(d => d.platform == 'C#' || d.platform == null)
    for (const csExample of csExamples) {
        if (Utils.isNullOrWhitespace(csExample.code) == false || Utils.isNullOrWhitespace(csExample.description) == false) {
            myWriter.output('/// <example>\n');
            if (Utils.isNullOrWhitespace(csExample.description) == false)
                writeDocsString(csExample.description);
            if (Utils.isNullOrWhitespace(csExample.code) == false)
                writeDocsString('<code>' + csExample.code + '</code>');
            myWriter.output('/// </example>\n');
        }
    }
}

function writeDocsVersion(method) {
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => d.platform == null)
    if (impl && Utils.isNullOrWhitespace(impl.version) == false)
        myWriter.output('/// <version>' + impl.version + '</version>\n');
}

function writeDocsString(txt) {
    if (Utils.isNullOrWhitespace(txt) == false) {
        myWriter.output('/// ' + txt.split('\n').join('\n' + '/// ') + '\n');
    }
}

function writeMethod(method) {
    if (Utils.isNullOrWhitespace(method.name) || Utils.isNullOrWhitespace(method.return_type)) {
        myWriter.output('#warning Failed processing method ' + method.name + ' : method has no name or return type.\n');
        return;
    }
    // find the best implementation
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => Utils.isNullOrWhitespace(d.platform))
    if (impl == null) {
        myWriter.output('#warning No implementation defined for method ' + method.name + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    const nativeMethodName = Utils.GetNativeMethodName(method.name);
    const rubyMethodType = method.return_type;
    const nativeMethodType = Utils.GetNativeType(rubyMethodType);
    const hasNativeImplementation = impl.type == 'Native' && Utils.isNullOrWhitespace(impl.data);

    // if its already implmented in the native libraries then just make a note of it and move on
    if (hasNativeImplementation) {
        myWriter.output('// Expecting native implementation\n');
        myWriter.output('/*\n');
    }

    writeDocsSummary(method.descriptions);
    writeDocsArgs(method.arguments);
    writeDocsReturn(method);
    writeDocsExamples(method.examples);
    writeDocsVersion(method);
    myWriter.output('[FakerMethod("' + method.name + '")]\n');
    if (method.private == true)
        myWriter.output('internal ');
    else
        myWriter.output('public ');
    myWriter.output(nativeMethodType + ' ' + nativeMethodName + '(' + getArgs(method.arguments) + ')\n');
    if (hasNativeImplementation) {
        myWriter.output('*/\n');
        return;
    }

    myWriter.output('{\n');
    myWriter.outputIndentPush();
    for (const arg of method.arguments) {
        // write out the code that will initialize default values that can not be initialized in the prototype
        var initSrc = getArgInitalization(arg);
        if (initSrc)
            myWriter.output(initSrc + '\n');
    }

    switch (impl.type) {
        case 'Native':
            if (impl.platform != 'C#') {
                myWriter.output('#warning No native implmentation for this method - needs porting\n');
                myWriter.output('throw new NotSupportedException("Mehtod needs porting to C#");\n');
            } else {
                myWriter.output(impl.data.replaceAll('\r\n', '\n') + '\n');
            }
            break;
        case 'Resolve':
        case 'Expression':
            var implData = impl.data;
            for (const arg of method.arguments) {
                var rubyArgName = arg.name;
                var nativeArgName = Utils.GetNativeArgName(rubyArgName);
                implData = implData.replaceAll('#{' + rubyArgName + '}', '" + ' + nativeArgName + ' + "');
            }

            var expr;
            if (impl.type == 'Expression')
                expr = 'this.EvaluateExpression("' + implData + '")';
            else
                expr = 'this.ResolveYamlValue("' + implData + '")';

            if (impl.charSubst == true)
                expr = 'this.Letterify(' + expr + ')';
            if (impl.digitSubst == true)
                expr = 'this.Numerify(' + expr + ')';
            if (impl.translate == true)
                expr = 'this.Translate(' + expr + ')';

            expr = Utils.GetCastStringToCode(expr, rubyMethodType);
            myWriter.output('return ' + expr + ';\n');
            break;
        default:
            myWriter.output('#error Unknown implemetation type : ' + impl.type + '\n');
            break;
    }
    myWriter.outputIndentPop();
    myWriter.output('}\n');
}

function getArgs(args) {
    return args.map(a => getArg(a)).join(', ');
}
function getArg(arg) {
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argNativeType = Utils.GetNativeType(arg.type);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var argDefaultDecl = '';

    if (Utils.isNullOrWhitespace(arg.default) == false) {
        if (arg.default == 'nil') {
            // String Fn(ARG_TYPE? arg = null)
            argDefaultDecl = 'null';
            argNativeType += '?';
        }
        else if (argNativeType == 'string' && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = 'DEFAULT_VALUE')
            argDefaultDecl = '"' + Utils.getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + '"';
        }
        else if (canDefault == false) {
            // Implemented within the function
            // String Fn(ARG_TYPE? arg = null){
            //  arg ??= DEFAULT_VALUE;
            // }
            argDefaultDecl = 'null';
            argNativeType += '?';
        }
        else {
            // String Fn(ARG_TYPE arg = DEFAULT_VALUE)
            argDefaultDecl = arg.default;
        }
        argDefaultDecl = ' = ' + argDefaultDecl;
    }

    return argNativeType + ' ' + argNativeName + argDefaultDecl;
}
function getArgInitalization(arg) {
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argNativeType = Utils.GetNativeType(arg.type);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var argDefault = arg.default;

    if (Utils.isNullOrWhitespace(argDefault) == false && canDefault == false) {
        // if (argNativeType == 'IntegerRange')
        //     return argNativeName + ' ??= IntegerRange.Parse(\"' + Utils.getNativeEscapedString(argDefault) + '\");';
        // else 
        if (argNativeType.startsWith('UNKNOWN_'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + Utils.getNativeEscapedString(argDefault) + '");';
        else if (argNativeType.startsWith('List<'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + Utils.getNativeEscapedString(argDefault) + '");';
        else
            throw new Error('Missing initilization code for ' + argNativeType);
    }
    return null;
}












