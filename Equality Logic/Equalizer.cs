using System.Collections.Generic;

public class Equalizer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y)
    {
        var result = x.Name.Equals(y.Name);

        if (result)
        {
            result = x.Age.Equals(y.Age);
        }
        return result;
    }

    public int GetHashCode(Person obj)
    {
        int result = obj.Name.GetHashCode() + obj.Age.GetHashCode();
        return result;
    }
}