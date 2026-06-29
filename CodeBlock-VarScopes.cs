using System;
using BoolsEvaluating;

public class CodeBlocksVarScopes()
{
  

    public static void Start()
    {
        Console.Clear();
        Random rand = new Random();
        int random = rand.Next(40,44);
        int[] numbers = { 4, 8, 15, 16, 23, random };
        bool found = false;
        int total = 0;
        
        foreach (int number in numbers)
        {
            total += number;
            if (number == 42) {found = true;}
        }

        if (found) {Console.WriteLine("\nGet in, the set contains 42, the meaing of life!!!1");}else{Console.WriteLine("\nahhhhhhhh");}
        Console.WriteLine($"Total: {total}");
        
        Console.WriteLine("\nPress '1' to try again ('x' to exit)");

        ConsoleKeyInfo input = Console.ReadKey(true);

        switch (input.KeyChar)
        {
            case '1': Start(); break;
            case 'x': Program.Start(); break;
        }

    }


}