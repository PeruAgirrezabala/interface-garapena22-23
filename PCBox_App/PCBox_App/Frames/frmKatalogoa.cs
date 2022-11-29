using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBox_App.Frames
{
    public partial class frmKatalogoa : Form
    {
        public frmKatalogoa()
        {
            InitializeComponent();
        }

        private void frmKatalogoa_Load(object sender, EventArgs e)
        {
            Produktuak produktuak = new Produktuak();
            gridaBete(produktuak);
        }

        private void gridaBete(Produktuak produktuak)
        {
            DataSet dsProduktuak = produktuak.produktuakLortuDS();
            dgProduktuak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProduktuak.DataSource = dsProduktuak.Tables[0];
        }
    }
}
