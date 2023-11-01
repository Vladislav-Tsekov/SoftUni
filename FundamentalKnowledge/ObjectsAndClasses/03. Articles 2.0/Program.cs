

namespace _03._Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            int cmdCnt = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < cmdCnt; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author)
                { 
                    Title = title,
                    Content = content,
                    Author = author,
                };

                articles.Add(article);


                    Console.WriteLine(article);

            }


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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}