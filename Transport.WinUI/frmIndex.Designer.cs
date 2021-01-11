namespace Transport.WinUI
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.Korisnici = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonVozaci = new System.Windows.Forms.Button();
            this.buttonAktivnevoznje = new System.Windows.Forms.Button();
            this.buttonZahtijevi = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.Vrijeme = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.menuPanel.Controls.Add(this.button8);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Controls.Add(this.button6);
            this.menuPanel.Controls.Add(this.panel2);
            this.menuPanel.Controls.Add(this.button3);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.buttonVozaci);
            this.menuPanel.Controls.Add(this.buttonAktivnevoznje);
            this.menuPanel.Controls.Add(this.buttonZahtijevi);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(250, 600);
            this.menuPanel.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Location = new System.Drawing.Point(0, 583);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(233, 45);
            this.button8.TabIndex = 14;
            this.button8.Text = "Odjava";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.Korisnici);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 80);
            this.panel3.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.LightGray;
            this.button7.Location = new System.Drawing.Point(0, 40);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(233, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "Dodaj novog";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // Korisnici
            // 
            this.Korisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.Korisnici.Dock = System.Windows.Forms.DockStyle.Top;
            this.Korisnici.FlatAppearance.BorderSize = 0;
            this.Korisnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Korisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Korisnici.ForeColor = System.Drawing.Color.LightGray;
            this.Korisnici.Location = new System.Drawing.Point(0, 0);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.Korisnici.Size = new System.Drawing.Size(233, 40);
            this.Korisnici.TabIndex = 7;
            this.Korisnici.Text = "Korisnici";
            this.Korisnici.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Korisnici.UseVisualStyleBackColor = false;
            this.Korisnici.Click += new System.EventHandler(this.Korisnici_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(0, 458);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 45);
            this.button6.TabIndex = 12;
            this.button6.Text = "Evidencija korisnika";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 80);
            this.panel2.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(0, 40);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(233, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Dodaj novo";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(233, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "Vozila";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(0, 333);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(233, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Evidencija vozila";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 80);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(233, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj novog";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(51)))), ((int)(((byte)(136)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vozači";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVozaci
            // 
            this.buttonVozaci.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVozaci.FlatAppearance.BorderSize = 0;
            this.buttonVozaci.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.buttonVozaci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonVozaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVozaci.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVozaci.Location = new System.Drawing.Point(0, 208);
            this.buttonVozaci.Name = "buttonVozaci";
            this.buttonVozaci.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonVozaci.Size = new System.Drawing.Size(233, 45);
            this.buttonVozaci.TabIndex = 8;
            this.buttonVozaci.Text = "Evidencija vozača";
            this.buttonVozaci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVozaci.UseVisualStyleBackColor = true;
            this.buttonVozaci.Click += new System.EventHandler(this.buttonVozaci_Click);
            // 
            // buttonAktivnevoznje
            // 
            this.buttonAktivnevoznje.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAktivnevoznje.FlatAppearance.BorderSize = 0;
            this.buttonAktivnevoznje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.buttonAktivnevoznje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonAktivnevoznje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAktivnevoznje.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAktivnevoznje.Location = new System.Drawing.Point(0, 163);
            this.buttonAktivnevoznje.Name = "buttonAktivnevoznje";
            this.buttonAktivnevoznje.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAktivnevoznje.Size = new System.Drawing.Size(233, 45);
            this.buttonAktivnevoznje.TabIndex = 5;
            this.buttonAktivnevoznje.Text = "Aktivne vožnje";
            this.buttonAktivnevoznje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAktivnevoznje.UseVisualStyleBackColor = true;
            this.buttonAktivnevoznje.Click += new System.EventHandler(this.buttonAktivnevoznje_Click);
            // 
            // buttonZahtijevi
            // 
            this.buttonZahtijevi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZahtijevi.FlatAppearance.BorderSize = 0;
            this.buttonZahtijevi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.buttonZahtijevi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.buttonZahtijevi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZahtijevi.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonZahtijevi.Location = new System.Drawing.Point(0, 118);
            this.buttonZahtijevi.Name = "buttonZahtijevi";
            this.buttonZahtijevi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonZahtijevi.Size = new System.Drawing.Size(233, 45);
            this.buttonZahtijevi.TabIndex = 6;
            this.buttonZahtijevi.Text = "Zahtijevi";
            this.buttonZahtijevi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZahtijevi.UseVisualStyleBackColor = true;
            this.buttonZahtijevi.Click += new System.EventHandler(this.buttonZahtijevi_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(233, 118);
            this.logoPanel.TabIndex = 5;
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(210, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 209);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(216, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datum
            // 
            this.Datum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Datum.AutoSize = true;
            this.Datum.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.Datum.Location = new System.Drawing.Point(240, 375);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(70, 28);
            this.Datum.TabIndex = 1;
            this.Datum.Text = "Datum";
            // 
            // Vrijeme
            // 
            this.Vrijeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vrijeme.AutoSize = true;
            this.Vrijeme.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F);
            this.Vrijeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.Vrijeme.Location = new System.Drawing.Point(319, 344);
            this.Vrijeme.Name = "Vrijeme";
            this.Vrijeme.Size = new System.Drawing.Size(82, 28);
            this.Vrijeme.TabIndex = 2;
            this.Vrijeme.Text = "Vrijeme";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblAdministrator);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Vrijeme);
            this.panel4.Controls.Add(this.Datum);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 600);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrator:";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 18F);
            this.lblAdministrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(55)))), ((int)(((byte)(133)))));
            this.lblAdministrator.Location = new System.Drawing.Point(140, 0);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(68, 28);
            this.lblAdministrator.TabIndex = 5;
            this.lblAdministrator.Text = "label3";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(41)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuPanel);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.menuPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button buttonZahtijevi;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVozaci;
        private System.Windows.Forms.Button buttonAktivnevoznje;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Korisnici;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Label Vrijeme;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label label2;
    }
}



