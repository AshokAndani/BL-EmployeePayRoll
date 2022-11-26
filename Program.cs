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
            int number = random.Next(0, 3);
            int WagePerHour = 20;
            int FullDayHour = 8;
            int partTimeHour = 4;
            if (number == 0)
            {
                Console.WriteLine("Employee is Present and Worked Full-Time");
                Console.WriteLine("Wage is: " + WagePerHour * FullDayHour);
            }
            else if (number == 1)
            {
                Console.WriteLine("Employee is Present and Worked Part-Time");
                Console.WriteLine("Wage is: " + WagePerHour * partTimeHour);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadKey();
        }
    }
}
