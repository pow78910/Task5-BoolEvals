using System;
using System.Collections;
using BoolsEvaluating;

class SwitchCases()
{

    public static void Start()
    {
        Console.Clear();
        // SKU = Stock Keeping Unit. 
        // SKU value format: <product #>-<2-letter color code>-<size code>
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01": type = "Sweat shirt";  break;
            case "02": type = "T-shirt"; break;
            default: type = "Other"; break;  
        }
        switch (product[1])
        {
            case "BL": color = "Black"; break;
            case "MN": color = "Maroon"; break; 
            default: color = "White"; break; 
        }
        switch (product[2])
        {
            case "S": size = "Small"; break;
            case "M": size = "Medium"; break;
            case "L": size = "Large"; break; 
            default: size = "One size fits all"; break; 
        }

        Console.WriteLine(sku);
        Console.WriteLine($"Product: {size} {color} {type}");


          Console.WriteLine("\nPress '1' to try again ('x' to exit)");

          Console.WriteLine("\n\n\nJUST EXIT FOR NOW, THIS FUNCTION SHOULD HAVE A FEATURE INCLUDED WHERE YOU CAN TYPE YOUR OWN CODE IN FOR THE OUTPUT,\nIT WILL NEED TO MAKE SURE THAT IT FOLLOW THE CONVENTION,\n DOES THIS NEEDED TO BE CODED IN USING SUBSTRING, A IN-BUILT FUNCTION OR CAN SOMETHING LIKE REGEX BE USED??? ");

        ConsoleKeyInfo input = Console.ReadKey(true);

        switch (input.KeyChar)
        {
            case '1': Start(); break;
            case 'x': Program.Start(); break;
        }

            }
}