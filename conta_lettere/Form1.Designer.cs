namespace conta_lettere
{
    partial class Form1
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
            this.lbl_testo = new System.Windows.Forms.Label();
            this.txt_frase = new System.Windows.Forms.TextBox();
            this.btn_conta = new System.Windows.Forms.Button();
            this.list_lettere = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_testo
            // 
            this.lbl_testo.AutoSize = true;
            this.lbl_testo.Location = new System.Drawing.Point(54, 41);
            this.lbl_testo.Name = "lbl_testo";
            this.lbl_testo.Size = new System.Drawing.Size(137, 13);
            this.lbl_testo.TabIndex = 0;
            this.lbl_testo.Text = "INSERISCI UNA STRINGA";
            // 
            // txt_frase
            // 
            this.txt_frase.Location = new System.Drawing.Point(67, 57);
            this.txt_frase.Name = "txt_frase";
            this.txt_frase.Size = new System.Drawing.Size(100, 20);
            this.txt_frase.TabIndex = 1;
            // 
            // btn_conta
            // 
            this.btn_conta.Location = new System.Drawing.Point(77, 83);
            this.btn_conta.Name = "btn_conta";
            this.btn_conta.Size = new System.Drawing.Size(75, 23);
            this.btn_conta.TabIndex = 2;
            this.btn_conta.Text = "CONTA";
            this.btn_conta.UseVisualStyleBackColor = true;
            this.btn_conta.Click += new System.EventHandler(this.btn_conta_Click);
            // 
            // list_lettere
            // 
            this.list_lettere.FormattingEnabled = true;
            this.list_lettere.Location = new System.Drawing.Point(246, 31);
            this.list_lettere.Name = "list_lettere";
            this.list_lettere.Size = new System.Drawing.Size(120, 95);
            this.list_lettere.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 306);
            this.Controls.Add(this.list_lettere);
            this.Controls.Add(this.btn_conta);
            this.Controls.Add(this.txt_frase);
            this.Controls.Add(this.lbl_testo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_testo;
        private System.Windows.Forms.TextBox txt_frase;
        private System.Windows.Forms.Button btn_conta;
        private System.Windows.Forms.ListBox list_lettere;
    }
}

