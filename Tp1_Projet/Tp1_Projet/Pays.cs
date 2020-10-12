using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Projet
{
   
    class Pays
    {
         private int id;
         private string name;

        public Pays(int id, string nom)
        {
            this.Id = id;
            this.Name = nom;
        }

        public int Id { 
            get => id;
            set
            {
                if (value < 1)
                    throw new ArgumentNullException("L'id ne peut pas être inèrieure à 1");
               
                this.id= value;
            }
        }
        public string Name { get => name;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("le nom ne peut pas être nul");
                if (value.Length == 0)
                    throw new ArgumentException("le prénom ne peut être de longeur 0");
                this.name = value;
            }
        }

        public override string ToString()
        {
            return Name + "Id = " + Id ;
        }
    }
}
