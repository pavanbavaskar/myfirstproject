using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.OOPS
{
    class Student
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
            student1.Id = 101;
            student1.name = "Krushna";
            student1.sub1Marks = 91;
            student1.sub2Marks = 75;
            student1.sub3Marks = 70;
            student1.marks = (student1.sub1Marks + student1.sub2Marks + student1.sub3Marks) / 300.0f;
            Console.WriteLine(student1.marks * 100.0f);


            Student student2 = new Student();
            student2.Id = 102;
            student2.name = "Shruti";
            student2.sub1Marks = 90.0f;
            student2.sub2Marks = 78.0f;
            student2.sub3Marks = 87.0f;
            student2.marks = (student2.sub1Marks + student2.sub2Marks + student2.sub3Marks) / 300.0f;
            Console.WriteLine(student2.marks * 100.0f);



        }
    }
}
