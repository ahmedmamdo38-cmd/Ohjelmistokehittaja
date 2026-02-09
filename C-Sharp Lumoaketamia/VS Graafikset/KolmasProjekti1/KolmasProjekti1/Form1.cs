namespace KolmasProjekti1
{
    public partial class LaskinFm : Form
    {
        public LaskinFm()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            float luku1 = float.Parse(LukuYksiTb.Text);
            float luku2 = float.Parse(LukuKaksiTB.Text);
            float vastaus = 0;
            string merkki = LaskutoimitusCB.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastaus = 0; 
                    break;
             }
            VastausLB.Text = Convert.ToString(vastaus);
            VastausLB.Visible = true;

        }
    }
}
