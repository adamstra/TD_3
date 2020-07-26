using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_3
{
    class Personne
    {
        public string prenom;
        public string nom;
        public int age;
        public int telephone;
        
        public Personne(string prenom,string nom,int age,int telephone)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.age = age;
            this.telephone = telephone;
        }

        public void afficher()
        {
            Console.WriteLine("Je m'appel {0} {1} et j'ai {2}, mon numero est le {3}", this.prenom, this.nom, this.age, this.telephone);
        }
    }
}
