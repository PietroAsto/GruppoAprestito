﻿using System;
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
    public partial class FormRicercaPrestiti : Form
    {
        Menu m1;
        public FormRicercaPrestiti(Menu m)
        {
            InitializeComponent();
            m1 = m;

            dgv_prestiti.DataSource = m1.banca.prestiti;
        }

        private void Prestiti_Load(object sender, EventArgs e)
        {

        }
    }
}
