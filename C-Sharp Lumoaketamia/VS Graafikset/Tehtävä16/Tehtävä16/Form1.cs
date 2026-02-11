namespace Tehtävä16
{
    public partial class Tehtävä16 : Form
    {
        private int kokonaisaika;
        public Tehtävä16()
        {
            InitializeComponent();
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                minuutitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuutitCB.SelectedIndex = 0;
            sekunnitCB.SelectedIndex = 7;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            StopBT.Enabled = true;

            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTR.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            ajastinTR.Enabled = false;
            aikaLB.Text = "00:00";
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika % 60;
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                ajastinTR.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
