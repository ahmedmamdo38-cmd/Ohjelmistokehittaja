namespace Tehtävä9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MuunaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);

            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fahreineitia on " + vastaus + " Celsius astetta ";
                VastausLB.Visible = true;
            }
            else if(FehrenheitRB.Checked)
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celsiuta on " + vastaus + " Fahrenheit asetta ";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = " Et valinnut muunnettavaa astetta tai antanut oikeaa lukua!!! ";
                VastausLB.Visible = true;
            }
        }
    }
}
