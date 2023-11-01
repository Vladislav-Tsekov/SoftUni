

namespace _02._Articles
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string title = input[0];
            string content = input[1];
            string author = input[2];

            Article article = new Article (title, content, author);

            int cmdCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdCnt; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string argument = cmdArgs[0];
                string change = cmdArgs[1];

                if (argument == "Edit")
                {
                    article.Edit(change);
                }
                else if (argument == "ChangeAuthor")
                {
                    article.ChangeAuthor(change);
                }
                else
                {
                    article.Rename(change);
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author) 
        {
            Title = title;
            Content = content;
            Author = author;
        } 

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) 
        {
            Content = content;
        }
        public void ChangeAuthor(string author) 
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString() 
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}