using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._2.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shop = 
                new Dictionary<string, double>();
            List<Customer> students = new List<Customer>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split("-");
                shop[line[0]] = double.Parse(line[1]);
            }
            string[] input = Console.ReadLine().Split("-");
            while (input[0]!="end of clients")
            {
                Dictionary<string, int> wishesList = 
                    new Dictionary<string, int>();
                string name = input[0];
                string[] wishes = input[1].Split(',');
                string wishProduct = wishes[0];
                if (shop.ContainsKey(wishProduct))
                {
                    int wishQuantity = int.Parse(wishes[1]);
                    wishesList.Add(wishProduct, wishQuantity);
                    double bill = 0.00;
                    foreach (var prod in wishesList)
                    {
                        bill = prod.Value * shop[prod.Key];
                    }
                    Customer customer = new Customer
                    { Name = name, WishList = wishesList, Bill = bill };
                    students.Add(customer);
                }
                input = Console.ReadLine().Split("-");
            }
            double total = 0.00;
            students = students.OrderBy(x => x.Name).ToList();
            foreach (Customer student in students)
            {
                Console.WriteLine(student.Name);
                foreach (KeyValuePair<string,int> item in student.WishList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {student.Bill:f2}");
                total += student.Bill;
            }
            Console.WriteLine($"Total bill: {total:f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> WishList { get; set; }
        public double Bill { get; set; }
    }
}
