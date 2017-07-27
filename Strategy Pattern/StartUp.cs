using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var popleSortedByName = new SortedSet<Person>(new NameComparator());
        var popleSortedByAge = new SortedSet<Person>(new AgeComparator());

        var number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            var details = Console.ReadLine().Split();
            var name = details[0];
            var age = int.Parse(details[1]);

            popleSortedByName.Add(new Person(name, age));
            popleSortedByAge.Add(new Person(name, age));
        }

        Console.WriteLine(string.Join(Environment.NewLine, popleSortedByName));
        Console.WriteLine(string.Join(Environment.NewLine, popleSortedByAge));
    }
}