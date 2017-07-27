using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var stones = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var lake = new Lake(stones);

        var orderedStones = new List<int>();

        foreach (var stone in lake)
        {
            orderedStones.Add(stone);
        }
        Console.WriteLine(string.Join(", ", orderedStones));
    }
}