using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6oop
{
    internal static class Maths
    {
        #region Methods
        public static void Sum(int x, int y)
        {
            Console.WriteLine($"Sum = {x + y}");
        }

        public static void Sub(int x, int y) { Console.WriteLine($"Sub= {x - y}"); }

        public static void Mul(int x, int y) { Console.WriteLine($"Mul= {x * y}"); }

        public static void Div(int x, int y) { Console.WriteLine($"{y / x}"); }
        #endregion
    }
}
