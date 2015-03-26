using System;
using System.Collections.Generic;

class Student : Person,ICommentable
{    
    private int numberInClass = 0;
    private List<string> comments = new List<string>();

    public Student(string name, int numberInClass)
        : base(name)
    {        
        this.NumberInClass = numberInClass;
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

    public int NumberInClass
    {
        get { return this.numberInClass; }
        set { this.numberInClass = value; }
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

