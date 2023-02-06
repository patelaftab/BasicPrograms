using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Basic Core Programs");
            Console.WriteLine("Choose a Option \n" +
                "1: FlipCoin Problem");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option) 
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CoinFlip();
                    break;
                default:
                    Console.WriteLine("Choose a Correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
