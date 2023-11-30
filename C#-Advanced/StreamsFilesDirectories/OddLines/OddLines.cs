namespace OddLines
{
    using System;
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
            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }
                    counter++;
                }
                reader.Close();
                writer.Close();
            }
        }
    }
}
