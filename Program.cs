using System;
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
            Console.WriteLine("3. Code blocks and variable scope");

            ConsoleKeyInfo input = Console.ReadKey(true);


            while (true)
            {
                switch(input.KeyChar)
                {
                    case '1':
                        CoinClass.CoinMeth();
                    break;
                    case '2':
                        AdminTask.Start();
                    break;
                    case '3':
                        CodeBlockVarScopes.Start();
                    break;
                            
                    
                }
                        
                        
            }
        }
    }
    

 
}