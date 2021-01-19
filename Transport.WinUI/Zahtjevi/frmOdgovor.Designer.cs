namespace Transport.WinUI.Zahtjevi
{
    partial class frmOdgovor
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
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.cmbVozac = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLokUtovara = new System.Windows.Forms.Label();
            this.lblLokIstovara = new System.Windows.Forms.Label();
            this.lblDatumTransporta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.VrstaRobe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVrstaRobe = new System.Windows.Forms.Label();
            this.lblUplaćeno = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Location = new System.Drawing.Point(163, 231);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(206, 96);
            this.rtbNapomena.TabIndex = 4;
            this.rtbNapomena.Text = "";
            // 
            // cmbVozac
            // 
            this.cmbVozac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVozac.FormattingEnabled = true;
            this.cmbVozac.Location = new System.Drawing.Point(163, 204);
            this.cmbVozac.Name = "cmbVozac";
            this.cmbVozac.Size = new System.Drawing.Size(206, 21);
            this.cmbVozac.TabIndex = 3;
            this.cmbVozac.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVozac_Validating);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button1.Location = new System.Drawing.Point(163, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prihvati";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLokUtovara
            // 
            this.lblLokUtovara.AutoSize = true;
            this.lblLokUtovara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLokUtovara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLokUtovara.Location = new System.Drawing.Point(197, 32);
            this.lblLokUtovara.Name = "lblLokUtovara";
            this.lblLokUtovara.Size = new System.Drawing.Size(50, 19);
            this.lblLokUtovara.TabIndex = 5;
            this.lblLokUtovara.Text = "label1";
            // 
            // lblLokIstovara
            // 
            this.lblLokIstovara.AutoSize = true;
            this.lblLokIstovara.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLokIstovara.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLokIstovara.Location = new System.Drawing.Point(197, 13);
            this.lblLokIstovara.Name = "lblLokIstovara";
            this.lblLokIstovara.Size = new System.Drawing.Size(50, 19);
            this.lblLokIstovara.TabIndex = 6;
            this.lblLokIstovara.Text = "label1";
            // 
            // lblDatumTransporta
            // 
            this.lblDatumTransporta.AutoSize = true;
            this.lblDatumTransporta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumTransporta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDatumTransporta.Location = new System.Drawing.Point(197, 51);
            this.lblDatumTransporta.Name = "lblDatumTransporta";
            this.lblDatumTransporta.Size = new System.Drawing.Size(50, 19);
            this.lblDatumTransporta.TabIndex = 7;
            this.lblDatumTransporta.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mjesto utovara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mjesto Istovara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum transporta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kilometraza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Napomena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vozač";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button2.Location = new System.Drawing.Point(269, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Odbij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VrstaRobe
            // 
            this.VrstaRobe.AutoSize = true;
            this.VrstaRobe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VrstaRobe.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VrstaRobe.Location = new System.Drawing.Point(13, 70);
            this.VrstaRobe.Name = "VrstaRobe";
            this.VrstaRobe.Size = new System.Drawing.Size(79, 19);
            this.VrstaRobe.TabIndex = 18;
            this.VrstaRobe.Text = "VrstaRobe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(13, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Uplaćeno";
            // 
            // lblVrstaRobe
            // 
            this.lblVrstaRobe.AutoSize = true;
            this.lblVrstaRobe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrstaRobe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVrstaRobe.Location = new System.Drawing.Point(197, 70);
            this.lblVrstaRobe.Name = "lblVrstaRobe";
            this.lblVrstaRobe.Size = new System.Drawing.Size(50, 19);
            this.lblVrstaRobe.TabIndex = 20;
            this.lblVrstaRobe.Text = "label1";
            // 
            // lblUplaćeno
            // 
            this.lblUplaćeno.AutoSize = true;
            this.lblUplaćeno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUplaćeno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUplaćeno.Location = new System.Drawing.Point(197, 89);
            this.lblUplaćeno.Name = "lblUplaćeno";
            this.lblUplaćeno.Size = new System.Drawing.Size(50, 19);
            this.lblUplaćeno.TabIndex = 21;
            this.lblUplaćeno.Text = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(163, 153);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(206, 20);
            this.txtCijena.TabIndex = 1;
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating_1);
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(163, 178);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(206, 20);
            this.txtKilometraza.TabIndex = 2;
            this.txtKilometraza.Validating += new System.ComponentModel.CancelEventHandler(this.txtKilometraza_Validating);
            // 
            // frmOdgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(492, 443);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblUplaćeno);
            this.Controls.Add(this.lblVrstaRobe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.VrstaRobe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatumTransporta);
            this.Controls.Add(this.lblLokIstovara);
            this.Controls.Add(this.lblLokUtovara);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbVozac);
            this.Controls.Add(this.rtbNapomena);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOdgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odgovor ";
            this.Load += new System.EventHandler(this.frmOdgovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.ComboBox cmbVozac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLokUtovara;
        private System.Windows.Forms.Label lblLokIstovara;
        private System.Windows.Forms.Label lblDatumTransporta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label VrstaRobe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVrstaRobe;
        private System.Windows.Forms.Label lblUplaćeno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtCijena;
    }
}