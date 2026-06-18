using System;
using BoolsEvaluating;


public class CoinClass()
{

        public static string coinFace = ""; 
        public static int coinFlip;
    public static void CoinMeth()
        {
            Console.Clear();
            Console.Write("\n");
           
            while(true)
            {
                
            Console.WriteLine("Press 1 to flip a coin('x' to exit)");
           
            ConsoleKeyInfo input = Console.ReadKey(true);
            Console.Clear();
                switch(input.KeyChar)
                {
                    case '1':
                        coinFlip = CoinFlip();
                        coinFace = CoinFace(coinFlip);
                        Output(coinFace);
                        
                    break;
                    case 'x':
                        Program.Start();
                    break;
                    default:
                        Console.WriteLine();
                    break;
                        
                        
                }
            }
        
                
        }
            public static int CoinFlip()
            {
                    Random coinFlipRand = new Random();
                    coinFlip = coinFlipRand.Next(2);
                    return coinFlip;
                    
            }
            public static string CoinFace(int coinFlip)
            {
                coinFace = coinFlip == 0 ? "Heads" : "Tails";
                return coinFace;
            }

            public static void Output(string output)
            {
                Console.WriteLine(output);
            }
    }
    