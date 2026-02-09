namespace TokaProjekti
{
    partial class harjoitus2FM
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
            OtsikkoLb = new Label();
            TulostusLb = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLb
            // 
            OtsikkoLb.AutoSize = true;
            OtsikkoLb.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OtsikkoLb.Location = new Point(40, 93);
            OtsikkoLb.Name = "OtsikkoLb";
            OtsikkoLb.Size = new Size(442, 51);
            OtsikkoLb.TabIndex = 0;
            OtsikkoLb.Text = "Anna tulostettava teksti:";
            // 
            // TulostusLb
            // 
            TulostusLb.AutoSize = true;
            TulostusLb.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulostusLb.Location = new Point(40, 176);
            TulostusLb.Name = "TulostusLb";
            TulostusLb.Size = new Size(111, 51);
            TulostusLb.TabIndex = 1;
            TulostusLb.Text = "xxxx";
            TulostusLb.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.AcceptsReturn = true;
            ViestiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViestiTB.Location = new Point(532, 105);
            ViestiTB.Multiline = true;
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(401, 46);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.ForeColor = Color.Black;
            TulostaBT.Location = new Point(706, 183);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(227, 41);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // harjoitus2FM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(945, 794);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(TulostusLb);
            Controls.Add(OtsikkoLb);
            ForeColor = Color.MintCream;
            Name = "harjoitus2FM";
            Text = "Harjoitus2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLb;
        private Label TulostusLb;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}
