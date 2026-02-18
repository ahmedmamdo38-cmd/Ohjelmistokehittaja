using System.IO;
using System.Reflection.Metadata;
namespace Tehtävä17
{
    public partial class MuistoFM : Form
    {
        string tiedostopolku = "";
        public MuistoFM()
        {
            InitializeComponent();
        }

        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void avaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog atk = new OpenFileDialog
            {
                Filter = "Rikastekstiinformaatti|*.rtf",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (atk.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader vl = new StreamReader(atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> teksti = vl.ReadToEndAsync();
                        rikasRTB.Rtf = teksti.Result;
                    }
                }
            }
        }
        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rikasRTB.Rtf != "")
            {
                tallennaNimelläToolStripMenuItem_Click(sender, e);
                rikasRTB.Rtf = "";
            }
            else
            {
                rikasRTB.Rtf = "";
            }
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tiedostopolku))
            {
                using (SaveFileDialog ttk = new SaveFileDialog()
                {
                    Filter = "Rikastekstiinformaatti|*.rtf",
                    ValidateNames = true
                })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter tiedosto = new StreamWriter(ttk.FileName);
                        tiedosto.WriteLine(this.rikasRTB);
                        tiedosto.Close();
                    }
                }
            }
            else
            {
                using (StreamWriter vk = new StreamWriter(tiedostopolku))
                {
                    vk.WriteLineAsync(rikasRTB.Rtf);
                }
            }
        }

        // Save (use SaveFile so the RTF is preserved)
        private void tallennaNimelläToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog tkk = new SaveFileDialog { Filter = "Rikastekstiformaatti|*.rtf" })
            {
                if (tkk.ShowDialog() == DialogResult.OK)
                    rikasRTB.SaveFile(tkk.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void tulostuksenEsikastseluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tulostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.Redo();
        }

        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.Copy();
        }

        private void leikkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.Cut();
        }

        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.Paste();
        }

        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.SelectedText = " ";
        }

        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.SelectAll();
        }

        private void kirjastinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rikasRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void tekstinKorostusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rikasRTB.SelectionBackColor = Color.Yellow;
        }

        private void tekstinRivittysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tekstinRivittysToolStripMenuItem.Checked == true)
            {
                tekstinRivittysToolStripMenuItem.Checked = false;
                rikasRTB.WordWrap = false;
            }
            else
            {
                tekstinRivittysToolStripMenuItem.Checked = true;
                rikasRTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tietoa tietoa = new Tietoa();
            tietoa.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rikasRTB.Text, rikasRTB.Font, Brushes.Black, 12, 10);
        }

        private void rikasRTB_TextChanged(object sender, EventArgs e)
        {
            if(rikasRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaToolStripMenuItem.Enabled = false;
            }
        }
    }
}
