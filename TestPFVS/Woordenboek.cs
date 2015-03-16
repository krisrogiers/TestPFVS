using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Woordenboek : Boek
    {
        private string taalValue;

        public string Taal
        {
            get { return taalValue; }
            set { taalValue = value; }
        }
        
        public Woordenboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string taal)
            : base (titel, auteur, aankoopprijs, genre)
        {
            Taal = taal;
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Taal: {0}", Taal);
        }

        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.75m;
            }
        }
    }
}
