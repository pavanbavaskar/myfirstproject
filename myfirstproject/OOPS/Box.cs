using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Box
    {
        public float height;
        public float width;
        public float length;

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.height = 5;
            box1.width = 3;
            box1.length = 8;
            Console.WriteLine("Area is : "+(box1.length*box1.width));
            Console.WriteLine("Volume is : "+(box1.length*box1.width*box1.height));

            Box box2 = new Box();
            box2.height = 4;
            box2.width = 2;
            box2.length = 7;
            Console.WriteLine("Area is : " + (box2.length * box2.width));
            Console.WriteLine("Volume is : " + (box2.length * box2.width * box2.height));

        }


    }
}
