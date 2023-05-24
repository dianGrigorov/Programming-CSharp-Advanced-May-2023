namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using StreamReader first = new StreamReader(firstInputFilePath);
            using StreamReader second = new StreamReader(secondInputFilePath);
            using StreamWriter writer = new StreamWriter(outputFilePath);

           string firstLine = first.ReadLine();
           string secondLine = second.ReadLine();

            while (firstLine != null || secondLine != null)
            {
                if(firstLine == null)
                {
                    writer.WriteLine(secondLine);
                    secondLine = second.ReadLine();
                }
                 else if  (secondLine == null)
                {
                    writer.WriteLine(firstLine);
                    firstLine = first.ReadLine();
                }
                else
                {
                    writer.WriteLine(firstLine);
                    writer.WriteLine(secondLine);
                    firstLine = first.ReadLine();
                    secondLine = second.ReadLine();
                }
                
            }


        }
    }
}
