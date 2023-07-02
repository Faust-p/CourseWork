using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolation
{
    internal class Solving
    {
        public delegate double Func(double x);
        public static double Function(double x) => (Math.Pow(x, 2));
    }
}
