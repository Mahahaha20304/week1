﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            Console.WriteLine("Enter 1st Number :");
            input = Console.ReadLine();  //waits for user to hit return
            num1 = Convert.ToInt32(input);
            Console.WriteLine("Enter 2nd Number :");
            input = Console.ReadLine();
            num2 = Convert.ToInt32(input);
            Console.WriteLine("pow is : {0}", pow(num1, num2));
            //{0} takes 1st argument and substitutes into string
            Console.ReadKey();  //waits for a key to press before ending
        }
        static int sum(int x, int y)
        {
            return x + y;
        }

        static double pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
