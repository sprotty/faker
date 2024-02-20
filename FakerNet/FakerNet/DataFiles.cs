using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    public class EnFile
    {
        private string _file;
        private string _path;

        private EnFile(string file)
            : this(file, file.ReplaceFirst(".yml", ""))
        {

        }

        private EnFile(string file, string path)
        {
            this._file = file;
            this._path = path;
        }


        public string getFile()
        {
            return _file;
        }

        public string getPath()
        {
            return _path;
        }

        public override string ToString()
        {
            return _file;
        }

        private static string[] GetYamlFiles()
        {
            string resourcePath = "FakerNet.Resources.en.";
            string[] names = typeof(EnFile).Assembly.GetManifestResourceNames();
            //Stream? stream = Assembly.GetManifestResourceStream(resourceName);
            //return stream == null ? null : new StreamReader(stream);
            return names.Where(n => n.StartsWith(resourcePath))
                        .Select(n => n.Substring(resourcePath.Length))
                        .ToArray();
        }

        //private static string[] FILES = GetYamlFiles();
        //    //new[] {
        //    //    "address.yml",
        //    //    "ancient.yml",
        //    //    "animal.yml",
        //    //    "app.yml",
        //    //    "appliance.yml",
        //    //    "aqua_teen_hunger_force.yml",
        //    //    "artist.yml",
        //    //    "aviation.yml",
        //    //    "back_to_the_future.yml",
        //    //    "barcode.yml",
        //    //    "bank.yml",
        //    //    "basketball.yml",
        //    //    "beer.yml",
        //    //    "bojack_horseman.yml",
        //    //    "book.yml",
        //    //    "bossa_nova.yml",
        //    //    "breaking_bad.yml",
        //    //    "buffy.yml",
        //    //    "business.yml",
        //    //    "cannabis.yml",
        //    //    "chuck_norris.yml",
        //    //    "code.yml",
        //    //    "coffee.yml",
        //    //    "coin.yml",
        //    //    "color.yml",
        //    //    "commerce.yml",
        //    //    "community.yml",
        //    //    "company.yml",
        //    //    "compass.yml",
        //    //    "construction.yml",
        //    //    "cosmere.yml",
        //    //    "country.yml",
        //    //    "crypto_coin.yml",
        //    //    "currency.yml",
        //    //    "dc_comics.yml",
        //    //    "demographic.yml",
        //    //    "dessert.yml",
        //    //    "device.yml",
        //    //    "disease.yml",
        //    //    "dota.yml",
        //    //    "dr_who.yml",
        //    //    "dragon_ball.yml",
        //    //    "dumb_and_dumber.yml",
        //    //    "dune.yml",
        //    //    "educator.yml",
        //    //    "elder_scrolls.yml",
        //    //    "electrical_components.yml",
        //    //    "esport.yml",
        //    //    "englandfootball.yml",
        //    //    "fallout.yml",
        //    //    "family_guy.yml",
        //    //    "famous_last_words.yml",
        //    //    "file.yml",
        //    //    "finance.yml",
        //    //    "food.yml",
        //    //    "football.yml",
        //    //    "fresh_prince_of_bel_air.yml",
        //    //    "friends.yml",
        //    //    "funny_name.yml",
        //    //    "game_of_thrones.yml",
        //    //    "gender.yml",
        //    //    "ghostbusters.yml",
        //    //    "grateful_dead.yml",
        //    //    "greek_philosophers.yml",
        //    //    "hacker.yml",
        //    //    "half_life.yml",
        //    //    "harry_potter.yml",
        //    //    "heroes.yml",
        //    //    "heroes_of_the_storm.yml",
        //    //    "hey_arnold.yml",
        //    //    "hipster.yml",
        //    //    "hitchhikers_guide_to_the_galaxy.yml",
        //    //    "hobbit.yml",
        //    //    "house.yml",
        //    //    "how_i_met_your_mother.yml",
        //    //    "id_number.yml",
        //    //    "industry_segments.yml",
        //    //    "internet.yml",
        //    //    "invoice.yml",
        //    //    "job.yml",
        //    //    "kpop.yml",
        //    //    "lebowski.yml",
        //    //    "lord_of_the_rings.yml",
        //    //    "lorem.yml",
        //    //    "lovecraft.yml",
        //    //    "markdown.yml",
        //    //    "marketing.yml",
        //    //    "matz.yml",
        //    //    "measurement.yml",
        //    //    "medical.yml",
        //    //    "michael_scott.yml",
        //    //    "military.yml",
        //    //    "most_interesting_man_in_the_world.yml",
        //    //    "movie.yml",
        //    //    "mountain.yml",
        //    //    "music.yml",
        //    //    "myst.yml",
        //    //    "name.yml",
        //    //    "nation.yml",
        //    //    "nato_phonetic_alphabet.yml",
        //    //    "new_girl.yml",
        //    //    "one_piece.yml",
        //    //    "overwatch.yml",
        //    //    "parks_and_rec.yml",
        //    //    "phish.yml",
        //    //    "phone_number.yml",
        //    //    "photography.yml",
        //    //    "pokemon.yml",
        //    //    "princess_bride.yml",
        //    //    "programming_language.yml",
        //    //    "relationship.yml",
        //    //    "restaurant.yml",
        //    //    "rick_and_morty.yml",
        //    //    "robin.yml",
        //    //    "rock_band.yml",
        //    //    "rupaul.yml",
        //    //    "science.yml",
        //    //    "seinfeld.yml",
        //    //    "shakespeare.yml",
        //    //    "silicon_valley.yml",
        //    //    "simpsons.yml",
        //    //    "singular_siegler.yml",
        //    //    "sip.yml",
        //    //    "slack_emoji.yml",
        //    //    "sonic_the_hedgehog.yml",
        //    //    "source.yml",
        //    //    "south_park.yml",
        //    //    "space.yml",
        //    //    "starcraft.yml",
        //    //    "star_trek.yml",
        //    //    "star_wars.yml",
        //    //    "stargate.yml",
        //    //    "stock.yml",
        //    //    "stranger_thing.yml",
        //    //    "stripe.yml",
        //    //    "subscription.yml",
        //    //    "super_smash_bros.yml",
        //    //    "superhero.yml",
        //    //    "sword_art_online.yml",
        //    //    "team.yml",
        //    //    "the_expanse.yml",
        //    //    "the_it_crowd.yml",
        //    //    "the_thick_of_it.yml",
        //    //    "twin_peaks.yml",
        //    //    "umphreys_mcgee.yml",
        //    //    "university.yml",
        //    //    "v_for_vendetta.yml",
        //    //    "vehicle.yml",
        //    //    "venture_bros.yml",
        //    //    "verbs.yml",
        //    //    "weather.yml",
        //    //    "witcher.yml",
        //    //    "kaamelott.yml",
        //    //    "world_cup.yml",
        //    //    "world_of_warcraft.yml",
        //    //    "yoda.yml",
        //    //    "zelda.yml"};

        // files where the search path can't be derived from the filename
        private static EnFile[] FILES_WITH_A_DIFFERENT_PATH = new[] {
                new EnFile("the_kingkiller_chronicle.yml", "books"),
                new EnFile("animal.yml", "creature"),
                new EnFile("bird.yml", "creature"),
                new EnFile("cat.yml", "creature"),
                new EnFile("dog.yml", "creature"),
                new EnFile("horse.yml", "creature"),
                new EnFile("clash_of_clans.yml", "games"),
                new EnFile("control.yml", "games"),
                new EnFile("dota.yml", "games"),
                new EnFile("fallout.yml", "games"),
                new EnFile("final_fantasy_xiv.yml", "games"),
                new EnFile("half_life.yml", "games"),
                new EnFile("league_of_legends.yml", "games"),
                new EnFile("minecraft.yml", "games"),
                new EnFile("myst.yml", "games"),
                new EnFile("overwatch.yml", "games"),
                new EnFile("pokemon.yml", "games"),
                new EnFile("sonic_the_hedgehog.yml", "games"),
                new EnFile("street_fighter.yml", "games"),
                new EnFile("super_mario.yml", "games"),
                new EnFile("super_smash_bros.yml", "games"),
                new EnFile("touhou.yml", "games"),
                new EnFile("warhammer_fantasy.yml", "games"),
                new EnFile("witcher.yml", "games"),
                new EnFile("world_of_warcraft.yml", "games"),
                new EnFile("zelda.yml", "games"),
                new EnFile("elder_scrolls.yml", "games"),
                new EnFile("phone_number.yml", "cell_phone") }; // load phone number again with a differen path


        public static EnFile[] AllFiles { get; } = GetYamlFiles().Select(f => new EnFile(f)).Concat(FILES_WITH_A_DIFFERENT_PATH).ToArray();
        //{
        //    List<EnFile> files = new List<EnFile>();
        //    foreach (string file in FILES)
        //    {
        //        files.Add(new EnFile(file));
        //    }
        //    files.AddRange(FILES_WITH_A_DIFFERENT_PATH);

        //    return files;
        //}
    }
}
