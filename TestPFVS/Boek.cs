using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Boek:IVoorwerpen
    {
      
        private string titelValue;

        public string Titel
        {
            get { return titelValue; }
            set { titelValue = value; }
        }

        private string auteurValue;

        public string Auteur
        {
            get { return auteurValue; }
            set { auteurValue = value; }
        }

        string eigenaar = "VDAB";

    
        private decimal aankoopprijsValue;

        public decimal Aankoopprijs
        {
            get { return aankoopprijsValue; }
            set { aankoopprijsValue = value; }
        }

        private Genre genreValue;

        public Genre Genre
        {
            get { return genreValue; }
            set { genreValue = value; }
        }
        
        public Boek(string titel, string auteur, decimal aankoopprijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            Aankoopprijs = aankoopprijs;
            Genre = genre;
        }

        public virtual decimal Winst
        {
            get
            {
                return Aankoopprijs * 1m;
            }
        }

        public virtual void Afbeelden()
        {
            if (Genre != null)
            {
                Console.WriteLine("Genre: ");
                Genre.Afbeelden();
            }
            Console.WriteLine("Titel: {0}", Titel);
            Console.WriteLine("Auteur: {0}", Auteur);
            Console.WriteLine("Eigenaar: {0}", eigenaar);
            Console.WriteLine("Aankoopprijs: {0}", Aankoopprijs);
            
        }
    }
}
