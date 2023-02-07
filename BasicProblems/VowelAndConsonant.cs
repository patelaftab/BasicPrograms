using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class VowelAndConsonant
    {
        public void VowelConsonant()
        {
            Console.WriteLine("Enter a any Character To Check");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch=='a' || ch=='e'||ch=='i' ||ch=='o'|| ch=='u'|| ch=='A'|| ch=='E'|| ch=='I'||ch=='O'||ch=='U')
            {
                Console.WriteLine("Charcter is a Vowel :" + ch);
            }
            else 
            {
                Console.WriteLine("Charcter is Consonant :" + ch);
            }
        }
    }
}
