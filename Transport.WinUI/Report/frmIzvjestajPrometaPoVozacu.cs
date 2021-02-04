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
    public partial class frmIzvjestajPrometaPoVozacu : Form
    {
        private readonly APIService _voznje = new APIService("Voznje");
        public frmIzvjestajPrometaPoVozacu()
        {
            InitializeComponent();
        }
        public Vozaci Vozac { get; set; }
       public List<Voznje> voznje = new List<Voznje>();
        public float? ProsjecnaOcjena = 0;
        public decimal UkupnaCijena = 0;
        public int UkupanBrojKilometara = 0;
        public int BrojTransporta = 0;
        public int BrojTransportaPO = 0;
        public int? sum = 0;

        private async void frmIzvjestajPrometaPoVozacu_Load(object sender, EventArgs e)
        {
            var voznjee = await _voznje.Get<List<Model.Voznje>>(null);
            

            foreach (var v in voznjee)
            {
                if (v.VozacId == Vozac.VozacID&&v.Zavrsen==true)
                {
                    sum += v.Ocjena;
                    BrojTransporta++;
                    UkupnaCijena += v.Cijena;
                    UkupanBrojKilometara += v.Kilometraza;
                    if(v.Ocijenjen==true)
                    BrojTransportaPO++;
                }
            }
            if (BrojTransportaPO != 0||sum!=0)
                ProsjecnaOcjena = sum / BrojTransportaPO;
            else
                ProsjecnaOcjena = 0;
            this.reportViewer3.LocalReport.SetParameters(new ReportParameter("Vozac", Vozac.ImeIPrezime));
            this.reportViewer3.LocalReport.SetParameters(new ReportParameter("ProsjecnaOcjena", ProsjecnaOcjena.ToString()));
            this.reportViewer3.LocalReport.SetParameters(new ReportParameter("UkupnaCijena", UkupnaCijena.ToString()));
            this.reportViewer3.LocalReport.SetParameters(new ReportParameter("UkupnaKilometraza", UkupanBrojKilometara.ToString()));
            this.reportViewer3.LocalReport.SetParameters(new ReportParameter("BrojTransporta", BrojTransporta.ToString()));
            this.reportViewer3.RefreshReport();
        }
    }
}
