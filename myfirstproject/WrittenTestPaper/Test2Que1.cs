using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.WrittenTestPaper
{
    // WAP to print all numbers between 1 to 100 except the number which divisible by 5 and 10
    class Test2Que1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 || i % 10 == 0)
                {
                    continue;                
                }              
                Console.WriteLine(i);
            }
        }
    }

    // Predict behaviour of following code

    class Test2Que2
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            } while (b != 3);
        }
    }

    // Predict the output of following

    class Test2Que3
    {
        static void Main(string[] args)
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {     
                k *= i;
            }
            Console.WriteLine("k = "+k+" i = "+i);            
        }
    }
    // WAP to check given number is spy or not
    class Test2Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int Product = 1;
            int Sum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                Product = Product * rem;
                Sum = Sum + rem;
                num = num / 10;
            }
            if (Product == Sum)
            {
                Console.WriteLine("Spy Number");
            }
            else
            {
                Console.WriteLine("Not Spy Number");
            }
        }
    }
    // WAP to check given number is trimorphic or not
    class Test2Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            int Cube = num * num * num;
            int LastD = Cube % 10;
            if (num == LastD)
            {
                Console.WriteLine("Trimorphic Number");
            }
            else
            {
                Console.WriteLine("Not a Trimorphic Number");
            }
        }
    }

    // WAP to print following pattern
    //    1
    //   222
    //  33333
    // 4444444

    class Test2Que6
    {
        static void Main(string[] args)
        {
            int n = 4;
            int z = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int k = n-1; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= z; j++)
                {
                    Console.Write(i);
                }
                z += 2;
                Console.WriteLine();
            }
        }
    }

    // WAP to print following pattern
    //  *****
    //  ****
    //   ***
    //   **
    //    *

    class Test2Que7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for(int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class Test2Que8
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i = 1; i <=n; i++)
            {
                int p = 1;
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = i; j<=n ; j++)
                {
                    Console.Write(p++);
                }
                Console.WriteLine();
            }
        }
    }
    // Predict the output
    class Test2Que9
    {
        static void Main(string[] args)
        {
            for(int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }
        }
    }

    // WAP to find twin prime number
    class Test2Que10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int Num2 = int.Parse(Console.ReadLine());

            bool IsPrimeN1 = true;
            bool IsPrimeN2 = true;
            int i = 2;
            int j = 2;
            while (Num1 > i)
            {             
                    if (Num1 % 2 == 0)
                    {
                        IsPrimeN1 = false;
                        break;
                    }
                i++;
            }         
            while (Num2 > j)
            {
                if (Num2 % 2 == 0)
                {
                    IsPrimeN1 = false;
                    break;
                }
                j++;
            }
            if (IsPrimeN2 == true && IsPrimeN1==true)
            {
                if(Num1-Num2==2 || Num1 - Num2 == -2)
                {
                    Console.WriteLine("Twin Prime Number");
                }
                else
                {
                    Console.WriteLine("Not Twin Prime Number");
                }
            }
            else
            {
                Console.WriteLine("Not Twin Prime Number");
            }
        }
    }

    // print series 2 12 36 80 150 252......upto 10 terms

    class Test2Que11
    {
        static void Main(string[] args)
        {
            int Square,Cube;         
            for(int i = 1; i <= 10; i++)
            {
                Square = i * i;
                Cube = i * i * i;
                Console.WriteLine(Square+Cube);
            }
        }
    }

    // WAP to print no. from 1-50 if number is even the print as it is and
    // if odd then print negative number with its square

    class Test2Que12
    {
        static void Main(string[] args)
        {
            int Negative = -1;
            for(int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($"{Negative*i} = {i*i}");
                }
            }
        }
    }

    // Predict the output of following what are the value of i and j?

    class Test2Que13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
               Console.WriteLine(i);
            }
        }
    }

    // print fibbo series
    class Test2Que14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Num = int.Parse(Console.ReadLine());
            int FirstNum = 0;
            int SecondNum = 1;
            for(int i = 0; i < Num; i++)
            {
                Console.WriteLine(FirstNum);
                int NextNum = FirstNum + SecondNum;
                FirstNum = SecondNum;
                SecondNum = NextNum;
            }
        }
    }
    // 1!+2!+3!+4!...n print the sum

    class Test2Que15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int Fact = 1;
            int Sum = 0;
            for(int i = 1; i <= n; i++)
            {
                Fact = Fact * i;
                Sum = Sum + Fact;
            }
            Console.WriteLine($"Sum of factorial upto {n} is : {Sum}");
        }
    }

    




}
