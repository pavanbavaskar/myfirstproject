using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Car
    {
        public string Brand;
        public int Model_No;
        public int Price;
        public string Colour;

        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car1.Brand = "Maruti";
            Car1.Model_No = 8;
            Car1.Price = 980000;
            Car1.Colour = "White";
            Console.WriteLine(Car1.Brand+" "+Car1.Model_No+" "+Car1.Price+" "+Car1.Colour);

            Car Car2 = new Car();
            Car2.Brand = "TATA";
            Car2.Model_No = 5;
            Car2.Price = 800000;
            Car2.Colour = "Black";
            Console.WriteLine(Car2.Brand + " " + Car2.Model_No + " " + Car2.Price + " " + Car2.Colour);

            Car Car3 = new Car();
            Car3.Brand = "Mahindra";
            Car3.Model_No = 6;
            Car3.Price = 900000;
            Car3.Colour = "Red";
            Console.WriteLine(Car3.Brand + " " + Car3.Model_No + " " + Car3.Price + " " + Car3.Colour);
        }
    }
}
