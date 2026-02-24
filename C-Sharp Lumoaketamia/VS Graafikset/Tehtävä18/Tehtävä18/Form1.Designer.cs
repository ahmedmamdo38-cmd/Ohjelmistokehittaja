namespace Tehtävä18
{
    partial class AvainhenkilotFM
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
            label3 = new Label();
            oppilaitoksetCB = new ComboBox();
            vastuuhloCB = new ComboBox();
            katuosoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            titteliLB = new Label();
            emailLB = new Label();
            phoneLB = new Label();
            sijantiLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(718, 70);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 115);
            label2.Name = "label2";
            label2.Size = new Size(269, 45);
            label2.TabIndex = 1;
            label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(373, 115);
            label3.Name = "label3";
            label3.Size = new Size(324, 45);
            label3.TabIndex = 2;
            label3.Text = "Valitse vastuuhenkilö:";
            // 
            // oppilaitoksetCB
            // 
            oppilaitoksetCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oppilaitoksetCB.FormattingEnabled = true;
            oppilaitoksetCB.Location = new Point(30, 190);
            oppilaitoksetCB.Name = "oppilaitoksetCB";
            oppilaitoksetCB.Size = new Size(272, 53);
            oppilaitoksetCB.TabIndex = 3;
            oppilaitoksetCB.SelectedIndexChanged += oppilaitoksetCB_SelectedIndexChanged;
            // 
            // vastuuhloCB
            // 
            vastuuhloCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vastuuhloCB.FormattingEnabled = true;
            vastuuhloCB.Location = new Point(373, 190);
            vastuuhloCB.Name = "vastuuhloCB";
            vastuuhloCB.Size = new Size(324, 53);
            vastuuhloCB.TabIndex = 4;
            vastuuhloCB.SelectedIndexChanged += vastuuhloCB_SelectedIndexChanged;
            // 
            // katuosoiteLB
            // 
            katuosoiteLB.AutoSize = true;
            katuosoiteLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            katuosoiteLB.Location = new Point(30, 269);
            katuosoiteLB.Name = "katuosoiteLB";
            katuosoiteLB.Size = new Size(178, 45);
            katuosoiteLB.TabIndex = 5;
            katuosoiteLB.Text = "katu osoite";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PostinumeroLB.Location = new Point(30, 333);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(200, 45);
            PostinumeroLB.TabIndex = 6;
            PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PostitoimipaikkaLB.Location = new Point(30, 399);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(254, 45);
            PostitoimipaikkaLB.TabIndex = 7;
            PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PuhelinLB.Location = new Point(30, 476);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(236, 45);
            PuhelinLB.TabIndex = 8;
            PuhelinLB.Text = "Puhelinnumero";
            // 
            // titteliLB
            // 
            titteliLB.AutoSize = true;
            titteliLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titteliLB.Location = new Point(373, 269);
            titteliLB.Name = "titteliLB";
            titteliLB.Size = new Size(94, 45);
            titteliLB.TabIndex = 9;
            titteliLB.Text = "titteli";
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLB.Location = new Point(373, 399);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(96, 45);
            emailLB.TabIndex = 10;
            emailLB.Text = "Email";
            // 
            // phoneLB
            // 
            phoneLB.AutoSize = true;
            phoneLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneLB.Location = new Point(373, 476);
            phoneLB.Name = "phoneLB";
            phoneLB.Size = new Size(253, 45);
            phoneLB.TabIndex = 11;
            phoneLB.Text = "Puhelinnumero1";
            // 
            // sijantiLB
            // 
            sijantiLB.AutoSize = true;
            sijantiLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sijantiLB.Location = new Point(373, 333);
            sijantiLB.Name = "sijantiLB";
            sijantiLB.Size = new Size(106, 45);
            sijantiLB.TabIndex = 12;
            sijantiLB.Text = "Sijanti";
            // 
            // AvainhenkilotFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 664);
            Controls.Add(sijantiLB);
            Controls.Add(phoneLB);
            Controls.Add(emailLB);
            Controls.Add(titteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(katuosoiteLB);
            Controls.Add(vastuuhloCB);
            Controls.Add(oppilaitoksetCB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AvainhenkilotFM";
            Text = "Oppilaitosten  avainhenkilöt ";
            Load += AvainhenkilotFM_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox oppilaitoksetCB;
        private ComboBox vastuuhloCB;
        private Label katuosoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label titteliLB;
        private Label emailLB;
        private Label phoneLB;
        private Label sijantiLB;
    }
}
