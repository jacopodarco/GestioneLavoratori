using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    /// <summary>
    /// sottoclasse che identifica i lavoratori dipendeti da qualcuno
    /// </summary>
    class LavoratoriDipendenti : Lavoratore
    {
        //definisco proprietà dei lavoratori autonomi
        /// <summary>
        /// Variabile float che definisce lo stipendi annuale di unno lavoratore
        /// </summary>
        public float Stipendio { get; set; }
        /// <summary>
        /// variabile che definisce il numero di anni di assuzione nell'azienda attuale
        /// </summary>
        public int AnniAssunzione { get; set; }

        //definisco un costruttore
        /// <summary>
        /// Costruttore del lavoratori dipendenti
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="genere"></param>
        public LavoratoriDipendenti(string nome, string cognome, int età, Sesso genere)
            : base(nome, cognome, età, genere)
        {
            Stipendio = Stipendio;
            AnniAssunzione = AnniAssunzione;
        }

        /// <summary>
        /// Metodo che overridda quello del lavoratore aggiungendo i dettagli del lavoratore nel caso dipendente
        /// </summary>
        /// <returns>dettagli lavoratore dipendente</returns>
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore() + " " +
                " StipendioAnnuale: " + Stipendio + " " +
                "AnniAssunzione: " + AnniAssunzione;
        }
        /// <summary>
        /// Metodo che calcola lo tipendio mensile basato su 12 mensilità per ogni lavoratore dipendente
        /// </summary>
        /// <returns>Stipendio mensile</returns>
        public override float StipendioMensile()
        {
            return Stipendio / 12;
        }
        /// <summary>
        /// Quante tasse il lavoratore deve versare? Se guadagna meno di 6000 allora 0, tra 15000 e 6000 il 15% dello stipendio, tra 25k e 15k il 30% , tre 35 e 25 il 40% e di più il 50%
        /// </summary>
        /// <returns>Valore delle tasse in euro</returns>
        public override float Tasse()
        {
            
            if (Stipendio <= 6000)
                return 0;
            if (Stipendio <= 15000 || Stipendio > 6000)
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
