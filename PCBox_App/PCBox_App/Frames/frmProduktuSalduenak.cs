using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PCBox_App
{
    public partial class frmProduktuSalduenak : Form
    {
        public frmProduktuSalduenak()
        {
            InitializeComponent();
        }

        private void frmProduktuSalduenak_Load(object sender, EventArgs e)
        {
            using (var db = new DBContext())
            {
                var Data = db.Salmenta
               .Include("Salmenta")
                .GroupBy(b => b.Produktua)
                .ToDictionary(g => g.Key, g => g.Count());

                if (Data != null)
                {
                    if (Data.Count > 0)
                    {
                        var kontrolak = this.gProduktuSalduenak1.Controls.OfType<Chart>(); foreach (var kontrola in kontrolak)
                        {
                            kontrola.DataSource = Data;
                            kontrola.Series[0].YValueMembers = "Value";
                            kontrola.Series[0].XValueMember = "Key";
                            kontrola.DataBind();
                        }
                    }
                }

            }
        }

        private void gProduktuSalduenak1_Load(object sender, EventArgs e)
        {

        }
    }
}
