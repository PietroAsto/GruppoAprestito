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
            this.btn_modifica_cliente.Location = new System.Drawing.Point(55, 365);
            this.btn_modifica_cliente.Name = "btn_modifica_cliente";
            this.btn_modifica_cliente.Size = new System.Drawing.Size(75, 23);
            this.btn_modifica_cliente.TabIndex = 0;
            this.btn_modifica_cliente.Text = "Modifica ";
            this.btn_modifica_cliente.UseVisualStyleBackColor = true;
            this.btn_modifica_cliente.Click += new System.EventHandler(this.btn_modifica_cliente_Click);
            // 
            // btn_elimina_cliente
            // 
            this.btn_elimina_cliente.Location = new System.Drawing.Point(260, 361);
            this.btn_elimina_cliente.Name = "btn_elimina_cliente";
            this.btn_elimina_cliente.Size = new System.Drawing.Size(86, 27);
            this.btn_elimina_cliente.TabIndex = 1;
            this.btn_elimina_cliente.Text = "Elimina";
            this.btn_elimina_cliente.UseVisualStyleBackColor = true;
            this.btn_elimina_cliente.Click += new System.EventHandler(this.btn_elimina_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scegli Cliente Tramite Codice Fiscale";
            // 
            // cb_scegli_cliente
            // 
            this.cb_scegli_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_scegli_cliente.FormattingEnabled = true;
            this.cb_scegli_cliente.Location = new System.Drawing.Point(260, 28);
            this.cb_scegli_cliente.Name = "cb_scegli_cliente";
            this.cb_scegli_cliente.Size = new System.Drawing.Size(130, 24);
            this.cb_scegli_cliente.TabIndex = 3;
            this.cb_scegli_cliente.SelectedValueChanged += new System.EventHandler(this.cb_scegli_cliente_SelectedValueChanged);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(260, 86);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(130, 22);
            this.tb_nome.TabIndex = 4;
            // 
            // tb_cognome
            // 
            this.tb_cognome.Location = new System.Drawing.Point(260, 142);
            this.tb_cognome.Name = "tb_cognome";
            this.tb_cognome.Size = new System.Drawing.Size(130, 22);
            this.tb_cognome.TabIndex = 5;
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(260, 212);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(130, 22);
            this.tb_cf.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Codice Fiscale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Stipendio";
            // 
            // tb_stipendio
            // 
            this.tb_stipendio.Location = new System.Drawing.Point(260, 278);
            this.tb_stipendio.Name = "tb_stipendio";
            this.tb_stipendio.Size = new System.Drawing.Size(130, 22);
            this.tb_stipendio.TabIndex = 11;
            // 
            // FormModificaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FormModificaCliente";
            this.Text = "Modifica";
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