using Microsoft.AspNetCore.Mvc;
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
    public partial class frmDodajVozaci : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _gradovi = new APIService("Gradovi");
        private readonly APIService _vozaci = new APIService("Vozaci");
        private Model.Vozaci vozacii;
        public frmDodajVozaci(Model.Vozaci vozaci = null)
        {
            InitializeComponent();
            vozacii = vozaci;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private async void frmDodajVozaci_Load(object sender, EventArgs e)
        {
            await LoadVozila();
            await LoadGradovi();
            if (vozacii != null)
            {
            txtIme.Text=vozacii.Ime;
             txtPrezime.Text=vozacii.Prezime;
                txtMjestoRodjenja.Text=vozacii.MjestoRodjenja;
                 txtJMBG.Text=vozacii.Jmbg;
               txtAdresa.Text=vozacii.Adresa;
               
               txtKorisnickoIme.Text=vozacii.KorisnickoIme;

            }
        }
        private async Task LoadVozila()
        {
            var result = await _vozila.Get<List<Model.Vozila>>(null);
            result.Insert(0, new Model.Vozila());
            cmbVozila.DisplayMember = "Marka";
            cmbVozila.ValueMember = "VoziloId";
            cmbVozila.DataSource = result;
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;
        }

        VozaciInsertRequest request = new VozaciInsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                if (ValidateChildren())
                {
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.MjestoRodjenja = txtMjestoRodjenja.Text;
                    request.Jmbg = txtJMBG.Text;
                    request.Adresa = txtAdresa.Text;
                    request.Password = txtPassword.Text;
                    request.PasswordPotvrda = txtPasswordPotvrda.Text;
                    request.KorisnickoIme = txtKorisnickoIme.Text;
                    request.GodineIskustva = Convert.ToInt32(txtGodineIskustva.Text);
                    await _vozaci.Insert<Model.Vozaci>(request);
                    MessageBox.Show("Novi vozač uspjesno dodan!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
            }

        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void txtGodineIskustva_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodineIskustva.Text))
            {
                errorProvider1.SetError(txtGodineIskustva, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGodineIskustva, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKorisnickoIme.Text)||txtKorisnickoIme.Text.Length<4)
            {
                errorProvider1.SetError(txtKorisnickoIme, "Minimalno 4 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text)||txtPassword.Text.Length<6)
            {
                errorProvider1.SetError(txtPassword, "Minimalno 6 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordPotvrda.Text)||txtPasswordPotvrda.Text.Length<6)
            {
                errorProvider1.SetError(txtPasswordPotvrda, "Minimalno 6 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPasswordPotvrda, null);
            }
        }

        private void cmbVozila_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (cmbVozila.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbVozila, "Obavezno odabrati vozilo!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cmbGradovi_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (cmbGradovi.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbGradovi, "Obavezno odabrati grad!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
