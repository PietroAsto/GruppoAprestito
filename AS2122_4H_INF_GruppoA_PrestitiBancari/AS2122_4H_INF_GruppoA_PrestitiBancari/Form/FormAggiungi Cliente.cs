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
    public partial class Aggiungi_Cliente : Form
    {
        private Banca b1;
        public Aggiungi_Cliente(Banca b)
        {
            InitializeComponent();
            b1 = b;
        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            // prendo il testo delle textBox
            string nuovo_nome = tb_nome.Text;
            string nuovo_cognome = tb_cognome.Text;
            string nuovo_cf = tb_cf.Text;
            double nuovo_stipendio = double.Parse(tb_stipendio.Text);
            
            // Creo un nuovo cliente
            Cliente nuovo_cliente = new Cliente(nuovo_nome, nuovo_cognome, nuovo_cf, nuovo_stipendio);
            
            // Aggiungo un cliente alla lista
            b1.clienti.Add(nuovo_cliente);

            // Svuoto TextBox
            tb_nome.Text = "";
            tb_cognome.Text = "";
            tb_cf.Text = "";
            tb_stipendio.Text = "";

            MessageBox.Show("Cliente aggiunto correttamente");
        }
    }
}
