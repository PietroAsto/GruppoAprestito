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
    public partial class FormModificaCliente : Form
    {
        Menu m1;
        public FormModificaCliente(Menu m)
        {
            InitializeComponent();
            m1 = m;
        }

        private void btn_modifica_cliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_elimina_cliente_Click(object sender, EventArgs e)
        {
            string nome_eliminato = tb_nome.Text;
            string cognome_eliminato = tb_cognome.Text;
            string cf_eliminato = tb_cf.Text;
            double stipendio_eliminato = double.Parse(tb_stipendio.Text);
            Cliente cliente = new Cliente(nome_eliminato, cognome_eliminato, cf_eliminato, stipendio_eliminato);

            // Elimino un cliente
            m1.banca.clienti.Remove(cliente);

            // Svuoto TextBox
            tb_nome.Text = "";
            tb_cognome.Text = "";
            tb_cf.Text = "";
            tb_stipendio.Text = "";
        }

        private void cb_scegli_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_scegli_cliente.Text = m1.banca.clienti[Cliente()]
        }
    }
}
