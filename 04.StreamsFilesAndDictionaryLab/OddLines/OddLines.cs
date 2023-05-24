namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using StreamReader streamReader = new StreamReader(inputFilePath);
            using StreamWriter streamWriter = new StreamWriter(outputFilePath);
            int counter = 0;
            string line = streamReader.ReadLine();
            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    streamWriter.WriteLine(line);

                }
                counter++;
                line = streamReader.ReadLine();
            }

        }
    }
}
