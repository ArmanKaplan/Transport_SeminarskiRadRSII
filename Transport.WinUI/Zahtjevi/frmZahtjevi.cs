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

namespace Transport.WinUI.Zahtjevi
{
    public partial class frmZahtjevi : Form
    {
        private readonly APIService _zahtjevi = new APIService("Zahtjevi");
        public frmZahtjevi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vrijednost = comboBox1.SelectedIndex;
            if(int.TryParse(vrijednost.ToString(),out int odg)){
                await LoadZahtjevi(odg);
            }
        }


    
        private async Task LoadZahtjevi(int odgovoren)
        {
            var result = await _zahtjevi.Get<List<Model.Zahtjevi>>(new ZahtjeviSearchRequest() {
            Obradjen=odgovoren
            });
            dgvZAHTJEVI.AutoGenerateColumns = false;
            dgvZAHTJEVI.DataSource = result;
        }

        private void frmZahtjevi_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zahtjeviTableAdapter.FillBy(this.transportDataSet.Zahtjevi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void kkToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zahtjeviTableAdapter.kk(this.transportDataSet.Zahtjevi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zahtjeviTableAdapter.FillBy1(this.transportDataSet.Zahtjevi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zahtjeviTableAdapter.FillBy2(this.transportDataSet.Zahtjevi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvZAHTJEVI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvZAHTJEVI_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
       
            if (dgvZAHTJEVI.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite upit!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          else  if (comboBox1.SelectedItem == "Obrađeni zahtjevi")
            {
                MessageBox.Show("Nije moguće odgovoriti na obrađeni zahtjev!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvZAHTJEVI.SelectedRows[0].DataBoundItem;

                frmOdgovor frm = new frmOdgovor(item as Model.Zahtjevi);
                frm.ShowDialog();

            }
        }
    }
}
