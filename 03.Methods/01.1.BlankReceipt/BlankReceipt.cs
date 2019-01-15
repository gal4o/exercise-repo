using System;

namespace _01._1.BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            PrintReciept();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to_____________________");
            Console.WriteLine("Received by____________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void PrintReciept()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
