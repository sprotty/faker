OK, this is a bit of a mess.

**Regluar Expressions**

A value if a regualar expression if it starts/ends with `/`. 

Note: This only works if its the whole expression, you can't mix and match data/function calls etc.

    /MY_REGEX/

**Function Calls**

Functions can be placed within the value are executed, functions are decorated like this `#{my_function}` 

Calls to `my_function` are executed in the parent scope if they are not qualified

i.e. this will call `city.city_name`

    fr:
      faker:
        address:
          city:
            - "#{city_name}"

Arguments can be included, they seem to be single quoted strings separated by whitespace

    latitude:
      - "#{random_float '-180' '180'}"

**Random Numbers**

`#` gets expanded to a random number 0-9

so `##-##` becomes `12-34`

**Random Letters**

`?` gets expanded to a random number A-Z a-z

so `????` becomes `AbCD`


**Literals**

Everything else is considered to be a literal.

YAML 
- If a string has {}"'[]&$# etc, then it needs quoting
- If the value is yes or no it needs quoting
- I think numbers need quoting

**Escaping and mixing and matching**

This is a problem... Faker has created no explicit rules for espcaping, I think `\` is the escape char for RUBY so a function literal would look like this `\#{name}`.

On the whole if stuff is processed RegEx, Function Calls, Numbers, Literals then it seems to work OK.

