using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditionals
{
    class ifElseDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());
            if(x%2==0)
            {
                Console.WriteLine("The entered number is even number");
            }
            else
            {
                Console.WriteLine("The entered number is odd number");
            }

        }
    }
    
    class ifelseTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine("The number is positive");
            }
            else if(a<0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
        }
    }

    class ifelseTask1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the character");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch =='A')
            {
                Console.WriteLine(ch+" : is a vovel");
            }
            else if(ch == 'E')
            {
                Console.WriteLine(ch + " : is a vovel");
            }
            else if(ch == 'I')
            {
                Console.WriteLine(ch + " : is a vovel");
            }
            else if (ch == 'O')
            {
                Console.WriteLine(ch + " : is a vovel");
            }
            else if (ch == 'U')
            {
                Console.WriteLine(ch + " : is a vovel");
            }
            else 
            {
                Console.WriteLine(ch + " : is a consonant");
            }
        }
    }

    class ifelseTask1_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the character");
            char c = Convert.ToChar(Console.ReadLine());
             
            if(c=='A'|| c == 'E'|| c=='I'||c=='O'||c=='U')
            {
                Console.WriteLine("The char is Vowel");
            }
           else
            {
                Console.WriteLine("The char is Consonant");
            }
            
        }
    }


    class ifelseTask2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int x = int.Parse(Console.ReadLine());

            if(x>0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (x<0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }

        }
    }

    class ifelseTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char c = Convert.ToChar(Console.ReadLine());

            if(c>='a' && c<='z')
            {
                Console.WriteLine(c+" : is Alphabet");
            }
            else if(c >= '0' && c <= '9')
            {
                Console.WriteLine(c + " : is Digit");
            }
            else
            {
                Console.WriteLine(c + " : is Special Character");
            }

        }
    }

    class ifelseTask3_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char c = Convert.ToChar(Console.ReadLine());

            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine(c + " : is Alphabet");
            }
            else if (c >= '0' && c <= '9')
            {
                Console.WriteLine(c + " : is Digit");
            }
            else
            {
                Console.WriteLine(c + " : is Special Character");
            }

        }
    }




















}
