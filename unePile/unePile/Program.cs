using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace unePile
{
    class Program

    {
        private static void Main(string[] args)
        {

            int nbr;
            int baz;
            Pile unePile;
            InitPile(10);
            unePile = InitPile(10);
            nbr = 31;
            baz = 16;

            int quotien, reste;
            string result;

            do
            {
                quotien = nbr % baz;
                reste = nbr / baz;
                nbr = reste;
                Empiler(ref unePile, Convert.ToString(quotien));
            } while (reste > 0);

            result = FormatResult(Depile(unePile));

            Console.WriteLine(result);

            Console.Read();

        }
        private class Pile
        {
            // passage en string, marre de me casser la tête avec les conversions
            private string maxElt;
            public string MaxElt { get; set; }

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
        private static Pile InitPile(int maxValeurs)
        {
            var unePile = new Pile
            {
                listTab = new List<string>(maxValeurs),
                MaxElt = Convert.ToString(maxValeurs)
            };
            return unePile;
        }

        /// <summary>
        /// Retourne true si la liste ne contient aucun élément, donc si la pile est vide.
        /// </summary>
        /// <param name="unePile"></param>
        /// <returns></returns>
        private static bool PileVide(Pile unePile)
        {
            return unePile.listTab.Count == 0 ? true : false;
        }

        /// <summary>
        /// Retourne true si la liste a atteint son "sommet" et faux s'il y'a encore de la place.
        /// </summary>
        /// <param name="unePile"></param>
        /// <returns></returns>
        private static bool PilePleine(Pile unePile)
        {
            return unePile.listTab.Count == Convert.ToInt32(unePile.MaxElt);
        }


        /// <summary>
        ///  Fonction qui va saisir un entier compris entre 2 nombres.
        ///  
        /// Int.Parse à revoir, pas sûr qu'elle soit vraiment necessaire. 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static int SaisirEntier(int min, int max)
        {
            var valeur = int.Parse(Console.ReadLine());
            while (valeur < min && valeur > max)
            {
                Console.WriteLine("Veuillez saisir un entier compris entre" + min + " et " + max);
                valeur = int.Parse(Console.ReadLine());
            }
            return valeur;
        }

        /// <summary>
        /// Fonction qui va empiler un entier 
        /// </summary>
        /// <param name="unePile"></param>
        private static void Empiler(ref Pile unePile, string valEmp)
        {
            if (!PilePleine(unePile))
            {
                unePile.listTab.Add(valEmp);
            }
            else throw new Exception("La Pile est pleine");

        }
        private static string FormatResult(string[] values)
        {
            string a = null;
            foreach (var s in values)
            {
                // Si le nombre fait plus de deux char il faut convertire en hexa
                if (s.Length >= 2)
                {
                    a += ToHex(s);
                }
                else
                {
                    a += s;
                }
            }
            return a;
        }
        private static string[] Depile(Pile unePile)
        {
            var a = new string[unePile.listTab.Count];

            if (PileVide(unePile)) throw new Exception("La pile est vide");
            for (int i = unePile.listTab.Count - 1, j = 0; i >= 0; i--)
            {
                a[j] = unePile.listTab[i];
                j++;
            }
            unePile.listTab.Clear();
            return a;
        }
        private static string ToHex(string value)
        {

            int intValue = Convert.ToInt32(value);
            string hexValue = intValue.ToString("X");

            return hexValue;
        }


    }
}

    

