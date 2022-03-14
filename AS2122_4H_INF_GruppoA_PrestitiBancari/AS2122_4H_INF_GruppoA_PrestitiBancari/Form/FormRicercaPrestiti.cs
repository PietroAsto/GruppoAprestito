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
    public partial class FormRicercaPrestiti : Form
    {
        Banca b1;
        public FormRicercaPrestiti(Banca b)
        {
            InitializeComponent();
            b1 = b;

        }

        private void Prestiti_Load(object sender, EventArgs e)
        {

        }

        private void btn_ricerca_Click(object sender, EventArgs e)
        {
            string cf_cliente = tb_cf.Text;

            foreach (Cliente c in b1.clienti)
            {
                if (c.CodiceFiscale == cf_cliente)
                {
                    dgv_prestiti.DataSource = c.prestiti;

                    // Levo l'orario, fondamentalmente perchè non serve
                    dgv_prestiti.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
                    dgv_prestiti.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";

                    // Metodo per calcolare l'ammontare totale
                    double a_p = 0;
                    for (int i = 0; i < c.prestiti.Count; i++)
                    {
                        a_p += c.prestiti[i].AmmontarePrestito;
                    }
                    tb_amm_tot.Text = a_p.ToString();
                }

            }
        }

        private void dgv_prestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
