using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public static class Calcul

    {
        public static double Addition(double nombre1, double nombre2)
        {
            double result = nombre1 + nombre2;
            return result;
        }

        public static double Division(double nombre1, double nombre2)
        {
            if(nombre2 == 0)
            {
                throw new DivideByZeroException();
            }
            double result = nombre1 / nombre2;
            return result;
        }
    }
}
