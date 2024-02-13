const config = require('../faker_api_metadata.json');
var indent = 0;
var indentRequired = true;

output("start");
output("end\n");
output("new");
output("1\n2");

output("using System.Diagnostics.CodeAnalysis;\n");
output("using System.Globalization;\n");
output("\n");
output("namespace FakerNet\n");
output("{\n");
outputIndentPush();

for (const cls of config.classes) {
    generateClass(cls);
}
outputIndentPop();
output("}\n");

function generateClass(cls) {
    writeDocsSummary(cls.descriptions);
    output('public class ' + cls.name + 'Generator\n');
    output('{\n');
    outputIndentPush();
    output('private Faker _faker;\n');
    output('\n');
    output('internal ' + cls.name + 'Generator(Faker faker)\n');
    output('{\n');
    output('    _faker = faker;\n');
    output('}\n');
    output('\n');

    for (const clsChild of cls.classes)
        generateClass(clsChild);

    for (const method of cls.methods)
        writeMethod(method);

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

    const nativeMethodName = GetNativeMethodName(method.name);
    const nativeMethodType = GetNativeType(method.return_type);

    writeDocsSummary(method.descriptions);
////    writeDocsArgs(method.arguments);
    writeDocsExamples(method.examples);
    output('[FakerMethod("' + method.name + '")]\n');
    output('public ' + nativeMethodType + ' ' + nativeMethodName);
    // <#=GetMethodArgDocs(xMethod)#>
////    writeArgs(method.arguments);
    output('\n');
    // public <#=methodType#> <#=methodName#>(<#=GetMethodArgs(xMethod)#>)
    // {
    // <#=GetMethodDefaultInits(xMethod)#><#+		

    //     string implType =xMethod.Attribute("implType")?.Value??"NONE";


}

function GetNativeMethodName(name) {
    return name;
}

function GetNativeType(type) {
    return type;
}


function isNullOrWhitespace(input) {
    return !input || !input.trim();
}



function output(txt) {
    var lines = txt.split('\n');

    if (indentRequired)
        process.stdout.write(' '.repeat(indent));
    indentRequired = false;

    if (lines.length == 1) {
        // no EOL
        process.stdout.write(lines[0]);
    }
    else {
        for (let index = 0; index < lines.length - 1; index++) {
            if (indentRequired)
                process.stdout.write(' '.repeat(indent));
            process.stdout.write(lines[index] + '\n');
            indentRequired = true;
        }
        // last line (no EOL after it)
        if (indentRequired)
            process.stdout.write(' '.repeat(indent));
        process.stdout.write(lines[lines.length-1]);
        indentRequired = false;
    }
}


function outputIndentPush() {
    indent += 4;
}
function outputIndentPop() {
    indent -= 4;
}
