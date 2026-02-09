namespace NeljasProjekti
{
    partial class ikaLaskuriDT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ikäLaskuriDT = new DateTimePicker();
            LaskeLB = new Label();
            vuosissaLB = new Label();
            kuukaudessaLb = new Label();
            paivissaLb = new Label();
            tuneissaLB = new Label();
            minuutiessäLb = new Label();
            sekuntiaLb = new Label();
            SuspendLayout();
            // 
            // ikäLaskuriDT
            // 
            ikäLaskuriDT.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ikäLaskuriDT.Location = new Point(44, 50);
            ikäLaskuriDT.Name = "ikäLaskuriDT";
            ikäLaskuriDT.Size = new Size(435, 31);
            ikäLaskuriDT.TabIndex = 0;
            // 
            // LaskeLB
            // 
            LaskeLB.AutoSize = true;
            LaskeLB.BackColor = SystemColors.AppWorkspace;
            LaskeLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskeLB.ForeColor = SystemColors.ActiveCaptionText;
            LaskeLB.Location = new Point(506, 50);
            LaskeLB.Name = "LaskeLB";
            LaskeLB.Size = new Size(98, 45);
            LaskeLB.TabIndex = 1;
            LaskeLB.Text = "Laske";
            LaskeLB.Click += LaskeLB_Click;
            // 
            // vuosissaLB
            // 
            vuosissaLB.AutoSize = true;
            vuosissaLB.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            vuosissaLB.Location = new Point(44, 129);
            vuosissaLB.Name = "vuosissaLB";
            vuosissaLB.Size = new Size(117, 45);
            vuosissaLB.TabIndex = 2;
            vuosissaLB.Text = "vuotta";
            vuosissaLB.Visible = false;
            // 
            // kuukaudessaLb
            // 
            kuukaudessaLb.AutoSize = true;
            kuukaudessaLb.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            kuukaudessaLb.Location = new Point(44, 193);
            kuukaudessaLb.Name = "kuukaudessaLb";
            kuukaudessaLb.Size = new Size(175, 45);
            kuukaudessaLb.TabIndex = 3;
            kuukaudessaLb.Text = "kuukautta";
            kuukaudessaLb.Visible = false;
            // 
            // paivissaLb
            // 
            paivissaLb.AutoSize = true;
            paivissaLb.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            paivissaLb.Location = new Point(44, 251);
            paivissaLb.Name = "paivissaLb";
            paivissaLb.Size = new Size(123, 45);
            paivissaLb.TabIndex = 4;
            paivissaLb.Text = "päivää";
            paivissaLb.Visible = false;
            // 
            // tuneissaLB
            // 
            tuneissaLB.AutoSize = true;
            tuneissaLB.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tuneissaLB.Location = new Point(433, 129);
            tuneissaLB.Name = "tuneissaLB";
            tuneissaLB.Size = new Size(111, 45);
            tuneissaLB.TabIndex = 5;
            tuneissaLB.Text = "tuntia";
            tuneissaLB.Visible = false;
            // 
            // minuutiessäLb
            // 
            minuutiessäLb.AutoSize = true;
            minuutiessäLb.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            minuutiessäLb.Location = new Point(433, 193);
            minuutiessäLb.Name = "minuutiessäLb";
            minuutiessäLb.Size = new Size(169, 45);
            minuutiessäLb.TabIndex = 6;
            minuutiessäLb.Text = "minuuttia";
            minuutiessäLb.Visible = false;
            // 
            // sekuntiaLb
            // 
            sekuntiaLb.AutoSize = true;
            sekuntiaLb.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sekuntiaLb.Location = new Point(433, 251);
            sekuntiaLb.Name = "sekuntiaLb";
            sekuntiaLb.Size = new Size(149, 45);
            sekuntiaLb.TabIndex = 7;
            sekuntiaLb.Text = "Vuosissa";
            sekuntiaLb.Visible = false;
            // 
            // ikaLaskuriDT
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 796);
            Controls.Add(sekuntiaLb);
            Controls.Add(minuutiessäLb);
            Controls.Add(tuneissaLB);
            Controls.Add(paivissaLb);
            Controls.Add(kuukaudessaLb);
            Controls.Add(vuosissaLB);
            Controls.Add(LaskeLB);
            Controls.Add(ikäLaskuriDT);
            Name = "ikaLaskuriDT";
            Text = "Ikälaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker ikäLaskuriDT;
        private Label LaskeLB;
        private Label vuosissaLB;
        private Label kuukaudessaLb;
        private Label paivissaLb;
        private Label tuneissaLB;
        private Label minuutiessäLb;
        private Label sekuntiaLb;
    }
}
