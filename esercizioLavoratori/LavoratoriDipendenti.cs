using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    class LavoratoriDipendenti : Lavoratore
    {
        //definisco proprietà dei lavoratori autonomi
        public int Stipendio { get; set; }
        public int AnniAssunzione { get; set; }

        //definisco un costruttore
        public LavoratoriDipendenti(string nome, string cognome, int età, Sesso genere)
            : base(nome, cognome, età, genere)
        {
            Stipendio = Stipendio;
            AnniAssunzione = AnniAssunzione;
        }

       
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore() + " " +
                "StipendioAnnuale: " + Stipendio + " " +
                "AnniAssunzione: " + AnniAssunzione + " (Dipendente)";
        }
    }
}
