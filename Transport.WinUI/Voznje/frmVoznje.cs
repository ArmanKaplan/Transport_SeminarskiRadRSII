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

namespace Transport.WinUI.Voznje
{
    public partial class frmVoznje : Form
    {
        private readonly APIService _voznje = new APIService("Voznje");
        public frmVoznje()
        {
            InitializeComponent();
        }
        private async Task LoadVoznje(int zavrseno)
        {
            
            dgvVoznje.AutoGenerateColumns = false;
            
            var result = await _voznje.Get<List<Model.Voznje>>(new VoznjeSearchRequest()
            {
                Zavrsen = zavrseno,
               
            });
            dgvVoznje.DataSource = result;
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var vrijednost = comboBox1.SelectedIndex;
            if (int.TryParse(vrijednost.ToString(), out int odg))
            {
                await LoadVoznje(odg);
            }
        }

      

        private void frmVoznje_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dgvVoznje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite upit!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVoznje.SelectedRows[0].DataBoundItem;

                PosaljiObavijest frm = new PosaljiObavijest(item as Model.Voznje);
                frm.ShowDialog();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvVoznje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite upit!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVoznje.SelectedRows[0].DataBoundItem;

                frmKvarovi frm = new frmKvarovi(item as Model.Voznje);
                frm.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (dgvVoznje.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite upit!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBox1.SelectedItem=="Zavrsene voznje")
            {
                MessageBox.Show("Nije moguće locirati završenu vožnju!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvVoznje.SelectedRows[0].DataBoundItem;

                frmLociranje frm = new frmLociranje(item as Model.Voznje);
                frm.ShowDialog();

            }
            
        }

    

        private void dgvVoznje_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var Grid = sender as DataGridView;
            DataGridViewColumn column = Grid.Columns[e.ColumnIndex];
            if (column.DataPropertyName.Contains("."))
            {
                object data = Grid.Rows[e.RowIndex].DataBoundItem;
                string[] properties = column.DataPropertyName.Split('.');
                for (int i = 0; i < properties.Length && data != null; i++)
                    data = data.GetType().GetProperty(properties[i]).GetValue(data);
                Grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = data;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
