namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    partial class Menu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Aggiungi_Cliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prestiti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AggiungiPrestito = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aggiungi_Cliente
            // 
            this.Aggiungi_Cliente.Location = new System.Drawing.Point(6, 21);
            this.Aggiungi_Cliente.Name = "Aggiungi_Cliente";
            this.Aggiungi_Cliente.Size = new System.Drawing.Size(128, 29);
            this.Aggiungi_Cliente.TabIndex = 0;
            this.Aggiungi_Cliente.Text = "Aggiungi Cliente ";
            this.Aggiungi_Cliente.UseVisualStyleBackColor = true;
            this.Aggiungi_Cliente.Click += new System.EventHandler(this.Aggiungi_Cliente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifica Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ModificaCliente_Click);
            // 
            // prestiti
            // 
            this.prestiti.Location = new System.Drawing.Point(6, 62);
            this.prestiti.Name = "prestiti";
            this.prestiti.Size = new System.Drawing.Size(140, 34);
            this.prestiti.TabIndex = 4;
            this.prestiti.Text = "Ricerca Prestiti";
            this.prestiti.UseVisualStyleBackColor = true;
            this.prestiti.Click += new System.EventHandler(this.Ricerca_Prestiti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prestiti);
            this.groupBox1.Controls.Add(this.AggiungiPrestito);
            this.groupBox1.Location = new System.Drawing.Point(18, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prestiti";
            // 
            // AggiungiPrestito
            // 
            this.AggiungiPrestito.Location = new System.Drawing.Point(6, 21);
            this.AggiungiPrestito.Name = "AggiungiPrestito";
            this.AggiungiPrestito.Size = new System.Drawing.Size(140, 35);
            this.AggiungiPrestito.TabIndex = 7;
            this.AggiungiPrestito.Text = "Aggiungi Prestito";
            this.AggiungiPrestito.UseVisualStyleBackColor = true;
            this.AggiungiPrestito.Click += new System.EventHandler(this.AggiungiPrestito_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Aggiungi_Cliente);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clienti";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menù";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aggiungi_Cliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button prestiti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AggiungiPrestito;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

