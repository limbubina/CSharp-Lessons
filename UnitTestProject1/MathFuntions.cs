using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaSection9
{
    internal class MathFuntions
    {
        public static double SquareRoot(int aNumber)
        {
            double result = Math.Sqrt(aNumber);
            return Math.Round (result,2);
        }

        public static int Sum(int a, int b)
        {
            return (int)a + b;
        }

        public static double Sum(double a, double b)
        {
            return (double)a + b;
        }
        public static decimal Sum(decimal a, decimal b)
        {
            return (decimal)a + b;
        }
    }
}
