using System;
using System.Collections.Generic;

namespace Prestiti_DLL
{
    public class Banca
    {
        string Nome;
        public List<Cliente> clienti;
        public List<Prestito> prestiti;
        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
            this.prestiti = new List<Prestito>();
        }
    }

    public class Cliente
    {
        // Visto che Nome viene assegnato nel costruttore, aggiungo il metodo setter
        public string Nome { get; set; }

        // Propietà usat per settare il DisplayMember della combobox
        public string Cognome { get; set; }
        public string CodiceFiscale { get; set; }
        public double Stipendio { get; set; }

        // Propietà creata per settare il ValueMember della combobox
        public Cliente Self
        {
            get { return this; }
        }

        public string NomeCognome
        {
            get { return Nome + " " + Cognome; }
        }

        public Cliente(string nome, string cognome, string CF, double stipendio)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.CodiceFiscale = CF;
            this.Stipendio = stipendio;
        }

    }

    public class Prestito
    {
        public double AmmontarePrestito { get; set; }
        public double Rata { get; set; }
        public DateTime InizioPrestito { get; set; }
        public DateTime FinePrestito { get; set; }
        public Cliente Intestatario { get; set; }
        public Prestito(Cliente intestatario, double ammontare, double rata, DateTime inizio, DateTime fine)
        {
            this.AmmontarePrestito = ammontare;
            this.Rata = rata;
            this.InizioPrestito = inizio;
            this.FinePrestito = fine;
            this.Intestatario = intestatario;
        }
    }
}