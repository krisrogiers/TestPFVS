using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Doel
    {
        
        
        public virtual void Afbeelden()
            {
                Console.WriteLine("Categorie: {0}", Categorie);
                Console.WriteLine("Leeftijd: {0}", Leeftijd);

            }
            public Doel(int leeftijd, Cat categorie)
            {
                Leeftijd = leeftijd;
                Categorie = categorie;                
            }

            private int leeftijdValue;

            public int Leeftijd
            {
                get { return leeftijdValue; }
                set { leeftijdValue = value; }
            }

            private Cat categorieValue;

            public Cat Categorie
            {
                get { return categorieValue; }
                set
                {
                    if (leeftijdValue < 18)
                    {
                        categorieValue = Cat.Jeugd;
                    }
                    else
                    {
                        categorieValue = Cat.Volwassen;
                    }

                }
            }


            public enum Cat
            {
                Jeugd,
                Volwassen,
            }



        }
    }

