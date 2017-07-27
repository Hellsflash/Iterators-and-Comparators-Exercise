using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var stack = new Stack<string>();

        var input = Console.ReadLine();

        while (input != "END")
        {
            var inputArgs = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var command = inputArgs[0];

            switch (command)
            {
                case "Push":
                    for (int i = 1; i < inputArgs.Length; i++)
                    {
                        stack.Push(inputArgs[i]);
                    }
                    break;

                case "Pop":
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
            }
            input = Console.ReadLine();
        }
        stack.ToList().ForEach(e => Console.WriteLine(e));
        stack.ToList().ForEach(e => Console.WriteLine(e));
    }
}