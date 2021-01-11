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

namespace Transport.WinUI.Vozila
{
    public partial class frmVozilaDodaj : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _tipVozila = new APIService("TipVozila");
        private Model.Vozila vozila;
        public frmVozilaDodaj(Model.Vozila vozilaa=null)
        {
            InitializeComponent();
            vozila = vozilaa;
        }
        private async Task LoadTipVozila()
        {
            var result = await _tipVozila.Get<List<Model.TipVozila>>(null);
            result.Insert(0, new Model.TipVozila());
            cmbTipVozila.DisplayMember = "Naziv";
            cmbTipVozila.ValueMember = "TipVozilaId";
            cmbTipVozila.DataSource = result;
        }

        VozilaInsertRequest request = new VozilaInsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
            var idObj = cmbTipVozila.SelectedValue;
         
            if (int.TryParse(idObj.ToString(), out int TipVozilaID))
            {
                request.TipVozilaId = TipVozilaID;
            }
            try
            {
                if (ValidateChildren())
                {


                    request.Marka = txtMarka.Text;
                    request.Model = txtModel.Text;
                    request.RegistracijskeOznake = txtRegOzn.Text;
                    //request.Kilovati = txtKilovati;
                    //request.GodinaProizvodnje = txtGodinaProizvodnje;
                    request.Boja = txtBoja.Text;


                    await _vozila.Insert<Model.Vozila>(request);
                    MessageBox.Show("Novo vozilo uspjesno dodano!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
            }

        }

        private async void frmVozilaDodaj_LoadAsync(object sender, EventArgs e)
        {
            await LoadTipVozila();
            if (vozila != null)
            {
                txtMarka.Text = vozila.Marka;
                txtModel.Text = vozila.Model;
                txtRegOzn.Text = vozila.RegistracijskeOznake;
                txtBoja.Text = vozila.Boja;
            }
        }

        private void txtMarka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarka.Text))
            {
                errorProvider1.SetError(txtMarka, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMarka, null);
            }
        }

        private void txtModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtModel.Text))
            {
                errorProvider1.SetError(txtModel, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtModel, null);
            }
        }

        private void txtKilovati_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKilovati.Text))
            {
                errorProvider1.SetError(txtKilovati, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKilovati, null);
            }
        }

        private void txtBoja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoja.Text))
            {
                errorProvider1.SetError(txtBoja, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBoja, null);
            }
        }

        private void txtGodinaProizvodnje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodinaProizvodnje.Text))
            {
                errorProvider1.SetError(txtGodinaProizvodnje, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodinaProizvodnje, null);
            }
        }

        private void cmbTipVozila_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (cmbTipVozila.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbTipVozila, "Obavezno odabrati grad!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtRegOzn_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodinaProizvodnje.Text))
            {
                errorProvider1.SetError(txtGodinaProizvodnje, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodinaProizvodnje, null);
            }
        }
    }
    
}
