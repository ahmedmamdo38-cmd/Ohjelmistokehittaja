namespace Tehtävä15
{
    partial class sekkariFM
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
            aikaLB = new Label();
            startBT = new Button();
            stopBT = new Button();
            ResetBT = new Button();
            ajastinTR = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aikaLB.Location = new Point(51, 115);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(944, 191);
            aikaLB.TabIndex = 0;
            aikaLB.Text = "00:00:00.000";
            // 
            // startBT
            // 
            startBT.Location = new Point(69, 372);
            startBT.Name = "startBT";
            startBT.Size = new Size(201, 95);
            startBT.TabIndex = 1;
            startBT.Text = "Start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // stopBT
            // 
            stopBT.Location = new Point(396, 372);
            stopBT.Name = "stopBT";
            stopBT.Size = new Size(201, 95);
            stopBT.TabIndex = 2;
            stopBT.Text = "Stop";
            stopBT.UseVisualStyleBackColor = true;
            stopBT.Click += stopBT_Click;
            // 
            // ResetBT
            // 
            ResetBT.Location = new Point(697, 372);
            ResetBT.Name = "ResetBT";
            ResetBT.Size = new Size(201, 95);
            ResetBT.TabIndex = 3;
            ResetBT.Text = "Reset";
            ResetBT.UseVisualStyleBackColor = true;
            ResetBT.Click += ResetBT_Click;
            // 
            // ajastinTR
            // 
            ajastinTR.Enabled = true;
            ajastinTR.Tick += ajastinTR_Tick;
            // 
            // sekkariFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 809);
            Controls.Add(ResetBT);
            Controls.Add(stopBT);
            Controls.Add(startBT);
            Controls.Add(aikaLB);
            Name = "sekkariFM";
            Text = "Sekuntikello";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aikaLB;
        private Button startBT;
        private Button stopBT;
        private Button ResetBT;
        private System.Windows.Forms.Timer ajastinTR;
    }
}
