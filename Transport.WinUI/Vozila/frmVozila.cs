using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport.WinUI.Vozila
{
    public partial class frmVozila : Form
    {
        private readonly APIService _apiService = new APIService("Vozila");
        public frmVozila()
        {
            InitializeComponent();
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            frmVozilaDodaj frm = new frmVozilaDodaj();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite vozilo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVozila.SelectedRows[0].DataBoundItem;

                //
                frmUrediVozilo frm = new frmUrediVozilo(item as Model.Vozila);
                frm.ShowDialog();
            }
        }

        private void dgvVozila_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite vozilo!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVozila.SelectedRows[0].DataBoundItem;

                //
                frmUrediVozilo frm = new frmUrediVozilo(item as Model.Vozila);
                frm.ShowDialog();
            }
        }

        private async void frmVozila_Load(object sender, EventArgs e)
        {
            
            var result = await _apiService.Get<List<Model.Vozila>>(null);
            dgvVozila.AutoGenerateColumns = false;
            dgvVozila.DataSource = result;
        }

        private async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new Model.VozilaSearchRequest()
            {
                RegistracijskeOznake = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Vozila>>(search);
            dgvVozila.AutoGenerateColumns = false;
            dgvVozila.DataSource = result;
        }
    }
}
