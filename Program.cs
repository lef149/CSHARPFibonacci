using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string usrInput;

            Console.WriteLine("Enter how many numbers of Fibonacci you would like to display: ");
            usrInput = Console.ReadLine();

            num = Int16.Parse(usrInput);

            List<int> series = new List<int>();
            series.Add(1);
            series.Add(1);

            for (int i = 2; i < num; i++)
            {
                series.Add(series[i - 2] + series[i - 1]);
            }

            for (int j = 0; j < num; j++)
            {
                Console.Write(series[j]);
                Console.Write(" ");
            }
        }
    }
}
