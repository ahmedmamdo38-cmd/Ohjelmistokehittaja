namespace Tehtävä14
{
    partial class PaivaKirjaFM
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
            SyottoTB = new TextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // SyottoTB
            // 
            SyottoTB.Location = new Point(42, 34);
            SyottoTB.Multiline = true;
            SyottoTB.Name = "SyottoTB";
            SyottoTB.Size = new Size(847, 515);
            SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            TallennaBT.BackColor = Color.LightSkyBlue;
            TallennaBT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TallennaBT.Location = new Point(42, 589);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(862, 96);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallena päiväkirjaan ";
            TallennaBT.UseVisualStyleBackColor = false;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // PaivaKirjaFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 799);
            Controls.Add(TallennaBT);
            Controls.Add(SyottoTB);
            Name = "PaivaKirjaFM";
            Text = "Päiväkirja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SyottoTB;
        private Button TallennaBT;
    }
}
