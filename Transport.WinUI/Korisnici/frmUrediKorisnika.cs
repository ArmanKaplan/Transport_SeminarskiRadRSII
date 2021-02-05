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
    public partial class frmUrediKorisnika : Form
    {
        private readonly APIService _korisnici = new APIService("Klijenti");
        private Model.Klijenti _klijenti;
        public frmUrediKorisnika(Klijenti klijenti)
        {
            InitializeComponent();
            _klijenti = klijenti;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var request = new KlijentiUpdateRequest()
                    {
                        Email = txtEmail.Text,
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Telefon = txtTelefon.Text,
                        Firma=txtFirma.Text
                        
               
                    };


                    await _korisnici.Update<Model.Klijenti>(_klijenti.KlijentId, request);

                    MessageBox.Show("Korisnik uspješno uređen!");
                    this.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
            }
        }



     



        private void frmUrediKorisnika_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = _klijenti.KorisnickoIme;
            txtIme.Text = _klijenti.Ime;
            txtPrezime.Text = _klijenti.Prezime;
            txtTelefon.Text = _klijenti.Telefon;
            txtFirma.Text = _klijenti.Firma;
            txtEmail.Text = _klijenti.Email;
            
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
         
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
