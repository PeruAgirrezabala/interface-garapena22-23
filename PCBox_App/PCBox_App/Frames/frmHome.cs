using PCBox_App.Frames;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBox_App
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnProduktuSalduenak_Click(object sender, EventArgs e)
        {
            frmProduktuSalduenak _frmProduktuSalduenak = new frmProduktuSalduenak();
            _frmProduktuSalduenak.lblErabiltzailea.Text = this.lblErabiltzailea.Text;
            _frmProduktuSalduenak.ShowDialog();
        }

        private void btnKatalogoa_Click(object sender, EventArgs e)
        {
            frmKatalogoa _frmKatalogoa = new frmKatalogoa();
            _frmKatalogoa.lblErabiltzailea.Text = this.lblErabiltzailea.Text;
            _frmKatalogoa.ShowDialog();
        }
    }
}
