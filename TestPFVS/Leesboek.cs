using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Leesboek : Boek
    {
        private string onderwerpValue;

        public string Onderwerp
        {
            get { return onderwerpValue; }
            set { onderwerpValue = value; }
        }






        public Leesboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string onderwerp)
            : base (titel, auteur, aankoopprijs, genre)
        {
            Onderwerp = onderwerp;
        }


        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Onderwerp: {0}", Onderwerp);
        }

        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.5m;
            }
        }
    }
}
