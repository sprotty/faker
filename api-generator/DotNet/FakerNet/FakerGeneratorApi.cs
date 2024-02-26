    
    
    
    
 
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace FakerNet
{
	public class AddressGenerator
	{
		private Faker _faker;
	
		internal AddressGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a building number.</Summary>
		/// <Example>
		/// <code>Faker::Address.building_number #=&gt; "7304"</code>
		/// </Example>
		[FakerMethod("building_number")]
		public string BuildingNumber()
		{
			return _faker.Resolve("address.building_number", this); // Fetch
		}
		
		/// <Summary>Produces the name of a city.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Address.city #=&gt; "Imogeneborough"
		/// </code>
		/// </Example>
		[FakerMethod("city")]
		public string City()
		{
			return _faker.Resolve("address.city", this); // Parse
		}
		
		/// <Summary>Produces the name of a city with the state.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Address.city_with_state #=&gt; "Northfort, California"
		/// </code>
		/// </Example>
		[FakerMethod("city_with_state")]
		public string CityWithState()
		{
			return _faker.Resolve("address.city", this); // Parse
		}
		
		/// <Summary>Produces a city prefix.</Summary>
		/// <Example>
		/// <code>Faker::Address.city_prefix #=&gt; "Lake"</code>
		/// </Example>
		[FakerMethod("city_prefix")]
		public string CityPrefix()
		{
			return _faker.Resolve("address.city_prefix", this); // Fetch
		}
		
		/// <Summary>Produces a city suffix.</Summary>
		/// <Example>
		/// <code>Faker::Address.city_suffix #=&gt; "fort"</code>
		/// </Example>
		[FakerMethod("city_suffix")]
		public string CitySuffix()
		{
			return _faker.Resolve("address.city_suffix", this); // Fetch
		}
		
		/// <Summary>Produces the name of a community.</Summary>
		/// <Example>
		/// <code>Faker::Address.community #=&gt; "University Crossing"</code>
		/// </Example>
		[FakerMethod("community")]
		public string Community()
		{
			return _faker.Resolve("address.community", this); // Parse
		}
		
		/// <Summary>Produces the name of a country.</Summary>
		/// <Example>
		/// <code>Faker::Address.country #=&gt; "French Guiana"</code>
		/// </Example>
		[FakerMethod("country")]
		public string Country()
		{
			return _faker.Translate(_faker.Resolve("address.country", this)); // Fetch
		}
		
		/// <Summary>
		/// Produces a country by ISO country code.
		/// &lt;p&gt;See the [List of ISO 3166 country codes](&lt;a href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes"&gt;en.wikipedia.org/wiki/List_of_ISO_3166_country_codes&lt;/a&gt;) on Wikipedia for a full list.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Address.country_by_code(code: 'NL') #=&gt; "Netherlands"</code>
		/// </Example>
		/// <param name="code">An ISO country code.</param>
		[FakerMethod("country_by_code")]
		public string CountryByCode(string code = "US")
		{
			return _faker.Resolve("address.country_by_code." + code + "", this); // Fetch
		}
		
		/// <Summary>Produces an ISO 3166 country code.</Summary>
		/// <Example>
		/// <code>Faker::Address.country_code #=&gt; "IT"</code>
		/// </Example>
		[FakerMethod("country_code")]
		public string CountryCode()
		{
			return _faker.Resolve("address.country_code", this); // Fetch
		}
		
		/// <Summary>Produces a long (alpha-3) ISO 3166 country code.</Summary>
		/// <Example>
		/// <code>Faker::Address.country_code_long #=&gt; "ITA"</code>
		/// </Example>
		[FakerMethod("country_code_long")]
		public string CountryCodeLong()
		{
			return _faker.Resolve("address.country_code_long", this); // Fetch
		}
		
		/// <Summary>Produces an ISO 3166 country code when given a country name.</Summary>
		/// <Example>
		/// <code>Faker::Address.country_name_to_code(name: 'united_states') #=&gt; "US"</code>
		/// </Example>
		/// <param name="name">
		/// 					<p>Country name in snake_case format.</p>
		/// 				</param>
		[FakerMethod("country_name_to_code")]
		public string CountryNameToCode(string name = "united_states")
		{
			return _faker.Resolve("address.country_by_name.#{String.lower '" + name + "'}", this); // Fetch
		}
		
		/// <Summary>Produces a latitude.</Summary>
		/// <Example>
		/// <code>Faker::Address.latitude #=&gt; -58.17256227443719</code>
		/// </Example>
		[FakerMethod("latitude")]
		public double Latitude()
		{
			return double.Parse(_faker.Expression("#{random_float '-180..180'}", this)); // Expression
		}
		
		/// <Summary>Produces a longitude.</Summary>
		/// <Example>
		/// <code>Faker::Address.longitude #=&gt; -156.65548382095133</code>
		/// </Example>
		[FakerMethod("longitude")]
		public double Longitude()
		{
			return double.Parse(_faker.Expression("#{random_float '-180..180'}", this)); // Expression
		}
		
		/// <Summary>Produces a mail box number.</Summary>
		/// <Example>
		/// <code>Faker::Address.mail_box #=&gt; "PO Box 123"</code>
		/// </Example>
		[FakerMethod("mail_box")]
		public string MailBox()
		{
			return _faker.Numerify(_faker.Letterify(_faker.Resolve("address.mail_box", this))); // Fetch
		}
		
		/// <Summary>Produces a secondary address.</Summary>
		/// <Example>
		/// <code>Faker::Address.secondary_address #=&gt; "Apt. 672"</code>
		/// </Example>
		[FakerMethod("secondary_address")]
		public string SecondaryAddress()
		{
			return _faker.Resolve("address.secondary_address", this); // Fetch
		}
		
		/// <Summary>Produces the name of a state.</Summary>
		/// <Example>
		/// <code>Faker::Address.state #=&gt; "California"</code>
		/// </Example>
		[FakerMethod("state")]
		public string State()
		{
			return _faker.Resolve("address.state", this); // Fetch
		}
		
		/// <Summary>Produces a state abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Address.state_abbr #=&gt; "AP"</code>
		/// </Example>
		[FakerMethod("state_abbr")]
		public string StateAbbr()
		{
			return _faker.Resolve("address.state_abbr", this); // Fetch
		}
		
		/// <Summary>Produces a street address.</Summary>
		/// <Example>
		/// <code>Faker::Address.street_address #=&gt; "282 Kevin Brook"</code>
		/// </Example>
		/// <param name="includeSecondary">Whether or not to include the secondary address.</param>
		[FakerMethod("street_address")]
		public string StreetAddress(bool includeSecondary = false)
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("address.street_address", this)))); // Parse
		}
		
		/// <Summary>Produces a street name.</Summary>
		/// <Example>
		/// <code>Faker::Address.street_name #=&gt; "Larkin Fork"</code>
		/// </Example>
		[FakerMethod("street_name")]
		public string StreetName()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("address.street_name", this)))); // Parse
		}
		
		/// <Summary>Produces a street suffix.</Summary>
		/// <Example>
		/// <code>Faker::Address.street_suffix #=&gt; "Street"</code>
		/// </Example>
		[FakerMethod("street_suffix")]
		public string StreetSuffix()
		{
			return _faker.Resolve("address.street_suffix", this); // Fetch
		}
		
		/// <Summary>Produces the name of a time zone.</Summary>
		/// <Example>
		/// <code>Faker::Address.time_zone #=&gt; "Asia/Yakutsk"</code>
		/// </Example>
		[FakerMethod("time_zone")]
		public string TimeZone()
		{
			return _faker.Resolve("address.time_zone", this); // Fetch
		}
		
		/// <Summary>Produces a Zip Code/Postocde.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Address.zip_code #=&gt; "58517"
		/// Faker::Address.zip_code #=&gt; "23285-4905"
		/// <!--Faker::Address.zip_code(state_abbreviation: 'CO') #=&gt; "80011"--></code>
		/// </Example>
		[FakerMethod("zip_code")]
		public string ZipCode()
		{
			return _faker.Numerify(_faker.Letterify(_faker.Resolve("address.postcode", this))); // Fetch
		}
		
		/// <Summary>Produces a postcode/zipcode.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Address.zip_code #=&gt; "58517"
		/// </code>
		/// </Example>
		[FakerMethod("postcode")]
		public string Postcode()
		{
			return _faker.Numerify(_faker.Letterify(_faker.Resolve("address.postcode", this))); // Fetch
		}
		
	}
	public class AdjectiveGenerator
	{
		private Faker _faker;
	
		internal AdjectiveGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a negative adjective.</Summary>
		/// <Example>
		/// <code>Faker::Adjective.negative #=&gt; "Creepy"</code>
		/// </Example>
		[FakerMethod("negative")]
		public string Negative()
		{
			return _faker.Translate(_faker.Resolve("adjective.negative", this)); // Fetch
		}
		
		/// <Summary>Produces a positive adjective.</Summary>
		/// <Example>
		/// <code>Faker::Adjective.positive #=&gt; "Kind"</code>
		/// </Example>
		[FakerMethod("positive")]
		public string Positive()
		{
			return _faker.Translate(_faker.Resolve("adjective.positive", this)); // Fetch
		}
		
	}
	public class AlphanumericGenerator
	{
		private Faker _faker;
	
		internal AlphanumericGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a random string of alphabetic characters (no digits).
		/// &lt;p&gt;Produces a random string of alphabetic characters (no digits)&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Alphanumeric.alpha(number: 10) #=&gt; "zlvubkrwga"</code>
		/// </Example>
		/// <param name="number">
		/// 					<p>The length of the string to generate</p>
		/// 				</param>
		[FakerMethod("alpha")]
		public string Alpha(long number = 32)
		{
			/*
			
						(number: 32)
						char_count = resolve(number)
						return '' if char_count.to_i < 1
		
						Array.new(char_count) { sample(self::LLetters) }.join
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>
		/// Produces a random string of alphanumeric characters.
		/// &lt;p&gt;Produces a random string of alphanumeric characters&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Alphanumeric.alphanumeric(number: 10) #=&gt; "3yfq2phxtb"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Alphanumeric.alphanumeric(number: 10, min_alpha: 3) #=&gt; "3yfq2phxtb"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Alphanumeric.alphanumeric(number: 10, min_alpha: 3, min_numeric: 3) #=&gt; "3yfq2phx8b"</code>
		/// </Example>
		/// <param name="minNumeric">
		/// 					<p>The minimum number of numbers to add to the string</p>
		/// 				</param>
		[FakerMethod("alpha_numeric")]
		public string AlphaNumeric(long minNumeric = 0)
		{
			/*
			
						(number: 32, min_alpha: 0, min_numeric: 0)
						char_count = resolve(number)
						return '' if char_count.to_i < 1
						raise ArgumentError, 'min_alpha must be greater than or equal to 0' if min_alpha&.negative?
						raise ArgumentError, 'min_numeric must be greater than or equal to 0' if min_numeric&.negative?
		
						return Array.new(char_count) { sample(ALPHANUMS) }.join if min_alpha.zero? && min_numeric.zero?
		
						raise ArgumentError, 'min_alpha + min_numeric must be <= number' if min_alpha + min_numeric > char_count
		
						random_count = char_count - min_alpha - min_numeric
		
						alphas = Array.new(min_alpha) { sample(self::LLetters) }
						numbers = Array.new(min_numeric) { sample(self::Numbers) }
						randoms = Array.new(random_count) { sample(ALPHANUMS) }
		
						combined = alphas + numbers + randoms
						combined.shuffle.join
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class AncientGenerator
	{
		private Faker _faker;
	
		internal AncientGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a god from ancient mythology.</Summary>
		/// <Example>
		/// <code>Faker::Ancient.god #=&gt; "Zeus"</code>
		/// </Example>
		[FakerMethod("god")]
		public string God()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("ancient.god", this)))); // Fetch
		}
		
		/// <Summary>Produces a hero from ancient mythology.</Summary>
		/// <Example>
		/// <code>Faker::Ancient.hero #=&gt; "Achilles"</code>
		/// </Example>
		[FakerMethod("hero")]
		public string Hero()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("ancient.hero", this)))); // Fetch
		}
		
		/// <Summary>Produces a primordial from ancient mythology.</Summary>
		/// <Example>
		/// <code>Faker::Ancient.primordial #=&gt; "Gaia"</code>
		/// </Example>
		[FakerMethod("primordial")]
		public string Primordial()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("ancient.primordial", this)))); // Fetch
		}
		
		/// <Summary>Produces a titan from ancient mythology.</Summary>
		/// <Example>
		/// <code>Faker::Ancient.titan #=&gt; "Atlas"</code>
		/// </Example>
		[FakerMethod("titan")]
		public string Titan()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("ancient.titan", this)))); // Fetch
		}
		
	}
	public class AppGenerator
	{
		private Faker _faker;
	
		internal AppGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of an app's author.</Summary>
		/// <Example>
		/// <code>Faker::App.author #=&gt; "Daphne Swift"</code>
		/// </Example>
		[FakerMethod("author")]
		public string Author()
		{
			return _faker.Numerify(_faker.Letterify(_faker.Resolve("app.author", this))); // Parse
		}
		
		/// <Summary>Produces an app name.</Summary>
		/// <Example>
		/// <code>Faker::App.name #=&gt; "Treeflex"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Numerify(_faker.Letterify(_faker.Resolve("app.name", this))); // Fetch
		}
		
		/// <Summary>Produces a String representing a semantic version identifier.</Summary>
		/// <Example>
		/// <code>Faker::App.semantic_version #=&gt; "3.2.5"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::App.semantic_version(major: 42) #=&gt; "42.5.2"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::App.semantic_version(minor: 100..101) #=&gt; "42.100.4"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::App.semantic_version(patch: 5..6) #=&gt; "7.2.6"</code>
		/// </Example>
		/// <param name="major">
		/// 					<p>An integer to use or a range to pick the integer from.</p>
		/// 				</param>
		
		/// <param name="minor">
		/// 					<p>An integer to use or a range to pick the integer from.</p>
		/// 				</param>
		
		/// <param name="patch">
		/// 					<p>An integer to use or a range to pick the integer from.</p>
		/// 				</param>
		[FakerMethod("semantic_version")]
		public string SemanticVersion(IntegerRange? major = null, IntegerRange? minor = null, IntegerRange? patch = null)
		{
		    major ??= IntegerRange.Parse("1..9");
		    minor ??= IntegerRange.Parse("1..9");
		    patch ??= IntegerRange.Parse("1..9");	/*
			
						(major: 0..9, minor: 0..9, patch: 1..9)
						[major, minor, patch].map { |chunk| sample(Array(chunk)) }.join('.')
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a version string.</Summary>
		/// <Example>
		/// <code>Faker::App.version #=&gt; "1.85"</code>
		/// </Example>
		[FakerMethod("version")]
		public string Version()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("app.version", this)))); // Parse
		}
		
	}
	public class ApplianceGenerator
	{
		private Faker _faker;
	
		internal ApplianceGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of an appliance brand.</Summary>
		/// <Example>
		/// <code>Faker::Appliance.brand #=&gt; "Bosch"</code>
		/// </Example>
		[FakerMethod("brand")]
		public string Brand()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("appliance.brand", this)))); // Fetch
		}
		
		/// <Summary>Produces the name of a type of appliance equipment.</Summary>
		/// <Example>
		/// <code>Faker::Appliance.equipment #=&gt; "Appliance plug"</code>
		/// </Example>
		[FakerMethod("equipment")]
		public string Equipment()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("appliance.equipment", this)))); // Fetch
		}
		
	}
	public class ArtistGenerator
	{
		private Faker _faker;
	
		internal ArtistGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of an artist.</Summary>
		/// <Example>
		/// <code>Faker::Artist.name #=&gt; "Michelangelo"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("artist.names", this)))); // Fetch
		}
		
	}
	public class AustraliaGenerator
	{
		private Faker _faker;
	
		internal AustraliaGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces an Australian animal.
		/// &lt;p&gt;Produces an Australian animal&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Australia.animal
		/// #=&gt; "Dingo"
		/// </code>
		/// </Example>
		[FakerMethod("animal")]
		public string Animal()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("australia.animals", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces a location in Australia.
		/// &lt;p&gt;Produces a location in Australia&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Australia.location
		/// #=&gt; "Sydney"
		/// </code>
		/// </Example>
		[FakerMethod("location")]
		public string Location()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("australia.locations", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces an Australian State or Territory.
		/// &lt;p&gt;Produces an Australian State or Territory&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Australia.state
		/// #=&gt; "New South Wales"
		/// </code>
		/// </Example>
		[FakerMethod("state")]
		public string State()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("australia.states", this)))); // Fetch
		}
		
	}
	public class AvatarGenerator
	{
		private Faker _faker;
	
		internal AvatarGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a URL for an avatar from robohash.org.
		/// &lt;p&gt;Produces a URL for an avatar from robohash.org&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image
		/// #=&gt; "https://robohash.org/sitsequiquia.png?size=300x300&amp;set=set1"
		/// </code>
		/// </Example>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image(slug: "my-own-slug")
		/// #=&gt; "https://robohash.org/my-own-slug.png?size=300x300&amp;set=set1"
		/// </code>
		/// </Example>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image(slug: "my-own-slug", size: "50x50")
		/// #=&gt; "https://robohash.org/my-own-slug.png?size=50x50&amp;set=set1"
		/// </code>
		/// </Example>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "jpg")
		/// #=&gt; "https://robohash.org/my-own-slug.jpg?size=50x50&amp;set=set1"
		/// </code>
		/// </Example>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp")
		/// #=&gt; "https://robohash.org/my-own-slug.bmp?size=50x50&amp;set=set1"
		/// </code>
		/// </Example>
		/// <Example>
		/// <code>
		/// Faker::Avatar.image(slug: "my-own-slug", size: "50x50", format: "bmp", set: "set1", bgset: "bg1")
		/// #=&gt; "https://robohash.org/my-own-slug.bmp?size=50x50&amp;set=set1&amp;bgset=bg1"
		/// </code>
		/// </Example>
		/// <param name="bgset">
		/// 					<p>The background set to use</p>
		/// 				</param>
		[FakerMethod("image")]
		public string Image(string? bgset = null)
		{
			/*
			
						(slug: nil, size: '300x300', format: 'png', set: 'set1', bgset: nil)
						raise ArgumentError, 'Size should be specified in format 300x300' unless size =~ /^[0-9]+x[0-9]+$/
						raise ArgumentError, "Supported formats are #{SUPPORTED_FORMATS.join(', ')}" unless SUPPORTED_FORMATS.include?(format)
		
						slug ||= Faker::Lorem.words.join
						bgset_query = "&bgset=#{bgset}" if bgset
						"https://robohash.org/#{slug}.#{format}?size=#{size}&set=#{set}#{bgset_query}"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class BankGenerator
	{
		private Faker _faker;
	
		internal BankGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a bank account number.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Bank.account_number #=&gt; 6738582379
		/// Faker::Bank.account_number(digits: 13) #=&gt; 673858237902
		/// </code>
		/// </Example>
		/// <param name="digits">
		/// 					<p>Number of digits that the generated account number should have.</p>
		/// 				</param>
		[FakerMethod("account_number")]
		public string AccountNumber(long digits = 10)
		{
			/*
			
						(digits: 10)
						output = ''
		
						output += rand.to_s[2..] while output.length < digits
		
						output[0...digits]
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>
		/// Produces an Australian BSB (Bank-State-Branch) number.
		/// &lt;p&gt;Produces an Australian BSB (Bank-State-Branch) number&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Bank.bsb_number
		/// #=&gt; "036616"
		/// </code>
		/// </Example>
		[FakerMethod("bsb_number")]
		public string BsbNumber()
		{
			/*
			
						compile_bsb_number
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Bank method checksum
		#warning Failed processing class Bank method compile_bsb_number
		#warning Failed processing class Bank method compile_fraction
		#warning Failed processing class Bank method compile_routing_number
		/// <Summary>Produces a bank iban number.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Bank.iban #=&gt; "GB76DZJM33188515981979"
		/// Faker::Bank.iban(country_code: "be") #=&gt; "BE6375388567752043"
		/// Faker::Bank.iban(country_code: nil) #=&gt; "DE45186738071857270067"
		/// </code>
		/// </Example>
		/// <param name="countryCode">
		/// 					<p>Specifies what country prefix is used to generate the iban code. Providing ‘nil` will use a random country.</p>
		/// 				</param>
		[FakerMethod("iban")]
		public string Iban(string countryCode = "GB")
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("bank.iban_details.#{country_code.downcase}.bban_pattern", this)))); // Fetch
		}
		
		#warning Failed processing class Bank method iban_checksum
		/// <Summary>Produces the ISO 3166 code of a country that uses the IBAN system.</Summary>
		/// <Example>
		/// <code>Faker::Bank.iban_country_code #=&gt; "CH"</code>
		/// </Example>
		[FakerMethod("iban_country_code")]
		public string IbanCountryCode()
		{
			/*
			
						sample(translate('faker.bank.iban_details').keys).to_s.upcase
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a bank name.</Summary>
		/// <Example>
		/// <code>Faker::Bank.name #=&gt; "ABN AMRO CORPORATE FINANCE LIMITED"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("bank.name", this)))); // Fetch
		}
		
		#warning Failed processing class Bank method rand_numstring
		/// <Summary>Produces a routing number.</Summary>
		/// <Example>
		/// <code>Faker::Bank.routing_number #=&gt; "729343831"</code>
		/// </Example>
		[FakerMethod("routing_number")]
		public string RoutingNumber()
		{
			/*
			
						valid_routing_number
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a valid routing number.</Summary>
		/// <Example>
		/// <code>Faker::Bank.routing_number #=&gt; "729343831"</code>
		/// </Example>
		[FakerMethod("routing_number_with_format")]
		public string RoutingNumberWithFormat()
		{
			/*
			
						compile_fraction(valid_routing_number)
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a swift / bic number.</Summary>
		/// <Example>
		/// <code>Faker::Bank.swift_bic #=&gt; "AAFMGB21"</code>
		/// </Example>
		[FakerMethod("swift_bic")]
		public string SwiftBic()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("bank.swift_bic", this)))); // Fetch
		}
		
		[FakerMethod("valid_checksum")]
		public bool ValidChecksum()
		{
			/*
			
						(routing_number, checksum)
						routing_number[8].to_i == checksum
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Bank method valid_routing_number
	}
	public class BarcodeGenerator
	{
		private Faker _faker;
	
		internal BarcodeGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		#warning Failed processing class Barcode method ean
		#warning Failed processing class Barcode method ean_with_composite_symbology
		#warning Failed processing class Barcode method generate_barcode
		/// <Summary>
		/// Generates the check digits from sum passed.
		/// &lt;p&gt;Generates the check digits from sum passed&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Barcode.send(:generate_check_digit, 12, 4)   =&gt; 0
		/// Faker::Barcode.send(:generate_check_digit, 23, 5)   =&gt; 6
		/// </code>
		/// </Example>
		[FakerMethod("generate_check_digit")]
		public long GenerateCheckDigit()
		{
			/*
			
						(odd_sum, even_sum)
						(10 - (odd_sum * 3 + even_sum) % 10) % 10
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Barcode method isbn
		#warning Failed processing class Barcode method ismn
		#warning Failed processing class Barcode method issn
		/// <Summary>
		/// Returns the sum of even and odd numbers from value passed.
		/// &lt;p&gt;Returns the sum of even and odd numbers from value passed&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Barcode.send(:sum_even_odd, 12345)   =&gt; [9, 5]
		/// Faker::Barcode.send(:sum_even_odd, 87465)   =&gt; [17, 13]
		/// </code>
		/// </Example>
		[FakerMethod("sum_even_odd")]
		public List<long> SumEvenOdd()
		{
			/*
			
						(fake_num)
						number = fake_num.to_i
						sum_even, sum_odd = 0, 0, index = 1
		
						while number != 0
						index.even? ? sum_even += number % 10 : sum_odd += number % 10
		
						number /= 10
						index += 1
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Barcode method upc_a
		#warning Failed processing class Barcode method upc_a_with_composite_symbology
		#warning Failed processing class Barcode method upc_e
		#warning Failed processing class Barcode method upc_e_with_composite_symbology
	}
	public class BeerGenerator
	{
		private Faker _faker;
	
		internal BeerGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random beer alcohol percentage.</Summary>
		/// <Example>
		/// <code>Faker::Beer.alcohol #=&gt; "5.4%"</code>
		/// </Example>
		[FakerMethod("alcohol")]
		public string Alcohol()
		{
			/*
			
						"#{rand(2.0..10.0).round(1)}%"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random beer blg level.</Summary>
		/// <Example>
		/// <code>Faker::Beer.blg #=&gt; "5.1Blg"</code>
		/// </Example>
		[FakerMethod("blg")]
		public string Blg()
		{
			/*
			
						"#{rand(5.0..20.0).round(1)}°Blg"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random beer hops.</Summary>
		/// <Example>
		/// <code>Faker::Beer.hop #=&gt; "Sterling"</code>
		/// </Example>
		[FakerMethod("hop")]
		public string Hop()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("beer.hop", this)))); // Fetch
		}
		
		/// <Summary>Produces a random beer IBU.</Summary>
		/// <Example>
		/// <code>Faker::Beer.ibu #=&gt; "87 IBU"</code>
		/// </Example>
		[FakerMethod("ibu")]
		public string Ibu()
		{
			/*
			
						"#{rand(10..100)} IBU"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random beer malt.</Summary>
		/// <Example>
		/// <code>Faker::Beer.malts #=&gt; "Munich"</code>
		/// </Example>
		[FakerMethod("malts")]
		public string Malts()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("beer.malt", this)))); // Fetch
		}
		
		/// <Summary>Produces a random beer name.</Summary>
		/// <Example>
		/// <code>Faker::Beer.name #=&gt; "Pliny The Elder"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("beer.name", this)))); // Fetch
		}
		
		/// <Summary>Produces a random beer style.</Summary>
		/// <Example>
		/// <code>Faker::Beer.style #=&gt; "Wood-aged Beer"</code>
		/// </Example>
		[FakerMethod("style")]
		public string Style()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("beer.style", this)))); // Fetch
		}
		
		/// <Summary>Produces a random beer yeast.</Summary>
		/// <Example>
		/// <code>Faker::Beer.yeast #=&gt; "5335 - Lactobacillus"</code>
		/// </Example>
		[FakerMethod("yeast")]
		public string Yeast()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("beer.yeast", this)))); // Fetch
		}
		
	}
	public class BlockchainGenerator
	{
		private Faker _faker;
	
		internal BlockchainGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		public class AeternityGenerator
		{
			private Faker _faker;
		
			internal AeternityGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces a random Aeternity wallet address.
			/// &lt;p&gt;Produces a random Aeternity wallet address&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Aeternity.address
			/// #=&gt; "ak_zvU8YQLagjcfng7Tg8yCdiZ1rpiWNp1PBn3vtUs44utSvbJVR"
			/// </code>
			/// </Example>
			[FakerMethod("address")]
			public string Address()
			{
				/*
				
								"ak_#{rand_strings}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Aeternity contract.
			/// &lt;p&gt;Produces a random Aeternity contract&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Aeternity.contract
			/// #=&gt; "ct_Hk2JsNeWGEYQEHHQCfcBeGrwbhtYSwFTPdDhW2SvjFYVojyhW"
			/// </code>
			/// </Example>
			[FakerMethod("contract")]
			public string Contract()
			{
				/*
				
								"ct_#{rand_strings}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Aeternity oracle.
			/// &lt;p&gt;Produces a random Aeternity oracle&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Aeternity.oracle
			/// #=&gt; "ok_28QDg7fkF5qiKueSdUvUBtCYPJdmMEoS73CztzXCRAwMGKHKZh"
			/// </code>
			/// </Example>
			[FakerMethod("oracle")]
			public string Oracle()
			{
				/*
				
								"ok_#{rand_strings(51)}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Aeternity transaction.
			/// &lt;p&gt;Produces a random Aeternity transaction&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Aeternity.transaction
			/// #=&gt; "th_147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"
			/// </code>
			/// </Example>
			[FakerMethod("transaction")]
			public string Transaction()
			{
				/*
				
								"th_#{rand_strings(51)}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
		}
		public class BitcoinGenerator
		{
			private Faker _faker;
		
			internal BitcoinGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces a Bitcoin wallet address.
			/// &lt;p&gt;Produces a Bitcoin wallet address&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Bitcoin.address
			/// #=&gt; "147nDP22h3pHrLt2qykTH4txUwQh1ccaXp"
			/// </code>
			/// </Example>
			[FakerMethod("address")]
			public string Address()
			{
				/*
				
								address_for(:main)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Generates a random Bitcoin address for the given network.
			/// &lt;p&gt;Generates a random Bitcoin address for the given network&lt;/p&gt;
			/// </Summary>
			/// <param name="network">
			/// 						<p>The name of network protocol to generate an address for</p>
			/// 					</param>
			[FakerMethod("address_for")]
			public string AddressFor(UNKNWON_Symbol network)
			{
				/*
				
								(network)
								version = PROTOCOL_VERSIONS.fetch(network)
								packed = version.chr + Faker::Config.random.bytes(20)
								checksum = OpenSSL::Digest::SHA256.digest(OpenSSL::Digest::SHA256.digest(packed))[0..3]
								Faker::Base58.encode(packed + checksum)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a Bitcoin testnet address.
			/// &lt;p&gt;Produces a Bitcoin testnet address&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Bitcoin.testnet_address
			/// #=&gt; "n4YjRyYD6V6zREpk6opqESDqD3KYnMdVEB"
			/// </code>
			/// </Example>
			[FakerMethod("testnet_address")]
			public string TestnetAddress()
			{
				/*
				
								address_for(:testnet)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
		}
		public class EthereumGenerator
		{
			private Faker _faker;
		
			internal EthereumGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces a random Ethereum wallet address.
			/// &lt;p&gt;Produces a random Ethereum wallet address&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Ethereum.address
			/// #=&gt; "0xd392b0c0500700d02d27ab30805ec80ddd3320ff"
			/// </code>
			/// </Example>
			[FakerMethod("address")]
			public string Address()
			{
				/*
				
								hex_alphabet = '0123456789abcdef'
								var = +'0x'
								40.times { var << sample(shuffle(hex_alphabet.chars)) }
								var
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
		}
		public class TezosGenerator
		{
			private Faker _faker;
		
			internal TezosGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces a random Tezos account address.
			/// &lt;p&gt;Produces a random Tezos account address&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.account
			/// #=&gt; "tz1eUsgK6aj752Fbxwk5sAoEFvSDnPjZ4qvk"
			/// </code>
			/// </Example>
			[FakerMethod("account")]
			public string Account()
			{
				/*
				
								encode_tz(:tz1, 20)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos block.
			/// &lt;p&gt;Produces a random Tezos block&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.block
			/// #=&gt; "BMbhs2rkY1dvAkAyRytvPsjFQ2RiPrBhYkxvWpY65dzkdSuw58a"
			/// </code>
			/// </Example>
			[FakerMethod("block")]
			public string Block()
			{
				/*
				
								encode_tz(:B, 32)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos contract.
			/// &lt;p&gt;Produces a random Tezos contract&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.contract
			/// #=&gt; "KT1MroqeP15nnitB4CnNfkqHYa2NErhPPLWF"
			/// </code>
			/// </Example>
			[FakerMethod("contract")]
			public string Contract()
			{
				/*
				
								encode_tz(:KT1, 20)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <param name="payloadSize">
			/// 						<p>The size of the payload</p>
			/// 					</param>
			[FakerMethod("encode_tz")]
			public string EncodeTz(long payloadSize)
			{
				/*
				
								(prefix, payload_size)
								prefix = PREFIXES.fetch(prefix)
								packed = prefix.map(&:chr).join + Faker::Config.random.bytes(payload_size)
								checksum = OpenSSL::Digest::SHA256.digest(OpenSSL::Digest::SHA256.digest(packed))[0..3]
								Faker::Base58.encode(packed + checksum)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos operation.
			/// &lt;p&gt;Produces a random Tezos operation&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.operation
			/// #=&gt; "onygWYXJX3xNstFLv9PcCrhQdCkENC795xwSinmTEc1jsDN4VDa"
			/// </code>
			/// </Example>
			[FakerMethod("operation")]
			public string Operation()
			{
				/*
				
								encode_tz(:o, 32)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos public key.
			/// &lt;p&gt;Produces a random Tezos public key&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.public_key
			/// #=&gt; "edpkuib9x8QXRc5nWwHUg7U1dXsVmaUrUNU5sX9pVEEvwbMVdfMCeq"
			/// </code>
			/// </Example>
			[FakerMethod("public_key")]
			public string PublicKey()
			{
				/*
				
								encode_tz(:edpk, 32)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos public key.
			/// &lt;p&gt;Produces a random Tezos public key&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.secret_key
			/// #=&gt; "edsk3HZCAGEGpzQPnQUwQeFY4ESanFhQCgLpKriQw8GHyhKCrjHawv"
			/// </code>
			/// </Example>
			[FakerMethod("secret_key")]
			public string SecretKey()
			{
				/*
				
								encode_tz(:edsk, 32)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random Tezos signature.
			/// &lt;p&gt;Produces a random Tezos signature&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Blockchain::Tezos.signature
			/// #=&gt; "edsigu165B7VFf3Dpw2QABVzEtCxJY2gsNBNcE3Ti7rRxtDUjqTFRpg67EdAQmY6YWPE5tKJDMnSTJDFu65gic8uLjbW2YwGvAZ"
			/// </code>
			/// </Example>
			[FakerMethod("signature")]
			public string Signature()
			{
				/*
				
								encode_tz(:edsig, 64)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
		}
	}
	public class BloodGenerator
	{
		private Faker _faker;
	
		internal BloodGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random blood group name.</Summary>
		/// <Example>
		/// <code>Faker::Blood.group #=&gt; "AB-"</code>
		/// </Example>
		[FakerMethod("group")]
		public string Group()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("blood.group", this)))); // Parse
		}
		
		/// <Summary>Produces a random blood RH-Factor.</Summary>
		/// <Example>
		/// <code>Faker::Blood.rh_factor #=&gt; "-"</code>
		/// </Example>
		[FakerMethod("rh_factor")]
		public string RhFactor()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("blood.rh_factor", this)))); // Fetch
		}
		
		/// <Summary>Produces a random blood type.</Summary>
		/// <Example>
		/// <code>Faker::Blood.type #=&gt; "AB"</code>
		/// </Example>
		[FakerMethod("type")]
		public string Type()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("blood.type", this)))); // Fetch
		}
		
	}
	public class BookGenerator
	{
		private Faker _faker;
	
		internal BookGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a random book author.
		/// &lt;p&gt;Produces a random book author&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Book.author #=&gt; "Alysha Olsen"</code>
		/// </Example>
		[FakerMethod("author")]
		public string Author()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("book.author", this)))); // Parse
		}
		
		/// <Summary>
		/// Produces a random genre.
		/// &lt;p&gt;Produces a random genre&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Book.genre #=&gt; "Mystery"</code>
		/// </Example>
		[FakerMethod("genre")]
		public string Genre()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("book.genre", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces a random book publisher.
		/// &lt;p&gt;Produces a random book publisher&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Book.publisher #=&gt; "Opus Reader"</code>
		/// </Example>
		[FakerMethod("publisher")]
		public string Publisher()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("book.publisher", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces a random book title.
		/// &lt;p&gt;Produces a random book title&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Book.title #=&gt; "The Odd Sister"</code>
		/// </Example>
		[FakerMethod("title")]
		public string Title()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("book.title", this)))); // Fetch
		}
		
	}
	public class BooksGenerator
	{
		private Faker _faker;
	
		internal BooksGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		public class CultureSeriesGenerator
		{
			private Faker _faker;
		
			internal CultureSeriesGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.book
			/// #=&gt; "The Player of Games"
			/// </code>
			/// </Example>
			[FakerMethod("book")]
			public string Book()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.books", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.civ
			/// #=&gt; "Culture"
			/// </code>
			/// </Example>
			[FakerMethod("civ")]
			public string Civ()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.civs", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.culture_ship
			/// #=&gt; "Fate Amenable To Change"
			/// </code>
			/// </Example>
			[FakerMethod("culture_ship")]
			public string CultureShip()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.culture_ships", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.culture_ship_class
			/// #=&gt; "General Systems Vehicle"
			/// </code>
			/// </Example>
			[FakerMethod("culture_ship_class")]
			public string CultureShipClass()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.culture_ship_classes", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.culture_ship_class_abv
			/// #=&gt; "The Odd Sister"
			/// </code>
			/// </Example>
			[FakerMethod("culture_ship_class_abv")]
			public string CultureShipClassAbv()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.culture_ship_class_abvs", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::CultureSeries.planet
			/// #=&gt; "Xinth"
			/// </code>
			/// </Example>
			[FakerMethod("planet")]
			public string Planet()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("culture_series.planets", this)))); // Fetch
			}
			
		}
		/// <Summary>
		/// A Faker module beyond your dreams, test data beyond your imagination.
		/// &lt;p&gt;A Faker module beyond your dreams, test data beyond your imagination.&lt;/p&gt;
		/// </Summary>
		public class DuneGenerator
		{
			private Faker _faker;
		
			internal DuneGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces the name of a character from Dune.
			/// &lt;p&gt;Produces the name of a character from Dune&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Dune.character #=&gt; "Leto Atreides"</code>
			/// </Example>
			[FakerMethod("character")]
			public string Character()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("dune.characters", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces the name of a city from Dune.
			/// &lt;p&gt;Produces the name of a city from Dune&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Dune.city #=&gt; "Arrakeen"</code>
			/// </Example>
			[FakerMethod("city")]
			public string City()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("dune.cities", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces the name of a planet from Dune.
			/// &lt;p&gt;Produces the name of a planet from Dune&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Dune.planet #=&gt; "Caladan"</code>
			/// </Example>
			[FakerMethod("planet")]
			public string Planet()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("dune.planets", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces a quote from Dune.
			/// &lt;p&gt;Produces a quote from Dune&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Dune.quote
			/// #=&gt; "A dead man, surely, no longer requires that water."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Dune.quote(character: "baron_harkonnen")
			/// #=&gt; "He who controls the spice, controls the universe!"
			/// </code>
			/// </Example>
			/// <param name="character">
			/// 						<p>The name of the character that the quote should be from</p>
			/// 					</param>
			[FakerMethod("quote")]
			public string Quote(string? character = null)
			{
				/*
				
								(character: nil)
								quoted_characters = translate('faker.dune.quotes').keys
			
								if character.nil?
								character = sample(quoted_characters).to_s
								else
								character = character.to_s.downcase
			
								unless quoted_characters.include?(character.to_sym)
								raise ArgumentError,
								"Characters quoted can be left blank or #{quoted_characters.join(', ')}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a saying from Dune.
			/// &lt;p&gt;Produces a saying from Dune&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Dune.saying #=&gt; "You do not beg the sun for mercy."</code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Dune.saying(source: "fremen")
			/// #=&gt; "May thy knife chip and shatter."
			/// </code>
			/// </Example>
			/// <param name="source"></param>
			[FakerMethod("saying")]
			public string Saying(string? source = null)
			{
				/*
				
								(source: nil)
								sourced_sayings = translate('faker.dune.sayings').keys
			
								if source.nil?
								source = sample(sourced_sayings).to_s
								else
								source = source.to_s.downcase
			
								unless sourced_sayings.include?(source.to_sym)
								raise ArgumentError,
								"Sources quoted in sayings can be left blank or #{sourced_sayings.join(', ')}"
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Example>
			/// <code>Faker::Books::Dune.title #=&gt; "Duke"</code>
			/// </Example>
			[FakerMethod("title")]
			public string Title()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("dune.titles", this)))); // Fetch
			}
			
		}
		public class LovecraftGenerator
		{
			private Faker _faker;
		
			internal LovecraftGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>
			/// Produces the name of a deity.
			/// &lt;p&gt;Produces the name of a deity&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Lovecraft.deity #=&gt; "Shub-Niggurath"</code>
			/// </Example>
			[FakerMethod("deity")]
			public string Deity()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("lovecraft.deity", this)))); // Fetch
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.fhtagn
			/// #=&gt; "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.fhtagn(number: 3)
			/// #=&gt; "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fht...
			/// </code>
			/// </Example>
			/// <param name="number">
			/// 						<p>The number of times to repeat the chant</p>
			/// 					</param>
			[FakerMethod("fhtagn")]
			public string Fhtagn(long number = 1)
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("lovecraft.fhtagn", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces the name of a location.
			/// &lt;p&gt;Produces the name of a location&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Lovecraft.location #=&gt; "Kingsport"</code>
			/// </Example>
			[FakerMethod("location")]
			public string Location()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("lovecraft.location", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces a random paragraph.
			/// &lt;p&gt;Produces a random paragraph&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraph
			/// #=&gt; "Squamous nameless daemoniac fungus ululate. Cyclopean stygian decadent loathsome manuscript tenebrous. Foetid abnormal stench. Dank non-euclidean comprehension eldritch. Charnel singular shunned lurk effulgence fungus."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraph(sentence_count: 2)
			/// #=&gt; "Decadent lurk tenebrous loathsome furtive spectral amorphous gibbous. Gambrel eldritch daemoniac cat madness comprehension stygian effulgence."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraph(sentence_count: 1, random_sentences_to_add: 1)
			/// #=&gt; "Stench cyclopean fainted antiquarian nameless. Antiquarian ululate tenebrous non-euclidean effulgence."
			/// </code>
			/// </Example>
			/// <param name="randomSentencesToAdd"></param>
			[FakerMethod("paragraph")]
			public string Paragraph(long randomSentencesToAdd = 3)
			{
				/*
				
								(sentence_count: 3, random_sentences_to_add: 3)
								sentences(number: resolve(sentence_count) + rand(random_sentences_to_add.to_i).to_i).join(' ')
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraph_by_chars
			/// #=&gt; "Truffaut stumptown trust fund 8-bit messenger bag portland. Meh kombucha selvage swag biodiesel. Lomo kinfolk jean shorts asymmetrical diy. Wayfarers portland twee stumptown. Wes anderson biodiesel retro 90's pabst. Diy echo 90's mixtape semiotics. Cornho."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraph_by_chars(characters: 128)
			/// #=&gt; "Effulgence madness noisome. Fungus stygian mortal madness amorphous dank. Decadent noisome hideous effulgence. Tentacles charne."
			/// </code>
			/// </Example>
			/// <param name="characters">
			/// 						<p>Number of characters to generate in the paragraph</p>
			/// 					</param>
			[FakerMethod("paragraph_by_chars")]
			public string ParagraphByChars(long characters = 256)
			{
				/*
				
								(characters: 256)
								paragraph = paragraph(sentence_count: 3)
			
								paragraph += " #{paragraph(sentence_count: 3)}" while paragraph.length < characters
			
								"#{paragraph[0...characters - 1]}."
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a array of random paragraphs.
			/// &lt;p&gt;Produces a array of random paragraphs&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraphs
			/// #=&gt; [
			/// #     "Noisome daemoniac gibbous abnormal antediluvian. Unutterable fung...
			/// #     "Non-euclidean immemorial indescribable accursed furtive. Dank unn...
			/// #     "Charnel antediluvian unnamable cat blasphemous comprehension tene...
			/// #   ]
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.paragraphs(number: 2)
			/// #=&gt; [
			/// #     "Hideous amorphous manuscript antediluvian non-euclidean cat eldri...
			/// #     "Tenebrous unnamable comprehension antediluvian lurk. Lurk spectra...
			/// #   ]
			/// </code>
			/// </Example>
			/// <param name="number">
			/// 						<p>Number of paragraphs to generate</p>
			/// 					</param>
			[FakerMethod("paragraphs")]
			public List<string> Paragraphs(long number = 3)
			{
				/*
				
								(number: 3)
								[].tap do |paragraphs|
								1.upto(resolve(number)) do
								paragraphs << paragraph(sentence_count: 3)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a random sentence.
			/// &lt;p&gt;Produces a random sentence&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentence
			/// #=&gt; "Furtive antiquarian squamous dank cat loathsome amorphous lurk."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentence(word_count: 3)
			/// #=&gt; "Daemoniac antediluvian fainted squamous comprehension gambrel nameless singular."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentence(word_count: 3, random_words_to_add: 1)
			/// #=&gt; "Amorphous indescribable tenebrous."
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentence(word_count: 3, random_words_to_add: 0, open_compounds_allowed: true)
			/// #=&gt; "Effulgence unmentionable gambrel."
			/// </code>
			/// </Example>
			/// <param name="openCompoundsAllowed">
			/// 						<p>If true, generated sentence can contain words having additional spaces</p>
			/// 					</param>
			[FakerMethod("sentence")]
			public string Sentence(bool openCompoundsAllowed = true)
			{
				/*
				
								(word_count: 4, random_words_to_add: 6, open_compounds_allowed: true)
								"#{words(number: word_count + rand(random_words_to_add.to_i).to_i, spaces_allowed: open_compounds_allowed).join(' ').capitalize}."
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a array of random sentences.
			/// &lt;p&gt;Produces a array of random sentences&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentences
			/// #=&gt; [
			/// #     "Nameless loathsome decadent gambrel.",
			/// #     "Ululate swarthy immemorial cat madness gibbous unmentionable unnamable.",
			/// #     "Decadent antediluvian non-euclidean tentacles amorphous tenebrous.",
			/// #   ]
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.sentences(number: 2)
			/// #=&gt; [
			/// #     "Antediluvian amorphous unmentionable singular accursed squamous immemorial.",
			/// #     "Gambrel daemoniac gibbous stygian shunned ululate iridescence abnormal.",
			/// #   ]
			/// </code>
			/// </Example>
			/// <param name="number">
			/// 						<p>Number of sentences to generate</p>
			/// 					</param>
			[FakerMethod("sentences")]
			public List<string> Sentences(long number = 3)
			{
				/*
				
								(number: 3)
								[].tap do |sentences|
								1.upto(resolve(number)) do
								sentences << sentence(word_count: 3)
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces the name of a tome.
			/// &lt;p&gt;Produces the name of a tome&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Lovecraft.tome #=&gt; "Book of Eibon"</code>
			/// </Example>
			[FakerMethod("tome")]
			public string Tome()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("lovecraft.tome", this)))); // Fetch
			}
			
			/// <Summary>
			/// Produces a random word.
			/// &lt;p&gt;Produces a random word&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Books::Lovecraft.word #=&gt; "furtive"</code>
			/// </Example>
			[FakerMethod("word")]
			public string Word()
			{
				/*
				
								random_word = sample(translate('faker.lovecraft.words'))
								random_word =~ /\s/ ? word : random_word
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>
			/// Produces a array of random words.
			/// &lt;p&gt;Produces a array of random words&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.words
			/// #=&gt; [
			/// #     "manuscript",
			/// #     "abnormal",
			/// #     "singular",
			/// #   ]
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.words(number: 2)
			/// #=&gt; [
			/// #     "daemoniac",
			/// #     "cat",
			/// #   ]
			/// </code>
			/// </Example>
			/// <Example>
			/// <code>
			/// Faker::Books::Lovecraft.words(number: 2, spaces_allowed: 1)
			/// #=&gt; [
			/// #     "lurk",
			/// #     "charnel",
			/// #   ]
			/// </code>
			/// </Example>
			/// <param name="spacesAllowed">
			/// 						<p>If true, generated words can contain spaces</p>
			/// 					</param>
			[FakerMethod("words")]
			public List<string> Words(bool spacesAllowed = false)
			{
				/*
				
								(number: 3, spaces_allowed: false)
								resolved_num = resolve(number)
								word_list = translate('faker.lovecraft.words')
								word_list *= ((resolved_num / word_list.length) + 1)
			
								return shuffle(word_list)[0, resolved_num] if spaces_allowed
			
								words = shuffle(word_list)[0, resolved_num]
								words.each_with_index { |w, i| words[i] = word if w =~ /\s/ }
							
				*/
				throw new NotSupportedException("Needs porting");
			}
			
		}
		public class TheKingkillerChronicleGenerator
		{
			private Faker _faker;
		
			internal TheKingkillerChronicleGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces the name of a The Kingkiller Chronicle book.</Summary>
			/// <Example>
			/// <code>Faker::Books::TheKingkillerChronicle.book #=&gt; "The Name of the Wind"</code>
			/// </Example>
			[FakerMethod("book")]
			public string Book()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("books.the_kingkiller_chronicle.books", this)))); // Fetch
			}
			
			/// <Summary>Produces the name of a The Kingkiller Chronicle character.</Summary>
			/// <Example>
			/// <code>Faker::Books::TheKingkillerChronicle.character #=&gt; "Kvothe"</code>
			/// </Example>
			[FakerMethod("character")]
			public string Character()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("books.the_kingkiller_chronicle.characters", this)))); // Fetch
			}
			
			/// <Summary>Produces the name of a The Kingkiller Chronicle creature.</Summary>
			/// <Example>
			/// <code>Faker::Books::TheKingkillerChronicle.creature #=&gt; "Scrael"</code>
			/// </Example>
			[FakerMethod("creature")]
			public string Creature()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("books.the_kingkiller_chronicle.creatures", this)))); // Fetch
			}
			
			/// <Summary>Produces the name of a The Kingkiller Chronicle location.</Summary>
			/// <Example>
			/// <code>Faker::Books::TheKingkillerChronicle.location #=&gt; "Tarbean"</code>
			/// </Example>
			[FakerMethod("location")]
			public string Location()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("books.the_kingkiller_chronicle.locations", this)))); // Fetch
			}
			
		}
	}
	public class BooleanGenerator
	{
		private Faker _faker;
	
		internal BooleanGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a boolean.
		/// &lt;p&gt;Produces a boolean&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Boolean.boolean #=&gt; true</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Boolean.boolean(true_ratio: 0.2) #=&gt; false</code>
		/// </Example>
		/// <param name="trueRatio">
		/// 					<p>The likelihood (as a float, out of 1.0) for the method to return ‘true`.</p>
		/// 				</param>
		[FakerMethod("get_boolean")]
		public bool GetBoolean(double trueRatio = 0.5)
		{
			/*
			
						(true_ratio: 0.5)
						(rand < true_ratio)
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class BossaNovaGenerator
	{
		private Faker _faker;
	
		internal BossaNovaGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of a bossa nova artist.</Summary>
		/// <Example>
		/// <code>Faker::BossaNova.artist #=&gt; "Tom Jobin"</code>
		/// </Example>
		[FakerMethod("artist")]
		public string Artist()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("bossa_nova.artists", this)))); // Fetch
		}
		
		/// <Summary>Produces a bossa nova song.</Summary>
		/// <Example>
		/// <code>Faker::BossaNova.song #=&gt; "Chega de Saudade"</code>
		/// </Example>
		[FakerMethod("song")]
		public string Song()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("bossa_nova.songs", this)))); // Fetch
		}
		
	}
	public class BusinessGenerator
	{
		private Faker _faker;
	
		internal BusinessGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a credit card expiration date.</Summary>
		/// <Example>
		/// <code>Faker::Business.credit_card_expiry_date #=&gt; &lt;Date: 2015-11-11 ((2457338j,0s,0n),+0s,2299161j)&gt;</code>
		/// </Example>
		[FakerMethod("credit_card_expiry_date")]
		public DateOnly CreditCardExpiryDate()
		{
			/*
			
						::Date.today + (365 * rand(1..4))
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a credit card number.</Summary>
		/// <Example>
		/// <code>Faker::Business.credit_card_number #=&gt; "1228-1221-1221-1431"</code>
		/// </Example>
		[FakerMethod("credit_card_number")]
		public string CreditCardNumber()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("business.credit_card_numbers", this)))); // Fetch
		}
		
		/// <Summary>Produces a type of credit card.</Summary>
		/// <Example>
		/// <code>Faker::Business.credit_card_type #=&gt; "visa"</code>
		/// </Example>
		[FakerMethod("credit_card_type")]
		public string CreditCardType()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("business.credit_card_types", this)))); // Fetch
		}
		
	}
	public class CameraGenerator
	{
		private Faker _faker;
	
		internal CameraGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a brand of a camera.
		/// &lt;p&gt;Produces a brand of a camera&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Camera.brand #=&gt; "Canon"</code>
		/// </Example>
		[FakerMethod("brand")]
		public string Brand()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("camera.brand", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces a brand with model.
		/// &lt;p&gt;Produces a brand with model&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Camera.brand_with_model #=&gt; "Canon 450D"</code>
		/// </Example>
		[FakerMethod("brand_with_model")]
		public string BrandWithModel()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("camera.brand_with_model", this)))); // Fetch
		}
		
		/// <Summary>
		/// Produces a model of camera.
		/// &lt;p&gt;Produces a model of camera&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Camera.model #=&gt; "450D"</code>
		/// </Example>
		[FakerMethod("model")]
		public string Model()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("camera.model", this)))); // Fetch
		}
		
	}
	public class CannabisGenerator
	{
		private Faker _faker;
	
		internal CannabisGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random brand.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.brand #=&gt; "Cannavore Confections"</code>
		/// </Example>
		[FakerMethod("brand")]
		public string Brand()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.brands", this)))); // Fetch
		}
		
		/// <Summary>Produces a random buzzword.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.buzzword #=&gt; "high"</code>
		/// </Example>
		[FakerMethod("buzzword")]
		public string Buzzword()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.buzzwords", this)))); // Fetch
		}
		
		/// <Summary>Produces a random cannabinoid type.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.cannabinoid #=&gt; "Cannabinolic Acid"</code>
		/// </Example>
		[FakerMethod("cannabinoid")]
		public string Cannabinoid()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.cannabinoids", this)))); // Fetch
		}
		
		/// <Summary>Produces a random abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.cannabinoid_abbreviation #=&gt; "CBGa"</code>
		/// </Example>
		[FakerMethod("cannabinoid_abbreviation")]
		public string CannabinoidAbbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.cannabinoid_abbreviations", this)))); // Fetch
		}
		
		/// <Summary>Produces a random category.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.category #=&gt; "crystalline"</code>
		/// </Example>
		[FakerMethod("category")]
		public string Category()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.categories", this)))); // Fetch
		}
		
		/// <Summary>Produces a random health benefit.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.health_benefit #=&gt; "prevents infection"</code>
		/// </Example>
		[FakerMethod("health_benefit")]
		public string HealthBenefit()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.health_benefits", this)))); // Fetch
		}
		
		/// <Summary>Produces a random kind of medical use.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.medical_use #=&gt; "anti-cancer"</code>
		/// </Example>
		[FakerMethod("medical_use")]
		public string MedicalUse()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.medical_uses", this)))); // Fetch
		}
		
		/// <Summary>Produces a random strain.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.strain #=&gt; "Super Glue"</code>
		/// </Example>
		[FakerMethod("strain")]
		public string Strain()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.strains", this)))); // Fetch
		}
		
		/// <Summary>Produces a random terpene type.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.terpene #=&gt; "Terpinene"</code>
		/// </Example>
		[FakerMethod("terpene")]
		public string Terpene()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.terpenes", this)))); // Fetch
		}
		
		/// <Summary>Produces a random type.</Summary>
		/// <Example>
		/// <code>Faker::Cannabis.type #=&gt; "indica"</code>
		/// </Example>
		[FakerMethod("type")]
		public string Type()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("cannabis.types", this)))); // Fetch
		}
		
	}
	public class ChileRutGenerator
	{
		private Faker _faker;
	
		internal ChileRutGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a random Chilean digito verificador (check-digit).
		/// &lt;p&gt;Alias for english speaking devs.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::ChileRut.check_digit #=&gt; "5"</code>
		/// </Example>
		[FakerMethod("check_digit")]
		public string CheckDigit()
		{
			/*
			
						dv
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random Chilean digito verificador (check-digit).</Summary>
		/// <Example>
		/// <code>Faker::ChileRut.dv #=&gt; "k"</code>
		/// </Example>
		[FakerMethod("dv")]
		public string Dv()
		{
			/*
			
						split_reversed_rut = @last_rut.to_s.reverse.chars
						seq = [2, 3, 4, 5, 6, 7]
						i = 0
						digit_sum = split_reversed_rut.reduce(0) do |sum, n|
						partial_result = sum.to_i + (n.to_i * seq[i])
						i = i == 5 ? 0 : i + 1
						partial_result
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class ChileRut method format_rut
		/// <Summary>Produces a random Chilean RUT (Rol Unico Tributario, ID with 8 digits) with a dv (digito verificador, check-digit).</Summary>
		/// <Example>
		/// <code>
		/// Faker::ChileRut.full_rut #=&gt; "30686957-4"
		/// Faker::ChileRut.full_rut(min_rut: 10_000_000, max_rut: 30_000_000) #=&gt; "20686957-4"
		/// Faker::ChileRut.full_rut(min_rut: 30_686_957, fixed: true) #=&gt; "30686957-4"
		/// </code>
		/// </Example>
		[FakerMethod("full_rut")]
		public string FullRut()
		{
			/*
			
						(min_rut: 1, max_rut: 99_999_999, fixed: false, formatted: false)
						this_rut = rut(min_rut: min_rut, max_rut: max_rut, fixed: fixed)
						this_rut = format_rut(this_rut) if formatted
						"#{this_rut}-#{dv}"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class ChileRut method last_rut
		/// <Summary>Produces a random Chilean RUT (Rol Unico Tributario, ID with 8 digits).</Summary>
		/// <Example>
		/// <code>
		/// Faker::ChileRut.rut #=&gt; 11235813
		/// Faker::ChileRut.rut(min_rut: 10_000_000, max_rut: 30_000_000) #=&gt; 21853211
		/// Faker::ChileRut.rut(min_rut: 20_890_156, is_fixed: true) #=&gt; 20890156
		/// </code>
		/// </Example>
		/// <param name="isFixed">
		/// 					<p>Determines if the RUT is fixed (returns the min_rut value).</p>
		/// 				</param>
		[FakerMethod("rut")]
		public UNKNWON_Number Rut(bool isFixed = false)
		{
			/*
			
						(min_rut: 1, max_rut: 99_999_999, is_fixed: false)
						@last_rut = is_fixed ? min_rut : rand_in_range(min_rut, max_rut)
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class ChuckNorrisGenerator
	{
		private Faker _faker;
	
		internal ChuckNorrisGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Produces a Chuck Norris Fact.
		/// &lt;p&gt;Original list of facts: &lt;a href="https://github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java"&gt;github.com/jenkinsci/chucknorris-plugin/blob/master/src/main/java/hudson/plugins/chucknorris/FactGenerator.java&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::ChuckNorris.fact
		/// #=&gt; "Chuck Norris can solve the Towers of Hanoi in one move."
		/// </code>
		/// </Example>
		[FakerMethod("fact")]
		public string Fact()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("chuck_norris.fact", this)))); // Fetch
		}
		
	}
	public class CodeGenerator
	{
		private Faker _faker;
	
		internal CodeGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Retrieves a real Amazon ASIN code from https://archive.org/details/asin_listing.
		/// &lt;p&gt;Retrieves a real Amazon ASIN code from &lt;a href="https://archive.org/details/asin_listing"&gt;archive.org/details/asin_listing&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Code.asin #=&gt; "B000MZW1GE"</code>
		/// </Example>
		[FakerMethod("asin")]
		public string Asin()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("code.asin", this)))); // Fetch
		}
		
		/// <Summary>Produces a random EAN (European Article Number) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.ean(digits: 8) #=&gt; "36941070"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Code.ean #=&gt; "9941880131907"</code>
		/// </Example>
		/// <param name="digits">
		/// 					<p>the length of the code to generate (either 8 or 13)</p>
		/// 				</param>
		[FakerMethod("ean")]
		public string Ean(long digits = 13)
		{
			/*
			
						(digits: 13)
						case digits
						when 8 then generate_base8_ean
						when 13 then generate_base13_ean
						else raise ArgumentError, 'base must be 8 or 13'
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Code method generate_base10_isbn
		#warning Failed processing class Code method generate_base13_ean
		#warning Failed processing class Code method generate_base13_isbn
		#warning Failed processing class Code method generate_base8_ean
		#warning Failed processing class Code method generate_imei
		#warning Failed processing class Code method generate_nric_check_alphabet
		#warning Failed processing class Code method generate_sin_check_digit
		/// <Summary>Produces a random IMEI (International Mobile Equipment Number) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.imei #=&gt; "492033129092256"</code>
		/// </Example>
		[FakerMethod("imei")]
		public string Imei()
		{
			/*
			
						generate_imei
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random ISBN (International Standard Book Number) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.isbn(digits: 13) #=&gt; "896579606969-8"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Code.isbn #=&gt; "170366802-2"</code>
		/// </Example>
		/// <param name="digits">
		/// 					<p>the length of the code to generate (either 10 or 13)</p>
		/// 				</param>
		[FakerMethod("isbn")]
		public string Isbn(long digits = 10)
		{
			/*
			
						(digits: 10)
						case digits
						when 10 then generate_base10_isbn
						when 13 then generate_base13_isbn
						else raise ArgumentError, 'digits must be 10 or 13'
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random NPI (National Provider Identifier) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.npi #=&gt; "9804062802"</code>
		/// </Example>
		[FakerMethod("npi")]
		public string Npi()
		{
			/*
			
						rand(10**10).to_s.rjust(10, '0')
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>
		/// Produces a random NRIC (National Registry Identity Card) code.
		/// &lt;p&gt;By default generates a Singaporean NRIC ID for someone who is born between the age of 18 and 65.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Code.nric(min_age: 25, max_age: 50) #=&gt; "S9347283G"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Code.nric(max_age: 55) #=&gt; "S7876903C"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Code.nric(min_age: 25) #=&gt; "S6281697Z"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Code.nric #=&gt; "S6372958B"</code>
		/// </Example>
		/// <param name="maxAge">
		/// 					<p>the max age of the person in years</p>
		/// 				</param>
		[FakerMethod("nric")]
		public string Nric(long maxAge = 65)
		{
			/*
			
						(min_age: 18, max_age: 65)
						birthyear = Date.birthday(min_age: min_age, max_age: max_age).year
		
						generate(:string) do |g|
						g.computed(name: :prefix) do
						if birthyear < 2000
						'S'
						else
						'T'
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random RUT (Rol Unico Nacional) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.rut #=&gt; "91611842-2"</code>
		/// </Example>
		[FakerMethod("rut")]
		public string Rut()
		{
			/*
			
						value = Number.number(digits: 8).to_s
						vd = rut_verificator_digit(value)
						value << "-#{vd}"
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Code method rut_verificator_digit
		/// <Summary>Produces a random SIN (Social Insurance Number for Canada) code.</Summary>
		/// <Example>
		/// <code>Faker::Code.sin #=&gt; "996586962"</code>
		/// </Example>
		[FakerMethod("sin")]
		public string Sin()
		{
			/*
			
						# 1   - province or temporary resident
						# 2-8 - random numbers
						# 9   - checksum
		
						# 1st digit. 8,0 are not used
						registry = Faker::Base.sample([1, 2, 3, 4, 5, 6, 7, 9]).to_s
		
						# generate 2nd to 8th
						partial = Array.new(7) { Faker::Config.random.rand(0..9) }.join
		
						# Generate 9th digit
						check_digit = generate_sin_check_digit("#{registry}#{partial}0").to_s
		
						registry + partial + check_digit
					
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Code method sum
	}
	public class CoffeeGenerator
	{
		private Faker _faker;
	
		internal CoffeeGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random blend name.</Summary>
		/// <Example>
		/// <code>Faker::Coffee.blend_name #=&gt; "Major Java"</code>
		/// </Example>
		[FakerMethod("blend_name")]
		public string BlendName()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coffee.blend_name", this)))); // Parse
		}
		
		/// <Summary>Produces a random coffee taste intensity.</Summary>
		/// <Example>
		/// <code>Faker::Coffee.intensifier #=&gt; "mild"</code>
		/// </Example>
		[FakerMethod("intensifier")]
		public string Intensifier()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coffee.intensifier", this)))); // Fetch
		}
		
		/// <Summary>Produces a string containing a random description of a coffee's taste.</Summary>
		/// <Example>
		/// <code>Faker::Coffee.notes #=&gt; "dull, tea-like, cantaloupe, soy sauce, marshmallow"</code>
		/// </Example>
		[FakerMethod("notes")]
		public string Notes()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coffee.notes", this)))); // Parse
		}
		
		/// <Summary>Produces a random coffee origin place.</Summary>
		/// <Example>
		/// <code>Faker::Coffee.origin #=&gt; "Oaxaca, Mexico"</code>
		/// </Example>
		[FakerMethod("origin")]
		public string Origin()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coffee.country", this)))); // Fetch
		}
		
		#warning Failed processing class Coffee method search_format
		/// <Summary>Produces a random coffee variety.</Summary>
		/// <Example>
		/// <code>Faker::Coffee.variety #=&gt; "Red Bourbon"</code>
		/// </Example>
		[FakerMethod("variety")]
		public string Variety()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coffee.variety", this)))); // Fetch
		}
		
	}
	public class CoinGenerator
	{
		private Faker _faker;
	
		internal CoinGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>
		/// Retrieves a face to a flipped coin.
		/// &lt;p&gt;Retrieves a face to a flipped coin&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Coin.flip #=&gt; "Heads"</code>
		/// </Example>
		[FakerMethod("flip")]
		public string Flip()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("coin.flip", this)))); // Fetch
		}
		
		/// <Summary>Retrieves a random coin from any country.</Summary>
		/// <Example>
		/// <code>Faker::Coin.name #=&gt; "Brazilian Real"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("currency.name", this)))); // Fetch
		}
		
	}
	public class ColorGenerator
	{
		private Faker _faker;
	
		internal ColorGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of a color.</Summary>
		/// <Example>
		/// <code>Faker::Color.color_name #=&gt; "yellow"</code>
		/// </Example>
		[FakerMethod("color_name")]
		public string ColorName()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("color.name", this)))); // Fetch
		}
		
		/// <Summary>Produces a hex color code.
		/// &lt;p&gt;Clients are able to specify the hue, saturation, or lightness of the required color. Alternatively a client can simply specify that they need a light or dark color.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Color.hex_color #=&gt; "#31a785"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hex_color(hue: 118, saturation: 1, lightness: 0.53) #=&gt; "#048700"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hex_color(:light) #=&gt; "#FFEE99"</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hex_color(:dark) #=&gt; "#665500"</code>
		/// </Example>
		/// <param name="args">
		/// <p>Allows the client to specify what color should be return</p>
		/// </param>
		[FakerMethod("hex_color")]
		public string HexColor(UNKNWON_Hash? args = null)
		{
			/*
			(args = nil)
		        hsl_hash = {}
		        hsl_hash = { lightness: LIGHTNESS_LOOKUP[args] } if %i[dark light].include?(args)
		        hsl_hash = args if args.is_a?(Hash)
		        hsl_to_hex(hsl_color(**hsl_hash))
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces an array of floats representing an HSL color.
		/// &lt;p&gt;The array is in the form of ‘[hue, saturation, lightness]`.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Color.hsl_color #=&gt; [69.87, 0.66, 0.3]</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hsl_color(hue: 70, saturation: 0.5, lightness: 0.8) #=&gt; [70, 0.5, 0.8]</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hsl_color(hue: 70) #=&gt; [70, 0.66, 0.6]</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hsl_color(saturation: 0.2) #=&gt; [54, 0.2, 0.3]</code>
		/// </Example>
		/// <Example>
		/// <code>Faker::Color.hsl_color(lightness: 0.6) #=&gt; [69.87, 0.66, 0.6]</code>
		/// </Example>
		/// <param name="lightness">
		/// <p>Optional value to use for lightness</p>
		/// </param>
		[FakerMethod("hsl_color")]
		public UNKNWON_Array(Float, Float, Float) HslColor(double? lightness = null)
		{
			/*
			(hue: nil, saturation: nil, lightness: nil)
		        valid_hue = hue || sample((0..360).to_a)
		        valid_saturation = saturation&.clamp(0, 1) || rand.round(2)
		        valid_lightness = lightness&.clamp(0, 1) || rand.round(2)
		        [valid_hue, valid_saturation, valid_lightness]
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a hex code representation of an HSL color.
		/// &lt;p&gt;Produces a hex code representation of an HSL color&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>hsl_to_hex([50, 100,80]) #=&gt; #FFEE99</code>
		/// </Example>
		/// <param name="aHslColor">
		/// <p>The array that represents the HSL color</p>
		/// </param>
		[FakerMethod("hsl_to_hex")]
		public string HslToHex(UNKNWON_Array(Float, Float, Float) aHslColor)
		{
			/*
			(a_hsl_color)
		        h, s, l = a_hsl_color
		        c = (1 - (2 * l - 1).abs) * s
		        h_prime = h / 60
		        x = c * (1 - (h_prime % 2 - 1).abs)
		        m = l - 0.5 * c
		
		        rgb = case h_prime.to_i
		              when 0 # 0 <= H' < 1
		                [c, x, 0]
		              when 1 # 1 <= H' < 2
		                [x, c, 0]
		              when 2 # 2 <= H' < 3
		                [0, c, x]
		              when 3 # 3 <= H' < 4
		                [0, x, c]
		              when 4 # 4 <= H' < 5
		                [x, 0, c]
		              else # 5 <= H' < 6
		                [c, 0, x]
		              end.map { |value| ((value + m) * 255).round }
		
		        format('#%02x%02x%02x', rgb[0], rgb[1], rgb[2])
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces an array of floats representing an HSLA color.
		/// &lt;p&gt;The array is in the form of ‘[hue, saturation, lightness, alpha]`.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Color.hsla_color #=&gt; [154.77, 0.36, 0.9, 0.2]</code>
		/// </Example>
		[FakerMethod("hsla_color")]
		public UNKNWON_Array(Float, Float, Float, Float) HslaColor()
		{
			/*
			
		        hsl_color << rand.round(1)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces an array of integers representing an RGB color.</Summary>
		/// <Example>
		/// <code>Faker::Color.rgb_color #=&gt; [54, 233, 67]</code>
		/// </Example>
		[FakerMethod("rgb_color")]
		public UNKNWON_Array(Integer, Integer, Integer) RgbColor()
		{
			/*
			
		        Array.new(3) { single_rgb_color }
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Color method single_rgb_color
	}
	public class CommerceGenerator
	{
		private Faker _faker;
	
		internal CommerceGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a randomized string of a brand name.
		/// &lt;p&gt;Produces a randomized string of a brand name&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Commerce.brand #=&gt; 'Apple'</code>
		/// </Example>
		[FakerMethod("brand")]
		public string Brand()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("commerce.brand", this)))); // Fetch
		}
		
		#warning Failed processing class Commerce method categories
		/// <Summary>Produces a random color.</Summary>
		/// <Example>
		/// <code>Faker::Commerce.color #=&gt; "lavender"</code>
		/// </Example>
		[FakerMethod("color")]
		public string Color()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("color.name", this)))); // Fetch
		}
		
		/// <Summary>Produces a random department.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Commerce.department #=&gt; "Grocery, Health &amp; Beauty"
		/// Faker::Commerce.department(max: 5) #=&gt; "Grocery, Books, Health &amp; Beauty"
		/// Faker::Commerce.department(max: 2, fixed_amount: true) #=&gt; "Books &amp; Tools"
		/// </code>
		/// </Example>
		/// <param name="fixedAmount">
		/// <p>Fixes the amount of departments to use instead of using a range.</p>
		/// </param>
		[FakerMethod("department")]
		public string Department(bool fixedAmount = false)
		{
			/*
			(max: 3, fixed_amount: false)
		        num = max if fixed_amount
		        num ||= 1 + rand(max)
		
		        categories = categories(num)
		
		        if categories.is_a?(Array)
		          if categories.length > 1
		            merge_categories(categories)
		          else
		            categories[0]
		          
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random material.</Summary>
		/// <Example>
		/// <code>Faker::Commerce.material #=&gt; "Plastic"</code>
		/// </Example>
		[FakerMethod("material")]
		public string Material()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("commerce.product_name.material", this)))); // Fetch
		}
		
		#warning Failed processing class Commerce method merge_categories
		/// <Summary>Produces a random product price.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Commerce.price #=&gt; 44.6
		/// Faker::Commerce.price(range: 0..10.0, as_string: true) #=&gt; "2.18"
		/// </code>
		/// </Example>
		/// <param name="asString">
		/// <p>Changes the return value to [String].</p>
		/// </param>
		[FakerMethod("price")]
		public double Price(bool asString = false)
		{
			/*
			(range: 0..100.0, as_string: false)
		        price = (rand(range) * 100).floor / 100.0
		        if as_string
		          price_parts = price.to_s.split('.')
		          price = "#{price_parts[0]}.#{price_parts[-1].ljust(2, '0')}"
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random product name.</Summary>
		/// <Example>
		/// <code>Faker::Commerce.product_name #=&gt; "Practical Granite Shirt"</code>
		/// </Example>
		[FakerMethod("product_name")]
		public string ProductName()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("commerce.product_name.adjective", this)))); // Fetch
		}
		
		/// <Summary>Produces a random promotion code.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Commerce.promotion_code #=&gt; "AmazingDeal829102"
		/// Faker::Commerce.promotion_code(digits: 2) #=&gt; "AmazingPrice57"
		/// </code>
		/// </Example>
		/// <param name="digits">
		/// <p>Updates the number of numerical digits used to generate the promotion code.</p>
		/// </param>
		[FakerMethod("promotion_code")]
		public string PromotionCode(long digits = 6)
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("commerce.promotion_code.adjective", this)))); // Fetch
		}
		
		/// <Summary>Produces a randomized string of a vendor name.
		/// &lt;p&gt;Produces a randomized string of a vendor name&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Commerce.vendor #=&gt; 'Dollar General'</code>
		/// </Example>
		[FakerMethod("vendor")]
		public string Vendor()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("commerce.vendor", this)))); // Fetch
		}
		
	}
	public class CompanyGenerator
	{
		private Faker _faker;
	
		internal CompanyGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		#warning Failed processing class Company method abn_checksum
		/// <Summary>Produces a company australian business number.</Summary>
		/// <Example>
		/// <code>Faker::Company.australian_business_number #=&gt; "93579396170"</code>
		/// </Example>
		[FakerMethod("australian_business_number")]
		public string AustralianBusinessNumber()
		{
			/*
			
		        base = format('%09d', rand(10**9))
		        abn = "00#{base}"
		
		        (99 - (abn_checksum(abn) % 89)).to_s + base
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company brazilian company number.</Summary>
		/// <Example>
		/// <code>Faker::Company.brazilian_company_number #=&gt; "37205322000500"</code>
		/// </Example>
		[FakerMethod("brazilian_company_number")]
		public string BrazilianCompanyNumber()
		{
			/*
			(formatted: false)
		        digits = Array.new(8) { Faker::Number.digit.to_i } + [0, 0, 0, Faker::Number.non_zero_digit.to_i]
		
		        factors = [5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2, 6].cycle
		
		        2.times do
		          checksum = digits.inject(0) { |acc, digit| acc + digit * factors.next } % 11
		          digits << (checksum < 2 ? 0 : 11 - checksum)
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces some company BS.
		/// &lt;p&gt;When a straight answer won’t do, BS to the rescue!&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.bs #=&gt; "empower customized functionalities"</code>
		/// </Example>
		[FakerMethod("bs")]
		public string Bs()
		{
			/*
			
		        translate('faker.company.bs').collect { |list| sample(list) }.join(' ')
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company buzzword.</Summary>
		/// <Example>
		/// <code>Faker::Company.buzzword #=&gt; "flexibility"</code>
		/// </Example>
		[FakerMethod("buzzword")]
		public string Buzzword()
		{
			/*
			
		        sample(translate('faker.company.buzzwords').flatten)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Company method calculate_gst_checksum
		/// <Summary>Produces a company catch phrase.</Summary>
		/// <Example>
		/// <code>Faker::Company.catch_phrase #=&gt; "Grass-roots grid-enabled portal"</code>
		/// </Example>
		[FakerMethod("catch_phrase")]
		public string CatchPhrase()
		{
			/*
			
		        translate('faker.company.buzzwords').collect { |list| sample(list) }.join(' ')
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Company method collect_regon_sum
		/// <Summary>Produces a company czech organisation number.</Summary>
		/// <Example>
		/// <code>Faker::Company.czech_organisation_number #=&gt; "90642741"</code>
		/// </Example>
		[FakerMethod("czech_organisation_number")]
		public string CzechOrganisationNumber()
		{
			/*
			
		        sum = 0
		        base = []
		        [8, 7, 6, 5, 4, 3, 2].each do |weight|
		          base << sample((0..9).to_a)
		          sum += (weight * base.last)
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company department.</Summary>
		/// <Example>
		/// <code>Faker::Company.department #=&gt; "Information Technology"</code>
		/// </Example>
		[FakerMethod("department")]
		public string Department()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.department", this)))); // Fetch
		}
		
		/// <Summary>Produces a company duns number.</Summary>
		/// <Example>
		/// <code>Faker::Company.duns_number #=&gt; "70-655-5105"</code>
		/// </Example>
		[FakerMethod("duns_number")]
		public string DunsNumber()
		{
			/*
			
		        format('%09d', rand(10**9)).gsub(/(\d{2})(\d{3})(\d{4})/, '\\1-\\2-\\3')
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company EIN (Employer Identification Number).</Summary>
		/// <Example>
		/// <code>Faker::Company.ein #=&gt; "07-4009024"</code>
		/// </Example>
		[FakerMethod("ein")]
		public string Ein()
		{
			/*
			
		        format('%09d', rand(10**9)).gsub(/(\d{2})(\d{7})/, '\\1-\\2')
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company french siren number.
		/// &lt;p&gt;Get a random French SIREN number. See more here &lt;a href="https://fr.wikipedia.org/wiki/Syst%C3%A8me_d%27identification_du_r%C3%A9pertoire_des_entreprises"&gt;fr.wikipedia.org/wiki/Syst%C3%A8me_d%27identification_du_r%C3%A9pertoire_des_entreprises&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.french_siren_number #=&gt; "163417827"</code>
		/// </Example>
		[FakerMethod("french_siren_number")]
		public string FrenchSirenNumber()
		{
			/*
			
		        base = (1..8).map { rand(10) }.join
		        base + luhn_algorithm(base).to_s
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company french siret number.</Summary>
		/// <Example>
		/// <code>Faker::Company.french_siret_number #=&gt; "76430067900496"</code>
		/// </Example>
		[FakerMethod("french_siret_number")]
		public string FrenchSiretNumber()
		{
			/*
			
		        location = rand(100).to_s.rjust(4, '0')
		        org_no = french_siren_number + location
		        org_no + luhn_algorithm(org_no).to_s
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Get a random Indian Goods and Services Tax (GST) number.
		/// &lt;p&gt;For more on Indian tax number here: &lt;a href="https://simple.wikipedia.org/wiki/GSTIN"&gt;simple.wikipedia.org/wiki/GSTIN&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Company.indian_gst_number #=&gt; "15VQPNZ2126J2ZU"
		/// Faker::Company.indian_gst_number(state_code: "22") #=&gt; "22ZVWEY6632K0ZN"
		/// </code>
		/// </Example>
		[FakerMethod("indian_gst_number")]
		public string IndianGstNumber()
		{
			/*
			(state_code: nil)
		        # Check if state code is valid
		        state_code_ranges = [('02'..'38'), ['98']]
		        if state_code && !(state_code_ranges[0].include?(state_code) || state_code == '98')
		          raise ArgumentError, 'state code must be in a range of 02 to 38 or 98'
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company industry.</Summary>
		/// <Example>
		/// <code>Faker::Company.industry #=&gt; "Food &amp; Beverages"</code>
		/// </Example>
		[FakerMethod("industry")]
		public string Industry()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.industry", this)))); // Fetch
		}
		
		#warning Failed processing class Company method inn_checksum
		/// <Summary>For more on Russian tax number algorithm here: https://ru.wikipedia.org/wiki/Идентификационный_номер_налогоплательщика#Вычисление_контрольных_цифр.
		/// &lt;p&gt;For more on Russian tax number algorithm here: &lt;a href="https://ru.wikipedia.org/wiki"&gt;ru.wikipedia.org/wiki&lt;/a&gt;/Идентификационный_номер_налогоплательщика#Вычисление_контрольных_цифр&lt;/p&gt;
		/// 
		/// &lt;p&gt;Range of regions: &lt;a href="https://ru.wikipedia.org/wiki"&gt;ru.wikipedia.org/wiki&lt;/a&gt;/Коды_субъектов_Российской_Федерации region [String] Any region string&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>
		/// Faker::Comnpany.russian_tax_number
		/// Faker::Comnpany.russian_tax_number(region: 'AZ')
		/// Faker::Comnpany.russian_tax_number(region: 'AZ', type: false)
		/// </code>
		/// </Example>
		/// <param name="type">
		/// <p>Legeal or not, defaults to :legal</p>
		/// </param>
		[FakerMethod("inn_number")]
		public string InnNumber(UNKNWON_Symbol type)
		{
			/*
			(region, type)
		        n10 = [2, 4, 10, 3, 5, 9, 4, 6, 8]
		        n11 = [7, 2, 4, 10, 3, 5, 9, 4, 6, 8]
		        n12 = [3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8]
		
		        region = format('%.2d', rand(0o1..92)) if region.nil?
		        checksum = if type == :legal
		                     number = region.to_s + rand(1_000_000..9_999_999).to_s
		                     inn_checksum(n10, number)
		                   else
		                     number = region.to_s + rand(10_000_000..99_999_999).to_s
		                     inn_checksum(n11, number) + inn_checksum(n12, number + inn_checksum(n11, number))
		                   
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company logo.
		/// &lt;p&gt;Get a random company logo url in PNG format.&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.logo #=&gt; "https://pigment.github.io/fake-logos/logos/medium/color/12.png"</code>
		/// </Example>
		[FakerMethod("logo")]
		public string Logo()
		{
			/*
			
		        rand_num = rand(1..13)
		        "https://pigment.github.io/fake-logos/logos/medium/color/#{rand_num}.png"
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Company method luhn_algorithm
		#warning Failed processing class Company method mod11
		/// <Summary>Produces a company name.</Summary>
		/// <Example>
		/// <code>Faker::Company.name #=&gt; "Roberts Inc"</code>
		/// </Example>
		[FakerMethod("name")]
		public string Name()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.name", this)))); // Parse
		}
		
		/// <Summary>Produces a company norwegian organisation number.
		/// &lt;p&gt;Get a random Norwegian organization number. Info: &lt;a href="https://www.brreg.no/om-oss/samfunnsoppdraget-vart/registera-vare/einingsregisteret/organisasjonsnummeret"&gt;www.brreg.no/om-oss/samfunnsoppdraget-vart/registera-vare/einingsregisteret/organisasjonsnummeret&lt;/a&gt;/&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.norwegian_organisation_number #=&gt; "842457173"</code>
		/// </Example>
		[FakerMethod("norwegian_organisation_number")]
		public string NorwegianOrganisationNumber()
		{
			/*
			
		        # Valid leading digit: 8, 9
		        mod11_check = nil
		        while mod11_check.nil?
		          base = [sample([8, 9]), format('%07d', rand(10**7))].join
		          mod11_check = mod11(base)
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company polish register of national economy.
		/// &lt;p&gt;Get a random Polish register of national economy number. More info &lt;a href="https://pl.wikipedia.org/wiki/REGON"&gt;pl.wikipedia.org/wiki/REGON&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.polish_register_of_national_economy #=&gt; "788435970"</code>
		/// </Example>
		[FakerMethod("polish_register_of_national_economy")]
		public string PolishRegisterOfNationalEconomy()
		{
			/*
			(length: 9)
		        raise ArgumentError, 'Length should be 9 or 14' unless [9, 14].include? length
		
		        random_digits = []
		        loop do
		          random_digits = Array.new(length) { rand(10) }
		          break if collect_regon_sum(random_digits) == random_digits.last
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company polish taxpayer identification_number.
		/// &lt;p&gt;Get a random Polish taxpayer identification number More info &lt;a href="https://pl.wikipedia.org/wiki/NIP"&gt;pl.wikipedia.org/wiki/NIP&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.polish_taxpayer_identification_number #=&gt; "2767549463"</code>
		/// </Example>
		[FakerMethod("polish_taxpayer_identification_number")]
		public string PolishTaxpayerIdentificationNumber()
		{
			/*
			
		        result = []
		        weights = [6, 5, 7, 2, 3, 4, 5, 6, 7]
		        loop do
		          result = Array.new(3) { rand(1..9) } + Array.new(7) { rand(10) }
		          break if (weight_sum(result, weights) % 11) == result[9]
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company profession.</Summary>
		/// <Example>
		/// <code>Faker::Company.profession #=&gt; "factory worker"</code>
		/// </Example>
		[FakerMethod("profession")]
		public string Profession()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.profession", this)))); // Fetch
		}
		
		/// <Summary>Get a random Russian tax number.</Summary>
		/// <Example>
		/// <code>
		/// Faker::Company.russian_tax_number                             #=&gt; "0415584064"
		/// Faker::Company.russian_tax_number(region: 'AZ')               #=&gt; "AZ50124562"
		/// Faker::Company.russian_tax_number(region: 'AZ', type: false)  #=&gt; "AZ8802315465"
		/// </code>
		/// </Example>
		/// <param name="type">
		/// <p>Legeal or not, defaults to :legal</p>
		/// </param>
		[FakerMethod("russian_tax_number")]
		public string RussianTaxNumber(UNKNWON_Symbol? type = null)
		{
			/*
			(region: nil, type: :legal)
		        inn_number(region, type)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company sic code.</Summary>
		/// <Example>
		/// <code>Faker::Company.sic_code #=&gt; "7383"</code>
		/// </Example>
		[FakerMethod("sic_code")]
		public string SicCode()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.sic_code", this)))); // Fetch
		}
		
		/// <Summary>Produces a company south african close corporation registration number.</Summary>
		/// <Example>
		/// <code>Faker::Company.south_african_close_corporation_registration_number #=&gt; "CK38/5739937418/23"</code>
		/// </Example>
		[FakerMethod("south_african_close_corporation_registration_number")]
		public string SouthAfricanCloseCorporationRegistrationNumber()
		{
			/*
			
		        generate(:string) do |g|
		          g.oneof do |one|
		            one.group do |g_|
		              g_.lit('CK')
		              g_.int(length: 2)
		            
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company south african listed company registration number.</Summary>
		/// <Example>
		/// <code>Faker::Company.south_african_listed_company_registration_number #=&gt; "2512/87676/06"</code>
		/// </Example>
		[FakerMethod("south_african_listed_company_registration_number")]
		public string SouthAfricanListedCompanyRegistrationNumber()
		{
			/*
			
		        generate(:string) do |g|
		          g.int(length: 4)
		          g.lit('/')
		          g.int(ranges: [1000..9_999_999_999])
		          g.lit('/06')
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company south african pty ltd registration number.</Summary>
		/// <Example>
		/// <code>Faker::Company.south_african_pty_ltd_registration_number #=&gt; "7043/2400717902/07"</code>
		/// </Example>
		[FakerMethod("south_african_pty_ltd_registration_number")]
		public string SouthAfricanPtyLtdRegistrationNumber()
		{
			/*
			
		        generate(:string) do |g|
		          g.int(length: 4)
		          g.lit('/')
		          g.int(ranges: [1000..9_999_999_999])
		          g.lit('/07')
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company south african trust registration number.</Summary>
		/// <Example>
		/// <code>Faker::Company.south_african_trust_registration_number #=&gt; "IT5673/937519896"</code>
		/// </Example>
		[FakerMethod("south_african_trust_registration_number")]
		public string SouthAfricanTrustRegistrationNumber()
		{
			/*
			
		        generate(:string) do |g|
		          g.lit('IT')
		          g.int(ranges: [10..9999])
		          g.lit('/')
		          g.int(ranges: [10..9_999_999_999])
		        
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		#warning Failed processing class Company method spanish_b_algorithm
		#warning Failed processing class Company method spanish_cif_control_digit
		/// <Summary>Produces a company spanish organisation number.
		/// &lt;p&gt;Get a random Spanish organization number. See more here &lt;a href="https://es.wikipedia.org/wiki/N%C3%BAmero_de_identificaci%C3%B3n_fiscal"&gt;es.wikipedia.org/wiki/N%C3%BAmero_de_identificaci%C3%B3n_fiscal&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.spanish_organisation_number #=&gt; "D6819358"</code>
		/// </Example>
		[FakerMethod("spanish_organisation_number")]
		public string SpanishOrganisationNumber()
		{
			/*
			(organization_type: nil)
		        # Valid leading character: A, B, C, D, E, F, G, H, J, N, P, Q, R, S, U, V, W
		        # format: 1 digit letter (organization type) + 7 digit numbers + 1 digit control (letter or number based on
		        # organization type)
		        letters = %w[A B C D E F G H J N P Q R S U V W]
		
		        organization_type = sample(letters) unless letters.include?(organization_type)
		        code = format('%07d', rand(10**7))
		        control = spanish_cif_control_digit(organization_type, code)
		
		        [organization_type, code, control].join
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company suffix.</Summary>
		/// <Example>
		/// <code>Faker::Company.suffix #=&gt; "LLC"</code>
		/// </Example>
		[FakerMethod("suffix")]
		public string Suffix()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.suffix", this)))); // Fetch
		}
		
		/// <Summary>Produces a company swedish organisation number.
		/// &lt;p&gt;Get a random Swedish organization number. See more here &lt;a href="https://sv.wikipedia.org/wiki/Organisationsnummer"&gt;sv.wikipedia.org/wiki/Organisationsnummer&lt;/a&gt;&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Company.swedish_organisation_number #=&gt; "3866029808"</code>
		/// </Example>
		[FakerMethod("swedish_organisation_number")]
		public string SwedishOrganisationNumber()
		{
			/*
			
		        # Valid leading digit: 1, 2, 3, 5, 6, 7, 8, 9
		        # Valid third digit: >= 2
		        # Last digit is a control digit
		        base = [sample([1, 2, 3, 5, 6, 7, 8, 9]), sample((0..9).to_a), sample((2..9).to_a), format('%06d', rand(10**6))].join
		        base + luhn_algorithm(base).to_s
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a company type.</Summary>
		/// <Example>
		/// <code>Faker::Company.type #=&gt; "Partnership"</code>
		/// </Example>
		[FakerMethod("type")]
		public string Type()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("company.type", this)))); // Fetch
		}
		
		#warning Failed processing class Company method weight_sum
	}
	public class CompassGenerator
	{
		private Faker _faker;
	
		internal CompassGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Compass.abbreviation #=&gt; "NEbN"</code>
		/// </Example>
		[FakerMethod("abbreviation")]
		public string Abbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.abbreviation", this)))); // Parse
		}
		
		/// <Summary>Produces a random azimuth.</Summary>
		/// <Example>
		/// <code>Faker::Compass.azimuth #=&gt; "168.75"</code>
		/// </Example>
		[FakerMethod("azimuth")]
		public string Azimuth()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.azimuth", this)))); // Parse
		}
		
		/// <Summary>Produces a random cardinal.</Summary>
		/// <Example>
		/// <code>Faker::Compass.cardinal #=&gt; "north"</code>
		/// </Example>
		[FakerMethod("cardinal")]
		public string Cardinal()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.cardinal.word", this)))); // Fetch
		}
		
		/// <Summary>Produces a random cardinal abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Compass.cardinal_abbreviation #=&gt; "N"</code>
		/// </Example>
		[FakerMethod("cardinal_abbreviation")]
		public string CardinalAbbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.cardinal.abbreviation", this)))); // Fetch
		}
		
		/// <Summary>Produces a random cardinal azimuth.</Summary>
		/// <Example>
		/// <code>Faker::Compass.cardinal_azimuth #=&gt; "90"</code>
		/// </Example>
		[FakerMethod("cardinal_azimuth")]
		public string CardinalAzimuth()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.cardinal.azimuth", this)))); // Fetch
		}
		
		/// <Summary>Produces a random direction.</Summary>
		/// <Example>
		/// <code>Faker::Compass.direction #=&gt; "southeast"</code>
		/// </Example>
		[FakerMethod("direction")]
		public string Direction()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.direction", this)))); // Parse
		}
		
		/// <Summary>Produces a random half wind.</Summary>
		/// <Example>
		/// <code>Faker::Compass.half_wind #=&gt; "north-northwest"</code>
		/// </Example>
		[FakerMethod("half_wind")]
		public string HalfWind()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.half-wind.word", this)))); // Fetch
		}
		
		/// <Summary>Produces a random half wind abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Compass.half_wind_abbreviation #=&gt; "NNE"</code>
		/// </Example>
		[FakerMethod("half_wind_abbreviation")]
		public string HalfWindAbbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.half-wind.abbreviation", this)))); // Fetch
		}
		
		/// <Summary>Produces a random half wind azimuth.</Summary>
		/// <Example>
		/// <code>Faker::Compass.half_wind_azimuth #=&gt; "292.5"</code>
		/// </Example>
		[FakerMethod("half_wind_azimuth")]
		public string HalfWindAzimuth()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.half-wind.azimuth", this)))); // Fetch
		}
		
		/// <Summary>Produces a random ordinal.</Summary>
		/// <Example>
		/// <code>Faker::Compass.ordinal #=&gt; "northwest"</code>
		/// </Example>
		[FakerMethod("ordinal")]
		public string Ordinal()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.ordinal.word", this)))); // Fetch
		}
		
		/// <Summary>Produces a random ordinal abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Compass.ordinal_abbreviation #=&gt; "SW"</code>
		/// </Example>
		[FakerMethod("ordinal_abbreviation")]
		public string OrdinalAbbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.ordinal.abbreviation", this)))); // Fetch
		}
		
		/// <Summary>Produces a random ordinal azimuth.</Summary>
		/// <Example>
		/// <code>Faker::Compass.ordinal_azimuth #=&gt; "135"</code>
		/// </Example>
		[FakerMethod("ordinal_azimuth")]
		public string OrdinalAzimuth()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.ordinal.azimuth", this)))); // Fetch
		}
		
		/// <Summary>Produces a random quarter wind.</Summary>
		/// <Example>
		/// <code>Faker::Compass.quarter_wind #=&gt; "north by west"</code>
		/// </Example>
		[FakerMethod("quarter_wind")]
		public string QuarterWind()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.quarter-wind.word", this)))); // Fetch
		}
		
		/// <Summary>Produces a random quarter wind abbreviation.</Summary>
		/// <Example>
		/// <code>Faker::Compass.quarter_wind_abbreviation #=&gt; "SWbS"</code>
		/// </Example>
		[FakerMethod("quarter_wind_abbreviation")]
		public string QuarterWindAbbreviation()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.quarter-wind.abbreviation", this)))); // Fetch
		}
		
		/// <Summary>Produces a random quarter wind azimuth.
		/// &lt;p&gt;Produces a random quarter wind azimuth&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Compass.quarter_wind_azimuth #=&gt; "56.25"</code>
		/// </Example>
		[FakerMethod("quarter_wind_azimuth")]
		public string QuarterWindAzimuth()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("compass.quarter-wind.azimuth", this)))); // Fetch
		}
		
	}
	public class ComputerGenerator
	{
		private Faker _faker;
	
		internal ComputerGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces the name of a computer os.</Summary>
		/// <Example>
		/// <code>Faker::Computer.os #=&gt; "RHEL 6.10"</code>
		/// </Example>
		/// <param name="platform">
		/// <p>optionally specify the platform ‘linux`, `macos`, or `windows`.</p>
		/// </param>
		[FakerMethod("os")]
		public string Os(string platform = self.platform)
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("computer.os.#{platform.downcase}", this)))); // Fetch
		}
		
		/// <Summary>Produces the name of a computer platform.</Summary>
		/// <Example>
		/// <code>Faker::Computer.platform #=&gt; "Linux"</code>
		/// </Example>
		[FakerMethod("platform")]
		public string Platform()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("computer.platform", this)))); // Fetch
		}
		
		/// <Summary>Produces a string with computer platform and os.
		/// &lt;p&gt;Produces a string with computer platform and os&lt;/p&gt;
		/// </Summary>
		/// <Example>
		/// <code>Faker::Computer.stack #=&gt; "Linux, RHEL 6.10"</code>
		/// </Example>
		[FakerMethod("stack")]
		public string Stack()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("computer.os.#{platform.downcase}", this)))); // Fetch
		}
		
		/// <Summary>Produces the name of a computer type.</Summary>
		/// <Example>
		/// <code>Faker::Computer.type #=&gt; "server"</code>
		/// </Example>
		[FakerMethod("type")]
		public string Type()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("computer.type", this)))); // Fetch
		}
		
	}
	public class ConstructionGenerator
	{
		private Faker _faker;
	
		internal ConstructionGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random heavy equipment.</Summary>
		/// <Example>
		/// <code>Faker::Construction.heavy_equipment #=&gt; "Excavator"</code>
		/// </Example>
		[FakerMethod("heavy_equipment")]
		public string HeavyEquipment()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.heavy_equipment", this)))); // Fetch
		}
		
		/// <Summary>Produces a random material.</Summary>
		/// <Example>
		/// <code>Faker::Construction.material #=&gt; "Wood"</code>
		/// </Example>
		[FakerMethod("material")]
		public string Material()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.materials", this)))); // Fetch
		}
		
		/// <Summary>Produces a random role.</Summary>
		/// <Example>
		/// <code>Faker::Construction.role #=&gt; "Engineer"</code>
		/// </Example>
		[FakerMethod("role")]
		public string Role()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.roles", this)))); // Fetch
		}
		
		/// <Summary>Produces a random standard cost code.</Summary>
		/// <Example>
		/// <code>Faker::Construction.standard_cost_code #=&gt; "1-000 - Purpose"</code>
		/// </Example>
		[FakerMethod("standard_cost_code")]
		public string StandardCostCode()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.standard_cost_codes", this)))); // Fetch
		}
		
		/// <Summary>Produces a random subcontract category.</Summary>
		/// <Example>
		/// <code>Faker::Construction.subcontract_category #=&gt; "Curb &amp; Gutter"</code>
		/// </Example>
		[FakerMethod("subcontract_category")]
		public string SubcontractCategory()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.subcontract_categories", this)))); // Fetch
		}
		
		/// <Summary>Produces a random trade.</Summary>
		/// <Example>
		/// <code>Faker::Construction.trade #=&gt; "Carpenter"</code>
		/// </Example>
		[FakerMethod("trade")]
		public string Trade()
		{
			return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("construction.trades", this)))); // Fetch
		}
		
	}
	public class CosmereGenerator
	{
		private Faker _faker;
	
		internal CosmereGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random allomancer.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.allomancer #=&gt; "Coinshot"</code>
		/// </Example>
		[FakerMethod("allomancer")]
		public string Allomancer()
		{
			/*
			
		        sample(allomancers)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random aon.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.aon #=&gt; "Rao"</code>
		/// </Example>
		[FakerMethod("aon")]
		public string Aon()
		{
			/*
			
		        sample(aons)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random feruchemist.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.feruchemist #=&gt; "Archivist"</code>
		/// </Example>
		[FakerMethod("feruchemist")]
		public string Feruchemist()
		{
			/*
			
		        sample(feruchemists)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random herald.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.herald #=&gt; "Ishar"</code>
		/// </Example>
		[FakerMethod("herald")]
		public string Herald()
		{
			/*
			
		        sample(heralds)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random knight radiant.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.knight_radiant #=&gt; "Truthwatcher"</code>
		/// </Example>
		[FakerMethod("knight_radiant")]
		public string KnightRadiant()
		{
			/*
			
		        sample(knights_radiant)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random metal.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.metal #=&gt; "Brass"</code>
		/// </Example>
		[FakerMethod("metal")]
		public string Metal()
		{
			/*
			
		        sample(metals)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random shard.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.shard #=&gt; "Ambition"</code>
		/// </Example>
		[FakerMethod("shard")]
		public string Shard()
		{
			/*
			
		        sample(shards)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random shard world.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.shard_world #=&gt; "Yolen"</code>
		/// </Example>
		[FakerMethod("shard_world")]
		public string ShardWorld()
		{
			/*
			
		        sample(shard_worlds)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random spren.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.spren #=&gt; "Flamespren"</code>
		/// </Example>
		[FakerMethod("spren")]
		public string Spren()
		{
			/*
			
		        sample(sprens)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random surge.</Summary>
		/// <Example>
		/// <code>Faker::Cosmere.surge #=&gt; "Progression"</code>
		/// </Example>
		[FakerMethod("surge")]
		public string Surge()
		{
			/*
			
		        sample(surges)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class CreatureGenerator
	{
		private Faker _faker;
	
		internal CreatureGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		public class AnimalGenerator
		{
			private Faker _faker;
		
			internal AnimalGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces a random animal name.
			/// &lt;p&gt;Produces a random animal name&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Animal.name #=&gt; "fly"</code>
			/// </Example>
			[FakerMethod("name")]
			public string Name()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.animal.name", this)))); // Fetch
			}
			
		}
		public class BirdGenerator
		{
			private Faker _faker;
		
			internal BirdGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces a random adjective used to described birds.
			/// &lt;p&gt;Produces a random adjective used to described birds&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.adjective #=&gt; 'common'</code>
			/// </Example>
			[FakerMethod("adjective")]
			public string Adjective()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.adjectives", this)))); // Fetch
			}
			
			/// <Summary>Produces a random bird anatomy word.
			/// &lt;p&gt;Produces a random bird anatomy word&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.anatomy #=&gt; "rump"</code>
			/// </Example>
			[FakerMethod("anatomy")]
			public string Anatomy()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.anatomy", this)))); // Fetch
			}
			
			/// <Summary>Produces a random, past tensed bird anatomy word.
			/// &lt;p&gt;Produces a random, past tensed bird anatomy word&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.anatomy #=&gt; "breasted"</code>
			/// </Example>
			[FakerMethod("anatomy_past_tense")]
			public string AnatomyPastTense()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.anatomy_past_tense", this)))); // Fetch
			}
			
			/// <Summary>Produces a random color word used in describing birds.
			/// &lt;p&gt;Produces a random color word used in describing birds&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.color #=&gt; "ferruginous"</code>
			/// </Example>
			[FakerMethod("color")]
			public string Color()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.colors", this)))); // Fetch
			}
			
			/// <Summary>Produces a random common family name of a bird.</Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.common_family_name #=&gt; "Owls"</code>
			/// </Example>
			[FakerMethod("common_family_name")]
			public string CommonFamilyName()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.common_family_name", this)))); // Fetch
			}
			
			/// <Summary>Produces a random common name for a bird.
			/// &lt;p&gt;Produces a random common name for a bird&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.common_name #=&gt; 'wren'</code>
			/// </Example>
			/// <param name="taxOrder">
			/// <p>Tax</p>
			/// </param>
			[FakerMethod("common_name")]
			public string CommonName(UNKNWON_String | Symbol | nil? taxOrder = null)
			{
				/*
				(tax_order = nil)
			          map = translate('faker.creature.bird.order_common_map')
			          if tax_order.nil?
			            sample(map.values.flatten).downcase
			          else
			            raise TypeError, 'tax_order parameter must be symbolizable' \
			              unless tax_order.respond_to?(:to_sym)
			            raise ArgumentError, "#{tax_order} is not a valid taxonomic order" \
			                                 unless map.keys.include?(tax_order.to_sym)
			
			            the_order = translate('faker.creature.bird.order_common_map')[tax_order.to_sym]
			            sample(the_order).downcase
			          
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>Produces a random emotional adjective NOT used to described birds ...but could be.
			/// &lt;p&gt;Produces a random emotional adjective NOT used to described birds …but could be&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.emotional_adjective #=&gt; 'cantankerous'</code>
			/// </Example>
			[FakerMethod("emotional_adjective")]
			public string EmotionalAdjective()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.emotional_adjectives", this)))); // Fetch
			}
			
			/// <Summary>Produces a random geographical word used in describing birds.
			/// &lt;p&gt;Produces a random geographical word used in describing birds&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.geo #=&gt; "Eurasian"</code>
			/// </Example>
			[FakerMethod("geo")]
			public string Geo()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.geo", this)))); // Fetch
			}
			
			/// <Summary>Produces a random and IMplausible common name for a bird.
			/// &lt;p&gt;Produces a random and IMplausible common name for a bird&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.implausible_common_name #=&gt; 'Hellinger's Cantankerous Chickadee'</code>
			/// </Example>
			[FakerMethod("implausible_common_name")]
			public string ImplausibleCommonName()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.implausible_common_names", this)))); // Parse
			}
			
			/// <Summary>Produces a random common taxonomic order from the class Aves.
			/// &lt;p&gt;Produces a random common taxonomic order from the class Aves&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.order #=&gt; "Passeriformes"</code>
			/// </Example>
			[FakerMethod("order")]
			public string Order()
			{
				/*
				
			          orders = I18n.translate('faker.creature.bird.order_common_map').keys
			          sample(orders).to_s
			        
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>Produces a hash entry with a random order and a random common name that is of that order.
			/// &lt;p&gt;Produces a hash entry with a random order and a random common name that is of that order&lt;/p&gt;
			/// 
			/// &lt;p&gt;}&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>
			/// Faker::Creature::Bird.order_with_common_name #=&gt; {
			/// order: ''Accipitriformes',
			/// common_name: 'Osprey'
			/// </code>
			/// </Example>
			[FakerMethod("order_with_common_name")]
			public UNKNWON_Hash<order,common_name> OrderWithCommonName()
			{
				/*
				(tax_order = nil)
			          map = I18n.translate('faker.creature.bird.order_common_map')
			          o = tax_order.nil? ? order : tax_order
			          { order: o, common_name: sample(map[o.to_sym]) }
			        
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>Produces a random and plausible common name for a bird.
			/// &lt;p&gt;Produces a random and plausible common name for a bird&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.plausible_common_name #=&gt; 'Hellinger's Wren'</code>
			/// </Example>
			[FakerMethod("plausible_common_name")]
			public string PlausibleCommonName()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.plausible_common_names", this)))); // Parse
			}
			
			/// <Summary>Produces a random adjective NOT used to described birds ...but probably shouldn't.
			/// &lt;p&gt;Produces a random adjective NOT used to described birds …but probably shouldn’t&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Bird.silly_adjective #=&gt; 'drunk'</code>
			/// </Example>
			[FakerMethod("silly_adjective")]
			public string SillyAdjective()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.bird.silly_adjectives", this)))); // Fetch
			}
			
		}
		public class CatGenerator
		{
			private Faker _faker;
		
			internal CatGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces a random cat breed.
			/// &lt;p&gt;Produces a random cat breed&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Cat.breed #=&gt; "Scottish Fold"</code>
			/// </Example>
			[FakerMethod("breed")]
			public string Breed()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.cat.breed", this)))); // Fetch
			}
			
			/// <Summary>Produces a random name for a cat.
			/// &lt;p&gt;Produces a random name for a cat&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Cat.name #=&gt; "Felix"</code>
			/// </Example>
			[FakerMethod("name")]
			public string Name()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.cat.name", this)))); // Fetch
			}
			
			/// <Summary>Produces a random cat breed registry.
			/// &lt;p&gt;Produces a random cat breed registry&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Cat.registry #=&gt; "Fancy Southern Africa Cat Council"</code>
			/// </Example>
			[FakerMethod("registry")]
			public string Registry()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.cat.registry", this)))); // Fetch
			}
			
		}
		public class DogGenerator
		{
			private Faker _faker;
		
			internal DogGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces a random dog age.
			/// &lt;p&gt;Produces a random dog age&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.age #=&gt; "puppy"</code>
			/// </Example>
			[FakerMethod("age")]
			public string Age()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.age", this)))); // Fetch
			}
			
			/// <Summary>Produces a random dog breed.
			/// &lt;p&gt;Produces a random dog breed&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.breed #=&gt; "Yorkshire Terrier"</code>
			/// </Example>
			[FakerMethod("breed")]
			public string Breed()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.breed", this)))); // Fetch
			}
			
			/// <Summary>Produces a random coat length.
			/// &lt;p&gt;Produces a random coat length&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.coat_length #=&gt; "short"</code>
			/// </Example>
			[FakerMethod("coat_length")]
			public string CoatLength()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.coat_length", this)))); // Fetch
			}
			
			/// <Summary>Produces a random gender.
			/// &lt;p&gt;Produces a random gender&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.gender #=&gt; "Female"</code>
			/// </Example>
			[FakerMethod("gender")]
			public string Gender()
			{
				/*
				
			          Faker::Gender.binary_type
			        
				*/
				throw new NotSupportedException("Needs porting");
			}
			
			/// <Summary>Produces a random dog meme phrase.
			/// &lt;p&gt;Produces a random dog meme phrase&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.meme_phrase #=&gt; "smol pupperino"</code>
			/// </Example>
			[FakerMethod("meme_phrase")]
			public string MemePhrase()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.meme_phrase", this)))); // Fetch
			}
			
			/// <Summary>Produces a random name for a dog.
			/// &lt;p&gt;Produces a random name for a dog&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.name #=&gt; "Spike"</code>
			/// </Example>
			[FakerMethod("name")]
			public string Name()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.name", this)))); // Fetch
			}
			
			/// <Summary>Produces a random size of a dog.
			/// &lt;p&gt;Produces a random size of a dog&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.size #=&gt; "small"</code>
			/// </Example>
			[FakerMethod("size")]
			public string Size()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.size", this)))); // Fetch
			}
			
			/// <Summary>Produces a random sound made by a dog.
			/// &lt;p&gt;Produces a random sound made by a dog&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Dog.sound #=&gt; "woof woof"</code>
			/// </Example>
			[FakerMethod("sound")]
			public string Sound()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.dog.sound", this)))); // Fetch
			}
			
		}
		public class HorseGenerator
		{
			private Faker _faker;
		
			internal HorseGenerator(Faker faker)
			{
				_faker = faker;
			}
		
			/// <Summary>Produces a random horse breed.
			/// &lt;p&gt;Produces a random horse breed&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Horse.breed #=&gt; "Spanish Barb see Barb Horse"</code>
			/// </Example>
			[FakerMethod("breed")]
			public string Breed()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.horse.breed", this)))); // Fetch
			}
			
			/// <Summary>Produces a random name for a horse.
			/// &lt;p&gt;Produces a random name for a horse&lt;/p&gt;
			/// </Summary>
			/// <Example>
			/// <code>Faker::Creature::Horse.name #=&gt; "Noir"</code>
			/// </Example>
			[FakerMethod("name")]
			public string Name()
			{
				return _faker.Translate(_faker.Numerify(_faker.Letterify(_faker.Resolve("creature.horse.name", this)))); // Fetch
			}
			
		}
	}
	public class CryptoGenerator
	{
		private Faker _faker;
	
		internal CryptoGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces an MD5 hash.</Summary>
		/// <Example>
		/// <code>Faker::Crypto.md5 #=&gt; "6b5ed240042e8a65c55ddb826c3408e6"</code>
		/// </Example>
		[FakerMethod("md5")]
		public string Md5()
		{
			/*
			
		        OpenSSL::Digest::MD5.hexdigest(Lorem.characters)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a SHA1 hash.</Summary>
		/// <Example>
		/// <code>Faker::Crypto.sha1 #=&gt; "4e99e31c51eef8b2d290e709f757f92e558a503f"</code>
		/// </Example>
		[FakerMethod("sha1")]
		public string Sha1()
		{
			/*
			
		        OpenSSL::Digest::SHA1.hexdigest(Lorem.characters)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a SHA256 hash.</Summary>
		/// <Example>
		/// <code>Faker::Crypto.sha256 #=&gt; "51e4dbb424cd9db1ec5fb989514f2a35652ececef33f21c8dd1fd61bb8e3929d"</code>
		/// </Example>
		[FakerMethod("sha256")]
		public string Sha256()
		{
			/*
			
		        OpenSSL::Digest::SHA256.hexdigest(Lorem.characters)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a SHA512 hash.</Summary>
		/// <Example>
		/// <code>Faker::Crypto.sha512 #=&gt; "7b9fc82a6642874833d01b74a7b4fae3d15373193b55cfba47327f8f0afdc8d0ea155b58639a03a887009ef997dab8dd8d36767620d430f6e787e5996e26da80"</code>
		/// </Example>
		[FakerMethod("sha512")]
		public string Sha512()
		{
			/*
			
		        OpenSSL::Digest::SHA512.hexdigest(Lorem.characters)
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
	}
	public class CryptoCoinGenerator
	{
		private Faker _faker;
	
		internal CryptoCoinGenerator(Faker faker)
		{
			_faker = faker;
		}
	
		/// <Summary>Produces a random crypto coin acronym.</Summary>
		/// <Example>
		/// <code>Faker::CryptoCoin.acronym #=&gt; "BTC"</code>
		/// </Example>
		[FakerMethod("acronym")]
		public string Acronym()
		{
			/*
			(coin: coin_array)
		        coin[ACRONYM]
		      
			*/
			throw new NotSupportedException("Needs porting");
		}
		
		/// <Summary>Produces a random crypto coin's name, acronym and logo in an array.</Summary>
		/// <Example>
		/// <code>Faker::CryptoCoin.coin_array #=&gt; ["Dash", "DASH", "https://i.imgur.com/2uX91cb.png"]</code>
		/// </Example>
		[FakerMethod("coin_array")]
		public List<string> CoinArray()
		{
