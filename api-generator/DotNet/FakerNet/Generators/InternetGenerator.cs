using System.Globalization;
using System.CodeDom.Compiler;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace FakerNet
{
    partial class InternetGenerator
    {
        private static IntegerRange[][] PrivateIP4AddressRanges = [
            [new IntegerRange(10, 10), new IntegerRange(0, 255), new IntegerRange(0, 255), new IntegerRange(1, 255)],       // 10.0.0.0/8     - Used for local communications within a private network
            [new IntegerRange(100, 100), new IntegerRange(64, 127), new IntegerRange(0, 255), new IntegerRange(1, 255)],    // 100.64.0.0/10  - Shared address space for communications between an ISP and its subscribers
            [new IntegerRange(127, 127), new IntegerRange(0, 255), new IntegerRange(0, 255), new IntegerRange(1, 255)],     // 127.0.0.0/8    - Used for loopback addresses to the local host
            [new IntegerRange(169, 169), new IntegerRange(254, 254), new IntegerRange(0, 255), new IntegerRange(1, 255)],   // 169.254.0.0/16 - Used for link-local addresses between two hosts on a single link when
            [new IntegerRange(172, 172), new IntegerRange(16, 31), new IntegerRange(0, 255), new IntegerRange(1, 255)],     // 172.16.0.0/12  - Used for local communications within a private network
            [new IntegerRange(192, 192), new IntegerRange(0, 0), new IntegerRange(0, 0), new IntegerRange(1, 255)],         // 192.0.0.0/24   - IETF Protocol Assignments
            [new IntegerRange(192, 192), new IntegerRange(168, 168), new IntegerRange(0, 255), new IntegerRange(1, 255)],   // 192.168.0.0/16 - Used for local communications within a private network
            [new IntegerRange(198, 198), new IntegerRange(18, 19), new IntegerRange(0, 255), new IntegerRange(1, 255)],     // 198.18.0.0/15  - Used for benchmark testing of inter-network communications between subnets
        ];

        /// <summary>
        /// the private network regular expressions
        /// </summary>
        private static readonly Regex[] PrivateIP4AddressRangeExpressions =
            [
                new Regex(@"^10\."),                                     // 10.0.0.0    - 10.255.255.255
                new Regex(@"^100\.(6[4-9]|[7-9]\d|1[0-1]\d|12[0-7])\."), // 100.64.0.0  - 100.127.255.255
                new Regex(@"^127\."),                                    // 127.0.0.0   - 127.255.255.255
                new Regex(@"^169\.254\."),                               // 169.254.0.0 - 169.254.255.255
                new Regex(@"^172\.(1[6-9]|2\d|3[0-1])\."),               // 172.16.0.0  - 172.31.255.255
                new Regex(@"^192\.0\.0\."),                              // 192.0.0.0   - 192.0.0.255
                new Regex(@"^192\.168\."),                               // 192.168.0.0 - 192.168.255.255
                new Regex(@"^198\.(1[8-9])\.")                           // 198.18.0.0  - 198.19.255.255
            ];

        /// <summary>
        /// the reserved network regular expressions
        /// </summary>
        private static readonly Regex[] ReservedIP4AddressRangeExpressions =
            [
                new Regex(@"^0\."),               // 0.0.0.0      - 0.255.255.255
                new Regex(@"^192\.0\.2\."),         // 192.0.2.0    - 192.0.2.255
                new Regex(@"^192\.88\.99\."),       // 192.88.99.0  - 192.88.99.255
                new Regex(@"^198\.51\.100\."),      // 198.51.100.0 - 198.51.100.255
                new Regex(@"^203\.0\.113\."),       // 203.0.113.0  - 203.0.113.255
                new Regex(@"^(22[4-9]|23\d)\."),    // 224.0.0.0    - 239.255.255.255
                new Regex(@"^(24\d|25[0-5])\.")     // 240.0.0.0    - 255.255.255.254  and  255.255.255.255
            ];


        #region Base64
        /// <summary>
        /// Produces a random string of alphabetic characters, (no digits).
        /// </summary>
        /// <param name="length">
        /// The length of the string to generate
        /// (default value "16")
        /// </param>
        /// <param name="padding">
        /// Toggles if a final equal ‘=’ will be added.
        /// (default value "false")
        /// </param>
        /// <param name="urlsafe">
        /// Toggles charset to ‘-’ and ‘_’ instead of ‘+’ and ‘/’.
        /// (default value "true")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.base64
        /// #=> "r_hbZ2DSD-ZACzZT"</code>
        /// </example>
        [FakerMethod("base64")]
        public string Base64(long length = 16, bool padding = false, bool urlsafe = true)
        {
            int safeLength = (int)(length % 4 == 1 ? length + 1 : length);
            IEnumerable<char> chars = DataGenerator.StringGenerator.AlpahNumeric;
            if (urlsafe)
                chars = chars.Append('-').Append('_');
            else
                chars = chars.Append('+').Append('/');
            char[] charArray = chars.ToArray();

            string base64 = string.Concat(Enumerable.Range(0, safeLength).Select(i => Random.NextItem(charArray)));
            if (padding)
                base64 += new string('=', 4 - safeLength % 4);
            return base64;
        }
        #endregion

        #region BotUserAgent
        /// <summary>
        /// Generate Web Crawler's user agents.
        /// </summary>
        /// <param name="vendor">
        /// Name of vendor, supported vendors are googlebot, bingbot, duckduckbot, baiduspider, yandexbot
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.bot_user_agent                        #=> "Mozilla/5.0 (compatible; YandexBot/3.0; +http://yandex.com/bots)"
        /// Faker::Internet.bot_user_agent(vendor: 'googlebot')   #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; Googlebot/2.1; +http://www.google.com/bot.html) Chrome/99.0.4844.84 Safari/537.36"
        /// Faker::Internet.bot_user_agent(vendor: 'bingbot')     #=> "Mozilla/5.0 AppleWebKit/537.36 (KHTML, like Gecko; compatible; bingbot/2.0; +http://www.bing.com/bingbot.htm) Chrome/86.0.4240.68 Safari/537.36 Edg/86.0.622.31"</code>
        /// </example>
        [FakerMethod("bot_user_agent")]
        public string BotUserAgent(string? vendor = null)
        {
            var agentDic = Faker.FetchYamlMap("internet.bot_user_agent");
            var agents = (List<object>)(vendor != null ? agentDic[vendor] : Random.NextItem(agentDic));
            return (string)Random.NextItem(agents);
        }
        #endregion


#warning Failed processing method device_token

        /// <summary>
        /// Returns the domain name.
        /// </summary>
        /// <param name="subdomain">
        /// If true passed adds a subdomain in response
        /// (default value "false")
        /// </param>
        /// <param name="domain">
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.domain_name                                             #=> "altenwerth-gerhold.example"
        /// Faker::Internet.domain_name(subdomain: true)                                  #=> "metz.mclaughlin-brekke.test"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker')                 #=> "foo.faker.test"
        /// Faker::Internet.domain_name(domain: 'faker-ruby.org')                         #=> "faker-ruby.org"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker-ruby.org')        #=> "foo.faker-ruby.org"
        /// Faker::Internet.domain_name(subdomain: true, domain: 'faker.faker-ruby.org')  #=> "faker.faker-ruby.org"</code>
        /// </example>
        [FakerMethod("domain_name")]
        public string DomainName(bool subdomain = false, string? domain = null)
        {
            List<string> domainBits = new List<string>();
            if (string.IsNullOrWhiteSpace(domain))
            {
                if (subdomain)
                    domainBits.Add(DomainWord());
                domainBits.Add(DomainWord());
                domainBits.Add(DomainSuffix(false));
            }
            else
            {
                domainBits.AddRange(domain.Split('.'));

                if (domainBits.Count < 2)
                    domainBits.Add(DomainSuffix(false));

                if (subdomain && domainBits.Count < 3)
                    domainBits.Insert(0, DomainWord());
            }
            return string.Join(".", domainBits);
        }

        // Expecting native implementation of
        //      public string DomainName(bool subdomain = false, string? domain = null)
        /// <summary>
        /// Returns the domain suffix e.g.
        /// com, org, co, biz, info etc.
        /// </summary>
        /// <param name="safe">Returns a 'safe' domain - one that wont get annoyed if you aim random traffic at it.</param>
        /// <example>
        /// <code>Faker::Internet.domain_suffix              #=> "com"
        /// Faker::Internet.domain_suffix              #=> "biz"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "example"
        /// Faker::Internet.domain_suffix(safe: true)  #=> "test"</code>
        /// </example>
        [FakerMethod("domain_suffix")]
        public string DomainSuffix(bool safe = false)
        {
            if (safe)
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("internet.safe_domain_suffix"))));
            else
                return this.Translate(this.Numerify(this.Letterify(this.ResolveYamlValue("internet.domain_suffix"))));
        }

        #region DomainWord
        /// <summary>
        /// Returns the domain word for internet.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.domain_word   #=> "senger"</code>
        /// </example>
        [FakerMethod("domain_word")]
        public string DomainWord()
        {
            string validChars = DataGenerator.StringGenerator.AlpahNumeric + "_-";

            string word = FakerEn.Commerce.Company.Name(); // in some locales these are not allowable chars for a domain....

            word = string.Concat(
                        word
                            .Split(new char[] { ' ', '\t' })
                            .First()
                            .Select(c => validChars.Contains(c) ? c : '_'));

            while (word.EndsWith('_'))
                word = word.RemoveTrailing('_');

            // fallback when the names are not allowable domain names
            if (word.Length < 3)
                word = Faker.Internet.DomainSuffix(false);
            return word;
        }
        #endregion

        #region Email
        /// <summary>
        /// Returns the email address.
        /// </summary>
        /// <param name="name">
        /// (default value "nil")
        /// </param>
        /// <param name="separators">
        /// A string containing allowable separators within the email address (i.e. '-_')
        /// (default value "'-_'")
        /// </param>
        /// <param name="domain">
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.email                                                           #=> "renee@zieme.test"
        /// Faker::Internet.email(name: 'smith')                                            #=> "smith@bergnaum.test"
        /// Faker::Internet.email(name: 'sam smith', separators: ['-'])                     #=> "smith-sam@tromp.example"
        /// Faker::Internet.email(name: 'sam smith', separators: ['-'], domain: 'test')     #=> "sam-smith@test.example"
        /// Faker::Internet.email(domain: 'gmail.com')                                      #=> "foo@gmail.com"</code>
        /// </example>
        [FakerMethod("email")]
        public string Email(string? name = null, string separators = "-_", string? domain = null)
        {
            string namePart;
            string domainPart;
            
            string separator = separators == null || separators.Length == 0 ? "" : Random.NextItem(separators).ToString();
            char[] validEmailNameChars = (DataGenerator.StringGenerator.AlpahNumeric + "!#$%&'*+-/=?^_`{|}~.").ToCharArray();

            if (string.IsNullOrWhiteSpace(name))
                namePart = Username(new IntegerRange(5, 15), separator);
            else
                namePart = name.Replace(" ", separator);

            namePart = string.Concat(namePart.Select(c => validEmailNameChars.Contains(c) ? c : '#'));

            if (string.IsNullOrWhiteSpace(domain))
                domainPart = DomainName();
            else
                domainPart = domain.Replace(" ", separator);

            return namePart + "@" + domainPart;
        }
        #endregion

#warning No implementation defined for method fix_umlauts(string @string = "");


        #region Password
        /// <summary>
        /// Produces a randomized string of characters suitable for passwords.
        /// </summary>
        /// <param name="minLength">
        /// The minimum length of the password
        /// (default value "8")
        /// </param>
        /// <param name="maxLength">
        /// The maximum length of the password
        /// (default value "16")
        /// </param>
        /// <param name="mixCase">
        /// Toggles if uppercased letters are allowed. If true, at least one will be added.
        /// (default value "true")
        /// </param>
        /// <param name="specialCharacters">
        /// Toggles if special characters are allowed. If true, at least one will be added.
        /// (default value "false")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.password #=> "Vg5mSvY1UeRg7"</code>
        /// </example>
        [FakerMethod("password")]
        public string Password(long minLength = 8, long maxLength = 16, bool mixCase = true, bool specialCharacters = false)
        {
            char[] specialCharsList = ['!', '@', '#', '$', '%', '^', '&', '*'];
            if (minLength < 1) throw new ArgumentOutOfRangeException(nameof(minLength), "minLength must be greater than zero");
            if (maxLength < 1) throw new ArgumentOutOfRangeException(nameof(maxLength), "maxLength must be greater than zero");
            if (minLength > maxLength) throw new ArgumentOutOfRangeException(nameof(maxLength), "min_length must be smaller than or equal to max_length");
            List<string> character_types = new List<string>();
            int required_min_length = 0;

            if (mixCase)
            {
                character_types.Add("mixed case");
                required_min_length += 2;
            }

            if (specialCharacters)
            {
                character_types.Add("special characters");
                required_min_length += 1;
            }

            if (minLength < required_min_length)
                throw new ArgumentOutOfRangeException(nameof(minLength), $"minLength should be at least {required_min_length} to enable {string.Join(", ", character_types)} configuration");

            int target_length = Random.NextInt32((int)minLength, (int)maxLength);

            List<char> password = new();
            List<char> character_bag = new();

            // use lower_chars by default and add upper_chars if mix_case
            password.Add(Random.NextItem(DataGenerator.StringGenerator.AlphabetLower.ToCharArray()));
            character_bag.AddRange(DataGenerator.StringGenerator.AlphabetLower);

            password.Add(Random.NextItem(DataGenerator.StringGenerator.Digits.ToCharArray()));
            character_bag.AddRange(DataGenerator.StringGenerator.Digits);

            if (mixCase)
            {
                password.Add(Random.NextItem(DataGenerator.StringGenerator.AlphabetUpper.ToCharArray()));
                character_bag.AddRange(DataGenerator.StringGenerator.AlphabetUpper);
            }

            if (specialCharacters)
            {
                password.Add(Random.NextItem(specialCharsList));
                character_bag.AddRange(specialCharsList);
            }

            while (password.Count < target_length)
                password.Add(Random.NextItem(character_bag));

            //        shuffle(password).join
            return string.Concat(password);
        }
        #endregion

        #region PrivateIpV4Address
        // Expecting native implementation of
        //      public string Password(long minLength = 8, long maxLength = 16, bool mixCase = true, bool specialCharacters = false)
        /// <summary>
        /// Returns the private IPv4 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.private_ip_v4_address   #=> "127.120.80.42"</code>
        /// </example>
        [FakerMethod("private_ip_v4_address")]
        public string PrivateIpV4Address()
        {
            return string.Join(".", Random.NextItem(PrivateIP4AddressRanges).Select(r => Random.NextInt32(r).ToString(CultureInfo.InvariantCulture)));
        }
        #endregion

        #region PublicIpV4Address
        /// <summary>
        /// Returns the public IPv4 address.
        /// </summary>
        /// <example>
        /// <code>Faker::Internet.public_ip_v4_address   #=> "127.120.80.42"</code>
        /// </example>
        [FakerMethod("public_ip_v4_address")]
        public string PublicIpV4Address()
        {
            string addr;
            do
            {
                addr = IpV4Address();
            } while (reserved_net_checker(addr) == true);
            return addr;
        }
        private bool reserved_net_checker(string addr)
        {
            return PrivateIP4AddressRangeExpressions.Concat(ReservedIP4AddressRangeExpressions).Any(r => r.IsMatch(addr));
        }
        #endregion

        #region Slug
        /// <summary>
        /// Returns unique string in URL.
        /// </summary>
        /// <param name="words">
        /// Comma or period separated words list
        /// (default value "nil")
        /// </param>
        /// <param name="glue">
        /// Separator to add between words passed, default used are ‘-’ or ‘_’
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.slug                                    #=> "repudiandae-sed"
        /// Faker::Internet.slug(words: 'test, faker')              #=> "test-faker"
        /// Faker::Internet.slug(words: 'test. faker')              #=> "test-faker"
        /// Faker::Internet.slug(words: 'test. faker', glue: '$')   #=> "test$faker"</code>
        /// </example>
        [FakerMethod("slug")]
        public string Slug(string? words = null, string? glue = null)
        {
            glue ??= Random.NextItem(["-", "_"]);
            if (string.IsNullOrWhiteSpace(words))
                return string.Join(glue, [Translate(Faker.FetchYamlValue("internet.slug")), Translate(Faker.FetchYamlValue("internet.slug"))]);
            else
                return words.Replace(",", "").Replace(".", "").Replace("'", "").Replace(" ", glue).ToLower();
        }

        #endregion#warning No implementation defined for method url(string host, string path, string scheme = "http");

        #region Url
        /// <summary>
        /// Returns URL.
        /// </summary>
        /// <param name="host">
        /// </param>
        /// <param name="path">
        /// </param>
        /// <param name="scheme">
        /// (default value "'http'")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.url                                                           #=> "http://treutel.test/demarcus"
        /// Faker::Internet.url(host: 'faker')                                            #=> "http://faker/shad"
        /// Faker::Internet.url(host: 'faker', path: '/docs')                             #=> "http://faker/docs"
        /// Faker::Internet.url(host: 'faker', path: '/docs', scheme: 'https')            #=> "https://faker/docs"</code>
        /// </example>
        [FakerMethod("url")]
        public string Url(string? host = null, string? path = null, string scheme = "https")
        {
            host ??= DomainName();
            path ??= "/" + Username();
            return $"{scheme}://{host}{path}";
        }
        #endregion

        #region UserAgent
        /// <summary>
        /// Generates the random browser identifier.
        /// </summary>
        /// <param name="vendor">
        /// Name of vendor, supported vendors are aol, chrome, firefox, internet_explorer, netscape, opera, safari
        /// (default value "nil")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.user_agent                    #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        /// Faker::Internet.user_agent(vendor: 'chrome')  #=> "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36"
        /// Faker::Internet.user_agent(vendor: 'safari')  #=> "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A"
        /// Faker::Internet.user_agent(vendor: 'faker')   #=> "Mozilla/5.0 (Windows; U; Win 9x 4.90; SG; rv:1.9.2.4) Gecko/20101104 Netscape/9.1.0285"</code>
        /// </example>
        [FakerMethod("user_agent")]
        public string UserAgent(string? vendor = null)
        {
            var agent_hash = Faker.FetchYamlMap("internet.user_agent");
            var agents = (List<object>)(vendor == null ? Random.NextItem(agent_hash) : agent_hash[vendor]);
            return (string)Random.NextItem(agents);
        }
        #endregion

        #region Username
        /// <summary>
        /// Returns the username.
        /// </summary>
        /// <param name="lengthRange">
        /// When int value passed it returns the username longer than specifier. Max value can be 10^6
        /// (default value "[5..10]")
        /// </param>
        /// <param name="separators">
        /// (default value "'._'")
        /// </param>
        /// <example>
        /// <code>Faker::Internet.username(specifier: 10)                     #=> "lulu.goodwin"
        /// Faker::Internet.username(specifier: 5..10)                  #=> "morris"
        /// Faker::Internet.username(specifier: 5..10)                  #=> "berryberry"
        /// Faker::Internet.username(specifier: 20, separators: ['_'])  #=> "nikki_sawaynnikki_saway"</code>
        /// </example>
        [FakerMethod("username")]
        public string Username(IntegerRange? lengthRange = null, string separators = "._")
        {
            lengthRange ??= IntegerRange.Parse("5..10");
            var fn = FakerEn.FetchYamlList("name.male_first_name").Union(FakerEn.FetchYamlList("name.female_first_name")).OfType<string>().ToList();
            var ln = FakerEn.FetchYamlList("name.last_name").OfType<string>().ToList();

            var fnBySize = fn.GroupBy(n => n.Length).ToList();
            var lnBySize = ln.GroupBy(n => n.Length).ToList();

            int targetLen = Random.NextInt32(lengthRange);
            bool addedFirstName = false;
            bool cammelCase = Random.NextBoolean(0.1);// 10% are camel case
            char separator = separators.Length > 0 ? Random.NextItem(separators) : default(char);
            bool firstPass = true; // try to favour a value - not a number its its short


            StringBuilder userName = new StringBuilder();
            while (userName.Length <= targetLen)
            {
                int remainder = targetLen - userName.Length;
                if (firstPass == false && remainder < 4 && userName.Length >= lengthRange.Min && userName.Length <= lengthRange.Max)
                    break; // close enough
                else if (firstPass == false && remainder == 1)
                    userName.Append(Random.NextInt32(0, 9).ToString(CultureInfo.InvariantCulture));
                else if (firstPass == false && remainder == 2)
                    userName.Append(Random.NextInt32(0, 99).ToString("##", CultureInfo.InvariantCulture));
                else if (firstPass == false && remainder == 3)
                    userName.Append(Random.NextInt32(0, 999).ToString("###", CultureInfo.InvariantCulture));
                else if (firstPass == false && remainder == 4)
                    userName.Append(Random.NextInt32(1935, 2023).ToString("####", CultureInfo.InvariantCulture));
                else if (firstPass == false && Random.Next(5) == 0 && remainder == 6) // if the remainder is 6, then 1 in 5 times append a date
                {
                    userName.Append(Random.NextInt32(1, 12).ToString("##", CultureInfo.InvariantCulture));
                    userName.Append(Random.NextInt32(1935, 2023).ToString("####", CultureInfo.InvariantCulture));
                }
                else
                {
                    List<IGrouping<int, string>> lst;
                    switch (Random.Next(2))
                    {
                        case 0: lst = addedFirstName ? lnBySize : fnBySize; addedFirstName = true; break;
                        case 1: lst = lnBySize; break;
                        default: Debug.Fail("Should not get here"); break;
                    }
                    if (cammelCase == false && userName.Length > 0 && separators.Length > 0)
                        userName.Append(separator);
                    userName.Append(FindValue(fnBySize));
                }
                firstPass = false;
            }

            return userName.ToString();

            string FindValue(List<IGrouping<int, string>> grp)
            {
                int maxLen = (int)lengthRange.Max - userName.Length;
                var filteredList = grp.Where(g => g.Key <= maxLen).ToList();
                if (filteredList.Count == 0)
                    return "";
                string value = Random.NextItem(Random.NextItem(filteredList)).ToLower();
                if (cammelCase)
                    value = value.FirstLetterToUpper();
                return value;
            }
        }
        #endregion
    }
}
