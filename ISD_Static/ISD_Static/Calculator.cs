using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Static
{
    static class Calculator
    {
        public static double Sum (double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Sub(double value1, double value2)
        {
            return value1 - value2;
        }
        public static double Div(double value1, double value2)
        {
            return value1 / value2;
        }
        public static double Mult(double value1, double value2)
        {
            return value1 * value2;
        }
        public static double Percent (double value1, double value2)
        {
            return value1 * value2/100;
        }

        public static double Mod (double value1, double value2)
        {
            return value1 % value2;
        }
    }
}
