using System;

class InvalidRangeException<T> : ArgumentOutOfRangeException
{
    private T rangeStart;
    private T rangeEnd;

    public InvalidRangeException(string message)
        : base(message)
    {

    }

    public InvalidRangeException(T rangeStart, T rangeEnd, string message = null)
        : base(message)
    {
        this.RangeStart = rangeStart;
        this.RangeEnd = rangeEnd;
    }

    public T RangeStart
    {
        get { return this.rangeStart; }
        set { this.rangeStart = value; }
    }

    public T RangeEnd
    {
        get { return this.rangeEnd; }
        set { this.rangeEnd = value; }
    }

}

