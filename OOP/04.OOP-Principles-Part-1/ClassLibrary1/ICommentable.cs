using System;
using System.Collections.Generic;
using System.Linq;

public interface ICommentable
{
    void AddComment(string comment);
    void RemoveComment(string comment);
}

