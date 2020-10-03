using Ergosum.ClassesMetier;
using Ergosum.ClassesTechniques;
using System;

namespace Ergosum
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue19 = new Catalogue(2019);
            Catalogue catalogue20 = new Catalogue(2020);
            TrancheAge tranche1 = new TrancheAge(1, 0, 4);
            TrancheAge tranche2 = new TrancheAge(2, 5, 8);
            TrancheAge tranche3 = new TrancheAge(3, 9, 12);
            TrancheAge tranche4 = new TrancheAge(4, 12, 16);
            Categorie categorie1 = new Categorie(1, "Jeu de société");
            Categorie categorie2 = new Categorie(2, "Jeu de cartes");
            Categorie categorie3 = new Categorie(3, "Jeu de construction");
            Categorie categorie4 = new Categorie(4, "Jeu de rôle");
            Jouet jouet10 = new Jouet(10, "jouet10", categorie1, tranche1);
            catalogue19.AjouteJouet(jouet10, 100);
            catalogue20.AjouteJouet(jouet10, 120);
            Jouet jouet11 = new Jouet(11, "jouet11", categorie1, tranche1);
            catalogue19.AjouteJouet(jouet11, 134);
            catalogue20.AjouteJouet(jouet11, 23);
            Jouet jouet12 = new Jouet(12, "jouet12", categorie1, tranche2);
            catalogue19.AjouteJouet(jouet12, 287);
            catalogue20.AjouteJouet(jouet12, 198);
            Jouet jouet20 = new Jouet(20, "jouet20", categorie2, tranche2);
            catalogue19.AjouteJouet(jouet20, 543);
            catalogue20.AjouteJouet(jouet20, 345);
            Jouet jouet21 = new Jouet(21, "jouet21", categorie2, tranche3);
            catalogue19.AjouteJouet(jouet21, 99);
            catalogue20.AjouteJouet(jouet21, 56);
            Jouet jouet22 = new Jouet(21, "jouet21", categorie2, tranche2);
            catalogue19.AjouteJouet(jouet22, 76);
            catalogue20.AjouteJouet(jouet22, 54);
            //////////////////////////////////////////////////
            //// Traitements
            /////////////////////////////////////////////////
            Console.WriteLine("le jouet jouet1O convient pour un jeune de 12 ans : " + jouet10.Convient(12));
            Console.WriteLine("le jouet jouet1O convient pour un jeune de 2 ans : " + jouet10.Convient(2));
            //test aux bornes de la tranche d'âge
            Console.WriteLine("le jouet jouet1O convient pour un jeune de 4 ans : " + jouet10.Convient(4));
            Console.WriteLine(jouet10.GetInfos());
            Console.WriteLine(jouet21.GetInfos());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------Qte distribuées --------");
            Console.WriteLine("quantitées distribuées en 2019 : " + catalogue19.QuantitéDistribuée());
            Console.WriteLine("quantitées distribuées en 2020 : " + catalogue20.QuantitéDistribuée());
            ////////////////////////////////////////
            ///// 
            Dictionnaire<Jouet, Int32> dico = new Dictionnaire<Jouet, int>();
            dico.Add(jouet10, 6);
            dico.Add(jouet11, 12);
            dico.Modifier(jouet11, 33);
            Console.WriteLine("Jouet 10 : " + dico.DonnerValeur(jouet10));
            Console.WriteLine("Jouet 11 : " + dico.DonnerValeur(jouet11));
            ////////////////////////////////////////
            ///// 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------Statistiques --------");

            Dictionnaire<Categorie,Int32> dicoStats19= catalogue19.StatCateg();
            Console.WriteLine("Catalogue 2019");
            foreach(Categorie uneCategorie in dicoStats19.DonnerToutesLesCles())
            {
                Console.WriteLine(uneCategorie.Libelle + " : " + dicoStats19.DonnerValeur(uneCategorie));
            }
            Console.WriteLine("Catalogue 2020");
            Dictionnaire<Categorie, Int32> dicoStats20 = catalogue20.StatCateg();
            foreach (Categorie uneCategorie in dicoStats20.DonnerToutesLesCles())
            {
                Console.WriteLine(uneCategorie.Libelle + " : " + dicoStats20.DonnerValeur(uneCategorie));
            }

            //////////////////
            // Jouets d'une categorie compatibles avec un âge passé en paramètre
            //int age = 6;
            int age = 10;
            Collection<Jouet> lesJouets =categorie1.JouetTranche(age);
            if(lesJouets.Cardinal() > 0)
            {
                Console.WriteLine("Jouets de la catégorie "+ categorie1.Libelle + " compatibles à " + age + " ans");
                foreach(Jouet unJouet in lesJouets)
                {
                    Console.WriteLine(unJouet.Libelle);
                }
            }
            else
            {

                Console.WriteLine("Aucun jouet comptible dans la catégorie  " + categorie1.Libelle + " pour l'âge de " + age + " ans");
            }
            


            Console.ReadKey();
        }
    }
}
