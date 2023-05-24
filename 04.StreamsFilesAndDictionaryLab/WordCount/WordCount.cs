namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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

           using StreamReader readWords = new StreamReader(wordsFilePath);
            char[] chars =  { ' ', '.', ',', ';', ':', '?', '-' };
            string[] words = readWords.ReadToEnd().ToLower().Split(chars);
            Dictionary<string, int> occurenseWords = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!occurenseWords.ContainsKey(word))
                {
                    occurenseWords.Add(word, 0);
                }
            }
            using StreamReader reader = new StreamReader(textFilePath);
            using StreamWriter writer = new StreamWriter(outputFilePath);

            string[] text = reader.ReadToEnd().ToLower().Split(chars);

            foreach (var word in text)
            {
                if (occurenseWords.ContainsKey(word))
                {
                    occurenseWords[word]++;
                }
            }

            foreach (var word in occurenseWords.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{word.Key} - {word.Value}");
            }
               
        }


    }
}

