namespace Transport.WinUI.Voznje
{
    partial class frmVoznje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoznje));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvVoznje = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LokacijaUtovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokacijaIstovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumTrasporta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaRobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vozac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kilometraza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aktivne voznje",
            "Zavrsene voznje"});
            this.comboBox1.Location = new System.Drawing.Point(13, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 27);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvVoznje
            // 
            this.dgvVoznje.AllowUserToAddRows = false;
            this.dgvVoznje.AllowUserToDeleteRows = false;
            this.dgvVoznje.AllowUserToResizeColumns = false;
            this.dgvVoznje.AllowUserToResizeRows = false;
            this.dgvVoznje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVoznje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoznje.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVoznje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVoznje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoznje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVoznje.ColumnHeadersHeight = 50;
            this.dgvVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LokacijaUtovara,
            this.LokacijaIstovara,
            this.DatumTrasporta,
            this.VrstaRobe,
            this.Vozac,
            this.Cijena,
            this.Kilometraza});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoznje.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVoznje.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVoznje.Location = new System.Drawing.Point(13, 116);
            this.dgvVoznje.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVoznje.Name = "dgvVoznje";
            this.dgvVoznje.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoznje.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVoznje.RowHeadersVisible = false;
            this.dgvVoznje.RowHeadersWidth = 62;
            this.dgvVoznje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvVoznje.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVoznje.RowTemplate.Height = 28;
            this.dgvVoznje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVoznje.Size = new System.Drawing.Size(642, 263);
            this.dgvVoznje.TabIndex = 35;
            this.dgvVoznje.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVoznje_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button4.Location = new System.Drawing.Point(509, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 33);
            this.button4.TabIndex = 33;
            this.button4.Text = "Pošalji obavijest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button3.Location = new System.Drawing.Point(359, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 33);
            this.button3.TabIndex = 32;
            this.button3.Text = "Kvarovi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button2.Location = new System.Drawing.Point(205, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 33);
            this.button2.TabIndex = 30;
            this.button2.Text = "Prikaži na mapi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Voznje";
            // 
            // LokacijaUtovara
            // 
            this.LokacijaUtovara.DataPropertyName = "Zahtjev.LokacijaUtovara";
            this.LokacijaUtovara.FillWeight = 105.2337F;
            this.LokacijaUtovara.HeaderText = "LokacijaUtovara";
            this.LokacijaUtovara.Name = "LokacijaUtovara";
            this.LokacijaUtovara.ReadOnly = true;
            // 
            // LokacijaIstovara
            // 
            this.LokacijaIstovara.DataPropertyName = "Zahtjev.LokacijaIstovara";
            this.LokacijaIstovara.FillWeight = 97.63347F;
            this.LokacijaIstovara.HeaderText = "Lokacija istovara";
            this.LokacijaIstovara.Name = "LokacijaIstovara";
            this.LokacijaIstovara.ReadOnly = true;
            // 
            // DatumTrasporta
            // 
            this.DatumTrasporta.DataPropertyName = "Zahtjev.DatumTransporta";
            this.DatumTrasporta.FillWeight = 97.63347F;
            this.DatumTrasporta.HeaderText = "Datum transporta";
            this.DatumTrasporta.Name = "DatumTrasporta";
            this.DatumTrasporta.ReadOnly = true;
            // 
            // VrstaRobe
            // 
            this.VrstaRobe.DataPropertyName = "Zahtjev.VrstaRobe";
            this.VrstaRobe.FillWeight = 97.63347F;
            this.VrstaRobe.HeaderText = "Vrsta robe";
            this.VrstaRobe.Name = "VrstaRobe";
            this.VrstaRobe.ReadOnly = true;
            // 
            // Vozac
            // 
            this.Vozac.DataPropertyName = "Vozac.Ime";
            this.Vozac.FillWeight = 97.63347F;
            this.Vozac.HeaderText = "Vozac";
            this.Vozac.Name = "Vozac";
            this.Vozac.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.FillWeight = 97.63347F;
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kilometraza
            // 
            this.Kilometraza.DataPropertyName = "Kilometraza";
            this.Kilometraza.HeaderText = "km";
            this.Kilometraza.Name = "Kilometraza";
            this.Kilometraza.ReadOnly = true;
            // 
            // frmVoznje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(696, 457);
            this.Controls.Add(this.dgvVoznje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmVoznje";
            this.Text = "Voznje";
            this.Load += new System.EventHandler(this.frmVoznje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoznje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvVoznje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaUtovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaIstovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumTrasporta;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaRobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vozac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kilometraza;
    }
}