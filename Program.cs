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
            int WagePerHour = 20;
            int FullDayHour = 8;
            int partTimeHour = 4;
            int workingDaysPerMonth = 20;
            int totalWage = 0;
            int noOfDaysPresent = 20;
            int totalHours = 0;
            for(int i = 0; i < workingDaysPerMonth && totalHours<=100; i++)
            {
                int number = random.Next(0, 3);
                switch (number)
                {
                    // 0 for full time
                    case 0:
                        totalHours += FullDayHour;
                        totalWage = totalWage + (FullDayHour * WagePerHour);
                        break;
                    // 1 for partime
                    case 1:
                        totalHours += partTimeHour;
                        totalWage+=(partTimeHour*WagePerHour);
                        break;
                    //2 for absent
                    case 2:
                        noOfDaysPresent--;
                        totalWage += 0;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Number of Hours Employee worked: "+totalHours);
            Console.WriteLine("Number of Days Employee is Present: "+noOfDaysPresent+" Days");
            Console.WriteLine("total wages for the month is: " + totalWage);
            Console.ReadKey();
        }
    }
}
