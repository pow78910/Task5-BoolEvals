using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;


namespace BoolsEvaluating
{
    class Program()
    {

       
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Pick an option");
            Console.WriteLine("1. Coin flip");
            Console.WriteLine("2.Admin/Manager Authentication Check");
            Console.WriteLine("3.Code blocks and variable scope");
            Console.WriteLine("4.Switch cases");
            

            ConsoleKeyInfo input = Console.ReadKey(true);


            while (true)
            {
                switch(input.KeyChar)
                {   
                    case '1': CoinClass.CoinMeth(); Console.ReadKey(); break;
                    case '2':AdminTask.Start(); Console.ReadKey(); break;
                    case '3': CodeBlocksVarScopes.Start(); Console.ReadKey(); break;
                    case '4': SwitchCases.Start(); Console.ReadKey(); break;
                }
                        
                        
            }
        }
    }
    

 
}