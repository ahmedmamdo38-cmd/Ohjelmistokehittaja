namespace Tehtävä10
{
    partial class BMILaskuriFM
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
            label1 = new Label();
            label3 = new Label();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            BMILaskuriBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 45);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 92);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Anna pituus:";
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(190, 45);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(150, 31);
            PainoTB.TabIndex = 3;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(190, 92);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(150, 31);
            PituusTB.TabIndex = 4;
            // 
            // BMILaskuriBT
            // 
            BMILaskuriBT.BackColor = Color.SteelBlue;
            BMILaskuriBT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BMILaskuriBT.ForeColor = Color.Snow;
            BMILaskuriBT.Location = new Point(58, 150);
            BMILaskuriBT.Name = "BMILaskuriBT";
            BMILaskuriBT.Size = new Size(282, 48);
            BMILaskuriBT.TabIndex = 5;
            BMILaskuriBT.Text = "Laske painoindeksi";
            BMILaskuriBT.UseVisualStyleBackColor = false;
            BMILaskuriBT.Click += BMILaskuriBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(58, 220);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(72, 25);
            VastausLB.TabIndex = 6;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // BMILaskuriFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 298);
            Controls.Add(VastausLB);
            Controls.Add(BMILaskuriBT);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "BMILaskuriFM";
            Text = "BMI Laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Button BMILaskuriBT;
        private Label VastausLB;
    }
}
