using System.Diagnostics.Eventing.Reader;

namespace TokaProjekti
{
    public partial class harjoitus2FM : Form
    {
        public harjoitus2FM()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostusLb.Visible = true;
            if(teksti.Length > 0)
            {
                TulostusLb.Text = teksti;
            }
            else
            {
                TulostusLb.Text = "Et4444 syöttänyt mitään tekstiä";
                ViestiTB.Focus();
                TulostusLb.Visible = true;
            }
        }
        

    }
}