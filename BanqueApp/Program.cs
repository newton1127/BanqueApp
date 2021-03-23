using BanqueApp.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MAD solde = new MAD(23000.0);
            MAD solde1 = new MAD(25656.0);
            MAD mo = new MAD(2565);


            Client c1 = new Client("maanaoui", "omar", "260000 casablanca");
            Client c2 = new Client("abali", "yussef", "260000 casablanca");
            Compte comp1 = new Compte(solde, c1);
            Compte comp2 = new Compte(solde1, c2);
            MAD Montant = new MAD(5000);
            //comp1.Afficher();
            //comp2.Afficher();

            comp1.Virement(comp2, Montant);


            
            //comp2.Afficher();

            CompteCourant cptc = new CompteCourant(solde,c1 );
            CompteEpargne cptt = new CompteEpargne(solde , c1 , 25);
            cptt.CalculInteret();
            cptt.Afficher();
            cptc.Debiter(mo);
            cptc.Afficher();
           
           

          
            Console.ReadKey();
        }
    }
}
