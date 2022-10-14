using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Student_1
    {
        public int Id;
        public string name;
        public float marks;
        public float sub1Marks;
        public float sub2Marks;
        public float sub3Marks;

        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("Enter Id");
            student1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            student1.name = Console.ReadLine();
            Console.WriteLine("Enter Sub1 Marks");
            student1.sub1Marks = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Sub2 Marks");
            student1.sub2Marks = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Sub3 Marks");
            student1.sub3Marks = Convert.ToByte(Console.ReadLine());

            student1.marks = ((student1.sub1Marks + student1.sub2Marks + student1.sub3Marks) / 300.0f)*100.0f;

            Console.WriteLine($"ID : {student1.Id} \nName : {student1.name} \nPecentage : {student1.marks}");



        }
    }
}
