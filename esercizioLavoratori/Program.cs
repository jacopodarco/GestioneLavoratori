﻿using System;
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
            Console.WriteLine("Scegliere in quale database entrare:\r\n1 = Lavoratori autonomi\r\n2 = Lavoratori dipendenti");
            int w = Int32.Parse(Console.ReadLine());

            switch (w) {
                case 1:

                    Console.WriteLine("Sei in Lavoratori autonomi \r\n" + 
                    "Indicare un'operazione: \r\n \r\n" + "1 = Lista dei lavoratori"
                    + "\r\n2 = Calcolo stipendio mensile \r\n3 = Calcolo tasse da pagare" +
                    "\r\n4 = Ordina lavoratori in base allo stipendio" +
                    "\r\n5 = Ordina lavoratori in base agli anni di lavoro");
                    int z = Int32.Parse(Console.ReadLine());

                    LavoratoriAutonomi[] array = new LavoratoriAutonomi[4];
                            array[0] = new LavoratoriAutonomi("Luca", "Marinello", 34, Sesso.M) { AnniAttivita = 42, BilancioMedio = 10 };
                            array[1] = new LavoratoriAutonomi("Luca", "Prandin", 44, Sesso.M) { AnniAttivita = 13, BilancioMedio = 34897 };
                            array[2] = new LavoratoriAutonomi("Paolo", "Bonolis", 21, Sesso.N) { AnniAttivita = 19, BilancioMedio = 1442 };
                            array[3] = new LavoratoriAutonomi("Paolo", "Bonolis", 21, Sesso.N) { AnniAttivita = 19, BilancioMedio = 1442 };


                    switch (z)
            {
                    case 1:
                        foreach (var g in array)
                        {
                            Console.WriteLine(g.GetDettaglioLavoratore());
                        }
                            Console.WriteLine("Esistono duplicati nel database?");

                            for (int i = 1; i < array.Length; i++)
                            {
                                Console.WriteLine("{0}", array[i].Equals(array[i-1]));
                            }

                            Console.ReadLine();
                        break;

                    case 2:           
                        foreach (var g in array)
                        {
                            Console.WriteLine("Il lavoratore Dipendente " + g.Cognome + " guadagna " + g.StipendioMensile());
                        }
                        Console.ReadLine();
                        break;

                    case 3:

                        foreach (var g in array)
                        {
                            Console.WriteLine("Il lavoratore Dipendente " + g.Cognome + " versa " + g.Tasse());
                        }
                        Console.ReadLine();
                        break;

                    case 4:
                        LavoratoriAutonomi[] sortedAutonomi = array.OrderBy
                        (lavAutonomi => lavAutonomi.StipendioMensile()).ToArray();
                        
                        foreach (var g in sortedAutonomi)
                        {
                            Console.WriteLine(g.GetDettaglioLavoratore());
                        }
                        Console.ReadLine();

                        break;
                    case 5:
                        LavoratoriAutonomi[] sortedAutonomi1 = array.OrderBy
                        (lavAutonomi => lavAutonomi.AnniAttivita).ToArray();

                        foreach (var g in sortedAutonomi1)
                        {
                            Console.WriteLine(g.GetDettaglioLavoratore());
                        }
                        Console.ReadLine();
                        break;
            }
                    break;

                case 2:

                    Console.WriteLine("Sei in Lavoratori dipendenti \r\n" +
                    "Indicare un'operazione: \r\n \r\n" + "1 = Lista dei lavoratori"
                    + "\r\n2 = Calcolo stipendio mensile \r\n3 = Calcolo tasse da pagare" +
                    "\r\n4 = Ordina lavoratori in base allo stipendio" +
                    "\r\n5 = Ordina lavoratori in base agli anni di lavoro");
                    int x = Int32.Parse(Console.ReadLine());
                    
                    LavoratoriDipendenti[] array1 = new LavoratoriDipendenti[3];
                    array1[0] = new LavoratoriDipendenti("Sallustio", "Regale", 18, Sesso.M) { Stipendio = 240000, AnniAssunzione = 11 };
                    array1[1] = new LavoratoriDipendenti("Alberta", "Giorgiani", 78, Sesso.F) { Stipendio = 36000, AnniAssunzione = 44 };
                    array1[2] = new LavoratoriDipendenti("Marika", "Gonzales", 67, Sesso.F) { Stipendio = 909090, AnniAssunzione = 33 };
                    switch (x)
                    {
                        case 1:

                            foreach (var g in array1)
                            {
                                Console.WriteLine(g.GetDettaglioLavoratore());
                            }
                            Console.ReadLine();
                            break;

                        case 2:
                            
                            foreach (var g in array1)
                            {
                                Console.WriteLine("Il lavoratore Dipendente " + g.Cognome + " guadagna " + g.StipendioMensile());
                            }
                            Console.ReadLine();
                            Console.ReadLine();
                            break;

                        case 3:

                            foreach (var g in array1)
                            {
                                Console.WriteLine("Il lavoratore Dipendente " + g.Cognome + " versa " + g.Tasse());
                            }
                            Console.ReadLine();

                            Console.ReadLine();
                            break;

                        case 4:
                            LavoratoriDipendenti[] sortedAutonomi = array1.OrderBy
                           (lavDipendenti => lavDipendenti.StipendioMensile()).ToArray();

                            foreach (var g in sortedAutonomi)
                            {
                                Console.WriteLine(g.GetDettaglioLavoratore() + g.StipendioMensile());
                            }
                            Console.ReadLine();
                            break;

                        case 5:
                            LavoratoriDipendenti[] sortedAutonomi1 = array1.OrderBy
                            (lavAutonomi => lavAutonomi.AnniAssunzione).ToArray();

                            foreach (var g in sortedAutonomi1)
                            {
                                Console.WriteLine(g.GetDettaglioLavoratore());
                            }
                            Console.ReadLine();
                            break;
                    }
                            break;
            }
       }
    }
}
