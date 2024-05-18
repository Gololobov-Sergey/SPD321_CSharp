using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD321_CSharp
{
    public delegate double CalDelegate(int a, int b);

    public class Calc
    {
        public double Sum(int a, int b) => a + b;

        public static double Diff(int a, int b)
        {
            return a - b;
        }

        public double Mult(int a, int b)
        {
            return a * b;
        }

        public double Div(int a, int b)
        {
            return a + b;
        }
    }
}
