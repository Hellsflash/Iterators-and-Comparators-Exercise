using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var firstPerson = new SortedSet<Person>(new Comparer());
        var secondPerson = new HashSet<Person>(new Equalizer());

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            var details = Console.ReadLine().Split();

            firstPerson.Add(new Person(details[0], int.Parse(details[1])));
            secondPerson.Add(new Person(details[0], int.Parse(details[1])));
        }
        Console.WriteLine(firstPerson.Count);
        Console.WriteLine(secondPerson.Count);
    }
}