const fs = require('node:fs');
const config = require('../faker_api_metadata.json');

config.classes = config.classes.filter((cls) => cls.exclude_cs != true);
config.classes.forEach(cls => cls.classes = cls.classes.filter((clsSub) => clsSub.exclude_cs != true));
config.classes.forEach((cls) =>
    cls.methods = cls.methods.filter(m =>
        m.exclude_cs != true));
config.classes.forEach(cls =>
    cls.classes.forEach(clsSub =>
        clsSub.methods = clsSub.methods.filter((m) =>
            m.exclude_cs != true)));

class Writer {
    #indent = 0;
    #indentRequired = true;
    #output_data = [];

    constructor() {
        // this.#indent = 0;
        // this.indentRequired = true;
        // this.output_data = [];
    }

    output(txt) {
        var lines = txt.split('\n');

        if (this.#indentRequired)
            this.#output_internal(' '.repeat(this.#indent));
        this.#indentRequired = false;

        if (lines.length == 1) {
            // no EOL
            this.#output_internal(lines[0]);
        }
        else {
            for (let index = 0; index < lines.length - 1; index++) {
                if (this.#indentRequired)
                    this.#output_internal(' '.repeat(this.#indent));
                this.#output_internal(lines[index] + '\n');
                this.#indentRequired = true;
            }
            // last line (no EOL after it)
            const lastLine = lines[lines.length - 1];
            if (lastLine.length > 0) {
                if (this.#indentRequired)
                    this.#output_internal(' '.repeat(this.#indent));
                this.#output_internal(lines[lines.length - 1]);
                this.#indentRequired = false;
            }
        }
    }

    #output_internal(txt) {
        // process.stdout.write(txt);
        this.#output_data.push(txt);
    }
    outputIndentPush() {
        this.#indent += 4;
    }
    outputIndentPop() {
        this.#indent -= 4;
    }

    write(filename) {
        fs.writeFileSync(filename, this.#output_data.join('').replaceAll('\r', '').replaceAll('\n', '\r\n'));
    }
}



class Utils {
    static #keywords = ['bool', 'byte', 'sbyte', 'short', 'ushort', 'int', 'uint', 'long', 'ulong', 'double', 'float', 'decimal',
        'string', 'char', 'void', 'object', 'typeof', 'sizeof', 'null', 'true', 'false', 'if', 'else', 'while', 'for', 'foreach', 'do', 'switch',
        'case', 'default', 'lock', 'try', 'throw', 'catch', 'finally', 'goto', 'break', 'continue', 'return', 'public', 'private', 'internal',
        'protected', 'static', 'readonly', 'sealed', 'const', 'fixed', 'stackalloc', 'volatile', 'new', 'override', 'abstract', 'virtual',
        'event', 'extern', 'ref', 'out', 'in', 'is', 'as', 'params', '__arglist', '__makeref', '__reftype', '__refvalue', 'this', 'base',
        'namespace', 'using', 'class', 'struct', 'interface', 'enum', 'delegate', 'checked', 'unchecked', 'unsafe', 'operator', 'implicit', 'explicit'
    ];

    static isNullOrWhitespace(input) {
        return !input || !input.trim();
    }

    static getNativeEscapedString(txt) {
        return txt.replaceAll('\\', '\\\\').replaceAll('"', '\\"');
    }

    static GetNativeArgName(rubyName) {
        var nameBits = rubyName.split('_');
        var nativeName = nameBits.shift().toLowerCase() + nameBits.map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
        if (Utils.#keywords.includes(nativeName))
            nativeName = '@' + nativeName;
        return nativeName;
    }

    static GetNativeMethodName(rubyName) {
        return rubyName.split('_').map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
    }

    static GetNativeEnumName(rubyName) {
        return rubyName;
    }
    static GetNativeEnumValue(rubyName) {
        return rubyName.split('_').map(n => n.substring(0, 1).toUpperCase() + n.substring(1)).join('');
    }

    static GetCastStringToCode(strExpr, rubyType) {
        if (rubyType.startsWith('Array<') && rubyType.endsWith('>')) {
            var arrayType = rubyType.substring(6, rubyType.length - 1);
            var castValue = Utils.GetCastStringToCode('item', arrayType);

            return strExpr + '.Split(\',\').Select(item => ' + castValue + ').ToList()';
        }
        else if (rubyType == 'Boolean')
            return 'bool.Parse(' + strExpr + ')';
        else if (rubyType == 'Float')
            return 'double.Parse(' + strExpr + ')';
        else if (rubyType == 'Integer')
            return 'long.Parse(' + strExpr + ')';
        else if (rubyType == 'IntegerRange')
            return 'IntegerRange.Parse(' + strExpr + ')';
        else if (rubyType == 'String')
            return strExpr;
        else if (rubyType == 'Binary')
            return 'BinaryHelper.StringToByteArray(' + strExpr + ')';
        else if (rubyType == 'Encoding')
            return 'Encoding.GetEncoding(' + strExpr + ')';
        else if (rubyType == 'DateTime')
            return 'DateTime.Parse(' + strExpr + ')';
        else if (rubyType == 'Date')
            return 'DateOnly.Parse(' + strExpr + ')';
        else if (rubyType == 'Time')
            return 'TimeOnly.Parse(' + strExpr + ')';
        else if (rubyType == 'DayOfWeek' ||
            config.enums.some(e => e.name == rubyType))
            return 'Enum.Parse<' + Utils.GetNativeEnumName(rubyType) + '>(' + strExpr + ')'; // its an enumeration    
        else
            throw new Error('Unknown type ' + rubyType);
    }

    static GetNativeType(rubyType) {
        if (rubyType.startsWith('Array<') && rubyType.endsWith('>'))
            return 'List<' + Utils.GetNativeType(rubyType.substring(6, rubyType.length - 1)) + '>';
        else if (rubyType == 'Boolean')
            return 'bool';
        else if (rubyType == 'Float')
            return 'double';
        else if (rubyType == 'Integer')
            return 'long';
        else if (rubyType == 'IntegerRange')
            return 'IntegerRange';
        else if (rubyType == 'String')
            return 'string';
        else if (rubyType == 'Binary')
            return 'byte[]';
        else if (rubyType == 'Encoding')
            return 'Encoding';
        else if (rubyType == 'DateTime')
            return 'DateTime';
        else if (rubyType == 'Date')
            return 'DateOnly';
        else if (rubyType == 'Time')
            return 'TimeOnly';
        else if (rubyType == '')
            return 'String'; // Assume string???
        else if (rubyType == 'DayOfWeek')
            return 'DayOfWeek';
        else if (config.enums.some(e => e.name == rubyType))
            return Utils.GetNativeEnumName(rubyType); // its an enumeration
        else
            return 'UNKNOWN_' + rubyType;
    }

    static CanDefaultValueType(rubyType) {
        if (rubyType.startsWith('Array<') && rubyType.endsWith('>'))
            return false;
        else if (rubyType == 'Boolean')
            return true;
        else if (rubyType == 'Float')
            return true;
        else if (rubyType == 'Integer')
            return true;
        else if (rubyType == 'IntegerRange')
            return false;
        else if (rubyType == 'String')
            return true;
        else if (rubyType == 'Binary')
            return true;
        else if (rubyType == 'Encoding')
            return true;
        else if (rubyType == 'DateTime')
            return false;
        else if (rubyType == 'Date')
            return false;
        else if (rubyType == 'Time')
            return false;
        else if (rubyType == 'DayOfWeek')
            return false;
        else if (rubyType == '')
            return true; // Assume string???
        else if (config.enums.some(e => e.name == rubyType))
            return true; // its an enumeration
        else
            return false;
    }
}


module.exports = { Writer, Utils, config };
