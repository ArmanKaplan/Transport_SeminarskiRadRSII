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
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Klijenti");
        public frmKorisnici()
        {
            InitializeComponent();
        }

      
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvKorisnici.SelectedRows[0].DataBoundItem;

                //
                frmUrediKorisnika frm = new frmUrediKorisnika(item as Klijenti);
                frm.ShowDialog();
            }
        }

        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKorisnici.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvKorisnici.SelectedRows[0].DataBoundItem;

                //
                frmUrediKorisnika frm = new frmUrediKorisnika(item as Klijenti);
                frm.ShowDialog();
            }
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KlijentiSearchRequest()
            {
                Ime = txtPretraga.Text,
             Prezime=txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Klijenti>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Klijenti>>(null);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
         
        }
    }
}
