namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    partial class FormRicercaPrestiti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRicercaPrestiti));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ricerca = new System.Windows.Forms.Button();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.tb_amm_tot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_stampa_prospetto = new System.Windows.Forms.Button();
            this.dgv_prestiti = new System.Windows.Forms.DataGridView();
            this.tb_nome_cliente_ricercato = new System.Windows.Forms.TextBox();
            this.tb_cognome_cliente_ricercato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_svuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestiti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice Fiscale ";
            // 
            // btn_ricerca
            // 
            this.btn_ricerca.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ricerca.Location = new System.Drawing.Point(379, 22);
            this.btn_ricerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ricerca.Name = "btn_ricerca";
            this.btn_ricerca.Size = new System.Drawing.Size(98, 28);
            this.btn_ricerca.TabIndex = 1;
            this.btn_ricerca.Text = "Ricerca";
            this.btn_ricerca.UseVisualStyleBackColor = true;
            this.btn_ricerca.Click += new System.EventHandler(this.btn_ricerca_Click);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(162, 18);
            this.tb_cf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(168, 22);
            this.tb_cf.TabIndex = 2;
            // 
            // tb_amm_tot
            // 
            this.tb_amm_tot.Location = new System.Drawing.Point(318, 373);
            this.tb_amm_tot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_amm_tot.Name = "tb_amm_tot";
            this.tb_amm_tot.Size = new System.Drawing.Size(119, 22);
            this.tb_amm_tot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prestiti Concessi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ammontare Totale Dei Prestiti";
            // 
            // bt_stampa_prospetto
            // 
            this.bt_stampa_prospetto.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stampa_prospetto.Location = new System.Drawing.Point(39, 317);
            this.bt_stampa_prospetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_stampa_prospetto.Name = "bt_stampa_prospetto";
            this.bt_stampa_prospetto.Size = new System.Drawing.Size(196, 32);
            this.bt_stampa_prospetto.TabIndex = 7;
            this.bt_stampa_prospetto.Text = "Stampa Prospetto";
            this.bt_stampa_prospetto.UseVisualStyleBackColor = true;
            this.bt_stampa_prospetto.Click += new System.EventHandler(this.bt_stampa_prospetto_Click);
            // 
            // dgv_prestiti
            // 
            this.dgv_prestiti.AllowUserToAddRows = false;
            this.dgv_prestiti.AllowUserToDeleteRows = false;
            this.dgv_prestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestiti.Location = new System.Drawing.Point(39, 141);
            this.dgv_prestiti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_prestiti.Name = "dgv_prestiti";
            this.dgv_prestiti.ReadOnly = true;
            this.dgv_prestiti.RowHeadersWidth = 51;
            this.dgv_prestiti.RowTemplate.Height = 24;
            this.dgv_prestiti.Size = new System.Drawing.Size(606, 150);
            this.dgv_prestiti.TabIndex = 9;
            // 
            // tb_nome_cliente_ricercato
            // 
            this.tb_nome_cliente_ricercato.Location = new System.Drawing.Point(162, 71);
            this.tb_nome_cliente_ricercato.Name = "tb_nome_cliente_ricercato";
            this.tb_nome_cliente_ricercato.Size = new System.Drawing.Size(168, 22);
            this.tb_nome_cliente_ricercato.TabIndex = 10;
            // 
            // tb_cognome_cliente_ricercato
            // 
            this.tb_cognome_cliente_ricercato.Location = new System.Drawing.Point(162, 45);
            this.tb_cognome_cliente_ricercato.Name = "tb_cognome_cliente_ricercato";
            this.tb_cognome_cliente_ricercato.Size = new System.Drawing.Size(168, 22);
            this.tb_cognome_cliente_ricercato.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cognome";
            // 
            // bt_svuota
            // 
            this.bt_svuota.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_svuota.Location = new System.Drawing.Point(379, 65);
            this.bt_svuota.Name = "bt_svuota";
            this.bt_svuota.Size = new System.Drawing.Size(98, 28);
            this.bt_svuota.TabIndex = 14;
            this.bt_svuota.Text = "Svuota";
            this.bt_svuota.UseVisualStyleBackColor = true;
            this.bt_svuota.Click += new System.EventHandler(this.bt_svuota_Click);
            // 
            // FormRicercaPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_svuota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_cognome_cliente_ricercato);
            this.Controls.Add(this.tb_nome_cliente_ricercato);
            this.Controls.Add(this.dgv_prestiti);
            this.Controls.Add(this.bt_stampa_prospetto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_amm_tot);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.btn_ricerca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRicercaPrestiti";
            this.Text = "Prestiti";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ricerca;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.TextBox tb_amm_tot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_stampa_prospetto;
        private System.Windows.Forms.DataGridView dgv_prestiti;
        private System.Windows.Forms.TextBox tb_nome_cliente_ricercato;
        private System.Windows.Forms.TextBox tb_cognome_cliente_ricercato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_svuota;
    }
}