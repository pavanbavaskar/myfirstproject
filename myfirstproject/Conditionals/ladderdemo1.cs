using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditionals
{
    // to calculate the percentage for 5 subjects 
    class ladderdemo1
    {
        static void Main(string[] args)
        {
            float e, m, p, b, c,per;
            Console.WriteLine("Enter the marks in English");
            e = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Math");
            m = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Physics");
            p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Biology");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks in Chemistry");
            c = float.Parse(Console.ReadLine());

            per = ((e + m + p + b + c)/500.0f)*100.0f;

            Console.WriteLine("Your percentage is : "+per);

            if (per >= 70)
            {
                Console.WriteLine("You passed in Distinction");
            }
            else if(per<70 && per >= 60)
            {
                Console.WriteLine("You passed in First Class");
            }
            else if(per<60 && per >= 50)
            {
                Console.WriteLine("You passed in Second Class");
            }
            else if (per < 50 && per >= 35)
            {
                Console.WriteLine("You Passed");
            }
            else
            {
                Console.WriteLine("Sorry, you are Failed!");
            }
        }
    }
    
    class ladderdemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter friend age");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Hiiii");
            }
            else if (a<b)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How are you?");
            }
        }
    }

    class ladderdemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine(num+" is divisible by 3 & 9");
            }
            else
            {
                Console.WriteLine(num+ " is not divisible by 3 & 9");
            }
        }
    }

    









}
