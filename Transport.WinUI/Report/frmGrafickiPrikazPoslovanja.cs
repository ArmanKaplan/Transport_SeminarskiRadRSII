using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.Model;
using Transport.WinUI;

namespace Transport.Report
{
    public partial class frmGrafickiPrikazPoslovanja : Form
    {
        private readonly APIService _voznje = new APIService("Voznje");



        public frmGrafickiPrikazPoslovanja()
        {
            InitializeComponent();
        }
        public List<Voznje> voznje = new List<Voznje>();
        private async void frmGrafickiPrikazPoslovanja_Load(object sender, EventArgs e)
        {
            var voznjee = await _voznje.Get<List<Model.Voznje>>(null);
            foreach (var v in voznjee)
            {
                voznje.Add(v);
            }

            ReportDataSource rds = new ReportDataSource("dsVoznje", voznje);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
