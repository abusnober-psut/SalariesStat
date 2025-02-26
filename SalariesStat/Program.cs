using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalariesStat
{
    class Program
    {
        static void Main(string[] args)
        {
            // read N salaries and finds out the highest and lowest salaries, 
            // then computes the average salary
            int N;
            float salary;
            float max, min;
            float sum=0;

            max = -99999; // suppose that the max value is v. small number
            min = 99999; // suppose that the min value is v. large number

            Console.WriteLine("Input number of employees");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Enter a Salary: ");
                salary = float.Parse(Console.ReadLine());

                sum += salary;

                if (salary > max)
                    max = salary;
                if (salary < min)
                    min = salary;
                  
            }


            Console.WriteLine($"Average Salary is {sum / N}\n highest Salary = {max} \n Lowest Salary {min}");






        }
    }
}
