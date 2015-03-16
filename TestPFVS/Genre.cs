using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Genre: Doel
    {

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("Naam: {0}", Naam);
        }


        public Genre(int leeftijd, Cat categorie, string naam)
            : base (leeftijd, categorie)
        {
            Naam = naam;
         }

        
        private string naamValue;

        public string Naam
        {
            get { return naamValue; }
            set { naamValue = value; }
        }



    }
}

