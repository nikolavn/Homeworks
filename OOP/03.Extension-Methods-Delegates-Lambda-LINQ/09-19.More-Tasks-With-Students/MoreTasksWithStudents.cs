using System;
using System.Collections.Generic;
using System.Linq;

class MoreTasksWithStudents
{
    static void Main()
    {
        #region Task 9
        //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        //Create a List<Student> with sample students. Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.

        List<Student> students = new List<Student>();

        Student student1 = new Student()
        {
            FirstName = "Ivan",
            LastName = "Ivanov",
            FN = 123404,
            Tel = "028888881",
            Email = "ivanivanov@abv.bg",
            Marks = new List<double>() { 4.5, 3.6, 5.08, 6.45 },
            GroupNumber = 2
        };

        Student student2 = new Student()
        {
            FirstName = "Petar",
            LastName = "Ivanov",
            FN = 123405,
            Tel = "0328888882",
            Email = "petarivanov@amail.bg",
            Marks = new List<double>() { 4.5, 3.6, 5.08, 6.0 },
            GroupNumber = 4
        };

        Student student3 = new Student()
        {
            FirstName = "Asen",
            LastName = "Petrov",
            FN = 123406,
            Tel = "064888883",
            Email = "asenpetrov@gmail.bg",
            Marks = new List<double>() { 4.5, 6.45 },
            GroupNumber = 2
        };

        Student student4 = new Student()
        {
            FirstName = "Petar",
            LastName = "Petrov",
            FN = 123407,
            Tel = "028888884",
            Email = "petarpetrov@abv.bg",
            Marks = new List<double>() { 4.5, 6.45 },
            GroupNumber = 3
        };

        List<Group> groups = new List<Group>();

        Group group1 = new Group() { GroupNumber = 1, DepartmentName = "Physics" };
        Group group2 = new Group() { GroupNumber = 4, DepartmentName = "Mathematics" };
        Group group3 = new Group() { GroupNumber = 2, DepartmentName = "Computer Science" };
        Group group4 = new Group() { GroupNumber = 3, DepartmentName = "Sports" };

        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);

        groups.Add(group1);
        groups.Add(group2);
        groups.Add(group3);
        groups.Add(group4);

        var group2Students =
        from stud in students
        where stud.GroupNumber == 2
        orderby stud.FirstName
        select stud;

        #endregion

        #region Task 10
        //Implement the previous using the same query expressed with extension methods.

        var group2StudentsExt = students.FindAll(s => s.GroupNumber == 2)
        .OrderBy(st => st.FirstName);

        #endregion

        #region Task 11
        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.

        var abvMailStudents =
        from stud in students
        where stud.Email.Contains("abv.bg")
        select stud;

        #endregion

        #region Task 12
        //Extract all students with phones in Sofia.
        //Use LINQ.

        var sofiaTelStudents =
            from stud in students
            where stud.Tel.Contains("02")
            select stud;

        #endregion

        #region Task 13
        //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        //Use LINQ.

        var excellentMark =
        from stud in students
        where stud.Marks.Contains(6)
        select new { FullName = stud.FirstName + " " + stud.LastName, Marks = stud.Marks };

        #endregion

        #region Task 14
        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.

        var studentsWithTwoMarks =
            from stud in students
            where stud.Marks.Count == 2
            select stud;

        #endregion

        #region Task 15
        //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

        var studentsFrom2005and2006 =
            from stud in students
            where stud.FN % 100 == 5 || stud.FN % 100 == 6
            select stud.Marks;

        #endregion

        #region Task 16
        //Create a class Group with properties GroupNumber and DepartmentName.
        //Introduce a property GroupNumber in the Student class.
        //Extract all students from "Mathematics" department.
        //Use the Join operator.

        var studentsInMaths =
            from stud in students
            join gr in groups on stud.GroupNumber equals gr.GroupNumber
            where gr.DepartmentName == "Mathematics"
            select stud;
       

        #endregion

        #region Task 18
        //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //Use LINQ.

        var groupedByGroupNumber =
            from stud in students
            group stud by stud.GroupNumber into newGroup
            orderby newGroup.Key
            select newGroup;

        #endregion

        #region Task 19
        //Rewrite the previous using extension methods.

        var groupedByGroupNumberExt = students.GroupBy(s => s.GroupNumber).OrderBy(k => k.Key);

        #endregion

        #region Printing Results

        Console.WriteLine(new String('=', 20) + "Task 9" + new String('=', 30));

        foreach (var student in group2Students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 10" + new String('=', 30));

        foreach (var student in group2StudentsExt)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 11" + new String('=', 30));

        foreach (var student in abvMailStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 12" + new String('=', 30));

        foreach (var student in sofiaTelStudents)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 13" + new String('=', 30));

        foreach (var student in excellentMark)
        {
            Console.WriteLine(student.FullName + "  " + string.Join(" ", student.Marks));
        }

        Console.WriteLine(new String('=', 20) + "Task 14" + new String('=', 30));

        foreach (var student in studentsWithTwoMarks)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 15" + new String('=', 30));

        foreach (var marks in studentsFrom2005and2006)
        {
            Console.WriteLine(string.Join(" ", marks));
        }

        Console.WriteLine(new String('=', 20) + "Task 16" + new String('=', 30));

        foreach (var student in studentsInMaths)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine(new String('=', 20) + "Task 18" + new String('=', 30));

        foreach (var groupNumber in groupedByGroupNumber)
        {
            Console.WriteLine("Group: {0}", groupNumber.Key);

            foreach (var student in groupNumber)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }

        Console.WriteLine(new String('=', 20) + "Task 19" + new String('=', 30));

        foreach (var groupNumber in groupedByGroupNumberExt)
        {
            Console.WriteLine("Group: {0}", groupNumber.Key);

            foreach (var student in groupNumber)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
        #endregion
    }
}

