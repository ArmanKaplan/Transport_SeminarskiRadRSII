using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.Model;

namespace Transport.WinUI.Voznje
{
    public partial class frmLociranje : Form
    {
        private readonly APIService _lociranja = new APIService("Lociranja");
        private readonly Model.Voznje Voznje = null;
        public frmLociranje(Model.Voznje voznje)
        {
            InitializeComponent();
            Voznje = voznje;
        }

        private async void frmLociranje_Load(object sender, EventArgs e)
        {






            var result = await _lociranja.Get<List<Model.Lociranja>>(null);
            foreach (var loc in result)
            {
                if (loc.VoznjaId == Voznje.VoznjaId && loc.Prihvaceno == false && loc.Odogovoreno == false&&loc.AdministratorId!=null)
                {
                    label1.Visible = true;
                    gMap.Visible = false;
                    button1.Visible = false;
                    //MessageBox.Show("Vozač jos uvijek nije prihvatio zathjev!");
                    //return;
                }
                else if (loc.Prihvaceno == true && loc.Odogovoreno == true && loc.VoznjaId == Voznje.VoznjaId&&loc.AdministratorId!=null)
                {

                    gMap.MapProvider = GMapProviders.GoogleMap;
                    double lat = /*Convert.ToDouble(loc.Lat);*/double.Parse(loc.Lat.Replace(',', '.'), CultureInfo.InvariantCulture);
                    double longt = /*Convert.ToDouble(loc.Lng);*/double.Parse(loc.Lng.Replace(',', '.'), CultureInfo.InvariantCulture);

                    PointLatLng point = new PointLatLng(lat, longt);
                    gMap.ShowCenter = false;
                    gMap.MinZoom = 10;
                    gMap.MaxZoom = 100;
                    gMap.Zoom = 18;
                    gMap.Overlays.Clear();
                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/icon.png");


                    GMapMarker marker = new GMarkerGoogle(point, bmpMarker);

                    GMapOverlay markers = new GMapOverlay("markers");

                    markers.Markers.Add(marker);

                    gMap.Overlays.Add(markers);
                    gMap.Position = point;

                    gMap.Visible = true;
                    label1.Hide();
                    button1.Visible = true;

                }
                else if (loc.Prihvaceno == false && loc.Odogovoreno == true && loc.VoznjaId == Voznje.VoznjaId&&loc.AdministratorId!=null)
                {
                    gMap.Visible=false;
                    label1.Visible=true;
                    label1.Text = "               Vozač je odbio vaš posljednji zathjev";
                    button1.Visible = true;

                }



                }
            


        }

        private void gMap_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LociranjaInsertRequest request = new LociranjaInsertRequest()
            {
                Lat = "string",
                Lng = "string",
                Odogovoreno = false,
                Prihvaceno = false,
                AdministratorId = APIService.LogovaniAdministrator.AdministratorId,
                KlijentId = null,
                VoznjaId = Voznje.VoznjaId
            };
            gMap.Visible = false;
            label1.Text = "Vozač jos uvijek nije prihvatio zahtjev za lociranjem!";
            label1.Visible = true;
            button1.Visible = false;
            var obavijesti = await _lociranja.Insert<Lociranja>(request);
            MessageBox.Show("Zahtjev za lociranjem poslat!");

        }
    }

}
