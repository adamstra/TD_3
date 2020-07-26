using System;

namespace TD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne perso1 = new Personne("Adama", "Traore", 23, 781525856);
            perso1.afficher();
            Console.WriteLine("---------------------------------------------------------------------");
            Mouton mouton1 = new Mouton("babali", "noir-blanc",2);
            mouton1.presentation();
            Console.WriteLine("---------------------------------------------------------------------");
            Ferme ferme1 = new Ferme(new string[] { "babali", "ladoum" },"Adama");
            ferme1.presenterFerme();
            Console.ReadKey();
        }
    }
}
