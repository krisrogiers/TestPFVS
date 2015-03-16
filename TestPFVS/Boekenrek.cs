using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPFVS
{
    public class Boekenrek:IVoorwerpen
    {
        public Boekenrek(float hoogte, float breedte, decimal aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Aankoopprijs = aankoopprijs;
        }

        private float hoogteValue;

        public float Hoogte
        {
            get { return hoogteValue; }
            set 
            { 
                if (value>=0)
                    hoogteValue = value; }
        }

        private float breedteValue;

        public float Breedte
        {
            get { return breedteValue; }
            set 
            {
                if (value >= 0)
                    breedteValue = value; 
            }
        }

        private decimal aankoopprijsValue;

        public decimal Aankoopprijs
        {
            get { return aankoopprijsValue; }
            set 
            {
                if (value >=0)
                    aankoopprijsValue = value; 
            }
        }



        public void Afbeelden()
        {
            Console.WriteLine("Hoogte: {0}", Hoogte);
            Console.WriteLine("Breedte: {0}", Breedte);
            Console.WriteLine("Aankoopprijs: {0}", Aankoopprijs);           
        }



        public decimal Winst
        {
            get
            {
                return Aankoopprijs * 2m;
            }
            
        }


    }
}
