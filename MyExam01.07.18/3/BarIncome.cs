using System;
using System.Text.RegularExpressions;

namespace _3
{
    class BarIncome
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double income = 0;
            while (input!= "end of shift" )
            {
                Regex nameReg = new Regex(
                    @"(?<name>%[A-Z]{1}[a-z]+%)(?<prod><[A-Za-z]+>)(?<count>\|[0-9]+\|)(?<price>[0-9]+.[0-9]+\$)");
                if (nameReg.IsMatch(input))
                {
                    Match match = nameReg.Match(input);
                    string name = match.Groups["name"].Value;
                    string finname = name.Trim('%');
                    string product = match.Groups["prod"].Value;
                    string finproduct = product.Trim('<').Trim('>');
                    string countSt = match.Groups["count"].Value;
                    string finCou = countSt.Trim('|');
                    int count = int.Parse(finCou);
                    string priceSt = match.Groups["price"].Value;
                    priceSt = priceSt.Trim('$');
                    double price = double.Parse(priceSt);
                    double totPr = count * price;
                    Console.WriteLine($"{finname}: {finproduct} - {totPr:f2}");
                    income += totPr;
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
