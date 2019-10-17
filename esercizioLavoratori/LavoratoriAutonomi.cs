using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    /// <summary>
    /// sottoclasse di lavoratore
    /// </summary>
    class LavoratoriAutonomi : Lavoratore
    {
        /// <summary>
        /// Il bilancio medio di un impresario negli anni calcolato dall'istat
        /// </summary>
        public float BilancioMedio { get; set; }
        /// <summary>
        /// Numero di anni di apertura dell'azienda da quando è aperta ad oggi
        /// </summary>
        public int AnniAttivita { get; set; }
        /// <summary>
        /// Costrutto per i lavoratori autonomi con bilancio e anni di attività
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="genere"></param>
        public LavoratoriAutonomi(string nome, string cognome, int età, Sesso genere)
            : base(nome, cognome, età, genere)
        {
            BilancioMedio = BilancioMedio;
            AnniAttivita = AnniAttivita;
        }

        //Metodo che mi ritorna informazioni lavoratore generale più le specifiche della sotto classe
        /// <summary>
        /// Metodo che overridda quello del lavoratore aggiungendo i dettagli del lavoratore nel caso autonomo
        /// </summary>
        /// <returns>dettagli lavoratore autonomo</returns>
        public override string GetDettaglioLavoratore()
        {
            return base.GetDettaglioLavoratore()  + " " +
                " BilancioAnnuale: " + BilancioMedio + " " +
                "AnniAttività: " + AnniAttivita  ;
        }
        /// <summary>
        /// Calcola il guadagno mensile del lavoratore autonomo
        /// </summary>
        /// <returns></returns>
        public override float StipendioMensile()
        {
            return BilancioMedio / 12;
        }
        /// <summary>
        /// Metodo che calcola le tasse da pagare dei lavoratori
        /// </summary>
        /// <returns>se il guadagno annuale è inferiore a 50000 euro allora le tasse da pagaere sono il 15%,30% altrimenti</returns>
        public override float Tasse()
        {
            if(BilancioMedio < 50000)
            {
                return BilancioMedio * 15 / 100;
            }
            else { return BilancioMedio * 30 / 100; }

        }

    }
}
