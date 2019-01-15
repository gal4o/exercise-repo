using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._2.BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> output = 
                new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                Book book = new Book()
                {
                    //Title = line[0],
                    Autor = line[1],
                    //Publisher = line[2],
                    //Release = line[3],
                    //ISBN = line[4],
                    Price = double.Parse(line[5])
                };
                if (output.ContainsKey(book.Autor))
                {
                    output[book.Autor] += book.Price;
                }
                else
                {
                    output.Add(book.Autor, book.Price);
                }
            }
            output = output.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");                
            }
        }
    }
    class Book
    {
        //public string Title { get; set; }
        public string Autor { get; set; }
        //public string Publisher { get; set; }
        //public string Release { get; set; }
        //public string ISBN { get; set; }
        public double Price { get; set; }
    }
}
