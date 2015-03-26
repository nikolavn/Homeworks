using System;
using System.Collections.Generic;

class Discipline:ICommentable
{
    private string disciplineName = null;
    private int numberOfLectures = 0;
    private int numberOfExersizes = 0;
    private List<string> comments = new List<string>();

    public Discipline(string name, int lectures, int exersizes)
    {
        this.DisciplineName = name;
        this.NumberOfLectures = lectures;
        this.NumberOfExersizes = exersizes;
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

    public string DisciplineName
    {
        get { return this.disciplineName; }
        set { this.disciplineName = value; }
    }

    public int NumberOfLectures
    {
        get { return this.numberOfLectures; }
        set { this.numberOfLectures = value; }
    }

    public int NumberOfExersizes
    {
        get { return this.numberOfExersizes; }
        set { this.numberOfExersizes = value; }
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

