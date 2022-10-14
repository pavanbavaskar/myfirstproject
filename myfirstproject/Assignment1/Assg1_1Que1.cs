using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Assignment1
{
    class Assg1_1Que1
    {
        // calculator using switchcase
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Press:\n + \n - \n * \n /");
            char check = Convert.ToChar(Console.ReadLine());
            switch (check)
            {
                case '+': Console.WriteLine("Addition is : " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction is : " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication is : " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Division is : " + (num1 / num2));
                    break;
                default: Console.WriteLine("Invalid !!");
                    break;
            }
        }
    }

    // display the day of the week corresponding to the number entered

    class Assg1_1Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. of day between 1 to 7");
            int DayNum = int.Parse(Console.ReadLine());
            switch (DayNum)
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
                    Console.WriteLine("Thusday");
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
                    Console.WriteLine("Error, the day does not exist");
                    break;
            }
        }
    }

    // take input in number and display in word between 1 to 5
    class Assg1_1Que3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 5");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Out of range");
                    break;
            }
        }
    }

    //WAP in using switch case for following : area of circle, area of square, area of a right
    // angle triangle, area of a rectangle, circumference of a circle, perimeter of a square
    // accept inputs like: radius, side,etc through keyboard (menu driven program)
    class Assg1_1Que4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU : \n 1.Area of cicle \n 2.Area of square" +
                    "\n 3.Area of rectangle \n 4.Area of triangle\n 5.Perimeter of circle" +
                    "\n 6.Perimeter of square");

            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter radius ");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of Circle : " + 3.14 * r * r);
                    break;
                case 2:
                    Console.WriteLine("Enter side");
                    int side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square : " + side * side);
                    break;
                case 3:
                    Console.WriteLine("Enter length");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of rectangle : " + length * width);
                    break;
                case 4:
                    Console.WriteLine("Enter base");
                    int baSe = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter height");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of triangle : " + 0.5 * baSe * height);
                    break;
                case 5:
                    Console.WriteLine("Enter radius ");
                    double rad = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Perimeter of Circle : " + 2*3.14 *rad);
                    break;
                case 6:
                    Console.WriteLine("Enter side");
                    int side1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter of square : " + side1 * 4);
                    break;
                default: Console.WriteLine("Invalid Choice");
                    break;

            }
        }
    }










}
