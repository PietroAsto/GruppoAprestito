using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prestiti_DLL;


namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    public partial class Menu : Form
    {
        internal Banca banca = new Banca("Banca");
        internal Banca Banca { get { return banca; } }
        
        public Menu()
        {
            InitializeComponent();

            RiempiListe();


        }

        private void RiempiListe()
        {
            Cliente pietro = new Cliente("Pietro", "Astorino", "gylo86", 7996.98);
            banca.clienti.Add(pietro);
            banca.clienti.Add(new Cliente("Filippo", "Verginelli", "hò79p", 980.98));
            banca.clienti.Add(new Cliente("Marco", "Perini", "uh9p73", 8967650.98));

            banca.prestiti.Add(new Prestito(pietro, 874.98, 80.3, DateTime.Now, DateTime.Now.AddDays(5)));

        }

        private void Aggiungi_Cliente_Click(object sender, EventArgs e)
        {
            Aggiungi_Cliente aggiungi_cliente = new Aggiungi_Cliente(this);
            aggiungi_cliente.Show();
        }

        private void Ricerca_Prestiti_Click(object sender, EventArgs e)
        {
            FormRicercaPrestiti ricerca_prestiti = new FormRicercaPrestiti(this);
            ricerca_prestiti.Show();
        }

        private void AggiungiPrestito_Click(object sender, EventArgs e)
        {
            FormAggiungiPrestito aggiungi_prestito = new FormAggiungiPrestito(this);
            aggiungi_prestito.Show();
        }

        private void ModificaCliente_Click(object sender, EventArgs e)
        {
            FormModificaCliente modifica = new FormModificaCliente(this);
            modifica.Show();
        }
    }
}
