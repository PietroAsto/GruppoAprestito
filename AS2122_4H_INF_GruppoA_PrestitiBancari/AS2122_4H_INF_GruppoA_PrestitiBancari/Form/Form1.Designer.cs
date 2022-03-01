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
            this.button_form_accedi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.prestiti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aggiungi_Cliente
            // 
            this.Aggiungi_Cliente.Location = new System.Drawing.Point(12, 67);
            this.Aggiungi_Cliente.Name = "Aggiungi_Cliente";
            this.Aggiungi_Cliente.Size = new System.Drawing.Size(128, 25);
            this.Aggiungi_Cliente.TabIndex = 0;
            this.Aggiungi_Cliente.Text = "Aggiungi Cliente ";
            this.Aggiungi_Cliente.UseVisualStyleBackColor = true;
            this.Aggiungi_Cliente.Click += new System.EventHandler(this.Aggiungi_Cliente_Click);
            // 
            // button_form_accedi
            // 
            this.button_form_accedi.Location = new System.Drawing.Point(12, 12);
            this.button_form_accedi.Name = "button_form_accedi";
            this.button_form_accedi.Size = new System.Drawing.Size(100, 24);
            this.button_form_accedi.TabIndex = 1;
            this.button_form_accedi.Text = "Accedi";
            this.button_form_accedi.UseVisualStyleBackColor = true;
            this.button_form_accedi.Click += new System.EventHandler(this.button_accedi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifica";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prestiti
            // 
            this.prestiti.Location = new System.Drawing.Point(12, 184);
            this.prestiti.Name = "prestiti";
            this.prestiti.Size = new System.Drawing.Size(75, 23);
            this.prestiti.TabIndex = 4;
            this.prestiti.Text = "Prestiti";
            this.prestiti.UseVisualStyleBackColor = true;
            this.prestiti.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prestiti);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_form_accedi);
            this.Controls.Add(this.Aggiungi_Cliente);
            this.Name = "Menu";
            this.Text = "Menù";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aggiungi_Cliente;
        private System.Windows.Forms.Button button_form_accedi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button prestiti;
    }
}

