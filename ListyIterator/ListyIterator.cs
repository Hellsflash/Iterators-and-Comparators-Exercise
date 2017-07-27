using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListyIterator<T> : IEnumerable<T>
{
    private int index;

    public ListyIterator()
    {
        this.Collection = new List<T>();
    }

    public ListyIterator(IEnumerable<T> collection) : this()
    {
        this.Collection = collection.ToList();
    }

    public List<T> Collection { get; }

    public bool Move()
    {
        this.index++;
        if (this.index < this.Collection.Count)
        {
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (index < this.Collection.Count - 1)
        {
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (this.Collection.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        Console.WriteLine(this.Collection[index]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.Collection.Count; i++)
        {
            yield return this.Collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}