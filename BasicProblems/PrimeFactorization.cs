using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class PrimeFactorization
    {
        public void Primefactor()
        {
            Console.WriteLine(" \nPlease enter any number to find Prime factors");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int div = 2; div * div <= num; div++)
            {
                while (num % div == 0)
                {
                    num = num / div;
                    Console.Write(div + " ");
                }
            }
            if (num != 1)
            {
                Console.Write(num);
            }
        }
    }
}
