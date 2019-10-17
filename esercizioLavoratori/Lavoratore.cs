using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizioLavoratori
{
    enum Sesso
    {
        N, F, M
    }
    /// <summary>
    /// cjovhsdohjpihsp
    /// </summary>
    class Lavoratore
    {
        // Proprietà generali dei lavoratori
        /// <summary>
        /// Indica il nome di battesimo del lavoratore
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Indica il cognome del lavoratore
        /// </summary>
        public string Cognome { get; set; }
        /// <summary>
        /// Indica l'età del lavoratore
        /// </summary>        
        public int Età { get; set; }
        /// <summary>
        /// Indica se è maschietto o femminuccia o trans
        /// </summary>
        public Sesso Genere { get; set; }


        // Definisco i costruttori
        /// <summary>
        /// Costruttore lavoratore composto dai parametri nome cognome età genere
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cognome"></param>
        /// <param name="età"></param>
        /// <param name="genere"></param>
        public Lavoratore(string nome, string cognome, int età, Sesso genere)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
            Genere = genere;
        }

        //metodo che mi ritorna le informazioni per il lavoratore generico
        /// <summary>
        /// Metodo che ritorna le informazioni per il generico lavoratore
        /// </summary>
        /// <returns>Informazioni principali del lavoratore</returns>
        public virtual string GetDettaglioLavoratore()
        {
            return System.Environment.NewLine +
                "Nome: " + Nome + " " +
                "Cognome: " + Cognome;
        }
        /// <summary>
        /// Metodo che poi verrà overrideato nelle sottoclassi
        /// </summary>
        /// <returns>valore di default</returns>
        public virtual float StipendioMensile()
        {
          return 0 ;
        }
        ///<summary>
        /// Metodo che poi verrà overrideato nelle sottoclassi
        /// </summary>
        /// <returns>valore di default</returns>
        public virtual float Tasse()
        {
            return 0;
        }
        /// <summary>
        /// metodo per confrontare elementi degli array
        /// </summary>
        /// <param name="obj">oggetto di confronto</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool result = false;
            Lavoratore temp = obj as Lavoratore; //no errore ma se non riesce temp = null
            if (temp != null)
            {
                result = temp.Cognome == this.Cognome && temp.Nome == this.Nome && temp.Età == this.Età;
            }
            return result;
        }

    }
}

