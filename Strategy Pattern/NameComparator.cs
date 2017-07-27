using System;
using System.Collections.Generic;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            char firstLetterX = x.Name[0];
            char secondLetterX = y.Name[0];

            result = string.Compare(firstLetterX.ToString(), secondLetterX.ToString(),
                StringComparison.CurrentCultureIgnoreCase);
        }
        return result;
    }
}