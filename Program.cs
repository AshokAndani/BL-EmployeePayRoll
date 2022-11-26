using System;
using System.Reflection;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            EmployeeWageCalculator wageCalculator = new EmployeeWageCalculator("Reliance",20,8,4,20);
            wageCalculator.PrintWageDetails();
            Console.ReadKey();
        }
    }
}
