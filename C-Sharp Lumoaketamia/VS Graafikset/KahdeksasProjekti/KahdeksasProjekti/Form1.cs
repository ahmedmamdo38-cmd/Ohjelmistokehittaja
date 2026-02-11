namespace KahdeksasProjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if(TekstiTB.Text.Length > 3)
            {
                luku1 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1));
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1));
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1));
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(3, 1));


                if(luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if(luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if(luku1 % 3 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset

            }
        }
    }
}
