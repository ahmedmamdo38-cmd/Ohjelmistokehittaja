namespace Tehtävä12
{
    partial class VastausLomakeFM
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
            KysymysLB = new Label();
            DummyRB = new GroupBox();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausARB = new RadioButton();
            DummyBT = new RadioButton();
            VastausLB = new Label();
            DummyRB.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(54, 53);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(196, 25);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaa 1. Kysymykseen:";
            // 
            // DummyRB
            // 
            DummyRB.Controls.Add(VastausDRB);
            DummyRB.Controls.Add(VastausCRB);
            DummyRB.Controls.Add(VastausBRB);
            DummyRB.Controls.Add(VastausARB);
            DummyRB.Controls.Add(DummyBT);
            DummyRB.Location = new Point(256, 12);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(196, 204);
            DummyRB.TabIndex = 1;
            DummyRB.TabStop = false;
            DummyRB.Text = "Vastaus";
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(6, 146);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(50, 29);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(6, 111);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(48, 29);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(6, 76);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(47, 29);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(6, 41);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(49, 29);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // DummyBT
            // 
            DummyBT.AutoSize = true;
            DummyBT.Location = new Point(6, 41);
            DummyBT.Name = "DummyBT";
            DummyBT.Size = new Size(46, 29);
            DummyBT.TabIndex = 0;
            DummyBT.TabStop = true;
            DummyBT.Text = "E";
            DummyBT.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(54, 191);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(72, 25);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // VastausLomakeFM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 264);
            Controls.Add(VastausLB);
            Controls.Add(DummyRB);
            Controls.Add(KysymysLB);
            Name = "VastausLomakeFM";
            Text = "Vastauslomake";
            Load += VastausLomakeFM_Load;
            DummyRB.ResumeLayout(false);
            DummyRB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private GroupBox DummyRB;
        private Label VastausLB;
        private RadioButton VastausDRB;
        private RadioButton VastausCRB;
        private RadioButton VastausBRB;
        private RadioButton VastausARB;
        private RadioButton DummyBT;
    }
}
