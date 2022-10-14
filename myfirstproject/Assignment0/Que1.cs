using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{     //assignment no. 1
     //program to enter two numbers and find their sum

    class Que1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");

            int a =Convert.ToInt32(Console.ReadLine());
            int b =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of this two numbers is : "+(a+b));
        }
   
    }

    //program for two numbers that performs all arithmetic operations
    class Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of this two numbers is : "+(a+b));
            Console.WriteLine("The substraction of this two numbers is : "+(a-b));
            Console.WriteLine("The multiplication of this two numbers is : "+(a*b));
            Console.WriteLine("The division of this two numbers is : "+(a/b));

        }
    }

    //program to find area of rectangle
    class Que3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of rectangle is : "+(l*b));
        }
    }
    //program to find area of triangle 

    class Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base of triangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter height of triangle");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of triangle is : " + (0.5*b*h));

        }
    }

   
    // program to calculate square

    class Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The square of "+x+" is : "+(x*x));
        }
    }

    // program to calculate cube

    class Que6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The cube of " + x + " is : " + (x * x * x));

        }
    }

}

