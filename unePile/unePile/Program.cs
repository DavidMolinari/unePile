using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace unePile
{
    class Program

    {
        public static void Main(string[] args)
        {

        }
        public class Pile
        {
            private int maxElt;
            public int MaxElt { get; set; }

            public List<string> listTab;
        }


        /// <summary>
        /// Initialisation de la pile 
        /// 
        /// TODO PAS ENCORE COMPLETE
        /// 
        /// 
        /// 
        /// 
        /// </summary>
        /// <param name="maxValeurs"></param>
        /// <returns></returns>
        public Pile InitPile(int maxValeurs)
        {
            var unePile = new Pile();
            return unePile;
        }

        /// <summary>
        /// Retourne true si la liste ne contient aucun élément, donc si la pile est vide.
        /// </summary>
        /// <param name="unePile"></param>
        /// <returns></returns>
        public bool PileVide( Pile unePile)
        {
            return unePile.listTab.Count == 0 ? true : false;
        }

        /// <summary>
        /// Retourne true si la liste a atteint son "sommet" et faux s'il y'a encore de la place.
        /// </summary>
        /// <param name="unePile"></param>
        /// <returns></returns>
        public bool PilePleine (Pile unePile)
        {
            return unePile.listTab.Count == unePile.MaxElt ? true : false;
        }


        /// <summary>
        ///  Fonction qui va saisir un entier compris entre 2 nombres.
        ///  
        /// Int.Parse à revoir, pas sûr qu'elle soit vraiment necessaire. 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int SaisirEntier ( int min, int max)
        {
            var valeur = int.Parse(Console.ReadLine());
            while (valeur < min && valeur > max)
            {
                Console.WriteLine("Veuillez saisir un entier compris entre" + min + " et " + max);
                valeur = int.Parse(Console.ReadLine());
            }
            return valeur;

        }
    }
}
