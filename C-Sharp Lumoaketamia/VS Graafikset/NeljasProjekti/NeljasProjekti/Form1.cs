namespace NeljasProjekti
{
    public partial class ikaLaskuriDT : System.Windows.Forms.Form
    {
        public ikaLaskuriDT()
        {
            InitializeComponent();
        }

        private void LaskeLB_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = ik‰LaskuriDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            vuosissaLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            kuukaudessaLb.Text = Math.Floor(erotus * 12 / 365.25) + " kuukautta";
            paivissaLb.Text = (erotus + " p‰ivi‰‰");
            tuneissaLB.Text = (erotus * 24 + " tuntia ");
            minuutiess‰Lb.Text = (erotus * 24 * 60 + " minuutissa ");
            sekuntiaLb.Text = (erotus * 24 * 3600 + " sekuntia");
            vuosissaLB.Visible = true;
            kuukaudessaLb.Visible = true;
            paivissaLb.Visible = true;
            tuneissaLB.Visible = true;
            minuutiess‰Lb.Visible = true;
            sekuntiaLb.Visible = true;
            

        }
    }
}
