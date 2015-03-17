using System;
using System.Collections.Generic;
using System.Linq;


class GenericList<T> : IEnumerable<T> where T : IComparable
{
    private T[] items;

    public GenericList(int capacity)
    {
        this.Capacity = capacity;
        this.items = new T[this.Capacity];
    }

    public int Capacity
    {
        get;
        set;
    }

    public int Count { get; set; }

    public T this[int index]
    {
        get
        {
            if (0 < index && index < this.Capacity)
            {
                return this.items[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("Index should be positive and less than " + (this.Count-1));
            }
        }
        set
        {
            if (0 < index && index < this.Capacity)
            {
                this.items[index] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            var oldItems = this.items;
            this.Capacity *= 2;
            this.items = new T[this.Capacity];
            Array.Copy(oldItems, 0, this.items, 0, this.Count);
        }

        this.items[this.Count] = item;
        this.Count++;
    }

    public void ClearList()
    {
        Array.Clear(this.items, 0, this.items.Length);
        this.Count = 0;
    }

    public int IndexOf(T value)
    {
        int elementIndex = 0;

        for (int counter = 0; counter < this.Count; counter++)
        {
            if (this.items[counter].CompareTo(value) == 0)
            {
                elementIndex = counter;
                break;
            }

            elementIndex = -1;
        }

        return elementIndex;
    }

    public void InsertAt(int index, T element)
    {
        if (0 > index || index > this.Count)
        {
            throw new ArgumentOutOfRangeException("Invalid index: " + index);
        }

        if (this.Count == this.Capacity)
        {
            var oldItems = this.items;
            this.Capacity++;
            this.items = new T[this.Capacity];
            Array.Copy(oldItems, 0, this.items, 0, this.Count);
        }

        T[] tempArray = new T[Capacity - 1 - index];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = this.items[index + i];
        }

        this.items[index] = element;
        this.Count++;

        Array.Copy(tempArray, 0, this.items, index + 1, tempArray.Length);
    }

    public T Max()
    {
        T maxValue = this.items[0];

        for (int i = 1; i < this.Count; i++)
        {
            if (maxValue.CompareTo(this.items[i]) < 0)
            {
                maxValue = this.items[i];
            }
        }

        return maxValue;
    }

    public T Min()
    {
        T minValue = this.items[0];

        for (int i = 1; i < this.Count; i++)
        {
            if (minValue.CompareTo(this.items[i]) > 0)
            {
                minValue = this.items[i];
            }
        }

        return minValue;
    }

    public void RemoveAt(int index)
    {
        if (0 > index || index > this.Count)
        {
            throw new ArgumentOutOfRangeException("Invalid index: " + index);
        }

        var removedItem = this.items[index];

        for (int i = index; i < this.Count - 1; i++)
        {
            this.items[i] = this.items[i + 1];
        }

        this.items[this.Count - 1] = default(T);
        this.Count--;
        this.Capacity--;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Count; i++)
        {
            var item = this.items[i];
            yield return item;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

