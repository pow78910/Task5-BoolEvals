using System;
using System.Security.Cryptography.X509Certificates;
using BoolsEvaluating;

class ForLoops()
{
  
    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("This is the Fizz Buzz challenge");

        for (int x = 0; x < 100; x++)
        {
        // pause - need another index for the final output that concats the two results from the number index and the fizz buzz index
        // or find the way needed to just output them straight out by calling both
        Console.WriteLine(FizzBuzzCalc(NumbersArr()));
        }

        Console.ReadKey();
        



        

    }

    public static double [] NumbersArr()
    {
        double[] numbersArr = new double[100];

        for (int i = 0; i < numbersArr.Length; i++)
        {
            numbersArr[i] = i + 1;
        }

        return numbersArr;
    }

    public static string[] FizzBuzzCalc(double[] numbersArr)
    {
         string[] fizzOrBuzz = new string[100];

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