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
        
        public Menu()
        {
            InitializeComponent();
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
