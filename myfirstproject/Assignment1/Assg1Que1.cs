using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{     
    // to check whether a year is leap or not 
    class Assg1Que1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y%100!=0)||(y % 100 == 0 && y%400==0))
            {
                Console.WriteLine(y+" is leap year");
            }
            else
            {
                Console.WriteLine(y+" is not a leap year");
            }
        }
    }

    // to check whether number is divisible by 5 and 11 or not

    class Assg1Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num%5==0 && num % 11 == 0)
            {
                Console.WriteLine(num+" is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine(num+" is not divisible by 5 and 11");
            }
        }
    }

    // find maximum between three numbers

    class Assg1Que3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            if((x>y)&&(x>z))
            {
                Console.WriteLine(x+" is a greater number");
            }
            else if((y>x)&&(y>z))
            {
                Console.WriteLine(y+" is a greater number");
            }
            else
            {
                Console.WriteLine(z+" is greater number");
            }

        }
    }
    // input any alphabet and check whether it is vowel or consonent
    class Assg1Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet");
            char c = Convert.ToChar(Console.ReadLine());

            if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.WriteLine(c+" is Vowel");
            }
            else if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                Console.WriteLine(c+" is a Vowel");
            }
            else
            {
                Console.WriteLine(c+" is Consonant");
            }
        }
    }

    // create a simple calculator

    class Assg1Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Press :\n 1 for + \n 2 for - \n 3 for * \n 4 for /");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Addition is : "+(a+b));
            }
            else if(op == 2)
            {
                Console.WriteLine("Substraction is : " + (a - b));
            }
            else if (op == 3)
            {
                Console.WriteLine("Multiplication is : " + (a * b));
            }
            else if (op == 4)
            {
                Console.WriteLine("Division is : " + (a / b));
            }
            else
            {
                Console.WriteLine("You pressed invalid key");
            }

        }
    }

    // to check entered number is negative positive or zero

    class Assg1Que6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine(a+" is a negative number");
            }
            else if (a > 0)
            {
                Console.WriteLine(a+" is a positive number");
            }
            else
            {
                Console.WriteLine(a+" is a zero");
            }
        }
    }

    // to check the entered character is alphabet, digit or special character

    class Assg1Que7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a character");
            char c = Convert.ToChar(Console.ReadLine());

            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine(c + " : is a Alphabet");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine(c + " : is a Digit");
            }
            else
            {
                Console.WriteLine(c + " : is a Special Character");
            }
        }
    }

    // to check the number is odd or even

    class Assg1Que8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num+" is a even number");
            }
            else
            {
                Console.WriteLine(num+" is a odd number");
            }
        }
    }

    // a bank intends to design a program to display the denomination of an input amount
    // the available denomination with the bank are of rupees 2000 500 200 100 50 20 10 and 1

    class Assg1Que9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            int amt = int.Parse(Console.ReadLine());
            // 2000 a, 500 b , 200 c, 100 d, 50 e , 20 f , 10 g ,1 h
            int a, b, c, d, e, f, g, h, p, q, r, s, t, u;
             a = amt / 2000;          p = amt % 2000;
             b = p / 500;             q = p % 500;
             c = q / 200;             r = q % 200;
             d = r / 100;             s = r % 100;
             e = s / 50;              t = s % 50;
             f = t / 20;              u = t % 20;
             g = u / 10;              h = u % 10;
            //int h = v / 1;           
            //Console.WriteLine(v);
            Console.WriteLine($" 2000 : {a} \n  500 : {b} \n  200 : {c} \n  100 : {d}" +
                $"\n   50 : {e} \n   20 : {f} \n   10 : {g} \n    1 : {h}");
        }
    }

    // to calculate the gross salary of an employee

    class Assg1Que10
    {
        static void Main(string[] args)
        {
            // gross salary = basic+basic*20%+basic*80%
            Console.WriteLine("Enter the Basic Salary");
            int s = int.Parse(Console.ReadLine());

            if (s <= 10000)
            {
                Console.WriteLine("Gross Salary is : "+(s+(s*0.2)+(s*0.8)));
            }
            else if(s<=20000)
            {
                Console.WriteLine("Gross Salary is : " + (s + (s * 0.25) + (s * 0.9)));
            }
            else
            {
                Console.WriteLine("Gross Salary is : " + (s + (s * 0.3) + (s * 0.95)));
            }
        }
    }

    // program to check entered number is 3 digit or not
    // if it is 3 digit no. then do sum of 1st & 3rd digit and print sum

    class Assg1Que11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = int.Parse(Console.ReadLine());

            if((a>=100)&&(a<=999))
            {
                Console.WriteLine("Entered number is 3 digit number");
            }
            else
            {
                Console.WriteLine("Entered number is not 3 digit number");
            }
        }
    }







}

