using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.Report;
using Transport.WinUI.Korisnici;
using Transport.WinUI.Vozaci;
using Transport.WinUI.Vozila;
using Transport.WinUI.Voznje;
using Transport.WinUI.Zahtjevi;

namespace Transport.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
            custmizeDesing();
        }
        private void custmizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
            if (panel2.Visible == true)
                panel2.Visible = false;
            if (panel3.Visible == true)
                panel3.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonZahtijevi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmZahtjevi());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVozila());
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmVozilaDodaj frm = new frmVozilaDodaj();
            frm.Show();
            hideSubMenu();
        }

        private void buttonVozaci_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVozaci());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDodajVozaci frm = new frmDodajVozaci();
            frm.Show();
            hideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            lblAdministrator.Text = APIService.LogovaniAdministrator.KorisnickoIme;
            timer1.Start();
            Datum.Text = DateTime.Now.ToLongDateString();
            Vrijeme.Text = DateTime.Now.ToLongTimeString();
        }
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Vrijeme.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAktivnevoznje_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVoznje());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(panel3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Korisnici_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKorisnici());
            hideSubMenu();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.Show();
            hideSubMenu();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmGrafickiPrikazPoslovanja frm = new frmGrafickiPrikazPoslovanja();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // REFRESH UI
                this.Show();
            }
            else
            {
                Application.Exit();
            }
           
        }
    }
}
