using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
    class Client
    {
        private String nom, prenom, adress;
        

        public Client(String nom, String prenom, String adress)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adress = adress;
            
        }
        public void afficher()
        {

            Console.WriteLine(" Nom : " + nom + "  Prenom : " + prenom + " adress:" + adress);

        }
    }
}
