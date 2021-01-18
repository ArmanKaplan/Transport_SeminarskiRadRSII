namespace Transport.WinUI.Vozaci
{
    partial class frmDodajVozaci
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtMjestoRodjenja = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtGodineIskustva = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.cmbGradovi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(171, 85);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(225, 20);
            this.txtIme.TabIndex = 0;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(171, 111);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(225, 20);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(171, 137);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(225, 20);
            this.txtJMBG.TabIndex = 2;
            this.txtJMBG.Validating += new System.ComponentModel.CancelEventHandler(this.txtJMBG_Validating);
            // 
            // txtMjestoRodjenja
            // 
            this.txtMjestoRodjenja.Location = new System.Drawing.Point(171, 163);
            this.txtMjestoRodjenja.Name = "txtMjestoRodjenja";
            this.txtMjestoRodjenja.Size = new System.Drawing.Size(225, 20);
            this.txtMjestoRodjenja.TabIndex = 3;
            this.txtMjestoRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoRodjenja_Validating);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(171, 189);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(225, 20);
            this.txtAdresa.TabIndex = 4;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // txtGodineIskustva
            // 
            this.txtGodineIskustva.Location = new System.Drawing.Point(171, 215);
            this.txtGodineIskustva.Name = "txtGodineIskustva";
            this.txtGodineIskustva.Size = new System.Drawing.Size(225, 20);
            this.txtGodineIskustva.TabIndex = 5;
            this.txtGodineIskustva.Validating += new System.ComponentModel.CancelEventHandler(this.txtGodineIskustva_Validating);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(171, 240);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(225, 20);
            this.txtKorisnickoIme.TabIndex = 6;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "JMBG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mjesto rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Godine iskustva";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Korisnicko ime";
            // 
            // cmbVozila
            // 
            this.cmbVozila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(171, 266);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(225, 21);
            this.cmbVozila.TabIndex = 14;
            this.cmbVozila.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVozila_Validating);
            // 
            // cmbGradovi
            // 
            this.cmbGradovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGradovi.FormattingEnabled = true;
            this.cmbGradovi.Location = new System.Drawing.Point(171, 293);
            this.cmbGradovi.Name = "cmbGradovi";
            this.cmbGradovi.Size = new System.Drawing.Size(225, 21);
            this.cmbGradovi.TabIndex = 15;
            this.cmbGradovi.SelectedIndexChanged += new System.EventHandler(this.cmbGradovi_SelectedIndexChanged);
            this.cmbGradovi.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGradovi_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vozilo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Grad";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button1.Location = new System.Drawing.Point(171, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Spasi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 320);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 20);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtPasswordPotvrda
            // 
            this.txtPasswordPotvrda.Location = new System.Drawing.Point(171, 346);
            this.txtPasswordPotvrda.Name = "txtPasswordPotvrda";
            this.txtPasswordPotvrda.Size = new System.Drawing.Size(225, 20);
            this.txtPasswordPotvrda.TabIndex = 20;
            this.txtPasswordPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordPotvrda_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(12, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(13, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Password potvrda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 39);
            this.label12.TabIndex = 67;
            this.label12.Text = "Dodaj novog vozača";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDodajVozaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPasswordPotvrda);
            this.Controls.Add(this.txtPassword);
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
            this.Name = "frmDodajVozaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj vozača";
            this.Load += new System.EventHandler(this.frmDodajVozaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtMjestoRodjenja;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtGodineIskustva;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVozila;
        private System.Windows.Forms.ComboBox cmbGradovi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordPotvrda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}