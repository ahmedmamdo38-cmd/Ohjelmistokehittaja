namespace KolmasProjekti1
{
    partial class LaskinFm
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
            LukuYksiTb = new TextBox();
            LukuKaksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LukuYksiTb
            // 
            LukuYksiTb.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LukuYksiTb.Location = new Point(51, 63);
            LukuYksiTb.Name = "LukuYksiTb";
            LukuYksiTb.Size = new Size(150, 50);
            LukuYksiTb.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LukuKaksiTB.Location = new Point(395, 64);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(150, 50);
            LukuKaksiTB.TabIndex = 1;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(207, 64);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(182, 53);
            LaskutoimitusCB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(551, 63);
            label1.Name = "label1";
            label1.Size = new Size(42, 45);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(599, 68);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(39, 45);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            // 
            // LaskeBT
            // 
            LaskeBT.BackColor = SystemColors.ActiveBorder;
            LaskeBT.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LaskeBT.Location = new Point(654, 68);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(148, 54);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = false;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // LaskinFm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 801);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LukuYksiTb);
            Name = "LaskinFm";
            Text = "Yksikertainen Laksin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTb;
        private TextBox LukuKaksiTB;
        private ComboBox LaskutoimitusCB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}
