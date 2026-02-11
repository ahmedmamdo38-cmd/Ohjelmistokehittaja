namespace Tehtävä14
{
    public partial class PaivaKirjaFM : Form
    {
        public PaivaKirjaFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:/Temp/paivakirja.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:/Temp/paivakirja.txt");
            text.WriteLine(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
