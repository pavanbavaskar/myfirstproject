using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{
    // program for convert the value cm to m and km
    class Que1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lenght in centimeter");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The converted length of " + a + " in metre is  : " + (a / 100.0f));
            Console.WriteLine("The converted length of " + a + " in kilometre is  : " + (a / 100000.0f));
        }
    }

    // program for enter five subject marks and calculate total,avg,percentage

    class Que1_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks in English");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in Math");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in Physics");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in Biology");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter marks in Chemistry");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The total of all subjects is : "+(a+b+c+d+e));
            Console.WriteLine("The average of all subjects is : "+((a+b+c+d+e)/5));
            Console.WriteLine("The overall percentage is : "+((a+b+c+d+e)/500.0f*100.0f));

        }
    }
     //program to calculate simple interest

    class Que1_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of Principal");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time (In years)");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate");
            int r = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Simple interest is : "+ ((p * t * r) / 100.0f));

        }
    }
     //program for calculating rectangle perimeter
    class Que1_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perimeter of rectangle is : " + (l+l+b+b));

        }
    }
   
    //program to calculate area of equilateral triangle

    class Que1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side of equilateral triangle ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of equilateral triangle : " + (0.433f * (s * s)));
        }
    }

    //program to compute the specified expression

    class Que1_6
    {
        static void Main(string[] args)
        {
            float a, b, c, d,ans;
            a = 25.5f;
            b = 3.5f;
            c = 40.5f;
            d = 4.5f;
            ans = ((a * b - b * b) / (c - d));
            Console.WriteLine(ans);

        }
    }

    //expression
    class Que1_7
    {
        static void Main(string[] args)
        {
            float exp = ((25.5f * 3.5f - 3.5f * 3.5f) / (40.5f - 4.5f));
            Console.WriteLine(exp);

        }
    }

    //compute formula
    class Que1_8
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, f, g, ans;
            a = 4.0f;
            b = 1.0f;
            c = 3.0f;
            d = 5.0f;
            e = 7.0f;
            f = 9.0f;
            g = 11.0f;
            ans = a * (b - (b / c) + (b / d) - (b / e) + (b / f) - (b / g));

            Console.WriteLine(ans);

        }
    }
    //expression
    class Que1_9
    {
        static void Main(string[] args)
        {

            float x = 4.0f * (1.0f - (1.0f / 3.0f) + (1.0f / 5.0f)
                - (1.0f / 7.0f) + (1.0f / 9.0f) - (1.0f / 11.0f));

            Console.WriteLine(x);

        }
    }

    //program to enter temp in celsius and convert into fahrenheit

    class Que1_10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Celsius");
            int t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The converted temperature in Fahrenheit is : "+((t*1.8)+32));

        }
    }


    //program to enter temp in fahrenheit and convert into celsius

    class Que1_11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Fahrenheit");
            int t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The converted temperature in Celsius is : " + ((t-32)*(5.0f/9.0f)));

        }
    }





















}




