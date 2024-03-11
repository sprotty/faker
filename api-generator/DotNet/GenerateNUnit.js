const { Writer, Utils, config } = require('./GeneratorCommon.js');
const { exit } = require('node:process');

var myWriter = new Writer();

myWriter.output("using System.Diagnostics.CodeAnalysis;\n");
myWriter.output("using System.Globalization;\n");
myWriter.output("\n");
myWriter.output("namespace FakerNet.NUnit\n");
myWriter.output("{\n");
myWriter.outputIndentPush();


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
myWriter.outputIndentPop();
myWriter.output("}\n");

myWriter.write('./FakerNet.NUnit/FakerGeneratorsTests.cs');

exit(0);

function generateClass(scope, cls) {
    const qClassName = (scope.length == 0) ? cls.name : (scope + "." + cls.name);

    myWriter.output('[TestClass]\n');
    myWriter.output('public class Test_' + qClassName.replaceAll('.', '_') + ' : FakerNUnitBase\n');
    myWriter.output('{\n');
    myWriter.outputIndentPush();

    for (const method of cls.methods ?? [])
        writeMethod(qClassName, method);

    myWriter.outputIndentPop();
    myWriter.output('}\n');
    myWriter.output('\n');

    for (const clsChild of cls.classes ?? [])
        generateClass(qClassName, clsChild);
}

function writeMethod(qClassName, method) {

    // Can't cope with required arguments
    if (method.arguments.some(a => Utils.isNullOrWhitespace(a.default))) {
        myWriter.output('// Method : ' + method.name + ' : Can not generated test for method with required arguments.\n');
        return;
    }

    if (Utils.isNullOrWhitespace(method.name) || Utils.isNullOrWhitespace(method.return_type)) {
        myWriter.output('#warning Failed processing method ' + method.name + '\n');
        return;
    }
    // find the best implementation
    var impl = method.implementations.find(d => d.platform == 'C#') ?? method.implementations.find(d => d.platform == null)
    if (impl == null) {
        myWriter.output('#warning No implementation defined for method ' + method.name + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    const nativeMethodName = Utils.GetNativeMethodName(method.name);
    const rubyMethodType = method.return_type;
    const nativeMethodType = Utils.GetNativeType(rubyMethodType);

    // if its already implmented in the native libraries then just make a note of it and move on
    if (impl.type == 'NativeFunction' && Utils.isNullOrWhitespace(impl.data)) {
        myWriter.output('// Expecting native implmentation of ' + method.name + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    myWriter.output('[TestMethod()]\n');
    myWriter.output('public void Test_' + nativeMethodName + '_Execute()\n');
    myWriter.output('{\n');
    myWriter.outputIndentPush();
    {
        myWriter.output('FakerForEveryLocale<' + nativeMethodType + '>(faker => faker.' + qClassName + '.' + nativeMethodName + '());\n');
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
    var argDefaultDecl = "";

    if (Utils.isNullOrWhitespace(arg.default) == false) {
        if (arg.default == "nil") {
            // String Fn(ARG_TYPE? arg = null)
            argDefaultDecl = "null";
            argNativeType += "?";
        }
        else if (argNativeType == "string" && arg.default.startsWith("'") && arg.default.endsWith("'")) {
            // String Fn(ARG_TYPE arg = "DEFAULT_VALUE")
            argDefaultDecl = "\"" + Utils.getNativeEscapedString(arg.default.substring(1, arg.default.length - 1)) + "\"";
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
    var argNativeName = Utils.GetNativeArgName(arg.name);
    var argNativeType = Utils.GetNativeType(arg.type);
    var canDefault = Utils.CanDefaultValueType(arg.type);
    var argDefault = arg.default;

    if (Utils.isNullOrWhitespace(argDefault) == false && canDefault == false) {
        if (argNativeType == 'IntegerRange')
            return argNativeName + ' ??= IntegerRange.Parse(\"' + Utils.getNativeEscapedString(argDefault) + '\");';
        else if (argNativeType.startsWith("UNKNOWN_"))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse(\"' + Utils.getNativeEscapedString(argDefault) + '\");';
        else if (argNativeType.startsWith("List<"))
            return '// ' + argNativeName + ' ??= ' + argNativeType + '.Parse(\"' + Utils.getNativeEscapedString(argDefault) + '\");';
        else
            throw new Error('Missing initilization code for ' + argNativeType);
    }
    return null;
}
