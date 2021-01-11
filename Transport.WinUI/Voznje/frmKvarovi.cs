using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport.WinUI.Voznje
{
    public partial class frmKvarovi : Form
    {
        private readonly APIService _kvarovi = new APIService("Kvarovi");
        private readonly APIService _voznje = new APIService("Voznje");
        private Model.Voznje voznjee;
        public frmKvarovi(Model.Voznje voznje)
        {
            InitializeComponent();
            voznjee = voznje;

        }

        private async void frmKvarovi_Load(object sender, EventArgs e)
        {

            var search = new Model.KvaroviSearchRequest()
            {
                VoznjaID = voznjee.VoznjaId
            };
            var result = await _kvarovi.Get<List<Model.Kvarovi>>(search);
            dgvKvarovi.AutoGenerateColumns = false;

            dgvKvarovi.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvKvarovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite upit!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var item = dgvKvarovi.SelectedRows[0].DataBoundItem;

                frmLociranjeKvara frm = new frmLociranjeKvara(item as Model.Kvarovi);
                frm.ShowDialog();

            }
        }
    }
}
