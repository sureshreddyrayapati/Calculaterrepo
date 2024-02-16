using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectFeb16
{
    public class Calc
    {
        public void Add(double x, double y)
        {
            Console.WriteLine("Result after Addition: "+(x+y));
        }
        public void Sub(double x, double y) { Console.WriteLine("Result aftre Sub :" + (x - y)); }
        public void Div(double x, double y) { Console.WriteLine("Result after division :"+(x/y)); }
        public void Mul(double x, double y)
        {
            Console.WriteLine("Result after Multiplication" + (x * y));
        }
        public void Avg(double x, double y)
        {
            Console.WriteLine($"avarage of {x} and {y} is :"+(x+y)/2);
        }
    }
}
