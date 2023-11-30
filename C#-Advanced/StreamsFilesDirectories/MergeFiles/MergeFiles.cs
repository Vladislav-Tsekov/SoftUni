namespace MergeFiles
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Linq;

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
            StreamReader readerOne = new StreamReader(firstInputFilePath);
            StreamReader readerTwo = new StreamReader(secondInputFilePath);
            Queue queue1 = new Queue();
            Queue queue2 = new Queue();

            string currentLine1 = string.Empty;
            while ((currentLine1 = readerOne.ReadLine()) != null)
                queue1.Enqueue(currentLine1);
                
            string currentLine2 = string.Empty;
            while ((currentLine2 = readerTwo.ReadLine()) != null)
                queue2.Enqueue(currentLine2);

            readerOne.Close();
            readerTwo.Close();

            StreamWriter writer = new StreamWriter(outputFilePath);

            if (queue1.Count > queue2.Count)
            {
                for (int i = 0; i < queue2.Count; i++)
                {
                    writer.WriteLine(queue1.Dequeue());
                    writer.WriteLine(queue2.Dequeue());
                }
                while (queue1.Count > 0)
                    writer.WriteLine(queue1.Dequeue());
            }
            else if (queue1.Count == queue2.Count) 
            {
                for (int i = 0; i < queue2.Count; i++)
                {
                    writer.WriteLine(queue1.Dequeue());
                    writer.WriteLine(queue2.Dequeue());
                }
            }
            else
            {
                for (int i = 0; i < queue1.Count; i++)
                {
                    writer.WriteLine(queue1.Dequeue());
                    writer.WriteLine(queue2.Dequeue());
                }
                while (queue2.Count > 0)
                    writer.WriteLine(queue2.Dequeue());
            }

            writer.Close();
        }
    }
}
