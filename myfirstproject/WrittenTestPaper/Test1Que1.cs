using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.WrittenTestPaper
{
    // WAP to calculate area of a equilateral triangle
    class Test1Que1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side");
            int side = int.Parse(Console.ReadLine());
            Console.WriteLine("Area is : "+0.433*side*side);
        }
    }
    // WAP to enter marks of 5 subject and calculate its total average and percentage

    class Test1Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks in English");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in Math");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in Physics");
            int s3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in Biology");
            int s4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks in Chemistry");
            int s5 = int.Parse(Console.ReadLine());

            int total = (s1 + s2 + s3 + s4 + s5);

            Console.WriteLine("Total is : "+total);
            Console.WriteLine("Average is : "+total/5.0);
            Console.WriteLine("Percentage is : "+(total/500.0)*100.0);
        }
    }

    // What is the output?

    class Test1Que3
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int c = 3;

            Console.WriteLine(a++ + b* ++c);
            Console.WriteLine("a = "+a+"b = "+b+"c = "+c);
            Console.WriteLine(b * 5 / a + b++ + b);
            Console.WriteLine("a = " + a + "b = " + b + "c = " + c);
        }
    }

    // WAP to check leap year

    class Test1Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int Year = int.Parse(Console.ReadLine());

            if(Year%4==0 || (Year % 100 == 0 && Year % 400 == 0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap year");
            }
        }
    }

    // WAP to check no. is divisible by 5 and 11 or not

    class Test1Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
            {
                Console.WriteLine("The no. is Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }

        }
    }

    // WAP to find max between 3 numbers

    class Test1Que6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Three numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if (x > y)
            {
                if (x > z)
                {
                    Console.WriteLine("The max number is : "+x);
                }
                else
                {
                    Console.WriteLine("The max number is : "+z);
                }
            }
            else
            {
                Console.WriteLine("The max number is : "+y);
            }
        }
    }

    // WAP to check its vowel or consonant

    class Test1Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Alphabet");
            char C = Convert.ToChar(Console.ReadLine());

            if(C=='a'|| C == 'o' || C == 'e' || C == 'i' || C == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else if(C == 'A' || C == 'E' || C == 'I' || C == 'O' || C == 'U')    
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }

    // WAP to create simple calculator

    class Test1Que8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Choice : + , - , * , /");
            char Choice = Convert.ToChar(Console.ReadLine());
            switch (Choice)
            {
                case '+': Console.WriteLine("Ans is : "+(num1+num2));
                    break;
                case '-': Console.WriteLine("Ans is : " + (num1 - num2));
                    break;
                case '*': Console.WriteLine("Ans is : " + (num1 * num2));
                    break;
                case '/': Console.WriteLine("Ans is : " + (num1 / num2));
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    // WAP to check alphabet, digit or special character

    class Test1Que9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char c = Convert.ToChar(Console.ReadLine());

            if (c >= 'a' || c <= 'z' || c >= 'A' || c <= 'Z')
            {
                Console.WriteLine("Alphabet");
            }
            else if (c >= '0' || c <= '9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }

    // WAP to check its even or odd

    class Test1Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }


        }
    }











}
