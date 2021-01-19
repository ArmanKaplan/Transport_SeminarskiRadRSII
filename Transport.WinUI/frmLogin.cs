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

namespace Transport.WinUI
{
    public partial class frmLogin : Form
    {
        APIService _administratori = new APIService("Administratori");
        public frmLogin()
        {
            InitializeComponent();
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKorisnickoIme.Text.Length <= 0|| txtLozinka.Text.Length <= 0) 
                    throw new Exception("Unesite korisnicko ime i lozinku");
                //await _administratori.Get<dynamic>(null);

                APIService.Username = txtKorisnickoIme.Text;
                APIService.Password = txtLozinka.Text;

                var request = new LoginSearchRequest()
                {
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };

                var korisnik = await _administratori.Get<List<Model.Administratori>>(request);

                if(korisnik.Count != 0)
                {
                    foreach (var item in korisnik)
                    {
                        if (item != null)
                        {
                            DialogResult = DialogResult.OK;
                            APIService.LogovaniAdministrator = item;
                        }
                    }
                }
                else
                {

                    throw new Exception();
                }

               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška u prijavi", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

     
    }
}
