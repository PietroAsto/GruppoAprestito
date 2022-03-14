namespace AS2122_4H_INF_GruppoA_PrestitiBancari
{
    partial class FormModificaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificaCliente));
            this.btn_modifica_cliente = new System.Windows.Forms.Button();
            this.btn_elimina_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_scegli_cliente = new System.Windows.Forms.ComboBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_cognome = new System.Windows.Forms.TextBox();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_stipendio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_modifica_cliente
            // 
            this.btn_modifica_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_modifica_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica_cliente.Location = new System.Drawing.Point(259, 359);
            this.btn_modifica_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modifica_cliente.Name = "btn_modifica_cliente";
            this.btn_modifica_cliente.Size = new System.Drawing.Size(100, 37);
            this.btn_modifica_cliente.TabIndex = 0;
            this.btn_modifica_cliente.Text = "Modifica ";
            this.btn_modifica_cliente.UseVisualStyleBackColor = false;
            this.btn_modifica_cliente.Click += new System.EventHandler(this.btn_modifica_cliente_Click);
            // 
            // btn_elimina_cliente
            // 
            this.btn_elimina_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elimina_cliente.Location = new System.Drawing.Point(391, 359);
            this.btn_elimina_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_elimina_cliente.Name = "btn_elimina_cliente";
            this.btn_elimina_cliente.Size = new System.Drawing.Size(85, 37);
            this.btn_elimina_cliente.TabIndex = 1;
            this.btn_elimina_cliente.Text = "Elimina";
            this.btn_elimina_cliente.UseVisualStyleBackColor = true;
            this.btn_elimina_cliente.Click += new System.EventHandler(this.btn_elimina_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scegli Cliente Tramite Codice Fiscale";
            // 
            // cb_scegli_cliente
            // 
            this.cb_scegli_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_scegli_cliente.FormattingEnabled = true;
            this.cb_scegli_cliente.Location = new System.Drawing.Point(511, 85);
            this.cb_scegli_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_scegli_cliente.Name = "cb_scegli_cliente";
            this.cb_scegli_cliente.Size = new System.Drawing.Size(129, 24);
            this.cb_scegli_cliente.TabIndex = 3;
            this.cb_scegli_cliente.SelectedValueChanged += new System.EventHandler(this.cb_scegli_cliente_SelectedValueChanged);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(511, 170);
            this.tb_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(129, 22);
            this.tb_nome.TabIndex = 4;
            // 
            // tb_cognome
            // 
            this.tb_cognome.Location = new System.Drawing.Point(511, 215);
            this.tb_cognome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cognome.Name = "tb_cognome";
            this.tb_cognome.Size = new System.Drawing.Size(129, 22);
            this.tb_cognome.TabIndex = 5;
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(511, 263);
            this.tb_cf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(129, 22);
            this.tb_cf.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codice Fiscale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(156, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stipendio";
            // 
            // tb_stipendio
            // 
            this.tb_stipendio.Location = new System.Drawing.Point(511, 310);
            this.tb_stipendio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_stipendio.Name = "tb_stipendio";
            this.tb_stipendio.Size = new System.Drawing.Size(129, 22);
            this.tb_stipendio.TabIndex = 11;
            // 
            // FormModificaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_stipendio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.tb_cognome);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.cb_scegli_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_elimina_cliente);
            this.Controls.Add(this.btn_modifica_cliente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormModificaCliente";
            this.Text = "Modifica";
            this.Load += new System.EventHandler(this.FormModificaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modifica_cliente;
        private System.Windows.Forms.Button btn_elimina_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_scegli_cliente;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_cognome;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_stipendio;
    }
}