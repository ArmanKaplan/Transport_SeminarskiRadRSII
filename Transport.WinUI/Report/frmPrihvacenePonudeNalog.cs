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
    public partial class frmPrihvacenePonudeNalog : Form
    {
        private readonly APIService _voznje = new APIService("Voznje");

        private readonly APIService _vozac = new APIService("Vozaci");



        public frmPrihvacenePonudeNalog()
        {
            InitializeComponent();
        }
        public Zahtjevi zahtjevi{get;set;}
       public Voznje Voznje { get; set; }
        public Vozaci Vozac { get; set; }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void frmPrihvacenePonudeNalog_Load(object sender, EventArgs e)
        {
            var voznje = await _voznje.Get<List<Model.Voznje>>(null);
            var vozaci = await _vozac.Get<List<Model.Vozaci>>(null);
         
            foreach (var v in voznje )
            {
                if (v.ZahtjevId == zahtjevi.ZahtjevId)
                {
                    Voznje = v;
                }
            }
            foreach (var vo in vozaci)
            {
                if (vo.VozacID == Voznje.VozacId)
                {
                    Vozac = vo;
                }
            }

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Vozac", Voznje.Vozac.ImeIPrezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Klijent", zahtjevi.Klijent.Ime+" "+ zahtjevi.Klijent.Prezime));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("LokacijaUtovara", zahtjevi.LokacijaUtovara));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("LokacijaIstovara", zahtjevi.LokacijaIstovara));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cijena", Voznje.Cijena.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Kilometraza", Voznje.Kilometraza.ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VrstaRobe", zahtjevi.VrstaRobe));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Datum", zahtjevi.Datum));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VoziloMarka", Vozac.Vozilo.Marka+" "+Vozac.Vozilo.Model));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("VoziloRegistracije", Vozac.Vozilo.RegistracijskeOznake));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("NazivFirme", zahtjevi.Klijent.Firma));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Napomena", zahtjevi.Napomena));
            this.reportViewer1.RefreshReport();
        }
    }
}
