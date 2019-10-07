using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    class LavoratoriAutonomi : Lavoratore
    {
        public int BilancioMedio { get; set; }
        public int AnniAttivita { get; set; }
        public LavoratoriAutonomi(string nome, string cognome, int età, Sesso genere)
            : base(nome, cognome, età, genere)
        {
            BilancioMedio = BilancioMedio;
            AnniAttivita = AnniAttivita;
        }

        //Metodo che mi ritorna informazioni lavoratore generale più le specifiche della sotto classe
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()  + " " +
                "BilancioAnnuale: " + BilancioMedio + " " +
                "AnniAttività: " + AnniAttivita +
                " (Autonomo)";
        }


    }
}
