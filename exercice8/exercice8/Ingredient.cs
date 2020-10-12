using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice8
{
    class Ingredient
    {
        private int id;
        private string libelle;
        private int quantite;

        public Ingredient(int id, string libelle, int quantite)
        {
            Id = id;
            Libelle = libelle;
            Quantite = quantite;
        }

        public int Id { get => id;
            set
            {
                if (value < 1)
                    throw new ArgumentNullException("L'id ne peut pas être inèrieure à 1");

                this.id = value;
            }
        }
        public string Libelle { get => libelle;
    
            set
            {
                if (value == null|| value.Length == 0)
                    throw new ArgumentNullException("le nom ne peut pas être nul");
               
                this.libelle = value.ToUpper();
            }
        
    }
        public int Quantite { get => quantite;
            set
            {
                if (value < 1)
                    throw new ArgumentNullException("L'id ne peut pas être inèrieure à 1");

                this.quantite = value;
            }
        
        }
    }
}
