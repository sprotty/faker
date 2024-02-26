const fs = require('node:fs');
const config = require('../faker_api_metadata.json');
const { exit } = require('node:process');
var indent = 0;
var indentRequired = true;
var output_data = [];
var keywords = ['bool', 'byte', 'sbyte', 'short', 'ushort', 'int', 'uint', 'long', 'ulong', 'double', 'float', 'decimal',
    'string', 'char', 'void', 'object', 'typeof', 'sizeof', 'null', 'true', 'false', 'if', 'else', 'while', 'for', 'foreach', 'do', 'switch',
    'case', 'default', 'lock', 'try', 'throw', 'catch', 'finally', 'goto', 'break', 'continue', 'return', 'public', 'private', 'internal',
    'protected', 'static', 'readonly', 'sealed', 'const', 'fixed', 'stackalloc', 'volatile', 'new', 'override', 'abstract', 'virtual',
    'event', 'extern', 'ref', 'out', 'in', 'is', 'as', 'params', '__arglist', '__makeref', '__reftype', '__refvalue', 'this', 'base',
    'namespace', 'using', 'class', 'struct', 'interface', 'enum', 'delegate', 'checked', 'unchecked', 'unsafe', 'operator', 'implicit', 'explicit'
];

output('using System.Diagnostics.CodeAnalysis;\n');
output('using System.Globalization;\n');
output('using System.CodeDom.Compiler;\n');
output('using System.ComponentModel.DataAnnotations;\n');
output('using System.Text;\n');
output('using System.Diagnostics;\n');
output('\n');
output('namespace FakerNet\n');
output('{\n');
outputIndentPush();
{
    for (const enm of config.enums) {
        output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
        output('/// <summary>\n');
        writeDocsString(enm.description);
        output('/// </summary>\n');
        output('public enum ' + GetNativeEnumName(enm.name) + '\n');
        output('{\n');
        outputIndentPush();
        {
            for (const enmVal of enm.values) {
                if (isNullOrWhitespace(enmVal.description) == false) {
                    output('/// <summary>\n');
                    writeDocsString(enmVal.description);
                    output('/// </summary>\n');
                }
                output('[Display(Name = "' + (enmVal.value ?? enmVal.name) + '")]\n');
                output(GetNativeEnumValue(enmVal.name) + ',\n');
            }
        }
        outputIndentPop();
        output('}\n');
        output('\n');
    }

    for (const cls of config.classes) {
        generateClass(cls);
    }

    output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
    output('partial class Faker\n');
    output('{\n');
    outputIndentPush();
    {
        for (const cls of config.classes) {
            output('[FakerMethod("' + cls.name + '")]\n');
            output('public ' + cls.name + 'Generator ' + cls.name + ' { get; }\n');
        }
        output('\n');
        output('public Faker(CultureInfo locale, Random random)\n');
        output('{\n');
        outputIndentPush();
        {
            output('this.Random = random;\n');
            output('\n');
            output('// Create the Faker Generators\n');
            for (const cls of config.classes) {
                output(cls.name + ' = new ' + cls.name + 'Generator(this);\n');
            }
            output('\n');
            output('Init(locale);\n');
        }
        outputIndentPop();
        output('}\n');
    }
    outputIndentPop();
    output('}\n');
}
outputIndentPop();
output('}\n');

fs.writeFileSync('./faker_api_metadata.cs', output_data.join(''));

exit(0);

function generateClass(cls) {
    writeDocsSummary(cls.descriptions);
    output('[GeneratedCode("Faker Code Generator", "1.0.0.0")]\n');
    output('[FakerGenerator("' + cls.name + '")]\n');
    output('public partial class ' + cls.name + 'Generator : GeneratorBase\n');
    output('{\n');
    outputIndentPush();
    {
        for (const nestedCls of cls.classes) {
            output('[FakerMethod("' + nestedCls.name + '")]\n');
            output('public ' + nestedCls.name + 'Generator ' + nestedCls.name + ' { get; }\n');
        }

        output('internal ' + cls.name + 'Generator(Faker faker)\n');
        output('         : base(faker)\n');
        output('{\n');
        outputIndentPush();
        {
            for (const nestedCls of cls.classes) {
                output(nestedCls.name + ' = new ' + nestedCls.name + 'Generator(this.Faker);\n');
            }
        }
        outputIndentPop();
        output('}\n');
        output('\n');

        for (const clsChild of cls.classes)
            generateClass(clsChild);

        for (const method of cls.methods)
            writeMethod(method);
    }
    outputIndentPop();
    output('}\n');
    output('\n');
}

function writeDocsSummary(descriptions) {
    var desc = descriptions.find(d => d.platform == 'C#') ?? descriptions.find(d => d.platform == null)
    if (desc && isNullOrWhitespace(desc.text) == false) {
        output('/// <summary>\n');
        writeDocsString(desc.text);
        output('/// </summary>\n');
    }
}

function writeDocsArgs(args) {
    for (const arg of args) {
        var desc = arg.descriptions.find(d => d.platform == 'C#') ?? arg.descriptions.find(d => d.platform == null)

        output('/// <param name="' + GetNativeArgName(arg.name) + '">\n');
        if (desc && isNullOrWhitespace(desc.text) == false) {
            writeDocsString(desc.text);
        }
        if (isNullOrWhitespace(arg.default) == false)
            writeDocsString('(default value "' + arg.default + '")');
        output('/// </param>\n');
    }
}
function writeDocsReturn(method) {
    if (isNullOrWhitespace(method.return_desc) == false) {
        output('/// <return>\n');
        writeDocsString(method.return_desc);
        output('/// </return>\n');
    }
}

function writeDocsExamples(exanples) {
    var example = exanples.find(d => d.platform == 'C#') ?? exanples.find(d => d.platform == null)
    if (example && (isNullOrWhitespace(example.code) == false || isNullOrWhitespace(example.description) == false)) {
        output('/// <example>\n');
        if (isNullOrWhitespace(example.description) == false)
            writeDocsString(example.description);
        if (isNullOrWhitespace(example.code) == false)
            writeDocsString('<code>' + example.code + '</code>');
        output('/// </example>\n');
    }
}

function writeDocsVersion(method) {
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => d.platform == null)
    if (impl && isNullOrWhitespace(impl.version) == false)
        output('/// <version>' + impl.version + '</version>\n');
}

function writeDocsString(txt) {
    if (isNullOrWhitespace(txt) == false) {
        output('/// ' + txt.split('\n').join('\n' + '/// ') + '\n');
    }
}

function writeMethod(method) {
    if (isNullOrWhitespace(method.name) || isNullOrWhitespace(method.return_type)) {
        output('#warning Failed processing method ' + method.name + '\n');
        return;
    }
    // find the best implementation
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => d.platform == null)
    if (impl == null) {
        output('#warning No implementation defined for method ' + method.name + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    const nativeMethodName = GetNativeMethodName(method.name);
    const rubyMethodType = method.return_type;
    const nativeMethodType = GetNativeType(rubyMethodType);

    // if its already implmented in the native libraries then just make a note of it and move on
    if (impl.type == 'Native' && isNullOrWhitespace(impl.data)) {
        output('// Expecting native implementation of\n');
        output('//      public ' + nativeMethodType + ' ' + nativeMethodName + '(' + getArgs(method.arguments) + ')\n');
        return;
    }

    writeDocsSummary(method.descriptions);
    writeDocsArgs(method.arguments);
    writeDocsReturn(method);
    writeDocsExamples(method.examples);
    writeDocsVersion(method);
    output('[FakerMethod("' + method.name + '")]\n');
    output('public ' + nativeMethodType + ' ' + nativeMethodName + '(' + getArgs(method.arguments) + ')\n');
    output('{\n');
    outputIndentPush();
    for (const arg of method.arguments) {
        // write out the code that will initialize default values that can not be initialized in the prototype
        var initSrc = getArgInitalization(arg);
        if (initSrc)
            output(initSrc + '\n');
    }

    switch (impl.type) {
        case 'Native':
            if (impl.platform != 'C#') {
                output('#warning No native implmentation for this method - needs porting\n');
                output('throw new NotSupportedException("Mehtod needs porting to C#");\n');
            } else {
                output(impl.data.replaceAll('\r\n', '\n') + '\n');
            }
            break;
        case 'Resolve':
        case 'Expression':
            var implData = impl.data;
            for (const arg of method.arguments) {
                var rubyArgName = arg.name;
                var nativeArgName = GetNativeArgName(rubyArgName);
                implData = implData.replaceAll('#{' + rubyArgName + '}', '" + ' + nativeArgName + ' + "');
            }

            var expr;
            if (impl.type == 'Expression')
                expr = 'this.EvaluateExpression("' + implData + '", this)';
            else
                expr = 'this.ResolveYamlValue("' + implData + '", this)';

            if (impl.charSubst == true)
                expr = 'this.Letterify(' + expr + ')';
            if (impl.digitSubst == true)
                expr = 'this.Numerify(' + expr + ')';
            if (impl.translate == true)
                expr = 'this.Translate(' + expr + ')';

            expr = GetCastStringToCode(expr, rubyMethodType);
            output('return ' + expr + ';\n');
            break;
        default:
            output('#error Unknown implemetation type : ' + impl.type + '\n');
            break;
    }
    outputIndentPop();
    output('}\n');
}

function getArgs(args) {
    return args.map(a => getArg(a)).join(', ');
}
function getArg(arg) {
    var argNativeName = GetNativeArgName(arg.name);
    var argNativeType = GetNativeType(arg.type);
    var canDefault = CanDefaultValueType(arg.type);
    var argDefaultDecl = '';

    if (isNullOrWhitespace(arg.default) == false) {
        if (arg.default == 'nil') {
            // String Fn(ARG_TYPE? arg = null)
            argDefaultDecl = 'null';
            argNativeType += '?';
        }
        else if (argNativeType == 'string' && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = 'DEFAULT_VALUE')
            argDefaultDecl = '"' + getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + '"';
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
    var argNativeName = GetNativeArgName(arg.name);
    var argNativeType = GetNativeType(arg.type);
    var canDefault = CanDefaultValueType(arg.type);
    var argDefault = arg.default;

    if (isNullOrWhitespace(argDefault) == false && canDefault == false) {
        if (argNativeType == 'IntegerRange')
            return argNativeName + ' ??= IntegerRange.Parse(\"' + getNativeEscapedString(argDefault) + '\");';
        else if (argNativeType.startsWith('UNKNOWN_'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + getNativeEscapedString(argDefault) + '");';
        else if (argNativeType.startsWith('List<'))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse("' + getNativeEscapedString(argDefault) + '");';
        else
            throw new Error('Missing initilization code for ' + argNativeType);
    }
    return null;
}



function GetNativeArgName(rubyName) {
    var nameBits = rubyName.split('_');
    var nativeName = nameBits.shift().toLowerCase() + nameBits.map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
    if (keywords.includes(nativeName))
        nativeName = '@' + nativeName;
    return nativeName;
}

function GetNativeMethodName(rubyName) {
    return rubyName.split('_').map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
}

function GetNativeEnumName(rubyName) {
    return rubyName;
}
function GetNativeEnumValue(rubyName) {
    return rubyName.split('_').map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
}



function GetNativeType(rubyType) {
    if (rubyType.startsWith('Array<') && rubyType.endsWith('>'))
        return 'List<' + GetNativeType(rubyType.substring(6, rubyType.length - 1)) + '>';
    else if (rubyType == 'Boolean')
        return 'bool';
    else if (rubyType == 'Date')
        return 'DateOnly';
    else if (rubyType == 'Float')
        return 'double';
    else if (rubyType == 'Integer')
        return 'long';
    else if (rubyType == 'IntegerRange')
        return 'IntegerRange';
    else if (rubyType == 'String')
        return 'string';
    else if (rubyType == '')
        return 'String'; // Assume string???
    else if (config.enums.some(e => e.name == rubyType))
        return GetNativeEnumName(rubyType); // its an enumeration
    else
        return 'UNKNOWN_' + rubyType;
}
function CanDefaultValueType(rubyType) {
    if (rubyType.startsWith('Array<') && rubyType.endsWith('>'))
        return false;
    else if (rubyType == 'Boolean')
        return true;
    else if (rubyType == 'Date')
        return false;
    else if (rubyType == 'Float')
        return true;
    else if (rubyType == 'Integer')
        return true;
    else if (rubyType == 'IntegerRange')
        return false;
    else if (rubyType == 'String')
        return true;
    else if (rubyType == '')
        return true; // Assume string???
    else if (config.enums.some(e => e.name == rubyType))
        return true; // its an enumeration
    else
        return false;
}

function GetCastStringToCode(strExpr, rubyType) {
    if (rubyType.startsWith('Array<') && rubyType.endsWith('>')) {
        var arrayType = rubyType.substring(6, rubyType.length - 1);
        var castValue = GetCastStringToCode('item', arrayType);

        return strExpr + '.Split(\',\').Select(item => ' + castValue + ').ToList()';
    }
    else if (rubyType == 'Boolean')
        return 'bool.Parse(' + strExpr + ')';
    else if (rubyType == 'Date')
        return 'DateOnly.Parse(' + strExpr + ')';
    else if (rubyType == 'Float')
        return 'double.Parse(' + strExpr + ')';
    else if (rubyType == 'Integer')
        return 'long.Parse(' + strExpr + ')';
    else if (rubyType == 'IntegerRange')
        return 'IntegerRange.Parse(' + strExpr + ')';
    else if (rubyType == 'String')
        return strExpr;
    else if (config.enums.some(e => e.name == rubyType))
        return 'Enum.Parse<' + GetNativeEnumName(rubyType) + '>(' + strExpr + ')'; // its an enumeration    
    //	else if (rubyType == '')
    //		return strExpr; // Assume string???
    else
        throw new Error('Unknown type ' + rubyType);
}

function isNullOrWhitespace(input) {
    return !input || !input.trim();
}

function getNativeEscapedString(txt) {
    return txt.replaceAll('\\', '\\\\').replaceAll('"', '\\"');
}


function output(txt) {
    var lines = txt.split('\n');

    if (indentRequired)
        output_internal(' '.repeat(indent));
    indentRequired = false;

    if (lines.length == 1) {
        // no EOL
        output_internal(lines[0]);
    }
    else {
        for (let index = 0; index < lines.length - 1; index++) {
            if (indentRequired)
                output_internal(' '.repeat(indent));
            output_internal(lines[index] + '\n');
            indentRequired = true;
        }
        // last line (no EOL after it)
        const lastLine = lines[lines.length - 1];
        if (lastLine.length > 0) {
            if (indentRequired)
                output_internal(' '.repeat(indent));
            output_internal(lines[lines.length - 1]);
            indentRequired = false;
        }
    }
}
function output_internal(txt) {
    process.stdout.write(txt);
    output_data.push(txt);
}



function outputIndentPush() {
    indent += 4;
}
function outputIndentPop() {
    indent -= 4;
}
