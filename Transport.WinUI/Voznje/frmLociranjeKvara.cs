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
    public partial class frmLociranjeKvara : Form
    {
        private readonly APIService _kvarovi = new APIService("Kvarovi");
        private readonly Model.Kvarovi Kvar = null;
        public frmLociranjeKvara(Kvarovi kvarovi)
        {
            InitializeComponent();
            Kvar = kvarovi;
        }

     

        private void frmLociranjeKvara_Load(object sender, EventArgs e)
        {
            

                    gMap.MapProvider = GMapProviders.GoogleMap;
                    double lat = /*Convert.ToDouble(loc.Lat);*/double.Parse(Kvar.Lat.Replace(',', '.'), CultureInfo.InvariantCulture);
                    double longt = /*Convert.ToDouble(loc.Lng);*/double.Parse(Kvar.Lng.Replace(',', '.'), CultureInfo.InvariantCulture);

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

               
                }
    }

     
    }

