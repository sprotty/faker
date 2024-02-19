module Faker
    class Address < Base
        class << self
            ##
            # Produces a building number.
            #
            # @return [String]
            #
            # @example
            #     csFaker::Address.building_number #=> "7304"
            #
            # @faker.version 1.1.1
            #
            def building_number()
                return fetch("address.building_number");
            end
            ##
            # Produces the name of a city.
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Address.city #=> "Imogeneborough"
            #     				
            #
            def city()
                return fetch("address.city");
            end
            ##
            # Produces the name of a city with the state.
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Address.city_with_state #=> "Northfort, California"
            #     				
            #
            def city_with_state()
                return fetch("address.city");
            end
            ##
            # Produces a city prefix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.city_prefix #=> "Lake"
            #
            def city_prefix()
                return fetch("address.city_prefix");
            end
            ##
            # Produces a city suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.city_suffix #=> "fort"
            #
            def city_suffix()
                return fetch("address.city_suffix");
            end
            ##
            # Produces the name of a community.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.community #=> "University Crossing"
            #
            def community()
                return fetch("address.community");
            end
            ##
            # Produces the name of a country.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.country #=> "French Guiana"
            #
            def country()
                return _faker.Translate(fetch("address.country"));
            end
            ##
            # 
            # 				Produces a country by ISO country code.
            # 				<p>See the [List of ISO 3166 country codes](<a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">en.wikipedia.org/wiki/List_of_ISO_3166_country_codes</a>) on Wikipedia for a full list.</p>
            # 			
            #
            # @param code [String]   An ISO country code. (default value "'US'")
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.country_by_code(code: 'NL') #=> "Netherlands"
            #
            def country_by_code(code: 'US')
                return fetch("address.country_by_code.#{code}");
            end
            ##
            # Produces an ISO 3166 country code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.country_code #=> "IT"
            #
            def country_code()
                return fetch("address.country_code");
            end
            ##
            # Produces a long (alpha-3) ISO 3166 country code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.country_code_long #=> "ITA"
            #
            def country_code_long()
                return fetch("address.country_code_long");
            end
            ##
            # Produces an ISO 3166 country code when given a country name.
            #
            # @param name [String]   
            #   					<p>Country name in snake_case format.</p>
            #   				 (default value "'united_states'")
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.country_name_to_code(name: 'united_states') #=> "US"
            #
            def country_name_to_code(name: 'united_states')
                return fetch("address.country_by_name.#{String.lower '#{name}'}");
            end
            ##
            # Produces a latitude.
            #
            # @return [Float]
            #
            # @example
            #     Faker::Address.latitude #=> -58.17256227443719
            #
            def latitude()
                return "#{random_float '-180..180'}";
            end
            ##
            # Produces a longitude.
            #
            # @return [Float]
            #
            # @example
            #     Faker::Address.longitude #=> -156.65548382095133
            #
            def longitude()
                return "#{random_float '-180..180'}";
            end
            ##
            # Produces a mail box number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.mail_box #=> "PO Box 123"
            #
            def mail_box()
                return _faker.Numerify(_faker.Letterify(fetch("address.mail_box")));
            end
            ##
            # Produces a secondary address.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.secondary_address #=> "Apt. 672"
            #
            def secondary_address()
                return fetch("address.secondary_address");
            end
            ##
            # Produces the name of a state.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.state #=> "California"
            #
            def state()
                return fetch("address.state");
            end
            ##
            # Produces a state abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.state_abbr #=> "AP"
            #
            def state_abbr()
                return fetch("address.state_abbr");
            end
            ##
            # Produces a street address.
            #
            # @param include_secondary [Boolean]   Whether or not to include the secondary address. (default value "false")
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.street_address #=> "282 Kevin Brook"
            #
            def street_address(include_secondary: false)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("address.street_address"))));
            end
            ##
            # Produces a street name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.street_name #=> "Larkin Fork"
            #
            def street_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("address.street_name"))));
            end
            ##
            # Produces a street suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.street_suffix #=> "Street"
            #
            def street_suffix()
                return fetch("address.street_suffix");
            end
            ##
            # Produces the name of a time zone.
            #
            # @return [String]
            #
            # @example
            #     Faker::Address.time_zone #=> "Asia/Yakutsk"
            #
            def time_zone()
                return fetch("address.time_zone");
            end
            ##
            # Produces a Zip Code/Postocde.
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Address.zip_code #=> "58517"
            #     					Faker::Address.zip_code #=> "23285-4905"
            #     					
            #
            def zip_code()
                return _faker.Numerify(_faker.Letterify(fetch("address.postcode")));
            end
            ##
            # Produces a postcode/zipcode.
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Address.zip_code #=> "58517"
            #     				
            #
            def postcode()
                return _faker.Numerify(_faker.Letterify(fetch("address.postcode")));
            end
            end
        end
    class Adjective < Base
        class << self
            ##
            # Produces a negative adjective.
            #
            # @return [String]
            #
            # @example
            #     Faker::Adjective.negative #=> "Creepy"
            #
            def negative()
                return _faker.Translate(fetch("adjective.negative"));
            end
            ##
            # Produces a positive adjective.
            #
            # @return [String]
            #
            # @example
            #     Faker::Adjective.positive #=> "Kind"
            #
            def positive()
                return _faker.Translate(fetch("adjective.positive"));
            end
            end
        end
    class Alphanumeric < Base
        class << self
            ##
            # 
            # 				Produces a random string of alphabetic characters (no digits).
            # 				<p>Produces a random string of alphabetic characters (no digits)</p>
            # 			
            #
            # @param number [Integer]   
            #   					<p>The length of the string to generate</p>
            #   				 (default value "32")
            #
            # @return [String]
            #
            # @example
            #     Faker::Alphanumeric.alpha(number: 10) #=> "zlvubkrwga"
            #
            def alpha(number: 32)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # 
            # 				Produces a random string of alphanumeric characters.
            # 				<p>Produces a random string of alphanumeric characters</p>
            # 			
            #
            # @param number [Integer]   
            #   					<p>The number of characters to generate</p>
            #   				
            #
            # @param min_alpha [Integer]   
            #   					<p>The minimum number of alphabetic to add to the string</p>
            #   				
            #
            # @param min_numeric [Integer]   
            #   					<p>The minimum number of numbers to add to the string</p>
            #   				 (default value "0")
            #
            # @return [String]
            #
            # @example
            #     Faker::Alphanumeric.alphanumeric(number: 10) #=> "3yfq2phxtb"
            #
            def alpha_numeric(number, min_alpha, min_numeric: 0)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Ancient < Base
        class << self
            ##
            # Produces a god from ancient mythology.
            #
            # @return [String]
            #
            # @example
            #     Faker::Ancient.god #=> "Zeus"
            #
            def god()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ancient.god"))));
            end
            ##
            # Produces a hero from ancient mythology.
            #
            # @return [String]
            #
            # @example
            #     Faker::Ancient.hero #=> "Achilles"
            #
            def hero()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ancient.hero"))));
            end
            ##
            # Produces a primordial from ancient mythology.
            #
            # @return [String]
            #
            # @example
            #     Faker::Ancient.primordial #=> "Gaia"
            #
            def primordial()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ancient.primordial"))));
            end
            ##
            # Produces a titan from ancient mythology.
            #
            # @return [String]
            #
            # @example
            #     Faker::Ancient.titan #=> "Atlas"
            #
            def titan()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ancient.titan"))));
            end
            end
        end
    class App < Base
        class << self
            ##
            # Produces the name of an app's author.
            #
            # @return [String]
            #
            # @example
            #     Faker::App.author #=> "Daphne Swift"
            #
            def author()
                return _faker.Numerify(_faker.Letterify(fetch("app.author")));
            end
            ##
            # Produces an app name.
            #
            # @return [String]
            #
            # @example
            #     Faker::App.name #=> "Treeflex"
            #
            def name()
                return _faker.Numerify(_faker.Letterify(fetch("app.name")));
            end
            ##
            # Produces a String representing a semantic version identifier.
            #
            # @param major [IntegerRange]   
            #   					<p>An integer to use or a range to pick the integer from.</p>
            #   				 (default value "1..9")
            #
            # @param minor [IntegerRange]   
            #   					<p>An integer to use or a range to pick the integer from.</p>
            #   				 (default value "1..9")
            #
            # @param patch [IntegerRange]   
            #   					<p>An integer to use or a range to pick the integer from.</p>
            #   				 (default value "1..9")
            #
            # @return [String]
            #
            # @example
            #     Faker::App.semantic_version #=> "3.2.5"
            #
            def semantic_version(major: 1..9, minor: 1..9, patch: 1..9)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a version string.
            #
            # @return [String]
            #
            # @example
            #     Faker::App.version #=> "1.85"
            #
            def version()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("app.version"))));
            end
            end
        end
    class Appliance < Base
        class << self
            ##
            # Produces the name of an appliance brand.
            #
            # @return [String]
            #
            # @example
            #     Faker::Appliance.brand #=> "Bosch"
            #
            def brand()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("appliance.brand"))));
            end
            ##
            # Produces the name of a type of appliance equipment.
            #
            # @return [String]
            #
            # @example
            #     Faker::Appliance.equipment #=> "Appliance plug"
            #
            def equipment()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("appliance.equipment"))));
            end
            end
        end
    class Artist < Base
        class << self
            ##
            # Produces the name of an artist.
            #
            # @return [String]
            #
            # @example
            #     Faker::Artist.name #=> "Michelangelo"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("artist.names"))));
            end
            end
        end
    class Australia < Base
        class << self
            ##
            # 
            # 				Produces an Australian animal.
            # 				<p>Produces an Australian animal</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Australia.animal
            #     					#=> "Dingo"
            #     				
            #
            def animal()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("australia.animals"))));
            end
            ##
            # 
            # 				Produces a location in Australia.
            # 				<p>Produces a location in Australia</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Australia.location
            #     					#=> "Sydney"
            #     				
            #
            def location()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("australia.locations"))));
            end
            ##
            # 
            # 				Produces an Australian State or Territory.
            # 				<p>Produces an Australian State or Territory</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Australia.state
            #     					#=> "New South Wales"
            #     				
            #
            def state()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("australia.states"))));
            end
            end
        end
    class Avatar < Base
        class << self
            ##
            # 
            # 				Produces a URL for an avatar from robohash.org.
            # 				<p>Produces a URL for an avatar from robohash.org</p>
            # 			
            #
            # @param slug [String]#
            # @param size [String]   
            #   					<p>image size in pixels, in the format of ‘AxB’</p>
            #   				
            #
            # @param format [String]   
            #   					<p>The image file format</p>
            #   				
            #
            # @param set [String]   
            #   					<p>The avatar set to use</p>
            #   				
            #
            # @param bgset [String]   
            #   					<p>The background set to use</p>
            #   				 (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Avatar.image
            #     					#=> "https://robohash.org/sitsequiquia.png?size=300x300&set=set1"
            #     				
            #
            def image(slug, size, format, set, bgset: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Bank < Base
        class << self
            ##
            # Produces a bank account number.
            #
            # @param digits [Integer]   
            #   					<p>Number of digits that the generated account number should have.</p>
            #   				 (default value "10")
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Bank.account_number #=> 6738582379
            #     					Faker::Bank.account_number(digits: 13) #=> 673858237902
            #     				
            #
            def account_number(digits: 10)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # 
            # 				Produces an Australian BSB (Bank-State-Branch) number.
            # 				<p>Produces an Australian BSB (Bank-State-Branch) number</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Bank.bsb_number
            #     					#=> "036616"
            #     				
            #
            def bsb_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method checksum"
            warn  "Failed processing method compile_bsb_number"
            warn  "Failed processing method compile_fraction"
            warn  "Failed processing method compile_routing_number"
            ##
            # Produces a bank iban number.
            #
            # @param country_code [String]   
            #   					<p>Specifies what country prefix is used to generate the iban code. Providing ‘nil` will use a random country.</p>
            #   				 (default value "'GB'")
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Bank.iban #=> "GB76DZJM33188515981979"
            #     					Faker::Bank.iban(country_code: "be") #=> "BE6375388567752043"
            #     					Faker::Bank.iban(country_code: nil) #=> "DE45186738071857270067"
            #     				
            #
            def iban(country_code: 'GB')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bank.iban_details.#{country_code.downcase}.bban_pattern"))));
            end
            warn  "Failed processing method iban_checksum"
            ##
            # Produces the ISO 3166 code of a country that uses the IBAN system.
            #
            # @return [String]
            #
            # @example
            #     Faker::Bank.iban_country_code #=> "CH"
            #
            def iban_country_code()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a bank name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Bank.name #=> "ABN AMRO CORPORATE FINANCE LIMITED"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bank.name"))));
            end
            warn  "Failed processing method rand_numstring"
            ##
            # Produces a routing number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Bank.routing_number #=> "729343831"
            #
            def routing_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a valid routing number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Bank.routing_number #=> "729343831"
            #
            def routing_number_with_format()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a swift / bic number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Bank.swift_bic #=> "AAFMGB21"
            #
            def swift_bic()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bank.swift_bic"))));
            end
            # @return [Boolean]
            #
            def valid_checksum()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method valid_routing_number"
            end
        end
    class Barcode < Base
        class << self
            warn  "Failed processing method ean"
            warn  "Failed processing method ean_with_composite_symbology"
            warn  "Failed processing method generate_barcode"
            ##
            # 
            # 				Generates the check digits from sum passed.
            # 				<p>Generates the check digits from sum passed</p>
            # 			
            #
            # @return [Integer]
            #
            # @example
            #     
            #     					Faker::Barcode.send(:generate_check_digit, 12, 4)   => 0
            #     					Faker::Barcode.send(:generate_check_digit, 23, 5)   => 6
            #     				
            #
            def generate_check_digit()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method isbn"
            warn  "Failed processing method ismn"
            warn  "Failed processing method issn"
            ##
            # 
            # 				Returns the sum of even and odd numbers from value passed.
            # 				<p>Returns the sum of even and odd numbers from value passed</p>
            # 			
            #
            # @return [Array<Integer>]
            #
            # @example
            #     
            #     					Faker::Barcode.send(:sum_even_odd, 12345)   => [9, 5]
            #     					Faker::Barcode.send(:sum_even_odd, 87465)   => [17, 13]
            #     				
            #
            def sum_even_odd()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method upc_a"
            warn  "Failed processing method upc_a_with_composite_symbology"
            warn  "Failed processing method upc_e"
            warn  "Failed processing method upc_e_with_composite_symbology"
            end
        end
    class Beer < Base
        class << self
            ##
            # Produces a random beer alcohol percentage.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.alcohol #=> "5.4%"
            #
            def alcohol()
                return "#{rand(2.0..10.0).round(1)}%";
            end
            ##
            # Produces a random beer blg level.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.blg #=> "5.1Blg"
            #
            def blg()
                return "#{rand(5.0..20.0).round(1)}°Blg";
            end
            ##
            # Produces a random beer hops.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.hop #=> "Sterling"
            #
            def hop()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("beer.hop"))));
            end
            ##
            # Produces a random beer IBU.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.ibu #=> "87 IBU"
            #
            def ibu()
                return "#{rand(10..100)} IBU";
            end
            ##
            # Produces a random beer malt.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.malts #=> "Munich"
            #
            def malts()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("beer.malt"))));
            end
            ##
            # Produces a random beer name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.name #=> "Pliny The Elder"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("beer.name"))));
            end
            ##
            # Produces a random beer style.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.style #=> "Wood-aged Beer"
            #
            def style()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("beer.style"))));
            end
            ##
            # Produces a random beer yeast.
            #
            # @return [String]
            #
            # @example
            #     Faker::Beer.yeast #=> "5335 - Lactobacillus"
            #
            def yeast()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("beer.yeast"))));
            end
            end
        end
    class Blockchain
        class Aeternity < Base
            class << self
                ##
                # 
                # 					Produces a random Aeternity wallet address.
                # 					<p>Produces a random Aeternity wallet address</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Aeternity.address
                #     						#=> "ak_zvU8YQLagjcfng7Tg8yCdiZ1rpiWNp1PBn3vtUs44utSvbJVR"
                #     					
                #
                def address()
                    return "ak_#{rand_strings}";
                end
                ##
                # 
                # 					Produces a random Aeternity contract.
                # 					<p>Produces a random Aeternity contract</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Aeternity.contract
                #     						#=> "ct_Hk2JsNeWGEYQEHHQCfcBeGrwbhtYSwFTPdDhW2SvjFYVojyhW"
                #     					
                #
                def contract()
                    return "ct_#{rand_strings}";
                end
                ##
                # 
                # 					Produces a random Aeternity oracle.
                # 					<p>Produces a random Aeternity oracle</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Aeternity.oracle
                #     						#=> "ok_28QDg7fkF5qiKueSdUvUBtCYPJdmMEoS73CztzXCRAwMGKHKZh"
                #     					
                #
                def oracle()
                    return "ok_#{rand_strings(51)}";
                end
                ##
                # 
                # 					Produces a random Aeternity transaction.
                # 					<p>Produces a random Aeternity transaction</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Aeternity.transaction
                #     						#=> "th_147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"
                #     					
                #
                def transaction()
                    return "th_#{rand_strings(51)}";
                end
                end
            end
        class Bitcoin < Base
            class << self
                ##
                # 
                # 					Produces a Bitcoin wallet address.
                # 					<p>Produces a Bitcoin wallet address</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Bitcoin.address
                #     						#=> "147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"
                #     					
                #
                def address()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Generates a random Bitcoin address for the given network.
                # 					<p>Generates a random Bitcoin address for the given network</p>
                # 				
                #
                # @param network [Symbol]   
                #   						<p>The name of network protocol to generate an address for</p>
                #   					
                #
                # @return [String]
                #
                def address_for(network)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a Bitcoin testnet address.
                # 					<p>Produces a Bitcoin testnet address</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Bitcoin.testnet_address
                #     						#=> "n4YjRyYD6V6zREpk6opqESDqD3KYnMdVEB"
                #     					
                #
                def testnet_address()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        class Ethereum < Base
            class << self
                ##
                # 
                # 					Produces a random Ethereum wallet address.
                # 					<p>Produces a random Ethereum wallet address</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Ethereum.address
                #     						#=> "0xd392b0c0500700d02d27ab30805ec80ddd3320ff"
                #     					
                #
                def address()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        class Tezos < Base
            class << self
                ##
                # 
                # 					Produces a random Tezos account address.
                # 					<p>Produces a random Tezos account address</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.account
                #     						#=> "tz1eUsgK6aj752Fbxwk5sAoEFvSDnPjZ4qvk"
                #     					
                #
                def account()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos block.
                # 					<p>Produces a random Tezos block</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.block
                #     						#=> "BMbhs2rkY1dvAkAyRytvPsjFQ2RiPrBhYkxvWpY65dzkdSuw58a"
                #     					
                #
                def block()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos contract.
                # 					<p>Produces a random Tezos contract</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.contract
                #     						#=> "KT1MroqeP15nnitB4CnNfkqHYa2NErhPPLWF"
                #     					
                #
                def contract()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @param prefix [Symbol]#
                # @param payload_size [Integer]   
                #   						<p>The size of the payload</p>
                #   					
                #
                # @return [String]
                #
                def encode_tz(prefix, payload_size)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos operation.
                # 					<p>Produces a random Tezos operation</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.operation
                #     						#=> "onygWYXJX3xNstFLv9PcCrhQdCkENC795xwSinmTEc1jsDN4VDa"
                #     					
                #
                def operation()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos public key.
                # 					<p>Produces a random Tezos public key</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.public_key
                #     						#=> "edpkuib9x8QXRc5nWwHUg7U1dXsVmaUrUNU5sX9pVEEvwbMVdfMCeq"
                #     					
                #
                def public_key()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos public key.
                # 					<p>Produces a random Tezos public key</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.secret_key
                #     						#=> "edsk3HZCAGEGpzQPnQUwQeFY4ESanFhQCgLpKriQw8GHyhKCrjHawv"
                #     					
                #
                def secret_key()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random Tezos signature.
                # 					<p>Produces a random Tezos signature</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Blockchain::Tezos.signature
                #     						#=> "edsigu165B7VFf3Dpw2QABVzEtCxJY2gsNBNcE3Ti7rRxtDUjqTFRpg67EdAQmY6YWPE5tKJDMnSTJDFu65gic8uLjbW2YwGvAZ"
                #     					
                #
                def signature()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        end
    class Blood < Base
        class << self
            ##
            # Produces a random blood group name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Blood.group #=> "AB-"
            #
            def group()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("blood.group"))));
            end
            ##
            # Produces a random blood RH-Factor.
            #
            # @return [String]
            #
            # @example
            #     Faker::Blood.rh_factor #=> "-"
            #
            def rh_factor()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("blood.rh_factor"))));
            end
            ##
            # Produces a random blood type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Blood.type #=> "AB"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("blood.type"))));
            end
            end
        end
    class Book < Base
        class << self
            ##
            # 
            # 				Produces a random book author.
            # 				<p>Produces a random book author</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Book.author #=> "Alysha Olsen"
            #
            def author()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("book.author"))));
            end
            ##
            # 
            # 				Produces a random genre.
            # 				<p>Produces a random genre</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Book.genre #=> "Mystery"
            #
            def genre()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("book.genre"))));
            end
            ##
            # 
            # 				Produces a random book publisher.
            # 				<p>Produces a random book publisher</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Book.publisher #=> "Opus Reader"
            #
            def publisher()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("book.publisher"))));
            end
            ##
            # 
            # 				Produces a random book title.
            # 				<p>Produces a random book title</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Book.title #=> "The Odd Sister"
            #
            def title()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("book.title"))));
            end
            end
        end
    class Books
        class CultureSeries < Base
            class << self
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.book
                #     						#=> "The Player of Games"
                #     					
                #
                def book()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.books"))));
                end
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.civ
                #     						#=> "Culture"
                #     					
                #
                def civ()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.civs"))));
                end
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.culture_ship
                #     						#=> "Fate Amenable To Change"
                #     					
                #
                def culture_ship()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.culture_ships"))));
                end
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.culture_ship_class
                #     						#=> "General Systems Vehicle"
                #     					
                #
                def culture_ship_class()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.culture_ship_classes"))));
                end
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.culture_ship_class_abv
                #     						#=> "The Odd Sister"
                #     					
                #
                def culture_ship_class_abv()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.culture_ship_class_abvs"))));
                end
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::CultureSeries.planet
                #     						#=> "Xinth"
                #     					
                #
                def planet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("culture_series.planets"))));
                end
                end
            end
        ##
        # 
        # 				A Faker module beyond your dreams, test data beyond your imagination.
        # 				<p>A Faker module beyond your dreams, test data beyond your imagination.</p>
        # 			
        #
        class Dune < Base
            class << self
                ##
                # 
                # 					Produces the name of a character from Dune.
                # 					<p>Produces the name of a character from Dune</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Dune.character #=> "Leto Atreides"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dune.characters"))));
                end
                ##
                # 
                # 					Produces the name of a city from Dune.
                # 					<p>Produces the name of a city from Dune</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Dune.city #=> "Arrakeen"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dune.cities"))));
                end
                ##
                # 
                # 					Produces the name of a planet from Dune.
                # 					<p>Produces the name of a planet from Dune</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Dune.planet #=> "Caladan"
                #
                def planet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dune.planets"))));
                end
                ##
                # 
                # 					Produces a quote from Dune.
                # 					<p>Produces a quote from Dune</p>
                # 				
                #
                # @param character [String]   
                #   						<p>The name of the character that the quote should be from</p>
                #   					 (default value "nil")
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::Dune.quote
                #     						#=> "A dead man, surely, no longer requires that water."
                #     					
                #
                def quote(character: nil)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a saying from Dune.
                # 					<p>Produces a saying from Dune</p>
                # 				
                #
                # @param source [String]    (default value "nil")
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Dune.saying #=> "You do not beg the sun for mercy."
                #
                def saying(source: nil)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                # @example
                #     Faker::Books::Dune.title #=> "Duke"
                #
                def title()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dune.titles"))));
                end
                end
            end
        class Lovecraft < Base
            class << self
                ##
                # 
                # 					Produces the name of a deity.
                # 					<p>Produces the name of a deity</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Lovecraft.deity #=> "Shub-Niggurath"
                #
                def deity()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lovecraft.deity"))));
                end
                # @param number [Integer]   
                #   						<p>The number of times to repeat the chant</p>
                #   					 (default value "1")
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.fhtagn
                #     						#=> "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"
                #     					
                #
                def fhtagn(number: 1)
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lovecraft.fhtagn"))));
                end
                ##
                # 
                # 					Produces the name of a location.
                # 					<p>Produces the name of a location</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Lovecraft.location #=> "Kingsport"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lovecraft.location"))));
                end
                ##
                # 
                # 					Produces a random paragraph.
                # 					<p>Produces a random paragraph</p>
                # 				
                #
                # @param sentence_count [Integer]   
                #   						<p>Number of sentences to generate</p>
                #   					
                #
                # @param random_sentences_to_add [Integer]    (default value "3")
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.paragraph
                #     						#=> "Squamous nameless daemoniac fungus ululate. Cyclopean stygian decadent loathsome manuscript tenebrous. Foetid abnormal stench. Dank non-euclidean comprehension eldritch. Charnel singular shunned lurk effulgence fungus."
                #     					
                #
                def paragraph(sentence_count, random_sentences_to_add: 3)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @param characters [Integer]   
                #   						<p>Number of characters to generate in the paragraph</p>
                #   					 (default value "256")
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.paragraph_by_chars
                #     						#=> "Truffaut stumptown trust fund 8-bit messenger bag portland. Meh kombucha selvage swag biodiesel. Lomo kinfolk jean shorts asymmetrical diy. Wayfarers portland twee stumptown. Wes anderson biodiesel retro 90's pabst. Diy echo 90's mixtape semiotics. Cornho."
                #     					
                #
                def paragraph_by_chars(characters: 256)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a array of random paragraphs.
                # 					<p>Produces a array of random paragraphs</p>
                # 				
                #
                # @param number [Integer]   
                #   						<p>Number of paragraphs to generate</p>
                #   					 (default value "3")
                #
                # @return [Array<String>]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.paragraphs
                #     						#=> [
                #     						#     "Noisome daemoniac gibbous abnormal antediluvian. Unutterable fung...
                #     						#     "Non-euclidean immemorial indescribable accursed furtive. Dank unn...
                #     						#     "Charnel antediluvian unnamable cat blasphemous comprehension tene...
                #     						#   ]
                #     					
                #
                def paragraphs(number: 3)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a random sentence.
                # 					<p>Produces a random sentence</p>
                # 				
                #
                # @param word_count [Integer]   
                #   						<p>The number of words to have in the sentence</p>
                #   					
                #
                # @param random_words_to_add [Integer]#
                # @param open_compounds_allowed [Boolean]   
                #   						<p>If true, generated sentence can contain words having additional spaces</p>
                #   					 (default value "true")
                #
                # @return [String]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.sentence
                #     						#=> "Furtive antiquarian squamous dank cat loathsome amorphous lurk."
                #     					
                #
                def sentence(word_count, random_words_to_add, open_compounds_allowed: true)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a array of random sentences.
                # 					<p>Produces a array of random sentences</p>
                # 				
                #
                # @param number [Integer]   
                #   						<p>Number of sentences to generate</p>
                #   					 (default value "3")
                #
                # @return [Array<String>]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.sentences
                #     						#=> [
                #     						#     "Nameless loathsome decadent gambrel.",
                #     						#     "Ululate swarthy immemorial cat madness gibbous unmentionable unnamable.",
                #     						#     "Decadent antediluvian non-euclidean tentacles amorphous tenebrous.",
                #     						#   ]
                #     					
                #
                def sentences(number: 3)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces the name of a tome.
                # 					<p>Produces the name of a tome</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Lovecraft.tome #=> "Book of Eibon"
                #
                def tome()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lovecraft.tome"))));
                end
                ##
                # 
                # 					Produces a random word.
                # 					<p>Produces a random word</p>
                # 				
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::Lovecraft.word #=> "furtive"
                #
                def word()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # 
                # 					Produces a array of random words.
                # 					<p>Produces a array of random words</p>
                # 				
                #
                # @param number [Integer]   
                #   						<p>Number of words to generate</p>
                #   					
                #
                # @param spaces_allowed [Boolean]   
                #   						<p>If true, generated words can contain spaces</p>
                #   					 (default value "false")
                #
                # @return [Array<String>]
                #
                # @example
                #     
                #     						Faker::Books::Lovecraft.words
                #     						#=> [
                #     						#     "manuscript",
                #     						#     "abnormal",
                #     						#     "singular",
                #     						#   ]
                #     					
                #
                def words(number, spaces_allowed: false)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        class TheKingkillerChronicle < Base
            class << self
                ##
                # Produces the name of a The Kingkiller Chronicle book.
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::TheKingkillerChronicle.book #=> "The Name of the Wind"
                #
                def book()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("books.the_kingkiller_chronicle.books"))));
                end
                ##
                # Produces the name of a The Kingkiller Chronicle character.
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::TheKingkillerChronicle.character #=> "Kvothe"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("books.the_kingkiller_chronicle.characters"))));
                end
                ##
                # Produces the name of a The Kingkiller Chronicle creature.
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::TheKingkillerChronicle.creature #=> "Scrael"
                #
                def creature()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("books.the_kingkiller_chronicle.creatures"))));
                end
                ##
                # Produces the name of a The Kingkiller Chronicle location.
                #
                # @return [String]
                #
                # @example
                #     Faker::Books::TheKingkillerChronicle.location #=> "Tarbean"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("books.the_kingkiller_chronicle.locations"))));
                end
                end
            end
        end
    class Boolean < Base
        class << self
            ##
            # 
            # 				Produces a boolean.
            # 				<p>Produces a boolean</p>
            # 			
            #
            # @param true_ratio [Float]   
            #   					<p>The likelihood (as a float, out of 1.0) for the method to return ‘true`.</p>
            #   				 (default value "0.5")
            #
            # @return [Boolean]
            #
            # @example
            #     Faker::Boolean.boolean #=> true
            #
            def get_boolean(true_ratio: 0.5)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class BossaNova < Base
        class << self
            ##
            # Produces the name of a bossa nova artist.
            #
            # @return [String]
            #
            # @example
            #     Faker::BossaNova.artist #=> "Tom Jobin"
            #
            def artist()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bossa_nova.artists"))));
            end
            ##
            # Produces a bossa nova song.
            #
            # @return [String]
            #
            # @example
            #     Faker::BossaNova.song #=> "Chega de Saudade"
            #
            def song()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bossa_nova.songs"))));
            end
            end
        end
    class Business < Base
        class << self
            ##
            # Produces a credit card expiration date.
            #
            # @return [Date]
            #
            # @example
            #     Faker::Business.credit_card_expiry_date #=> <Date: 2015-11-11 ((2457338j,0s,0n),+0s,2299161j)>
            #
            def credit_card_expiry_date()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a credit card number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Business.credit_card_number #=> "1228-1221-1221-1431"
            #
            def credit_card_number()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("business.credit_card_numbers"))));
            end
            ##
            # Produces a type of credit card.
            #
            # @return [String]
            #
            # @example
            #     Faker::Business.credit_card_type #=> "visa"
            #
            def credit_card_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("business.credit_card_types"))));
            end
            end
        end
    class Camera < Base
        class << self
            ##
            # 
            # 				Produces a brand of a camera.
            # 				<p>Produces a brand of a camera</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Camera.brand #=> "Canon"
            #
            def brand()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("camera.brand"))));
            end
            ##
            # 
            # 				Produces a brand with model.
            # 				<p>Produces a brand with model</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Camera.brand_with_model #=> "Canon 450D"
            #
            def brand_with_model()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("camera.brand_with_model"))));
            end
            ##
            # 
            # 				Produces a model of camera.
            # 				<p>Produces a model of camera</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Camera.model #=> "450D"
            #
            def model()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("camera.model"))));
            end
            end
        end
    class Cannabis < Base
        class << self
            ##
            # Produces a random brand.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.brand #=> "Cannavore Confections"
            #
            def brand()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.brands"))));
            end
            ##
            # Produces a random buzzword.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.buzzword #=> "high"
            #
            def buzzword()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.buzzwords"))));
            end
            ##
            # Produces a random cannabinoid type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.cannabinoid #=> "Cannabinolic Acid"
            #
            def cannabinoid()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.cannabinoids"))));
            end
            ##
            # Produces a random abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.cannabinoid_abbreviation #=> "CBGa"
            #
            def cannabinoid_abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.cannabinoid_abbreviations"))));
            end
            ##
            # Produces a random category.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.category #=> "crystalline"
            #
            def category()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.categories"))));
            end
            ##
            # Produces a random health benefit.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.health_benefit #=> "prevents infection"
            #
            def health_benefit()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.health_benefits"))));
            end
            ##
            # Produces a random kind of medical use.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.medical_use #=> "anti-cancer"
            #
            def medical_use()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.medical_uses"))));
            end
            ##
            # Produces a random strain.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.strain #=> "Super Glue"
            #
            def strain()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.strains"))));
            end
            ##
            # Produces a random terpene type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.terpene #=> "Terpinene"
            #
            def terpene()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.terpenes"))));
            end
            ##
            # Produces a random type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cannabis.type #=> "indica"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cannabis.types"))));
            end
            end
        end
    class ChileRut < Base
        class << self
            ##
            # 
            # 				Produces a random Chilean digito verificador (check-digit).
            # 				<p>Alias for english speaking devs.</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::ChileRut.check_digit #=> "5"
            #
            def check_digit()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random Chilean digito verificador (check-digit).
            #
            # @return [String]
            #
            # @example
            #     Faker::ChileRut.dv #=> "k"
            #
            def dv()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method format_rut"
            ##
            # Produces a random Chilean RUT (Rol Unico Tributario, ID with 8 digits) with a dv (digito verificador, check-digit).
            #
            # @param min_rut [Integer]   
            #   					<p>Specifies the minimum value of the RUT.</p>
            #   				
            #
            # @param max_rut [Integer]   
            #   					<p>Specifies the maximum value of the RUT.</p>
            #   				
            #
            # @param fixed [Boolean]   
            #   					<p>Determines if the RUT is fixed (returns the min_rut value).</p>
            #   				
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::ChileRut.full_rut #=> "30686957-4"
            #     					Faker::ChileRut.full_rut(min_rut: 10_000_000, max_rut: 30_000_000) #=> "20686957-4"
            #     					Faker::ChileRut.full_rut(min_rut: 30_686_957, fixed: true) #=> "30686957-4"
            #     				
            #
            def full_rut(min_rut, max_rut, fixed)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method last_rut"
            ##
            # Produces a random Chilean RUT (Rol Unico Tributario, ID with 8 digits).
            #
            # @param min_rut [Integer]   
            #   					<p>Specifies the minimum value of the RUT.</p>
            #   				
            #
            # @param max_rut [Integer]   
            #   					<p>Specifies the maximum value of the RUT.</p>
            #   				
            #
            # @param is_fixed [Boolean]   
            #   					<p>Determines if the RUT is fixed (returns the min_rut value).</p>
            #   				 (default value "false")
            #
            # @return [Number]
            #
            # @example
            #     
            #     					Faker::ChileRut.rut #=> 11235813
            #     					Faker::ChileRut.rut(min_rut: 10_000_000, max_rut: 30_000_000) #=> 21853211
            #     					Faker::ChileRut.rut(min_rut: 20_890_156, is_fixed: true) #=> 20890156
            #     				
            #
            def rut(min_rut, max_rut, is_fixed: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class ChuckNorris < Base
        class << self
            ##
            # 
            # 				Produces a Chuck Norris Fact.
            # 				<p>Original list of facts: <a href="https://github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java">github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java</a></p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::ChuckNorris.fact
            #     					#=> "Chuck Norris can solve the Towers of Hanoi in one move."
            #     				
            #
            def fact()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chuck_norris.fact"))));
            end
            end
        end
    class Code < Base
        class << self
            ##
            # 
            # 				Retrieves a real Amazon ASIN code from https://archive.org/details/asin_listing.
            # 				<p>Retrieves a real Amazon ASIN code from <a href="https://archive.org/details/asin_listing">archive.org/details/asin_listing</a></p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.asin #=> "B000MZW1GE"
            #
            def asin()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("code.asin"))));
            end
            ##
            # Produces a random EAN (European Article Number) code.
            #
            # @param digits [Integer]   
            #   					<p>the length of the code to generate (either 8 or 13)</p>
            #   				 (default value "13")
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.ean(digits: 8) #=> "36941070"
            #
            def ean(digits: 13)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method generate_base10_isbn"
            warn  "Failed processing method generate_base13_ean"
            warn  "Failed processing method generate_base13_isbn"
            warn  "Failed processing method generate_base8_ean"
            warn  "Failed processing method generate_imei"
            warn  "Failed processing method generate_nric_check_alphabet"
            warn  "Failed processing method generate_sin_check_digit"
            ##
            # Produces a random IMEI (International Mobile Equipment Number) code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.imei #=> "492033129092256"
            #
            def imei()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random ISBN (International Standard Book Number) code.
            #
            # @param digits [Integer]   
            #   					<p>the length of the code to generate (either 10 or 13)</p>
            #   				 (default value "10")
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.isbn(digits: 13) #=> "896579606969-8"
            #
            def isbn(digits: 10)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random NPI (National Provider Identifier) code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.npi #=> "9804062802"
            #
            def npi()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # 
            # 				Produces a random NRIC (National Registry Identity Card) code.
            # 				<p>By default generates a Singaporean NRIC ID for someone who is born between the age of 18 and 65.</p>
            # 			
            #
            # @param min_age [Integer]   
            #   					<p>the min age of the person in years</p>
            #   				
            #
            # @param max_age [Integer]   
            #   					<p>the max age of the person in years</p>
            #   				 (default value "65")
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.nric(min_age: 25, max_age: 50) #=> "S9347283G"
            #
            def nric(min_age, max_age: 65)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random RUT (Rol Unico Nacional) code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.rut #=> "91611842-2"
            #
            def rut()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method rut_verificator_digit"
            ##
            # Produces a random SIN (Social Insurance Number for Canada) code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Code.sin #=> "996586962"
            #
            def sin()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method sum"
            end
        end
    class Coffee < Base
        class << self
            ##
            # Produces a random blend name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coffee.blend_name #=> "Major Java"
            #
            def blend_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coffee.blend_name"))));
            end
            ##
            # Produces a random coffee taste intensity.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coffee.intensifier #=> "mild"
            #
            def intensifier()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coffee.intensifier"))));
            end
            ##
            # Produces a string containing a random description of a coffee's taste.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coffee.notes #=> "dull, tea-like, cantaloupe, soy sauce, marshmallow"
            #
            def notes()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coffee.notes"))));
            end
            ##
            # Produces a random coffee origin place.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coffee.origin #=> "Oaxaca, Mexico"
            #
            def origin()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coffee.country"))));
            end
            warn  "Failed processing method search_format"
            ##
            # Produces a random coffee variety.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coffee.variety #=> "Red Bourbon"
            #
            def variety()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coffee.variety"))));
            end
            end
        end
    class Coin < Base
        class << self
            ##
            # 
            # 				Retrieves a face to a flipped coin.
            # 				<p>Retrieves a face to a flipped coin</p>
            # 			
            #
            # @return [String]
            #
            # @example
            #     Faker::Coin.flip #=> "Heads"
            #
            def flip()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("coin.flip"))));
            end
            ##
            # Retrieves a random coin from any country.
            #
            # @return [String]
            #
            # @example
            #     Faker::Coin.name #=> "Brazilian Real"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("currency.name"))));
            end
            end
        end
    class Color < Base
        class << self
            ##
            # Produces the name of a color.
            #
            # @return [String]
            #
            # @example
            #     Faker::Color.color_name #=> "yellow"
            #
            def color_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("color.name"))));
            end
            ##
            # Produces a hex color code.
            #                             <p>Clients are able to specify the hue, saturation, or lightness of the required color. Alternatively a client can simply specify that they need a light or dark color.</p>
            #                         
            #
            # @param args [Hash]   
            #   <p>Allows the client to specify what color should be return</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     Faker::Color.hex_color #=> "#31a785"
            #
            def hex_color(args: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces an array of floats representing an HSL color.
            #                             <p>The array is in the form of ‘[hue, saturation, lightness]`.</p>
            #                         
            #
            # @param hue [FLoat]   
            #   <p>Optional value to use for hue</p>
            #   
            #
            # @param saturation [Float]   
            #   <p>Optional value to use for saturation</p>
            #   
            #
            # @param lightness [Float]   
            #   <p>Optional value to use for lightness</p>
            #    (default value "nil")
            #
            # @return [Array(Float, Float, Float)]
            #
            # @example
            #     Faker::Color.hsl_color #=> [69.87, 0.66, 0.3]
            #
            def hsl_color(hue, saturation, lightness: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a hex code representation of an HSL color.
            #                             <p>Produces a hex code representation of an HSL color</p>
            #                         
            #
            # @param a_hsl_color [Array(Float, Float, Float)]   
            #   <p>The array that represents the HSL color</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     hsl_to_hex([50, 100,80]) #=> #FFEE99
            #
            def hsl_to_hex(a_hsl_color)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces an array of floats representing an HSLA color.
            #                             <p>The array is in the form of ‘[hue, saturation, lightness, alpha]`.</p>
            #                         
            #
            # @return [Array(Float, Float, Float, Float)]
            #
            # @example
            #     Faker::Color.hsla_color #=> [154.77, 0.36, 0.9, 0.2]
            #
            def hsla_color()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces an array of integers representing an RGB color.
            #
            # @return [Array(Integer, Integer, Integer)]
            #
            # @example
            #     Faker::Color.rgb_color #=> [54, 233, 67]
            #
            def rgb_color()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method single_rgb_color"
            end
        end
    class Commerce < Base
        class << self
            ##
            # Produces a randomized string of a brand name.
            #                             <p>Produces a randomized string of a brand name</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Commerce.brand #=> 'Apple'
            #
            def brand()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("commerce.brand"))));
            end
            warn  "Failed processing method categories"
            ##
            # Produces a random color.
            #
            # @return [String]
            #
            # @example
            #     Faker::Commerce.color #=> "lavender"
            #
            def color()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("color.name"))));
            end
            ##
            # Produces a random department.
            #
            # @param max [Integer]   
            #   <p>Updates the maximum number of names used to generate the department name.</p>
            #   
            #
            # @param fixed_amount [Boolean]   
            #   <p>Fixes the amount of departments to use instead of using a range.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Commerce.department #=> "Grocery, Health & Beauty"
            #                                         Faker::Commerce.department(max: 5) #=> "Grocery, Books, Health & Beauty"
            #                                         Faker::Commerce.department(max: 2, fixed_amount: true) #=> "Books & Tools"
            #                                     
            #
            def department(max, fixed_amount: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random material.
            #
            # @return [String]
            #
            # @example
            #     Faker::Commerce.material #=> "Plastic"
            #
            def material()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("commerce.product_name.material"))));
            end
            warn  "Failed processing method merge_categories"
            ##
            # Produces a random product price.
            #
            # @param range [Range]   
            #   <p>A range to generate the random number within.</p>
            #   
            #
            # @param as_string [Boolean]   
            #   <p>Changes the return value to [String].</p>
            #    (default value "false")
            #
            # @return [Float]
            #
            # @example
            #     
            #                                         Faker::Commerce.price #=> 44.6
            #                                         Faker::Commerce.price(range: 0..10.0, as_string: true) #=> "2.18"
            #                                     
            #
            def price(range, as_string: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random product name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Commerce.product_name #=> "Practical Granite Shirt"
            #
            def product_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("commerce.product_name.adjective"))));
            end
            ##
            # Produces a random promotion code.
            #
            # @param digits [Integer]   
            #   <p>Updates the number of numerical digits used to generate the promotion code.</p>
            #    (default value "6")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Commerce.promotion_code #=> "AmazingDeal829102"
            #                                         Faker::Commerce.promotion_code(digits: 2) #=> "AmazingPrice57"
            #                                     
            #
            def promotion_code(digits: 6)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("commerce.promotion_code.adjective"))));
            end
            ##
            # Produces a randomized string of a vendor name.
            #                             <p>Produces a randomized string of a vendor name</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Commerce.vendor #=> 'Dollar General'
            #
            def vendor()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("commerce.vendor"))));
            end
            end
        end
    class Company < Base
        class << self
            warn  "Failed processing method abn_checksum"
            ##
            # Produces a company australian business number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.australian_business_number #=> "93579396170"
            #
            def australian_business_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company brazilian company number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.brazilian_company_number #=> "37205322000500"
            #
            def brazilian_company_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces some company BS.
            #                             <p>When a straight answer won’t do, BS to the rescue!</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.bs #=> "empower customized functionalities"
            #
            def bs()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company buzzword.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.buzzword #=> "flexibility"
            #
            def buzzword()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method calculate_gst_checksum"
            ##
            # Produces a company catch phrase.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.catch_phrase #=> "Grass-roots grid-enabled portal"
            #
            def catch_phrase()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method collect_regon_sum"
            ##
            # Produces a company czech organisation number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.czech_organisation_number #=> "90642741"
            #
            def czech_organisation_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company department.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.department #=> "Information Technology"
            #
            def department()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.department"))));
            end
            ##
            # Produces a company duns number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.duns_number #=> "70-655-5105"
            #
            def duns_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company EIN (Employer Identification Number).
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.ein #=> "07-4009024"
            #
            def ein()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company french siren number.
            #                             <p>Get a random French SIREN number. See more here <a href="https://fr.wikipedia.org/wiki/Syst%C3%A8me_d%27identification_du_r%C3%A9pertoire_des_entreprises">fr.wikipedia.org/wiki/Syst%C3%A8me_d%27identification_du_r%C3%A9pertoire_des_entreprises</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.french_siren_number #=> "163417827"
            #
            def french_siren_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company french siret number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.french_siret_number #=> "76430067900496"
            #
            def french_siret_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Get a random Indian Goods and Services Tax (GST) number.
            #                             <p>For more on Indian tax number here: <a href="https://simple.wikipedia.org/wiki/GSTIN">simple.wikipedia.org/wiki/GSTIN</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Company.indian_gst_number #=> "15VQPNZ2126J2ZU"
            #                                         Faker::Company.indian_gst_number(state_code: "22") #=> "22ZVWEY6632K0ZN"
            #                                     
            #
            def indian_gst_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company industry.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.industry #=> "Food & Beverages"
            #
            def industry()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.industry"))));
            end
            warn  "Failed processing method inn_checksum"
            ##
            # For more on Russian tax number algorithm here: https://ru.wikipedia.org/wiki/Идентификационный_номер_налогоплательщика#Вычисление_контрольных_цифр.
            #                             <p>For more on Russian tax number algorithm here: <a href="https://ru.wikipedia.org/wiki">ru.wikipedia.org/wiki</a>/Идентификационный_номер_налогоплательщика#Вычисление_контрольных_цифр</p>
            # 
            #                             <p>Range of regions: <a href="https://ru.wikipedia.org/wiki">ru.wikipedia.org/wiki</a>/Коды_субъектов_Российской_Федерации region [String] Any region string</p>
            #                         
            #
            # @param type [Symbol]   
            #   <p>Legeal or not, defaults to :legal</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Comnpany.russian_tax_number
            #                                         Faker::Comnpany.russian_tax_number(region: 'AZ')
            #                                         Faker::Comnpany.russian_tax_number(region: 'AZ', type: false)
            #                                     
            #
            def inn_number(type)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company logo.
            #                             <p>Get a random company logo url in PNG format.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.logo #=> "https://pigment.github.io/fake-logos/logos/medium/color/12.png"
            #
            def logo()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method luhn_algorithm"
            warn  "Failed processing method mod11"
            ##
            # Produces a company name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.name #=> "Roberts Inc"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.name"))));
            end
            ##
            # Produces a company norwegian organisation number.
            #                             <p>Get a random Norwegian organization number. Info: <a href="https://www.brreg.no/om-oss/samfunnsoppdraget-vart/registera-vare/einingsregisteret/organisasjonsnummeret">www.brreg.no/om-oss/samfunnsoppdraget-vart/registera-vare/einingsregisteret/organisasjonsnummeret</a>/</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.norwegian_organisation_number #=> "842457173"
            #
            def norwegian_organisation_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company polish register of national economy.
            #                             <p>Get a random Polish register of national economy number. More info <a href="https://pl.wikipedia.org/wiki/REGON">pl.wikipedia.org/wiki/REGON</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.polish_register_of_national_economy #=> "788435970"
            #
            def polish_register_of_national_economy()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company polish taxpayer identification_number.
            #                             <p>Get a random Polish taxpayer identification number More info <a href="https://pl.wikipedia.org/wiki/NIP">pl.wikipedia.org/wiki/NIP</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.polish_taxpayer_identification_number #=> "2767549463"
            #
            def polish_taxpayer_identification_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company profession.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.profession #=> "factory worker"
            #
            def profession()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.profession"))));
            end
            ##
            # Get a random Russian tax number.
            #
            # @param region [String]   
            #   <p>Any region string</p>
            #   
            #
            # @param type [Symbol]   
            #   <p>Legeal or not, defaults to :legal</p>
            #    (default value ":legal")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Company.russian_tax_number                             #=> "0415584064"
            #                                         Faker::Company.russian_tax_number(region: 'AZ')               #=> "AZ50124562"
            #                                         Faker::Company.russian_tax_number(region: 'AZ', type: false)  #=> "AZ8802315465"
            #                                     
            #
            def russian_tax_number(region, type: :legal)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company sic code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.sic_code #=> "7383"
            #
            def sic_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.sic_code"))));
            end
            ##
            # Produces a company south african close corporation registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.south_african_close_corporation_registration_number #=> "CK38/5739937418/23"
            #
            def south_african_close_corporation_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company south african listed company registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.south_african_listed_company_registration_number #=> "2512/87676/06"
            #
            def south_african_listed_company_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company south african pty ltd registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.south_african_pty_ltd_registration_number #=> "7043/2400717902/07"
            #
            def south_african_pty_ltd_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company south african trust registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.south_african_trust_registration_number #=> "IT5673/937519896"
            #
            def south_african_trust_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method spanish_b_algorithm"
            warn  "Failed processing method spanish_cif_control_digit"
            ##
            # Produces a company spanish organisation number.
            #                             <p>Get a random Spanish organization number. See more here <a href="https://es.wikipedia.org/wiki/N%C3%BAmero_de_identificaci%C3%B3n_fiscal">es.wikipedia.org/wiki/N%C3%BAmero_de_identificaci%C3%B3n_fiscal</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.spanish_organisation_number #=> "D6819358"
            #
            def spanish_organisation_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.suffix #=> "LLC"
            #
            def suffix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.suffix"))));
            end
            ##
            # Produces a company swedish organisation number.
            #                             <p>Get a random Swedish organization number. See more here <a href="https://sv.wikipedia.org/wiki/Organisationsnummer">sv.wikipedia.org/wiki/Organisationsnummer</a></p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.swedish_organisation_number #=> "3866029808"
            #
            def swedish_organisation_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a company type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Company.type #=> "Partnership"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("company.type"))));
            end
            warn  "Failed processing method weight_sum"
            end
        end
    class Compass < Base
        class << self
            ##
            # Produces a random abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.abbreviation #=> "NEbN"
            #
            def abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.abbreviation"))));
            end
            ##
            # Produces a random azimuth.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.azimuth #=> "168.75"
            #
            def azimuth()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.azimuth"))));
            end
            ##
            # Produces a random cardinal.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.cardinal #=> "north"
            #
            def cardinal()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.cardinal.word"))));
            end
            ##
            # Produces a random cardinal abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.cardinal_abbreviation #=> "N"
            #
            def cardinal_abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.cardinal.abbreviation"))));
            end
            ##
            # Produces a random cardinal azimuth.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.cardinal_azimuth #=> "90"
            #
            def cardinal_azimuth()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.cardinal.azimuth"))));
            end
            ##
            # Produces a random direction.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.direction #=> "southeast"
            #
            def direction()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.direction"))));
            end
            ##
            # Produces a random half wind.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.half_wind #=> "north-northwest"
            #
            def half_wind()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.half-wind.word"))));
            end
            ##
            # Produces a random half wind abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.half_wind_abbreviation #=> "NNE"
            #
            def half_wind_abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.half-wind.abbreviation"))));
            end
            ##
            # Produces a random half wind azimuth.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.half_wind_azimuth #=> "292.5"
            #
            def half_wind_azimuth()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.half-wind.azimuth"))));
            end
            ##
            # Produces a random ordinal.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.ordinal #=> "northwest"
            #
            def ordinal()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.ordinal.word"))));
            end
            ##
            # Produces a random ordinal abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.ordinal_abbreviation #=> "SW"
            #
            def ordinal_abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.ordinal.abbreviation"))));
            end
            ##
            # Produces a random ordinal azimuth.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.ordinal_azimuth #=> "135"
            #
            def ordinal_azimuth()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.ordinal.azimuth"))));
            end
            ##
            # Produces a random quarter wind.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.quarter_wind #=> "north by west"
            #
            def quarter_wind()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.quarter-wind.word"))));
            end
            ##
            # Produces a random quarter wind abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.quarter_wind_abbreviation #=> "SWbS"
            #
            def quarter_wind_abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.quarter-wind.abbreviation"))));
            end
            ##
            # Produces a random quarter wind azimuth.
            #                             <p>Produces a random quarter wind azimuth</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Compass.quarter_wind_azimuth #=> "56.25"
            #
            def quarter_wind_azimuth()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("compass.quarter-wind.azimuth"))));
            end
            end
        end
    class Computer < Base
        class << self
            ##
            # Produces the name of a computer os.
            #
            # @param platform [String]   
            #   <p>optionally specify the platform ‘linux`, `macos`, or `windows`.</p>
            #    (default value "self.platform")
            #
            # @return [String]
            #
            # @example
            #     Faker::Computer.os #=> "RHEL 6.10"
            #
            def os(platform: self.platform)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("computer.os.#{platform.downcase}"))));
            end
            ##
            # Produces the name of a computer platform.
            #
            # @return [String]
            #
            # @example
            #     Faker::Computer.platform #=> "Linux"
            #
            def platform()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("computer.platform"))));
            end
            ##
            # Produces a string with computer platform and os.
            #                             <p>Produces a string with computer platform and os</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Computer.stack #=> "Linux, RHEL 6.10"
            #
            def stack()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("computer.os.#{platform.downcase}"))));
            end
            ##
            # Produces the name of a computer type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Computer.type #=> "server"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("computer.type"))));
            end
            end
        end
    class Construction < Base
        class << self
            ##
            # Produces a random heavy equipment.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.heavy_equipment #=> "Excavator"
            #
            def heavy_equipment()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.heavy_equipment"))));
            end
            ##
            # Produces a random material.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.material #=> "Wood"
            #
            def material()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.materials"))));
            end
            ##
            # Produces a random role.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.role #=> "Engineer"
            #
            def role()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.roles"))));
            end
            ##
            # Produces a random standard cost code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.standard_cost_code #=> "1-000 - Purpose"
            #
            def standard_cost_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.standard_cost_codes"))));
            end
            ##
            # Produces a random subcontract category.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.subcontract_category #=> "Curb & Gutter"
            #
            def subcontract_category()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.subcontract_categories"))));
            end
            ##
            # Produces a random trade.
            #
            # @return [String]
            #
            # @example
            #     Faker::Construction.trade #=> "Carpenter"
            #
            def trade()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("construction.trades"))));
            end
            end
        end
    class Cosmere < Base
        class << self
            ##
            # Produces a random allomancer.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.allomancer #=> "Coinshot"
            #
            def allomancer()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random aon.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.aon #=> "Rao"
            #
            def aon()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random feruchemist.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.feruchemist #=> "Archivist"
            #
            def feruchemist()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random herald.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.herald #=> "Ishar"
            #
            def herald()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random knight radiant.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.knight_radiant #=> "Truthwatcher"
            #
            def knight_radiant()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random metal.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.metal #=> "Brass"
            #
            def metal()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random shard.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.shard #=> "Ambition"
            #
            def shard()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random shard world.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.shard_world #=> "Yolen"
            #
            def shard_world()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random spren.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.spren #=> "Flamespren"
            #
            def spren()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random surge.
            #
            # @return [String]
            #
            # @example
            #     Faker::Cosmere.surge #=> "Progression"
            #
            def surge()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Creature
        class Animal < Base
            class << self
                ##
                # Produces a random animal name.
                #                                 <p>Produces a random animal name</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Animal.name #=> "fly"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.animal.name"))));
                end
                end
            end
        class Bird < Base
            class << self
                ##
                # Produces a random adjective used to described birds.
                #                                 <p>Produces a random adjective used to described birds</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.adjective #=> 'common'
                #
                def adjective()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.adjectives"))));
                end
                ##
                # Produces a random bird anatomy word.
                #                                 <p>Produces a random bird anatomy word</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.anatomy #=> "rump"
                #
                def anatomy()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.anatomy"))));
                end
                ##
                # Produces a random, past tensed bird anatomy word.
                #                                 <p>Produces a random, past tensed bird anatomy word</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.anatomy #=> "breasted"
                #
                def anatomy_past_tense()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.anatomy_past_tense"))));
                end
                ##
                # Produces a random color word used in describing birds.
                #                                 <p>Produces a random color word used in describing birds</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.color #=> "ferruginous"
                #
                def color()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.colors"))));
                end
                ##
                # Produces a random common family name of a bird.
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.common_family_name #=> "Owls"
                #
                def common_family_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.common_family_name"))));
                end
                ##
                # Produces a random common name for a bird.
                #                                 <p>Produces a random common name for a bird</p>
                #                             
                #
                # @param tax_order [String | Symbol | nil]   
                #   <p>Tax</p>
                #    (default value "nil")
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.common_name #=> 'wren'
                #
                def common_name(tax_order: nil)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a random emotional adjective NOT used to described birds ...but could be.
                #                                 <p>Produces a random emotional adjective NOT used to described birds …but could be</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.emotional_adjective #=> 'cantankerous'
                #
                def emotional_adjective()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.emotional_adjectives"))));
                end
                ##
                # Produces a random geographical word used in describing birds.
                #                                 <p>Produces a random geographical word used in describing birds</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.geo #=> "Eurasian"
                #
                def geo()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.geo"))));
                end
                ##
                # Produces a random and IMplausible common name for a bird.
                #                                 <p>Produces a random and IMplausible common name for a bird</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.implausible_common_name #=> 'Hellinger's Cantankerous Chickadee'
                #
                def implausible_common_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.implausible_common_names"))));
                end
                ##
                # Produces a random common taxonomic order from the class Aves.
                #                                 <p>Produces a random common taxonomic order from the class Aves</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.order #=> "Passeriformes"
                #
                def order()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a hash entry with a random order and a random common name that is of that order.
                #                                 <p>Produces a hash entry with a random order and a random common name that is of that order</p>
                # 
                #                                 <p>}</p>
                #                             
                #
                # @return [Hash<order,common_name>]
                #
                # @example
                #     
                #                                             Faker::Creature::Bird.order_with_common_name #=> {
                #                                             order: ''Accipitriformes',
                #                                             common_name: 'Osprey'
                #                                         
                #
                def order_with_common_name()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a random and plausible common name for a bird.
                #                                 <p>Produces a random and plausible common name for a bird</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.plausible_common_name #=> 'Hellinger's Wren'
                #
                def plausible_common_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.plausible_common_names"))));
                end
                ##
                # Produces a random adjective NOT used to described birds ...but probably shouldn't.
                #                                 <p>Produces a random adjective NOT used to described birds …but probably shouldn’t</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Bird.silly_adjective #=> 'drunk'
                #
                def silly_adjective()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.bird.silly_adjectives"))));
                end
                end
            end
        class Cat < Base
            class << self
                ##
                # Produces a random cat breed.
                #                                 <p>Produces a random cat breed</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Cat.breed #=> "Scottish Fold"
                #
                def breed()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.cat.breed"))));
                end
                ##
                # Produces a random name for a cat.
                #                                 <p>Produces a random name for a cat</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Cat.name #=> "Felix"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.cat.name"))));
                end
                ##
                # Produces a random cat breed registry.
                #                                 <p>Produces a random cat breed registry</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Cat.registry #=> "Fancy Southern Africa Cat Council"
                #
                def registry()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.cat.registry"))));
                end
                end
            end
        class Dog < Base
            class << self
                ##
                # Produces a random dog age.
                #                                 <p>Produces a random dog age</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.age #=> "puppy"
                #
                def age()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.age"))));
                end
                ##
                # Produces a random dog breed.
                #                                 <p>Produces a random dog breed</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.breed #=> "Yorkshire Terrier"
                #
                def breed()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.breed"))));
                end
                ##
                # Produces a random coat length.
                #                                 <p>Produces a random coat length</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.coat_length #=> "short"
                #
                def coat_length()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.coat_length"))));
                end
                ##
                # Produces a random gender.
                #                                 <p>Produces a random gender</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.gender #=> "Female"
                #
                def gender()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a random dog meme phrase.
                #                                 <p>Produces a random dog meme phrase</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.meme_phrase #=> "smol pupperino"
                #
                def meme_phrase()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.meme_phrase"))));
                end
                ##
                # Produces a random name for a dog.
                #                                 <p>Produces a random name for a dog</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.name #=> "Spike"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.name"))));
                end
                ##
                # Produces a random size of a dog.
                #                                 <p>Produces a random size of a dog</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.size #=> "small"
                #
                def size()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.size"))));
                end
                ##
                # Produces a random sound made by a dog.
                #                                 <p>Produces a random sound made by a dog</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Dog.sound #=> "woof woof"
                #
                def sound()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.dog.sound"))));
                end
                end
            end
        class Horse < Base
            class << self
                ##
                # Produces a random horse breed.
                #                                 <p>Produces a random horse breed</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Horse.breed #=> "Spanish Barb see Barb Horse"
                #
                def breed()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.horse.breed"))));
                end
                ##
                # Produces a random name for a horse.
                #                                 <p>Produces a random name for a horse</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Creature::Horse.name #=> "Noir"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("creature.horse.name"))));
                end
                end
            end
        end
    class Crypto < Base
        class << self
            ##
            # Produces an MD5 hash.
            #
            # @return [String]
            #
            # @example
            #     Faker::Crypto.md5 #=> "6b5ed240042e8a65c55ddb826c3408e6"
            #
            def md5()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a SHA1 hash.
            #
            # @return [String]
            #
            # @example
            #     Faker::Crypto.sha1 #=> "4e99e31c51eef8b2d290e709f757f92e558a503f"
            #
            def sha1()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a SHA256 hash.
            #
            # @return [String]
            #
            # @example
            #     Faker::Crypto.sha256 #=> "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"
            #
            def sha256()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a SHA512 hash.
            #
            # @return [String]
            #
            # @example
            #     Faker::Crypto.sha512 #=> "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"
            #
            def sha512()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class CryptoCoin < Base
        class << self
            ##
            # Produces a random crypto coin acronym.
            #
            # @return [String]
            #
            # @example
            #     Faker::CryptoCoin.acronym #=> "BTC"
            #
            def acronym()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random crypto coin's name, acronym and logo in an array.
            #
            # @return [Array<String>]
            #
            # @example
            #     Faker::CryptoCoin.coin_array #=> ["Dash", "DASH", "https://i.imgur.com/2uX91cb.png"]
            #
            def coin_array()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("crypto_coin.coin"))));
            end
            ##
            # Produces a random crypto coin's name, acronym and logo in a hash.
            #
            # @return [Hash]
            #
            # @example
            #     Faker::CryptoCoin.coin_hash {:name=>"Ethereum", :acronym=>"ETH", :url_logo=>"https://i.imgur.com/uOPFCXj.png"}
            #
            def coin_hash()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random crypto coin name.
            #
            # @return [String]
            #
            # @example
            #     Faker::CryptoCoin.coin_name #=> "Bitcoin"
            #
            def coin_name()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random crypto coin logo url.
            #
            # @return [String]
            #
            # @example
            #     Faker::CryptoCoin.url_logo #=> "https://i.imgur.com/EFz61Ei.png"
            #
            def url_logo()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Currency < Base
        class << self
            ##
            # Produces a currency code.
            #
            # @return [String]
            #
            # @example
            #     Faker::Currency.code #=> "USD"
            #
            def code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("currency.code"))));
            end
            ##
            # Produces the name of a currency.
            #
            # @return [String]
            #
            # @example
            #     Faker::Currency.name #=> "Swedish Krona"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("currency.name"))));
            end
            ##
            # Produces a currency symbol.
            #
            # @return [String]
            #
            # @example
            #     Faker::Currency.symbol #=> "$"
            #
            def symbol()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("currency.symbol"))));
            end
            end
        end
    class Date < Base
        class << self
            ##
            # Produce a random date in the past (up to N days).
            #
            # @param days [Integer]   
            #   <p>The maximum number of days to go into the past.</p>
            #    (default value "365")
            #
            # @return [Date]
            #
            # @example
            #     Faker::Date.backward(days: 14) #=> #<Date: 2019-09-12>
            #
            def backward(days: 365)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random date between two dates.
            #
            # @param from [Date]   
            #   <p>The start of the usable date range.</p>
            #   
            #
            # @param to [Date]   
            #   <p>The end of the usable date range.</p>
            #   
            #
            # @return [Date]
            #
            # @example
            #     
            #     <p>if used with or without Rails (Active Support)</p>
            #     
            #     Faker::Date.between(from: '2014-09-23', to: '2014-09-25') #=> #<Date: 2014-09-24>
            #
            def between(from, to)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random date between two dates.
            #
            # @param from [Date]   
            #   <p>The start of the usable date range.</p>
            #   
            #
            # @param to [Date]   
            #   <p>The end of the usable date range.</p>
            #   
            #
            # @param excepted [Date]   
            #   <p>A date to exclude.</p>
            #   
            #
            # @return [Date]
            #
            # @example
            #     
            #     <p>if used with or without Rails (Active Support)</p>
            #     
            #     Faker::Date.between_except(from: '2014-09-23', to: '2015-09-25', excepted: '2015-01-24') #=> #<Date: 2014-10-03>
            #
            def between_except(from, to, excepted)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random date in the past (up to N days).
            #
            # @param min_age [Integer]   
            #   <p>The minimum age that the birthday would imply.</p>
            #   
            #
            # @param max_age [Integer]   
            #   <p>The maximum age that the birthday would imply.</p>
            #    (default value "65")
            #
            # @return [Date]
            #
            # @example
            #     Faker::Date.birthday(min_age: 18, max_age: 65) #=> #<Date: 1986-03-28>
            #
            def birthday(min_age, max_age: 65)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method birthday_date"
            ##
            # Produce a random date in the future (up to N days).
            #
            # @param from [Integer]   
            #   <p>The start of the usable forward date range.</p>
            #   
            #
            # @param days [Integer]   
            #   <p>The maximum number of days to go into the future.</p>
            #    (default value "365")
            #
            # @return [Date]
            #
            # @example
            #     
            #     <p>if used with or without Rails (Active Support)</p>
            #     
            #     Faker::Date.forward(days: 23) #=> #<Date: 2014-10-03>
            #
            def forward(from, days: 365)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method get_date_object"
            ##
            # Produces a date in the year and/or month specified.
            #
            # @param month [Integer]   
            #   <p>represents the month of the date</p>
            #   
            #
            # @param year [Integer]   
            #   <p>represents the year of the date</p>
            #    (default value "::Date.today.year")
            #
            # @return [Date]
            #
            # @example
            #     Faker::Date.in_date_period #=> #<Date: 2019-09-01>
            #
            def in_date_period(month, year: ::Date.today.year)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random date at given day(s) of the week between two dates.
            #
            # @param day [Symbol]   
            #   <p># The day(s) of the week. See {DAYS_OF_WEEK}.</p>
            #   
            #
            # @param from [Date]   
            #   <p>The start of the usable date range.</p>
            #   
            #
            # @param to [Date]   
            #   <p>The end of the usable date range.</p>
            #   
            #
            # @return [Date]
            #
            # @example
            #     
            #     <p>if used with or without Rails (Active Support)</p>
            #     
            #     Faker::Date.on_day_of_week_between(day: :tuesday, from: '2023-01-01', to: '2023-02-01') #=> #<Date: 2032-01-10>
            #
            def on_day_of_week_between(day, from, to)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class DcComics < Base
        class << self
            ##
            # Produces a hero name from DC Comics.
            #                             <p>Produces a hero name from DC Comics</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::DcComics.hero #=> "Batman"
            #
            def hero()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dc_comics.hero"))));
            end
            ##
            # Produces a heroine name from DC Comics.
            #                             <p>Produces a heroine name from DC Comics</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::DcComics.heroine #=> "Supergirl"
            #
            def heroine()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dc_comics.heroine"))));
            end
            ##
            # Produces a character name from DC Comics.
            #                             <p>Produces a character name from DC Comics</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::DcComics.name #=> "Clark Kent"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dc_comics.name"))));
            end
            ##
            # Produces a comic book title from DC Comics.
            #                             <p>Produces a comic book title from DC Comics</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::DcComics.title #=> "Batman: The Long Halloween"
            #
            def title()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dc_comics.title"))));
            end
            ##
            # Produces a villain name from DC Comics.
            #                             <p>Produces a villain name from DC Comics</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::DcComics.villain #=> "The Joker"
            #
            def villain()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dc_comics.villain"))));
            end
            end
        end
    class Demographic < Base
        class << self
            ##
            # Produces a denonym.
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.denonym #=> "Panamanian"
            #
            def demonym()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("demographic.demonym"))));
            end
            ##
            # Produces a level of educational attainment.
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.educational_attainment #=> "GED or alternative credential"
            #
            def educational_attainment()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("demographic.educational_attainment"))));
            end
            ##
            # Produces a height as a string.
            #
            # @param unit [Symbol]   
            #   <p>either ‘:metric` or `imperial`.</p>
            #    (default value ":metric")
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.height #=> "1.61"
            #
            def height(unit: :metric)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a marital status.
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.marital_status #=> "Widowed"
            #
            def marital_status()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("demographic.marital_status"))));
            end
            ##
            # Produces the name of a race.
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.race #=> "Native Hawaiian or Other Pacific Islander"
            #
            def race()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("demographic.race"))));
            end
            ##
            # Produces a sex for demographic purposes.
            #
            # @return [String]
            #
            # @example
            #     Faker::Demographic.sex #=> "Female"
            #
            def sex()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("demographic.sex"))));
            end
            end
        end
    class Dessert < Base
        class << self
            ##
            # Produces the name of a dessert flavor.
            #
            # @return [String]
            #
            # @example
            #     Faker::Dessert.flavor #=> "Salted Caramel"
            #
            def flavor()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dessert.flavor"))));
            end
            ##
            # Produces the name of a dessert topping.
            #
            # @return [String]
            #
            # @example
            #     Faker::Dessert.topping #=> "Gummy Bears"
            #
            def topping()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dessert.topping"))));
            end
            ##
            # Produces the name of a dessert variety.
            #
            # @return [String]
            #
            # @example
            #     Faker::Dessert.variety #=> "Cake"
            #
            def variety()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dessert.variety"))));
            end
            end
        end
    class Device < Base
        class << self
            ##
            # Produces a build number between 1 and 500.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Device.build_number #=> 5
            #
            def build_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces the name of a manufacturer for a device.
            #
            # @return [String]
            #
            # @example
            #     Faker::Device.manufacturer #=> "Apple"
            #
            def manufacturer()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("device.manufacturer"))));
            end
            ##
            # Produces a model name for a device.
            #
            # @return [String]
            #
            # @example
            #     Faker::Device.model_name #=> "iPhone 4"
            #
            def model_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("device.model_name"))));
            end
            ##
            # Produces the name of a platform for a device.
            #
            # @return [String]
            #
            # @example
            #     Faker::Device.platform #=> "webOS"
            #
            def platform()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("device.platform"))));
            end
            ##
            # Produces a serial code for a device.
            #
            # @return [String]
            #
            # @example
            #     Faker::Device.serial #=> "ejfjnRNInxh0363JC2WM"
            #
            def serial()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("device.serial"))));
            end
            ##
            # Produces a version number between 1 and 1000.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Device.version #=> 42
            #
            def version()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class DrivingLicence < Base
        class << self
            ##
            # Produces a random British driving licence number.
            #
            # @param last_name [String]   
            #   <p>The last name of the driving licence’s owner.</p>
            #   
            #
            # @param initials [String]   
            #   <p>The initials of the driving licence’s owner.</p>
            #   
            #
            # @param gender [String]   
            #   <p>The gender of the driving licence’s owner.</p>
            #   
            #
            # @param date_of_birth [String]   
            #   <p>The date of birth of the driving licence’s owner.</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::DrivingLicence.british_driving_licence        #=> "MCDER712081VF7EK"
            #                                         Faker::DrivingLicence.british_driving_licence(last_name: "O'Carroll",
            #                                         initials: "J",
            #                                         gender: :female,
            #                                         date_of_birth: Date.parse("1986-10-24")) #=> "OCARR815246J91HT"
            #                                     
            #
            def british_driving_licence(last_name, initials, gender, date_of_birth)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method gb_licence_checksum"
            warn  "Failed processing method gb_licence_padding"
            warn  "Failed processing method gb_licence_year"
            ##
            # Produces a random Northern Irish licence number.
            #
            # @return [String]
            #
            # @example
            #     Faker::DrivingLicence.northern_irish_driving_licence #=> "70702548"
            #
            def northern_irish_driving_licence()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method random_gender"
            warn  "Failed processing method uk_driving_licence"
            ##
            # Produces a random USA driving licence number by state code passed.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::DrivingLicence.usa_driving_licence                 #=> "V5598249"
            #                                         Faker::DrivingLicence.usa_driving_licence('new mexico')   #=> "270692028"
            #                                         Faker::DrivingLicence.usa_driving_licence('New Mexico')   #=> "68178637"
            #                                     
            #
            def usa_driving_licence()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("driving_licence.usa.#{state.to_s.strip.downcase.gsub(' ', '_')}"))));
            end
            # @return [String]
            #
            def initialize()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Drone < Base
        class << self
            ##
            # Returns the drone battery capacity.
            #                             <p>Returns the drone battery capacity</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.battery_capacity #=> "3500 mAh"
            #
            def battery_capacity()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.battery_capacity"))));
            end
            ##
            # Returns the battery type.
            #                             <p>Returns the battery type</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.battery_type #=> "LiPo 4S"
            #
            def battery_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.battery_type"))));
            end
            ##
            # Returns battery voltage.
            #                             <p>Returns battery voltage</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.battery_voltage #=> "13.2V"
            #
            def battery_voltage()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.battery_voltage"))));
            end
            ##
            # Returns total battery weight in grams.
            #                             <p>Returns total battery weight in grams</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.battery_weight #=> "198 g"
            #
            def battery_weight()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.battery_weight"))));
            end
            ##
            # Returns charging temperature for battery in Fahrenheit.
            #                             <p>Returns charging temperature for battery in Fahrenheit</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.charging_temperature #=> "41-104F"
            #
            def charging_temperature()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.charging_temperature"))));
            end
            ##
            # Returns max flight time for drone in optimal conditions.
            #                             <p>Returns max flight time for drone in optimal conditions</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.flight_time #=> "34 min"
            #
            def flight_time()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.flight_time"))));
            end
            ##
            # Returns camera ISO range for drone.
            #                             <p>Returns camera ISO range for drone</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.iso #=> "100-3200"
            #
            def iso()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.iso"))));
            end
            ##
            # Returns max altitude drone can go above sea level in meters.
            #                             <p>Returns max altitude drone can go above sea level in meters</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_altitude #=> "5000 m"
            #
            def max_altitude()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_altitude"))));
            end
            ##
            # Returns max angular velocity of drone in degrees/s.
            #                             <p>Returns max angular velocity of drone in degrees/s</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_angular_velocity #=> "250 degree/s"
            #
            def max_angular_velocity()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_angular_velocity"))));
            end
            ##
            # Returns maximum ascent speed for drone in m/s.
            #                             <p>Returns maximum ascent speed for drone in m/s</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_ascent_speed #=> "4 m/s"
            #
            def max_ascent_speed()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_ascent_speed"))));
            end
            ##
            # Returns max chargin power required for battery.
            #                             <p>Returns max chargin power required for battery</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_charging_power #=> "38W"
            #
            def max_charging_power()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_charging_power"))));
            end
            ##
            # Returns maximum descent speed for drone in m/s.
            #                             <p>Returns maximum descent speed for drone in m/s</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_descent_speed #=> "4 m/s"
            #
            def max_descent_speed()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_descent_speed"))));
            end
            ##
            # Returns how far drone can go in optimal condition when full charged in meters.
            #                             <p>Returns how far drone can go in optimal condition when full charged in meters</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_flight_distance #=> "18500 m"
            #
            def max_flight_distance()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_flight_distance"))));
            end
            ##
            # Returns max camera resolution in MP".
            #                             <p>Returns max camera resolution in MP“</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_resolution #=> "48MP"
            #
            def max_resolution()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_resolution"))));
            end
            ##
            # Returns max shutter speed for camera.
            #                             <p>Returns max shutter speed for camera</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_shutter_speed #=> "60s"
            #
            def max_shutter_speed()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_shutter_speed"))));
            end
            ##
            # Returns max horizontal speed by drone in m/s.
            #                             <p>Returns max horizontal speed by drone in m/s</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_speed #=> "19 m/s"
            #
            def max_speed()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_speed"))));
            end
            ##
            # Returns max tilt angle drone can go in degrees.
            #                             <p>Returns max tilt angle drone can go in degrees</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_tilt_angle #=> "35 degrees"
            #
            def max_tilt_angle()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_tilt_angle"))));
            end
            ##
            # Returns max wind resistance by drone in m/s.
            #                             <p>Returns max wind resistance by drone in m/s</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.max_wind_resistance #=> "10.5 m/s"
            #
            def max_wind_resistance()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_wind_resistance"))));
            end
            ##
            # Returns min shutter speed for camera.
            #                             <p>Returns min shutter speed for camera</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.min_shutter_speed #=> "1/8000s"
            #
            def min_shutter_speed()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.min_shutter_speed"))));
            end
            ##
            # Returns random drone name with company.
            #                             <p>Returns random drone name with company</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.name #=> "DJI Mavic Air 2"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.name"))));
            end
            ##
            # Returns operating temperature for drone in Fahrenheit.
            #                             <p>Returns operating temperature for drone in Fahrenheit</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.operating_temperature #=> "14-104F"
            #
            def operating_temperature()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.operating_temperature"))));
            end
            ##
            # Returns photo format for drone.
            #                             <p>Returns photo format for drone</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.photo_format #=> "JPEG"
            #
            def photo_format()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.photo_format"))));
            end
            ##
            # Returns max and min shutter speed for camera.
            #                             <p>Returns max and min shutter speed for camera</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.shutter_speed_range #=> "8-1/8000s"
            #
            def shutter_speed_range()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.max_shutter_speed"))));
            end
            ##
            # Returns video format.
            #                             <p>Returns video format</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.video_format #=> "MP4"
            #
            def video_format()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.video_format"))));
            end
            ##
            # Returns total drone weight in grams.
            #                             <p>Returns total drone weight in grams</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Drone.weight #=> "570 g"
            #
            def weight()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("drone.weight"))));
            end
            end
        end
    class Educator < Base
        class << self
            ##
            # Produces a campus name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.campus #=> "Vertapple Campus"
            #
            def campus()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.campus"))));
            end
            ##
            # Produces a course name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.course_name #=> "Criminology 101"
            #
            def course_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.course_name"))));
            end
            ##
            # Produces a university degree.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.degree #=> "Associate Degree in Criminology"
            #
            def degree()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.degree"))));
            end
            ##
            # Produces a primary school.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.primary_school #=> "Brighthurst Elementary School"
            #
            def primary_school()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.primary_school"))));
            end
            ##
            # Produces a secondary school.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.secondary_school #=> "Iceborough Secondary College"
            #
            def secondary_school()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.secondary_school"))));
            end
            ##
            # Produces a university subject.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.subject #=> "Criminology"
            #
            def subject()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.subject"))));
            end
            ##
            # Produces a university name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Educator.university #=> "Mallowtown Technical College"
            #
            def university()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("educator.university"))));
            end
            end
        end
    class ElectricalComponents < Base
        class << self
            ##
            # Produces an active electrical component.
            #
            # @return [String]
            #
            # @example
            #     Faker::ElectricalComponents.active #=> "Transistor"
            #
            def active()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("electrical_components.active"))));
            end
            ##
            # Produces an electromechanical electrical component.
            #
            # @return [String]
            #
            # @example
            #     Faker::ElectricalComponents.electromechanical #=> "Toggle Switch"
            #
            def electromechanical()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("electrical_components.electromechanical"))));
            end
            ##
            # Produces a passive electrical component.
            #
            # @return [String]
            #
            # @example
            #     Faker::ElectricalComponents.passive #=> "Resistor"
            #
            def passive()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("electrical_components.passive"))));
            end
            end
        end
    class Emotion < Base
        class << self
            ##
            # Produces an emotion adjective.
            #
            # @return [String]
            #
            # @example
            #     Faker::Emotion.adjective # => "nonplussed"
            #
            def adjective()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("emotion.adjective"))));
            end
            ##
            # Produces an emotion noun.
            #
            # @return [String]
            #
            # @example
            #     Faker::Emotion.noun #=> "amazement"
            #
            def noun()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("emotion.noun"))));
            end
            end
        end
    class Esport < Base
        class << self
            ##
            # Produces the name of an eSports event.
            #
            # @return [String]
            #
            # @example
            #     Faker::Esport.event #=> "ESL Cologne"
            #
            def event()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("esport.events"))));
            end
            ##
            # Produces the name of a game played as an eSport.
            #
            # @return [String]
            #
            # @example
            #     Faker::Esport.game #=> "Dota 2"
            #
            def game()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("esport.games"))));
            end
            ##
            # Produces the name of an eSports league.
            #
            # @return [String]
            #
            # @example
            #     Faker::Esport.league #=> "IEM"
            #
            def league()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("esport.leagues"))));
            end
            ##
            # Produces the name of a professional eSports player.
            #
            # @return [String]
            #
            # @example
            #     Faker::Esport.player #=> "Crimsix"
            #
            def player()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("esport.players"))));
            end
            ##
            # Produces the name of an eSports team.
            #
            # @return [String]
            #
            # @example
            #     Faker::Esport.team #=> "CLG"
            #
            def team()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("esport.teams"))));
            end
            end
        end
    class Fantasy
        class Tolkien < Base
            class << self
                ##
                # Produces a character from Tolkien's legendarium.
                #                                 <p>Produces a character from Tolkien’s legendarium</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Fantasy::Tolkien.character
                #                                             #=> "Goldberry"
                #                                         
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.characters"))));
                end
                ##
                # Produces a location from Tolkien's legendarium.
                #                                 <p>Produces a location from Tolkien’s legendarium</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Fantasy::Tolkien.location
                #                                             #=> "Helm's Deep"
                #                                         
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.locations"))));
                end
                ##
                # Produces the name of a poem from Tolkien's legendarium.
                #                                 <p>Produces the name of a poem from Tolkien’s legendarium</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Fantasy::Tolkien.poem
                #                                             #=> "Chip the glasses and crack the plates"
                #                                         
                #
                def poem()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.poems"))));
                end
                ##
                # Produces a race from Tolkien's legendarium.
                #                                 <p>Produces a race from Tolkien’s legendarium</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Fantasy::Tolkien.race
                #                                             #=> "Uruk-hai"
                #                                         
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.races"))));
                end
                end
            end
        end
    class File < Base
        class << self
            ##
            # Produces a random directory name.
            #
            # @param segment_count [Integer]   
            #   <p>Specifies the number of nested folders in the generated string.</p>
            #   
            #
            # @param root [String]   
            #   <p>Specifies the root of the generated string.</p>
            #   
            #
            # @param directory_separator [String]   
            #   <p>Specifies the separator between the segments.</p>
            #    (default value "::File::Separator")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::File.dir #=> "et_error/sint_voluptas/quas_veritatis"
            #                                         Faker::File.dir(segment_count: 2) #=> "ea-suscipit/ut-deleniti"
            #                                         Faker::File.dir(segment_count: 3, root: nil, directory_separator: '/') #=> "est_porro/fugit_eveniet/incidunt-autem"
            #                                         Faker::File.dir(segment_count: 3, root: nil, directory_separator: '\\') #=> "aut-ullam\\quia_quisquam\\ut-eos"
            #                                     
            #
            def dir(segment_count, root, directory_separator: ::File::Separator)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random file extension.
            #
            # @return [String]
            #
            # @example
            #     Faker::File.extension #=> "mp3"
            #
            def extension()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("file.extension"))));
            end
            ##
            # Produces a random file name.
            #
            # @param dir [String]   
            #   <p>Specifies the path used for the generated file.</p>
            #   
            #
            # @param name [String]   
            #   <p>Specifies the filename used for the generated file.</p>
            #   
            #
            # @param ext [String]   
            #   <p>Specifies the extension used the generated file.</p>
            #   
            #
            # @param directory_separator [String]   
            #   <p>Specifies the separator between the directory and name elements.</p>
            #    (default value "::File::Separator")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::File.file_name(dir: 'path/to') #=> "path/to/something_random.jpg"
            #                                         Faker::File.file_name(dir: 'foo/bar', name: 'baz') #=> "foo/bar/baz.zip"
            #                                         Faker::File.file_name(dir: 'foo/bar', name: 'baz', ext: 'doc') #=> "foo/bar/baz.doc"
            #                                         Faker::File.file_name(dir: 'foo/bar', name: 'baz', ext: 'mp3', directory_separator: '\\') #=> "foo/bar\\baz.mp3"
            #                                     
            #
            def file_name(dir, name, ext, directory_separator: ::File::Separator)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random mime type.
            #
            # @return [String]
            #
            # @example
            #     Faker::File.mime_type #=> "application/pdf"
            #
            def mime_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("file.mime_type.#{media_type}"))));
            end
            end
        end
    class Finance < Base
        class << self
            ##
            # Returns a random condominium fiscal code.
            #
            # @param country [String]   
            #   <p>Two capital letter country code to use for the vat number.</p>
            #    (default value "'IT'")
            #
            # @return [String]
            #
            # @example
            #     Faker::Finance.condominium_fiscal_code #=> "012345678"
            #
            def condominium_fiscal_code(country: 'IT')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("finance.condominium_fiscal_code.#{country}"))));
            end
            ##
            # Produces a random credit card number.
            #
            # @param types [String]   
            #   <p>Specific credit card type.</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Finance.credit_card #=> "3018-348979-1853"
            #                                         Faker::Finance.credit_card(:mastercard) #=> "6771-8921-2291-6236"
            #                                         Faker::Finance.credit_card(:mastercard, :visa) #=> "4448-8934-1277-7195"
            #                                     
            #
            def credit_card(types)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("finance.credit_card.#{type}"))));
            end
            ##
            # Returns a randomly-selected stock market.
            #
            # @return [String]
            #
            # @example
            #     Faker::Finance.stock_market #=> 'NASDAQ'
            #
            def stock_market()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("finance.stock_market"))));
            end
            ##
            # Returns a randomly-selected stock ticker from a specified market.
            #
            # @param markets [String]   
            #   <p>The name of the market to choose the ticker from (e.g. NYSE, NASDAQ)</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Finance.ticker #=> 'AMZN'
            #                                         Faker::Finance.vat_number('NASDAQ') #=> 'GOOG'
            #                                     
            #
            def ticker(markets)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("finance.ticker.#{market}"))));
            end
            ##
            # Produces a random vat number.
            #
            # @param country [String]   
            #   <p>Two capital letter country code to use for the vat number.</p>
            #    (default value "'BR'")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Finance.vat_number #=> "BR38.395.329/2471-83"
            #                                         Faker::Finance.vat_number('DE') #=> "DE593306671"
            #                                         Faker::Finance.vat_number('ZA') #=> "ZA79494416181"
            #                                     
            #
            def vat_number(country: 'BR')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("finance.vat_number.#{country}"))));
            end
            warn  "Failed processing method vat_number_keys"
            end
        end
    class Food < Base
        class << self
            ##
            # Retrieves an allergen.
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.allergen #=> "Peanuts"
            #
            def allergen()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.allergens"))));
            end
            ##
            # Retrieves a description about some dish.
            #                             <p>Retrieves a description about some dish</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.description #=> "Breaded fried chicken with waffles. Served with maple syrup."
            #
            def description()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.descriptions"))));
            end
            ##
            # Retrieves a typical dish from each country.
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.dish #=> "Feijoada"
            #
            def dish()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.dish"))));
            end
            ##
            # Retrieves ethnic category.
            #                             <p>Retrieves ethnic category</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.ethnic_category #=> "Indian cuisine"
            #
            def ethnic_category()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.ethnic_category"))));
            end
            ##
            # Retrieves a fruit.
            #                             <p>Retrieves a fruit</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.fruits #=> "Papaya"
            #
            def fruits()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.fruits"))));
            end
            ##
            # Retrieves an ingredient.
            #                             <p>Retrieves an ingredient</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.ingredient #=> "Olives"
            #
            def ingredient()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.ingredients"))));
            end
            ##
            # Retrieves cooking measures.
            #                             <p>Retrieves cooking measures</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.measurement #=> "1/3"
            #
            def measurement()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.measurement_sizes"))));
            end
            ##
            # Retrieves metric measurements.
            #                             <p>Retrieves metric measurements</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.metric_measurement #=> "centiliter"
            #
            def metric_measurement()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.metric_measurements"))));
            end
            ##
            # Retrieves some random spice.
            #                             <p>Retrieves some random spice</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.spice #=> "Garlic Chips"
            #
            def spice()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.spices"))));
            end
            ##
            # Retrieves a vegetable.
            #                             <p>Retrieves a vegetable</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Food.vegetables #=> "Broccolini"
            #
            def vegetables()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("food.vegetables"))));
            end
            end
        end
    class FunnyName < Base
        class << self
            ##
            # Retrieves a funny four word name.
            #
            # @return [String]
            #
            # @example
            #     Faker::FunnyName.four_word_name #=> "Maude L. T. Ford"
            #
            def four_word_name()
                return fetch("funny_name.name");
            end
            ##
            # Retrieves a funny name.
            #
            # @return [String]
            #
            # @example
            #     Faker::FunnyName.name #=> "Sam Pull"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("funny_name.name"))));
            end
            ##
            # Retrieves a funny name with an initial.
            #
            # @return [String]
            #
            # @example
            #     Faker::FunnyName.name_with_initial #=> "Heather N. Yonn"
            #
            def name_with_initial()
                return fetch("funny_name.name");
            end
            ##
            # Retrieves a funny three word name.
            #
            # @return [String]
            #
            # @example
            #     Faker::FunnyName.three_word_name #=> "Carson O. Gin"
            #
            def three_word_name()
                return fetch("funny_name.name");
            end
            ##
            # Retrieves a funny two word name.
            #
            # @return [String]
            #
            # @example
            #     Faker::FunnyName.two_word_name #=> "Shirley Knot"
            #
            def two_word_name()
                return fetch("funny_name.name");
            end
            end
        end
    class Game < Base
        class << self
            ##
            # Produces the name of a video game genre.
            #
            # @return [String]
            #
            # @example
            #     Faker::Game.genre #=> "Real-time strategy"
            #
            def genre()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game.genre"))));
            end
            ##
            # Produces the name of a video game console or platform.
            #
            # @return [String]
            #
            # @example
            #     Faker::Game.platform #=> "Nintendo Switch"
            #
            def platform()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game.platform"))));
            end
            ##
            # Produces the name of a video game.
            #
            # @return [String]
            #
            # @example
            #     Faker::Game.title #=> "Half-Life 2"
            #
            def title()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game.title"))));
            end
            end
        end
    class Games
        class ClashOfClans < Base
            class << self
                ##
                # Produces the name of a defensive building from Clash Of Clans.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ClashOfClans.defensive_building #=> "Cannon"
                #
                def defensive_building()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.clash_of_clans.defensive_buildings"))));
                end
                ##
                # Produces the name of a rank from Clash Of Clans.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ClashOfClans.rank #=> "Legend"
                #
                def rank()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.clash_of_clans.ranks"))));
                end
                ##
                # Produces the name of a troop from Clash of Clans.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ClashOfClans.troop #=> "Barbarian"
                #
                def troop()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.clash_of_clans.troops"))));
                end
                end
            end
        class Control < Base
            class << self
                ##
                # Produces the name of an Altered Item.
                #                                 <p>Produces the name of an Altered Item</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.altered_item #=> "Rubber Duck"
                #
                def altered_item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.altered_item"))));
                end
                ##
                # Produces the location of an Altered World Event (AWE).
                #                                 <p>Produces the location of an Altered World Event (AWE)</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.altered_world_event #=> "Ordinary, Wisconsin"
                #
                def altered_world_event()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.altered_world_event"))));
                end
                ##
                # Produces the name of a character from Control.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.character #=> "Jesse Faden"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.character"))));
                end
                ##
                # Produces a line from the Hiss incantation.
                #                                 <p>Produces a line from the Hiss incantation</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.hiss #=> "Push the fingers through the surface into the wet."
                #
                def hiss()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.hiss"))));
                end
                ##
                # Produces the name of a location from Control.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.location #=> "Dimensional Research"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.location"))));
                end
                ##
                # Produces the name of an Object of Power (OoP).
                #                                 <p>Produces the name of an Object of Power (OoP)</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.object_of_power #=> "Hotline"
                #
                def object_of_power()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.object_of_power"))));
                end
                ##
                # Produces a quote from Control.
                #                                 <p>Produces a quote from Control</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.quote #=> "He never liked fridge duty"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.quote"))));
                end
                ##
                # < Produces a line/quote/message from The Board >.
                #                                 <p>&lt; Produces a line/quote/message from The Board &gt;</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Control.the_board #=> "< You/We wield the Gun/You. The Board appoints you. Congratulations, Director. >"
                #
                def the_board()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.control.the_board"))));
                end
                end
            end
        class DnD < Base
            class << self
                ##
                # Produces the name of an alignment from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.alignment #=> "Lawful Neutral"
                #
                def alignment()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.alignments"))));
                end
                ##
                # Produces the name of a background from Dungeons and Dragons (PHB).
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.background #=> "Urchin"
                #
                def background()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.backgrounds"))));
                end
                ##
                # Produces the name of a city from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.city #=> "Earthfast"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.cities"))));
                end
                ##
                # Produces the first name of a character or monster from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.name #=> "Eilonwy"
                #
                def first_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.name.first_name"))));
                end
                ##
                # Produces the name of a class from Dungeons and Dragons (PHB).
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.klass #=> "Warlock"
                #
                def klass()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.klasses"))));
                end
                ##
                # Produces the name of a language from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.language #=> "Gnomish"
                #
                def language()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.languages"))));
                end
                ##
                # Produces a last name from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.last_name #=> "Leafwhisper"
                #
                def last_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.name.last_name"))));
                end
                ##
                # Produces the name of a melee weapon from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.melee_weapon #=> "Handaxe"
                #
                def melee_weapon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.melee_weapons"))));
                end
                ##
                # Produces the name of a monster from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.monster #=> "Manticore"
                #
                def monster()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.monsters"))));
                end
                ##
                # Produces a full name from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.name #=> "Drakon Blackthorn"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.name.first_name"))));
                end
                ##
                # Produces the name of a race from Dungeons and Dragons (PHB).
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.races #=> "Dwarf"
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.races"))));
                end
                ##
                # Produces the name of a ranged weapon from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.ranged_weapon #=> "Shortbow"
                #
                def ranged_weapon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.ranged_weapons"))));
                end
                ##
                # Produces a last name from Dungeons and Dragons.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DnD.title_name #=> "Corvus the Cunning"
                #
                def title_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dnd.name.first_name"))));
                end
                end
            end
        class Dota < Base
            class << self
                ##
                # Produces the name of a building from Dota.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Dota.building #=> "Tower"
                #
                def building()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.building"))));
                end
                ##
                # Produces the name of a hero from Dota.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Dota.hero #=> "Abaddon"
                #
                def hero()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.hero"))));
                end
                ##
                # Produces the name of an item from Dota.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Dota.item #=> "Armlet of Mordiggian"
                #
                def item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.item"))));
                end
                ##
                # Produces the name of a professional Dota player.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Dota.player #=> "Dendi"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.player"))));
                end
                ##
                # Produces the name of a hero from Dota.
                #
                # @param hero [String]   
                #   <p>The name of a Dota hero.</p>
                #    (default value "'abaddon'")
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Games::Dota.quote #=> "You have called death upon yourself."
                #                                             Faker::Games::Dota.quote(hero: 'alchemist') #=> "Better living through alchemy!"
                #                                         
                #
                def quote(hero: 'abaddon')
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.#{hero}.quote"))));
                end
                ##
                # Produces the name of a professional Dota team.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Dota.team #=> "Evil Geniuses"
                #
                def team()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.dota.team"))));
                end
                end
            end
        class ElderScrolls < Base
            class << self
                ##
                # Produces the name of a city from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.city #=> "Whiterun"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.city"))));
                end
                ##
                # Produces the name of a creature from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.creature #=> "Frost Troll"
                #
                def creature()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.creature"))));
                end
                ##
                # Produces the name of a dragon from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.dragon #=> "Blood Dragon"
                #
                def dragon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.dragon"))));
                end
                ##
                # Produces a first name from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.first_name #=> "Balgruuf"
                #
                def first_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.first_name"))));
                end
                ##
                # Produces a weapon from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.jewelry #=> "Silver Ruby Ring"
                #
                def jewelry()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.jewelry"))));
                end
                ##
                # Produces a last name from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.last_name #=> "The Old"
                #
                def last_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.last_name"))));
                end
                ##
                # Produces a randomly generated name from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.name #=> "Balgruuf The Old"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.first_name"))));
                end
                ##
                # Produces the name of a race from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.race #=> "Argonian"
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.race"))));
                end
                ##
                # Produces the name of a region from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.region #=> "Cyrodiil"
                #
                def region()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.region"))));
                end
                ##
                # Produces a weapon from the Elder Scrolls universe.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::ElderScrolls.weapon #=> "Elven Bow"
                #
                def weapon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.elder_scrolls.weapon"))));
                end
                end
            end
        class Fallout < Base
            class << self
                ##
                # Produces the name of a character from the Fallout games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Fallout.character #=> "Liberty Prime"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.fallout.characters"))));
                end
                ##
                # Produces the name of a faction from the Fallout games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Fallout.faction #=> "Brotherhood of Steel"
                #
                def faction()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.fallout.factions"))));
                end
                ##
                # Produces the name of a location from the Fallout games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Fallout.location #=> "New Vegas"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.fallout.locations"))));
                end
                ##
                # Produces a quote from the Fallout games.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Games::Fallout.quote
                #                                             #=> "Democracy is non-negotiable"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.fallout.quotes"))));
                end
                end
            end
        class FinalFantasyXIV < Base
            class << self
                ##
                # Produces the name of a character from FFXIV.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::FinalFantasyXIV.character #=> "Y'shtola Rhul"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.final_fantasy_xiv.characters"))));
                end
                ##
                # Produces a data center from Final Fantasy XIV.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::FinalFantasyXIV.data_center #=> "Aether"
                #
                def data_center()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.final_fantasy_xiv.data_centers"))));
                end
                ##
                # Produces a job name from Final Fantasy XIV.
                #                                 <p>Either a battle or non-battle playable job.</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::FinalFantasyXIV.job #=> "Paladin"
                #
                def job()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.final_fantasy_xiv.jobs"))));
                end
                ##
                # Produces the name of a playable race from Final Fantasy XIV.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::FinalFantasyXIV.race #=> "Miqo'te"
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.final_fantasy_xiv.races"))));
                end
                ##
                # Produces a geographical zone from Final Fantasy XIV.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::FinalFantasyXIV.zone #=> "Eastern La Noscea"
                #
                def zone()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.final_fantasy_xiv.zones"))));
                end
                end
            end
        class HalfLife < Base
            class << self
                ##
                # Produces the name of a character from the Half-Life games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HalfLife.character #=> "Gordon Freeman"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.half_life.character"))));
                end
                ##
                # Produces the name of an enemy from the Half-Life games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HalfLife.enemy #=> "Headcrab"
                #
                def enemy()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.half_life.enemy"))));
                end
                ##
                # Produces the name of a location from the Half-Life games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HalfLife.location #=> "Black Mesa Research Facility"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.half_life.location"))));
                end
                end
            end
        class Heroes < Base
            class << self
                ##
                # Produces the name of an artifact from Heroes 3.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Heroes.artifact #=> "Armageddon's Blade"
                #
                def artifact()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes.artifacts"))));
                end
                ##
                # Produces the name of a class from Heroes 3.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Heroes.klass #=> "Knight"
                #
                def klass()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes.klasses"))));
                end
                ##
                # Produces the name of a hero from Heroes 3.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Heroes.name #=> "Christian"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes.names"))));
                end
                ##
                # Produces the name of a specialty from Heroes 3.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Heroes.specialty #=> "Ballista"
                #
                def specialty()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes.specialties"))));
                end
                end
            end
        class HeroesOfTheStorm < Base
            class << self
                ##
                # Produces a battleground from Heroes of the Storm.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HeroesOfTheStorm.battleground #=> "Towers of Doom"
                #
                def battleground()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes_of_the_storm.battlegrounds"))));
                end
                ##
                # This method is deprecated.
                #                                 <p>The implementation will be removed in a near future release. Use ‘HeroesOfTheStorm.class_name` instead.</p>
                #                             
                #
                # @return [String]
                #
                def class()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a class name from Heroes of the Storm.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HeroesOfTheStorm.class_name #=> "Support"
                #
                def class_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes_of_the_storm.class_names"))));
                end
                ##
                # Produces a hero from Heroes of the Storm.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HeroesOfTheStorm.hero #=> "Illidan"
                #
                def hero()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes_of_the_storm.heroes"))));
                end
                ##
                # Produces a quote from Heroes of the Storm.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::HeroesOfTheStorm.quote #=> "MEAT!!!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("heroes_of_the_storm.quotes"))));
                end
                end
            end
        class LeagueOfLegends < Base
            class << self
                ##
                # Produces the name of a champion from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.champion #=> "Jarvan IV"
                #
                def champion()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.champion"))));
                end
                ##
                # Produces a location from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.location #=> "Demacia"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.location"))));
                end
                ##
                # Produces a mastery from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.masteries #=> "Double Edged Sword"
                #
                def masteries()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.masteries"))));
                end
                ##
                # Produces a quote from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.quote #=> "Purge the unjust."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.quote"))));
                end
                ##
                # Produces a rank from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.rank #=> "Bronze V"
                #
                def rank()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.rank"))));
                end
                ##
                # Produces a summoner spell from League of Legends.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::LeagueOfLegends.summoner_spell #=> "Flash"
                #
                def summoner_spell()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.league_of_legends.summoner_spell"))));
                end
                end
            end
        class Minecraft < Base
            class << self
                ##
                # Produces the name of an achievement from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.achievement #=> "Time to Mine!"
                #
                def achievement()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.achievement"))));
                end
                ##
                # Produces the name of a biome from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.biome #=> "Jungle"
                #
                def biome()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.biome"))));
                end
                ##
                # Produces the name of a block from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.block #=> "Stone"
                #
                def block()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.blocks"))));
                end
                ##
                # Produces the name of a enchantment from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.enchantment #=> "Fire Protection"
                #
                def enchantment()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.enchantment"))));
                end
                ##
                # Produces the name of a game mode from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.game_mode #=> "Survival"
                #
                def game_mode()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.game_mode"))));
                end
                ##
                # Produces the name of an item from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.item #=> "Iron Shovel"
                #
                def item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.items"))));
                end
                ##
                # Produces the name of a mob from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.mob #=> "Sheep"
                #
                def mob()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.mobs"))));
                end
                ##
                # Produces the name of a status effect from Minecraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Minecraft.status_effect #=> "Weakness"
                #
                def status_effect()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.minecraft.status_effect"))));
                end
                end
            end
        class Myst < Base
            class << self
                ##
                # Produces the name of an age from Myst.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Myst.age #=> "Relto"
                #
                def age()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.myst.ages"))));
                end
                ##
                # Produces the name of a character from Myst.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Myst.character #=> "Gehn"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.myst.characters"))));
                end
                ##
                # Produces the name of a creature from Myst.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Myst.creature #=> "squee"
                #
                def creature()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.myst.creatures"))));
                end
                ##
                # Produces the name of a game from the Myst series.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Myst.game #=> "Myst III: Exile"
                #
                def game()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.myst.games"))));
                end
                ##
                # Produces a quote from Myst.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Myst.quote #=> "I realized, the moment I fell into the fissure, that the Book would not be destroyed as I had planned."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.myst.quotes"))));
                end
                end
            end
        class Overwatch < Base
            class << self
                ##
                # Produces the name of a hero from Overwatch.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Overwatch.hero #=> "Tracer"
                #
                def hero()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.overwatch.heroes"))));
                end
                ##
                # Produces the name of a location from Overwatch.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Overwatch.location #=> "Numbani"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.overwatch.locations"))));
                end
                ##
                # Produces a quote from Overwatch.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Overwatch.quote #=> "It's high noon"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.overwatch.quotes"))));
                end
                end
            end
        class Pokemon < Base
            class << self
                ##
                # Produces a location from Pokemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Pokemon.location #=> "Pallet Town"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.pokemon.locations"))));
                end
                ##
                # Produces a move from Pokemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Pokemon.move #=> "Thunder Shock"
                #
                def move()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.pokemon.moves"))));
                end
                ##
                # Produces the name of a Pokemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Pokemon.name #=> "Pikachu"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.pokemon.names"))));
                end
                end
            end
        class SonicTheHedgehog < Base
            class << self
                ##
                # Produces the name of a character from Sonic the Hedgehog.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SonicTheHedgehog.character #=> "Sonic the Hedgehog"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.sonic_the_hedgehog.character"))));
                end
                ##
                # Produces the name of a game from the Sonic the Hedgehog series.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SonicTheHedgehog.game #=> "Waku Waku Sonic Patrol Car"
                #
                def game()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.sonic_the_hedgehog.game"))));
                end
                ##
                # Produces the name of a zone from Sonic the Hedgehog.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SonicTheHedgehog.zone #=> "Green Hill Zone"
                #
                def zone()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.sonic_the_hedgehog.zone"))));
                end
                end
            end
        class StreetFighter < Base
            class << self
                ##
                # Produces the name of a playable character from Street Fighter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::StreetFighter.character #=> "Ryu"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.street_fighter.characters"))));
                end
                ##
                # Produces the name of a move from Street Fighter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::StreetFighter.move #=> "Shoryuken"
                #
                def move()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.street_fighter.moves"))));
                end
                ##
                # Produces a quote from Street Fighter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::StreetFighter.quote #=> "Go home and be a family man."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.street_fighter.quotes"))));
                end
                ##
                # Produces the name of a stage from Street Fighter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::StreetFighter.stage #=> "Volcanic Rim"
                #
                def stage()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.street_fighter.stages"))));
                end
                end
            end
        class SuperMario < Base
            class << self
                ##
                # Produces the name of a Super Mario character.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SuperMario.character #=> "Luigi"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.super_mario.characters"))));
                end
                ##
                # Produces the name of a Super Mario game.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SuperMario.game #=> "Super Mario Odyssey"
                #
                def game()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.super_mario.games"))));
                end
                ##
                # Produces the name of a Super Mario location.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SuperMario.location #=> "Kong City"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.super_mario.locations"))));
                end
                end
            end
        class SuperSmashBros < Base
            class << self
                ##
                # Produces the name of a fighter from the Smash Bros games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SuperSmashBros.fighter #=> "Mario"
                #
                def fighter()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.super_smash_bros.fighter"))));
                end
                ##
                # Produces the name of a stage from the Smash Bros games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::SuperSmashBros.stage #=> "Final Destination"
                #
                def stage()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.super_smash_bros.stage"))));
                end
                end
            end
        class Tarkov < Base
            class << self
                ##
                # Produces a random boss from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.boss #=> "Tagilla"
                #
                def boss()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.bosses"))));
                end
                ##
                # Produces a random faction from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.faction #=> "USEC"
                #
                def faction()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.factions"))));
                end
                ##
                # Produces a random quest from Fence from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.fence_quest #=> "Compensation for Damage - Wager"
                #
                def fence_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.fence"))));
                end
                ##
                # Produces a random item from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.item #=> "Diary"
                #
                def item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.items"))));
                end
                ##
                # Produces a random quest from Jaeger from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.jaeger_quest #=> "The Tarkov Shooter - Part 1"
                #
                def jaeger_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.jaeger"))));
                end
                ##
                # Produces a random location from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.location #=> "Customs"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.locations"))));
                end
                ##
                # Produces a random quest from Mechanic from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.mechanic_quest #=> "Signal - Part 4"
                #
                def mechanic_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.mechanic"))));
                end
                ##
                # Produces a random quest from Peacekeeper from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.peacekeeper_quest #=> "Overpopulation"
                #
                def peacekeeper_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.peacekeeper"))));
                end
                ##
                # Produces a random quest from Prapor from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.prapor_quest #=> "Easy Job - Part 2
                #
                def prapor_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.prapor"))));
                end
                ##
                # Produces a random quest from a random trader from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.quest #=> "The Key to Success"
                #
                def quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.#{@traders.sample}"))));
                end
                ##
                # Produces a random quest from Ragman from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.ragman_quest #=> "Hot Delivery"
                #
                def ragman_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.ragman"))));
                end
                ##
                # Produces a random quest from Skier from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.skier_quest #=> "Safe Corridor"
                #
                def skier_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.skier"))));
                end
                ##
                # Produces a random quest from Therapist from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.therapist_quest #=> "Supply Plans"
                #
                def therapist_quest()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.quests.therapist"))));
                end
                ##
                # Produces a random trader from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.trader #=> "Prapor"
                #
                def trader()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.traders"))));
                end
                ##
                # Produces a random weapon from Escape from Tarkov.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Tarkov.weapon #=> "AK-74N"
                #
                def weapon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tarkov.weapons"))));
                end
                end
            end
        class Touhou < Base
            class << self
                ##
                # Produces the name of a character from the Touhou games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Touhou.character #=> "Sanae Kochiya"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.touhou.characters"))));
                end
                ##
                # Produces the name of a Touhou game.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Touhou.game #=> "Mountain of Faith"
                #
                def game()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.touhou.games"))));
                end
                ##
                # Produces the name of a location from the Touhou games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Touhou.location #=> "Moriya Shrine"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.touhou.locations"))));
                end
                ##
                # Produces the name of a song from the Touhou games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Touhou.song #=> "Faith Is for the Transient People"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.touhou.songs"))));
                end
                ##
                # Produces the name of a spell card from the Touhou games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Touhou.spell_card #=> 'Esoterica "Gray Thaumaturgy"'
                #
                def spell_card()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.touhou.spell_cards"))));
                end
                end
            end
        class WarhammerFantasy < Base
            class << self
                ##
                # Produces a creature from the Warhammer Fantasy setting.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WarhammerFantasy.creature #=> "Hydra"
                #
                def creature()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.warhammer_fantasy.creatures"))));
                end
                ##
                # Produces a faction from the Warhammer Fantasy setting.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WarhammerFantasy.faction #=> "Bretonnia"
                #
                def faction()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.warhammer_fantasy.factions"))));
                end
                ##
                # Produces the name of a hero from the Warhammer Fantasy setting.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WarhammerFantasy.hero #=> "Sigmar Heldenhammer"
                #
                def hero()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.warhammer_fantasy.heros"))));
                end
                ##
                # Produces a location from the Warhammer Fantasy setting.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WarhammerFantasy.location #=> "Lustria"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.warhammer_fantasy.locations"))));
                end
                ##
                # Produces a quote from the Warhammer Fantasy setting.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WarhammerFantasy.quote #=> "The softest part of a castle is the belly of the man inside."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.warhammer_fantasy.quotes"))));
                end
                end
            end
        class Witcher < Base
            class << self
                ##
                # Produces the name of a book from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.book #=> "Sword of Destiny"
                #
                def book()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.books"))));
                end
                ##
                # Produces the name of a character from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.character #=> "Triss Merigold"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.characters"))));
                end
                ##
                # Produces the name of a location from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.location #=> "Novigrad"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.locations"))));
                end
                ##
                # Produces the name of a monster from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.monster #=> "Katakan"
                #
                def monster()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.monsters"))));
                end
                ##
                # Produces the name of a potion from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.potion #=> "Gadwall"
                #
                def potion()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.potions"))));
                end
                ##
                # Produces a quote from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.quote #=> "No Lollygagin'!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.quotes"))));
                end
                ##
                # Produces the name of a school from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.school #=> "Wolf"
                #
                def school()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.schools"))));
                end
                ##
                # Produces the name of a sign from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.sign #=> "Igni"
                #
                def sign()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.signs"))));
                end
                ##
                # Produces the name of a witcher from The Witcher.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Witcher.witcher #=> "Geralt of Rivia"
                #
                def witcher()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.witcher.witchers"))));
                end
                end
            end
        class WorldOfWarcraft < Base
            class << self
                ##
                # Produces a class name from World of Warcraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WorldOfWarcraft.class_name #=> "Druid"
                #
                def class_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.world_of_warcraft.class_names"))));
                end
                ##
                # Produces the name of a hero from World of Warcraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WorldOfWarcraft.hero #=> "Uther the Lightbringer"
                #
                def hero()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.world_of_warcraft.heros"))));
                end
                ##
                # Produces a quote from World of Warcraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WorldOfWarcraft.quote #=> "These are dark times indeed."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.world_of_warcraft.quotes"))));
                end
                ##
                # Produces the name of a race from World of Warcraft.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::WorldOfWarcraft.race #=> "Druid"
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.world_of_warcraft.races"))));
                end
                end
            end
        class Zelda < Base
            class << self
                ##
                # Produces the name of a character from the Legend of Zelda games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Zelda.character #=> "Link"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.zelda.characters"))));
                end
                ##
                # Produces the name of a Legend of Zelda game.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Zelda.game #=> "Breath of the Wild"
                #
                def game()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.zelda.games"))));
                end
                ##
                # Produces the name of an item from the Legend of Zelda games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Zelda.item #=> "Boomerang"
                #
                def item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.zelda.items"))));
                end
                ##
                # Produces the name of a character from the Legend of Zelda games.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::Zelda.location #=> "Hyrule Castle"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("games.zelda.locations"))));
                end
                end
            end
        end
    class Gender < Base
        class << self
            ##
            # Produces either 'Male' or 'Female'.
            #
            # @return [String]
            #
            # @example
            #     Faker::Gender.binary_type #=> "Female"
            #
            def binary_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("gender.binary_types"))));
            end
            ##
            # Produces either 'f' or 'm'.
            #
            # @return [String]
            #
            # @example
            #     Faker::Gender.short_binary_type #=> "f"
            #
            def short_binary_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("gender.short_binary_types"))));
            end
            ##
            # Produces the name of a gender identity.
            #
            # @return [String]
            #
            # @example
            #     Faker::Gender.type #=> "Non-binary"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("gender.types"))));
            end
            end
        end
    class GreekPhilosophers < Base
        class << self
            ##
            # Produces the name of a Greek philosopher.
            #
            # @return [String]
            #
            # @example
            #     Faker::GreekPhilosophers.name #=> "Socrates"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("greek_philosophers.names"))));
            end
            ##
            # Produces a quote from a Greek philosopher.
            #
            # @return [String]
            #
            # @example
            #     Faker::GreekPhilosophers.quote #=> "Only the educated are free."
            #
            def quote()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("greek_philosophers.quotes"))));
            end
            end
        end
    class HTML < Base
        class << self
            warn  "Failed processing method available_methods"
            ##
            # Produces a random code block formatted in HTML.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.code #=> "<code>Eos quasi qui.</code>"
            #
            def code()
                return "<code>#{Lorem.sentence(word_count: 1)}</code>";
            end
            ##
            # Generates HTML content with customizable attributes for any HTML tag.
            #
            # @param tag [String]   
            #   <p>The HTML tag to generate.</p>
            #   
            #
            # @param content [String]   
            #   <p>The Content of the HTML tag.</p>
            #   
            #
            # @param attributes [Hash]   
            #   <p>The attributes to include in the tag.</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.element(tag: 'div', content: "This is a div with XSS attributes.", attributes: {class: 'xss', onclick: "alert('XSS')"}) #=> "<div class=\"xss\" onclick=\"alert('XSS')\">This is a div with XSS attributes.</div>"
            #
            def element(tag, content, attributes)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random emphasis formatting on a random word in two HTML paragraphs.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.emphasis #=> "<em>repellat id impedit</em>"
            #
            def emphasis()
                return _faker.Translate(_faker.Numerify(_faker.Letterify("<em>#{Faker::Lorem.paragraph(sentence_count: 1)}</em>")));
            end
            warn  "Failed processing method generate_table_row"
            ##
            # Produces a random HTML header format.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.heading #=> "<h5>Autem</h5>"
            #
            def heading()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates a random <link> tag with the `rel` attribute set to "stylesheet" and the `href` attribute set to a random URL.
            #
            # @param rel [String]   
            #   <p>The rel of the link tag.</p>
            #    (default value "'stylesheet'")
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.link #=> "<link rel=\"stylesheet\" href=\"http://fay.io/darryl.barrows.css\">"
            #
            def link(rel: 'stylesheet')
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random ordered list in HTML format, with at least one element.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.ordered_list #=> "<ol>\n<li>Qui reiciendis non consequatur atque.</li>\n<li>Quo doloremque veritatis tempora aut.</li>\n<li>Aspernatur.</li>\n<li>Ea ab.</li>\n<li>Qui.</li>\n<li>Sit pariatur nemo eveniet.</li>\n<li>Molestiae aut.</li>\n<li>Nihil molestias iure placeat.</li>\n<li>Dolore autem quisquam.</li>\n</ol>"
            #
            def ordered_list()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random HTML paragraph format.
            #
            # @param sentence_count [Integer]   
            #   <p>The number of sentences in the paragraph.</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Include supplemental text.</p>
            #   
            #
            # @param random_sentences_to_add [Integer]   
            #   <p>The number of random sentences to add to the paragraph.</p>
            #   
            #
            # @param exclude_words [Array<String>]   
            #   <p>Words to exclude from the generated paragraph.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.paragraph #=> "<p>Incidunt atque quis</p>"
            #
            def paragraph(sentence_count, supplemental, random_sentences_to_add, exclude_words: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method random"
            ##
            # Generates a random HTML content sandwich, starting with a header, followed by paragraphs, and random elements.
            #
            # @param sentences [Integer]   
            #   <p>The number of sentences in each paragraph.</p>
            #   
            #
            # @param repeat [Integer]   
            #   <p>The number of times to repeat the pattern (header, paragraph, random).</p>
            #    (default value "1")
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.sandwich(sentences: 3, repeat: 2) #=> returns a sandwich of HTML content with 2 repetitions, each having a header, paragraph, and random element
            #
            def sandwich(sentences, repeat: 1)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates a random <script> tag with the `src` attribute set to a random URL.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.script #=> "<script src=\"http://gulgowski.name/jordan.weimann.js\"></script>"
            #
            def script()
                return _faker.Translate(_faker.Numerify(_faker.Letterify("<script src=\"#{Faker::Internet.url}.js\"></script>")));
            end
            ##
            # Produces a random HTML table.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.table #=> "<table>\n<thead>\n<th>ad</th>\n<th>similique</th>\n<th>voluptatem</th>\n</thead>\n<tbody>\n<td>corrupti</td>\n<td>est</td>\n<td>rerum</td>\n<td>molestiae</td>\n<td>quidem</td>\n<td>et</td>\n<td>in</td>\n<td>tempora</td>\n<td>at</td>\n<\tbody>\n<tfoot>\n<td>voluptatem</td>\n<td>debitis</td>\n<td>rem</td>\n</tfoot>\n</table>"
            #
            def table()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random unordered list of items between 1 and 10 randomly in HTML format.
            #
            # @return [String]
            #
            # @example
            #     Faker::HTML.unordered_list #=> "<ul>\n<li>Voluptatum aliquid tempora molestiae facilis non sed.</li>\n<li>Nostrum omnis iste impedit voluptatum dolor.</li>\n<li>Esse quidem et facere.</li>\n</ul>"
            #
            def unordered_list()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    ##
    # Port of http://shinytoylabs.com/jargon/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.
    # <p>Port of <a href="http://shinytoylabs.com/jargon">shinytoylabs.com/jargon</a>/ Are you having trouble writing tech-savvy dialogue for your latest screenplay? Worry not! Hollywood-grade technical talk is ready to fill out any form where you need to look smart.</p>
    # 
    #
    class Hacker < Base
        class << self
            ##
            # Short technical abbreviations.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hacker.abbreviation #=> "RAM"
            #
            def abbreviation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hacker.abbreviation"))));
            end
            ##
            # Hacker-centric adjectives.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hacker.adjective #=> "open-source"
            #
            def adjective()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hacker.adjective"))));
            end
            ##
            # Produces a verb that ends with '-ing'.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hacker.ingverb #=> "synthesizing"
            #
            def ingverb()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hacker.ingverb"))));
            end
            ##
            # Only the best hacker-related nouns.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hacker.noun #=> "bandwidth"
            #
            def noun()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hacker.noun"))));
            end
            warn  "Failed processing method phrases"
            ##
            # Produces something smart.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Hacker.say_something_smart
            #                                         #=> "Try to compress the SQL interface, maybe it will program the back-end hard drive!"
            #                                     
            #
            def say_something_smart()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Actions that hackers take.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hacker.verb #=> "bypass"
            #
            def verb()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hacker.verb"))));
            end
            end
        end
    class Hipster < Base
        class << self
            ##
            # Produces a random hipster paragraph.
            #
            # @param sentence_count [Integer]   
            #   <p>Specifies the number of sentences in the paragraph</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #   
            #
            # @param random_sentences_to_add [Boolean]   
            #   <p>Specifies the number of random sentences to add</p>
            #    (default value "3")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Hipster.paragraph #=> "Migas fingerstache pbr&b tofu. Polaroid distillery typewriter echo tofu actually. Slow-carb fanny pack pickled direct trade scenester mlkshk plaid. Banjo venmo chambray cold-pressed typewriter. Fap skateboard intelligentsia."
            #                                         Faker::Hipster.paragraph(sentence_count: 2) #=> "Yolo tilde farm-to-table hashtag. Lomo kitsch disrupt forage +1."
            #                                         Faker::Hipster.paragraph(sentence_count: 2, supplemental: true) #=> "Typewriter iste ut viral kombucha voluptatem. Sint voluptates saepe. Direct trade irony chia excepturi yuccie. Biodiesel esse listicle et quam suscipit."
            #                                         Faker::Hipster.paragraph(sentence_count: 2, supplemental: false, random_sentences_to_add: 4) #=> "Selvage vhs chartreuse narwhal vinegar. Authentic vinyl truffaut carry vhs pop-up. Hammock everyday iphone locavore thundercats bitters vegan goth. Fashion axe banh mi shoreditch whatever artisan."
            #                                         Faker::Hipster.paragraph(sentence_count: 2, supplemental: true, random_sentences_to_add: 4) #=> "Deep v gluten-free unde waistcoat aperiam migas voluptas dolorum. Aut drinking illo sustainable sapiente. Direct trade fanny pack kale chips ennui semiotics."
            #                                     
            #
            def paragraph(sentence_count, supplemental, random_sentences_to_add: 3)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random hipster paragraph by characters.
            #
            # @param characters [Integer]   
            #   <p>Specifies the number of characters in the paragraph</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Hipster.paragraph_by_chars #=> "Truffaut stumptown trust fund 8-bit messenger bag portland. Meh kombucha selvage swag biodiesel. Lomo kinfolk jean shorts asymmetrical diy. Wayfarers portland twee stumptown. Wes anderson biodiesel retro 90's pabst. Diy echo 90's mixtape semiotics. Cornho."
            #                                         Faker::Hipster.paragraph_by_chars(characters: 256, supplemental: false) #=> "Hella kogi blog narwhal sartorial selfies mustache schlitz. Bespoke normcore kitsch cred hella fixie. Park aesthetic fixie migas twee. Cliche mustache brunch tumblr fixie godard. Drinking pop-up synth hoodie dreamcatcher typewriter. Kitsch biodiesel green."
            #                                     
            #
            def paragraph_by_chars(characters, supplemental: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces random hipster paragraphs.
            #
            # @param number [Integer]   
            #   <p>Specifies the number of paragraphs</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #    (default value "false")
            #
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Hipster.paragraphs #=> ["Tilde microdosing blog cliche meggings. Intelligentsia five dollar toast forage yuccie. Master kitsch knausgaard. Try-hard everyday trust fund mumblecore.", "Normcore viral pickled. Listicle humblebrag swag tote bag. Taxidermy street hammock neutra butcher cred kale chips. Blog portland humblebrag trust fund irony.", "Single-origin coffee fixie cleanse tofu xoxo. Post-ironic tote bag ramps gluten-free locavore mumblecore hammock. Umami loko twee. Ugh kitsch before they sold out."]
            #                                         Faker::Hipster.paragraphs(number: 1) #=> ["Skateboard cronut synth +1 fashion axe. Pop-up polaroid skateboard asymmetrical. Ennui fingerstache shoreditch before they sold out. Tattooed pitchfork ramps. Photo booth yr messenger bag raw denim bespoke locavore lomo synth."]
            #                                         Faker::Hipster.paragraphs(number: 1, supplemental: true) #=> ["Quae direct trade pbr&b quo taxidermy autem loko. Umami quas ratione migas cardigan sriracha minima. Tenetur perspiciatis pickled sed eum doloribus truffaut. Excepturi dreamcatcher meditation."]
            #                                     
            #
            def paragraphs(number, supplemental: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random hipster sentence.
            #
            # @param word_count [Integer]   
            #   <p>Specifies the number of words in the sentence</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #   
            #
            # @param random_words_to_add [Integer]   
            #   <p>Specifies the number of random words to add</p>
            #   
            #
            # @param open_compounds_allowed [Boolean]   
            #   <p>Specifies if the generated sentence can contain words having additional spaces</p>
            #    (default value "true")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Hipster.sentence #=> "Park iphone leggings put a bird on it."
            #                                         Faker::Hipster.sentence(word_count: 3) #=> "Pour-over swag godard."
            #                                         Faker::Hipster.sentence(word_count: 3, supplemental: true) #=> "Beard laboriosam sequi celiac."
            #                                         Faker::Hipster.sentence(word_count: 3, supplemental: false, random_words_to_add: 4) #=> "Bitters retro mustache aesthetic biodiesel 8-bit."
            #                                         Faker::Hipster.sentence(word_count: 3, supplemental: true, random_words_to_add: 4) #=> "Occaecati deleniti messenger bag meh crucifix autem."
            #                                         Faker::Hipster.sentence(word_count: 3, supplemental: true, random_words_to_add: 0, open_compounds_allowed: true) #=> "Kale chips nihil eos."
            #                                         Faker::Hipster.sentence(word_count: 3, supplemental: true, random_words_to_add: 0, open_compounds_allowed: false) #=> "Dreamcatcher umami fixie."
            #                                     
            #
            def sentence(word_count, supplemental, random_words_to_add, open_compounds_allowed: true)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces random hipster sentences.
            #
            # @param number [Integer]   
            #   <p>Specifies the number of sentences returned</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #    (default value "false")
            #
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Hipster.sentences #=> ["Godard pitchfork vinegar chillwave everyday 90's whatever.", "Pour-over artisan distillery street waistcoat.", "Salvia yr leggings franzen blue bottle."]
            #                                         Faker::Hipster.sentences(number: 1) #=> ["Before they sold out pinterest venmo umami try-hard ugh hoodie artisan."]
            #                                         Faker::Hipster.sentences(number: 1, supplemental: true) #=> ["Et sustainable optio aesthetic et."]
            #                                     
            #
            def sentences(number, supplemental: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random hipster word.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hipster.word #=> "irony"
            #
            def word()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random hipster word.
            #
            # @param number [Integer]   
            #   <p>Specifies the number of words returned</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Specifies if the words are supplemental</p>
            #   
            #
            # @param spaces_allowed [Boolean]   
            #   <p>Specifies if the words may contain spaces</p>
            #    (default value "false")
            #
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Hipster.words #=> ["pug", "pitchfork", "chia"]
            #                                         Faker::Hipster.words(number: 4) #=> ["ugh", "cardigan", "poutine", "stumptown"]
            #                                         Faker::Hipster.words(number: 4, supplemental: true) #=> ["iste", "seitan", "normcore", "provident"]
            #                                         Faker::Hipster.words(number: 4, supplemental: true, spaces_allowed: true) #=> ["qui", "magni", "craft beer", "est"]
            #                                     
            #
            def words(number, supplemental, spaces_allowed: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Hobby < Base
        class << self
            ##
            # Retrieves a typical hobby activity.
            #
            # @return [String]
            #
            # @example
            #     Faker::Hobby.activity #=> "Cooking"
            #
            def activity()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hobby.activity"))));
            end
            end
        end
    class House < Base
        class << self
            ##
            # Produces the name of a piece of furniture.
            #
            # @return [String]
            #
            # @example
            #     Faker::House.furniture #=> "chair"
            #
            def furniture()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("house.furniture"))));
            end
            ##
            # Produces the name of a room in a house.
            #
            # @return [String]
            #
            # @example
            #     Faker::House.room #=> "kitchen"
            #
            def room()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("house.rooms"))));
            end
            end
        end
    class IDNumber < Base
        class << self
            warn  "Failed processing method _translate"
            ##
            # Produces a random Brazilian Citizen Number (CPF).
            #
            # @param formatted [Boolean]   
            #   <p>Specifies if the number is formatted with dividers.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::IDNumber.brazilian_citizen_number #=> "53540542221"
            #                                         Faker::IDNumber.brazilian_citizen_number(formatted: true) #=> "535.405.422-21"
            #                                     
            #
            def brazilian_citizen_number(formatted: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method brazilian_citizen_number_checksum_digit"
            warn  "Failed processing method brazilian_citizen_number_digit"
            warn  "Failed processing method brazilian_document_checksum"
            warn  "Failed processing method brazilian_document_digit"
            ##
            # Produces a random Brazilian ID Number (RG).
            #
            # @param formatted [Boolean]   
            #   <p>Specifies if the number is formatted with dividers.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::IDNumber.brazilian_id #=> "493054029"
            #                                         Faker::IDNumber.brazilian_id(formatted: true) #=> "49.305.402-9"
            #                                     
            #
            def brazilian_id(formatted: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method brazilian_id_checksum_digit"
            warn  "Failed processing method brazilian_id_digit"
            ##
            # Produces a random Chilean ID (Rut with 8 digits).
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.chilean_id #=> "15620613-K"
            #
            def chilean_id()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method chilean_verification_code"
            ##
            # Produces a random Croatian ID number (OIB).
            #
            # @param international [Boolean]   
            #   <p>Specifies whether to add international prefix.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::IDNumber.croatian_id #=> "88467617508"
            #                                         Faker::IDNumber.croatian_id(international: true) #=> "HR88467617508"
            #                                     
            #
            def croatian_id(international: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method croatian_id_checksum_digit"
            warn  "Failed processing method danish_control_digits"
            ##
            # Produces a random Danish ID Number (CPR number).
            #                             <p>CPR number is 10 digits. Digit 1-6 is the birthdate (format “DDMMYY”). Digit 7-10 is a sequence number. Digit 7 digit is a control digit that determines the century of birth. Digit 10 reveals the gender: # even is female, odd is male.</p>
            #                         
            #
            # @param formatted [Boolean]   
            #   <p>Specifies if the number is formatted with dividers.</p>
            #   
            #
            # @param birthday [Date]   
            #   <p>Specifies the birthday for the id number.</p>
            #   
            #
            # @param gender [Symbol]   
            #   <p>Specifies the gender for the id number. Must be one :male or :female if present.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::IDNumber.danish_id_number #=> "0503909980"
            #                                         Faker::IDNumber.danish_id_number(formatted: true) #=> "050390-9980"
            #                                         Faker::IDNumber.danish_id_number(birthday: Date.new(1990, 3, 5)) #=> "0503909980"
            #                                         Faker::IDNumber.danish_id_number(gender: :female) #=> "0503909980"
            #                                     
            #
            def danish_id_number(formatted, birthday, gender: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random French social security number (INSEE number).
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.french_insee_number #=> "53290236-H"
            #
            def french_insee_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random invalid US Social Security number.
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.invalid #=> "311-72-0000"
            #
            def invalid()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random invalid South African ID Number.
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.invalid_south_african_id_number #=> "1642972065088"
            #
            def invalid_south_african_id_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method south_african_id_checksum_digit"
            ##
            # Produces a random Spanish citizen identifier (DNI).
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.spanish_citizen_number #=> "53290236-H"
            #
            def spanish_citizen_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random Spanish foreign born citizen identifier (NIE).
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.spanish_foreign_citizen_number #=> "Z-1600870-Y"
            #
            def spanish_foreign_citizen_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method ssn_valid"
            ##
            # Produces a random valid US Social Security number.
            #
            # @return [String]
            #
            # @example
            #     Faker::IDNumber.valid #=> "552-56-3593"
            #
            def valid()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random valid South African ID Number.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::IDNumber.south_african_id_number #=> "8105128870184"
            #                                         Faker::IDNumber.valid_south_african_id_number #=> "8105128870184"
            #                                     
            #
            def valid_south_african_id_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class IndustrySegments < Base
        class << self
            ##
            # Produces the name of an industry.
            #
            # @return [String]
            #
            # @example
            #     Faker::IndustrySegments.industry #=> "Basic Materials"
            #
            def industry()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("industry_segments.industry"))));
            end
            ##
            # Produces the name of a sector of an industry.
            #
            # @return [String]
            #
            # @example
            #     Faker::IndustrySegments.sector #=> "Industrial Metals & Mining"
            #
            def sector()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("industry_segments.sector"))));
            end
            ##
            # Produces the name of a subsector of an industry.
            #
            # @return [String]
            #
            # @example
            #     Faker::IndustrySegments.industry #=> "Basic Materials"
            #
            def sub_sector()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("industry_segments.sub_sector"))));
            end
            ##
            # Produces the name of a super-sector of an industry.
            #
            # @return [String]
            #
            # @example
            #     Faker::IndustrySegments.super_sector #=> "Basic Resources"
            #
            def super_sector()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("industry_segments.super_sector"))));
            end
            end
        end
    class Internet
        class HTTP < Base
            class << self
                ##
                # Produces an HTTP status code.
                #                                 <p>Produces an HTTP status code</p>
                #                             
                #
                # @return [Integer]
                #
                # @example
                #     Faker::Internet::HTTP.status_code #=> 418
                #
                def status_code()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        ##
        # Produces a random string of alphabetic characters, (no digits).
        #                             <p>Produces a random string of alphabetic characters, (no digits)</p>
        #                         
        #
        # @param length [Integer]   
        #   <p>The length of the string to generate</p>
        #   
        #
        # @param padding [Boolean]   
        #   <p>Toggles if a final equal ‘=’ will be added.</p>
        #   
        #
        # @param urlsafe [Boolean]   
        #   <p>Toggles charset to ‘-’ and ‘_’ instead of ‘+’ and ‘/’.</p>
        #    (default value "true")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.base64
        #                                         #=> "r_hbZ2DSD-ZACzZT"
        #                                     
        #
        def base64(length, padding, urlsafe: true)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Generate Web Crawler's user agents.
        #                             <p>Generate Web Crawler’s user agents</p>
        #                         
        #
        # @param vendor [String]   
        #   <p>Name of vendor, supported vendors are googlebot, bingbot, duckduckbot, baiduspider, yandexbot</p>
        #    (default value "nil")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.bot_user_agent                        #=> "Mozilla/5.0 (compatible; YandexBot/3.0; +http://yandex.com/bots)"
        #                                         Faker::Internet.bot_user_agent(vendor: 'googlebot')   #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; Googlebot/2.1; +http://www.google.com/bot.html) Chrome/99.0.4844.84 Safari/537.36"
        #                                         Faker::Internet.bot_user_agent(vendor: 'bingbot')     #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm) Chrome/86.0.4240.68 Safari/537.36 Edg/86.0.622.31"
        #                                     
        #
        def bot_user_agent(vendor: nil)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        warn  "Failed processing method construct_email"
        warn  "Failed processing method device_token"
        ##
        # Returns the domain name.
        #                             <p>Returns the domain name</p>
        #                         
        #
        # @param subdomain [Bool]   
        #   <p>If true passed adds a subdomain in response</p>
        #   
        #
        # @param domain [String]    (default value "nil")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.domain_name                                                   #=> "altenwerth-gerhold.example"
        #                                         Faker::Internet.domain_name(subdomain: true)                                  #=> "metz.mclaughlin-brekke.test"
        #                                         Faker::Internet.domain_name(subdomain: true, domain: 'faker')                 #=> "foo.faker.test"
        #                                         Faker::Internet.domain_name(domain: 'faker-ruby.org')                         #=> "faker-ruby.org"
        #                                         Faker::Internet.domain_name(subdomain: true, domain: 'faker-ruby.org')        #=> "foo.faker-ruby.org"
        #                                         Faker::Internet.domain_name(subdomain: true, domain: 'faker.faker-ruby.org')  #=> "faker.faker-ruby.org"
        #                                     
        #
        def domain_name(subdomain, domain: nil)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the domain suffix e.g.
        #                             <p>com, org, co, biz, info etc.</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.domain_suffix              #=> "com"
        #                                         Faker::Internet.domain_suffix              #=> "biz"
        #                                         Faker::Internet.domain_suffix(safe: true)  #=> "example"
        #                                         Faker::Internet.domain_suffix(safe: true)  #=> "test"
        #                                     
        #
        def domain_suffix()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("internet.safe_domain_suffix"))));
        end
        ##
        # Returns the domain word for internet.
        #                             <p>Returns the domain word for internet</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.domain_word   #=> "senger"
        #
        def domain_word()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the email address.
        #                             <p>Returns the email address</p>
        #                         
        #
        # @param name [String]#
        # @param separators [Array<String>]#
        # @param domain [String]    (default value "nil")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.email                                                           #=> "renee@zieme.test"
        #                                         Faker::Internet.email(name: 'smith')                                            #=> "smith@bergnaum.test"
        #                                         Faker::Internet.email(name: 'sam smith', separators: ['-'])                     #=> "smith-sam@tromp.example"
        #                                         Faker::Internet.email(name: 'sam smith', separators: ['-'], domain: 'test')     #=> "sam-smith@test.example"
        #                                         Faker::Internet.email(domain: 'gmail.com')                                      #=> "foo@gmail.com"
        #                                     
        #
        def email(name, separators, domain: nil)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Fixes ä, ö, ü, ß characters in string passed with ae, oe, ue, ss resp.
        #
        # @param string [String]    (default value "''")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.fix_umlauts                     #=> ""
        #                                         Faker::Internet.fix_umlauts(string: 'faker')    #=> "faker"
        #                                         Faker::Internet.fix_umlauts(string: 'faküer')   #=> "fakueer"
        #                                     
        #
        def fix_umlauts(string: '')
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the IPv4 address.
        #                             <p>Returns the IPv4 address</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.ip_v4_address   #=> "97.117.128.93"
        #
        def ip_v4_address()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns Ipv4 address with CIDR, range from 1 to 31.
        #                             <p>Returns Ipv4 address with CIDR, range from 1 to 31</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/16"
        #                                         Faker::Internet.ip_v4_cidr  #=> "129.162.99.74/24"
        #                                     
        #
        def ip_v4_cidr()
            return "#{ip_v4_address}/#{rand(1..31)}";
        end
        ##
        # Returns Ipv6 address.
        #                             <p>Returns Ipv6 address</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.ip_v6_address   #=> "7754:76d4:c7aa:7646:ea68:1abb:4055:4343"
        #
        def ip_v6_address()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns Ipv6 address with CIDR, range between 1 to 127.
        #                             <p>Returns Ipv6 address with CIDR, range between 1 to 127</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.ip_v6_cidr  #=> "beca:9b99:4bb6:9712:af2f:516f:8507:96e1/99"
        #
        def ip_v6_cidr()
            return "#{ip_v6_address}/#{rand(1..127)}";
        end
        ##
        # Returns the MAC address.
        #                             <p>Returns the MAC address</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.mac_address                   #=> "74:d0:c9:22:95:12"
        #                                         Faker::Internet.mac_address(prefix: 'a')      #=> "0a:91:ce:24:89:3b"
        #                                         Faker::Internet.mac_address(prefix: 'aa')     #=> "aa:38:a0:3e:e8:41"
        #                                         Faker::Internet.mac_address(prefix: 'aa:44')  #=> "aa:44:30:88:6e:95"
        #                                     
        #
        def mac_address()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces a randomized string of characters suitable for passwords.
        #                             <p>Produces a randomized string of characters suitable for passwords</p>
        #                         
        #
        # @param min_length [Integer]   
        #   <p>The minimum length of the password</p>
        #   
        #
        # @param max_length [Integer]   
        #   <p>The maximum length of the password</p>
        #   
        #
        # @param mix_case [Boolean]   
        #   <p>Toggles if uppercased letters are allowed. If true, at least one will be added.</p>
        #   
        #
        # @param special_characters [Boolean]   
        #   <p>Toggles if special characters are allowed. If true, at least one will be added.</p>
        #    (default value "false")
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.password #=> "Vg5mSvY1UeRg7"
        #
        def password(min_length, max_length, mix_case, special_characters: false)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the private IPv4 address.
        #                             <p>Returns the private IPv4 address</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.private_ip_v4_address   #=> "127.120.80.42"
        #
        def private_ip_v4_address()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns lambda to check if address passed is private or not.
        #                             <p>Returns lambda to check if address passed is private or not</p>
        #                         
        #
        # @return [Lambda]
        #
        # @example
        #     
        #                                         Faker::Internet.private_net_checker.call("127.120.80.42")   #=> true
        #                                         Faker::Internet.private_net_checker.call("148.120.80.42")   #=> false
        #                                     
        #
        def private_net_checker()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the private network regular expressions.
        #                             <p>Returns the private network regular expressions</p>
        #                         
        #
        # @return [Array<String>]
        #
        # @example
        #     Faker::Internet.private_nets_regex  #=> [/^10\./, /^100\.(6[4-9]|[7-9]\d|1[0-1]\d|12[0-7])\./, /^127\./, /^169\.254\./, /^172\.(1[6-9]|2\d|3[0-1])\./, /^192\.0\.0\./, /^192\.168\./, /^198\.(1[8-9])\./]
        #
        def private_nets_regex()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the public IPv4 address.
        #                             <p>Returns the public IPv4 address</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.public_ip_v4_address   #=> "127.120.80.42"
        #
        def public_ip_v4_address()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns lambda function to check address passed is reserved or not.
        #                             <p>Returns lambda function to check address passed is reserved or not</p>
        #                         
        #
        # @return [Lambda]
        #
        # @example
        #     
        #                                         Faker::Internet.reserved_net_checker.call('192.88.99.255')   #=> true
        #                                         Faker::Internet.reserved_net_checker.call('192.88.199.255')  #=> false
        #                                     
        #
        def reserved_net_checker()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the reserved network regular expressions.
        #                             <p>Returns the reserved network regular expressions</p>
        #                         
        #
        # @return [Array<String>]
        #
        # @example
        #     Faker::Internet.reserved_nets_regex   #=> [/^0\./, /^192\.0\.2\./, /^192\.88\.99\./, /^198\.51\.100\./, /^203\.0\.113\./, /^(22[4-9]|23\d)\./, /^(24\d|25[0-5])\./]
        #
        def reserved_nets_regex()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        warn  "Failed processing method sanitize_email_local_part"
        ##
        # Returns unique string in URL.
        #                             <p>Returns unique string in URL</p>
        #                         
        #
        # @param words [String]   
        #   <p>Comma or period separated words list</p>
        #   
        #
        # @param glue [String]   
        #   <p>Separator to add between words passed, default used are ‘-’ or ‘_’</p>
        #    (default value "nil")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.slug                                    #=> "repudiandae-sed"
        #                                         Faker::Internet.slug(words: 'test, faker')              #=> "test-faker"
        #                                         Faker::Internet.slug(words: 'test. faker')              #=> "test-faker"
        #                                         Faker::Internet.slug(words: 'test. faker', glue: '$')   #=> "test$faker"
        #                                     
        #
        def slug(words, glue: nil)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns URL.
        #                             <p>Returns URL</p>
        #                         
        #
        # @param host [String]#
        # @param path [String]#
        # @param scheme [String]    (default value "'http'")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.url                                                           #=> "http://treutel.test/demarcus"
        #                                         Faker::Internet.url(host: 'faker')                                            #=> "http://faker/shad"
        #                                         Faker::Internet.url(host: 'faker', path: '/docs')                             #=> "http://faker/docs"
        #                                         Faker::Internet.url(host: 'faker', path: '/docs', scheme: 'https')            #=> "https://faker/docs"
        #                                     
        #
        def url(host, path, scheme: 'http')
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces a randomized hash of internet user details.
        #                             <p>Produces a randomized hash of internet user details</p>
        #                         
        #
        # @return [hash]
        #
        # @example
        #     Faker::Internet.user #=> { username: 'alexie', email: 'trudie@grant.test' }
        #
        def user()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Generates the random browser identifier.
        #                             <p>Generates the random browser identifier</p>
        #                         
        #
        # @param vendor [String]   
        #   <p>Name of vendor, supported vendors are aol, chrome, firefox, internet_explorer, netscape, opera, safari</p>
        #    (default value "nil")
        #
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.user_agent                    #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        #                                         Faker::Internet.user_agent(vendor: 'chrome')  #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        #                                         Faker::Internet.user_agent(vendor: 'safari')  #=> "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A"
        #                                         Faker::Internet.user_agent(vendor: 'faker')   #=> "Mozilla/5.0 (Windows; U; Win 9x 4.90; SG; rv:1.9.2.4) Gecko/20101104 Netscape/9.1.0285"
        #                                     
        #
        def user_agent(vendor: nil)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Returns the username.
        #                             <p>Returns the username</p>
        #                         
        #
        # @param specifier [Integer]   
        #   <p>When int value passed it returns the username longer than specifier. Max value can be 10^6</p>
        #   
        #
        # @param separators [Array<String>]#
        # @return [String]
        #
        # @example
        #     
        #                                         Faker::Internet.username(specifier: 10)                     #=> "lulu.goodwin"
        #                                         Faker::Internet.username(specifier: 5..10)                  #=> "morris"
        #                                         Faker::Internet.username(specifier: 5..10)                  #=> "berryberry"
        #                                         Faker::Internet.username(specifier: 20, separators: ['_'])  #=> "nikki_sawaynnikki_saway"
        #                                     
        #
        def username(specifier, separators)
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Generated universally unique identifier.
        #                             <p>Generated universally unique identifier</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Internet.uuid  #=> "8a6cdd40-6d78-4fdb-912b-190e3057197f"
        #
        def uuid()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        end
    class Invoice < Base
        class << self
            ##
            # Produces a random amount between values with 2 decimals.
            #                             <p>Produces a random amount between values with 2 decimals</p>
            #                         
            #
            # @param from [Integer]   
            #   <p>Specifies lower limit.</p>
            #   
            #
            # @param to [Integer]   
            #   <p>Specifies upper limit.</p>
            #    (default value "0")
            #
            # @return [Integer]
            #
            # @example
            #     
            #                                         Faker::Finance.amount_between #=> 0
            #                                         Faker::Finance.amount_between(0, 10) #=> 4.33
            #                                     
            #
            def amount_between(from, to: 0)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method calculate_weighted_sum"
            ##
            # Produces a random valid reference accoring to the International bank slip reference https://en.wikipedia.org/wiki/Creditor_Reference.
            #                             <p>Produces a random valid reference accoring to the International bank slip reference <a href="https://en.wikipedia.org/wiki/Creditor_Reference">en.wikipedia.org/wiki/Creditor_Reference</a></p>
            #                         
            #
            # @param ref [String]   
            #   <p>Specifies reference base.</p>
            #    (default value "''")
            #
            # @return [String]
            #
            # @example
            #     Faker::Invoice.creditor_reference #=> "RF34118592570724925498"
            #
            def creditor_reference(ref: '')
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method iban_checksum"
            warn  "Failed processing method kidmod10"
            warn  "Failed processing method method_731"
            warn  "Failed processing method mod10_remainder"
            ##
            # Produces a random valid reference.
            #
            # @param ref [String]   
            #   <p>Specifies reference base.</p>
            #    (default value "''")
            #
            # @return [String]
            #
            # @example
            #     Faker::Invoice.reference #=> "45656646957845"
            #
            def reference(ref: '')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("invoice.reference.pattern"))));
            end
            end
        end
    class JapaneseMedia
        class Conan < Base
            class << self
                ##
                # Produces a character from Conan.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Conan.character #=> "Conan Edogawa"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("conan.characters"))));
                end
                ##
                # Produces a gadget from Conan.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Conan.gadget #=> "Voice-Changing Bowtie"
                #
                def gadget()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("conan.gadgets"))));
                end
                ##
                # Produces a vehicle from Conan.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Conan.vehicle #=> "Agasa's Volkswagen Beetle"
                #
                def vehicle()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("conan.vehicles"))));
                end
                end
            end
        class CowboyBebop < Base
            class << self
                ##
                # Produces a character from Cowboy Bebop.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::CowboyBebop.character #=> "Spike Spiegel"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cowboy_bebop.character"))));
                end
                ##
                # Produces an episode from Cowboy Bebop.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::CowboyBebop.episode #=> "Honky Tonk Women"
                #
                def episode()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cowboy_bebop.episode"))));
                end
                ##
                # Produces a quote from Cowboy Bebop.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::CowboyBebop.quote #=> "Bang!!!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cowboy_bebop.quote"))));
                end
                ##
                # Produces a song title from Cowboy Bebop.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::CowboyBebop.songs #=> "Live in Baghdad"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cowboy_bebop.song"))));
                end
                end
            end
        class Doraemon < Base
            class << self
                ##
                # Produces a character from Doraemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Doraemon.character #=> "Nobita"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("doraemon.characters"))));
                end
                ##
                # Produces a gadget from Doraemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Doraemon.gadget #=> "Anywhere Door"
                #
                def gadget()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("doraemon.gadgets"))));
                end
                ##
                # Produces a location from Doraemon.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Doraemon.location #=> "Tokyo"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("doraemon.locations"))));
                end
                end
            end
        class DragonBall < Base
            class << self
                ##
                # Produces the name of a character from Dragon Ball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DragonBall.character #=> "Goku"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dragon_ball.characters"))));
                end
                ##
                # Produces the name of a planet from Dragon Ball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DragonBall.planet #=> "Namek"
                #
                def planet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dragon_ball.planets"))));
                end
                ##
                # Produces the name of a race from Dragon Ball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Games::DragonBall.race #=> "Saiyan"
                #
                def race()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dragon_ball.races"))));
                end
                end
            end
        class FmaBrotherhood < Base
            class << self
                ##
                # Produces a character from FmaBrotherhood.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::FmaBrotherhood.character #=> "Edward Elric"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("fma_brotherhood.characters"))));
                end
                ##
                # Produces a cities from FmaBrotherhood.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::FmaBrotherhood.city #=> "Central City"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("fma_brotherhood.cities"))));
                end
                ##
                # Produces a country from FmaBrotherhood.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::FmaBrotherhood.country #=> "Xing"
                #
                def country()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("fma_brotherhood.countries"))));
                end
                end
            end
        class KamenRider < Base
            class << self
                ##
                # Produces the name of a collectible device from a Kamen Rider series.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::KamenRider.collectible_device #=> "Vistamp"
                #
                def collectible_device()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def eras()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def eras=()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def from_eras()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kamen_rider.#{era}.#{field}"))));
                end
                ##
                # Produces the name of a Kamen Rider from a series in the given era.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::KamenRider.kamen_rider #=> "Kamen Rider Revice"
                #
                def kamen_rider()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces the name of a Kamen Rider series.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::KamenRider.series #=> "Kamen Rider Revice"
                #
                def series()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces the name of a transformation device used by a Kamen Rider from the given eras.
                #                                 <p>Produces the name of a transformation device used by a Kamen Rider from the given eras.</p>
                # 
                #                                 <p>“Revice Driver”</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #     <p>Faker::JapaneseMedia::KamenRider.transformation_device #=&gt;</p>
                #     
                #
                def transformation_device()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces the name of a main user of Kamen Rider.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::KamenRider.user #=> "Ikki Igarashi"
                #
                def user()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        class Naruto < Base
            class << self
                ##
                # Produces a character from Naruto.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Naruto.character #=> "Naruto Uzumaki"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("naruto.characters"))));
                end
                ##
                # Produces a demon from Naruto.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Naruto.demon #=> "Nine-Tails (Kurama)"
                #
                def demon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("naruto.demons"))));
                end
                ##
                # Produces a eye from Naruto.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Naruto.eye #=> "Konohagakure (Byakugan)"
                #
                def eye()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("naruto.eyes"))));
                end
                ##
                # Produces a village from Naruto.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::Naruto.village #=> "Konohagakure (Leaf Village)"
                #
                def village()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("naruto.villages"))));
                end
                end
            end
        class OnePiece < Base
            class << self
                ##
                # Produces an akuma no mi from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.akuma_no_mi #=> "Gomu Gomu no Mi"
                #
                def akuma_no_mi()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.akuma_no_mi"))));
                end
                ##
                # Produces a character from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.character #=> "Monkey D. Luffy"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.characters"))));
                end
                ##
                # Produces an island from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.island #=> "Laftel"
                #
                def island()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.islands"))));
                end
                ##
                # Produces a location from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.location #=> "Foosha Village"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.locations"))));
                end
                ##
                # Produces a quote from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.quote #=> "ONE PIECE IS REAL!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.quotes"))));
                end
                ##
                # Produces a sea from One Piece.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::OnePiece.sea #=> "East Blue"
                #
                def sea()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("one_piece.seas"))));
                end
                end
            end
        class StudioGhibli < Base
            class << self
                ##
                # Produces a character from the Studio Ghibli.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::StudioGhibli.character #=> "Chihiro"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("studio_ghibli.characters"))));
                end
                ##
                # Produces a movie from Studio Ghibli.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::StudioGhibli.movie #=> "Kiki's Delivery Service"
                #
                def movie()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("studio_ghibli.movies"))));
                end
                ##
                # Produces a quote from Studio Ghibli's movies.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::StudioGhibli.quote #=> "One thing you can always count on is that hearts change."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("studio_ghibli.quotes"))));
                end
                end
            end
        class SwordArtOnline < Base
            class << self
                ##
                # Produces the in-game name of a character from Sword Art Online.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::SwordArtOnline.game_name #=> "Silica"
                #
                def game_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sword_art_online.game_name"))));
                end
                ##
                # Produces the name of an item from Sword Art Online.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::SwordArtOnline.item #=> "Blackwyrm Coat"
                #
                def item()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sword_art_online.item"))));
                end
                ##
                # Produces the name of a location from Sword Art Online.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::SwordArtOnline.location #=> "Ruby Palace"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sword_art_online.location"))));
                end
                ##
                # Produces the real name of a character from Sword Art Online.
                #
                # @return [String]
                #
                # @example
                #     Faker::JapaneseMedia::SwordArtOnline.real_name #=> "Kirigaya Kazuto"
                #
                def real_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sword_art_online.real_name"))));
                end
                end
            end
        end
    class Job < Base
        class << self
            ##
            # Produces a random job field.
            #
            # @return [String]
            #
            # @example
            #     Faker::Job.field #=> "Banking"
            #
            def field()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("job.field"))));
            end
            ##
            # Produces a random job skill.
            #
            # @return [String]
            #
            # @example
            #     Faker::Job.key_skill #=> "Leadership"
            #
            def key_skill()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("job.key_skills"))));
            end
            ##
            # Produces a random job position.
            #
            # @return [String]
            #
            # @example
            #     Faker::Job.position #=> "Strategist"
            #
            def position()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("job.position"))));
            end
            ##
            # Produces a random job title.
            #
            # @return [String]
            #
            # @example
            #     Faker::Job.title #=> "Construction Manager"
            #
            def title()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("job.title"))));
            end
            end
        end
    class Json < Base
        class << self
            ##
            # Produces a random nested JSON formatted string that can take JSON as an additional argument.
            #
            # @param json [Hash{String => String}]   
            #   <p>Specifies a Json.shallow_json and uses its keys as keys of the nested JSON.</p>
            #   
            #
            # @param width [Integer]   
            #   <p>Specifies the number of nested key-value pairs.</p>
            #   
            #
            # @param options [Hash]   
            #   <p>Specifies a Faker gem class to use for nested keys and for values, respectably. options_hash = {key: Class.method, value: Class.method}</p>
            #   
            #
            # @return [Hash{String => String}]
            #
            # @example
            #     
            #                                         json = Faker::Json.shallow_json(width: 3, options: { key: 'Name.first_name', value: 'Name.last_name' })
            #                                         puts json # =>
            #                                         {"Alisha":"Olson","Everardo":"DuBuque","Bridgette":"Turner"}
            #     
            #                                         json2 = Faker::Json.add_depth_to_json(json: json, width: 2, options: { key: 'Name.first_name', value: 'Name.last_name' })
            #                                         puts json2 # =>
            #                                         {"Alisha":{"Daisy":"Trantow","Oda":"Haag"},
            #                                         "Everardo":{"Javier":"Marvin","Eliseo":"Schuppe"},
            #                                         "Bridgette":{"Jorge":"Kertzmann","Lelah":"MacGyver"}}
            #     
            #                                         json3 = Faker::Json.add_depth_to_json(json: json2, width: 4, options: { key: 'Name.first_name', value: 'Name.last_name' })
            #                                         puts json3 # =>
            #                                         {"Alisha":
            #                                         {"Daisy":
            #                                         {"Bulah":"Wunsch","Cristian":"Champlin","Lester":"Bartoletti","Greg":"Jacobson"},
            #                                         "Oda":
            #                                         {"Salvatore":"Kuhlman","Aubree":"Okuneva","Larry":"Schmitt","Velva":"Gibson"}},
            #                                         "Everardo":
            #                                         {"Javier":
            #                                         {"Eduardo":"Orn","Laila":"Kub","Thad":"Legros","Dion":"Wilderman"},
            #                                         "Eliseo":
            #                                         {"Olin":"Hilpert","Marisa":"Greenfelder","Karlee":"Schmitt","Judd":"Larkin"}},
            #                                         "Bridgette":
            #                                         {"Jorge":
            #                                         {"Eloy":"Pfeffer","Kody":"Hansen","Paxton":"Lubowitz","Abe":"Lesch"},
            #                                         "Lelah":
            #                                         {"Rick":"Wiza","Bonita":"Bayer","Gardner":"Auer","Felicity":"Abbott"}}}
            #                                     
            #
            def add_depth_to_json(json, width, options)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method add_hash"
            warn  "Failed processing method add_hash_to_bottom"
            warn  "Failed processing method build_keys_from_array"
            warn  "Failed processing method build_shallow_hash"
            ##
            # Produces a random simple JSON formatted string.
            #
            # @param width [Integer]   
            #   <p>Specifies the number of key-value pairs.</p>
            #   
            #
            # @param options [Hash]   
            #   <p>Specifies a Faker gem class to use for keys and for values, respectably. options_hash = {key: Class.method, value: Class.method}</p>
            #   
            #
            # @return [Hash{String => String}]
            #
            # @example
            #     
            #                                         Faker::Json.shallow_json(width: 3, options: { key: 'RockBand.name', value: 'Seinfeld.quote' }) # =>
            #                                         {"Parliament Funkadelic":"They're real, and they're spectacular.",
            #                                         "Fleetwood Mac":"I'm not a lesbian. I hate men, but I'm not a lesbian.",
            #                                         "The Roots":"It became very clear to me sitting out there today that every decision
            #                                         I've made in my entire life has been wrong. My life is the complete opposite of everything
            #                                         I want it to be. Every instinct I have, in every aspect of life, be it something to wear,
            #                                         something to eat - it's all been wrong."}
            #                                     
            #
            def shallow_json(width, options)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Kpop < Base
        class << self
            ##
            # Produces the name of a K-Pop boy band.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.boy_bands #=> "Exo"
            #
            def boy_bands()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.boy_bands"))));
            end
            ##
            # Produces the name of a K-Pop girl group.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.girl_groups #=> "2NE1"
            #
            def girl_groups()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.girl_groups"))));
            end
            ##
            # Produces the name of a 1990's 'OG' K-Pop group.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.i_groups #=> "Seo Taiji and Boys"
            #
            def i_groups()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.i_groups"))));
            end
            ##
            # Produces the name of a 2000's K-Pop group.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.ii_groups #=> "Girls' Generation"
            #
            def ii_groups()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.ii_groups"))));
            end
            ##
            # Produces the name of a 2010's K-Pop group.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.iii_groups #=> "Trouble Maker"
            #
            def iii_groups()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.iii_groups"))));
            end
            ##
            # Produces the name of a solo K-Pop artist.
            #
            # @return [String]
            #
            # @example
            #     Faker::Kpop.solo #=> "T.O.P"
            #
            def solo()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("kpop.solo"))));
            end
            end
        end
    ##
    # Based on Perl's Text::Lorem.
    # <p>Based on Perl’s Text::Lorem</p>
    # 
    #
    class Lorem < Base
        class << self
            ##
            # Generates single character.
            #                             <p>Generates single character</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Lorem.character    #=> "e"
            #
            def character()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random string of alphanumeric characters.
            #                             <p>Produces a random string of alphanumeric characters</p>
            #                         
            #
            # @param number [Integer]   
            #   <p>The number of characters to generate</p>
            #   
            #
            # @param min_alpha [Integer]   
            #   <p>The minimum number of alphabetic to add to the string</p>
            #   
            #
            # @param min_numeric [Integer]   
            #   <p>The minimum number of numbers to add to the string</p>
            #    (default value "0")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.characters #=> "uw1ep04lhs0c4d931n1jmrspprf5w..."
            #                                         Faker::Lorem.characters(number: 10) #=> "ang9cbhoa8"
            #                                         Faker::Lorem.characters(number: 10, min_alpha: 4) #=> "ang9cbhoa8"
            #                                         Faker::Lorem.characters(number: 10, min_alpha: 4, min_numeric: 1) #=> "ang9cbhoa8"
            #                                     
            #
            def characters(number, min_alpha, min_numeric: 0)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method locale_period"
            warn  "Failed processing method locale_question_mark"
            warn  "Failed processing method locale_space"
            ##
            # Generates the emoji.
            #                             <p>Generates the emoji</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.multibyte  #=> "😀"
            #                                         Faker::Lorem.multibyte  #=> "❤"
            #                                     
            #
            def multibyte()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates three sentence paragraph.
            #                             <p>Generates three sentence paragraph</p>
            #                         
            #
            # @param sentence_count [Integer]   
            #   <p>Number of sentences in the paragraph</p>
            #   
            #
            # @param supplemental [Boolean]#
            # @param random_sentences_to_add [Integer]#
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.paragraph
            #                                         #=> "Impedit et est. Aliquid deleniti necessitatibus. Et aspernatur minima."
            #                                         Faker::Lorem.paragraph(sentence_count: 2)
            #                                         #=> "Rerum fugit vitae. Et atque autem."
            #                                         Faker::Lorem.paragraph(sentence_count: 2, supplemental: true)
            #                                         #=> "Terreo coerceo utor. Vester sunt cogito."
            #                                         Faker::Lorem.paragraph(sentence_count: 2, supplemental: true, random_sentences_to_add: 2)
            #                                         #=> "Texo tantillus tamisium. Tribuo amissio tamisium. Facere aut canis."
            #                                     
            #
            def paragraph(sentence_count, supplemental, random_sentences_to_add)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates paragraph with 256 characters.
            #                             <p>Generates paragraph with 256 characters</p>
            #                         
            #
            # @param number [Integer]#
            # @param supplemental [Boolean]    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.paragraph_by_chars
            #                                         Faker::Lorem.paragraph_by_chars(number: 20)                       #=> "Sit modi alias. Imp."
            #                                         Faker::Lorem.paragraph_by_chars(number: 20, supplemental: true)   #=> "Certus aveho admove."
            #                                     
            #
            def paragraph_by_chars(number, supplemental: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates three paragraphs.
            #                             <p>Generates three paragraphs</p>
            #                         
            #
            # @param number [Integer]#
            # @param supplemental [Boolean]#
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Lorem.paragraphs
            #                                         Faker::Lorem.paragraphs(number:2)
            #                                         Faker::Lorem.paragraphs(number:2, supplemental: true)
            #                                     
            #
            def paragraphs(number, supplemental)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Returns the question with 4 words.
            #                             <p>Returns the question with 4 words</p>
            #                         
            #
            # @param word_count [Integer]#
            # @param supplemental [Boolean]#
            # @param random_words_to_add [Integer]#
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.question                                                               #=> "Natus deleniti sequi laudantium?"
            #                                         Faker::Lorem.question(word_count: 2)                                                #=> "Quo ut?"
            #                                         Faker::Lorem.question(word_count: 2, supplemental: true)                            #=> "Terga consequatur?"
            #                                         Faker::Lorem.question(word_count: 2, supplemental: true, random_words_to_add: 2)    #=> "Depulso uter ut?"
            #                                     
            #
            def question(word_count, supplemental, random_words_to_add)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates array of three questions.
            #                             <p>Generates array of three questions</p>
            #                         
            #
            # @param number [Integer]#
            # @param supplemental [Boolean]#
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Lorem.questions                                  #=> ["Amet culpa enim?", "Voluptatem deleniti numquam?", "Veniam non cum?"]
            #                                         Faker::Lorem.questions(number: 2)                       #=> ["Minus occaecati nobis?", "Veniam et alias?"]
            #                                         Faker::Lorem.questions(number: 2, supplemental: true)   #=> ["Acceptus subito cetera?", "Aro sulum cubicularis?"]
            #                                     
            #
            def questions(number, supplemental)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates sentence.
            #                             <p>Generates sentence</p>
            #                         
            #
            # @param word_count [Integer]   
            #   <p>How many words should be there in a sentence, default to 4</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Add supplemental words, default to false</p>
            #   
            #
            # @param random_words_to_add [Integer]   
            #   <p>Add any random words, default to 0</p>
            #   
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.sentence                                                             #=> "Magnam qui aut quidem."
            #                                         Faker::Lorem.sentence(word_count: 5)                                              #=> "Voluptas rerum aut aliquam velit."
            #                                         Faker::Lorem.sentence(word_count: 5, supplemental: true)                          #=> "Aut viscus curtus votum iusto."
            #                                         Faker::Lorem.sentence(word_count: 5, supplemental: true, random_words_to_add:2)   #=> "Crinis quo cruentus velit animi vomer."
            #                                     
            #
            def sentence(word_count, supplemental, random_words_to_add)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates three sentences.
            #                             <p>Generates three sentences</p>
            #                         
            #
            # @param number [Integer]   
            #   <p>How many sentences to be generated, default to 3</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Should add supplemental words, defaults to false</p>
            #   
            #
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Lorem.sentences                                  #=> ["Possimus non tenetur.", "Nulla non excepturi.", "Quisquam rerum facilis."]
            #                                         Faker::Lorem.sentences(number: 2)                       #=> ["Nulla est natus.", "Perferendis autem cum."]
            #                                         Faker::Lorem.sentences(number: 2, supplemental: true)   #=> ["Cito cena ad.", "Solvo animus allatus."]
            #                                     
            #
            def sentences(number, supplemental)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Returs the random word.
            #                             <p>Returs the random word</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Lorem.word   #=> "soluto"
            #                                         Faker::Lorem.word(exclude_words: 'error') #=> "nisi"
            #                                         Faker::Lorem.word(exclude_words: 'id, error') #=> "et"
            #                                         Faker::Lorem.word(exclude_words: ['id', 'error']) #=> "consequatur"
            #                                     
            #
            def word()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generates random 3 words.
            #                             <p>Generates random 3 words</p>
            #                         
            #
            # @param number [Integer]   
            #   <p>Number of words to be generated</p>
            #   
            #
            # @param supplemental [Boolean]   
            #   <p>Whether to attach supplemental words at the end, default is false</p>
            #   
            #
            # @return [Array<String>]
            #
            # @example
            #     
            #                                         Faker::Lorem.words                                    #=> ["hic", "quia", "nihil"]
            #                                         Faker::Lorem.words(number: 4)                         #=> ["est", "temporibus", "et", "quaerat"]
            #                                         Faker::Lorem.words(number: 4, supplemental: true)    #=> ["nisi", "sit", "allatus", "consequatur"]
            #                                         Faker::Lorem.words(number: 4, supplemental: true, exclude_words: 'sit') #=> ["nisi", "allatus", "consequatur", "aut"]
            #                                     
            #
            def words(number, supplemental)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class LoremFlickr < Base
        class << self
            warn  "Failed processing method build_url"
            ##
            # Produces a random colorized image URL from loremflickr.com.
            #
            # @param size [String]   
            #   <p>Specifies the size of image to generate.</p>
            #   
            #
            # @param color [String]   
            #   <p>Specifies the color of image to generate.</p>
            #   
            #
            # @param search_terms [Array<String>]   
            #   <p>Adds search terms to the image URL.</p>
            #   
            #
            # @param match_all [Boolean]   
            #   <p>Add “all” as part of the URL.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::LoremFlickr.image #=> "https://loremflickr.com/red/300/300/all"
            #                                         Faker::LoremFlickr.image(size: "50x60", color: 'blue') #=> "https://loremflickr.com/blue/50/60/all"
            #                                         Faker::LoremFlickr.image(size: "50x60", color: 'blue', search_terms: ['sports']) #=> "https://loremflickr.com/blue/50/60/sports"
            #                                         Faker::LoremFlickr.image(size: "50x60", color: 'blue', search_terms: ['sports', 'fitness']) #=> "https://loremflickr.com/blue/50/60/sports,fitness"
            #                                         Faker::LoremFlickr.image(size: "50x60", color: 'blue', search_terms: ['sports', 'fitness'], match_all: true) #=> "https://loremflickr.com/blue/50/60/sports,fitness/all"
            #                                     
            #
            def colorized_image(size, color, search_terms, match_all: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random grayscale image URL from loremflickr.com.
            #
            # @param size [String]   
            #   <p>Specifies the size of image to generate.</p>
            #   
            #
            # @param search_terms [Array<String>]   
            #   <p>Adds search terms to the image URL.</p>
            #   
            #
            # @param match_all [Boolean]   
            #   <p>Add “all” as part of the URL.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::LoremFlickr.grayscale_image #=> "https://loremflickr.com/g/300/300/all"
            #                                         Faker::LoremFlickr.grayscale_image(size: "50x60") #=> "https://loremflickr.com/g/50/60/all"
            #                                         Faker::LoremFlickr.grayscale_image(size: "50x60", search_terms: ['sports']) #=> "https://loremflickr.com/g/50/60/sports"
            #                                         Faker::LoremFlickr.grayscale_image(size: "50x60", search_terms: ['sports', 'fitness']) #=> "https://loremflickr.com/50/60/g/sports,fitness"
            #                                         Faker::LoremFlickr.grayscale_image(size: "50x60", search_terms: ['sports', 'fitness'], match_all: true) #=> "https://loremflickr.com/g/50/60/sports,fitness/all"
            #                                     
            #
            def grayscale_image(size, search_terms, match_all: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random image URL from loremflickr.com.
            #
            # @param size [String]   
            #   <p>Specifies the size of image to generate.</p>
            #   
            #
            # @param search_terms [Array<String>]   
            #   <p>Adds search terms to the image URL.</p>
            #   
            #
            # @param match_all [Boolean]   
            #   <p>Add “all” as part of the URL.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::LoremFlickr.image #=> "https://loremflickr.com/300/300"
            #                                         Faker::LoremFlickr.image(size: "50x60") #=> "https://loremflickr.com/50/60"
            #                                         Faker::LoremFlickr.image(size: "50x60", search_terms: ['sports']) #=> "https://loremflickr.com/50/60/sports"
            #                                         Faker::LoremFlickr.image(size: "50x60", search_terms: ['sports', 'fitness']) #=> "https://loremflickr.com/50/60/sports,fitness"
            #                                         Faker::LoremFlickr.image(size: "50x60", search_terms: ['sports', 'fitness'], match_all: true) #=> "https://loremflickr.com/50/60/sports,fitness/all"
            #                                     
            #
            def image(size, search_terms, match_all: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random pixelated image URL from loremflickr.com.
            #
            # @param size [String]   
            #   <p>Specifies the size of image to generate.</p>
            #   
            #
            # @param search_terms [Array<String>]   
            #   <p>Adds search terms to the image URL.</p>
            #   
            #
            # @param match_all [Boolean]   
            #   <p>Add “all” as part of the URL.</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::LoremFlickr.pixelated_image #=> "https://loremflickr.com/p/300/300/all"
            #                                         Faker::LoremFlickr.pixelated_image(size: "50x60") #=> "https://loremflickr.com/p/50/60/all"
            #                                         Faker::LoremFlickr.pixelated_image(size: "50x60", search_terms: ['sports']) #=> "https://loremflickr.com/p/50/60/sports"
            #                                         Faker::LoremFlickr.pixelated_image(size: "50x60", search_terms: ['sports', 'fitness']) #=> "https://loremflickr.com/p/50/60/sports,fitness"
            #                                         Faker::LoremFlickr.pixelated_image(size: "50x60", search_terms: ['sports', 'fitness'], match_all: true) #=> "https://loremflickr.com/p/50/60/sports,fitness/all"
            #                                     
            #
            def pixelated_image(size, search_terms, match_all: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Markdown < Base
        class << self
            warn  "Failed processing method available_methods"
            ##
            # Produces a random code block formatted in Ruby.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.block_code #=> "```ruby\nEos quasi qui.\n```"
            #
            def block_code()
                return "```ruby\n#{Lorem.sentence(word_count: 1)}\n```";
            end
            ##
            # Produces a random emphasis formatting on a random word in two sentences.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.emphasis #=> "_Incidunt atque quis repellat id impedit.  Quas numquam quod incidunt dicta non. Blanditiis delectus laudantium atque reiciendis qui._"
            #
            def emphasis()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("markdown.emphasis"))));
            end
            ##
            # Produces a random header format.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.headers #=> "##### Autem"
            #
            def headers()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("markdown.headers"))));
            end
            ##
            # Produces a random inline code snippet between two sentences.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.inline_code #=> "Aut eos quis suscipit. `Dignissimos voluptatem expedita qui.` Quo doloremque veritatis tempora aut."
            #
            def inline_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify("`#{Faker::Lorem.sentence(word_count: 1)}`")));
            end
            ##
            # Produces a random ordered list of items between 1 and 10 randomly.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.ordered_list #=> "1. Qui reiciendis non consequatur atque.\n2. Quo doloremque veritatis tempora aut.\n3. Aspernatur.\n4. Ea ab.\n5. Qui.\n6. Sit pariatur nemo eveniet.\n7. Molestiae aut.\n8. Nihil molestias iure placeat.\n9. Dolore autem quisquam."
            #
            def ordered_list()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method random"
            ##
            # Produces a simulated blog-esque text-heavy block in markdown.
            #                             <p>Produces a simulated blog-esque text-heavy block in markdown</p>
            # 
            #                             <p>Keyword arguments: sentences, repeat</p>
            #                         
            #
            # @param sentences [Integer]   
            #   <p>Specifies how many sentences make a text block.</p>
            #   
            #
            # @param repeat [Integer]   
            #   <p>Specifies how many times the text block repeats.</p>
            #    (default value "1")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Markdown.sandwich #=> returns newline separated content of 1 header, 1 default lorem paragraph, and 1 random markdown element
            #                                         Faker::Markdown.sandwich(sentences: 5) #=> returns newline separated content of 1 header, 1 5-sentence lorem paragraph, and 1 random markdown element
            #                                         Faker::Markdown.sandwich(sentences: 6, repeat: 3) #=> returns newline separated content of 1 header, and then 3 sections consisting of, here, 1 6-sentence lorem paragraph and 1 random markdown element. The random markdown element is chosen at random in each iteration of the paragraph-markdown pairing.
            #                                     
            #
            def sandwich(sentences, repeat: 1)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random 3x4 table with a row of headings, a row of hyphens and two rows of data.
            #                             <p>Produces a random 3x4 table with a row of headings, a row of hyphens and two rows of data</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.table #=> "ad | similique | voluptatem\ncorrupti | est | rerum\nmolestiae | quidem | et"
            #
            def table()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random unordered list of items between 1 and 10 randomly.
            #
            # @return [String]
            #
            # @example
            #     Faker::Markdown.unordered_list #=> "* Voluptatum aliquid tempora molestiae facilis non sed.\n* Nostrum omnis iste impedit voluptatum dolor.\n* Esse quidem et facere."
            #
            def unordered_list()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Marketing < Base
        class << self
            ##
            # Produces a few marketing buzzwords.
            #
            # @return [String]
            #
            # @example
            #     Faker::Marketing.buzzwords #=> "rubber meets the road"
            #
            def buzzwords()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("marketing.buzzwords"))));
            end
            end
        end
    class Measurement < Base
        class << self
            warn  "Failed processing method check_for_plural"
            warn  "Failed processing method define_measurement_locale"
            warn  "Failed processing method ensure_valid_amount"
            ##
            # Produces a random height measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random height value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.height #=> "6 inches"
            #                                         Faker::Measurement.height(amount: 1.4) #=> "1.4 inches"
            #                                         Faker::Measurement.height(amount: "none") #=> "inch"
            #                                         Faker::Measurement.height(amount: "all") #=> "inches"
            #                                     
            #
            def height(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random length measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random length value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.length #=> "1 yard"
            #                                         Faker::Measurement.length(amount: 1.4) #=> "1.4 yards"
            #                                     
            #
            def length(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method make_plural"
            ##
            # Produces a random metric height measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random height value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.metric_height #=> "2 meters"
            #                                         Faker::Measurement.metric_height(amount: 1.4) #=> "1.4 meters"
            #                                     
            #
            def metric_height(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random metric length measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random length value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.metric_length #=> "0 decimeters"
            #                                         Faker::Measurement.metric_length(amount: 1.4) #=> "1.4 decimeters"
            #                                     
            #
            def metric_length(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random metric volume measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random volume value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.metric_volume #=> "1 liter"
            #                                         Faker::Measurement.metric_volume(amount: 1.4) #=> "1.4 liters"
            #                                     
            #
            def metric_volume(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random metric weight measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random weight value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.metric_weight #=> "8 grams"
            #                                         Faker::Measurement.metric_weight(amount: 1.4) #=> "1.4 grams"
            #                                     
            #
            def metric_weight(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random volume measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random volume value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.volume #=> "10 cups"
            #                                         Faker::Measurement.volume(amount: 1.4) #=> "1.4 cups"
            #                                     
            #
            def volume(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random weight measurement.
            #
            # @param amount [Integer]   
            #   <p>Specifies the random weight value.</p>
            #    (default value "rand(10)")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Measurement.weight #=> "3 pounds"
            #                                         Faker::Measurement.weight(amount: 1.4) #=> "1.4 pounds"
            #                                     
            #
            def weight(amount: rand(10))
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Military < Base
        class << self
            ##
            # Produces a rank in the U.S.
            #                             <p>Air Force.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.air_force_rank #=> "Captain"
            #
            def air_force_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.air_force_rank"))));
            end
            ##
            # Produces a rank in the U.S.
            #                             <p>Army.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.army_rank #=> "Staff Sergeant"
            #
            def army_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.army_rank"))));
            end
            ##
            # Produces a rank in the U.S.
            #                             <p>Coast Guard</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.coast_guard_rank #=> "Master Chief Petty Officer of the Coast Guard"
            #
            def coast_guard_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.coast_guard_rank"))));
            end
            ##
            # Produces a U.S.
            #                             <p>Department of Defense Paygrade.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.dod_paygrade #=> "E-6"
            #
            def dod_paygrade()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.dod_paygrade"))));
            end
            ##
            # Produces a rank in the U.S.
            #                             <p>Marines.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.marines_rank #=> "Gunnery Sergeant"
            #
            def marines_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.marines_rank"))));
            end
            ##
            # Produces a rank in the U.S.
            #                             <p>Navy.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.navy_rank #=> "Seaman"
            #
            def navy_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.navy_rank"))));
            end
            ##
            # Produces a rank in the U.S.
            #                             <p>Space Force.</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Military.space_force_rank #=> "Senior Enlisted Advisor of the Space Force"
            #
            def space_force_rank()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("military.space_force_rank"))));
            end
            end
        end
    class Mountain < Base
        class << self
            ##
            # Produces a name of a mountain.
            #                             <p>Produces a name of a mountain</p>
            # 
            #                             <pre><code>@faker.version next
            #                             </code></pre>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Mountain.name #=> "Mount Everest"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("mountain.name"))));
            end
            ##
            # Produces a name of a range.
            #                             <p>Produces a name of a range</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Mountain.range #=> "Dhaulagiri Himalaya"
            #
            def range()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("mountain.range"))));
            end
            end
        end
    class Movie < Base
        class << self
            ##
            # Produces a quote from a movie.
            #
            # @return [String]
            #
            # @example
            #     Faker::Movie.quote #=> "Bumble bee tuna"
            #
            def quote()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("movie.quote"))));
            end
            ##
            # Produces a title from a movie.
            #
            # @return [String]
            #
            # @example
            #     Faker::Movie.title #=> "The Lord of the Rings: The Two Towers"
            #
            def title()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("movie.title"))));
            end
            end
        end
    class Movies
        class Avatar < Base
            class << self
                ##
                # Produces a character from Avatar.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Avatar.character #=> "Jake Sully"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("avatar.characters"))));
                end
                ##
                # Produces a date from Avatar.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Avatar.date #=> "December 15, 2022"
                #
                def date()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("avatar.dates"))));
                end
                ##
                # Produces a quote from Avatar.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::Avatar.quote
                #                                             #=> "If it ain't raining, we ain't training."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("avatar.quotes"))));
                end
                end
            end
        class BackToTheFuture < Base
            class << self
                ##
                # Produces a character from Back to the Future.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::BackToTheFuture.character #=> "Marty McFly"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("back_to_the_future.characters"))));
                end
                ##
                # Produces a date from Back to the Future.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::BackToTheFuture.date #=> "November 5, 1955"
                #
                def date()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("back_to_the_future.dates"))));
                end
                ##
                # Produces a quote from Back to the Future.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::BackToTheFuture.quote
                #                                             #=> "Roads? Where we're going, we don't need roads."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("back_to_the_future.quotes"))));
                end
                end
            end
        class Departed < Base
            class << self
                ##
                # Produces an actor from The Departed.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Departed.actor #=> "Matt Damon"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("departed.actors"))));
                end
                ##
                # Produces a character from The Departed.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Departed.character #=> "Frank Costello"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("departed.characters"))));
                end
                ##
                # Produces a quote from The Departed.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::Departed.quote
                #                                             #=> "I'm the guy who does his job. You must be the other guy"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("departed.quotes"))));
                end
                end
            end
        class Ghostbusters < Base
            class << self
                ##
                # Produces an actor from Ghostbusters.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Ghostbusters.actor #=> "Bill Murray"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ghostbusters.actors"))));
                end
                ##
                # Produces a character from Ghostbusters.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Ghostbusters.character #=> "Dr. Egon Spengler"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ghostbusters.characters"))));
                end
                ##
                # Produces a quote from Ghostbusters.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::Ghostbusters.quote
                #                                             #=> "I tried to think of the most harmless thing. Something I loved from my childhood. Something that could never ever possibly destroy us. Mr. Stay Puft!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("ghostbusters.quotes"))));
                end
                end
            end
        class Hackers < Base
            class << self
                ##
                # Produces a real character name from Hackers.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hackers.character #=> "Dade Murphy"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hackers.characters"))));
                end
                ##
                # Produces a character hacker "handle" from Hackers.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hackers.handle #=> "Zero Cool"
                #
                def handle()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hackers.handles"))));
                end
                ##
                # Produces a quote from Hackers.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hackers.quote #=> "Hack the Planet!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hackers.quotes"))));
                end
                end
            end
        class HarryPotter < Base
            class << self
                ##
                # Produces a book from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.book #=> "Harry Potter and the Chamber of Secrets"
                #
                def book()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.books"))));
                end
                ##
                # Produces a character from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.character #=> "Harry Potter"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.characters"))));
                end
                ##
                # Produces a house from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.house #=> "Gryffindor"
                #
                def house()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.houses"))));
                end
                ##
                # Produces a location from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.location #=> "Hogwarts"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.locations"))));
                end
                ##
                # Produces a quote from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.quote #=> "I solemnly swear that I am up to good."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.quotes"))));
                end
                ##
                # Produces a spell from Harry Potter.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HarryPotter.spell #=> "Reparo"
                #
                def spell()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("harry_potter.spells"))));
                end
                end
            end
        class HitchhikersGuideToTheGalaxy < Base
            class << self
                ##
                # Produces a character from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HitchhikersGuideToTheGalaxy.character #=> "Marvin"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.characters"))));
                end
                ##
                # Produces a location from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.location
                #                                             #=> "Arthur Dent's house"
                #                                         
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.locations"))));
                end
                ##
                # Produces a Marvin quote from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.marvin_quote
                #                                             #=> "Life? Don't talk to me about life."
                #                                         
                #
                def marvin_quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.marvin_quote"))));
                end
                ##
                # Produces a planet from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.planet
                #                                             #=> "Magrathea"
                #                                         
                #
                def planet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.planets"))));
                end
                ##
                # Produces a quote from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.quote
                #                                             #=> "In the beginning, the Universe was created. This has made a lot of people very angry and been widely regarded as a bad move."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.quotes"))));
                end
                ##
                # Produces a species from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.specie
                #                                             #=> "Perfectly Normal Beast"
                #                                         
                #
                def specie()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.species"))));
                end
                ##
                # Produces a starship from The Hitchhiker's Guide to the Galaxy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::HitchhikersGuideToTheGalaxy.starship
                #                                             #=> "Vogon Constructor Fleet"
                #                                         
                #
                def starship()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hitchhikers_guide_to_the_galaxy.starships"))));
                end
                end
            end
        class Hobbit < Base
            class << self
                ##
                # Produces the name of a character from The Hobbit.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hobbit.character #=> "Gandalf the Grey"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.hobbit.character"))));
                end
                ##
                # Produces the name of a location from The Hobbit.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hobbit.location #=> "The Shire"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.hobbit.location"))));
                end
                ##
                # Produces a quote from The Hobbit.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::Hobbit.quote
                #                                             #=> "Never laugh at live dragons, Bilbo you fool!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.hobbit.quote"))));
                end
                ##
                # Produces the name of one of the 13 dwarves from the Company, or Gandalf or Bilbo.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Hobbit.thorins_company #=> "Thorin Oakenshield"
                #
                def thorins_company()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.hobbit.thorins_company"))));
                end
                end
            end
        class HowToTrainYourDragon < Base
            class << self
                ##
                # Produces a character from How To Train Your Dragon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HowToTrainYourDragon.character #=> "Hiccup"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_to_train_your_dragon.characters"))));
                end
                ##
                # Produces a dragon from How To Train Your Dragon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HowToTrainYourDragon.dragons #=> "Toothless"
                #
                def dragon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_to_train_your_dragon.dragons"))));
                end
                ##
                # Produces a location from How To Train Your Dragon.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::HowToTrainYourDragon.location #=> "Berk"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_to_train_your_dragon.locations"))));
                end
                end
            end
        class Lebowski < Base
            class << self
                ##
                # Produces an actor from The Big Lebowski.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Lebowski.actor #=> "John Goodman"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lebowski.actors"))));
                end
                ##
                # Produces a character from The Big Lebowski.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Lebowski.character #=> "Jackie Treehorn"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lebowski.characters"))));
                end
                ##
                # Produces a quote from The Big Lebowski.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Lebowski.quote #=> "Forget it, Donny, you're out of your element!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("lebowski.quotes"))));
                end
                end
            end
        class LordOfTheRings < Base
            class << self
                ##
                # Produces a character from Lord of the Rings.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::LordOfTheRings.character #=> "Legolas"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.lord_of_the_rings.characters"))));
                end
                ##
                # Produces a location from Lord of the Rings.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::LordOfTheRings.location #=> "Helm's Deep"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.lord_of_the_rings.locations"))));
                end
                ##
                # Produces a quote from Lord of the Rings.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::LordOfTheRings.quote
                #                                             #=> "I wish the Ring had never come to me. I wish none of this had happened."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tolkien.lord_of_the_rings.quotes"))));
                end
                end
            end
        class PrincessBride < Base
            class << self
                ##
                # Produces a character from The Princess Bride.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::PrincessBride.character #=> "Dread Pirate Roberts"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("princess_bride.characters"))));
                end
                ##
                # Produces a quote from The Princess Bride.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::PrincessBride.quote
                #                                             #=> "Hello. My name is Inigo Montoya. You killed my father. Prepare to die!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("princess_bride.quotes"))));
                end
                end
            end
        class StarWars < Base
            class << self
                ##
                # Produces a call number from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.call_number #=> "Leader"
                #
                def call_number()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Generates numbers array.
                #                                 <p>Generates numbers array</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.call_numbers  #=> ["Leader", "#"]
                #
                def call_numbers()
                    return fetch("star_wars.call_numbers");
                end
                ##
                # Produces a call sign from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.call_sign #=> "Grey 5"
                #
                def call_sign()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("star_wars.call_sign"))));
                end
                ##
                # Produces a call squadron from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.call_squadron #=> "Green"
                #
                def call_squadron()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Returns squadrons array.
                #                                 <p>Returns squadrons array</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.call_squadrons  #=> ["Rogue", "Red", "Gray", "Green", "Blue", "Gold", "Black", "Yellow", "Phoenix"]
                #
                def call_squadrons()
                    return fetch("star_wars.call_squadrons");
                end
                ##
                # Produces a character from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.character #=> "Anakin Skywalker"
                #
                def character()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Returns all character names in movie.
                #                                 <p>Returns all character names in movie</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.characters
                #
                def characters()
                    return fetch("star_wars.characters");
                end
                ##
                # Produces a droid from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.droid #=> "C-3PO"
                #
                def droid()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Returns droid list.
                #                                 <p>Returns droid list</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.droids
                #
                def droids()
                    return fetch("star_wars.droids");
                end
                ##
                # Produces a planet from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.planet #=> "Tatooine"
                #
                def planet()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Lists out all planet names.
                #                                 <p>Lists out all planet names</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.planets
                #
                def planets()
                    return fetch("star_wars.planets");
                end
                ##
                # Produces a quote from Star Wars.
                #
                # @param character [String]   
                #   <p>The name of a character to derive a quote from.</p>
                #    (default value "nil")
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.quote #=> "Aren't you a little short for a Stormtrooper?"
                #
                def quote(character: nil)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a species from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.specie #=> "Gungan"
                #
                def specie()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Returns name of all species.
                #                                 <p>Returns name of all species</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.species
                #
                def species()
                    return fetch("star_wars.species");
                end
                ##
                # Produces a vehicle from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.vehicle #=> "Sandcrawler"
                #
                def vehicle()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Lists out all vehicles.
                #                                 <p>Lists out all vehicles</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.vehicles
                #
                def vehicles()
                    return fetch("star_wars.vehicles");
                end
                ##
                # Produces a wookiee sentence from Star Wars.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::StarWars.wookiee_sentence #=> "Yrroonn ru ooma roo ahuma ur roooarrgh hnn-rowr."
                #
                def wookiee_sentence()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # All wookiee words.
                #                                 <p>All wookiee words</p>
                #                             
                #
                # @return [Array<String>]
                #
                # @example
                #     Faker::Movies::StarWars.wookiee_words
                #
                def wookiee_words()
                    return fetch("star_wars.wookiee_words");
                end
                end
            end
        class TheRoom < Base
            class << self
                ##
                # Produces an actor from The Room (2003).
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Room.actor #=> "Tommy Wiseau"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_room.actors"))));
                end
                ##
                # Produces a character from The Room (2003).
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Room.character #=> "Johnny"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_room.characters"))));
                end
                ##
                # Produces a location from The Room (2003).
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Room.location #=> "Johnny's Apartment"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_room.locations"))));
                end
                ##
                # Produces a quote from The Room (2003).
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::Room.quote
                #                                             #=> "You're lying, I never hit you. You are tearing me apart, Lisa!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_room.quotes"))));
                end
                end
            end
        class Tron < Base
            class << self
                ##
                # Produces a character from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.character #=> "Bit"
                #
                def character()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a game from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.game #=> "Space Paranoids"
                #
                def game()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a location from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.location #=> "Flynn's Arcade"
                #
                def location()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a program from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.program #=> "Clu"
                #
                def program()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a quote from Tron.
                #
                # @param character [String]   
                #   <p>The name of a character to derive a quote from.</p>
                #    (default value "nil")
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.quote #=> "Greetings, Programs!"
                #
                def quote(character: nil)
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a tagline from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.tagline #=> "The Electronic Gladiator"
                #
                def tagline()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a user from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.user #=> "Light Cycle"
                #
                def user()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a vehicle from Tron.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::Tron.vehicle #=> "Light Cycle"
                #
                def vehicle()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        class VForVendetta < Base
            class << self
                ##
                # Produces a character from V For Vendetta.
                #
                # @return [String]
                #
                # @example
                #     Faker::Movies::VForVendetta.character #=> "V"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("v_for_vendetta.characters"))));
                end
                ##
                # Produces a quote from V For Vendetta.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::VForVendetta.quote
                #                                             #=> "People should not be afraid of their governments. Governments should be afraid of their people."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("v_for_vendetta.quotes"))));
                end
                ##
                # Produces a speech from V For Vendetta.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Movies::VForVendetta.speech
                #                                             #=> "Remember, remember, the Fifth of November, the Gunpowder Treason and Plot. I know of no reason why the Gunpowder Treason should ever be forgot..."
                #                                         
                #
                def speech()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("v_for_vendetta.speeches"))));
                end
                end
            end
        end
    ##
    # A generator of titles of operas by various composers.
    # <p>A generator of titles of operas by various composers</p>
    # 
    #
    class Music
        class GratefulDead < Base
            class << self
                ##
                # Produces the name of a member of The Grateful Dead.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::GratefulDead.player #=> "Jerry Garcia"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("grateful_dead.players"))));
                end
                ##
                # Produces the name of a song by The Grateful Dead.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::GratefulDead.song #=> "Cassidy"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("grateful_dead.songs"))));
                end
                end
            end
        class Hiphop < Base
            class << self
                ##
                # Produces the name of a Hip Hop Artist.
                #                                 <p>Produces the name of a Hip Hop Artist</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Hiphop.artist #=> "Lil Wayne"
                #
                def artist()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.hiphop.artist"))));
                end
                ##
                # Produces the name of a Hip Hop Group.
                #                                 <p>Produces the name of a Hip Hop Group</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Hiphop.groups #=> "OVO"
                #
                def groups()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.hiphop.groups"))));
                end
                ##
                # Produces the name of a Hip Hop Subgenre.
                #                                 <p>Produces the name of a Hip Hop Subgenre</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Hiphop.subgeneres #=> "Alternative"
                #
                def subgenres()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.hiphop.subgenres"))));
                end
                end
            end
        class Opera < Base
            class << self
                ##
                # Produces the title of an opera by Ludwig van Beethoven.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.beethoven #=> "Fidelio"
                #
                def beethoven()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_ludwig_van_beethoven"))));
                end
                ##
                # Produces the title of an opera by Vincenzo Bellini.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.bellini #=> "Norma"
                #
                def bellini()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_vincenzo_bellini"))));
                end
                ##
                # Produces the title of an opera by Alban Berg.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.berg #=> "Wozzeck"
                #
                def berg()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_alban_berg"))));
                end
                ##
                # Produces the title of an opera by Hector Berlioz.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.berlioz #=> "Les Troyens"
                #
                def berlioz()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_hector_berlioz"))));
                end
                ##
                # Produces the title of an opera by Georges Bizet.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.bizet #=> "Carmen"
                #
                def bizet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_georges_bizet"))));
                end
                ##
                # Produces the title of an opera by Gaetano Donizetti.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.donizetti #=> "Lucia di Lammermoor"
                #
                def donizetti()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_gaetano_donizetti"))));
                end
                ##
                # Produces the title of an opera by Christoph Willibald Gluck.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.gluck #=> "Orfeo ed Euridice"
                #
                def gluck()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_christoph_willibald_gluck"))));
                end
                ##
                # Produces the title of a French opera by Christoph Willibald Gluck.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.gluck_fr #=> "Orphee et Euridice"
                #
                def gluck_french()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_christoph_willibald_gluck"))));
                end
                ##
                # Produces the title of an Italian opera by Christoph Willibald Gluck.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.gluck_it #=> "Orfeo ed Euridice"
                #
                def gluck_italian()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_christoph_willibald_gluck"))));
                end
                ##
                # Produces the title of an opera by Charles Gounod.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.gounod #=> "Faust"
                #
                def gounod()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_charles_gounod"))));
                end
                ##
                # Produces the title of an opera by Wolfgang Amadeus Mozart.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.mozart #=> "Die Zauberfloete"
                #
                def mozart()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_wolfgang_amadeus_mozart"))));
                end
                ##
                # Produces the title of a German opera by Wolfgang Amadeus Mozart.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.mozart_ger #=> "Die Zauberfloete"
                #
                def mozart_german()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_wolfgang_amadeus_mozart"))));
                end
                ##
                # Produces the title of an Italian opera by Wolfgang Amadeus Mozart.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.mozart_it #=> "Cosi fan tutte"
                #
                def mozart_italian()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_wolfgang_amadeus_mozart"))));
                end
                ##
                # Produces the title of an opera by Maurice Ravel.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.ravel #=> "L'enfant et les sortileges"
                #
                def ravel()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_maurice_ravel"))));
                end
                ##
                # Produces the title of an opera by Gioacchino Rossini.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.rossini #=> "Il Barbiere di Siviglia"
                #
                def rossini()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_gioacchino_rossini"))));
                end
                ##
                # Produces the title of an opera by Camille Saint-Saens.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.saint_saens #=> "Samson and Delilah"
                #
                def saint_saens()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.french.by_camille_saint_saens"))));
                end
                ##
                # Produces the title of an opera by Franz Schubert.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.schubert #=> "Alfonso und Estrella"
                #
                def schubert()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_franz_schubert"))));
                end
                ##
                # Produces the title of an opera by Robert Schumann.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.schumann #=> "Genoveva"
                #
                def schumann()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_robert_schumann"))));
                end
                ##
                # Produces the title of an opera by Richard Strauss.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.strauss #=> "Elektra"
                #
                def strauss()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_richard_strauss"))));
                end
                ##
                # Produces the title of an opera by Giuseppe Verdi.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.verdi #=> "Il Trovatore"
                #
                def verdi()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.italian.by_giuseppe_verdi"))));
                end
                ##
                # Produces the title of an opera by Richard Wagner.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.wagner #=> "Tristan und Isolde"
                #
                def wagner()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_richard_wagner"))));
                end
                ##
                # Produces the title of an opera by Carl Maria von Weber.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Opera.weber #=> "Der Freischuetz"
                #
                def weber()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("opera.german.by_carl_maria_von_weber"))));
                end
                end
            end
        class PearlJam < Base
            class << self
                ##
                # Produces the name of an album by Pearl Jam.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::PearlJam.album #=> "Ten"
                #
                def album()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("pearl_jam.albums"))));
                end
                ##
                # Produces the name of a member of Pearl Jam (current and former).
                #                                 <p>Produces the name of a member of Pearl Jam (current and former)</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::PearlJam.musician #=> "Eddie Vedder"
                #
                def musician()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("pearl_jam.musicians"))));
                end
                ##
                # Produces the name of a song by Pearl Jam.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::PearlJam.song #=> "Even Flow"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("pearl_jam.songs"))));
                end
                end
            end
        class Phish < Base
            class << self
                ##
                # Produces the name of a album by Phish.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Phish.album #=> "Fuego"
                #
                def album()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phish.albums"))));
                end
                ##
                # Produces the name of a musician in Phish.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Phish.musician #=> "Trey Anastasio"
                #
                def musician()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phish.musicians"))));
                end
                ##
                # Produces the name of a song by Phish.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Phish.song #=> "Tweezer"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phish.songs"))));
                end
                end
            end
        class Prince < Base
            class << self
                ##
                # Produces a random Prince album.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Music::Prince.album #=> "The Gold Experience"
                #                                             Faker::Music::Prince.album #=> "Purple Rain"
                #                                         
                #
                def album()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("prince.album"))));
                end
                ##
                # Produces a random Prince-associated band.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Prince.band #=> "The New Power Generation"
                #
                def band()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("prince.band"))));
                end
                ##
                # Produces a random Prince song lyric.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Music::Prince.lyric #=> "Dearly beloved, we are gathered here today to get through this thing called life."
                #                                             Faker::Music::Prince.lyric #=> "You were so hard to find, the beautiful ones, they hurt you every time."
                #                                         
                #
                def lyric()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("prince.lyric"))));
                end
                ##
                # Produces a random Prince song.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Music::Prince.song #=> "Raspberry Beret"
                #                                             Faker::Music::Prince.song #=> "Starfish And Coffee"
                #                                         
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("prince.song"))));
                end
                end
            end
        class RockBand < Base
            class << self
                ##
                # Produces the name of a rock band.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::RockBand.name #=> "Led Zeppelin"
                #
                def name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rock_band.name"))));
                end
                ##
                # Produces a rock song.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::RockBand.song #=> "Dani California"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rock_band.song"))));
                end
                end
            end
        class Rush < Base
            class << self
                ##
                # Produces the name of an album by Rush.
                #                                 <p>Produces the name of an album by Rush</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Rush.album #=> "Hold Your Fire"
                #
                def album()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rush.albums"))));
                end
                ##
                # Produces the name of a member of Rush.
                #                                 <p>Produces the name of a member of Rush</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::Rush.player #=> "Geddy Lee"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rush.players"))));
                end
                end
            end
        class SmashingPumpkins < Base
            class << self
                ##
                # Produces the name of an album by the Smashing Pumpkins.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::SmashingPumpkins.album #=> "Siamese Dream"
                #
                def album()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("smashing_pumpkins.albums"))));
                end
                ##
                # Produces a random Smashing Pumpkins song lyric.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Music::SmashingPumpkins.lyric #=> "Despite all my rage, I am still just a rat in a cage"
                #                                             Faker::Music::SmashingPumpkins.lyric #=> "Breathin' underwater, and livin' under glass"
                #                                         
                #
                def lyric()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("smashing_pumpkins.lyric"))));
                end
                ##
                # Produces the name of a member of the Smashing Pumpkins (current and former).
                #                                 <p>Produces the name of a member of the Smashing Pumpkins (current and former)</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::SmashingPumpkins.musician #=> "Billy Corgan"
                #
                def musician()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("smashing_pumpkins.musicians"))));
                end
                ##
                # Produces the name of a song by the Smashing Pumpkins.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::SmashingPumpkins.song #=> "Stand Inside My Love"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("smashing_pumpkins.songs"))));
                end
                end
            end
        class UmphreysMcgee < Base
            class << self
                ##
                # Produces the name of a song by Umphrey's McGee.
                #
                # @return [String]
                #
                # @example
                #     Faker::Music::UmphreysMcgee.song #=> "Dump City"
                #
                def song()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("umphreys_mcgee.song"))));
                end
                end
            end
        ##
        # Produces the name of an album.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.album #=> "Sgt. Pepper's Lonely Hearts Club"
        #
        def album()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.albums"))));
        end
        ##
        # Produces the name of a band.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.band #=> "The Beatles"
        #
        def band()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.bands"))));
        end
        ##
        # Produces the name of a chord, using letter notation.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.chord #=> "Adim7"
        #
        def chord()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces an array of types of chords.
        #
        # @return [Array<String><String>]
        #
        def chord_types()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces the name of a musical genre.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.genre #=> "Rock"
        #
        def genre()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.genres"))));
        end
        ##
        # Produces the name of an instrument.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.instrument #=> "Acoustic Guitar"
        #
        def instrument()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.instruments"))));
        end
        ##
        # Produces the name of a key/note, using letter notation.
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.key #=> "A#"
        #
        def key()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces an array of key types (with "major" denoted as an empty string).
        #
        # @return [Array<String>]
        #
        # @example
        #     Faker::Music.key_types #=> ['', 'm']
        #
        def key_types()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces an array of accidentals (with "natural" denoted as an empty string).
        #
        # @return [Array<String>]
        #
        def key_variants()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces an array of the letter names of musical notes, without accidentals.
        #
        # @return [Array<String>]
        #
        def keys()
            #warning No native implmentation for this method - needs porting
            throw new NotSupportedException("Mehtod needs porting to C#");
        end
        ##
        # Produces a name from Lou Bega's Mambo #5.
        #                             <p>Produces a name from Lou Bega’s Mambo #5</p>
        #                         
        #
        # @return [String]
        #
        # @example
        #     Faker::Music.mambo #=> "Monica"
        #
        def mambo_no_5()
            return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("music.mambo_no_5"))));
        end
        end
    class Name < Base
        class << self
            ##
            # Produces a random female first name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.female_first_name #=> "Natasha"
            #
            def female_first_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.female_first_name"))));
            end
            ##
            # Produces a random first name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.first_name #=> "Kaci"
            #
            def first_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.first_name"))));
            end
            ##
            # Produces random initials.
            #
            # @param number [Integer]   
            #   					<p>Number of digits that the generated initials should have.</p>
            #   				 (default value "3")
            #
            # @return [String]
            #
            # @example
            #     
            #     					Faker::Name.initials            #=> "NJM"
            #     					Faker::Name.initials(number: 2) #=> "NM"
            #     				
            #
            def initials(number: 3)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random last name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.last_name #=> "Ernser"
            #
            def last_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.last_name"))));
            end
            ##
            # Produces a random male first name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.male_first_name #=> "Edward"
            #
            def male_first_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.male_first_name"))));
            end
            ##
            # Produces a random name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.name #=> "Tyshawn Johns Sr."
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.name"))));
            end
            ##
            # Produces a random name with middle name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.name_with_middle #=> "Aditya Elton Douglas"
            #
            def name_with_middle()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.name_with_middle"))));
            end
            ##
            # Produces a random gender neutral first name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.neutral_first_name #=> "Casey"
            #
            def neutral_first_name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.neutral_first_name"))));
            end
            ##
            # Produces a random name prefix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.prefix #=> "Mr."
            #
            def prefix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.prefix"))));
            end
            ##
            # Produces a random name suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Name.suffix #=> "IV"
            #
            def suffix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("name.suffix"))));
            end
            end
        end
    class Nation < Base
        class << self
            ##
            # Produces a random capital city.
            #
            # @return [String]
            #
            # @example
            #     Faker::Nation.capital_city #=> "Kathmandu"
            #
            def capital_city()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("nation.capital_city"))));
            end
            ##
            # Produces a random national flag emoji.
            #
            # @return [String]
            #
            # @example
            #     Faker::Nation.flag #=> "🇫🇮"
            #
            def flag()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random national language.
            #
            # @return [String]
            #
            # @example
            #     Faker::Nation.language #=> "Nepali"
            #
            def language()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("nation.language"))));
            end
            ##
            # Produces a random national sport.
            #
            # @return [String]
            #
            # @example
            #     Faker::Nation.national_sport #=> "dandi biyo"
            #
            def national_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("team.sport"))));
            end
            ##
            # Produces a random nationality.
            #
            # @return [String]
            #
            # @example
            #     Faker::Nation.nationality #=> "Nepalese"
            #
            def nationality()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("nation.nationality"))));
            end
            end
        end
    class NationalHealthService < Base
        class << self
            ##
            # Produces a random British NHS number.
            #
            # @return [String]
            #
            # @example
            #     Faker::NationalHealthService.british_number #=> "403 958 5577"
            #
            def british_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random British NHS number's check digit.
            #
            # @param number [Integer]   
            #   <p>Specifies the NHS number the check digit belongs to.</p>
            #    (default value "0")
            #
            # @return [Integer]
            #
            # @example
            #     Faker::NationalHealthService.check_digit(number: 400_012_114) #=> 6
            #
            def check_digit(number: 0)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class NatoPhoneticAlphabet < Base
        class << self
            ##
            # Produces a code word from the NATO phonetic alphabet.
            #
            # @return [String]
            #
            # @example
            #     Faker::NatoPhoneticAlphabet.code_word #=> "Hotel"
            #
            def code_word()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("nato_phonetic_alphabet.code_word"))));
            end
            end
        end
    class Number < Base
        class << self
            ##
            # Produces a number between two provided values.
            #                             <p>Boundaries are inclusive.</p>
            #                         
            #
            # @param from [Numeric]   
            #   <p>The lowest number to include.</p>
            #   
            #
            # @param to [Numeric]   
            #   <p>The highest number to include.</p>
            #    (default value "5000.00")
            #
            # @return [Numeric]
            #
            # @example
            #     
            #                                         Faker::Number.between(from: 1, to: 10) #=> 7
            #                                         Faker::Number.between(from: 0.0, to: 1.0) #=> 0.7844640543957383
            #                                     
            #
            def between(from, to: 5000.00)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a number in binary format.
            #
            # @param digits [Integer]   
            #   <p>Number of digits to generate the binary as string</p>
            #    (default value "4")
            #
            # @return [String]
            #
            # @example
            #     Faker::Number.binary(digits: 4) #=> "1001"
            #
            def binary(digits: 4)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a float.
            #
            # @param l_digits [Integer]   
            #   <p>Number of digits that the generated decimal should have to the left of the decimal point.</p>
            #   
            #
            # @param r_digits [Integer]   
            #   <p>Number of digits that the generated decimal should have to the right of the decimal point.</p>
            #    (default value "2")
            #
            # @return [Float]
            #
            # @example
            #     
            #                                         Faker::Number.decimal(l_digits: 2) #=> 11.88
            #                                         Faker::Number.decimal(l_digits: 3, r_digits: 3) #=> 181.843
            #                                     
            #
            def decimal(l_digits, r_digits: 2)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a number with a number of digits, preserves leading zeroes.
            #
            # @param digits [Integer]   
            #   <p>Number of digits that the generated number should have.</p>
            #    (default value "10")
            #
            # @return [String]
            #
            # @example
            #     Faker::Number.decimal_part(digits: 2) #=> "09"
            #
            def decimal_part(digits: 10)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a single-digit integer.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Number.digit #=> 1
            #
            def digit()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method generate"
            warn  "Failed processing method greater_than_zero"
            ##
            # Produces a number in hexadecimal format.
            #
            # @param digits [Integer]   
            #   <p>Number of digits in the he</p>
            #    (default value "6")
            #
            # @return [String]
            #
            # @example
            #     Faker::Number.hexadecimal(digits: 3) #=> "e74"
            #
            def hexadecimal(digits: 6)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random number with a leading zero.
            #
            # @param digits [Integer]   
            #   <p>Number of digits that the generated number should have.</p>
            #    (default value "10")
            #
            # @return [String]
            #
            # @example
            #     Faker::Number.leading_zero_number(digits: 10) #=> "0669336915"
            #
            def leading_zero_number(digits: 10)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method less_than_zero"
            ##
            # Produces a negative float.
            #
            # @param from [Integer]   
            #   <p>The lower boundary.</p>
            #   
            #
            # @param to [Integer]   
            #   <p>The higher boundary.</p>
            #   
            #
            # @return [Float]
            #
            # @example
            #     Faker::Number.negative #=> -4480.042585669558
            #
            def negative(from, to)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a non-zero single-digit integer.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Number.non_zero_digit #=> 8
            #
            def non_zero_digit()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a float given a mean and standard deviation.
            #
            # @param mean [Integer]#
            # @param standard_deviation [Numeric]    (default value "1")
            #
            # @return [Float]
            #
            # @example
            #     Faker::Number.normal(mean: 50, standard_deviation: 3.5) #=> 47.14669604069156
            #
            def normal(mean, standard_deviation: 1)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random number.
            #
            # @param digits [Integer]   
            #   <p>Number of digits that the generated number should have.</p>
            #    (default value "10")
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Number.number(digits: 10) #=> 1968353479
            #
            def number(digits: 10)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a positive float.
            #
            # @param from [Integer]   
            #   <p>The lower boundary.</p>
            #   
            #
            # @param to [Integer]   
            #   <p>The higher boundary.</p>
            #    (default value "5000.00")
            #
            # @return [Float]
            #
            # @example
            #     Faker::Number.positive #=> 235.59238499107653
            #
            def positive(from, to: 5000.00)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method should_be"
            ##
            # Produces a number within two provided values.
            #                             <p>Boundaries are inclusive or exclusive depending on the range passed.</p>
            #                         
            #
            # @param range [Range]   
            #   <p>The range from which to generate a number.</p>
            #    (default value "1.00..5000.00")
            #
            # @return [Numeric]
            #
            # @example
            #     
            #                                         Faker::Number.within(range: 1..10) #=> 7
            #                                         Faker::Number.within(range: 0.0..1.0) #=> 0.7844640543957383
            #                                     
            #
            def within(range: 1.00..5000.00)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Omniauth < Base
        class << self
            ##
            # Generate a mock Omniauth response from Apple.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #    (default value "nil")
            #
            # @return [Hash]
            #
            def apple(name, email, uid: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generate a mock Omniauth response from Auth0.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #    (default value "nil")
            #
            # @return [Hash]
            #
            def auth0(name, email, uid: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method city_state"
            ##
            # Generate a mock Omniauth response from Facebook.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param username [String]   
            #   <p>A specific username to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #   
            #
            # @return [Hash]
            #
            def facebook(name, email, username, uid)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method gender"
            ##
            # Generate a mock Omniauth response from Github.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #   
            #
            # @return [Hash]
            #
            def github(name, email, uid)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Generate a mock Omniauth response from Google.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #   
            #
            # @return [Hash]
            #
            def google(name, email, uid)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method image"
            ##
            # Generate a mock Omniauth response from LinkedIn.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param email [String]   
            #   <p>A specific email to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #   
            #
            # @return [Hash]
            #
            def linkedin(name, email, uid)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method random_boolean"
            warn  "Failed processing method random_number_from_range"
            warn  "Failed processing method timezone"
            ##
            # Generate a mock Omniauth response from Twitter.
            #
            # @param name [String]   
            #   <p>A specific name to return in the response.</p>
            #   
            #
            # @param nickname [String]   
            #   <p>A specific nickname to return in the response.</p>
            #   
            #
            # @param uid [String]   
            #   <p>A specific UID to return in the response.</p>
            #   
            #
            # @return [Hash]
            #
            def twitter(name, nickname, uid)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method email"
            warn  "Failed processing method first_name"
            # @return [Omniauth]
            #
            def initialize()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method last_name"
            warn  "Failed processing method name"
            end
        end
    class PhoneNumber < Base
        class << self
            ##
            # Produces a random area code.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.area_code #=> "201"
            #                                         Faker::PhoneNumber.area_code #=> "613"
            #                                         Faker::PhoneNumber.area_code #=> "321"
            #                                     
            #
            def area_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phone_number.area_code"))));
            end
            ##
            # Produces a random cell phone number in a random format without the country code and it can have different dividers.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.cell_phone #=> "(836) 115-8995"
            #                                         Faker::PhoneNumber.cell_phone #=> "382-597-5739"
            #                                         Faker::PhoneNumber.cell_phone #=> "316.828.1822"
            #                                     
            #
            def cell_phone()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("cell_phone.formats"))));
            end
            ##
            # Produces a random phone number in e164 format, i.e., without any dividers.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.cell_phone_in_e164 #=> "+542024834991"
            #                                         Faker::PhoneNumber.cell_phone_in_e164 #=> "+8522846847703"
            #                                         Faker::PhoneNumber.cell_phone_in_e164 #=> "+649477546575"
            #                                     
            #
            def cell_phone_in_e164()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random cell phone number with country code.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.cell_phone_with_country_code #=> "+852 (190) 987-9034"
            #                                         Faker::PhoneNumber.cell_phone_with_country_code #=> "+64 (820) 583-6474"
            #                                         Faker::PhoneNumber.cell_phone_with_country_code #=> "+1 591.871.7985"
            #                                     
            #
            def cell_phone_with_country_code()
                return "#{country_code} #{cell_phone}";
            end
            ##
            # Produces a random country code.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.country_code #=> "+20"
            #                                         Faker::PhoneNumber.country_code #=> "+39"
            #                                         Faker::PhoneNumber.country_code #=> "+852"
            #                                     
            #
            def country_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phone_number.country_code"))));
            end
            ##
            # Produces a random exchange code.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.exchange_code #=> "208"
            #                                         Faker::PhoneNumber.exchange_code #=> "415"
            #                                         Faker::PhoneNumber.exchange_code #=> "652"
            #                                     
            #
            def exchange_code()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phone_number.exchange_code"))));
            end
            ##
            # Produces a phone number in a random format without the country code and it can have different dividers.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.phone_number #=> "(504) 113-1705"
            #                                         Faker::PhoneNumber.phone_number #=> "662.291.7201"
            #                                         Faker::PhoneNumber.phone_number #=> "9415283713"
            #                                     
            #
            def phone_number()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("phone_number.formats"))));
            end
            ##
            # Produces a random phone number with country code.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.phone_number_with_country_code #=> "+55 466-746-6882"
            #                                         Faker::PhoneNumber.phone_number_with_country_code #=> "+81 3718219558"
            #                                         Faker::PhoneNumber.phone_number_with_country_code #=> "+49 140 957 9846"
            #                                     
            #
            def phone_number_with_country_code()
                return "#{country_code} #{phone_number}";
            end
            ##
            # Produces a random extension / subscriber number.
            #                             <p>Can be used for both extensions and last four digits of phone number.</p>
            #                         
            #
            # @param length [Integer]   
            #   <p>Specifies the length of the return value. Defaults to 4.</p>
            #    (default value "4")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::PhoneNumber.subscriber_number #=> "3873"
            #                                         Faker::PhoneNumber.subscriber_number(length: 2) #=> "39"
            #                                         Faker::PhoneNumber.extension #=> "3764"
            #                                         Faker::PhoneNumber.extension(length: 2) => "37"
            #                                     
            #
            def subscriber_number(length: 4)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Placeholdit < Base
        class << self
            warn  "Failed processing method generate_color"
            ##
            # Produces a random placeholder image from https://via.placeholder.com.
            #                             <pre><code>Faker::Placeholdit.image #=&gt; &quot;https://via.placeholder.com/300x300.png&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;) #=&gt; &quot;https://via.placeholder.com/50x50.png&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;, format: &#39;jpg&#39;) #=&gt; &quot;https://via.placeholder.com/50x50.jpg&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;, format: &#39;gif&#39;, background_color: &#39;ffffff&#39;) #=&gt; &quot;https://via.placeholder.com/50x50.gif/ffffff&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;, format: &#39;jpeg&#39;, background_color: :random) #=&gt; &quot;https://via.placeholder.com/50x50.jpeg/39eba7&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;, format: &#39;jpeg&#39;, background_color: &#39;ffffff&#39;, text_color: &#39;000&#39;) #=&gt; &quot;https://via.placeholder.com/50x50.jpeg/ffffff/000&quot;
            #                             Faker::Placeholdit.image(size: &#39;50x50&#39;, format: &#39;jpg&#39;, background_color: &#39;ffffff&#39;, text_color: &#39;000&#39;, text: &#39;Some Custom Text&#39;) #=&gt; &quot;https://via.placeholder.com/50x50.jpg/ffffff/000?text=Some Custom Text&quot;
            #                             </code></pre>
            #                         
            #
            # @param size [String]   
            #   <p>Specifies the image’s size, dimensions separated by ‘x’.</p>
            #   
            #
            # @param format [String]   
            #   <p>Specifies the image’s extension.</p>
            #   
            #
            # @param background_color [String]   
            #   <p>Specifies the background color, either in hexadecimal format (without #) or as :random.</p>
            #   
            #
            # @param text_color [String]   
            #   <p>Specifies the text color, either in hexadecimal format (without #) or as :random.</p>
            #   
            #
            # @param text [String]   
            #   <p>Specifies a custom text to be used.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     # Keyword arguments: size, format, background_color, text_color, text
            #
            def image(size, format, background_color, text_color, text: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class ProgrammingLanguage < Base
        class << self
            ##
            # Produces the name of a programming language's creator.
            #
            # @return [String]
            #
            # @example
            #     Faker::ProgrammingLanguage.creator #=> "Yukihiro Matsumoto"
            #
            def creator()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("programming_language.creator"))));
            end
            ##
            # Produces the name of a programming language.
            #
            # @return [String]
            #
            # @example
            #     Faker::ProgrammingLanguage.name #=> "Ruby"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("programming_language.name"))));
            end
            end
        end
    class Quote < Base
        class << self
            ##
            # Produces a famous last words quote.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.famous_last_words #=> "My vocabulary did this to me. Your love will let you go on..."
            #
            def famous_last_words()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.famous_last_words"))));
            end
            ##
            # Produces a quote from a fortune cookie.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.fortune_cookie #=> "This cookie senses that you are superstitious; it is an inclination that is bad for your mental health."
            #
            def fortune_cookie()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.fortune_cookie"))));
            end
            ##
            # Produces a quote from Deep Thoughts by Jack Handey.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.jack_handey # => "I hope life isn't a big joke, because I don't get it."
            #
            def jack_handey()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.jack_handey"))));
            end
            ##
            # Produces a quote from Matz.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.matz #=> "You want to enjoy life, don't you? If you get your job done quickly and your job is fun, that's good isn't it? That's the purpose of life, partly. Your life is better."
            #
            def matz()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.matz"))));
            end
            ##
            # Produces a quote from comedian Mitch Hedberg.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.mitch_hedberg # => "I like Kit-Kats, unless I'm with four or more people."
            #
            def mitch_hedberg()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.mitch_hedberg"))));
            end
            ##
            # Produces a quote about the most interesting man in the world.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.most_interesting_man_in_the_world #=> "He can speak Russian... in French"
            #
            def most_interesting_man_in_the_world()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.most_interesting_man_in_the_world"))));
            end
            ##
            # Produces a Robin quote.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.robin #=> "Holy Razors Edge"
            #
            def robin()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.robin"))));
            end
            ##
            # Produces a singular siegler quote.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.singular_siegler #=> "Texas!"
            #
            def singular_siegler()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.singular_siegler"))));
            end
            ##
            # Produces a quote from Yoda.
            #
            # @return [String]
            #
            # @example
            #     Faker::Quote.yoda #=> "Use your feelings, Obi-Wan, and find him you will."
            #
            def yoda()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("quote.yoda"))));
            end
            end
        end
    class Quotes
        class Chiquito < Base
            class << self
                ##
                # Produces an Expression from Chiquito.
                #                                 <p>Produces an Expression from Chiquito</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Chiquito.expression # => "Ereh un torpedo!"
                #
                def expression()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def expressions()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chiquito.expressions"))));
                end
                ##
                # Produces a joke from Chiquito.
                #                                 <p>Produces a joke from Chiquito</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Quotes::Chiquito.joke # => "- Papar papar llevame al circo!
                #                                             - Noorl! El que quiera verte que venga a la casa"
                #                                         
                #
                def joke()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def jokes()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chiquito.jokes"))));
                end
                ##
                # Produces a sentence from Chiquito.
                #                                 <p>Produces a sentence from Chiquito</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Chiquito.sentence # => "Te llamo trigo por no llamarte Rodrigo"
                #
                def sentence()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def sentences()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chiquito.sentences"))));
                end
                ##
                # Produces a concept from Chiquito.
                #                                 <p>Produces a concept from Chiquito</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Chiquito.term # => "Fistro"
                #
                def term()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                # @return [String]
                #
                def terms()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chiquito.terms"))));
                end
                end
            end
        class Rajnikanth < Base
            class << self
                ##
                # Produces a Rajnikanth.
                #                                 <p>Original list of jokes: <a href="http://www.rajinikanthjokes.com">www.rajinikanthjokes.com</a>/</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::Rajnikanth.joke
                #                                             #=> "Rajinikanth is so fast that he always comes yesterday."
                #                                         
                #
                def joke()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rajnikanth.joke"))));
                end
                end
            end
        class Shakespeare < Base
            class << self
                ##
                # Generates quote from 'As you like it!'.
                #                                 <p>Generates quote from ‘As you like it!’</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.as_you_like_it   #=> "How bitter a thing it is to look into happiness through another man's eyes!"
                #
                def as_you_like_it()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("shakespeare.as_you_like_it"))));
                end
                ##
                # Produces a Shakespeare quote from As You Like It.
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.as_you_like_it_quote # => "Can one desire too much of a good thing?."
                #
                def as_you_like_it_quote()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Generates quote from Hamlet.
                #                                 <p>Generates quote from Hamlet</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.hamlet   #=> "A little more than kin, and less than kind."
                #
                def hamlet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("shakespeare.hamlet"))));
                end
                ##
                # Produces a Shakespeare quote from Hamlet.
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.hamlet_quote # => "To be, or not to be: that is the question."
                #
                def hamlet_quote()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Returns quote from 'King Rechard III'.
                #                                 <p>Returns quote from ‘King Rechard III’</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare  #=> "The king's name is a tower of strength."
                #
                def king_richard_iii()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("shakespeare.king_richard_iii"))));
                end
                ##
                # Produces a Shakespeare quote from King Richard III.
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.king_richard_iii_quote # => "Now is the winter of our discontent."
                #
                def king_richard_iii_quote()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Quote from 'Romeo and Juliet'.
                #                                 <p>Quote from ‘Romeo and Juliet’</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.romeo_and_juliet  #=> "Wisely and slow; they stumble that run fast."
                #
                def romeo_and_juliet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("shakespeare.romeo_and_juliet"))));
                end
                ##
                # Produces a Shakespeare quote from Romeo And Juliet.
                #
                # @return [String]
                #
                # @example
                #     Faker::Quotes::Shakespeare.romeo_and_juliet_quote # => "O Romeo, Romeo! wherefore art thou Romeo?."
                #
                def romeo_and_juliet_quote()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        end
    class Relationship < Base
        class << self
            ##
            # Produces a random family relationship.
            #
            # @return [String]
            #
            # @example
            #     Faker::Relationship.familial #=> "Grandfather"
            #
            def familial()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random in-law relationship.
            #
            # @return [String]
            #
            # @example
            #     Faker::Relationship.in_law #=> "Brother-in-law"
            #
            def in_law()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("relationship.in_law"))));
            end
            ##
            # Produces a random parent relationship.
            #
            # @return [String]
            #
            # @example
            #     Faker::Relationship.parent #=> "Father"
            #
            def parent()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("relationship.parent"))));
            end
            ##
            # Produces a random sibling relationship.
            #
            # @return [String]
            #
            # @example
            #     Faker::Relationship.sibling #=> "Sister"
            #
            def sibling()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("relationship.sibling"))));
            end
            ##
            # Produces a random spouse relationship.
            #
            # @return [String]
            #
            # @example
            #     Faker::Relationship.spouse #=> "Husband"
            #
            def spouse()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("relationship.spouse"))));
            end
            end
        end
    class Restaurant < Base
        class << self
            ##
            # Produces a description of a restaurant.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Restaurant.description
            #                                         #=> "We are committed to using the finest ingredients in our recipes. No food leaves our kitchen that we ourselves would not eat."
            #                                     
            #
            def description()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("restaurant.description"))));
            end
            ##
            # Produces the name of a restaurant.
            #
            # @return [String]
            #
            # @example
            #     Faker::Restaurant.name #=> "Curry King"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("restaurant.name"))));
            end
            ##
            # Produces a review for a restaurant.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Restaurant.review
            #                                         #=> "Brand new. Great design. Odd to hear pop music in a Mexican establishment. Music is a bit loud. It should be background."
            #                                     
            #
            def review()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("restaurant.review"))));
            end
            ##
            # Produces a type of restaurant.
            #
            # @return [String]
            #
            # @example
            #     Faker::Restaurant.type #=> "Comfort Food"
            #
            def type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("restaurant.type"))));
            end
            end
        end
    class Science < Base
        class << self
            ##
            # Produces the name of a element.
            #
            # @return [String]
            #
            # @example
            #     Faker::Science.element #=> "Carbon"
            #
            def element()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.element"))));
            end
            ##
            # Produces the state of an element.
            #
            # @return [String]
            #
            # @example
            #     Faker::Science.element_state #=> "Liquid"
            #
            def element_state()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.element_state"))));
            end
            ##
            # Produces the subcategory of an element.
            #
            # @return [String]
            #
            # @example
            #     Faker::Science.element_subcategory #=> "Reactive nonmetal"
            #
            def element_subcategory()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.element_subcategory"))));
            end
            ##
            # Produces the symbol of an element.
            #
            # @return [String]
            #
            # @example
            #     Faker::Science.element_symbol #=> "Pb"
            #
            def element_symbol()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.element_symbol"))));
            end
            ##
            # Produces a scientifically sounding word.
            #                             <p>Produces a scientifically sounding word</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Science.modifier #=> "Quantum"
            #                                         Faker::Science.modifier #=> "Superconductive"
            #                                     
            #
            def modifier()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.modifier"))));
            end
            ##
            # Produces a name of a science You can optionally filter by specifying one or more of the following: `:empirical, :formal, :natural, :social, :basic, :applied`.
            #                             <p>Produces a name of a science You can optionally filter by specifying one or more of the following: ‘:empirical, :formal, :natural, :social, :basic, :applied`</p>
            #                         
            #
            # @param branches [Array<Symbol>]#
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Science.science #=> "Space science"
            #                                         Faker::Science.science(:natural, :applied) #=> "Engineering"
            #                                         Faker::Science.science(:formal, :applied) #=> "Computer Science"
            #                                     
            #
            def science(branches)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces the name of a scientist.
            #
            # @return [String]
            #
            # @example
            #     Faker::Science.scientist #=> "Isaac Newton"
            #
            def scientist()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.scientist"))));
            end
            ##
            # Produces the name of a scientific tool.
            #                             <p>By default it uses a science word modifier to generate more diverse data, which can be disabled.</p>
            #                         
            #
            # @param simple [Boolean]   
            #   <p>Whether to generate simple realistic tool names, (no Q-word).</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Science.tool #=> "Superconductive Microcentrifuge"
            #                                         Faker::Science.tool #=> "Portable Cryostat"
            #                                         Faker::Science.tool #=> "Quantum Spectrophotometer"
            #                                         Faker::Science.tool(simple: true) #=> "Microcentrifuge"
            #                                     
            #
            def tool(simple: false)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("science.tool"))));
            end
            end
        end
    class Show < Base
        class << self
            ##
            # Produces the name of a musical for an older audience.
            #                             <p>Produces the name of a musical for an older audience</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Alphanumeric.alpha
            #                                         #=> "West Side Story"
            #                                     
            #
            def adult_musical()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("show.adult_musical"))));
            end
            ##
            # Produces the name of a musical for a younger audience.
            #                             <p>Produces the name of a musical for a younger audience</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Alphanumeric.alpha
            #                                         #=> "Into the Woods JR."
            #                                     
            #
            def kids_musical()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("show.kids_musical"))));
            end
            ##
            # Produces the name of a play.
            #                             <p>Produces the name of a play</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Alphanumeric.alpha
            #                                         #=> "Death of a Salesman"
            #                                     
            #
            def play()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("show.play"))));
            end
            end
        end
    class SlackEmoji < Base
        class << self
            ##
            # Produces a random slack emoji from activity category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.activity #=> ":soccer:"
            #
            def activity()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.activity"))));
            end
            ##
            # Produces a random slack emoji from celebration category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.celebration #=> ":tada:"
            #
            def celebration()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.celebration"))));
            end
            ##
            # Produces a random slack emoji from custom category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.custom #=> ":slack:"
            #
            def custom()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.custom"))));
            end
            ##
            # Produces a random slack emoji from any category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.emoji #=> ":pizza:"
            #
            def emoji()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.emoji"))));
            end
            ##
            # Produces a random slack emoji from food and drink category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.food_and_drink #=> ":beers:"
            #
            def food_and_drink()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.food_and_drink"))));
            end
            ##
            # Produces a random slack emoji from nature category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.nature #=> ":mount_fuji:"
            #
            def nature()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.nature"))));
            end
            ##
            # Produces a random slack emoji from objects and symbols category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.objects_and_symbols #=> ":id:"
            #
            def objects_and_symbols()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.objects_and_symbols"))));
            end
            ##
            # Produces a random slack emoji from people category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.people #=> ":sleepy:"
            #
            def people()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.people"))));
            end
            ##
            # Produces a random slack emoji from travel and places category.
            #
            # @return [String]
            #
            # @example
            #     Faker::SlackEmoji.travel_and_places #=> ":metro:"
            #
            def travel_and_places()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("slack_emoji.travel_and_places"))));
            end
            end
        end
    class Source < Base
        class << self
            ##
            # Produces source code for Hello World in a given language.
            #
            # @param lang [Symbol]   
            #   <p>The programming language to use</p>
            #    (default value ":ruby")
            #
            # @return [String]
            #
            # @example
            #     Faker::Source.hello_world #=> "puts 'Hello World!'"
            #
            def hello_world(lang: :ruby)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("source.hello_world.#{lang}"))));
            end
            ##
            # Produces source code for printing a string in a given language.
            #
            # @param str [String]   
            #   <p>The string to print</p>
            #   
            #
            # @param lang [Symbol]   
            #   <p>The programming language to use</p>
            #    (default value ":ruby")
            #
            # @return [String]
            #
            # @example
            #     Faker::Source.print #=> "puts 'faker_string_to_print'"
            #
            def print(str, lang: :ruby)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("source.print.#{lang}"))));
            end
            ##
            # Produces source code for printing 1 through 10 in a given language.
            #
            # @param lang [Symbol]   
            #   <p>The programming language to use</p>
            #    (default value ":ruby")
            #
            # @return [String]
            #
            # @example
            #     Faker::Source.print_1_to_10 #=> "(1..10).each { |i| puts i }"
            #
            def print_1_to_10(lang: :ruby)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("source.print_1_to_10.#{lang}"))));
            end
            end
        end
    class SouthAfrica < Base
        class << self
            ##
            # Produces a South African cell phone number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.cell_phone #=> "082 946 7470"
            #
            def cell_phone()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African close corporation registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.close_corporation_registration_number #=> "CK74/7585/23"
            #
            def close_corporation_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African ID number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.id_number #=> "6110311856083"
            #
            def id_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces an invalid South African ID number.
            #                             <p>Produces an invalid South African ID number</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.invalid_id_number #=> "7018356904081"
            #
            def invalid_id_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African listed company registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.listed_company_registration_number #=> "7039/3135/06"
            #
            def listed_company_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African phone number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.phone_number #=> "010 788 5009"
            #
            def phone_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African private company registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.pty_ltd_registration_number #=> "5301/714689/07"
            #
            def pty_ltd_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African trust registration number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.trust_registration_number #=> "IT38/6489900"
            #
            def trust_registration_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a valid South African ID number.
            #                             <p>Produces a valid South African ID number</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.valid_id_number #=> "6110311856083"
            #
            def valid_id_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a South African VAT number.
            #
            # @return [String]
            #
            # @example
            #     Faker::SouthAfrica.vat_number #=> "ZA79494416181"
            #
            def vat_number()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Space < Base
        class << self
            ##
            # Produces the name of a space agency.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.agency #=> "Japan Aerospace Exploration Agency"
            #
            def agency()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.agency"))));
            end
            ##
            # Produces a space agency abbreviation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.agency_abv #=> "NASA"
            #
            def agency_abv()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.agency_abv"))));
            end
            ##
            # Produces the name of a space company.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.company #=> "SpaceX"
            #
            def company()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.company"))));
            end
            ##
            # Produces the name of a constellation.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.constellation #=> "Orion"
            #
            def constellation()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.constellation"))));
            end
            ##
            # Produces a distance measurement.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.distance_measurement #=> "15 parsecs"
            #
            def distance_measurement()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.distance_measurement"))));
            end
            ##
            # Produces the name of a galaxy.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.galaxy #=> "Andromeda"
            #
            def galaxy()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.galaxy"))));
            end
            ##
            # Produces the name of a launch vehicle.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.launch_vehicle #=> "Saturn IV"
            #
            def launch_vehicle()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.launch_vehicle"))));
            end
            ##
            # Produces the name of a meteorite.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.meteorite #=> "Ensisheim"
            #
            def meteorite()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.meteorite"))));
            end
            ##
            # Produces the name of a moon.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.moon #=> "Europa"
            #
            def moon()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.moon"))));
            end
            ##
            # Produces the name of a NASA spacecraft.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.nasa_space_craft #=> "Endeavour"
            #
            def nasa_space_craft()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.nasa_space_craft"))));
            end
            ##
            # Produces the name of a nebula.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.nebula #=> "Triffid Nebula"
            #
            def nebula()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.nebula"))));
            end
            ##
            # Produces the name of a planet.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.planet #=> "Venus"
            #
            def planet()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.planet"))));
            end
            ##
            # Produces the name of a star.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.star #=> "Proxima Centauri"
            #
            def star()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.star"))));
            end
            ##
            # Produces the name of a star cluster.
            #
            # @return [String]
            #
            # @example
            #     Faker::Space.star_cluster #=> "Messier 70"
            #
            def star_cluster()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("space.star_cluster"))));
            end
            end
        end
    class Sport < Base
        class << self
            ##
            # Produces a sport from the ancient olympics.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.ancient_olympics_sport #=> "Pankration"
            #
            def ancient_olympics_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.ancient_olympics"))));
            end
            ##
            # Produces a sport from the modern olympics or paralympics, summer or winter.
            #
            # @param include_ancient [Boolean]   
            #   <p>If true, may produce a sport from the ancient olympics</p>
            #   
            #
            # @param include_unusual [Boolean]   
            #   <p>If true, may produce an unusual (definitely not olympic) sport</p>
            #    (default value "false")
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.sport #=> "Football"
            #
            def sport(include_ancient, include_unusual: false)
                return fetch("sport.summer_olympics");
            end
            ##
            # Produces a sport from the summer olympics.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.summer_olympics_sport #=> "Archery"
            #
            def summer_olympics_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.summer_olympics"))));
            end
            ##
            # Produces a sport from the summer paralympics.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.summer_paralympics_sport #=> "Wheelchair Basketball"
            #
            def summer_paralympics_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.summer_paralympics"))));
            end
            ##
            # Produces an unusual sport.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.unusual_sport #=> "Camel Jumping"
            #
            def unusual_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.unusual"))));
            end
            ##
            # Produces a sport from the winter olympics.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.winter_olympics_sport #=> "Bobsleigh"
            #
            def winter_olympics_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.winter_olympics"))));
            end
            ##
            # Produces a sport from the winter paralympics.
            #
            # @return [String]
            #
            # @example
            #     Faker::Sport.winter_paralympics_sport #=> "Para Ice Hockey"
            #
            def winter_paralympics_sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("sport.winter_paralympics"))));
            end
            end
        end
    class Sports
        class Basketball < Base
            class << self
                ##
                # Produces the name of a basketball coach.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Basketball.coach #=> "Gregg Popovich"
                #
                def coach()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("basketball.coaches"))));
                end
                ##
                # Produces the name of a basketball player.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Basketball.player #=> "LeBron James"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("basketball.players"))));
                end
                ##
                # Produces a position in basketball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Basketball.position #=> "Point Guard"
                #
                def position()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("basketball.positions"))));
                end
                ##
                # Produces the name of a basketball team.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Basketball.team #=> "Golden State Warriors"
                #
                def team()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("basketball.teams"))));
                end
                end
            end
        class Chess < Base
            class << self
                ##
                # Produces a long (alpha-3) ISO 3166 country code.
                #
                # @return [String]
                #
                # @example
                #     Faker::Chess.federation #=> "COL"
                #
                def federation()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces the name of a chess opening.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Chess.opening #=> "Giuoco Piano"
                #
                def opening()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chess.openings"))));
                end
                ##
                # Produces the name of a chess player name.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Chess.player #=> "Golden State Warriors"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chess.players"))));
                end
                # @return [String]
                #
                def rating()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces a chess title.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Chess.title #=> "GM"
                #
                def title()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chess.titles"))));
                end
                # @return [String]
                #
                def tournament()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("chess.tournaments"))));
                end
                end
            end
        class Football < Base
            class << self
                ##
                # Produces the name of a football coach.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Football.coach #=> "Jose Mourinho"
                #
                def coach()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("football.coaches"))));
                end
                ##
                # Produces a football competition.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Football.competition #=> "FIFA World Cup"
                #
                def competition()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("football.competitions"))));
                end
                ##
                # Produces the name of a football player.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Football.player #=> "Lionel Messi"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("football.players"))));
                end
                ##
                # Produces a position in football.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Football.position #=> "Defensive Midfielder"
                #
                def position()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("football.positions"))));
                end
                ##
                # Produces the name of a football team.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Football.team #=> "Manchester United"
                #
                def team()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("football.teams"))));
                end
                end
            end
        class Mountaineering < Base
            class << self
                ##
                # Produces the name of a Mountaineer.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Mountaineering.mountaineer #=> "Junko Tabei"
                #
                def mountaineer()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("mountaineering.mountaineer"))));
                end
                end
            end
        class Volleyball < Base
            class << self
                ##
                # Produces the name of a volleyball coach.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Volleyball.coach #=> "Russ Rose"
                #
                def coach()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("volleyball.coach"))));
                end
                ##
                # Produces a formation in volleyball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Volleyball.formation #=> "4-2"
                #
                def formation()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("volleyball.formation"))));
                end
                ##
                # Produces the name of a volleyball player.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Volleyball.player #=> "Saeid Marouf"
                #
                def player()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("volleyball.player"))));
                end
                ##
                # Produces a position in volleyball.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Volleyball.position #=> "Middle blocker"
                #
                def position()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("volleyball.position"))));
                end
                ##
                # Produces the name of a volleyball team.
                #
                # @return [String]
                #
                # @example
                #     Faker::Sports::Volleyball.team #=> "Leo Shoes Modena"
                #
                def team()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("volleyball.team"))));
                end
                end
            end
        end
    class Stripe < Base
        class << self
            ##
            # Produces a random ccv number.
            #
            # @param card_type [String]   
            #   <p>Specific valid card type.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Stripe.ccv #=> "123"
            #                                         Faker::Stripe.ccv(card_type: "amex") #=> "1234"
            #                                     
            #
            def ccv(card_type: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random invalid card number.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Stripe.invalid_card #=> "4000000000000002"
            #                                         Faker::Stripe.invalid_card(card_error: "addressZipFail") #=> "4000000000000010"
            #                                     
            #
            def invalid_card()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random month in two digits format.
            #
            # @return [String]
            #
            # @example
            #     Faker::Stripe.month #=> "10"
            #
            def month()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random valid card number.
            #
            # @param card_type [String]   
            #   <p>Specific valid card type.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Stripe.valid_card #=> "4242424242424242"
            #                                         Faker::Stripe.valid_card(card_type: "visa_debit") #=> "4000056655665556"
            #                                     
            #
            def valid_card(card_type: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random valid Stripe token.
            #
            # @param card_type [String]   
            #   <p>Specific valid card type.</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Stripe.valid_token #=> "tok_visa"
            #                                         Faker::Stripe.valid_token(card_type: "mc_debit") #=> "tok_mastercard_debit"
            #                                     
            #
            def valid_token(card_type: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random year that is always in the future.
            #
            # @return [String]
            #
            # @example
            #     Faker::Stripe.year #=> "2018" # This will always be a year in the future
            #
            def year()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Subscription < Base
        class << self
            ##
            # Produces the name of a payment method.
            #
            # @return [String]
            #
            # @example
            #     Faker::Subscription.payment_method #=> "PayPal"
            #
            def payment_method()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("subscription.payment_methods"))));
            end
            ##
            # Produces the name of a payment term.
            #
            # @return [String]
            #
            # @example
            #     Faker::Subscription.payment_term #=> "Monthly"
            #
            def payment_term()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("subscription.payment_terms"))));
            end
            ##
            # Produces the name of a subscription plan.
            #
            # @return [String]
            #
            # @example
            #     Faker::Subscription.plan #=> "Platinum"
            #
            def plan()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("subscription.plans"))));
            end
            ##
            # Produces a subscription status.
            #
            # @return [String]
            #
            # @example
            #     Faker::Subscription.status #=> "Active"
            #
            def status()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("subscription.statuses"))));
            end
            ##
            # Produces the name of a subscription term.
            #
            # @return [String]
            #
            # @example
            #     Faker::Subscription.subscription_term #=> "Annual"
            #
            def subscription_term()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("subscription.subscription_terms"))));
            end
            end
        end
    class Superhero < Base
        class << self
            ##
            # Produces a superhero descriptor.
            #
            # @return [String]
            #
            # @example
            #     Faker::Superhero.descriptor #=> "Bizarro"
            #
            def descriptor()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("superhero.descriptor"))));
            end
            ##
            # Produces a random superhero name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Superhero.name #=> "Magnificent Shatterstar"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("superhero.name"))));
            end
            ##
            # Produces a superpower.
            #
            # @return [String]
            #
            # @example
            #     Faker::Superhero.power #=> "Photokinesis"
            #
            def power()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("superhero.power"))));
            end
            ##
            # Produces a superhero name prefix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Superhero.prefix #=> "the Fated"
            #
            def prefix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("superhero.prefix"))));
            end
            ##
            # Produces a superhero name suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::Superhero.suffix #=> "Captain"
            #
            def suffix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("superhero.suffix"))));
            end
            end
        end
    class Tea < Base
        class << self
            ##
            # Produces a random type of tea.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Tea.type
            #                                         #=> "Green"
            #                                     
            #
            def type()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random variety or blend of tea.
            #
            # @param type [String]   
            #   <p>the type of tea to query for (valid types: ‘Black’, ‘Green’, ‘Oolong’, ‘White’, and ‘Herbal’)</p>
            #    (default value "nil")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Tea.variety
            #                                         #=> "Earl Grey"
            #                                     
            #
            def variety(type: nil)
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("tea.type"))));
            end
            end
        end
    class Team < Base
        class << self
            ##
            # Produces a team creature.
            #
            # @return [String]
            #
            # @example
            #     Faker::Team.creature #=> "geese"
            #
            def creature()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("team.creature"))));
            end
            ##
            # Produces the name of a team mascot.
            #
            # @return [String]
            #
            # @example
            #     Faker::Team.mascot #=> "Hugo"
            #
            def mascot()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("team.mascot"))));
            end
            ##
            # Produces a team name from a state and a creature.
            #
            # @return [String]
            #
            # @example
            #     Faker::Team.name #=> "Oregon vixens"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("team.name"))));
            end
            ##
            # Produces a team sport.
            #
            # @return [String]
            #
            # @example
            #     Faker::Team.sport #=> "Lacrosse"
            #
            def sport()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("team.sport"))));
            end
            ##
            # Produces a team state.
            #
            # @return [String]
            #
            # @example
            #     Faker::Team.state #=> "Oregon"
            #
            def state()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("address.state"))));
            end
            end
        end
    class Time < Base
        class << self
            ##
            # Produce a random time in the past (up to N days).
            #
            # @param days [Integer]   
            #   <p>The maximum number of days to go into the past.</p>
            #   
            #
            # @param period [Symbol]   
            #   <p>The time of day, if any. See {TIME_RANGES}.</p>
            #   
            #
            # @param format [Symbol]   
            #   <p>The name of a DateTime format to use.</p>
            #    (default value "nil")
            #
            # @return [Time]
            #
            # @example
            #     
            #                                         Faker::Time.backward(days: 14, period: :evening)
            #                                         #=> "2014-09-17 19:56:33 -0700"
            #                                         Faker::Time.backward(days: 5, period: :morning, format: :short)
            #                                         #=> "14 Oct 07:44"
            #                                     
            #
            def backward(days, period, format: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random time between two times.
            #
            # @param from [Time]   
            #   <p>The start of the usable time range.</p>
            #   
            #
            # @param to [Time]   
            #   <p>The end of the usable time range.</p>
            #   
            #
            # @param format [Symbol]   
            #   <p>The name of a DateTime format to use.</p>
            #    (default value "nil")
            #
            # @return [Time]
            #
            # @example
            #     
            #                                         # Random Stringified time between two times, formatted to the specified I18n format
            #                                         # (Examples are from a Rails console with rails-i18n 5.1.1 defaults loaded)
            #                                         I18n.locale = 'en-US'
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :default) #=> "Tue, 16 Oct 2018 10:48:27 AM -05:00"
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :short) #=> "15 Oct 10:48 AM"
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :long) #=> "October 15, 2018 10:48 AM"
            #     
            #                                         I18n.locale = 'ja'
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :default) #=> "2018/10/15 10:48:27"
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :short) #=> "18/10/15 10:48"
            #                                         Faker::Time.between(from: DateTime.now - 1, to: DateTime.now, format: :long) #=> "2018年10月16日(火) 10時48分27秒 -0500"
            #                                     
            #
            def between(from, to, format: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produce a random time between two dates.
            #
            # @param from [Date]   
            #   <p>The start of the usable time range.</p>
            #   
            #
            # @param to [Date]   
            #   <p>The end of the usable time range.</p>
            #   
            #
            # @param period [Symbol]   
            #   <p>The time of day, if any. See {TIME_RANGES}.</p>
            #   
            #
            # @param format [Symbol]   
            #   <p>The name of a DateTime format to use.</p>
            #    (default value "nil")
            #
            # @return [Time]
            #
            # @example
            #     
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :all)
            #                                         #=> "2014-09-19 07:03:30 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :day)
            #                                         #=> "2014-09-18 16:28:13 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :night)
            #                                         #=> "2014-09-20 19:39:38 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :morning)
            #                                         #=> "2014-09-19 08:07:52 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :afternoon)
            #                                         #=> "2014-09-18 12:10:34 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :evening)
            #                                         #=> "2014-09-19 20:21:03 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 1, to: Date.today, period: :midnight)
            #                                         #=> "2014-09-20 00:40:14 -0700"
            #                                         Faker::Time.between_dates(from: Date.today - 5, to: Date.today + 5, period: :afternoon, format: :default)
            #                                         #=> "Fri, 19 Oct 2018 15:17:46 -0500"
            #                                     
            #
            def between_dates(from, to, period, format: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method date_with_random_time"
            ##
            # Produce a random time in the future (up to N days).
            #
            # @param days [Integer]   
            #   <p>The maximum number of days to go into the future.</p>
            #   
            #
            # @param period [Symbol]   
            #   <p>The time of day, if any. See {TIME_RANGES}.</p>
            #   
            #
            # @param format [Symbol]   
            #   <p>The name of a DateTime format to use.</p>
            #    (default value "nil")
            #
            # @return [Time]
            #
            # @example
            #     
            #                                         Faker::Time.forward(days: 23, period: :morning)
            #                                         # => "2014-09-26 06:54:47 -0700"
            #                                         Faker::Time.forward(days: 5,  period: :evening, format: :long)
            #                                         #=> "October 21, 2018 20:47"
            #                                     
            #
            def forward(days, period, format: nil)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method get_time_object"
            warn  "Failed processing method hours"
            warn  "Failed processing method minutes"
            warn  "Failed processing method seconds"
            warn  "Failed processing method time_with_format"
            end
        end
    class Travel
        class Airport < Base
            class << self
                ##
                # Produces random Airport by IATA code and takes arguments for size and region.
                #                                 <p>Produces random Airport by IATA code and takes arguments for size and region</p>
                # 
                #                                 <p>Faker::Travel::Airport.iata(size: ‘large’, region: ‘united_states’) =&gt; “LAX”</p>
                #                             
                #
                # @param size [String]   
                #   <p>airport size, united_states has large, or medium, or small, european_union has large, or medium</p>
                #   
                #
                # @param region [String]   
                #   <p>airport region, currently available -&gt; united_states or european_union</p>
                #   
                #
                # @return [String]
                #
                def iata(size, region)
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("airport.#{region}.iata_code.#{size}"))));
                end
                ##
                # Produces random Airport by name and takes arguments for size and region.
                #                                 <p>Produces random Airport by name and takes arguments for size and region</p>
                # 
                #                                 <p>Faker::Travel::Airport.name(size: ‘large’, region: ‘united_states’) =&gt; “Los Angeles International Airport”</p>
                #                             
                #
                # @param size [String]   
                #   <p>airport size, united_states has large, or medium, or small, european_union has large, or medium</p>
                #   
                #
                # @param region [String]   
                #   <p>airport region, currently available -&gt; united_states or european_union</p>
                #   
                #
                # @return [String]
                #
                def name(size, region)
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("airport.#{region}.#{size}"))));
                end
                end
            end
        class TrainStation < Base
            class << self
                # @return [String]
                #
                def fill_missing_inputs_with_samples()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                ##
                # Produces random Train Station by name and takes optional arguments for region and type.
                #                                 <p>Produces random Train Station by name and takes optional arguments for region and type</p>
                # 
                #                                 <p>Faker::Travel::TrainStation.name(region: ‘united_kingdom’, type: ‘metro’) =&gt; “Brockley” Faker::Travel::TrainStation.name(type: ‘railway’) =&gt; “Düsseldorf Hauptbahnhof” Faker::Travel::TrainStation.name(region: ‘spain’) =&gt; “Santa Eulàlia”</p>
                #                             
                #
                # @param region [String]   
                #   <p>Train station region: germany, spain, united_kingdom, united_states</p>
                #   
                #
                # @param type [String]   
                #   <p>Train station type: metro, railway</p>
                #    (default value "nil")
                #
                # @return [String]
                #
                def name(region, type: nil)
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("train_station.#{region}.#{type}"))));
                end
                # @return [String]
                #
                def validate_arguments()
                    #warning No native implmentation for this method - needs porting
                    throw new NotSupportedException("Mehtod needs porting to C#");
                end
                end
            end
        end
    class TvShows
        class AquaTeenHungerForce < Base
            class << self
                ##
                # Produces a character from Aqua Teen Hunger Force.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::AquaTeenHungerForce.character #=> "Master Shake"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("aqua_teen_hunger_force.character"))));
                end
                ##
                # Produces a perl of great ATHF wisdom.
                #                                 <p>Produces a perl of great ATHF wisdom</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::AquaTeenHungerForce.quote #=> "Friendship ain't about trust. Friendship's about nunchucks."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("aqua_teen_hunger_force.quote"))));
                end
                end
            end
        class Archer < Base
            class << self
                ##
                # Produces a character from Archer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Archer.character #=> "Sterling Archer"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("archer.characters"))));
                end
                ##
                # Produces a location from Archer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Archer.location #=> "The Tuntmore Towers"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("archer.locations"))));
                end
                ##
                # Produces a quote from Archer.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Archer.quote
                #                                             #=> "You're not my supervisor!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("archer.quotes"))));
                end
                end
            end
        class BigBangTheory < Base
            class << self
                ##
                # Produces a character from Big Bang Theory.
                #                                 <p>Produces a character from Big Bang Theory</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BigBangTheory.character #=> "Sheldon Cooper"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("big_bang_theory.characters"))));
                end
                ##
                # Produces a quote from Bing Bang Theory.
                #                                 <p>Produces a quote from Bing Bang Theory</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BigBangTheory.quote #=> "I'm not crazy. My mother had me tested."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("big_bang_theory.quotes"))));
                end
                end
            end
        class BojackHorseman < Base
            class << self
                ##
                # Produces a character from BoJack Horseman.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BojackHorseman.character #=> "BoJack Horseman"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bojack_horseman.characters"))));
                end
                ##
                # Produces a quote from BoJack Horseman.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::BojackHorseman.quote
                #                                             #=> "Not understanding that you're a horrible person doesn't make you less of a horrible person."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bojack_horseman.quotes"))));
                end
                ##
                # Produces a tongue twister from BoJack Horseman.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BojackHorseman.tongue_twister #=> "Did you steal a meal from Neal McBeal the Navy Seal?"
                #
                def tongue_twister()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bojack_horseman.tongue_twisters"))));
                end
                end
            end
        class BreakingBad < Base
            class << self
                ##
                # Produces the name of a character from Breaking Bad.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BreakingBad.character #=> "Walter White"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("breaking_bad.character"))));
                end
                ##
                # Produces the name of an episode from Breaking Bad.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BreakingBad.episode #=> "Fly"
                #
                def episode()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("breaking_bad.episode"))));
                end
                end
            end
        class BrooklynNineNine < Base
            class << self
                ##
                # Produces a character from Brooklyn Nine Nine.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::BrooklynNineNine.character #=> "Jake Peralta"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("brooklyn_nine_nine.characters"))));
                end
                ##
                # Produces a quote from Brooklyn Nine Nine.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::BrooklynNineNine.quote
                #                                             #=> "Cool, cool, cool, cool, cool. No doubt, no doubt, no doubt."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("brooklyn_nine_nine.quotes"))));
                end
                end
            end
        class Buffy < Base
            class << self
                ##
                # Produces a actor from Buffy the Vampire Slayer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Buffy.actor #=> "John Ritter"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("buffy.actors"))));
                end
                ##
                # Produces a big bad from Buffy the Vampire Slayer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Buffy.big_bad #=> "Glory"
                #
                def big_bad()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("buffy.big_bads"))));
                end
                ##
                # Produces a character from Buffy the Vampire Slayer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Buffy.character #=> "Buffy Summers"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("buffy.characters"))));
                end
                ##
                # Produces an episode from Buffy the Vampire Slayer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Buffy.episode #=> "Once More, with Feeling"
                #
                def episode()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("buffy.episodes"))));
                end
                ##
                # Produces a quote from Buffy the Vampire Slayer.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Buffy.quote #=> "If the apocalypse comes, beep me."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("buffy.quotes"))));
                end
                end
            end
        class Community < Base
            class << self
                ##
                # Produces a character from Community.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Community.characters #=> "Jeff Winger"
                #
                def characters()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("community.characters"))));
                end
                ##
                # Produces a quote from Community.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Community.quotes
                #                                             #=> "I fear a political career could shine a negative light on my drug dealing."
                #                                         
                #
                def quotes()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("community.quotes"))));
                end
                end
            end
        class DrWho < Base
            class << self
                ##
                # Produces an actor from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.actor #=> "Matt Smith"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.actors"))));
                end
                ##
                # Produces a catch phrase from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.catch_phrase #=> "Fantastic!"
                #
                def catch_phrase()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.catch_phrases"))));
                end
                ##
                # Produces a character from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.character #=> "Captain Jack Harkness"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.character"))));
                end
                ##
                # Produces a quote from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.quote #=> "Lots of planets have a north!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.quotes"))));
                end
                ##
                # Produces a species from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.specie #=> "Dalek"
                #
                def specie()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.species"))));
                end
                ##
                # Produces an iteration of The Doctor from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.the_doctor #=> "Ninth Doctor"
                #
                def the_doctor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.the_doctors"))));
                end
                ##
                # Produces a villain from Doctor Who.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DrWho.villain #=> "The Master"
                #
                def villain()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dr_who.villains"))));
                end
                end
            end
        class DumbAndDumber < Base
            class << self
                ##
                # Produces an actor from Dumb and Dumber.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DumbAndDumber.actor #=> "Jim Carrey"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dumb_and_dumber.actors"))));
                end
                ##
                # Produces a character from Dumb and Dumber.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::DumbAndDumber.character #=> "Harry Dunne"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dumb_and_dumber.characters"))));
                end
                ##
                # Produces a quote from Dumb and Dumber.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::DumbAndDumber.quote
                #                                             #=> "Why you going to the airport? Flying somewhere?"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("dumb_and_dumber.quotes"))));
                end
                end
            end
        class FamilyGuy < Base
            class << self
                ##
                # Produces a character from Family Guy.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::FamilyGuy.character #=> "Peter Griffin"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("family_guy.character"))));
                end
                ##
                # Produces a location from Family Guy.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::FamilyGuy.location #=> "James Woods High"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("family_guy.location"))));
                end
                ##
                # Produces a quote from Family Guy.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::FamilyGuy.quote
                #                                             #=> "It's Peanut Butter Jelly Time."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("family_guy.quote"))));
                end
                end
            end
        class FinalSpace < Base
            class << self
                ##
                # Produces a character from Final Space.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::FinalSpace.character #=> "Gary Goodspeed"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("final_space.characters"))));
                end
                ##
                # Produces a quote from Final Space.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::FinalSpace.quote
                #                                             #=> "It's an alien on my face! It's an alien on my...It's a space alien!"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("final_space.quotes"))));
                end
                ##
                # Produces a vehicle from Final Space.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::FinalSpace.vehicle #=> "Imperium Cruiser"
                #
                def vehicle()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("final_space.vehicles"))));
                end
                end
            end
        class Friends < Base
            class << self
                ##
                # Produces a character from Friends.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Friends.character #=> "Rachel Green"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("friends.characters"))));
                end
                ##
                # Produces a location from Friends.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Friends.location #=> "Central Perk"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("friends.locations"))));
                end
                ##
                # Produces a quote from Friends.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Friends.quote #=> "We were on a break!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("friends.quotes"))));
                end
                end
            end
        class Futurama < Base
            class << self
                ##
                # Produces a character from Futurama.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Futurama.character #=> "Amy Wong"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("futurama.characters"))));
                end
                ##
                # Produces a catchphrase from Hermes Conrad.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Futurama.hermes_catchphrase
                #                                             #=> "Great foo of bar!"
                #                                         
                #
                def hermes_catchphrase()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("futurama.hermes_catchphrases"))));
                end
                ##
                # Produces a location from Futurama.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Futurama.location #=> "Wormulon"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("futurama.locations"))));
                end
                ##
                # Produces a quote from Futurama.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Futurama.quote
                #                                             #=> "Ugh, it's like a party in my mouth & everyone's throwing up."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("futurama.quotes"))));
                end
                end
            end
        class GameOfThrones < Base
            class << self
                ##
                # Produces a character from Game of Thrones.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::GameOfThrones.character #=> "Tyrion Lannister"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game_of_thrones.characters"))));
                end
                ##
                # Produces a city from Game of Thrones.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::GameOfThrones.city #=> "Lannisport"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game_of_thrones.cities"))));
                end
                ##
                # Produces a dragon from Game of Thrones.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::GameOfThrones.dragon #=> "Drogon"
                #
                def dragon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game_of_thrones.dragons"))));
                end
                ##
                # Produces a house from Game of Thrones.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::GameOfThrones.house #=> "Stark"
                #
                def house()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game_of_thrones.houses"))));
                end
                ##
                # Produces a quote from Game of Thrones.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::GameOfThrones.quote
                #                                             #=> "Never forget who you are. The rest of the world won't. Wear it like an armor and it can never be used against you."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("game_of_thrones.quotes"))));
                end
                end
            end
        class HeyArnold < Base
            class << self
                ##
                # Produces a character from Hey Arnold!.
                #                                 <p>Produces a character from Hey Arnold!</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HeyArnold.character #=> "Arnold"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hey_arnold.characters"))));
                end
                ##
                # Produces a location from Hey Arnold!.
                #                                 <p>Produces a location from Hey Arnold!</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HeyArnold.location #=> "Big Bob's Beeper Emporium"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hey_arnold.locations"))));
                end
                ##
                # Produces a quote from Hey Arnold!.
                #                                 <p>Produces a quote from Hey Arnold!</p>
                #                             
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HeyArnold.quote #=> "Stoop Kid's afraid to leave his stoop!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("hey_arnold.quotes"))));
                end
                end
            end
        class HowIMetYourMother < Base
            class << self
                ##
                # Produces a catch phrase from How I Met Your Mother.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HowIMetYourMother.catch_phrase #=> "Legendary"
                #
                def catch_phrase()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_i_met_your_mother.catch_phrase"))));
                end
                ##
                # Produces a character from How I Met Your Mother.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HowIMetYourMother.character #=> "Barney Stinson"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_i_met_your_mother.character"))));
                end
                ##
                # Produces a high five from How I Met Your Mother.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::HowIMetYourMother.high_five #=> "Relapse Five"
                #
                def high_five()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_i_met_your_mother.high_five"))));
                end
                ##
                # Produces a quote from How I Met Your Mother.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::HowIMetYourMother.quote
                #                                             #=> "Whenever I'm sad, I stop being sad and be awesome instead."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("how_i_met_your_mother.quote"))));
                end
                end
            end
        class MichaelScott < Base
            class << self
                ##
                # Produces a quote from Michael Scott.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::MichaelScott.quote
                #                                             #=> "I am Beyoncé, always."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("michael_scott.quotes"))));
                end
                end
            end
        class NewGirl < Base
            class << self
                ##
                # Produces a character from New Girl.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::NewGirl.character #=> "Jessica Day"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("new_girl.characters"))));
                end
                ##
                # Produces a quote from New Girl.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::NewGirl.quote
                #                                             #=> "Are you cooking a frittata in a sauce pan? What is this - prison?"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("new_girl.quotes"))));
                end
                end
            end
        class ParksAndRec < Base
            class << self
                ##
                # Produces a character from Parks and Recreation.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::ParksAndRec.character #=> "Leslie Knope"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("parks_and_rec.characters"))));
                end
                ##
                # Produces a city from Parks and Recreation.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::ParksAndRec.city #=> "Pawnee"
                #
                def city()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("parks_and_rec.cities"))));
                end
                end
            end
        class RickAndMorty < Base
            class << self
                ##
                # Produces a character from Rick and Morty.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::RickAndMorty.character #=> "Rick Sanchez"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rick_and_morty.characters"))));
                end
                ##
                # Produces a location from Rick and Morty.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::RickAndMorty.location #=> "Dimension C-132"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rick_and_morty.locations"))));
                end
                ##
                # Produces a quote from Rick and Morty.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::RickAndMorty.quote
                #                                             #=> "Ohh yea, you gotta get schwifty."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rick_and_morty.quotes"))));
                end
                end
            end
        class RuPaul < Base
            class << self
                ##
                # Produces a queen from RuPaul's Drag Race.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::RuPaul.queen #=> "Latrice Royale"
                #
                def queen()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rupaul.queens"))));
                end
                ##
                # Produces a quote from RuPaul's Drag Race.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::RuPaul.quote #=> "That's Funny, Tell Another One."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("rupaul.quotes"))));
                end
                end
            end
        class Seinfeld < Base
            class << self
                ##
                # Produces a business from Seinfeld.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Seinfeld.business #=> "Kruger Industrial Smoothing"
                #
                def business()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("seinfeld.business"))));
                end
                ##
                # Produces a character from Seinfeld.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Seinfeld.character #=> "George Costanza"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("seinfeld.character"))));
                end
                ##
                # Produces a quote from Seinfeld.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Seinfeld.quote
                #                                             #=> "I'm not a lesbian. I hate men, but I'm not a lesbian."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("seinfeld.quote"))));
                end
                end
            end
        class SiliconValley < Base
            class << self
                ##
                # Produces an app from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SiliconValley.app #=> "Nip Alert"
                #
                def app()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.apps"))));
                end
                ##
                # Produces a character from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SiliconValley.character #=> "Jian Yang"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.characters"))));
                end
                ##
                # Produces a company from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SiliconValley.company #=> "Bachmanity"
                #
                def company()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.companies"))));
                end
                ##
                # Produces an email address from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SiliconValley.email #=> "richard@piedpiper.test"
                #
                def email()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.email"))));
                end
                ##
                # Produces an invention from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::SiliconValley.invention
                #                                             #=> "Tres Comas Tequila"
                #                                         
                #
                def invention()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.inventions"))));
                end
                ##
                # Produces a motto from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::SiliconValley.motto
                #                                             #=> "Our products are products, producing unrivaled results"
                #                                         
                #
                def motto()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.mottos"))));
                end
                ##
                # Produces a quote from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::SiliconValley.quote
                #                                             #=> "I don't want to live in a world where someone else is making the world a better place better than we are."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.quotes"))));
                end
                ##
                # Produces a URL from Silicon Valley.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SiliconValley.url #=> "http://www.piedpiper.com"
                #
                def url()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("silicon_valley.urls"))));
                end
                end
            end
        class Simpsons < Base
            class << self
                ##
                # Produces a character from The Simpsons.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Simpsons.character #=> "Charles Montgomery Burns"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("simpsons.characters"))));
                end
                ##
                # Produces an episode title from The Simpsons.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Simpsons.episode_title
                #                                             #=> "Two Cars in Every Garage and Three Eyes on Every Fish"
                #                                         
                #
                def episode_title()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("simpsons.episode_titles"))));
                end
                ##
                # Produces a location from The Simpsons.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Simpsons.location #=> "Moe's Tavern"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("simpsons.locations"))));
                end
                ##
                # Produces a quote from The Simpsons.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Simpsons.quote
                #                                             #=> "It takes two to lie: one to lie and one to listen."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("simpsons.quotes"))));
                end
                end
            end
        class SouthPark < Base
            class << self
                ##
                # Produces a character from South Park.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::SouthPark.character #=> "Mr. Garrison"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("south_park.characters"))));
                end
                ##
                # Produces an episode name from South Park.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::SouthPark.episode_name
                #                                             #=> "Make Love, Not Warcraft"
                #                                         
                #
                def episode_name()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("south_park.episodes"))));
                end
                ##
                # Produces a quote from South Park.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::SouthPark.quote
                #                                             #=> "I'm just getting a little cancer Stan."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("south_park.quotes"))));
                end
                end
            end
        class Spongebob < Base
            class << self
                ##
                # Produces a character from Spongebob.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Spongebob.character #=> "Patrick"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("spongebob.characters"))));
                end
                ##
                # Produces an episode from Spongebob.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Spongebob.episode #=> "Reef Blower"
                #
                def episode()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("spongebob.episodes"))));
                end
                ##
                # Produces a quote from Spongebob.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Spongebob.quote #=> "I'm ready! I'm ready!"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("spongebob.quotes"))));
                end
                end
            end
        class StarTrek < Base
            class << self
                ##
                # Produces a character from Star Trek.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::StarTrek.character #=> "Spock"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("star_trek.character"))));
                end
                ##
                # Produces a location from Star Trek.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::StarTrek.location #=> "Cardassia"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("star_trek.location"))));
                end
                ##
                # Produces a species from Star Trek.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::StarTrek.specie #=> "Ferengi"
                #
                def specie()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("star_trek.specie"))));
                end
                ##
                # Produces a villain from Star Trek.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::StarTrek.villain #=> "Khan Noonien Singh"
                #
                def villain()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("star_trek.villain"))));
                end
                end
            end
        class Stargate < Base
            class << self
                ##
                # Produces a character from Stargate.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Stargate.character #=> "Jack O'Neill"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("stargate.characters"))));
                end
                ##
                # Produces a planet from Stargate.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Stargate.planet #=> "Abydos"
                #
                def planet()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("stargate.planets"))));
                end
                ##
                # Produces a quote from Stargate.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::Stargate.quote
                #                                             #=> "General, request permission to beat the crap out of this man."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("stargate.quotes"))));
                end
                end
            end
        class StrangerThings < Base
            class << self
                ##
                # Produces a quote from Stranger Things.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::StrangerThings.quote
                #                                             #=> "Friends don't lie."
                #                                         
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("stranger_things.character"))));
                end
                ##
                # Produces a character from Stranger Things.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::StrangerThings.character #=> "six"
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("stranger_things.quote"))));
                end
                end
            end
        class Suits < Base
            class << self
                ##
                # Produces a character from Suits.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Suits.character #=> "Harvey Specter"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("suits.characters"))));
                end
                ##
                # Produces a quote from Suits.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Suits.quote #=> "Don't play the odds, play the man."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("suits.quotes"))));
                end
                end
            end
        class Supernatural < Base
            class << self
                ##
                # Produces the name of a character from Supernatural.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Supernatural.character #=> "Dean Winchester"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("supernatural.character"))));
                end
                ##
                # Produces the name of a hunted creature.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Supernatural.creature #=> "Demon"
                #
                def creature()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("supernatural.creature"))));
                end
                ##
                # Produces the name of a weapon used by the hunters.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::Supernatural.weapon #=> "Colt"
                #
                def weapon()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("supernatural.weapon"))));
                end
                end
            end
        class TheExpanse < Base
            class << self
                ##
                # Produces a character from The Expanse.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheExpanse.character #=> "Jim Holden"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_expanse.characters"))));
                end
                ##
                # Produces a location from The Expanse.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheExpanse.location #=> "Ganymede"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_expanse.locations"))));
                end
                ##
                # Produces a quote from The Expanse.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheExpanse.quote #=> "I am that guy."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_expanse.quotes"))));
                end
                ##
                # Produces a ship from The Expanse.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheExpanse.ship #=> "Nauvoo"
                #
                def ship()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_expanse.ships"))));
                end
                end
            end
        class TheFreshPrinceOfBelAir < Base
            class << self
                ##
                # Produces a actor from The Fresh Prince of Bel-Air.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheFreshPrinceOfBelAir.actor #=> "Quincy Jones"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_fresh_prince_of_bel_air.actors"))));
                end
                ##
                # Produces a character from The Fresh Prince of Bel-Air.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheFreshPrinceOfBelAir.character #=> "Will Smith"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_fresh_prince_of_bel_air.characters"))));
                end
                ##
                # Produces a quote from The Fresh Prince of Bel-Air.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::TheFreshPrinceOfBelAir.quote
                #                                             #=> "Girl, you look so good, I would marry your brother just to get in your family."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_fresh_prince_of_bel_air.quotes"))));
                end
                end
            end
        class TheITCrowd < Base
            class << self
                ##
                # Produces an actor from The IT Crowd.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheITCrowd.actor #=> "Chris O'Dowd"
                #
                def actor()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_it_crowd.actors"))));
                end
                ##
                # Produces a character from The IT Crowd.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheITCrowd.character #=> "Roy Trenneman"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_it_crowd.characters"))));
                end
                ##
                # Produces an email from The IT Crowd.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheITCrowd.email #=> "roy.trenneman@reynholm.test"
                #
                def email()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_it_crowd.emails"))));
                end
                ##
                # Produces a quote from The IT Crowd.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::TheITCrowd.quote
                #                                             #=> "Hello, IT. Have you tried turning it off and on again?"
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_it_crowd.quotes"))));
                end
                end
            end
        class TheOffice < Base
            class << self
                ##
                # Produces a character from The Office.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheOffice.character #=> "Michael Scott"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_office.characters"))));
                end
                ##
                # Produces a quote from The Office.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheOffice.quote #=> "Identity theft is not a joke, Jim! Millions of families suffer every year."
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_office.quotes"))));
                end
                end
            end
        class TheThickOfIt < Base
            class << self
                ##
                # Produces a character from The Thick of It.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheThickOfIt.character #=> "Nicola Murray"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_thick_of_it.characters"))));
                end
                ##
                # Produces a department from The Thick of It.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TheThickOfIt.department #=> "Shadow Cabinet"
                #
                def department()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_thick_of_it.departments"))));
                end
                ##
                # Produces a position from The Thick of It.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::TheThickOfIt.position
                #                                             #=> "Director of Communications"
                #                                         
                #
                def position()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("the_thick_of_it.positions"))));
                end
                end
            end
        class TwinPeaks < Base
            class << self
                ##
                # Produces a character from Twin Peaks.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TwinPeaks.character #=> "Dale Cooper"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("twin_peaks.characters"))));
                end
                ##
                # Produces a location from Twin Peaks.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::TwinPeaks.location #=> "Black Lodge"
                #
                def location()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("twin_peaks.locations"))));
                end
                ##
                # Produces a quote from Twin Peaks.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::TwinPeaks.quote
                #                                             #=> "The owls are not what they seem."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("twin_peaks.quotes"))));
                end
                end
            end
        class VentureBros < Base
            class << self
                ##
                # Produces a character from The Venture Bros.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::VentureBros.character #=> "Scaramantula"
                #
                def character()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("venture_bros.character"))));
                end
                ##
                # Produces an organization from The Venture Bros.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::VentureBros.organization
                #                                             #=> "Guild of Calamitous Intent"
                #                                         
                #
                def organization()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("venture_bros.organization"))));
                end
                ##
                # Produces a quote from The Venture Bros.
                #
                # @return [String]
                #
                # @example
                #     
                #                                             Faker::TvShows::VentureBros.quote
                #                                             #=> "Revenge, like gazpacho soup, is best served cold, precise, and merciless."
                #                                         
                #
                def quote()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("venture_bros.quote"))));
                end
                ##
                # Produces a vehicle from The Venture Bros.
                #
                # @return [String]
                #
                # @example
                #     Faker::TvShows::VentureBros.vehicle #=> "Monarchmobile"
                #
                def vehicle()
                    return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("venture_bros.vehicle"))));
                end
                end
            end
        end
    class Twitter < Base
        class << self
            warn  "Failed processing method created_at"
            warn  "Failed processing method id"
            warn  "Failed processing method photo_entity"
            ##
            # Produces a random screen name.
            #
            # @return [String]
            #
            # @example
            #     Faker::Twitter.screen_name #=> "audreanne_hackett"
            #
            def screen_name()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random Twitter user.
            #
            # @param include_user [Boolean]   
            #   <p>Include or exclude user details</p>
            #   
            #
            # @param include_photo [Boolean]   
            #   <p>Include or exclude user photo</p>
            #    (default value "false")
            #
            # @return [Hash]
            #
            # @example
            #     
            #                                         Faker::Twitter.status #=> {:id=>8821452687517076614, :text=>"Ea et laboriosam vel non."...
            #                                         Faker::Twitter.status(include_user: false) # Just get a status object with no embed user
            #                                         Faker::Twitter.status(include_photo: true) # Includes entities for an attached image
            #                                     
            #
            def status(include_user, include_photo: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method status_entities"
            ##
            # Produces a random Twitter user.
            #
            # @param include_status [Boolean]   
            #   <p>Include or exclude user status details</p>
            #   
            #
            # @param include_email [Boolean]   
            #   <p>Include or exclude user email details</p>
            #    (default value "false")
            #
            # @return [Hash]
            #
            # @example
            #     
            #                                         Faker::Twitter.user #=>  {:id=>8821452687517076614, :name=>"Lincoln Paucek", :screen_name=>"cody"...
            #                                         Faker::Twitter.user(include_status: false) # Just get a user object with no embed status
            #                                         Faker::Twitter.user(include_email: true) # Simulate an authenticated user with the email permission
            #                                     
            #
            def user(include_status, include_email: false)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method user_entities"
            warn  "Failed processing method utc_offset"
            end
        end
    class Types < Base
        class << self
            ##
            # Produces a random character from the a-z, 0-9 ranges.
            #
            # @return [String]
            #
            # @example
            #     Faker::Types.character #=> "n"
            #
            def character()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random complex hash with random keys and values where the values may include other hashes and arrays.
            #
            # @param number [Integer]   
            #   <p>Specifies the number of key-value pairs.</p>
            #    (default value "1")
            #
            # @return [Hash]
            #
            # @example
            #     
            #                                         Faker::Types.complex_rb_hash #=> {user: {first: "bob", last: "marley"}}
            #                                         Faker::Types.complex_rb_hash(number: 1) #=> {user: {first: "bob", last: "marley"}}
            #                                         Faker::Types.complex_rb_hash(number: 2) #=> {user: {first: "bob", last: "marley"}, son: ["damien", "marley"]}
            #                                     
            #
            def complex_rb_hash(number: 1)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random complex type that's either a String, an Integer, an array or a hash.
            #
            # @return [String]
            #
            # @example
            #     Faker::Types.random_complex_type #=> 1 or "a" or "bob" or {foo: "bar"}
            #
            def random_complex_type()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random type that's either a String or an Integer.
            #
            # @return [String]
            #
            # @example
            #     Faker::Types.random_type #=> 1 or "a" or "bob"
            #
            def random_type()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random array.
            #
            # @param len [Integer]   
            #   <p>Specifies the number of elements in the array.</p>
            #   
            #
            # @return [Array]
            #
            # @example
            #     
            #                                         Faker::Types.rb_array #=> ["a"]
            #                                         Faker::Types.rb_array(len: 4) #=> ["a", 1, 2, "bob"]
            #                                         Faker::Types.rb_array(len: 2, type: -> { Faker::Types.rb_string }) #=> ["cat", "foo"]
            #                                     
            #
            def rb_array(len)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random hash with random keys and values.
            #
            # @param number [Integer]   
            #   <p>Specifies the number of key-value pairs.</p>
            #   
            #
            # @return [Hash]
            #
            # @example
            #     
            #                                         Faker::Types.rb_hash #=> {name: "bob"}
            #                                         Faker::Types.rb_hash(number: 1) #=> {name: "bob"}
            #                                         Faker::Types.rb_hash(number: 2) #=> {name: "bob", last: "marley"}
            #                                     
            #
            def rb_hash(number)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random integer.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Types.rb_integer #=> 1
            #
            def rb_integer()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random String created from word (Faker::Lorem.word).
            #                             <p>Produces a random String created from word (Faker::Lorem.word)</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Types.rb_string #=> "foobar"
            #
            def rb_string()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            warn  "Failed processing method titleize"
            end
        end
    class University < Base
        class << self
            ##
            # Produces a greek alphabet.
            #
            # @return [Array<String>]
            #
            # @example
            #     Faker::University.greek_alphabet #=> ["Α", "B", "Γ", "Δ", ...]
            #
            def greek_alphabet()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random greek organization.
            #
            # @return [String]
            #
            # @example
            #     Faker::University.greek_organization #=> "BEX"
            #
            def greek_organization()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random university name.
            #
            # @return [String]
            #
            # @example
            #     Faker::University.name #=> "Eastern Mississippi Academy"
            #
            def name()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("university.name"))));
            end
            ##
            # Produces a random university prefix.
            #
            # @return [String]
            #
            # @example
            #     Faker::University.prefix #=> "Western"
            #
            def prefix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("university.prefix"))));
            end
            ##
            # Produces a random university suffix.
            #
            # @return [String]
            #
            # @example
            #     Faker::University.suffix #=> "Academy"
            #
            def suffix()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("university.suffix"))));
            end
            end
        end
    class Vehicle < Base
        class << self
            ##
            # Produces a random list of car options.
            #
            # @return [Array<String>]
            #
            # @example
            #     Faker::Vehicle.car_options #=> ["DVD System", "MP3 (Single Disc)", "Tow Package", "CD (Multi Disc)", "Cassette Player", "Bucket Seats", "Cassette Player", "Leather Interior", "AM/FM Stereo", "Third Row Seats"]
            #
            def car_options()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.car_options"))));
            end
            ##
            # Produces a random car type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.car_type #=> "Sedan"
            #
            def car_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.car_types"))));
            end
            ##
            # Produces a random vehicle color.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.color #=> "Red"
            #
            def color()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.colors"))));
            end
            ##
            # Produces a random vehicle door count.
            #
            # @return [Integer]
            #
            # @example
            #     
            #                                         Faker::Vehicle.doors #=> 1
            #                                         Faker::Vehicle.door_count #=> 3
            #                                     
            #
            def doors()
                return fetch("vehicle.doors");
            end
            ##
            # Produces a random vehicle drive type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.drive_type #=> "4x2/2-wheel drive"
            #
            def drive_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.drive_types"))));
            end
            ##
            # Produces a random engine cylinder count.
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Vehicle.engine_size #=> 6
            #                                         Faker::Vehicle.engine #=> 4
            #                                     
            #
            def engine()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.cylinder_engine"))));
            end
            ##
            # Produces a random vehicle fuel type.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.fuel_type #=> "Diesel"
            #
            def fuel_type()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.fuel_types"))));
            end
            ##
            # Produces a random license plate number.
            #
            # @param state_abbreviation [String]   
            #   <p>Two letter state abbreviation for license plate generation.</p>
            #    (default value "''")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Vehicle.license_plate #=> "DEP-2483"
            #                                         Faker::Vehicle.license_plate(state_abbreviation: 'FL') #=> "977 UNU"
            #                                     
            #
            def license_plate(state_abbreviation: '')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.license_plate"))));
            end
            ##
            # Produces a random vehicle make.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.make #=> "Honda"
            #
            def make()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.makes"))));
            end
            ##
            # Produces a random vehicle make and model.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.make_and_model #=> "Dodge Charger"
            #
            def make_and_model()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random vehicle manufacturer.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.manufacture #=> "Lamborghini"
            #
            def manufacture()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.manufacture"))));
            end
            ##
            # Produces a random mileage/kilometrage for a vehicle.
            #
            # @param min [Integer]   
            #   <p>Specific minimum limit for mileage generation.</p>
            #   
            #
            # @param max [Integer]   
            #   <p>Specific maximum limit for mileage generation.</p>
            #    (default value "MILEAGE_MAX")
            #
            # @return [Integer]
            #
            # @example
            #     
            #                                         Faker::Vehicle.mileage #=> 26961
            #                                         Faker::Vehicle.mileage(min: 50_000) #=> 81557
            #                                         Faker::Vehicle.mileage(min: 50_000, max: 250_000) #=> 117503
            #                                         Faker::Vehicle.kilometrage #=> 35378
            #                                     
            #
            def mileage(min, max: MILEAGE_MAX)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random vehicle model.
            #
            # @param make_of_model [String]   
            #   <p>Specific valid vehicle make.</p>
            #    (default value "''")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::Vehicle.model #=> "A8"
            #                                         Faker::Vehicle.model(make_of_model: 'Toyota') #=> "Prius"
            #                                     
            #
            def model(make_of_model: '')
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.models_by_make.#{make}"))));
            end
            warn  "Failed processing method singapore_checksum"
            ##
            # Produces a random license plate number for Singapore.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.singapore_license_plate #=> "SLV1854M"
            #
            def singapore_license_plate()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random list of standard specs.
            #
            # @return [Array<String>]
            #
            # @example
            #     Faker::Vehicle.standard_specs #=> ["Full-size spare tire w/aluminum alloy wheel", "Back-up camera", "Carpeted cargo area", "Silver accent IP trim finisher -inc: silver shifter finisher", "Back-up camera", "Water-repellent windshield & front door glass", "Floor carpeting"]
            #
            def standard_specs()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.standard_specs"))));
            end
            ##
            # Produces a random vehicle style.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.style #=> "ESi"
            #
            def style()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.styles"))));
            end
            ##
            # Produces a random vehicle transmission.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.transmission #=> "Automanual"
            #
            def transmission()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.transmissions"))));
            end
            ##
            # Produces a car version.
            #                             <p>Produces a car version</p>
            #                         
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.version #=> "40 TFSI Premium"
            #
            def version()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("vehicle.version"))));
            end
            ##
            # Produces a random vehicle VIN number.
            #
            # @return [String]
            #
            # @example
            #     Faker::Vehicle.vin #=> "LLDWXZLG77VK2LUUF"
            #
            def vin()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            ##
            # Produces a random car year between 1 and 15 years ago.
            #
            # @return [Integer]
            #
            # @example
            #     Faker::Vehicle.year #=> 2008
            #
            def year()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Verb < Base
        class << self
            ##
            # Produces the base form of a random verb.
            #
            # @return [String]
            #
            # @example
            #     Faker::Verb.base #=> "hurt"
            #
            def base()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("verbs.base"))));
            end
            ##
            # Produces a random verb in the .ing form.
            #
            # @return [String]
            #
            # @example
            #     Faker::Verb.ing_form #=> "causing"
            #
            def ing_form()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("verbs.ing_form"))));
            end
            ##
            # Produces a random verb in past tense.
            #
            # @return [String]
            #
            # @example
            #     Faker::Verb.past #=> "completed"
            #
            def past()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("verbs.past"))));
            end
            ##
            # Produces a random verb in past participle.
            #
            # @return [String]
            #
            # @example
            #     Faker::Verb.past_participle #=> "digested"
            #
            def past_participle()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("verbs.past_participle"))));
            end
            ##
            # Produces a random verb in simple present.
            #
            # @return [String]
            #
            # @example
            #     Faker::Verb.simple_present #=> "climbs"
            #
            def simple_present()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("verbs.simple_present"))));
            end
            end
        end
    class VulnerabilityIdentifier < Base
        class << self
            ##
            # Produces a Common Vulnerabilities and Exposures (CVE) identifier.
            #
            # @param year [Integer]   
            #   <p>The year-part of the CVE identifier (defaults to the current year)</p>
            #    (default value "::Date.today.year")
            #
            # @return [String]
            #
            # @example
            #     
            #                                         Faker::VulnerabilityIdentifier.cve #=> "CVE-2021-1337"
            #                                         Faker::VulnerabilityIdentifier.cve(year: 1999) #=> "CVE-1999-0523"
            #                                     
            #
            def cve(year: ::Date.today.year)
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class WorldCup < Base
        class << self
            ##
            # Produces a city name hosting the World Cup match.
            #
            # @return [String]
            #
            # @example
            #     Faker::WorldCup.city #=> "Moscow"
            #
            def city()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("world_cup.cities"))));
            end
            ##
            # Produces a random national team name from a group.
            #
            # @return [String]
            #
            # @example
            #     Faker::WorldCup.group(group: 'group_B') #=> "Spain"
            #
            def group()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("world_cup.groups.#{group}"))));
            end
            ##
            # Produces a random name from national team roster.
            #
            # @return [String]
            #
            # @example
            #     Faker::WorldCup.roster #=> "Hector Cuper"
            #
            def roster()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("world_cup.rosters.#{country}.#{type}"))));
            end
            ##
            # Produces the name of a stadium that has hosted a World Cup match.
            #
            # @return [String]
            #
            # @example
            #     Faker::WorldCup.stadium #=> "Rostov Arena"
            #
            def stadium()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("world_cup.stadiums"))));
            end
            ##
            # Produces a national team name.
            #
            # @return [String]
            #
            # @example
            #     Faker::WorldCup.team #=> "Iran"
            #
            def team()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("world_cup.teams"))));
            end
            end
        end
    class String < Base
        class << self
            warn  "No implementation defined for method length(text);"
            warn  "No implementation defined for method lower(text);"
            # @return [String]
            #
            def random()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            # @return [String]
            #
            def select_a()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            # @return [String]
            #
            def utf8string()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            # @return [String]
            #
            def space_or_utf8_char()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            # @return [String]
            #
            def char_space_ratio()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            # @return [String]
            #
            def utf8character()
                #warning No native implmentation for this method - needs porting
                throw new NotSupportedException("Mehtod needs porting to C#");
            end
            end
        end
    class Bible < Base
        class << self
            # @return [String]
            #
            def character()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bible.character"))));
            end
            # @return [String]
            #
            def location()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bible.location"))));
            end
            # @return [String]
            #
            def quote()
                return _faker.Translate(_faker.Numerify(_faker.Letterify(fetch("bible.quote"))));
            end
            end
        end
end
