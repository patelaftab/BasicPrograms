using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class OddEven
    {
        public void Checkingoddeven()
        {
            Console.WriteLine("Enter a Number To Check");
            int number=Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Number Is Even Number :" +number);
            }
            else
            {
                Console.WriteLine("Number Is Odd Number :" +number);
            }
        }
    }
}
