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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
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
            this.Aggiungi_Cliente.Location = new System.Drawing.Point(32, 22);
            this.Aggiungi_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Aggiungi_Cliente.Name = "Aggiungi_Cliente";
            this.Aggiungi_Cliente.Size = new System.Drawing.Size(151, 42);
            this.Aggiungi_Cliente.TabIndex = 0;
            this.Aggiungi_Cliente.Text = "Aggiungi Cliente ";
            this.Aggiungi_Cliente.UseVisualStyleBackColor = true;
            this.Aggiungi_Cliente.Click += new System.EventHandler(this.Aggiungi_Cliente_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifica Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ModificaCliente_Click);
            // 
            // prestiti
            // 
            this.prestiti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.prestiti.FlatAppearance.BorderSize = 2;
            this.prestiti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.prestiti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.prestiti.Location = new System.Drawing.Point(32, 74);
            this.prestiti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prestiti.Name = "prestiti";
            this.prestiti.Size = new System.Drawing.Size(151, 44);
            this.prestiti.TabIndex = 4;
            this.prestiti.Text = "Ricerca Prestiti";
            this.prestiti.UseVisualStyleBackColor = true;
            this.prestiti.Click += new System.EventHandler(this.Ricerca_Prestiti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.prestiti);
            this.groupBox1.Controls.Add(this.AggiungiPrestito);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(148, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(220, 123);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "               PRESTITI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AggiungiPrestito
            // 
            this.AggiungiPrestito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AggiungiPrestito.FlatAppearance.BorderSize = 2;
            this.AggiungiPrestito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AggiungiPrestito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AggiungiPrestito.Location = new System.Drawing.Point(32, 23);
            this.AggiungiPrestito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AggiungiPrestito.Name = "AggiungiPrestito";
            this.AggiungiPrestito.Size = new System.Drawing.Size(151, 42);
            this.AggiungiPrestito.TabIndex = 7;
            this.AggiungiPrestito.Text = "Aggiungi Prestito";
            this.AggiungiPrestito.UseVisualStyleBackColor = true;
            this.AggiungiPrestito.Click += new System.EventHandler(this.AggiungiPrestito_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Aggiungi_Cliente);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(148, 66);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(220, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "                CLIENTI";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menù";
            this.Load += new System.EventHandler(this.Menu_Load);
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

