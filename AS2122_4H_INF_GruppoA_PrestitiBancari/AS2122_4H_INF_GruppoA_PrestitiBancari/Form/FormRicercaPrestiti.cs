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
        Menu m1;
        public FormRicercaPrestiti(Menu m)
        {
            InitializeComponent();
            m1 = m;

        }

        private void Prestiti_Load(object sender, EventArgs e)
        {

        }

        private void btn_ricerca_Click(object sender, EventArgs e)
        {
            string cliente = tb_cf.Text;

            foreach (Prestito p in m1.banca.prestiti)
            {
                if(p.Intestatario.CodiceFiscale == cliente) 
                    dgv_prestiti.DataSource = m1.banca.prestiti;
            }
        }
    }
}
