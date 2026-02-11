namespace KolmetoistasProjekti
{
    public partial class Harjoitus13FM : Form
    {
        public Harjoitus13FM()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Temp/pojat.txt");
            string[] tyot = File.ReadAllLines("C:/Temp/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach(string poika in pojat)
            {
                if(nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi vuonna 2026";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach(string tytto in tyot)
            {
                if(nimi == tytto){
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2026";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien nimien joukosta !!!";
                VastausLB.Visible = true;
            }

        }
    }
}
