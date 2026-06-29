using System;
using System.Security.Cryptography.X509Certificates;
using BoolsEvaluating;

class ForLoops()
{
      //creates numbers array with length of 100 
        public static double[] numbersArr = new double[100];
        public static string[] fizzOrBuzz = new string[100];
  

  //maybe add function for random number in a range e.g. 399 - 3821
  //fizz buzz calc can be applied to all the numbers within the range
  //will need to change the way the arrays are init, or create a new one for random. 
  //could also just declare the array limit, user can determine the range within that range
  //any element after would simply be blank. 
    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("This is the Fizz Buzz challenge");
        NumbersArr();
        FizzBuzzCalc(numbersArr);
        
        
       
        for (int x = 0; x < 100; x++)
        {
        
           Console.WriteLine($"{numbersArr[x]} - {fizzOrBuzz[x]}");  

        }
    Console.WriteLine("\nPress '1' to try again ('x' to exit)");

        ConsoleKeyInfo input = Console.ReadKey(true);

        switch (input.KeyChar)
        {
            case '1': Start(); break;
            case 'x': Program.Start(); break;
        }
        
        


        

    }

    public static double [] NumbersArr()
    {
        for (int i = 0; i < numbersArr.Length; i++)
        {//gives each value with the array the value of i+1 in the loop i.e. 1 - 100
            numbersArr[i] = i + 1;
        }

        return numbersArr;
    }

    public static string[] FizzBuzzCalc(double[] numbersArr)
    {
        for (int i = 0; i < numbersArr.Length; i++)
        {
            if (numbersArr[i] % 3 == 0 && numbersArr[i] % 5 != 0)
                {
                    fizzOrBuzz[i] = "Fizz";
                }
            else if (numbersArr[i] % 5 == 0 && numbersArr[i] % 3 != 0)
                {
                    fizzOrBuzz[i] = "Buzz";
                }
            else if (numbersArr[i] % 5 == 0 && numbersArr[i] % 3 == 0)
            {
                fizzOrBuzz[i] = "FizzBuzz";
            } 
            else
            {
                fizzOrBuzz[i] = "nah";
            }
        }
        return fizzOrBuzz;
    }
    
}