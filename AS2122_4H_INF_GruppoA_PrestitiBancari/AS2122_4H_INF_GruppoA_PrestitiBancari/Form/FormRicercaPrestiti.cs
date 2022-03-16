using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Cliente cliente_ricercato;
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

                    // Salvo il cliente ricercato
                    cliente_ricercato = c;

                    // Levo l'orario, fondamentalmente perchè non serve
                    dgv_prestiti.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    dgv_prestiti.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

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
        private void bt_stampa_prospetto_Click(object sender, EventArgs e)
        {
            // Ricavo il percorso del deskstop indipendentemente dal pc in cui sono (uso le classi di sistema)
            string percorso_dekstop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (cliente_ricercato != null)
            {
                // Calcolo il nome del file
                string nome_file = "\\Prospetto_Prestiti_" + cliente_ricercato.Nome + "_" + cliente_ricercato.Cognome + DateTime.Now.ToString("dd.MM.yyyy") + ".csv";

                // Compongo il percorso assoluto del file
                string file = percorso_dekstop + nome_file;

                // Lo StringBuilder ci aiuta a comporre il csv e ad occuparsi degli a capo
                var csv = new StringBuilder();

                // Definisco e aggiungo manualmente i nomi delle colonne
                csv.AppendLine("Ammontare;Rata;DataInizio;DataFine");

                // Estraggo tutti i dati dei prestiti del cliente 
                foreach (Prestito p in cliente_ricercato.prestiti)
                {
                    string nuova_linea = $"{p.AmmontarePrestito};{p.Rata};{p.InizioPrestito.ToString("dd.MM.yyyy")};{p.FinePrestito.ToString("dd.MM.yyyy")}";
                    csv.AppendLine(nuova_linea);
                }

                // Scrivo il file
                File.WriteAllText(file, csv.ToString());
            }
        }

        private void dgv_prestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
