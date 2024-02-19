const fs = require('node:fs');
const config = require('../faker_api_metadata.json');
const { exit } = require('node:process');
var indent = 0;
var indentRequired = true;
var output_data = [];

output("module Faker\n");
outputIndentPush();
for (const cls of config.classes) {
    generateClass(cls);
}
outputIndentPop();
output("end\n");

fs.writeFileSync("./faker_api_metadata.rb", output_data.join(''));

exit(0);

function generateClass(cls) {
    writeDocsSummary(cls.descriptions);
    output('class ' + cls.name);
    if (cls.classes.length == 0) {
        output(' < Base\n');
        outputIndentPush();
        output('class << self');
    }
    output('\n');
    outputIndentPush();

    for (const clsChild of cls.classes)
        generateClass(clsChild);

    for (const method of cls.methods)
        writeMethod(method);

    if (cls.classes.length == 0) {
        output('end\n');
        outputIndentPop();
    }
    output('end\n');
    outputIndentPop();
}

function writeDocsSummary(descriptions) {
    var desc = descriptions.find(d => d.platform == 'C#') ?? descriptions.find(d => d.platform == null)
    if (desc && isNullOrWhitespace(desc.text) == false) {
        output('##\n');
        writeDocsString(desc.text);
        output('#\n');
    }
}

function writeDocsExamples(exanples) {
    var example = exanples.find(d => d.platform == 'C#') ?? exanples.find(d => d.platform == null)
    if (example && (isNullOrWhitespace(example.code) == false || isNullOrWhitespace(example.description) == false)) {
        output('# @example\n');
        if (isNullOrWhitespace(example.description) == false)
            writeDocsString(example.description, false, 4);
        if (isNullOrWhitespace(example.code) == false)
            writeDocsString(example.code, false, 4);
        output('#\n');
    }
}

function writeDocsArgs(args) {
    for (const arg of args) {
        var desc = arg.descriptions.find(d => d.platform == 'C#') ?? arg.descriptions.find(d => d.platform == null)

        var doc = '';
        if (desc && isNullOrWhitespace(desc.text) == false) {
            doc += desc.text;
        }
        if (isNullOrWhitespace(arg.default) == false)
            doc += ' (default value "' + arg.default + '")';

        output('# @param ' + arg.name + ' [' + arg.type + ']');
        writeDocsString(doc, true, 2);
        output('#\n');
    }
}

function writeDocsReturn(method) {
    output('# @return [' + method.return_type + ']\n');
    output('#\n');
}

function writeDocsVersion(method) {
    var impl = method.implementations.find(d => d.platform == 'Ruby') ?? method.implementations.find(d => d.platform == null)
    if (impl == null) {
        output('warn  \"No implementation defined for method ' + method.name + '(' + getArgs(method.arguments) + ');\"\n');
        return;
    }

    if (isNullOrWhitespace(impl.version) == false) {
        output('# @faker.version ' + impl.version + '\n');
        output('#\n');
    }
}

function writeDocsString(txt, skipStartHash, docIndent) {
    if (isNullOrWhitespace(txt) == false) {
        if (skipStartHash != true)
            output('#');
        output(' ' + ' '.repeat(docIndent ?? 0) + txt.split('\n').join('\n' + '# ' + ' '.repeat(docIndent ?? 0)) + '\n');
    }
}


function writeMethod(method) {
    if (isNullOrWhitespace(method.name) || isNullOrWhitespace(method.return_type)) {
        output('warn  \"Failed processing method ' + method.name + '\"\n');
        return;
    }
    // find the best implementation
    var impl = method.implementations.find(d => d.platform == 'Ruby') ?? method.implementations.find(d => d.platform == null)
    if (impl == null) {
        output('warn  \"No implementation defined for method ' + method.name + '(' + getArgs(method.arguments) + ');\"\n');
        return;
    }

    const methodName = method.name;
    const methodType = method.return_type;

    // if its already implmented in the native libraries then just make a note of it and move on
    if (impl.type == 'NativeFunction' && isNullOrWhitespace(impl.data)) {
        output('# Expecting native implmentation of ' + rubyMethodName + '(' + getArgs(method.arguments) + ');\n');
        return;
    }

    writeDocsSummary(method.descriptions);
    writeDocsArgs(method.arguments);
    writeDocsReturn(method);
    writeDocsExamples(method.examples);
    writeDocsVersion(method);

    output('def ' + methodName + '(' + getArgs(method.arguments) + ')\n');
    outputIndentPush();

    switch (impl.type) {
        case 'Native':
            if (impl.platform != 'C#') {
                output('#warning No native implmentation for this method - needs porting\n');
                output('throw new NotSupportedException("Mehtod needs porting to C#");\n');
            }
            else {
                output(impl.data);
            }
            break;
        case 'Resolve':
             var expr = 'fetch("' + impl.data + '")';
             if (impl.charSubst == true)
                 expr = '_faker.Letterify(' + expr + ')';
             if (impl.digitSubst == true)
                 expr = '_faker.Numerify(' + expr + ')';
             if (impl.translate == true)
                 expr = '_faker.Translate(' + expr + ')';

            output('return ' + expr + ';\n');
            break;
        case 'Expression':
            var expr = '"' + impl.data + '"';

            if (impl.charSubst == true)
                expr = '_faker.Letterify(' + expr + ')';
            if (impl.digitSubst == true)
                expr = '_faker.Numerify(' + expr + ')';
            if (impl.translate == true)
                expr = '_faker.Translate(' + expr + ')';

            // expr = GetCastStringToCode(expr, methodType);
             output('return ' + expr + ';\n');
            break;
        default:
            output('#error Unknown implemetation type : ' + impl.type + '\n');
            break;
    }
    outputIndentPop();
    output('end\n');
}

function getArgs(args) {
    return args.map(a => getArg(a)).join(', ');
}
function getArg(arg) {
    var argName = arg.name;
    var argDefaultDecl = "";

    if (isNullOrWhitespace(arg.default) == false)
        argDefaultDecl = ": " + arg.default;

    return argName + argDefaultDecl;
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
