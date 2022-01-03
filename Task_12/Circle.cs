using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetSquare(double r)
        {
            return Math.PI * (Math.Pow(r,2));
        }


        static public double GetAffiliation(double x, double y, double x0, double y0)
        {

            return Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2);

        }


    }
}
