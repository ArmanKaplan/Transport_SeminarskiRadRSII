namespace Transport.Report
{
    partial class frmPrihvacenePonudeNalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Transport.WinUI.Report.PrihvacenePonudeNalog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(638, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmPrihvacenePonudeNalog
            // 
            this.ClientSize = new System.Drawing.Size(638, 521);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmPrihvacenePonudeNalog";
            this.Load += new System.EventHandler(this.frmPrihvacenePonudeNalog_Load);
            this.ResumeLayout(false);

        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
    
}
#endregion