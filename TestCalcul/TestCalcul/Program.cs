using Calculatrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalcul
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arranger
            Double a = 1.0;
            Double b = 2.0;

            // Agir
            Double resultat = Calcul.Addition(a, b);
            // Auditer
            if (resultat != 3.0)
                Console.WriteLine("Test Addition 1 : échec");
            // Arranger
            a = 0;
            b = 0;
            // Agir
            resultat = Calcul.Addition(a, b);
            // Auditer
            if (resultat != 0)
                Console.WriteLine("Test Addition 2 : échec");
            // Arranger
            a = 1.0;
            b = -2.0;
            // Agir
            resultat = Calcul.Addition(a, b);
            // Auditer
            if (resultat != -1.0)
                Console.WriteLine("Test Addition 3 : échec");
            // Arranger
            a = -1.0;
            b = -2.0;
            // Agir
            resultat = Calcul.Addition(a, b);
            // Auditer
            if (resultat != -3.0)
                Console.WriteLine("Test Addition 4 : échec");
            Console.ReadKey();
        }
    }
}
