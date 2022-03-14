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
        Banca b1;
        public FormAggiungiPrestito(Banca b)
        {
            InitializeComponent();
            b1 = b;
        }

        private void FormAggiungiPrestito_Load(object sender, EventArgs e)
        {
            cb_clienti.DataSource = b1.clienti;
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
            b1.prestiti.Add(prestito);

            // Ripristino i valori del prestito quando si aggiunge un prestito
            nud_ammontare.Value = 0;
            nud_rata.Value = 0;
            dtp_inizio.Value = DateTime.Today;
            dtp_fine.Value = DateTime.Today;

            MessageBox.Show("Prestito aggiunto correttamente");
            
        }

        private void cb_clienti_SelectedValueChanged(object sender, EventArgs e)
        {
            // Ripristino i valori del prestito quando si cambia cliente
            nud_ammontare.Value = 0;
            nud_rata.Value = 0;
            dtp_inizio.Value = DateTime.Today;
            dtp_fine.Value = DateTime.Today;
        }
    }
}
