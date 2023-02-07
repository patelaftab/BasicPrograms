using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class SwapNumbers
    {
        public void Swapnum()
        {
            Console.WriteLine("Enter a First Value");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Value");
            int num2=Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = num1;
            num1 = num2;
            num2= temp;
            Console.WriteLine("\nAfter Swaping Number one with Number two is :" + num1 +
                "\nAfter Swaping Number two With Number one is :" +num2);
        }
    }
}
