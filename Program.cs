using System;
using System.Reflection;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Random random = new Random();
            int number=random.Next(0, 2);
            int WagePerHour = 20;
            int FullDayHour = 8;
            if(number == 0)
            {
                Console.WriteLine("Employee is Present ");
                Console.WriteLine("Wage is: "+WagePerHour*FullDayHour);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadKey();
        }
    }
}
