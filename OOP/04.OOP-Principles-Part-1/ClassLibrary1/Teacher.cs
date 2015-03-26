using System;
using System.Collections.Generic;

class Teacher : Person,ICommentable
{
    private List<Discipline> disciplines = new List<Discipline>();
    private List<string> comments = new List<string>();

    public Teacher(string name, List<Discipline> disciplines)
        : base(name)
    {
        this.Disciplines = disciplines;
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

    internal List<Discipline> Disciplines
    {
        get { return this.disciplines; }
        set { this.disciplines = value; }
    }

    public void AddDiscipline(Discipline newDiscipline)
    {
        this.Disciplines.Add(newDiscipline);
    }

    public void RemoveDiscipline(Discipline discipline)
    {
        this.Disciplines.Remove(discipline);
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

