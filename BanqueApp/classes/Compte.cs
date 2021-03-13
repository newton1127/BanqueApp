using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanqueApp.classes
{
    class Compte
    {

        private static int compt = 0;
        private readonly int numcompte;
        private MAD solde;
        private readonly Client titulaire;
        private static MAD plafond = new MAD(7000);
        public Compte(MAD sol, Client N)
        {
            this.solde = sol;
            compt++;
            numcompte = compt;
            this.titulaire = N;
        }
        public void Afficher()
        {
            Console.WriteLine(" Numero de votre compte : " + numcompte);
           
            solde.afficher();
            titulaire.afficher();
        }

        void Crediter(MAD M)
        {
            if (M.ispositif() )
            {
                this.solde += M;
                Console.WriteLine(" done !!!");
            }
            else
                Console.WriteLine("veuillez entrer une valeur positif");
        }
        public bool Debiter(MAD M)
        {
            if (M.ispositif() && M < plafond && this.solde > M)
            {
                this.solde -= M;
                Console.WriteLine("Done !!!");
                return true;
            }
            else if (M > plafond)
            {
                Console.WriteLine("erreur !!! , veuillez entrer une valeur inferieur au plafond");
                return false;
            }
            else if (this.solde < M)
            {
                Console.WriteLine("solde insuffisant");
                return false;
            }
            else
                Console.WriteLine("veuillez entrer une valeur positif");
            return false;
        }
        public void Virement(Compte C1, MAD M)
        {
            if (this.Debiter(M))
                C1.Crediter(M);
        }

      
    }
}
