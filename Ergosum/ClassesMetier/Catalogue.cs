﻿using Ergosum.ClassesTechniques;
using System;
using System.Collections.Generic;


namespace Ergosum.ClassesMetier
{
    class Catalogue
    {
        private int annee;
        /// <summary>
        /// Contient pour chaque jouet du catalogue :
        /// - en clé, l’objet de la classe Jouet
        /// - en valeur, la quantité de ce jouet distribuée pour ce catalogue
        /// </summary>
        private Dictionnaire<Jouet, int> lesJouets;
    
        public Catalogue(int uneAnnee)
        {
            this.annee = uneAnnee;
            this.lesJouets = new Dictionnaire<Jouet, int>();
        }

        /// <summary>
        /// Retourne la quantité totale de jouets distribués pour ce catalogue.
        /// </summary>
        /// <returns></returns>
        public int QuantitéDistribuée()
        {
            // TODO : implémenter cette méthode
            // TODO : changer le return
            return 0;
        }

 
       public int Annee { get => annee; }

        /// <summary>
        /// Retourne un dictionnaire contenant pour chaque catégorie de ce catalogue :
        /// - en clé, l’objet de la classe Catégorie
        /// - en valeur, la quantité de jouets distribués pour cette catégorie.
        /// </summary>
        /// <returns></returns>
        public Dictionnaire<Categorie, int> StatCateg() {
            // TODO : implémenter cette méthode
            // TODO : changer le return
            return null;
        }

        /// <summary>
        /// Ajoute le jouet passé en paramètre 
        /// au dictionnaire avec sa quantitée distribuée
        /// </summary>
        /// <param name="unjouet"></param>
        /// <param name="qteDistribuee"></param>
        public void AjouteJouet(Jouet unjouet, int qteDistribuee)
        {
            this.lesJouets.Ajouter(unjouet, qteDistribuee);
        }


    }
}
