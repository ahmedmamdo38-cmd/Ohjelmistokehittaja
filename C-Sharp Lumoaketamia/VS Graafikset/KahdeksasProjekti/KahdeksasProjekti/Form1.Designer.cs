namespace KahdeksasProjekti
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
            label2 = new Label();
            TekstiTB = new TextBox();
            MuutaBT = new Button();
            VastasuLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Lucida Handwriting", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(381, 61);
            label1.Name = "label1";
            label1.Size = new Size(549, 52);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(982, 27);
            label2.TabIndex = 1;
            label2.Text = "Roomalaiset numerot Anna numero valilla 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(1016, 199);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(226, 31);
            TekstiTB.TabIndex = 2;
            // 
            // MuutaBT
            // 
            MuutaBT.BackColor = Color.PeachPuff;
            MuutaBT.Font = new Font("Lucida Handwriting", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MuutaBT.Location = new Point(1016, 290);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(171, 73);
            MuutaBT.TabIndex = 3;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = false;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // VastasuLB
            // 
            VastasuLB.AutoSize = true;
            VastasuLB.Font = new Font("Lucida Handwriting", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VastasuLB.Location = new Point(510, 306);
            VastasuLB.Name = "VastasuLB";
            VastasuLB.Size = new Size(131, 41);
            VastasuLB.TabIndex = 4;
            VastasuLB.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Roman_numerals_2;
            ClientSize = new Size(1310, 851);
            Controls.Add(VastasuLB);
            Controls.Add(MuutaBT);
            Controls.Add(TekstiTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TekstiTB;
        private Button MuutaBT;
        private Label VastasuLB;
    }
}
