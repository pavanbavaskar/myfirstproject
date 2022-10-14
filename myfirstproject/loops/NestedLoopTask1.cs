using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.loops
{
    //1
    //12
    //123
    //1234
    class NestedLoopTask1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    //1
    //22
    //333
    //4444
    class NestedLoopTask2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    //4321
    //432
    //43
    //4
    class NestedLoopTask3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //*
    //**
    //***
    //****
    class NestedLoopTask4
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
    //****
    //***
    //**
    //*
    class NestedLoopTask5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
    //1111
    //222
    //33
    //4
    class NestedLoopTask6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    //1234
    //123
    //12
    //1
    class NestedLoopTask7
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //A
    //AB
    //ABC
    //ABCD

    class NestedLoopTask8
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    //54321
    //5432
    //543
    //54
    //5
    class NestedLoopTask9
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //1
    //10
    //101
    //1010

    class NestedLoopTask10
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<=4; i++)
            {
                for(int j = 0; j <i; j++)
                {
                   
                    if (j%2==0 || j==0)
                    {
                        Console.Write("1");
                    }
                    if (j % 2 != 0)
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    //****
    //*  *
    //*  *
    //****

    class NestedLoopTask11
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {            
                for(int j=1;j<=4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    //DCBA
    //DCB
    //DC
    //D
    class NestedLoopTask12
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'D'; j >=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    //  *
    //  *
    //*****
    //  *
    //  *
    class NestedLoopTask13
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 || j == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    //   *
    //  ** 
    // ***
    //****
    class NestedLoopTask14
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    /*class NestedLoopTask15
    {
        static void Main(string[] args)
        {
            for(int i = 1; i >= 1; i--)
            {
                for(int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
            }



        }
    }*/

    class NestedLoopTask16
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
    //   *
    //  **
    // ***
    //****
    class NestedLoopTask17
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
    //    *
    //   * *
    //  * * *
    // * * * *

    class NestedLoopTask18
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
    //*   *
    //**  *
    //*  **
    //*   *
    class NestedLoopTask19
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (j == 1 || j == 4 || j == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    //10101
    //01010
    //10101
    //01010
    //10101

    class NestedLoopTask20
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if ((j+i)%2==0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }             
                }
                Console.WriteLine();
            }
        }
    }


   /* class NestedLoopTask21
    {
        static void Main(string[] args)
        {





        }
    }
*/












}
