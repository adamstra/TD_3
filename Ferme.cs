using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_3
{
    class Ferme : Personne
    {
        public string[] mouton;

        public Ferme(string[] mouton,string prenom)
        {
            this.mouton = mouton;
            this.prenom = prenom;
        }

        public void presenterFerme()
        { 
            Console.WriteLine("la ferme de {0} a un mouton  {1}",this.prenom,this.mouton);
        }
    }
}
