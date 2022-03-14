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
        Banca b1;
        public FormModificaCliente(Banca b)
        {
            InitializeComponent();
            
            b1 = b;

            RefreshClienti();
        }

        private void btn_modifica_cliente_Click(object sender, EventArgs e)
        {
            var cliente_selezionato = (Cliente)cb_scegli_cliente.SelectedValue;

            if (cliente_selezionato != null)
            {
                // Assegno il testo che è all'interno della textbox al campo del Cliente
                cliente_selezionato.Nome = tb_nome.Text;
                cliente_selezionato.Cognome = tb_cognome.Text;
                cliente_selezionato.CodiceFiscale = tb_cf.Text;
                cliente_selezionato.Stipendio = Convert.ToDouble(tb_stipendio.Text);
            }

            RefreshClienti();

            MessageBox.Show("Cliente modificato");
        }

        private void btn_elimina_cliente_Click(object sender, EventArgs e)
        {
            // Recupero il cliente selezionato
            var cliente_selezionato = (Cliente)cb_scegli_cliente.SelectedValue;


            // Elimino un cliente
            b1.clienti.Remove(cliente_selezionato);

            RefreshClienti();

            //Svuoto TextBox
            tb_nome.Text = "";
            tb_cognome.Text = "";
            tb_cf.Text = "";
            tb_stipendio.Text = "";

            MessageBox.Show("Cliente eliminato"); 
        }


        private void cb_scegli_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            // Recupero il cliente selezionato
            var cliente_selezionato = (Cliente)cb_scegli_cliente.SelectedValue;

            if (cliente_selezionato != null)
            {
                tb_nome.Text = cliente_selezionato.Nome;
                tb_cognome.Text = cliente_selezionato.Cognome;
                tb_cf.Text = cliente_selezionato.CodiceFiscale;
                tb_stipendio.Text = cliente_selezionato.Stipendio.ToString();
            }
        }

        private void RefreshClienti()
        {
            // Svuoto la lista
            cb_scegli_cliente.DataSource = null;

            // Aggiunta dei nomi dei clienti ad una combobox
            cb_scegli_cliente.DataSource = b1.clienti;
            cb_scegli_cliente.DisplayMember = "CodiceFiscale";
            cb_scegli_cliente.ValueMember = "Self";
        }
    }
}
