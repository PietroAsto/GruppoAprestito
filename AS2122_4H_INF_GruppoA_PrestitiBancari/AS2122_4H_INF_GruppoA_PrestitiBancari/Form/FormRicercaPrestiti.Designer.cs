﻿namespace AS2122_4H_INF_GruppoA_PrestitiBancari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRicercaPrestiti));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ricerca = new System.Windows.Forms.Button();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_prestiti = new System.Windows.Forms.DataGridView();
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
            this.btn_ricerca.Location = new System.Drawing.Point(197, 56);
            this.btn_ricerca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ricerca.Name = "btn_ricerca";
            this.btn_ricerca.Size = new System.Drawing.Size(98, 29);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 373);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 22);
            this.textBox2.TabIndex = 3;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(40, 317);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Stampa Prospetto";
            this.button2.UseVisualStyleBackColor = true;
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
            this.dgv_prestiti.Size = new System.Drawing.Size(737, 150);
            this.dgv_prestiti.TabIndex = 9;
            this.dgv_prestiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prestiti_CellContentClick);
            // 

            
            // 
            // FormRicercaPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_prestiti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.btn_ricerca);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRicercaPrestiti";
            this.Text = "Prestiti";
            this.Load += new System.EventHandler(this.Prestiti_Load);
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
        private System.Windows.Forms.DataGridView dgv_prestiti;
    }
}