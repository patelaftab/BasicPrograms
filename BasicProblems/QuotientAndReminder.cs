using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class QuotientAndReminder
    {
        public void Quotientremimnder()
        {
            Console.WriteLine("Welcome To Quotient And Reminder Program ");
            int Divident, Divisor;
            Console.WriteLine("Enter a Value Of Divident");
            Divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Value Of Divisor");
            Divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = Divident / Divisor;
            int reminder = Divident % Divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Reminder = " + reminder);
        }
    }
}
