using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private List<T> collection;

    public Stack()
    {
        this.collection = new List<T>();
    }

    public List<T> Collection => this.collection;

    public void Push(T element)
    {
        this.collection.Add(element);
    }

    public void Pop()
    {
        if (this.collection.Count == 0)
        {
            throw new ArgumentException("No elements");
        }

        var lastElement = this.collection.Last();
        var index = this.collection.LastIndexOf(lastElement);
        this.collection.RemoveAt(index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.collection.Count - 1; i >= 0; i--)
        {
            yield return this.collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}