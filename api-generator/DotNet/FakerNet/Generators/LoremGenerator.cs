using System.CodeDom.Compiler;
using System.Text;

namespace FakerNet
{
    partial class DataGenerator
    {
        partial class LoremGenerator
        {
            /// <summary>
            /// Generates three sentence paragraph.
            /// </summary>
            /// <param name="sentenceCount">
            /// Number of sentences in the paragraph
            /// (default value "3")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomSentencesToAdd">
            /// A random number of sentences, less than or equal to this, are added to the paragraph.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.paragraph
            /// #=> "Impedit et est. Aliquid deleniti necessitatibus. Et aspernatur minima."
            /// Faker::Lorem.paragraph(sentence_count: 2)
            /// #=> "Rerum fugit vitae. Et atque autem."
            /// Faker::Lorem.paragraph(sentence_count: 2, supplemental: true)
            /// #=> "Terreo coerceo utor. Vester sunt cogito."
            /// Faker::Lorem.paragraph(sentence_count: 2, supplemental: true, random_sentences_to_add: 2)
            /// #=> "Texo tantillus tamisium. Tribuo amissio tamisium. Facere aut canis."</code>
            /// </example>
            [FakerMethod("paragraph")]
            public string Paragraph(long sentenceCount = 3, bool supplemental = false, long randomSentencesToAdd = 0, string? excludeWords = null)
            {
                int actualSentenceCount = (int)sentenceCount + Random.NextInt32(0, (int)randomSentencesToAdd);
                return string.Join(LocaleSpace(), Enumerable.Range(0, actualSentenceCount).Select(_ => Sentence(2, supplemental, 10, excludeWords)));
            }

            /// <summary>
            /// Generates paragraph with 256 characters.
            /// </summary>
            /// <param name="charCount">
            /// The number of characters in the paragraph
            /// (default value "256 ")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.paragraph_by_chars
            /// Faker::Lorem.paragraph_by_chars(number: 20)                       #=> "Sit modi alias. Imp."
            /// Faker::Lorem.paragraph_by_chars(number: 20, supplemental: true)   #=> "Certus aveho admove."</code>
            /// </example>
            [FakerMethod("paragraph_by_chars")]
            public string ParagraphByChars(long charCount = 256, bool supplemental = false)
            {
                StringBuilder sb = new StringBuilder();
                while (sb.Length < charCount)
                {
                    sb.Append(Sentence(2, supplemental, 15));
                }
                return sb.ToString().Substring(0, (int)charCount);
            }

            /// <summary>
            /// Returns the question with 4 words.
            /// </summary>
            /// <param name="wordCount">
            /// How many words should be there in a sentence
            /// (default value "5")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomWordsToAdd">
            /// A random number of words, less than or equal to this, are added to the word count.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.question                                                               #=> "Natus deleniti sequi laudantium?"
            /// Faker::Lorem.question(word_count: 2)                                                #=> "Quo ut?"
            /// Faker::Lorem.question(word_count: 2, supplemental: true)                            #=> "Terga consequatur?"
            /// Faker::Lorem.question(word_count: 2, supplemental: true, random_words_to_add: 2)    #=> "Depulso uter ut?"</code>
            /// </example>
            [FakerMethod("question")]
            public string Question(long wordCount = 5, bool supplemental = false, long randomWordsToAdd = 0, string? excludeWords = null)
            {
                return Sentence(wordCount, supplemental, randomWordsToAdd, excludeWords) + LocaleQuestionMark();
            }

            /// <summary>
            /// Generates sentence.
            /// </summary>
            /// <param name="wordCount">
            /// How many words should be there in a sentence
            /// (default value "4")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="randomWordsToAdd">
            /// A random number of words, less than or equal to this, are added to the word count.
            /// (default value "0")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.sentence                                                             #=> "Magnam qui aut quidem."
            /// Faker::Lorem.sentence(word_count: 5)                                              #=> "Voluptas rerum aut aliquam velit."
            /// Faker::Lorem.sentence(word_count: 5, supplemental: true)                          #=> "Aut viscus curtus votum iusto."
            /// Faker::Lorem.sentence(word_count: 5, supplemental: true, random_words_to_add:2)   #=> "Crinis quo cruentus velit animi vomer."</code>
            /// </example>
            [FakerMethod("sentence")]
            public string Sentence(long wordCount = 4, bool supplemental = false, long randomWordsToAdd = 0, string? excludeWords = null)
            {
                return string.Join(LocaleSpace(), Words(wordCount + Random.NextInt32(0, (int)randomWordsToAdd), supplemental, excludeWords)).FirstLetterToUpper() + LocalePeriod();
            }

            /// <summary>
            /// Generates 3 random lorem words.
            /// </summary>
            /// <param name="wordCount">
            /// Number of words to be generated
            /// (default value "3")
            /// </param>
            /// <param name="supplemental">
            /// Whether to include supplemental lorem words
            /// (default value "false")
            /// </param>
            /// <param name="excludeWords">
            /// A list of comma separated words that should not be used
            /// (default value "nil")
            /// </param>
            /// <example>
            /// <code>Faker::Lorem.words                                    #=> ["hic", "quia", "nihil"]
            /// Faker::Lorem.words(number: 4)                         #=> ["est", "temporibus", "et", "quaerat"]
            /// Faker::Lorem.words(number: 4, supplemental: true)    #=> ["nisi", "sit", "allatus", "consequatur"]
            /// Faker::Lorem.words(number: 4, supplemental: true, exclude_words: 'sit') #=> ["nisi", "allatus", "consequatur", "aut"]</code>
            /// </example>
            [FakerMethod("words")]
            public string Words(long wordCount = 3, bool supplemental = false, string? excludeWords = null)
            {
                string[] excludeWordList = (excludeWords ?? "").Split(',').Select(s => s.Trim()).ToArray();

                var wordsExpr = this.Faker.FetchYamlList("lorem.words").OfType<string>();
                if (supplemental)
                    wordsExpr = wordsExpr.Concat(this.Faker.FetchYamlList("lorem.supplemental").OfType<string>());

                var wordsList = wordsExpr.Select(w => Translate(w)).Except(excludeWordList).ToList();
                return string.Join(" ", Enumerable.Range(0, (int)wordCount).Select(i => Random.NextItem(wordsList)));
            }
        }
    }
}