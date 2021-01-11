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
using Flurl.Http;
namespace Transport.WinUI.Vozaci
{
    public partial class frmVozaci : Form
    {
        private readonly APIService _apiService = new APIService("Vozaci");
        public frmVozaci()
        {
            InitializeComponent();
        }



    

        private void dgvVozaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvVozaci.SelectedRows[0].DataBoundItem;

            //
            frmDodajVozaci frm = new frmDodajVozaci(item as Model.Vozaci);
            frm.ShowDialog();
        }


       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frmDodajVozaci frm = new frmDodajVozaci();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVozaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVozaci.SelectedRows[0].DataBoundItem;

                //
                frmUrediVozaca frm = new frmUrediVozaca(item as Model.Vozaci);
                    frm.ShowDialog();
            }
           
        }

        private void dgvVozaci_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVozaci.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite vozača!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVozaci.SelectedRows[0].DataBoundItem;

                //
                frmUrediVozaca frm = new frmUrediVozaca(item as Model.Vozaci);
                frm.ShowDialog();
            }
        }

        private async void frmVozaci_Load(object sender, EventArgs e)
        {
           
            var result = await _apiService.Get<List<Model.Vozaci>>(null);
            dgvVozaci.AutoGenerateColumns = false;
            dgvVozaci.DataSource = result;
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new VozaciSearchRequest()
            {
                Ime = txtPretraga.Text,
                Prezime=txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Vozaci>>(search);
            dgvVozaci.AutoGenerateColumns = false;
            dgvVozaci.DataSource = result;
        }
    }
}
