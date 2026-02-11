namespace KolmetoistasProjekti
{
    partial class Harjoitus13FM
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
            NimiTB = new TextBox();
            TarkastaBT = new Button();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 73);
            label1.Name = "label1";
            label1.Size = new Size(521, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa: ";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(577, 70);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(270, 31);
            NimiTB.TabIndex = 1;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(577, 150);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(112, 34);
            TarkastaBT.TabIndex = 2;
            TarkastaBT.Text = "Tarksitaa";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(70, 160);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(59, 25);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "label2";
            VastausLB.Visible = false;
            // 
            // Harjoitus13FM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 813);
            Controls.Add(VastausLB);
            Controls.Add(TarkastaBT);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Name = "Harjoitus13FM";
            Text = "Harjoitus13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Button TarkastaBT;
        private Label VastausLB;
    }
}
