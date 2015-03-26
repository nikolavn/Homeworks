using System;
using System.Collections.Generic;

class Class:ICommentable
{
    private string classID = null;
    private List<Student> studentsInClass = new List<Student>();
    private List<Teacher> teachers = new List<Teacher>();
    private List<string> comments = new List<string>();
    
    public Class(string id, List<Student> students,List<Teacher> teachers)
    {
        this.ClassID = id;
        this.StudentsInClass = students;
        this.Teachers = teachers;
    }

    public List<string> Comments
    {
        get
        {
            return this.comments;
        }
        set
        {
            this.comments = value;
        }
    }

    public string ClassID
    {
        get { return this.classID; }
        set { this.classID = value; }
    }

    internal List<Student> StudentsInClass
    {
        get { return this.studentsInClass; }
        set { this.studentsInClass = value; }
    }

    internal List<Teacher> Teachers
    {
        get { return teachers; }
        set { teachers = value; }
    }

    public void AddStudent(Student newStudent)
    {
        this.StudentsInClass.Add(newStudent);
    }

    public void RemoveStudent(Student student)
    {
        this.StudentsInClass.Remove(student);
    }

    public void AddTeacher(Teacher newTeacher)
    {
        this.Teachers.Add(newTeacher);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        this.Teachers.Remove(teacher);
    }

    public void AddComment(string comment)
    {
        this.Comments.Add(comment);
    }

    public void RemoveComment(string comment)
    {
        if (this.Comments.Contains(comment))
        {
            this.Comments.Remove(comment);
        }
        else
        {
            throw new ArgumentException("Comment you're trying to remove doesn't exist.");
        }
    }
}

