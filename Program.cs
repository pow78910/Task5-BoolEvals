using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;

namespace BoolsEvaluating
{
    class Program()
    {

       public static string coinFace = ""; 
        public static int coinFlip;
        static void Main(string[] args)
        {
            while(true)
            {
            coinFlip = CoinFlip();
            coinFace = CoinFace(coinFlip);
            Output(coinFace);
            Console.ReadKey();
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
}