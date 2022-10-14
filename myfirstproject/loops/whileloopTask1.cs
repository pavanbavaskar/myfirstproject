using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.loops
{

    // display no. between 35 to 75 
    class whileloopTask1
    {
        static void Main(string[] args)
        {
            int i = 35;
            while (i <= 75)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    // print 60 to 25 numbers
    class whileloopTask2
    {
        static void Main(string[] args)
        {
            int i = 60;
            while (i >= 25)
            {
                Console.WriteLine(i);
                i--;
            }
        }
    }
    //check prime number
    class whileloopTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int i = 2;

            while (i < num)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;                
            }

            if (isPrime == true)
            {
                Console.WriteLine("Its a prime number");
            }
            else
            {
                Console.WriteLine("Its not a prime number");
            }
        }
    }
    // to check the magic number
    class whileloopTask4
    {
        static void Main(string[] args)
        {
            int magicNo = 56;
            int i = 1;
            while (i > 0)
            {
               i++;
                Console.WriteLine("Enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num < magicNo)
                {
                    Console.WriteLine("Number is less than Magic number");
                    continue;
                }
                else if (num > magicNo)
                {
                    Console.WriteLine("Number is greater than Magic number");
                    continue;
                }
                else
                {
                    Console.WriteLine("Number is correct...");
                    break;
                }
             //   i++;
            }
        }
    }
    // factorial of a number

   class whileloopTask5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            int i = 1;
            while (i <= num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial is : "+fact);
        }
    }

    //to check number is valid palindrome
    class whileloopTask6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int reverse = 0;
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
               
            }
            if (temp == reverse)
            {
                Console.WriteLine("The number is Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome number");
            }
        }
    }

    // to check armstrong number

    class whileloopTask7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }

        }
    }
    // to check the spy number
    class whileloopTask8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                product = product * r;
                num = num / 10;
            }         
            if (sum == product)
            {
                Console.WriteLine("This is a spy number");
            }
            else
            {
                Console.WriteLine("this is not a spy number");
            }
        }
    }

    // reverse a number
    class whileloopTask9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (num > 0)
            {
                int r = num % 10;
                reverse = reverse * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(reverse);
        }
    }

    // print even digits in a number
    class whileloopTask10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int digit = 0;
            while (num > 0)
            {
                int r = num % 10;
                digit = r;
                num = num / 10;
                if (digit % 2 == 0)
                {
                    Console.Write(digit+" ");
                }
            }      
        }
    }

    class whilelooptask11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int digit = 0;
            int LastD = num%10;
            while (num > 0)
            {
                int r = num % 10;
               // LastD=r;
                digit = r;
                num = num / 10;

            }
            Console.WriteLine(digit+LastD);
        }
    }



}
