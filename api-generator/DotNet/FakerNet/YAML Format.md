OK, this is a bit of a mess, basically the YAML and the expressions in the code are RUBY.
The Ruby `#{SUTFF}` syntax is similar to the C# `$"{STUFF}"` syntax, and that can go into the YAML files.
So our parser needs to do a bit of basic RUBY evaluation to work - this is a bit 80/20 we are not re-writing RUBY
but need some basic functionality make stuff work.

**Naming conventions**
Classes in RUBY are CamelCase (ClashOfClans).
Methods in RUBY are snake_case (city_name).
The maps in the YAML are all snake_case (clash_of_clans)
So if you are looking at a qualified name `Address.city` then this is a call to `city()` on the RUBY class `Faker.Address`.
So if you are looking at a qualified name `address.city` then this is a lookup into the YAML files with the path `[LOCALE].faker.address.city`.

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

Escaping in a RUBY string is done with the `\` char see https://blog.appsignal.com/2016/12/21/ruby-magic-escaping-in-ruby.html.

So a function literal would look like this `\#{name}`

Not 100%, but this probably follows in the YAML as well - Currently escaping is not supported in C# in either the YAML or RUBY expressions - this doesn't seem to be a problem....YET.....

On the whole if stuff is processed RegEx, Function Calls, Numbers, Literals then it seems to work OK.

