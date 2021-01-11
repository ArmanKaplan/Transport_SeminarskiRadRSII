namespace Transport.WinUI.Voznje
{
    partial class frmKvarovi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKvarovi = new System.Windows.Forms.DataGridView();
            this.Lokacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioritetno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKvarovi
            // 
            this.dgvKvarovi.AllowUserToAddRows = false;
            this.dgvKvarovi.AllowUserToDeleteRows = false;
            this.dgvKvarovi.AllowUserToResizeColumns = false;
            this.dgvKvarovi.AllowUserToResizeRows = false;
            this.dgvKvarovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKvarovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKvarovi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKvarovi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKvarovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKvarovi.ColumnHeadersHeight = 50;
            this.dgvKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKvarovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lokacija,
            this.Opis,
            this.Prioritetno});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKvarovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKvarovi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKvarovi.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKvarovi.Location = new System.Drawing.Point(0, 0);
            this.dgvKvarovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKvarovi.Name = "dgvKvarovi";
            this.dgvKvarovi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(40)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKvarovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKvarovi.RowHeadersVisible = false;
            this.dgvKvarovi.RowHeadersWidth = 62;
            this.dgvKvarovi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvKvarovi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKvarovi.RowTemplate.Height = 28;
            this.dgvKvarovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKvarovi.Size = new System.Drawing.Size(722, 324);
            this.dgvKvarovi.TabIndex = 14;
            // 
            // Lokacija
            // 
            this.Lokacija.DataPropertyName = "Lokacija";
            this.Lokacija.HeaderText = "Lokacija";
            this.Lokacija.Name = "Lokacija";
            this.Lokacija.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Prioritetno
            // 
            this.Prioritetno.DataPropertyName = "Prioritetno";
            this.Prioritetno.HeaderText = "Prioritetno";
            this.Prioritetno.Name = "Prioritetno";
            this.Prioritetno.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(722, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Lociraj vozilo u kvaru";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKvarovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvKvarovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKvarovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kvarovi";
            this.Load += new System.EventHandler(this.frmKvarovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKvarovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKvarovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioritetno;
        private System.Windows.Forms.Button button1;
    }
}