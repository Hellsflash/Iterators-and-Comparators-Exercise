using System;
using System.Collections.Generic;

public class StaruUp
{
    public static void Main()
    {
        var myList = new ListyIterator<string>();

        var input = Console.ReadLine();

        while (input != "END")
        {

            var inputArgs = input.Split();
            var command = inputArgs[0];

            switch (command)
            {
                case "Create":
                    var collection = new List<string>();

                    for (int i = 1; i < inputArgs.Length; i++)
                    {
                        collection.Add(inputArgs[i]);
                    }

                    myList = new ListyIterator<string>(collection);
                    break;

                case "Move":
                    Console.WriteLine(myList.Move());
                    break;

                case "HasNext":
                    Console.WriteLine(myList.HasNext());
                    break;

                case "Print":
                    try
                    {
                        myList.Print();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;

                case "PrintAll":
                    Console.WriteLine(string.Join(" ", myList.Collection));
                    break;
            }
            input = Console.ReadLine();
        }
    }
}