using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class HarmonicNumber
    {
        public void HarmonicNumbers()
        {
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(" =");

            for (int i = 0; i < number; i++)
            {
                Console.Write(" 1/" + i);
                if (i < number - 1)
                    Console.Write(" +");
            }
        }
    }
}
