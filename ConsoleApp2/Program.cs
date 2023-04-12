using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "today is a good day for walking. i will try to walk near the sea";
            WriteLine(str);
            string[] str1 = str.Split('.');
            foreach (string item in str1) 
            {
                WriteLine(item);
                string[] str3 = item.Split(' ');
                foreach (string item2 in str3) 
                {
                    WriteLine(item2);
                    if (item2.Length > 0)
                    {
                        Char.ToUpper(item2[0]);
                    }
                }
            }
        }
    }
}
