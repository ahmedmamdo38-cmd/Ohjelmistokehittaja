namespace Tehtävä12
{
    public partial class VastausLomakeFM : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] vastaukset = new string[10];
        string[] oikeat = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        public VastausLomakeFM()
        {
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void VastausLomakeFM_Load(object sender, EventArgs e)
        {

        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysmyskseen:";
                laskuri++;
            }
            else
            {
                VastausLB.Text = " ";
                VastausARB.Enabled = false;
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                
                for(int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if(VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if(VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if(VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if(VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}
