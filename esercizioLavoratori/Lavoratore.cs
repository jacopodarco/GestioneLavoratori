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
    class Lavoratore
    {
        // Proprietà generali dei lavoratori
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public Sesso Genere { get; set; }

        // Definisco i costruttori
        public Lavoratore(string nome, string cognome, int età, Sesso genere)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
            Genere = genere;
        }

        //metodo che mi ritorna le informazioni per il lavoratore generico
        public virtual string GetDettaglioLavoratore()
        {
            return System.Environment.NewLine +
                "Nome: " + Nome + " " +
                "Cognome: " + Cognome;
        }
        public virtual float StipendioMensile()
        {
          return 0 ;
        }
        public virtual float Tasse()
        {
            return 0;
        }
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

