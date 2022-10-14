using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicsofCS
{
    class uservalue
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the days");
            int d = int.Parse(Console.ReadLine());

            // float y = d / 365.0f;
            // int w = d / 7;
            int y = d / 365;
            int b = d % 365;
            int w = b / 7;
            int days = w % 7;

            // int x = d;
           // Console.WriteLine(b);
            Console.WriteLine(d+" days is : "+y+" years "+w+" weeks "+days+" days");
           // Console.WriteLine(d+" days in "+w+" weeks");
           // Console.WriteLine(d+"days in "+x+" days");

        }
    }

    class daysconv
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the days");
            int days = int.Parse(Console.ReadLine());
            
            float y, w,m;
            y = days / 365.0f;
            w = days / 7.0f;
            m = days / 30.0f;

            Console.WriteLine(days+" days in "+(y)+" years");
            Console.WriteLine(days+" days in "+(w)+" weeks");
            Console.WriteLine(days+" days in "+(m)+" months");
        
        }
    }





}
