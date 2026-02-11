namespace Tehtävä16
{
    partial class Tehtävä16
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            minuutitCB = new ComboBox();
            sekunnitCB = new ComboBox();
            aikaLB = new Label();
            startBT = new Button();
            StopBT = new Button();
            ajastinTR = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 103);
            label1.Name = "label1";
            label1.Size = new Size(148, 45);
            label1.TabIndex = 0;
            label1.Text = "Minuutit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 103);
            label2.Name = "label2";
            label2.Size = new Size(150, 45);
            label2.TabIndex = 1;
            label2.Text = "Sekunnit:";
            // 
            // minuutitCB
            // 
            minuutitCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minuutitCB.FormattingEnabled = true;
            minuutitCB.Location = new Point(185, 169);
            minuutitCB.Name = "minuutitCB";
            minuutitCB.Size = new Size(136, 53);
            minuutitCB.TabIndex = 2;
            // 
            // sekunnitCB
            // 
            sekunnitCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sekunnitCB.FormattingEnabled = true;
            sekunnitCB.Location = new Point(384, 169);
            sekunnitCB.Name = "sekunnitCB";
            sekunnitCB.Size = new Size(136, 53);
            sekunnitCB.TabIndex = 3;
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aikaLB.Location = new Point(208, 225);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(300, 128);
            aikaLB.TabIndex = 4;
            aikaLB.Text = "00:00";
            // 
            // startBT
            // 
            startBT.Location = new Point(185, 369);
            startBT.Name = "startBT";
            startBT.Size = new Size(136, 81);
            startBT.TabIndex = 5;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // StopBT
            // 
            StopBT.Location = new Point(384, 369);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(136, 81);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = true;
            StopBT.Click += StopBT_Click;
            // 
            // ajastinTR
            // 
            ajastinTR.Enabled = true;
            ajastinTR.Interval = 1000;
            ajastinTR.Tick += ajastinTR_Tick;
            // 
            // Tehtävä16
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 780);
            Controls.Add(StopBT);
            Controls.Add(startBT);
            Controls.Add(aikaLB);
            Controls.Add(sekunnitCB);
            Controls.Add(minuutitCB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tehtävä16";
            Text = "Kokonaisaika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private Button startBT;
        private Button StopBT;
        private System.Windows.Forms.Timer ajastinTR;
    }
}
