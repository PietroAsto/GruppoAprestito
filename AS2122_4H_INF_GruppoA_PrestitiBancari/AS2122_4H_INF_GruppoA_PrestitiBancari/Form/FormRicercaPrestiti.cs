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
            string cliente = tb_cf.Text;

            foreach (Prestito p in b1.prestiti)
            {
                if (p.Intestatario.CodiceFiscale == cliente)
                {
                    dgv_prestiti.DataSource = b1.prestiti;
                    dgv_prestiti.Columns.Remove("Intestatario");
                }
            }
        }

        private void dgv_prestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
