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
    public partial class frmUrediVozilo : Form
    {
        private readonly APIService _Vozila = new APIService("Vozila");

        private readonly Model.Vozila _vozila;
        public frmUrediVozilo(Model.Vozila vozila)
        {
            InitializeComponent();
            _vozila = vozila;
        }

        private void frmUrediVozilo_Load(object sender, EventArgs e)
        {
            txtBoja.Text = _vozila.Boja;
            txtGodinaProizvodnje.Text = _vozila.GodinaProizvodnje.ToString();
            txtKilovati.Text = _vozila.Kilovati.ToString();
            txtMarka.Text = _vozila.Marka;
            txtModel.Text = _vozila.Model;
            txtRegOzn.Text = _vozila.RegistracijskeOznake;
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateChildren())
                {
                    var request = new VozilaUpdateRequest()
                    {
                        Boja = txtBoja.Text,
                        GodinaProizvodnje = Convert.ToInt32(txtGodinaProizvodnje.Text),
                        Kilovati = Convert.ToInt32(txtKilovati.Text),
                        Marka = txtMarka.Text,
                        Model = txtModel.Text,
                        RegistracijskeOznake = txtModel.Text



                    };

                    await _Vozila.Update<Model.Vozila>(_vozila.VoziloId, request);

                    MessageBox.Show("Korisnik uspješno uređen!");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greška", "Neispravan unos!");
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

