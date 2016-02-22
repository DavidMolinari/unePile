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

        public Pile InitPile(int maxValeurs)
        {
            var unePile = new Pile();
            return unePile;
        }

    }
}
