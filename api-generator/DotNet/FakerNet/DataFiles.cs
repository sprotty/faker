using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakerNet
{
    public class EnFile
    {
        

        private EnFile(string yamlFilename)
            : this(yamlFilename, yamlFilename.ReplaceFirst(".yml", ""))
        {

        }

        private EnFile(string yamlFilename, string category)
        {
            this.YamlFilename = yamlFilename;
            this.Category = category;
        }


        public string YamlFilename { get; }
        public string Category { get; }

        public override string ToString()
        {
            return YamlFilename;
        }

        private static string[] GetYamlFiles()
        {
            string resourcePath = "FakerNet.Resources.en.";
            string[] names = typeof(EnFile).Assembly.GetManifestResourceNames();
            return names.Where(n => n.StartsWith(resourcePath))
                        .Select(n => n.Substring(resourcePath.Length))
                        .ToArray();
        }

        // files where the search path can't be derived from the filename
        private static EnFile[] FILES_WITH_A_DIFFERENT_PATH = new[] {
            new EnFile("animal.yml", "creature"),
            new EnFile("bird.yml", "creature"),
            new EnFile("cat.yml", "creature"),
            new EnFile("clash_of_clans.yml", "games"),
            new EnFile("control.yml", "games"),
            new EnFile("dog.yml", "creature"),
            new EnFile("dota.yml", "games"),
            new EnFile("elder_scrolls.yml", "games"),
            new EnFile("fallout.yml", "games"),
            new EnFile("final_fantasy_xiv.yml", "games"),
            new EnFile("fresh_prince_of_bel_air.yml", "the_fresh_prince_of_bel_air"),
            new EnFile("half_life.yml", "games"),
            new EnFile("horse.yml", "creature"),
            new EnFile("jack_handey.yml", "quote"),
            new EnFile("league_of_legends.yml", "games"),
            new EnFile("minecraft.yml", "games"),
            new EnFile("mitch_hedberg.yml", "quote"),
            new EnFile("myst.yml", "games"),
            new EnFile("overwatch.yml", "games"),
            new EnFile("pokemon.yml", "games"),
            new EnFile("sonic_the_hedgehog.yml", "games"),
            new EnFile("stranger_thing.yml", "stranger_things"),
            new EnFile("street_fighter.yml", "games"),
            new EnFile("super_mario.yml", "games"),
            new EnFile("super_smash_bros.yml", "games"),
            new EnFile("the_kingkiller_chronicle.yml", "books"),
            new EnFile("touhou.yml", "games"),
            new EnFile("warhammer_fantasy.yml", "games"),
            new EnFile("witcher.yml", "games"),
            new EnFile("world_of_warcraft.yml", "games"),
            new EnFile("zelda.yml", "games"),

                //new EnFile("the_kingkiller_chronicle.yml", "books"),
                //new EnFile("animal.yml", "creature"),
                //new EnFile("bird.yml", "creature"),
                //new EnFile("cat.yml", "creature"),
                //new EnFile("dog.yml", "creature"),
                //new EnFile("horse.yml", "creature"),
                //new EnFile("cosmere.yml", "games"),
                //new EnFile("clash_of_clans.yml", "games"),
                //new EnFile("control.yml", "games"),
                //new EnFile("dota.yml", "games"),
                //new EnFile("fallout.yml", "games"),
                //new EnFile("final_fantasy_xiv.yml", "games"),
                //new EnFile("half_life.yml", "games"),
                //new EnFile("league_of_legends.yml", "games"),
                //new EnFile("minecraft.yml", "games"),
                //new EnFile("myst.yml", "games"),
                //new EnFile("overwatch.yml", "games"),
                //new EnFile("pokemon.yml", "games"),
                //new EnFile("sonic_the_hedgehog.yml", "games"),
                //new EnFile("street_fighter.yml", "games"),
                //new EnFile("super_mario.yml", "games"),
                //new EnFile("super_smash_bros.yml", "games"),
                //new EnFile("touhou.yml", "games"),
                //new EnFile("warhammer_fantasy.yml", "games"),
                //new EnFile("witcher.yml", "games"),
                //new EnFile("world_of_warcraft.yml", "games"),
                //new EnFile("zelda.yml", "games"),
                //new EnFile("elder_scrolls.yml", "games"),
                //new EnFile("michael_scott.yml", "tv_shows"),
                //new EnFile("jack_handey.yml", "quote"),
                //new EnFile("phone_number.yml", "cell_phone") 
        }; // load phone number again with a differen path

        /*
                 private static EnFile[] FILES_WITH_A_DIFFERENT_PATH = new[] {







            new EnFile("fr/animal.yml", "creature"),
            new EnFile("fr/pokemon.yml", "games"),
            new EnFile("ja/animal.yml", "creature"),
            new EnFile("ja/cat.yml", "creature"),
            new EnFile("ja/dog.yml", "creature"),
            new EnFile("ja/overwatch.yml", "games"),
            new EnFile("ja/pokemon.yml", "games"),
            new EnFile("ja/super_mario.yml", "games"),
            new EnFile("ja/super_smash_bros.yml", "games"),
            new EnFile("ja/touhou.yml", "games"),
            new EnFile("ja/zelda.yml", "games"),
        };
         */

        public static EnFile[] AllFiles { get; } = GetYamlFiles().Select(f => new EnFile(f)).Concat(FILES_WITH_A_DIFFERENT_PATH).ToArray();
     }
}
