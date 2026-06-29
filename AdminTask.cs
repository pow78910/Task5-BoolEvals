using System;
using System.Diagnostics.Tracing;
using System.Linq.Expressions;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using BoolsEvaluating;

public class AdminTask()
{
    
    public static string? permission = "None";
    public static int level = 55;
    public static string? input = "None";
    


    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("Please enter your role(Admin/Manager/Prod/'x + ENTER' to exit)");
        input = Console.ReadLine().ToLower();

        while(!(input.Contains("admin")|| input.Contains("manager") || input.Contains("prod") || input == "x"))
        {
             Console.WriteLine("Invalid Input, try again");
            input = Console.ReadLine();

        }
        if (input == "x"){Program.Start();} 
        permission = input.Contains("admin") ? "Admin" : "Manager/Prod"; 

        Console.WriteLine("Enter you permission Level (0-100)");
         input = Console.ReadLine();
        while(!int.TryParse(input, out level))
        {
           Console.WriteLine("Invalid Input, try again");
           input = Console.ReadLine();

        }

        Authentication();     
        Console.ReadKey();
        
    }

    public static void Authentication()
    {
        if (permission.Contains("Admin"))
        {
            if (level > 55)
            {
                SudoUser();
            }
            else
            {
                AdminUser();
            }
        }
        else if (permission.Contains("Manager"))
        {
            if (level >= 20)
            {
                Manager();
            }
            else
            {
                Prod();
            }
        }
        else
        {
            Prod();
        }
    }

    public static void SudoUser()
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    public static void AdminUser()
    {
        Console.WriteLine("Welcome, Admin user.");
    }

    public static void Manager()
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    public static void Prod()
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }

}

