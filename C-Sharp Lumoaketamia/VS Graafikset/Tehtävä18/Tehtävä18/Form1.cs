using System.Data;

namespace Tehtävä18
{
    public partial class AvainhenkilotFM : Form
    {

        DataTable oppilaitos = new DataTable();
        DataTable vastuuHenkilot = new DataTable();
        DataTable yhteys = new DataTable();
        public AvainhenkilotFM()
        {
            InitializeComponent();
        }

        //private void label2_Click(object sender, EventArgs e)
        private void AvainhenkilotFM_Load(object sender, EventArgs e)
        {
            taytaOppilaitosTaulukko();
            oppilaitoksetCB.DataSource = oppilaitos;
            oppilaitoksetCB.DisplayMember = "ONimi";
            taytaVastuuHenkilotTaulukko();
        }

        private void oppilaitoksetCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string viite = oppilaitos.Rows[oppilaitoksetCB.SelectedIndex]["OID"].ToString();
            katuosoiteLB.Text = oppilaitos.Rows[oppilaitoksetCB.SelectedIndex]["OKatuosoite"].ToString();
            PostinumeroLB.Text = oppilaitos.Rows[oppilaitoksetCB.SelectedIndex]["OPostinumero"].ToString();
            PostitoimipaikkaLB.Text = oppilaitos.Rows[oppilaitoksetCB.SelectedIndex]["OPostitoimipaikka"].ToString();
            PuhelinLB.Text = oppilaitos.Rows[oppilaitoksetCB.SelectedIndex]["OPuhelin"].ToString();
        }




        //private void label2_Click(object sender, EventArgs e)
        //{ }
    }
}
