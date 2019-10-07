using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indicare un'operazione: \r\n \r\n" + "1 = Lista dei lavoratori"
                + "\r\n 2 = Calcolo stipendio mensile");
            int z = Int32.Parse(Console.ReadLine());


            
            LavoratoriAutonomi a1 = new LavoratoriAutonomi("Luca", "Marinello", 34, Sesso.M) { AnniAttivita = 42, BilancioMedio = 100000 };
            LavoratoriAutonomi a2 = new LavoratoriAutonomi("Luca", "Prandin", 44, Sesso.M) { AnniAttivita = 13, BilancioMedio = 100000 };
            LavoratoriAutonomi a3 = new LavoratoriAutonomi("Paolo", "Bonolis", 21, Sesso.N) { AnniAttivita = 1, BilancioMedio = 100000 };

            LavoratoriDipendenti d1 = new LavoratoriDipendenti("Sallustio", "Regale", 18, Sesso.M) { Stipendio = 24000, AnniAssunzione = 34 };
            LavoratoriDipendenti d2 = new LavoratoriDipendenti("Alberta", "Giorgiani", 78, Sesso.F) { Stipendio = 24000, AnniAssunzione = 34 };
            LavoratoriDipendenti d3 = new LavoratoriDipendenti("Marika", "Gonzales", 67, Sesso.F) { Stipendio = 24000, AnniAssunzione = 34 };
            switch (z)
            {
                case 1:
            
            Console.WriteLine("Elenco lavoratori presenti nel database : " + System.Environment.NewLine +
                a1.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.WriteLine(a2.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.WriteLine(a3.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.WriteLine(d1.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.WriteLine(d2.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.WriteLine(d3.GetDettaglioLavoratore() + System.Environment.NewLine);
            Console.ReadLine();
            break;
                case 2:

                break; 
                    
                   
        }
        


        }
    }
}
