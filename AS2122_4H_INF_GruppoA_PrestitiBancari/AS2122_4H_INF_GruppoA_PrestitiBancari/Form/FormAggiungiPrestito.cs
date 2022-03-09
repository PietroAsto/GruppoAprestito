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
    public partial class FormAggiungiPrestito : Form
    {
        Menu m1;
        public FormAggiungiPrestito(Menu m)
        {
            InitializeComponent();
            m1 = m;
        }

        private void FormAggiungiPrestito_Load(object sender, EventArgs e)
        {
            cb_clienti.DataSource = m1.banca.clienti;
            cb_clienti.DisplayMember = "NomeCognome";
            cb_clienti.ValueMember = "Self";
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            // Salvo tutte le info del prestito
            Cliente cliente = (Cliente)cb_clienti.SelectedValue;
            double ammontare = ((double)nud_ammontare.Value);
            double rata = ((double)nud_ammontare.Value);
            DateTime inizio = dtp_inizio.Value;
            DateTime fine = dtp_fine.Value;

            // Creo e aggiungo un prestito alla lista dei prestiti
            Prestito prestito = new Prestito(cliente, ammontare, rata, inizio, fine);
            m1.banca.prestiti.Add(prestito);
        }

        private void cb_clienti_SelectedValueChanged(object sender, EventArgs e)
        {
            // ToDo: ripristinare campi 
        }
    }
}
