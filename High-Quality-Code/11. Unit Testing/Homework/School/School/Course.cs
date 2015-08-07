using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Course
    {
        private const int MaximumStudentsInCourse = 30;

        private List<Student> studentsList;
        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.studentsList = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (object.Equals(student, null))
            {
                throw new ArgumentNullException("Student to add can not be null");
            }

            if (this.studentsList.Count >= MaximumStudentsInCourse)
            {
                throw new ArgumentOutOfRangeException("Students in course cannot be more than 30");
            }

            if (this.studentsList.Contains(student))
            {
                throw new ArgumentException("Student is already in the list");
            }

            this.studentsList.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (object.Equals(student, null))
            {
                throw new ArgumentNullException("Student can not be null");
            }

            if (!this.studentsList.Contains(student))
            {
                throw new ArgumentException("Student is not in list");
            }

            this.studentsList.Remove(student);
        }

        public string ListStudents()
        {
            StringBuilder listOfStudents = new StringBuilder();

            foreach (var student in this.studentsList)
            {
                listOfStudents.Append(student.ToString() + Environment.NewLine);
            }

            return listOfStudents.ToString();
        }

        public override string ToString()
        {
            return this.Name + Environment.NewLine + this.ListStudents();
        }
    }
}