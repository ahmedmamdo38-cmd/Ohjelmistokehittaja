namespace Tehtävä_20
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            idTB = new TextBox();
            etunimiTB = new TextBox();
            sukunimiTB = new TextBox();
            opiskelijaNroTB = new TextBox();
            emailTB = new TextBox();
            phoneTB = new TextBox();
            tyhjennaBT = new Button();
            tallennaBT = new Button();
            paivitaBT = new Button();
            poistaBT = new Button();
            TietotauluDG = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 51);
            label1.Name = "label1";
            label1.Size = new Size(48, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 99);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 1;
            label2.Text = "ETUNIIMI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 144);
            label3.Name = "label3";
            label3.Size = new Size(148, 32);
            label3.TabIndex = 2;
            label3.Text = "SUKUNIMI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(459, 51);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 3;
            label4.Text = "PUHELIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(459, 99);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 4;
            label5.Text = "SÄHKÖPOSTI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(459, 144);
            label6.Name = "label6";
            label6.Size = new Size(212, 32);
            label6.TabIndex = 5;
            label6.Text = "OPISKELIJANRO:";
            // 
            // idTB
            // 
            idTB.Location = new Point(195, 54);
            idTB.Name = "idTB";
            idTB.Size = new Size(222, 31);
            idTB.TabIndex = 6;
            // 
            // etunimiTB
            // 
            etunimiTB.Location = new Point(195, 100);
            etunimiTB.Name = "etunimiTB";
            etunimiTB.Size = new Size(222, 31);
            etunimiTB.TabIndex = 7;
            // 
            // sukunimiTB
            // 
            sukunimiTB.Location = new Point(195, 147);
            sukunimiTB.Name = "sukunimiTB";
            sukunimiTB.Size = new Size(222, 31);
            sukunimiTB.TabIndex = 8;
            // 
            // opiskelijaNroTB
            // 
            opiskelijaNroTB.Location = new Point(677, 147);
            opiskelijaNroTB.Name = "opiskelijaNroTB";
            opiskelijaNroTB.Size = new Size(222, 31);
            opiskelijaNroTB.TabIndex = 9;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(677, 99);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(222, 31);
            emailTB.TabIndex = 10;
            // 
            // phoneTB
            // 
            phoneTB.Location = new Point(677, 51);
            phoneTB.Name = "phoneTB";
            phoneTB.Size = new Size(222, 31);
            phoneTB.TabIndex = 11;
            // 
            // tyhjennaBT
            // 
            tyhjennaBT.BackColor = SystemColors.ControlLight;
            tyhjennaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tyhjennaBT.Location = new Point(39, 201);
            tyhjennaBT.Name = "tyhjennaBT";
            tyhjennaBT.Size = new Size(197, 56);
            tyhjennaBT.TabIndex = 12;
            tyhjennaBT.Text = "TYHJENNÄ";
            tyhjennaBT.UseVisualStyleBackColor = false;
            tyhjennaBT.Click += tyhjennaBT_Click;
            // 
            // tallennaBT
            // 
            tallennaBT.BackColor = SystemColors.ControlLight;
            tallennaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tallennaBT.Location = new Point(258, 201);
            tallennaBT.Name = "tallennaBT";
            tallennaBT.Size = new Size(197, 56);
            tallennaBT.TabIndex = 13;
            tallennaBT.Text = "TALLENNA";
            tallennaBT.UseVisualStyleBackColor = false;
            tallennaBT.Click += tallennaBT_Click;
            // 
            // paivitaBT
            // 
            paivitaBT.BackColor = SystemColors.ControlLight;
            paivitaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paivitaBT.Location = new Point(474, 201);
            paivitaBT.Name = "paivitaBT";
            paivitaBT.Size = new Size(197, 56);
            paivitaBT.TabIndex = 14;
            paivitaBT.Text = "PÄIVITÄ";
            paivitaBT.UseVisualStyleBackColor = false;
            paivitaBT.Click += paivitaBT_Click;
            // 
            // poistaBT
            // 
            poistaBT.BackColor = SystemColors.ControlLight;
            poistaBT.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            poistaBT.Location = new Point(702, 201);
            poistaBT.Name = "poistaBT";
            poistaBT.Size = new Size(197, 56);
            poistaBT.TabIndex = 15;
            poistaBT.Text = "POISTA";
            poistaBT.UseVisualStyleBackColor = false;
            poistaBT.Click += poistaBT_Click;
            // 
            // TietotauluDG
            // 
            TietotauluDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TietotauluDG.Location = new Point(39, 263);
            TietotauluDG.Name = "TietotauluDG";
            TietotauluDG.RowHeadersWidth = 62;
            TietotauluDG.Size = new Size(860, 453);
            TietotauluDG.TabIndex = 16;
            TietotauluDG.CellContentClick += TietotauluDG_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 818);
            Controls.Add(TietotauluDG);
            Controls.Add(poistaBT);
            Controls.Add(paivitaBT);
            Controls.Add(tallennaBT);
            Controls.Add(tyhjennaBT);
            Controls.Add(phoneTB);
            Controls.Add(emailTB);
            Controls.Add(opiskelijaNroTB);
            Controls.Add(sukunimiTB);
            Controls.Add(etunimiTB);
            Controls.Add(idTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Opiskelijarekisterin ylläpito";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TietotauluDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idTB;
        private TextBox etunimiTB;
        private TextBox sukunimiTB;
        private TextBox opiskelijaNroTB;
        private TextBox emailTB;
        private TextBox phoneTB;
        private Button tyhjennaBT;
        private Button tallennaBT;
        private Button paivitaBT;
        private Button poistaBT;
        private DataGridView TietotauluDG;
    }
}
