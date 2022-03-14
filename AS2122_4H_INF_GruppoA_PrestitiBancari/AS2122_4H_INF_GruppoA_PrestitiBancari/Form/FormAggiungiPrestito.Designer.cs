namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    partial class FormAggiungiPrestito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAggiungiPrestito));
            this.cb_clienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_ammontare = new System.Windows.Forms.NumericUpDown();
            this.nud_rata = new System.Windows.Forms.NumericUpDown();
            this.dtp_inizio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fine = new System.Windows.Forms.DateTimePicker();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ammontare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rata)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_clienti
            // 
            this.cb_clienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_clienti.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_clienti.FormattingEnabled = true;
            this.cb_clienti.Location = new System.Drawing.Point(326, 71);
            this.cb_clienti.Name = "cb_clienti";
            this.cb_clienti.Size = new System.Drawing.Size(256, 28);
            this.cb_clienti.TabIndex = 0;
            this.cb_clienti.SelectedValueChanged += new System.EventHandler(this.cb_clienti_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ammontare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Inizio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data Fine";
            // 
            // nud_ammontare
            // 
            this.nud_ammontare.DecimalPlaces = 2;
            this.nud_ammontare.Location = new System.Drawing.Point(327, 129);
            this.nud_ammontare.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nud_ammontare.Name = "nud_ammontare";
            this.nud_ammontare.Size = new System.Drawing.Size(255, 22);
            this.nud_ammontare.TabIndex = 6;
            // 
            // nud_rata
            // 
            this.nud_rata.DecimalPlaces = 2;
            this.nud_rata.Location = new System.Drawing.Point(327, 181);
            this.nud_rata.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nud_rata.Name = "nud_rata";
            this.nud_rata.Size = new System.Drawing.Size(255, 22);
            this.nud_rata.TabIndex = 7;
            // 
            // dtp_inizio
            // 
            this.dtp_inizio.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inizio.Location = new System.Drawing.Point(326, 239);
            this.dtp_inizio.Name = "dtp_inizio";
            this.dtp_inizio.Size = new System.Drawing.Size(256, 27);
            this.dtp_inizio.TabIndex = 8;
            // 
            // dtp_fine
            // 
            this.dtp_fine.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fine.Location = new System.Drawing.Point(326, 294);
            this.dtp_fine.Name = "dtp_fine";
            this.dtp_fine.Size = new System.Drawing.Size(256, 27);
            this.dtp_fine.TabIndex = 9;
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiungi.Location = new System.Drawing.Point(271, 353);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(109, 29);
            this.btn_aggiungi.TabIndex = 10;
            this.btn_aggiungi.Text = "Aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // FormAggiungiPrestito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.dtp_fine);
            this.Controls.Add(this.dtp_inizio);
            this.Controls.Add(this.nud_rata);
            this.Controls.Add(this.nud_ammontare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_clienti);
            this.Name = "FormAggiungiPrestito";
            this.Text = "FormAggiungiPrestito";
            this.Load += new System.EventHandler(this.FormAggiungiPrestito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ammontare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_clienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_ammontare;
        private System.Windows.Forms.NumericUpDown nud_rata;
        private System.Windows.Forms.DateTimePicker dtp_inizio;
        private System.Windows.Forms.DateTimePicker dtp_fine;
        private System.Windows.Forms.Button btn_aggiungi;
    }
}