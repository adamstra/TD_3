using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD_3
{
    class Mouton
    {
        public string race;
        public string couleur;
        public int age;
        
        public Mouton(string race ,string couleur , int age)
        {
            this.race = race;
            this.couleur = couleur;
            this.age = age;
        }

        public void presentation()
        {
            Console.WriteLine("Race :{0} -> Couleur :{1} -> Age :{2}",race,couleur,age);
        }
    }
}
