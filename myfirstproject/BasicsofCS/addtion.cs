using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.BasicsofCS
{
    class addition
    {
        static void Main(string[] args)
        {
            int num1 = 25;
            int num2 = 65;
            int ans = num1 + num2;
            Console.WriteLine("Addition is " + ans);
        }
    }
    class substraction
    {
        static void Main(string[] args)
        {
            int num1 = 96;
            int num2 = 56;
            int ans = num1 + num2;
            Console.WriteLine("Substraction is " + ans);
        }
    }
    class division
    {
        static void Main(string[] args)
        {
            float divno1 = 25f;
            float divno2 = 2f;
            float ans = divno1 / divno2;
            Console.WriteLine("Division is "+ans);

        }
    }

    class multiplication
    {
        static void Main(string[] args)
        {
            int x = 45;
            int y = 81;
            int ans = x * y;
            Console.WriteLine("Multiplication is "+ans);

        }
    }
     class cube 
    { 
        static void Main(string[] args)
        {
            int a = 5;
            int cube = a*a*a;
            Console.WriteLine("cube of 5 is "+cube);

        }
     }

    class swapping
    { static void Main(string[] args)
      {
            int a, b;
            a = 6;
            b = 8;
            Console.WriteLine(a+" , "+b);
           
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(a+" , "+b);
      }        
    }
      
    class percentage
    {
        static void Main(string[] args)
        {
            byte eng = 75;
            byte math = 72;
            byte phy = 86;
            byte bio = 83;
            byte chem = 78;

            float percent = ((eng + math + phy + bio + chem) / 5.0f);

            Console.WriteLine("The percentage is "+percent);


        }
    }

    class Operatormath
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 3;
            Console.WriteLine(a++ + b*++c);
            Console.WriteLine("a= "+a+" b= "+b+" c= "+c);
            Console.WriteLine(b*5/a+b++ + b);
            Console.WriteLine($"a={a} b={b} c={c}");
        }
    }







}