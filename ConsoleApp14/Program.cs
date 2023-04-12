using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp14
{
    public delegate double CalcDelegate(double x, double y);
    public class S
    {
        public double Plus(double x, double y)
        {
            return x + y;
        }
        public double Minus(double x, double y)
        {
            return x - y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            S p = new S();
            Write("Введите пример ");
            string exp = ReadLine();
            char s = ' ';
            foreach (char item in exp)
            {
                if (item == '+' || item == '-')
                {
                    s = item; break;
                }
            }
            string[] numbers = exp.Split(s);
            CalcDelegate de = null;
            switch (s)
            {
                case '+':
                    {
                        de = new CalcDelegate(p.Plus);
                        break;
                    }
                case '-':
                    {
                        de = new CalcDelegate(p.Minus);
                        break;
                    }
            }
            WriteLine($"Result: {de(double.Parse(numbers[0]),double.Parse(numbers[1]))}");
        }
    }
}
