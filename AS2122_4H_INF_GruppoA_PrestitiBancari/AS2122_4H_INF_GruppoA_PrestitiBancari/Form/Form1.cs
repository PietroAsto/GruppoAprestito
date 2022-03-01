using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_accedi_Click(object sender, EventArgs e)
        {
             FormAccedi accedi = new FormAccedi(this);
             accedi.Show();
        }

        private void Aggiungi_Cliente_Click(object sender, EventArgs e)
        {
            Aggiungi_Cliente aggiungi_cliente = new Aggiungi_Cliente(this);
            aggiungi_cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modifica modifica = new Modifica(this);
            modifica.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prestiti prestiti = new Prestiti(this);
            prestiti.Show();
        }
    }
}
