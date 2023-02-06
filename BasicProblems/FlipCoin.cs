using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class FlipCoin
    {
        public  void CoinFlip()
        {
            Console.WriteLine("Enter a how many Time you Want to Flip The Coin");
            int flipnum=Convert.ToInt32(Console.ReadLine());
            int Head = 0, Tail = 0;
            Random random = new Random();
            for(int i=0;i<flipnum;i++)
            {
                double numcheck=random.NextDouble();
                if (numcheck>0.5)
                {
                    Head++;
                }
                else 
                {
                    Tail++;
                }
                
            }
            double Headpercentage = Head * 100 / flipnum;
            double Tailpercentage = Tail * 100 / flipnum;
            Console.WriteLine("Head Percentage Is :" + Headpercentage);
            Console.WriteLine("Tail percentage Is :" + Tailpercentage);
        }
    }
}
