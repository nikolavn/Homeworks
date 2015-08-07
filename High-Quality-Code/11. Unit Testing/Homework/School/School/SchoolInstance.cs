using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class SchoolInstance
    {
        private string name;
        private IList<Course> coursesList;

        public SchoolInstance(string name)
        {
            this.Name = name;
            this.coursesList = new List<Course>();
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
                    throw new ArgumentNullException("School name can not be null.");
                }

                this.name = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (object.Equals(course, null))
            {
                throw new ArgumentNullException("Course to add can not be null");
            }

            if (this.coursesList.Contains(course))
            {
                throw new ArgumentException("Course is already in the list");
            }

            this.coursesList.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (object.Equals(course, null))
            {
                throw new ArgumentNullException("Course can not be null");
            }

            if (!this.coursesList.Contains(course))
            {
                throw new ArgumentException("Course is not in list");
            }

            this.coursesList.Remove(course);
        }

        public string ListCourses()
        {
            var coursesInSchool = new StringBuilder();

            foreach (var course in this.coursesList)
            {
                coursesInSchool.Append(course.ToString());
            }

            return coursesInSchool.ToString();
        }

        public string ListStudents()
        {
            var studentsInSchool = new StringBuilder();

            foreach (var course in this.coursesList)
            {
                studentsInSchool.Append(course.ListStudents());
            }

            return studentsInSchool.ToString();
        }
    }
}