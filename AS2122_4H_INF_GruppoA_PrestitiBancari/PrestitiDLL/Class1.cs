using System;
using System.Collections.Generic;

namespace Prestiti_DLL
{
    public class Banca
    {
        string Nome;
        public List<Cliente> clienti;
        public Banca(string nome)
        {
            this.Nome = nome;
            this.clienti = new List<Cliente>();
        }
    }

    public class Cliente
    {
        string Nome;
        string Cognome;
        string CodiceFiscale;
        double Stipendio;
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
        double AmmontarePrestito;
        double Rata;
        DateTime InizioPrestito;
        DateTime FinePrestito;
        public Prestito(double ammontare, double rata, DateTime inizio, DateTime fine)
        {
            this.AmmontarePrestito = ammontare;
            this.Rata = rata;
            this.InizioPrestito = inizio;
            this.FinePrestito = fine;
        }
    }
}