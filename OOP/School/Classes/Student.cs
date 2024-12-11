﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Classes
{
    class Student : Person
    {
        public string StudentID { get; set; }
        public Grade GradeLevel { get; set; }
        public List<Subject> subjectlist = new List<Subject>();
        public double GPA { get; set; }

        public Student(string name, int age, string address, string studentID, double gpa) : base(name, age, address)
        {
            StudentID = studentID;
          
            GPA = gpa;
        }
        

        public void EnrollinSubject()
        {

        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Student ID: {StudentID}");
            Console.WriteLine($"GradeLeve: {GradeLevel}");
            Console.WriteLine($"Subjects:");
            Console.WriteLine($"GPA: {GPA}");

        }
    }
}