
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05._2.BookLibraryModification
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, DateTime> output = new Dictionary<string,DateTime>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                Book book = new Book()
                {
                    Title = line[0],
                    //Autor = line[1],
                   // Publisher = line[2],
                    Release = DateTime.ParseExact
                    (line[3],"dd.MM.yyyy", CultureInfo.InvariantCulture),
                    //ISBN = line[4],
                   // Price = double.Parse(line[5])
                };
                output.Add(book.Title, book.Release);
            }
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);
            output = output
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in output)
            {
                if (item.Value>=startDate)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Day:d2}.{item.Value.Month:d2}.{item.Value.Year}");
                }
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
       // public string Autor { get; set; }
       // public string Publisher { get; set; }
        public DateTime Release { get; set; }
       // public string ISBN { get; set; }
       // public double Price { get; set; }
    }
}
