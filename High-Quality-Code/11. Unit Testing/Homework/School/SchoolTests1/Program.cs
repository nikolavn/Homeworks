using System;
using System.Collections.Generic;
using School;

namespace SchoolTests1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 30; i++)
            {
                var currentStudent = new Student("test");
                students.Add(currentStudent);
            }

            foreach (var student in students)
            {

                Console.WriteLine(student.ID);

            }


            SchoolInstance newSchool = new SchoolInstance("testSchool");
            Course newCourse = new Course("testCourse");


            Student newStudent = new Student("gosho");
            newCourse.AddStudent(newStudent);
            newSchool.AddCourse(newCourse);

            Console.WriteLine(newCourse.ToString());
            Console.WriteLine(newSchool.ListStudents());
        }
    }
}
