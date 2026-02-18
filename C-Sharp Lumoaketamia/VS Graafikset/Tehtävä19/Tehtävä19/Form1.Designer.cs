namespace Tehtävä19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            VasenPL = new Panel();
            ylaPL = new Panel();
            meistaPL = new Panel();
            ruoatPL = new Panel();
            juomatPL = new Panel();
            herkutPL = new Panel();
            koriPL = new Panel();
            meistaBT = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ruoatBT = new Button();
            panel3 = new Panel();
            juomatBT = new Button();
            panel4 = new Panel();
            herkutBT = new Button();
            panel5 = new Panel();
            koriBT = new Button();
            hattoPP = new PictureBox();
            label1 = new Label();
            suljePB = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            VasenPL.SuspendLayout();
            ylaPL.SuspendLayout();
            meistaPL.SuspendLayout();
            ruoatPL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hattoPP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suljePB).BeginInit();
            SuspendLayout();
            // 
            // VasenPL
            // 
            VasenPL.BackColor = Color.FromArgb(62, 172, 64);
            VasenPL.Controls.Add(suljePB);
            VasenPL.Controls.Add(panel5);
            VasenPL.Controls.Add(koriBT);
            VasenPL.Controls.Add(panel4);
            VasenPL.Controls.Add(herkutBT);
            VasenPL.Controls.Add(panel3);
            VasenPL.Controls.Add(juomatBT);
            VasenPL.Controls.Add(panel2);
            VasenPL.Controls.Add(ruoatBT);
            VasenPL.Controls.Add(panel1);
            VasenPL.Controls.Add(meistaBT);
            VasenPL.Dock = DockStyle.Left;
            VasenPL.Location = new Point(0, 0);
            VasenPL.Name = "VasenPL";
            VasenPL.Size = new Size(135, 300);
            VasenPL.TabIndex = 0;
            // 
            // ylaPL
            // 
            ylaPL.BackColor = Color.FromArgb(255, 153, 2);
            ylaPL.Controls.Add(label1);
            ylaPL.Controls.Add(hattoPP);
            ylaPL.Dock = DockStyle.Top;
            ylaPL.Location = new Point(135, 0);
            ylaPL.Name = "ylaPL";
            ylaPL.Size = new Size(515, 40);
            ylaPL.TabIndex = 1;
            // 
            // meistaPL
            // 
            meistaPL.Controls.Add(label3);
            meistaPL.Controls.Add(label2);
            meistaPL.Dock = DockStyle.Fill;
            meistaPL.Location = new Point(135, 40);
            meistaPL.Name = "meistaPL";
            meistaPL.Size = new Size(515, 260);
            meistaPL.TabIndex = 0;
            // 
            // ruoatPL
            // 
            ruoatPL.Controls.Add(label4);
            ruoatPL.Dock = DockStyle.Fill;
            ruoatPL.Location = new Point(135, 40);
            ruoatPL.Name = "ruoatPL";
            ruoatPL.Size = new Size(515, 260);
            ruoatPL.TabIndex = 1;
            // 
            // juomatPL
            // 
            juomatPL.Dock = DockStyle.Fill;
            juomatPL.Location = new Point(135, 40);
            juomatPL.Name = "juomatPL";
            juomatPL.Size = new Size(515, 260);
            juomatPL.TabIndex = 2;
            // 
            // herkutPL
            // 
            herkutPL.Dock = DockStyle.Fill;
            herkutPL.Location = new Point(135, 40);
            herkutPL.Name = "herkutPL";
            herkutPL.Size = new Size(515, 260);
            herkutPL.TabIndex = 3;
            // 
            // koriPL
            // 
            koriPL.Dock = DockStyle.Fill;
            koriPL.Location = new Point(135, 40);
            koriPL.Name = "koriPL";
            koriPL.Size = new Size(515, 260);
            koriPL.TabIndex = 4;
            // 
            // meistaBT
            // 
            meistaBT.BackgroundImageLayout = ImageLayout.Zoom;
            meistaBT.FlatAppearance.BorderSize = 0;
            meistaBT.FlatStyle = FlatStyle.Flat;
            meistaBT.ForeColor = Color.White;
            meistaBT.Image = Properties.Resources.info;
            meistaBT.Location = new Point(3, 40);
            meistaBT.Name = "meistaBT";
            meistaBT.Size = new Size(132, 42);
            meistaBT.TabIndex = 0;
            meistaBT.Text = "Meistä";
            meistaBT.TextAlign = ContentAlignment.MiddleRight;
            meistaBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            meistaBT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 218, 45);
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 40);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(105, 218, 45);
            panel2.Location = new Point(3, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 40);
            panel2.TabIndex = 11;
            // 
            // ruoatBT
            // 
            ruoatBT.BackgroundImageLayout = ImageLayout.Zoom;
            ruoatBT.FlatAppearance.BorderSize = 0;
            ruoatBT.FlatStyle = FlatStyle.Flat;
            ruoatBT.ForeColor = Color.White;
            ruoatBT.Image = (Image)resources.GetObject("ruoatBT.Image");
            ruoatBT.Location = new Point(3, 89);
            ruoatBT.Name = "ruoatBT";
            ruoatBT.Size = new Size(132, 42);
            ruoatBT.TabIndex = 10;
            ruoatBT.Text = "Ruoat";
            ruoatBT.TextAlign = ContentAlignment.MiddleRight;
            ruoatBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            ruoatBT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(105, 218, 45);
            panel3.Location = new Point(3, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 40);
            panel3.TabIndex = 13;
            // 
            // juomatBT
            // 
            juomatBT.BackgroundImageLayout = ImageLayout.Zoom;
            juomatBT.FlatAppearance.BorderSize = 0;
            juomatBT.FlatStyle = FlatStyle.Flat;
            juomatBT.ForeColor = Color.White;
            juomatBT.Image = (Image)resources.GetObject("juomatBT.Image");
            juomatBT.Location = new Point(3, 138);
            juomatBT.Name = "juomatBT";
            juomatBT.Size = new Size(132, 42);
            juomatBT.TabIndex = 12;
            juomatBT.Text = "Juomat";
            juomatBT.TextAlign = ContentAlignment.MiddleRight;
            juomatBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            juomatBT.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(105, 218, 45);
            panel4.Location = new Point(3, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 40);
            panel4.TabIndex = 15;
            // 
            // herkutBT
            // 
            herkutBT.BackgroundImageLayout = ImageLayout.Zoom;
            herkutBT.FlatAppearance.BorderSize = 0;
            herkutBT.FlatStyle = FlatStyle.Flat;
            herkutBT.ForeColor = Color.White;
            herkutBT.Image = (Image)resources.GetObject("herkutBT.Image");
            herkutBT.Location = new Point(3, 187);
            herkutBT.Name = "herkutBT";
            herkutBT.Size = new Size(132, 42);
            herkutBT.TabIndex = 14;
            herkutBT.Text = "Herkut";
            herkutBT.TextAlign = ContentAlignment.MiddleRight;
            herkutBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            herkutBT.UseVisualStyleBackColor = true;
            herkutBT.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(105, 218, 45);
            panel5.Location = new Point(3, 239);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 40);
            panel5.TabIndex = 17;
            // 
            // koriBT
            // 
            koriBT.BackgroundImageLayout = ImageLayout.Zoom;
            koriBT.FlatAppearance.BorderSize = 0;
            koriBT.FlatStyle = FlatStyle.Flat;
            koriBT.ForeColor = Color.White;
            koriBT.Image = (Image)resources.GetObject("koriBT.Image");
            koriBT.Location = new Point(3, 236);
            koriBT.Name = "koriBT";
            koriBT.Size = new Size(132, 42);
            koriBT.TabIndex = 16;
            koriBT.Text = "Kori";
            koriBT.TextAlign = ContentAlignment.MiddleRight;
            koriBT.TextImageRelation = TextImageRelation.TextBeforeImage;
            koriBT.UseVisualStyleBackColor = true;
            // 
            // hattoPP
            // 
            hattoPP.Dock = DockStyle.Right;
            hattoPP.Image = Properties.Resources.cook_hat;
            hattoPP.Location = new Point(437, 0);
            hattoPP.Name = "hattoPP";
            hattoPP.Size = new Size(78, 40);
            hattoPP.TabIndex = 0;
            hattoPP.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 3);
            label1.Name = "label1";
            label1.Size = new Size(399, 37);
            label1.TabIndex = 1;
            label1.Text = "Keudan oppilaskunnan kahvila";
            // 
            // suljePB
            // 
            suljePB.Image = Properties.Resources.Red_dot;
            suljePB.Location = new Point(3, 3);
            suljePB.Name = "suljePB";
            suljePB.Size = new Size(23, 24);
            suljePB.TabIndex = 18;
            suljePB.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 9);
            label2.Name = "label2";
            label2.Size = new Size(522, 75);
            label2.TabIndex = 0;
            label2.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \r\n9:00-14:30 joka päivä maanantaista torstaisin ja perjantaisin \r\n9:00-12:30.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 116);
            label3.Name = "label3";
            label3.Size = new Size(512, 75);
            label3.TabIndex = 1;
            label3.Text = "Keudan oppilaskunnan kahvilasta saa lämpimien\r\n juomien lisäksi virvoikkeita sekä pientä purtavaa sekä makeisia \r\nTervetuloa tutustumaan !";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 17);
            label4.Name = "label4";
            label4.Size = new Size(170, 125);
            label4.TabIndex = 0;
            label4.Text = "Suolaiset \r\n-juustosämpylä  3€\r\n-kinkkusämpylä  3€\r\n-croissant            2€\r\n-karjalanpiirakka  2€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(650, 300);
            Controls.Add(ruoatPL);
            Controls.Add(meistaPL);
            Controls.Add(koriPL);
            Controls.Add(herkutPL);
            Controls.Add(juomatPL);
            Controls.Add(ylaPL);
            Controls.Add(VasenPL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            VasenPL.ResumeLayout(false);
            ylaPL.ResumeLayout(false);
            ylaPL.PerformLayout();
            meistaPL.ResumeLayout(false);
            meistaPL.PerformLayout();
            ruoatPL.ResumeLayout(false);
            ruoatPL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hattoPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)suljePB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel VasenPL;
        private Panel ylaPL;
        private Panel meistaPL;
        private Panel ruoatPL;
        private Panel juomatPL;
        private Panel herkutPL;
        private Panel koriPL;
        private Button meistaBT;
        private Panel panel1;
        private Panel panel5;
        private Button koriBT;
        private Panel panel4;
        private Button herkutBT;
        private Panel panel3;
        private Button juomatBT;
        private Panel panel2;
        private Button ruoatBT;
        private Label label1;
        private PictureBox hattoPP;
        private PictureBox suljePB;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
