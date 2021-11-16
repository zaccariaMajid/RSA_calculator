namespace Majid_RSA_avanzato
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
            this.txt_messaggio = new System.Windows.Forms.TextBox();
            this.txt_messaggioCif = new System.Windows.Forms.TextBox();
            this.txt_messaggioDecif = new System.Windows.Forms.TextBox();
            this.txt_firmaDigDec = new System.Windows.Forms.TextBox();
            this.btn_Cif = new System.Windows.Forms.Button();
            this.btn_Decif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_svuota = new System.Windows.Forms.Button();
            this.btn_genera = new System.Windows.Forms.Button();
            this.btn_hsahFirma = new System.Windows.Forms.Button();
            this.txt_xor = new System.Windows.Forms.TextBox();
            this.txt_rot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_messaggio
            // 
            this.txt_messaggio.Location = new System.Drawing.Point(87, 158);
            this.txt_messaggio.Multiline = true;
            this.txt_messaggio.Name = "txt_messaggio";
            this.txt_messaggio.Size = new System.Drawing.Size(167, 69);
            this.txt_messaggio.TabIndex = 0;
            // 
            // txt_messaggioCif
            // 
            this.txt_messaggioCif.Enabled = false;
            this.txt_messaggioCif.Location = new System.Drawing.Point(260, 158);
            this.txt_messaggioCif.Multiline = true;
            this.txt_messaggioCif.Name = "txt_messaggioCif";
            this.txt_messaggioCif.Size = new System.Drawing.Size(334, 128);
            this.txt_messaggioCif.TabIndex = 1;
            // 
            // txt_messaggioDecif
            // 
            this.txt_messaggioDecif.Enabled = false;
            this.txt_messaggioDecif.Location = new System.Drawing.Point(600, 188);
            this.txt_messaggioDecif.Multiline = true;
            this.txt_messaggioDecif.Name = "txt_messaggioDecif";
            this.txt_messaggioDecif.Size = new System.Drawing.Size(167, 69);
            this.txt_messaggioDecif.TabIndex = 2;
            // 
            // txt_firmaDigDec
            // 
            this.txt_firmaDigDec.Enabled = false;
            this.txt_firmaDigDec.Location = new System.Drawing.Point(600, 327);
            this.txt_firmaDigDec.Multiline = true;
            this.txt_firmaDigDec.Name = "txt_firmaDigDec";
            this.txt_firmaDigDec.Size = new System.Drawing.Size(167, 69);
            this.txt_firmaDigDec.TabIndex = 4;
            // 
            // btn_Cif
            // 
            this.btn_Cif.Location = new System.Drawing.Point(103, 234);
            this.btn_Cif.Name = "btn_Cif";
            this.btn_Cif.Size = new System.Drawing.Size(139, 23);
            this.btn_Cif.TabIndex = 5;
            this.btn_Cif.Text = "CIFRA";
            this.btn_Cif.UseVisualStyleBackColor = true;
            this.btn_Cif.Click += new System.EventHandler(this.btn_Cif_Click);
            // 
            // btn_Decif
            // 
            this.btn_Decif.Location = new System.Drawing.Point(600, 263);
            this.btn_Decif.Name = "btn_Decif";
            this.btn_Decif.Size = new System.Drawing.Size(167, 23);
            this.btn_Decif.TabIndex = 6;
            this.btn_Decif.Text = "DECIFRA";
            this.btn_Decif.UseVisualStyleBackColor = true;
            this.btn_Decif.Click += new System.EventHandler(this.btn_Decif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "-";
            // 
            // btn_svuota
            // 
            this.btn_svuota.Location = new System.Drawing.Point(42, 180);
            this.btn_svuota.Name = "btn_svuota";
            this.btn_svuota.Size = new System.Drawing.Size(39, 23);
            this.btn_svuota.TabIndex = 10;
            this.btn_svuota.Text = "D";
            this.btn_svuota.UseVisualStyleBackColor = true;
            this.btn_svuota.Click += new System.EventHandler(this.btn_svuota_Click);
            // 
            // btn_genera
            // 
            this.btn_genera.Location = new System.Drawing.Point(87, 34);
            this.btn_genera.Name = "btn_genera";
            this.btn_genera.Size = new System.Drawing.Size(196, 56);
            this.btn_genera.TabIndex = 11;
            this.btn_genera.Text = "GENERA CHIAVI";
            this.btn_genera.UseVisualStyleBackColor = true;
            this.btn_genera.Click += new System.EventHandler(this.btn_genera_Click);
            // 
            // btn_hsahFirma
            // 
            this.btn_hsahFirma.Location = new System.Drawing.Point(486, 402);
            this.btn_hsahFirma.Name = "btn_hsahFirma";
            this.btn_hsahFirma.Size = new System.Drawing.Size(212, 23);
            this.btn_hsahFirma.TabIndex = 13;
            this.btn_hsahFirma.Text = "DECIFRA FIRMA DIGITALE";
            this.btn_hsahFirma.UseVisualStyleBackColor = true;
            this.btn_hsahFirma.Click += new System.EventHandler(this.btn_hsahFirma_Click);
            // 
            // txt_xor
            // 
            this.txt_xor.Enabled = false;
            this.txt_xor.Location = new System.Drawing.Point(219, 327);
            this.txt_xor.Multiline = true;
            this.txt_xor.Name = "txt_xor";
            this.txt_xor.Size = new System.Drawing.Size(167, 69);
            this.txt_xor.TabIndex = 14;
            // 
            // txt_rot
            // 
            this.txt_rot.Enabled = false;
            this.txt_rot.Location = new System.Drawing.Point(392, 327);
            this.txt_rot.Multiline = true;
            this.txt_rot.Name = "txt_rot";
            this.txt_rot.Size = new System.Drawing.Size(167, 69);
            this.txt_rot.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "XOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ROT13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rot);
            this.Controls.Add(this.txt_xor);
            this.Controls.Add(this.btn_hsahFirma);
            this.Controls.Add(this.btn_genera);
            this.Controls.Add(this.btn_svuota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Decif);
            this.Controls.Add(this.btn_Cif);
            this.Controls.Add(this.txt_firmaDigDec);
            this.Controls.Add(this.txt_messaggioDecif);
            this.Controls.Add(this.txt_messaggioCif);
            this.Controls.Add(this.txt_messaggio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_messaggio;
        private System.Windows.Forms.TextBox txt_messaggioCif;
        private System.Windows.Forms.TextBox txt_messaggioDecif;
        private System.Windows.Forms.TextBox txt_firmaDigDec;
        private System.Windows.Forms.Button btn_Cif;
        private System.Windows.Forms.Button btn_Decif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_svuota;
        private System.Windows.Forms.Button btn_genera;
        private System.Windows.Forms.Button btn_hsahFirma;
        private System.Windows.Forms.TextBox txt_xor;
        private System.Windows.Forms.TextBox txt_rot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

