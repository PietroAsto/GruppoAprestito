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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ricerca = new System.Windows.Forms.Button();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_prestiti = new System.Windows.Forms.DataGridView();
            this.bancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice Fiscale ";
            // 
            // btn_ricerca
            // 
            this.btn_ricerca.Location = new System.Drawing.Point(337, 15);
            this.btn_ricerca.Name = "btn_ricerca";
            this.btn_ricerca.Size = new System.Drawing.Size(75, 23);
            this.btn_ricerca.TabIndex = 1;
            this.btn_ricerca.Text = "Ricerca";
            this.btn_ricerca.UseVisualStyleBackColor = true;
            this.btn_ricerca.Click += new System.EventHandler(this.btn_ricerca_Click);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(141, 16);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(168, 22);
            this.tb_cf.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(546, 405);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prestiti Concessi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ammontare Totale Dei Prestiti";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stampa Prospetto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgv_prestiti
            // 
            this.dgv_prestiti.AllowUserToAddRows = false;
            this.dgv_prestiti.AllowUserToDeleteRows = false;
            this.dgv_prestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prestiti.Location = new System.Drawing.Point(71, 102);
            this.dgv_prestiti.Name = "dgv_prestiti";
            this.dgv_prestiti.ReadOnly = true;
            this.dgv_prestiti.RowHeadersWidth = 51;
            this.dgv_prestiti.RowTemplate.Height = 24;
            this.dgv_prestiti.Size = new System.Drawing.Size(606, 150);
            this.dgv_prestiti.TabIndex = 9;
            // 
            // bancaBindingSource
            // 
            this.bancaBindingSource.DataSource = typeof(Prestiti_DLL.Banca);
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataSource = typeof(AS2122_4H_INF_GruppoA_PrestitiBancari.Menu);
            // 
            // FormRicercaPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_prestiti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.btn_ricerca);
            this.Controls.Add(this.label1);
            this.Name = "FormRicercaPrestiti";
            this.Text = "Prestiti";
            this.Load += new System.EventHandler(this.Prestiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prestiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ricerca;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.BindingSource bancaBindingSource;
        private System.Windows.Forms.DataGridView dgv_prestiti;
    }
}