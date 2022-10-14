using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.loops
{
    class DowhileloopTask1
    {
            static void Main(string[] args)
            {
                char ch;
                do
                {
                    Console.WriteLine("Enter the no. between 1 to 7");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        case 7:
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("invalid choice");
                            break;
                    }
                    Console.WriteLine("Press Y to try again");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch == 'Y' || ch == 'y');
            }
        
    }
}
