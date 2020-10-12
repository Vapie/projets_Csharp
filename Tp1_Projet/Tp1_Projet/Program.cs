using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Projet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pays> pays = new List<Pays>();
            try
            {
                pays.Add ( new Pays(1, "Fronce"));
                pays.Add ( new Pays(2, "Almagne"));
                pays.Add ( new Pays(3, "Itali"));
            }
            catch
            {
                Console.WriteLine("error");
            }

            foreach (Pays pay in pays)
            {
                Console.WriteLine(pay.ToString());
            }
            TdDebug t = new TdDebug();
            // t.Exercice3();
            t.Exercice6();
            Task.Delay(5);
            
        }
    }
}
