namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var wordsReader = new StreamReader(wordsFilePath);
            var textReader = new StreamReader(textFilePath);

            Dictionary<string, int> wordMatchCnt = new Dictionary<string, int>();
            string[] text = textReader.ReadToEnd().ToLower().Split();
            string[] keywords = wordsReader.ReadToEnd().ToLower().Split();
            List<string> wordsFromText = new();

            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                Regex regex = new Regex("[A-Za-z]+");
                foreach (var word in text)
                {
                    Match match = regex.Match(word);
                    wordsFromText.Add(match.ToString().ToLower());
                }
                wordsFromText.TrimExcess();

                for (int i = 0; i < keywords.Length; i++)
                {
                    string currentWord = keywords[i];

                    for (int j = 0; j < wordsFromText.Count; j++)
                    {
                        string currentWordFromText = wordsFromText[j];

                        if (currentWord == currentWordFromText)
                        {
                            if (!wordMatchCnt.ContainsKey(currentWord))
                            {
                                wordMatchCnt.Add(currentWord, 0);
                                wordMatchCnt[currentWord]++;
                            }
                            else
                            {
                                wordMatchCnt[currentWord]++;
                            }
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    foreach (var item in wordMatchCnt.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
