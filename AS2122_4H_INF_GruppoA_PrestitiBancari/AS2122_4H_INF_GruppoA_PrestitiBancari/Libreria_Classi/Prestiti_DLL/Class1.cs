namespace Prestiti_DLL
{
    internal class Banca
    {
        string Nome;
        List<Cliente> cliente;
        public Banca(string nome)
        {
            this.Nome = nome;
            cliente = new List<Cliente>();
        }
    }

    internal class Cliente
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

    internal class Prestito
    {
        double AmmontarePrestito;
        double Rata;
        DateTime InizioPrestito;
        DateTime FinePrestito;
        public Prestito()
        {
            AmmontarePrestito = 0;
            Rata = 0;
            InizioPrestito = DateTime.Now;
            //FinePrestito = DateTime.
        }
    }
}