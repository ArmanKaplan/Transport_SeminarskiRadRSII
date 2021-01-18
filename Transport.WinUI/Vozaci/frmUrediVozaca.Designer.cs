namespace Transport.WinUI.Vozaci
{
    partial class frmUrediVozaca
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
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtGodineIskustva = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtMjestoRodjenja = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(11, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 39);
            this.label12.TabIndex = 91;
            this.label12.Text = "Uredi vozača";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button1.Location = new System.Drawing.Point(173, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "Spasi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(15, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 85;
            this.label9.Text = "Grad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(14, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 84;
            this.label8.Text = "Vozilo";
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(173, 313);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(225, 21);
            this.cmbGradovi.TabIndex = 83;
            this.cmbGradovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradovi_Validating);
            // 
            // cmbVozila
            // 
            this.cmbVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(173, 286);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(225, 21);
            this.cmbVozila.TabIndex = 82;
            this.cmbVozila.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVozila_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 81;
            this.label7.Text = "Korisnicko ime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Godine iskustva";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 79;
            this.label5.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 78;
            this.label4.Text = "Mjesto rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "JMBG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 76;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Ime";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(173, 260);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(225, 20);
            this.txtKorisnickoIme.TabIndex = 74;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // txtGodineIskustva
            // 
            this.txtGodineIskustva.Location = new System.Drawing.Point(173, 235);
            this.txtGodineIskustva.Name = "txtGodineIskustva";
            this.txtGodineIskustva.Size = new System.Drawing.Size(225, 20);
            this.txtGodineIskustva.TabIndex = 73;
            this.txtGodineIskustva.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodineIskustva_Validating);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(173, 209);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(225, 20);
            this.txtAdresa.TabIndex = 72;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // txtMjestoRodjenja
            // 
            this.txtMjestoRodjenja.Location = new System.Drawing.Point(173, 183);
            this.txtMjestoRodjenja.Name = "txtMjestoRodjenja";
            this.txtMjestoRodjenja.Size = new System.Drawing.Size(225, 20);
            this.txtMjestoRodjenja.TabIndex = 71;
            this.txtMjestoRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoRodjenja_Validating);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(173, 157);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(225, 20);
            this.txtJMBG.TabIndex = 70;
            this.txtJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.txtJMBG_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(173, 131);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(225, 20);
            this.txtPrezime.TabIndex = 69;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(173, 105);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(225, 20);
            this.txtIme.TabIndex = 68;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmUrediVozaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbGradovi);
            this.Controls.Add(this.cmbVozila);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.txtGodineIskustva);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtMjestoRodjenja);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUrediVozaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uredi vozača";
            this.Load += new System.EventHandler(this.frmUrediVozaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtGodineIskustva;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtMjestoRodjenja;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}