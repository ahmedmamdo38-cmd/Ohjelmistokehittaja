namespace Tehtävä10
{
    public partial class BMILaskuriFM : Form
    {
        public BMILaskuriFM()
        {
            InitializeComponent();
        }

        private void BMILaskuriBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);

            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if(bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on " + bmi + "\n Alipaino";
                VastausLB.ForeColor = Color.SkyBlue;
                VastausLB.Visible = true;
            }
            else if(bmi < 25)
            {
                VastausLB.Text = "Painoindeksisi " + bmi + "\n Normaalipaino";
                VastausLB.ForeColor = Color.Green;
                VastausLB.Visible = true;
                
            }
            else if(bmi < 40){
                VastausLB.Text = "Painoindeksisi " + bmi + "\n Ylipaino";
                VastausLB.ForeColor = Color.Yellow;
                VastausLB.Visible = true;
            }
            else{
                VastausLB.Text = "Painoindeksisi " + bmi + "\n Huomattava ylipaino";
                VastausLB.ForeColor = Color.Red;
                VastausLB.Visible = true;
            }
        }
    }
}
