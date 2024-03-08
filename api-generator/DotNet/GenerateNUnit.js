const fs = require('node:fs');
const config = require('../faker_api_metadata.json');
const { exit } = require('node:process');
var indent = 0;
var indentRequired = true;
var output_data = [];

output("using System.Diagnostics.CodeAnalysis;\n");
output("using System.Globalization;\n");
output("\n");
output("namespace FakerNet.NUnit\n");
output("{\n");
outputIndentPush();


/*


namespace FakerNet.NUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
 */
for (const cls of config.classes) {
    generateClass('', cls);
}
outputIndentPop();
output("}\n");

fs.writeFileSync("./FakerNet.NUnit/FakerGeneratorsTests.cs", output_data.join('').replaceAll('\r', ''));

exit(0);

function generateClass(scope, cls) {
    const qClassName = (scope.length == 0) ? cls.name : (scope + "." + cls.name);

    output('[TestClass]\n');
    output('public class Test_' + qClassName.replaceAll('.', '_') + ' : FakerNUnitBase\n');
    output('{\n');
    outputIndentPush();

    for (const method of cls.methods??[])
        writeMethod(qClassName, method);

    outputIndentPop();
    output('}\n');
    output('\n');

    for (const clsChild of cls.classes??[])
        generateClass(qClassName, clsChild);
}

function writeMethod(qClassName, method) {

    // Can't cope with required arguments
    if (method.arguments.some(a => isNullOrWhitespace(a.default))) {
        output('// Method : ' + method.name + ' : Can not generated test for method with required arguments.\n');
        return;
    }

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
    if (impl.type == 'NativeFunction' && isNullOrWhitespace(impl.data)) {
        output('// Expecting native implmentation of ' + method.name + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    output('[TestMethod()]\n');
    output('public void Test_' + nativeMethodName + '_Execute()\n');
    output('{\n');
    outputIndentPush();
    output('FakerForEveryLocale<' + nativeMethodType + '>(faker => faker.' + qClassName + '.' + nativeMethodName + '());\n');

    // for (const arg of method.arguments) {
    //     // write out the code that will initialize default values that can not be initialized in the prototype
    //     var initSrc = getArgInitalization(arg);
    //     if (initSrc)
    //         output(initSrc + '\n');
    // }

    // switch (impl.type) {
    //     case 'Native':
    //         if (impl.platform != 'C#') {
    //             output('#warning No native implmentation for this method - needs porting\n');
    //             output('throw new NotSupportedException("Mehtod needs porting to C#");\n');
    //         }
    //         else {
    //             output(impl.data);
    //         }
    //         break;
    //     case 'Resolve':
    //     case 'Expression':
    //         var implData = impl.data;
    //         for (const arg of method.arguments) {
    //             var rubyArgName = arg.name;
    //             var nativeArgName = GetNativeArgName(rubyArgName);
    //             implData = implData.replaceAll('#{' + rubyArgName + '}', '" + ' + nativeArgName + ' + "');
    //         }

    //         var expr;
    //         if (impl.type == 'Expression')
    //             expr = '_faker.Expression("' + implData + '", this)';
    //         else
    //             expr = '_faker.Resolve("' + implData + '", this)';

    //         if (impl.charSubst == true)
    //             expr = '_faker.Letterify(' + expr + ')';
    //         if (impl.digitSubst == true)
    //             expr = '_faker.Numerify(' + expr + ')';
    //         if (impl.translate == true)
    //             expr = '_faker.Translate(' + expr + ')';

    //         expr = GetCastStringToCode(expr, rubyMethodType);
    //         output('return ' + expr + ';\n');
    //         break;
    //     default:
    //         output('#error Unknown implemetation type : ' + impl.type + '\n');
    //         break;
    // }
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
    var argDefaultDecl = "";

    if (isNullOrWhitespace(arg.default) == false) {
        if (arg.default == "nil") {
            // String Fn(ARG_TYPE? arg = null)
            argDefaultDecl = "null";
            argNativeType += "?";
        }
        else if (argNativeType == "string" && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = "DEFAULT_VALUE")
            argDefaultDecl = "\"" + getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + "\"";
        }
        else if (canDefault == false) {
            // Implemented within the function
            // String Fn(ARG_TYPE? arg = null){
            //  arg ??= DEFAULT_VALUE;
            // }
            argDefaultDecl = "null";
            argNativeType += "?";
        }
        else {
            // String Fn(ARG_TYPE arg = DEFAULT_VALUE)
            argDefaultDecl = arg.default;
        }
        argDefaultDecl = " = " + argDefaultDecl;
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
        else if (argNativeType.startsWith("UNKNOWN_"))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse(\"' + getNativeEscapedString(argDefault) + '\");';
        else if (argNativeType.startsWith("List<"))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse(\"' + getNativeEscapedString(argDefault) + '\");';
        else
            throw new Error('Missing initilization code for ' + argNativeType);
    }
    return null;
}



function GetNativeArgName(rubyName) {
    var nameBits = rubyName.split('_');
    return nameBits.shift().toLowerCase() + nameBits.map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
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
    if (rubyType.startsWith("Array<") && rubyType.endsWith(">"))
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
        return true; // its an enumeration    else
    return false;
}

function GetCastStringToCode(strExpr, rubyType) {
    if (rubyType.startsWith('Array<') && rubyType.endsWith('>')) {
        var arrayType = rubyType.substring(6, rubyType.length - 1);
        var castValue = GetCastStringToCode('item', arrayType);

        return 'String.Split(",", strExpr).Select(item => ' + castValue + ').ToList()';
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
    // process.stdout.write(txt);
    output_data.push(txt);
}



function outputIndentPush() {
    indent += 4;
}
function outputIndentPop() {
    indent -= 4;
}
