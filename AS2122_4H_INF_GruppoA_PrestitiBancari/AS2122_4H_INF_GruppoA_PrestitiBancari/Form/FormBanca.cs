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
        internal Banca banca = new Banca("Arabab Ashabeb");
        internal Banca Banca { get { return banca; } }
        
        internal Prestito prestito;

        //internal Prestito Prestito { get { return Prestito} }



        
        public Menu()
        {
            InitializeComponent();

            RiempiListe();
        }

        private void RiempiListe()
        {
            Cliente pietro = new Cliente("Pietro", "Astorino", "gylo86", 7996.98);
            Prestito p = new Prestito(pietro, 874.98, 80.3, DateTime.Now, DateTime.Now.AddDays(5));
            Prestito p1 = new Prestito(pietro, 2345.52, 678.4, DateTime.Now, DateTime.Now.AddDays(45));
            banca.prestiti_tot.Add(p);
            banca.prestiti_tot.Add(p1);
            pietro.prestiti.Add(p);
            pietro.prestiti.Add(p1);

            
            
            banca.clienti.Add(pietro);
            banca.clienti.Add(new Cliente("Filippo", "Verginelli", "hò79p", 980.98));
            banca.clienti.Add(new Cliente("Marco", "Perini", "uh9p73", 8967650.98));
        }

        private void Aggiungi_Cliente_Click(object sender, EventArgs e)
        {
            Aggiungi_Cliente aggiungi_cliente = new Aggiungi_Cliente(Banca);
            aggiungi_cliente.Show();
        }

        private void Ricerca_Prestiti_Click(object sender, EventArgs e)
        {
            FormRicercaPrestiti ricerca_prestiti = new FormRicercaPrestiti(Banca, prestito);
            ricerca_prestiti.Show();
        }

        private void AggiungiPrestito_Click(object sender, EventArgs e)
        {
            FormAggiungiPrestito aggiungi_prestito = new FormAggiungiPrestito(Banca);
            aggiungi_prestito.Show();
        }

        private void ModificaCliente_Click(object sender, EventArgs e)
        {
            FormModificaCliente modifica = new FormModificaCliente(Banca);
            modifica.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
