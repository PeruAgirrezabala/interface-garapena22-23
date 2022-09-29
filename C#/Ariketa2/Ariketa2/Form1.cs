namespace Ariketa2
{
    public partial class Form1 : Form
    {
        List<Ariketa2> zenbakiak = new List<Ariketa2>();
        private int zenbHurrengoa;
        public Form1()
        {
            InitializeComponent();
        }



    
        private void button1_Click(object sender, EventArgs e)
        {
            switch (zenbHurrengoa)
            {
                case 0:
                    zenbakiak.Add(new Ariketa2(double.Parse(textBox1.Text)));
                    label1.Text = "2.Zenbakia";
                    break;
                case 1:
                    zenbakiak.Add(new Ariketa2(double.Parse(textBox1.Text)));
                    label1.Text = "3.Zenbakia";
                    break;
                case 2:
                    zenbakiak.Add(new Ariketa2(double.Parse(textBox1.Text)));
                    label1.Text = "4.Zenbakia";
                    break;
                case 3:
                    zenbakiak.Add(new Ariketa2(double.Parse(textBox1.Text)));
                    label1.Text = "Emaitza";
                    textBox1.Text = "(" + zenbakiak[0].zenbakia + " + (2 x " + zenbakiak[1].zenbakia + ") + (3 x " + zenbakiak[2].zenbakia + ") + (4 x " + zenbakiak[3].zenbakia + ")) / 4 = " + Ariketa2.Eragiketa(zenbakiak); ;
                    buttonH.Enabled = false;
                    textBox1.Enabled = false;
                    break;
            }
            if (zenbHurrengoa < 3)
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
            zenbHurrengoa++;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text = "1. Zenbakiak";
            this.textBox1.Text = "";
            foreach(Ariketa2 zenbakia in zenbakiak)
            {
                zenbakiak.Remove(zenbakia);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}