using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PCBox_App
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnHasiSaioa_Click(object sender, EventArgs e)
        {
            if (this.txtErabiltzailea.Text.Equals(""))
            {
                MessageBox.Show("Sar ezazu erabiltzailea jarraitzeko.", "Kontuz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.txtPasahitza.Text.Equals(""))
            {
                MessageBox.Show("Sar ezazu pasahitza jarraitzeko.", "Kontuz!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Erabiltzaileak> erabiltzaileZerrenda = new Erabiltzaileak().getErabiltzaileak();
            int i = 0;
            Boolean zuzena = false;
            while (i < erabiltzaileZerrenda.Count && zuzena == false)
            {
                if (erabiltzaileZerrenda[i].erabiltzailea.Equals(this.txtErabiltzailea.Text.Trim()) && erabiltzaileZerrenda[i].pasahitza.Equals(this.txtPasahitza.Text.Trim()))
                {
                    zuzena = true;
                }
                i++;
            }
            if (!zuzena){
                MessageBox.Show("Erabiltzailea edo Pasahitza ez da zuzena.", "Kontuz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtErabiltzailea.Text = "";
                this.txtPasahitza.Text = "";
                return;
            }
            frmHome _frmHome = new frmHome();
            _frmHome.lblErabiltzailea.Text = this.txtErabiltzailea.Text;
            _frmHome.Show();
        }
    }
}
