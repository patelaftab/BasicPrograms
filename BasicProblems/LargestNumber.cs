using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class LargestNumber
    {
        public void LargestAmong()
        {
            int Num1, Num2, Num3;
            Console.WriteLine("Enter Number 1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.WriteLine("Number1 is Largest of Three");
                }
                else
                {
                    Console.WriteLine("NUmber3 is Largest of Three");
                }
            }
            else if (Num2 > Num3)
            {
                Console.WriteLine("Number2 is Largest of Three");
            }
            else
            {
                Console.WriteLine("Number3 is Largest of Three");
            }
        }
    }
}
