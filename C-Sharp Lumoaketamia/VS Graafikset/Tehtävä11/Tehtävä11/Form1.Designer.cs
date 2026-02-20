namespace Tehtävä11
{
    partial class NopanHeittoFM
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
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            HeittaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(233, 41);
            label1.TabIndex = 0;
            label1.Text = "Nopan heitto";
            // 
            // noppa01PB
            // 
            noppa01PB.Image = Properties.Resources.dice01;
            noppa01PB.Location = new Point(33, 93);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(100, 100);
            noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa01PB.TabIndex = 1;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.dice01;
            noppa02PB.Location = new Point(166, 93);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(100, 100);
            noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa02PB.TabIndex = 2;
            noppa02PB.TabStop = false;
            // 
            // HeittaBT
            // 
            HeittaBT.BackColor = Color.Black;
            HeittaBT.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeittaBT.ForeColor = Color.Gold;
            HeittaBT.Location = new Point(33, 220);
            HeittaBT.Name = "HeittaBT";
            HeittaBT.Size = new Size(233, 76);
            HeittaBT.TabIndex = 3;
            HeittaBT.Text = "Heittä";
            HeittaBT.UseVisualStyleBackColor = false;
            HeittaBT.Click += HeittaBT_Click;
            // 
            // NopanHeittoFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 344);
            Controls.Add(HeittaBT);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Controls.Add(label1);
            Name = "NopanHeittoFM";
            Text = "Nopan heitto ";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button HeittaBT;
    }
}
