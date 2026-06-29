using System;
using System.Collections;
using System.Transactions;
using BoolsEvaluating;

public class DoWhileLoop()
{

        public static Random random = new Random(); 
    public static double current = random.Next();


    public static void Start()
    {
    
        Console.Clear();
        Console.WriteLine("This method shows you an example of the do while loop being used");

        RandomNumber();
        Console.ReadKey();

    }

     public static void RandomNumber()
    {
        /*
        do 
        { 
            current = random.Next(1,11);
            Console.WriteLine(current);
        
            
        }while (current != 7);

        Console.Write ("LOOOOOK IT'S A 7");S
        */
current = random.Next(1,11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1,11);
        }
        Console.WriteLine($"Last number: {current}, testing - press a key to go again");
        Console.ReadKey();
        RandomNumber();

    }


}