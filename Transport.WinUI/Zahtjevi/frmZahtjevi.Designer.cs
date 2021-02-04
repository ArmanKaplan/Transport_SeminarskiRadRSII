namespace Transport.WinUI.Zahtjevi
{
    partial class frmZahtjevi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZahtjevi));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zahtjeviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportDataSet = new Transport.WinUI.TransportDataSet();
            this.zahtjeviTableAdapter = new Transport.WinUI.TransportDataSetTableAdapters.ZahtjeviTableAdapter();
            this.transportDataSet1 = new Transport.WinUI.TransportDataSet();
            this.transportDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvZAHTJEVI = new System.Windows.Forms.DataGridView();
            this.LokacijaUtovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LokacijaIstovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumTransporta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaRobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIspisNaloga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZAHTJEVI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zahtjeviBindingSource, "Obradjen", true));
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Neobrađeni zahtjevi",
            "Obrađeni zahtjevi"});
            this.comboBox1.Location = new System.Drawing.Point(10, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 27);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zahtjeviBindingSource
            // 
            this.zahtjeviBindingSource.DataMember = "Zahtjevi";
            this.zahtjeviBindingSource.DataSource = this.transportDataSet;
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjeviTableAdapter
            // 
            this.zahtjeviTableAdapter.ClearBeforeFill = true;
            // 
            // transportDataSet1
            // 
            this.transportDataSet1.DataSetName = "TransportDataSet";
            this.transportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportDataSet1BindingSource
            // 
            this.transportDataSet1BindingSource.DataSource = this.transportDataSet1;
            this.transportDataSet1BindingSource.Position = 0;
            // 
            // dgvZAHTJEVI
            // 
            this.dgvZAHTJEVI.AllowUserToAddRows = false;
            this.dgvZAHTJEVI.AllowUserToDeleteRows = false;
            this.dgvZAHTJEVI.AllowUserToResizeColumns = false;
            this.dgvZAHTJEVI.AllowUserToResizeRows = false;
            this.dgvZAHTJEVI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZAHTJEVI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZAHTJEVI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvZAHTJEVI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvZAHTJEVI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZAHTJEVI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZAHTJEVI.ColumnHeadersHeight = 50;
            this.dgvZAHTJEVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvZAHTJEVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LokacijaUtovara,
            this.LokacijaIstovara,
            this.DatumTransporta,
            this.VrstaRobe,
            this.Napomena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZAHTJEVI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZAHTJEVI.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvZAHTJEVI.Location = new System.Drawing.Point(10, 116);
            this.dgvZAHTJEVI.Margin = new System.Windows.Forms.Padding(2);
            this.dgvZAHTJEVI.Name = "dgvZAHTJEVI";
            this.dgvZAHTJEVI.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZAHTJEVI.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZAHTJEVI.RowHeadersVisible = false;
            this.dgvZAHTJEVI.RowHeadersWidth = 62;
            this.dgvZAHTJEVI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvZAHTJEVI.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZAHTJEVI.RowTemplate.Height = 28;
            this.dgvZAHTJEVI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZAHTJEVI.Size = new System.Drawing.Size(642, 263);
            this.dgvZAHTJEVI.TabIndex = 27;
            this.dgvZAHTJEVI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZAHTJEVI_CellContentClick_1);
            // 
            // LokacijaUtovara
            // 
            this.LokacijaUtovara.DataPropertyName = "LokacijaUtovara";
            this.LokacijaUtovara.HeaderText = "Lokacija utovara";
            this.LokacijaUtovara.Name = "LokacijaUtovara";
            this.LokacijaUtovara.ReadOnly = true;
            // 
            // LokacijaIstovara
            // 
            this.LokacijaIstovara.DataPropertyName = "LokacijaIstovara";
            this.LokacijaIstovara.HeaderText = "Lokacija istovara";
            this.LokacijaIstovara.Name = "LokacijaIstovara";
            this.LokacijaIstovara.ReadOnly = true;
            // 
            // DatumTransporta
            // 
            this.DatumTransporta.DataPropertyName = "DatumTransporta";
            this.DatumTransporta.HeaderText = "Datum transporta";
            this.DatumTransporta.Name = "DatumTransporta";
            this.DatumTransporta.ReadOnly = true;
            // 
            // VrstaRobe
            // 
            this.VrstaRobe.DataPropertyName = "VrstaRobe";
            this.VrstaRobe.HeaderText = "Vrsta robe";
            this.VrstaRobe.Name = "VrstaRobe";
            this.VrstaRobe.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.button4.Location = new System.Drawing.Point(561, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 33);
            this.button4.TabIndex = 25;
            this.button4.Text = "Odgovori";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 33);
            this.label1.TabIndex = 28;
            this.label1.Text = "Zahtjevi";
            // 
            // btnIspisNaloga
            // 
            this.btnIspisNaloga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIspisNaloga.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisNaloga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            this.btnIspisNaloga.Location = new System.Drawing.Point(349, 395);
            this.btnIspisNaloga.Name = "btnIspisNaloga";
            this.btnIspisNaloga.Size = new System.Drawing.Size(206, 33);
            this.btnIspisNaloga.TabIndex = 29;
            this.btnIspisNaloga.Text = "Ispis naloga";
            this.btnIspisNaloga.UseVisualStyleBackColor = true;
            this.btnIspisNaloga.Click += new System.EventHandler(this.btnIspisNaloga_Click);
            // 
            // frmZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(696, 457);
            this.Controls.Add(this.btnIspisNaloga);
            this.Controls.Add(this.dgvZAHTJEVI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmZahtjevi";
            this.Text = "Zahtjevi";
            this.Load += new System.EventHandler(this.frmZahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zahtjeviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZAHTJEVI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource zahtjeviBindingSource;
        private TransportDataSetTableAdapters.ZahtjeviTableAdapter zahtjeviTableAdapter;
        private TransportDataSet transportDataSet1;
        private System.Windows.Forms.BindingSource transportDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dgvZAHTJEVI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaUtovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn LokacijaIstovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumTransporta;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaRobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.Button btnIspisNaloga;
    }
}