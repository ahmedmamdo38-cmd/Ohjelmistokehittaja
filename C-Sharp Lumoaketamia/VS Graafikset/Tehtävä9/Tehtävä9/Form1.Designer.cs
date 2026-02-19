namespace Tehtävä9
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
            AsteetTB = new TextBox();
            CelsiusRB = new RadioButton();
            FehrenheitRB = new RadioButton();
            groupBox1 = new GroupBox();
            MuunaBT = new Button();
            label2 = new Label();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 143);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(242, 143);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(77, 31);
            AsteetTB.TabIndex = 1;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Location = new Point(33, 53);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(91, 29);
            CelsiusRB.TabIndex = 2;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // FehrenheitRB
            // 
            FehrenheitRB.AutoSize = true;
            FehrenheitRB.Location = new Point(33, 97);
            FehrenheitRB.Name = "FehrenheitRB";
            FehrenheitRB.Size = new Size(119, 29);
            FehrenheitRB.TabIndex = 3;
            FehrenheitRB.TabStop = true;
            FehrenheitRB.Text = "Fehrenheit";
            FehrenheitRB.UseVisualStyleBackColor = true;
            FehrenheitRB.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Controls.Add(FehrenheitRB);
            groupBox1.Location = new Point(351, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 150);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunat?";
            // 
            // MuunaBT
            // 
            MuunaBT.Location = new Point(667, 127);
            MuunaBT.Name = "MuunaBT";
            MuunaBT.Size = new Size(112, 62);
            MuunaBT.TabIndex = 5;
            MuunaBT.Text = "Muuna";
            MuunaBT.UseVisualStyleBackColor = true;
            MuunaBT.Click += MuunaBT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 256);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 6;
            label2.Text = "Vastaus:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(189, 256);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(72, 25);
            VastausLB.TabIndex = 7;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 786);
            Controls.Add(VastausLB);
            Controls.Add(label2);
            Controls.Add(MuunaBT);
            Controls.Add(groupBox1);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AsteetTB;
        private RadioButton CelsiusRB;
        private RadioButton FehrenheitRB;
        private GroupBox groupBox1;
        private Button MuunaBT;
        private Label label2;
        private Label VastausLB;
    }
}
