using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "To be, or not to be, that is the question," +
                "\r\nWhether 'tis nobler in the mind to suffer" +
                "\r\nThe slings and arrows of outrageous fortune," +
                "\r\nOr to take arms against a sea of troubles," +
                "\r\nAnd by opposing end them? To die: to sleep;" +
                "\r\nNo more; and by a sleep to say we end" +
                "\r\nThe heart-ache and the thousand natural shocks" +
                "\r\nThat flesh is heir to, 'tis a consummation" +
                "\r\nDevoutly to be wish'd. To die, to sleep\r\n";
            Console.WriteLine(str);
            int counter = 0;
            str.Replace("die", "***");
            foreach (char item in str)
            {
                if (item == '*')
                {
                    counter++;
                }
            }
            Console.WriteLine(str);
            Console.WriteLine(counter);

        }
    }
}
