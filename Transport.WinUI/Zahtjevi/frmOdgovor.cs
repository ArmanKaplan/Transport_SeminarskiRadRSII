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
    public partial class frmOdgovor : Form
    {
        private readonly APIService _vozaci = new APIService("Vozaci");
        private readonly APIService voznje = new APIService("Voznje");
        private readonly APIService zahtjev = new APIService("Zahtjevi");
        private Model.Zahtjevi _zahtjev = null;
        public frmOdgovor(Model.Zahtjevi zahtjev)
        {
            InitializeComponent();
            _zahtjev = zahtjev;
        }
        private async Task LoadVozaci()
        {
            var result = await _vozaci.Get<List<Model.Vozaci>>(null);
            result.Insert(0, new Model.Vozaci());
          
            cmbVozac.DisplayMember = "ImeIPrezime";
            cmbVozac.ValueMember = "VozacID";
            cmbVozac.DataSource = result;
        }
        private async void frmOdgovor_Load(object sender, EventArgs e)
        {
            await LoadVozaci();

            lblLokIstovara.Text = _zahtjev.LokacijaIstovara;
            lblLokUtovara.Text = _zahtjev.LokacijaUtovara;
            lblDatumTransporta.Text = _zahtjev.Datum;
            lblVrstaRobe.Text = _zahtjev.VrstaRobe;
            if (_zahtjev.Uplaceno == true)
                lblUplaćeno.Text = "DA";
            else
                lblUplaćeno.Text = "NE";

            ZahtjeviOdgovorRequest request = new ZahtjeviOdgovorRequest()
            {
                LokacijaIstovara = _zahtjev.LokacijaIstovara,
                LokacijaUtovara = _zahtjev.LokacijaUtovara,
                DatumTransporta = _zahtjev.DatumTransporta,
                KlijentId = _zahtjev.KlijentId,
                Napomena = _zahtjev.Napomena,
                Obradjen = _zahtjev.Obradjen,
                TipRobeId = _zahtjev.TipRobeId,
                TipVozilaId = _zahtjev.TipVozilaId,
                VrstaRobe = _zahtjev.VrstaRobe,
                ZahtjevId = _zahtjev.ZahtjevId


            };

            var zathjevii = await zahtjev.Update<Model.Zahtjevi>(_zahtjev.ZahtjevId, request);


        }
        VoznjeInsertRequest request = new VoznjeInsertRequest();
        private async void button1_Click(object sender, EventArgs e)
        {
         
            var idObj = cmbVozac.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int VozacID))
            {
                request.VozacId = VozacID;
            }


            try
            {
                if (ValidateChildren())
                {
                    ZahtjeviOdgovorRequest requestO = new ZahtjeviOdgovorRequest()
                    {
                        LokacijaIstovara = _zahtjev.LokacijaIstovara,
                        LokacijaUtovara = _zahtjev.LokacijaUtovara,
                        DatumTransporta = _zahtjev.DatumTransporta,
                        KlijentId = _zahtjev.KlijentId,
                        Napomena = _zahtjev.Napomena,
                        Obradjen = true,
                        TipRobeId = _zahtjev.TipRobeId,
                        TipVozilaId = _zahtjev.TipVozilaId,
                        VrstaRobe = _zahtjev.VrstaRobe,
                        ZahtjevId = _zahtjev.ZahtjevId


                    };

                    var zathjevii = await zahtjev.Update<Model.Zahtjevi>(_zahtjev.ZahtjevId, requestO);

                    request.Zapoceto = false;
                    request.Zavrsen = false;
                    request.Odgovoren = true;
                    request.Prihvacen = true;
                    request.Ocijenjen = false;
                    request.Ocjena = null;
                    request.ZahtjevId = _zahtjev.ZahtjevId;
                    request.Cijena = Convert.ToInt32(txtCijena.Text);
                    request.Kilometraza = Convert.ToInt32(txtKilometraza.Text);
                    request.Napomena = rtbNapomena.Text;
                    

                    await voznje.Insert<Model.Voznje>(request);
                    MessageBox.Show("Zahtjev je prihvacen");
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Greska pri unosu");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ZahtjeviOdgovorRequest request = new ZahtjeviOdgovorRequest()
            {
                LokacijaIstovara = _zahtjev.LokacijaIstovara,
                LokacijaUtovara = _zahtjev.LokacijaUtovara,
                DatumTransporta = _zahtjev.DatumTransporta,
                KlijentId = _zahtjev.KlijentId,
                Napomena = _zahtjev.Napomena,
                Obradjen = true,
                TipRobeId = _zahtjev.TipRobeId,
                TipVozilaId = _zahtjev.TipVozilaId,
                VrstaRobe = _zahtjev.VrstaRobe,
                ZahtjevId = _zahtjev.ZahtjevId,
                Odbijen = true


            };
            var zathjevii = await zahtjev.Update<Model.Zahtjevi>(_zahtjev.ZahtjevId, request);
            MessageBox.Show("Zahtjev je odbijen");
            this.Close();

        }

        private void txtCijena_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                errorProvider1.SetError(txtCijena, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtCijena, null);
            }
        }

        private void txtKilometraza_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKilometraza.Text))
            {
                errorProvider1.SetError(txtKilometraza, "Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKilometraza, null);
            }
        }
        private void cmbVozac_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.Clear();
            if (cmbVozac.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbVozac, "Obavezno odabrati vozača!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

       
    }
    }

