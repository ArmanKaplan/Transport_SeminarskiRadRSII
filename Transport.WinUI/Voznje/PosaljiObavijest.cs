using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.Model;

namespace Transport.WinUI.Voznje
{
    public partial class PosaljiObavijest : Form
    {
        private readonly APIService _voznje = new APIService("Voznje");
        private readonly APIService _obavijesti= new APIService("Obavijesti");
        private Model.Voznje voznjee;

        public PosaljiObavijest(Model.Voznje voznje)
        {
            InitializeComponent();
            voznjee = voznje;
        }

     

        private void PosaljiObavijest_Load(object sender, EventArgs e)
        {
            label1.Text = "Posaljite obavijest odabranoj vožnji";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {

                    ObavijestiPosaljiRequest request = new ObavijestiPosaljiRequest()
                    {
                        Tekst = txtObavijesti.Text,
                        Datum = DateTime.Now,
                        VoznjaId = voznjee.VoznjaId
                    };

                    var obavijesti = await _obavijesti.Insert<Obavijesti>(request);
                    MessageBox.Show("Obavjest uspješno poslana!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
            }
        }

        private void txtObavijesti_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtObavijesti.Text))
            {
                errorProvider1.SetError(txtObavijesti, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtObavijesti, null);
            }
        }
    }
}
