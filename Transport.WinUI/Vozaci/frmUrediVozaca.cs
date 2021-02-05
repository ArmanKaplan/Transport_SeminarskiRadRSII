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

namespace Transport.WinUI.Vozaci
{
    public partial class frmUrediVozaca : Form
    {
        public readonly Model.Vozaci _vozaci;
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _gradovi = new APIService("Gradovi");
        private readonly APIService _Vozaci = new APIService("Vozaci");
        public frmUrediVozaca(Model.Vozaci vozaci)
        {
            InitializeComponent();
            _vozaci = vozaci;
        }
        private async Task LoadVozila()
        {
            var result = await _vozila.Get<List<Model.Vozila>>(null);
         
            cmbVozila.DisplayMember = "VoziloMarka";
            cmbVozila.ValueMember = "VoziloId";
            cmbVozila.DataSource = result;
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;
        }

        private async void frmUrediVozaca_Load(object sender, EventArgs e)
        {
            await LoadVozila();
            await LoadGradovi();
            txtAdresa.Text = _vozaci.Adresa;
            txtGodineIskustva.Text = _vozaci.GodineIskustva.ToString();
            txtJMBG.Text = _vozaci.Jmbg;
            txtMjestoRodjenja.Text = _vozaci.MjestoRodjenja;
            txtIme.Text = _vozaci.Ime;
            txtKorisnickoIme.Text = _vozaci.KorisnickoIme;
            txtPrezime.Text = _vozaci.Prezime;
            cmbVozila.SelectedValue = _vozaci.VoziloID;
            cmbGradovi.SelectedValue = _vozaci.GradID;


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    VozaciUpdateRequest request = new VozaciUpdateRequest();

                    var idObj = cmbVozila.SelectedValue;

                    if (int.TryParse(idObj.ToString(), out int VozilaID))
                    {
                        request.VoziloID = VozilaID;
                    }
                
                    var jedMjereIdObj = cmbGradovi.SelectedValue;

                    if (int.TryParse(jedMjereIdObj.ToString(), out int GradID))
                    {
                        request.GradID = GradID;
                    }
          
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.KorisnickoIme = txtKorisnickoIme.Text;
                    request.MjestoRodjenja = txtMjestoRodjenja.Text;
                    request.Jmbg = txtJMBG.Text;
                    request.Adresa = txtAdresa.Text;
                    request.GodineIskustva = Convert.ToInt32(txtGodineIskustva.Text);
 
                    await _Vozaci.Update<Model.Vozaci>(_vozaci.VozacID, request);

                    MessageBox.Show("Vozac uspješno uređen!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtJMBG.Text))
            {
                errorProvider1.SetError(txtJMBG, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtJMBG, null);
            }
        }

        private void txtMjestoRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMjestoRodjenja.Text))
            {
                errorProvider1.SetError(txtMjestoRodjenja, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtMjestoRodjenja, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }


        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text) || txtKorisnickoIme.Text.Length < 4)
            {
                errorProvider1.SetError(txtKorisnickoIme, "Minimalno 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

       

    }
}
