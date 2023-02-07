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
                "1: FlipCoin Problem\n" +
                "2: Leap Year Program\n"+
                "3: Power Of Two");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option) 
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CoinFlip();
                    break;
                case 2:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Checkyear();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.Table();
                    break;
                default:
                    Console.WriteLine("Choose a Correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
