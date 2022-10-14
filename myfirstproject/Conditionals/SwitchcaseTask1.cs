using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Conditionals
{

    // program to display day
    class SwitchcaseTask1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of day between 1 to 7");
            int DayNum = int.Parse(Console.ReadLine());
            switch (DayNum)
            {
                case 1:Console.WriteLine("It's Monday");
                    break;
                case 2:Console.WriteLine("It's Tuesday");
                    break;
                case 3:Console.WriteLine("It's Wensday");
                    break;
                case 4:Console.WriteLine("It's Thusday");
                    break;
                case 5:Console.WriteLine("It's Friday");
                    break;
                case 6:Console.WriteLine("It's Saturday");
                    break;
                case 7:Console.WriteLine("It's Sunday");
                    break;
                default: Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }

    class SwitchcaseTask2
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("MENU : \n 1.Area of cicle \n 2.Area of square" +
                    "\n 3.Area of rectangle \n 4.Area of triangle");
                Console.WriteLine("Enter Your Choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Enter radius ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of Circle : "+3.14*r*r);
                        break;
                    case 2:
                        Console.WriteLine("Enter side");
                        int side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of square : "+side*side);
                        break;
                    case 3:
                        Console.WriteLine("Enter length");
                        int length = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter width");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of rectangle : "+length * width);
                        break;
                    case 4:
                        Console.WriteLine("Enter base");
                        int baSe = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height");
                        int height = int.Parse(Console.ReadLine());
                        Console.WriteLine("Area of triangle : "+0.5*baSe*height);
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
    // to check vowel or consonant (uppercase and lowercase)
    class SwitchcaseTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'i':
                case 'o':
                case 'a':
                case 'e':
                case 'u':
                case 'I':
                case 'O':
                case 'A':
                case 'E':
                case 'U': Console.WriteLine("Its a Vowel");
                    break;
                default: Console.WriteLine("Its a Consonant");
                    break;
            }
        }
    }












}
