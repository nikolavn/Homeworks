using System;
using System.Collections.Generic;
using School;

namespace SchoolTests
{
    public class Program
    {
        public void Main(string[] args)
        {
            List<School.Student> students = new List<School.Student>();

            for (int i = 0; i < 30; i++)
            {
                var currentStudent = new School.Student("test");
                students.Add(currentStudent);
            }

            foreach (var student in students)
            {
                Console.WriteLine(student.ID);
            }
        }
    }
}
