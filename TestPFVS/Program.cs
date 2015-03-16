using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPFVS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Genre mijngenre = new Genre(15, Doel.Cat.Jeugd, "JONGEREN");
            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];
            voorwerpen[0] = new Leesboek("Flutverhaal","Aspe",10m,mijngenre,"Gezever");
            voorwerpen[1] = new Woordenboek("Frans/Nederlands","Van Daele",100m, mijngenre, "Frans");
            voorwerpen[2] = new Boekenrek(100f,200f,100m);
            decimal totaleWinst=0m;
            foreach (IVoorwerpen voorwerp in voorwerpen)
	        {
                voorwerp.Afbeelden();
                Console.WriteLine("winst: {0}", voorwerp.Winst);
                totaleWinst += voorwerp.Winst;
                Console.WriteLine();
	        }
            Console.WriteLine("Totale winst: {0}", totaleWinst);
        }


    }
}
