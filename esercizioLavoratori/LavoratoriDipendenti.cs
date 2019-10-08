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
        public float Stipendio { get; set; }
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
                " StipendioAnnuale: " + Stipendio + " " +
                "AnniAssunzione: " + AnniAssunzione;
        }
        public override float StipendioMensile()
        {
            return Stipendio / 12;
        }
        public override float Tasse()
        {
            
            if (Stipendio < 6000)
                return 0;
            if (Stipendio <= 15000 || Stipendio >= 6000)
                return Stipendio * 15 / 100;
            if (Stipendio > 15000 || Stipendio <= 25000)
                return Stipendio * 30 / 100;
            if (Stipendio > 25000 || Stipendio <= 35000)
                return Stipendio * 40 / 100;
            if (Stipendio > 35000)
                return Stipendio * 50 / 100;
            else { return 0; }
        }
    }
}
