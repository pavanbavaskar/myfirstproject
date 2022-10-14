using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment2
{
    // program to print even no. between 121 - 229 using for loop
    class Assg2Que1
    {
        static void Main(string[] args)
        {
            for(int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    // print odd no. between 521 - 229 using while loop
    class Assg2Que2
    {
        static void Main(string[] args)
        {
            int i = 521;
            while (i >= 229)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }

    //program to show the use of break statement

    class Assg2Que3
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }

    // program to find GCD and LCM of given number
    class Assg2Que4
    {
        static void Main(string[] args)
        {

        }
    }

    // WAP to print all alphabets using for loop

    class Assg2Que5
    {
        static void Main(string[] args)
        {
            for(char alpha = 'a'; alpha <= 'z'; alpha++)
            {
                Console.WriteLine(alpha);
            }
        }
    }

    // WAP to find sum of all even numbers between 1 to n 

    class Assg2Que6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }     
            }
            Console.WriteLine($"The sum of even number from 1 to {n} : "+sum);
        }
    }

    // WAP to find sum of all odd numbers between 1 to n 

    class Assg2Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"The sum of odd number from 1 to {n} : " + sum);
        }
    }

    /*//WAP to count number of digits in any number
    class Assg2Que8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i < num; i++)
            {

            }


        }
    }*/

    // WAP to find product of digits in any number

    class Assg2Que9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int product = 1;
            for(int i = 1; i <= num; i++)
            {
                int r = num % 10;
                product = product * r;
                num = num / 10;
            }
            Console.WriteLine("Product of Digits is : "+product);
        }
    }

    // WAP to find frequency of each digit of given integer

    /*class Assg2Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                int r = num % 10;
                num = num / 10;
            }


        }
    }*/

    // WAP to find a prime number between 400 to 300

    class Assg2Que11
    {
        static void Main(string[] args)
        {
           // bool isPrime = true;
            for(int i = 400; i >= 300; i--)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    // isPrime = false;
                    Console.WriteLine(i);
                }
                /*if(isPrime==true)
                {
                    Console.WriteLine(i);
                }*/
            }
           /* if (isPrime == true)
            {
                Console.WriteLine(i);
            }
*/

        }
    }

    //WAP to print table of given number

    class Assg2Que12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print the table");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                int table = i * num;
                Console.WriteLine(table);
            }
        }
    }

    // WAP to print square of 1 to 20
    class Assg2Que13
    {
        static void Main(string[] args)
        {
            int i, square;
            square = 1;
            for (i = 1; i <= 20; i++)
            {
                square = i * i;
                Console.WriteLine(square);
            }
        }
    }









}
