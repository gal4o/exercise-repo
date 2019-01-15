using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            int employeeId = int.Parse(Console.ReadLine());
            decimal monthlySalary = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("EmployeeData ID:{0:D8}", employeeId);
            Console.WriteLine("Salary: {0:F2}", monthlySalary);
        }
    }
}
