using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditionals
{
    class ternaryTask0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            string num = x % 2 == 0 ? "Even number" : "Odd number";
            Console.WriteLine(num);
        }
    }

    class ternaryTask1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Second number");
            int b = int.Parse(Console.ReadLine());
            string check = a > b ? "First number is greater" : "Second number is greater";
            Console.WriteLine(check);
        }
    }









}
