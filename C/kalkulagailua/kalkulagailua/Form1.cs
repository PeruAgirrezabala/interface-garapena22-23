namespace kalkulagailua
{
    public partial class Form1 : Form
    {
        Kalkulagailua kalkulagailua = new Kalkulagailua();
        public Form1()
        {
            InitializeComponent();
        }
        private Boolean Balioak()
        {
            Boolean ondo = true;
            try
            {
                kalkulagailua.Zenb1 = float.Parse(txtzenb1.Text);
                kalkulagailua.Zenb2 = float.Parse(txtzenb2.Text);
            }
            catch (Exception ex)
            {
                ondo = false;
                MessageBox.Show("Errorea gertatu da. " + ex.Message);
                Application.Exit();
            }
            return ondo;
        }
        private void Hasieratu()
        {
            txtzenb1.Text = "";
            txtzenb2.Text = "";
            txtzenb1.Focus();

        }
        private void btng_Click(object sender, EventArgs e)
        {
            if (Balioak()) {
                MessageBox.Show(kalkulagailua.Gehiketa().ToString("0.00"));
                Hasieratu();
            }
            
        }

        private void btnk_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Kenketa().ToString("0.00"));
                Hasieratu();
            }

        }

        private void btnb_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Biderketa().ToString("0.00"));
                Hasieratu();
            }

        }

        private void btnz_Click(object sender, EventArgs e)
        {
            if (Balioak())
            {
                MessageBox.Show(kalkulagailua.Zatiketa().ToString("0.00"));
                Hasieratu();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) // ez bada zenbakia
         && e.KeyChar != Convert.ToChar(Keys.Back) // ez bada atzera
         && e.KeyChar != Convert.ToChar(Keys.Delete)// ez bada ezabatu
         && e.KeyChar != Convert.ToChar(",")) // ez bada koma
            {
                e.Handled = true; // ebentoa kontrolatu
                return; // bueltatu
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(",")) // koma bada
                {
                    if (txtzenb1.Text.IndexOf(",") >= 0) // jada badago koma bat
                    {
                        e.Handled = true; //ebentoa kontrolatu
                        return; //bueltatu
                    }
                    else
                    {
                        if (txtzenb1.Text.Length == 0) // lehenengo koma aurretik 0 bat jartzeko
                        {
                            e.Handled = true;
                            SendKeys.Send("0,");
                        }
                    }
                }
            }
        }
    }
}