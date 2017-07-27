using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var people = new List<Person>();

        int equal = 0;
        int notequal = 0;

        var input = Console.ReadLine();

        while (input != "END")
        {
            var inputArgs = input.Split();
            people.Add(new Person(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));

            input = Console.ReadLine();
        }

        var index = int.Parse(Console.ReadLine()) - 1;

        var personToCompare = people[index];

        foreach (var peron in people)
        {
            int value = peron.CompareTo(personToCompare);

            if (value == 0)
            {
                equal++;
            }
            else
            {
                notequal++;
            }
        }

        if (equal == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equal} {notequal} {people.Count}");
        }
    }
}