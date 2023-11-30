namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);

            int num = 1;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                writer.WriteLine($"{num++}. {line}");
            }
            
            reader.Close();
            writer.Close();
        }
    }
}
