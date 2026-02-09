namespace LukujenJarjestys_viidesProjekti_
{
    partial class Form1
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
            uusiLukuTB = new TextBox();
            VastausLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna luku (-999 lopetus):\r\n";
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Location = new Point(308, 76);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(327, 31);
            uusiLukuTB.TabIndex = 1;
            uusiLukuTB.KeyPress += uusiLukuTB_KeyPress;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(51, 141);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(59, 25);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "label2";
            VastausLB.Click += jono;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 815);
            Controls.Add(VastausLB);
            Controls.Add(uusiLukuTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uusiLukuTB;
        private Label VastausLB;
    }
}
