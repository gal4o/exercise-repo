using System;

namespace _01.RageExpenses
{
    class RageExpenses
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int trashHeadset = lostGames / 2;
            int trashMouse = lostGames / 3;
            int trashKeyboart = lostGames / 6;
            int trashDispl = trashKeyboart / 2;
            double expenses = trashHeadset * headsetPrice 
                + trashMouse * mousePrice 
                + trashKeyboart * keyboardPrice 
                + trashDispl * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
