using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    public class Ville
    {
        private String codePostal;

        public String CodePostal
        {
            get { return codePostal; }
            set { codePostal = value; }
        }

        private String nom;

        public String Nom
        {
            get { return nom; }
            set {
                if (value == null)
                    throw new NullReferenceException("yo");
                nom = value.ToUpper(); }
        }

        public Ville(string codePostal, string nom)
        {
            CodePostal = codePostal;
            Nom = nom;
        }
        public override string ToString()
        {
            return "jure ça marche";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Ville))
                return false;
            Ville v = (Ville)obj;
            if ((this.CodePostal == v.CodePostal) && (this.Nom == v.Nom))
                return true; 
            return false;
        }
    }
}
