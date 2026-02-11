using System.Diagnostics;

namespace Tehtävä15
{
    public partial class sekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();

        public sekkariFM()
        {
            InitializeComponent();
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
