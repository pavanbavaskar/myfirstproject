using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditionals
{
    // greatest number in three numbers
    class nesteddemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());
            int max = 0;

            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            Console.WriteLine(max+" is a greatest number");       
        }
    }
    






}
