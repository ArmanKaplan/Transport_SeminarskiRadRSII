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

namespace Transport.WinUI.Korisnici
{
    public partial class frmDodajKorisnika : Form
    {
        private readonly APIService _gradovi = new APIService("Gradovi");
        private readonly APIService _klijenti = new APIService("Klijenti");
        public frmDodajKorisnika()
        {
            InitializeComponent();
        }

        private void cmbGradovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        KlijentiInsertRequest request = new KlijentiInsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
            var idObj = cmbGradovi.SelectedValue;
            
            if (int.TryParse(idObj.ToString(), out int GradID))
            {
                request.GradId = GradID;
            }
            try
            {

                if (ValidateChildren())
                {
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.Email = txtEmail.Text;
                    request.Firma = txtFirma.Text;
                    request.Telefon = txtTelefon.Text;
                    request.Password = txtPassword.Text;
                    request.PasswordPotvrda = txtPasswordPotvrda.Text;
                    request.KorisnickoIme = txtKorisnickoIme.Text;

                    await _klijenti.Insert<Model.Klijenti>(request);
                    MessageBox.Show("Korisnik uspijesno dodan!");
                    this.Close();
                }
            }
            catch(Exception) {
                MessageBox.Show("Greška", "Neispravan unos!");
            }
         
            
        }
        private async Task LoadGradovi()
        {
            var result = await _gradovi.Get<List<Model.Gradovi>>(null);
            result.Insert(0, new Model.Gradovi());
            cmbGradovi.DisplayMember = "Naziv";
            cmbGradovi.ValueMember = "GradId";
            cmbGradovi.DataSource = result;
        }

        private async void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
           await LoadGradovi();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtIme.Text)){
                errorProvider1.SetError(txtIme, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme,null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
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
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text.Length < 6)
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
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtPasswordPotvrda.Text) || txtPasswordPotvrda.Text.Length < 6)
            {
                errorProvider1.SetError(txtPasswordPotvrda, "Minimalno 6 karaktera");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPasswordPotvrda, null);
            }
       
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirma_Validating(object sender, CancelEventArgs e)
        {

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
