namespace LukujenJarjestys_viidesProjekti_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                }
                else
                {

                }
            }
        }

        private void jono(object sender, EventArgs e)
        {

        }
    }
}
