using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.loops
{
    class forlooptask1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        } 


    }
    class forlooptask2
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
    // print odd numbers
    class forlooptask3
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=20;i=i+2)
            {
                Console.WriteLine(i);
            }

        }
    }

    class forlooptask4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }

        }
    }

    class forlooptask5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the exponent");
            int e = int.Parse(Console.ReadLine());
            // Console.WriteLine("enter the power");
            // int p = int.Parse(Console.ReadLine());
            int p = 1;
            for(int i=1; i<=e; i++)
            {
                Console.WriteLine(p = p * b);
            }

        }
    }

    class forlooptask6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int fact = 1;
            for(int i=1; i <= num; i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);
            }

        }
    }

    class forlooptask7
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }

        }
    }

    //print sum of even no. in between 1 to 30
    class forlooptask8
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i <= 30; i =i+ 2)
            {
              //  Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("the sum of even numbers between 1 to 30 : "+sum);
        }
    }

    //print even no.in between 1 to 30
    class forlooptask8_1
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 30; i++)
            {
                if (i % 2==0)
                
                    Console.WriteLine(i);
                            
            }

        }
    }

    // print the series 1,3,7,15

    class forlooptask9
    {
        static void Main(string[] args)
        {
            int p = 2;
            for (int i = 1; i <= 50;)
            {
                Console.WriteLine(i);
                i = i + p;
                p = p * 2;
            }
        }
    }

    // print series 1,4,9,16,..

    class forlooptask10
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*i);
            }
        }
    }

    // program to print table of given number

    class forlooptask11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to print table");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i*n);
            }

        }
    }

    // program to print sum of first 10 numbers

    class forlooptask12
    {
        static void Main(string[] args)
        {
            int sum=0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;              
            }
            Console.WriteLine(sum);
        }
    }

    // to count odd number between 1 to 20

    class forlooptask13
    {
        static void Main(string[] args)
        {
           // int odd = 0;
            for(int i=0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }              
            }
        }
    }
    // to display number between 175-120
    class forlooptask14
    {
        static void Main(string[] args)
        {
            for(int i=175; i>=120; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    // to display alternate even no. between 1-20
    class forlooptask15
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 20; i=i+4)
            {        
                Console.WriteLine(i);
            }
        }
    }

    // print series 1,8,27,64

    class forlooptask16
    {
        static void Main(string[] args)
        {
            int cube;
            for(int i = 1; i <= 10; i++)
            {
                cube = i * i * i;
                Console.WriteLine(cube);
            }
        }
    }

    // print series 0,7,26,63,.....

    class forlooptask17
    {
        static void Main(string[] args)
        {
            int i,num;
            for (i = 1; i <= 10; i++)
            {
                num = ((i * i * i) - 1);
                Console.WriteLine(num);
            }
        }
    }

    // print odd no.
    class forlooptask18
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }

    // print even no.
    class forlooptask19
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }

    // count odd numbers between 1 to 20

    class forlooptask20
    {
        static void Main(string[] args)
        {
            int OddCount = 0;
            for(int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    OddCount++;
                }
            }
            Console.WriteLine(OddCount);
        }
    }

    // count even and odd numbers between 1 to 25

    class forlooptask21
    {
        static void Main(string[] args)
        {
            int OddCount = 0;
            int EvenCount = 0;
            for (int i = 1; i <= 25; i++)
            {
                if (i % 2 == 0)
                {
                   // Console.WriteLine(i);
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            Console.WriteLine("Odd count is : "+OddCount);
            Console.WriteLine("Even count is : "+EvenCount);
        }
    }

    // find average between 1 to 10 

    class forlooptask22
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("Average is : "+(sum/10.0));
        }
    }

    // average of even no. between 1 to 10

    class forlooptask23
    {
        static void Main(string[] args)
        {
            int sum = 0;
            float EvenCount = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                    EvenCount++;
                }
            }
            Console.WriteLine("Average is : "+(sum/EvenCount));
        }
    }

    // average of odd and even numbers seperately

    class forlooptask24
    {
        static void Main(string[] args)
        {
            float OddCount = 0;
            float EvenCount = 0;
            int EvenSum = 0;
            int OddSum = 0;
            for(int i = 1; i <= 25; i++)
            {
                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + i;
                    EvenCount++;
                }
                else
                {
                    OddSum = OddSum + i;
                    OddCount++;
                }
            }

            Console.WriteLine("Average of even numbers is : "+(EvenSum/EvenCount));
            Console.WriteLine("Average of odd numbers is : "+(OddSum/OddCount));
        }
    }

    // display and count prime numbers between 1 to 20

    class forlooptask25
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool CheckPrime = true;
            for(int i = 2; i <= 20; i++)
            {
                for(int j = 2; j <i; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        CheckPrime = false;
                        break;
                    }
                }
                if (CheckPrime==true)
                {
                    Console.WriteLine(i);
                    count++;
                }
                CheckPrime = true;
            }
            Console.WriteLine(count);
        }
    }

    // display prime numbers between 1 to 30

    class forlooptask26
    {
        static void Main(string[] args)
        {
          //  int count = 0;

            for (int i = 1; i <=30; i++)
            {
                for (int j = 1; j <i; j++)
                {
                    if (i%j!=0)
                    {
                       // Console.WriteLine(i);
                       //count++;
                    }
                  Console.WriteLine(i);
                }
               /* if (count == 2)
                {
                    Console.WriteLine(i);
                }*/
            }

        }
    }
    // check trimorphic number
    // num = last digit of cube
    class forlooptask27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int Cube = num * num * num;
            int LastD = Cube % 10;

            if (temp == LastD)
            {
                Console.WriteLine("Trimorphic");
            }
            else
            {
                Console.WriteLine("Not Trimorphic");
            }        
        }
    }

    // find avg of digits in a number
    class forlooptask28
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int Add = 0;
            while (num > 0)
            {
                int r = num % 10;
                Add = Add + r;
                num = num / 10;
                count++;
            }
            Console.WriteLine("Average of digits is : "+(Add/count));
        }
    }

    // print table 1 to 5
    class forlooptask29
    {
        static void Main(string[] args)
        {
            int Table;
            for (int num = 1; num <=5; num++)
            {
                for (int i = 1; i <=10; i++)
                {
                    Table = num * i;
                    Console.WriteLine(Table);
                }
            }
        }
    }
    // sum of factorial of digits of number
    class forlooptask30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (0 < num)
            {
                int digit = num % 10;
                int fact = 1;             
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                   
                }
                sum = sum + fact;             
                num = num / 10;             
            }
            Console.WriteLine("The sum of factorial of digits of number : "+sum);
        }
    }

    // check number whether its krishnamurthy or not
    class forlooptask31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int OrigNo = num;
            int sum = 0;
            while (0 < num)
            {
                int digit = num % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;

                }
                sum = sum + fact;
                num = num / 10;
            }

            if (OrigNo == sum)
            {
                Console.WriteLine("Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurthy Number");
            }
        }
    }
    // WAP to check Dasarium number or not
    class forlooptask32
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int original = num;        
            int count = 0;
            int sum = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }      
            num = original;
            while (num > 0)
            {
                int power = 1;
                int r = num % 10;
                for(int i = 1; i <= count; i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                count--;
                num = num / 10;
            }       
            if (original == sum)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("Not Disarium Number");
            }
        }
    }

    // WAP to check automorphic or not
    class forlooptask33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int Origi = num;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            num = Origi;
            int square = num * num;             
                int Base = 10;
                int power = 1;
                for(int i = 1; i <= count; i++)
                {
                    power = power * Base;
                }                
            int lastDsq = square % power;
            if (Origi == lastDsq)
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("Not Automorphic Number");
            }          
        }
    }

    //WAP to check the number is kaparekar or not

    class forlooptask34
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            int orig = num;
            int sum;
            int Square = num * num;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            num = orig;
            int power = (int)(Math.Pow(10, count));
            int end = Square % power;
            int start = Square / power;
            sum = end + start;                     
            if(orig==sum)
            {
                Console.WriteLine("Kaparekar Number");
            }
            else
            {
                Console.WriteLine("Not a Kaparekar Number");
            }
        }
    }

    // WAP to check the no. is Harshad or not
    class forlooptask35
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int num = int.Parse(Console.ReadLine());
            int orig = num;
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            num = orig;
            while (num > 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            if (sum % count == 0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not Harshad Number");
            }
        }
    }

   /* class forlooptask36
    {
        static void Main(string[] args)
        {
            *//* Console.WriteLine("Enter");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());

             if (a > b)
             {
                 Console.WriteLine("first number");
             }
             else
             {
                 Console.WriteLine("Second number");
             }*//*
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int orig = num;
            bool isDuck = true;
            while (num > 0)
            {
                if (num % 10 == 0)
                {
                    isDuck = true;
                    break;
                }
                else
                {
                    isDuck = false;
                }
                num = num / 10;
            }

            int firstDigit = int.MaxValue;
            int count = 0;
            int c = 0;
            while ( firstDigit>0   )
            {
                int r = orig % 10;
                firstDigit = r;
                orig = orig / 10;
                if(firstDigit==0)
                {
                    break;
                }
                else if(orig==0)
                {
                    break;
                }
             
*//*                if (orig==0 && firstDigit==0)
                {
                    count++;

                    break;

                }*//*
            }
            Console.WriteLine(c+"   digits");
            Console.WriteLine(firstDigit + " --------");
            if (firstDigit > 0 && isDuck == true)
            {
                Console.WriteLine("Duck Number");
            }
            else
            {
                Console.WriteLine("Not Duck Number");
            }
        }
    }*/


    // 2 12 36 80
    class forlooptask37
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                int num = (i * i) + (i * i * i);
                Console.WriteLine(num);
            }
        }
    }

    // 3 13 37 81
    class forlooptask38
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = ((i * i) + (i * i * i)+1);
                Console.WriteLine(num);
            }
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entr number in string");

            string num = Console.ReadLine();

            bool isFirst = false;
            bool isZero = false;

            for(int i=0;i<num.Length;i++)
            {
                if(num[0]=='0')
                {
                    isFirst = true;
                    break;
                }
                else if(num[i]=='0')
                {
                    isZero = true;
                    break;
                }
            }


            if(isFirst==true)
            {
                Console.WriteLine("not duck");
            }
            else if(isFirst==false && isZero==false)
            {
                Console.WriteLine("Not duck");
            }
            else if(isZero==true)
            {
                Console.WriteLine("Duck number");
            }
        }
    }


    class forlooptask39
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                int d = 1;
                for (char j = 'A'; j <= i; j++)
                {
                    if (i == 'A' || i == 'C')
                    {
                        Console.Write(d++);
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }


        }
    }

    class forlooptask40
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter Number");
                int Num = int.Parse(Console.ReadLine());
                int FirstNum = 0;
                int SecondNum = 1;
                for (int i = 0; i < Num; i++)
                {
                    Console.WriteLine(FirstNum);
                    int NextNum = FirstNum + SecondNum;
                    FirstNum = SecondNum;
                    SecondNum = NextNum;
                }
        }
    }


    class forlooptask41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                if(num>=2 && num <= 8)
                {
                    Console.WriteLine("Green");
                }
                else
                {
                    Console.WriteLine("Red");
                }
            }
            else
            {
                if (num > 8)
                {
                    Console.WriteLine("White");
                }
                else
                {
                    Console.WriteLine("Black");
                }
            }

        }
    }

    class forlooptask42
    {
        static void Main(string[] args)
        {
            long j = 1;
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine(j);
                j = (j * 10) + 1;

            }



        }
    }


    class forlooptask43
    {
        static void Main(string[] args)
        {
            float digicount = 0;
            int sum = 0;
            for(int i= 1; i <= 10; i++)
            {
                bool IsPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime == true)
                {
                   // Console.WriteLine(i);
                    sum = sum + i;
                    digicount++;
                }
                       

            }

            Console.WriteLine("Average of Prime no. : "+sum/digicount);



        }
    }










}
