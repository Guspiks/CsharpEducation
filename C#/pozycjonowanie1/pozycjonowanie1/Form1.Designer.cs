namespace pozycjonowanie1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Pozycjonuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PozycjaX = new System.Windows.Forms.Label();
            this.lbl_PozycjaY = new System.Windows.Forms.Label();
            this.lbl_speedx = new System.Windows.Forms.Label();
            this.lbl_XLOP = new System.Windows.Forms.Label();
            this.lbl_YLOP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_speedy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Wiad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Pozycjonuj
            // 
            this.bt_Pozycjonuj.Location = new System.Drawing.Point(565, 12);
            this.bt_Pozycjonuj.Name = "bt_Pozycjonuj";
            this.bt_Pozycjonuj.Size = new System.Drawing.Size(223, 23);
            this.bt_Pozycjonuj.TabIndex = 0;
            this.bt_Pozycjonuj.Text = "Pozycjonuj";
            this.bt_Pozycjonuj.UseVisualStyleBackColor = true;
            this.bt_Pozycjonuj.Click += new System.EventHandler(this.bt_Pozycjonuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pozycja X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pozycja Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prędkość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "X LOOP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Y LOOP";
            // 
            // lbl_PozycjaX
            // 
            this.lbl_PozycjaX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PozycjaX.Location = new System.Drawing.Point(9, 38);
            this.lbl_PozycjaX.Name = "lbl_PozycjaX";
            this.lbl_PozycjaX.Size = new System.Drawing.Size(100, 23);
            this.lbl_PozycjaX.TabIndex = 6;
            // 
            // lbl_PozycjaY
            // 
            this.lbl_PozycjaY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PozycjaY.Location = new System.Drawing.Point(115, 38);
            this.lbl_PozycjaY.Name = "lbl_PozycjaY";
            this.lbl_PozycjaY.Size = new System.Drawing.Size(100, 23);
            this.lbl_PozycjaY.TabIndex = 7;
            // 
            // lbl_speedx
            // 
            this.lbl_speedx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_speedx.Location = new System.Drawing.Point(221, 38);
            this.lbl_speedx.Name = "lbl_speedx";
            this.lbl_speedx.Size = new System.Drawing.Size(100, 23);
            this.lbl_speedx.TabIndex = 8;
            // 
            // lbl_XLOP
            // 
            this.lbl_XLOP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_XLOP.Location = new System.Drawing.Point(329, 38);
            this.lbl_XLOP.Name = "lbl_XLOP";
            this.lbl_XLOP.Size = new System.Drawing.Size(100, 23);
            this.lbl_XLOP.TabIndex = 9;
            // 
            // lbl_YLOP
            // 
            this.lbl_YLOP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_YLOP.Location = new System.Drawing.Point(435, 38);
            this.lbl_YLOP.Name = "lbl_YLOP";
            this.lbl_YLOP.Size = new System.Drawing.Size(100, 23);
            this.lbl_YLOP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "x";
            // 
            // lbl_speedy
            // 
            this.lbl_speedy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_speedy.Location = new System.Drawing.Point(221, 81);
            this.lbl_speedy.Name = "lbl_speedy";
            this.lbl_speedy.Size = new System.Drawing.Size(100, 23);
            this.lbl_speedy.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1500, 1500);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Wiad
            // 
            this.tb_Wiad.Location = new System.Drawing.Point(565, 60);
            this.tb_Wiad.Name = "tb_Wiad";
            this.tb_Wiad.Size = new System.Drawing.Size(181, 20);
            this.tb_Wiad.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Wiad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_speedy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_YLOP);
            this.Controls.Add(this.lbl_XLOP);
            this.Controls.Add(this.lbl_speedx);
            this.Controls.Add(this.lbl_PozycjaY);
            this.Controls.Add(this.lbl_PozycjaX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Pozycjonuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Pozycjonuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_PozycjaX;
        private System.Windows.Forms.Label lbl_PozycjaY;
        private System.Windows.Forms.Label lbl_speedx;
        private System.Windows.Forms.Label lbl_XLOP;
        private System.Windows.Forms.Label lbl_YLOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_speedy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Wiad;
    }
}

