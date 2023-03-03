namespace ObjRec
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
            this.picbox_Original = new System.Windows.Forms.PictureBox();
            this.picbox_Detected = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Wynik = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_maxVal = new System.Windows.Forms.TextBox();
            this.tb_minVal = new System.Windows.Forms.TextBox();
            this.bt_macz = new System.Windows.Forms.Button();
            this.bt_Wykryj = new System.Windows.Forms.Button();
            this.bt_Open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Detected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox_Original
            // 
            this.picbox_Original.Location = new System.Drawing.Point(13, 13);
            this.picbox_Original.Name = "picbox_Original";
            this.picbox_Original.Size = new System.Drawing.Size(344, 313);
            this.picbox_Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_Original.TabIndex = 0;
            this.picbox_Original.TabStop = false;
            // 
            // picbox_Detected
            // 
            this.picbox_Detected.Location = new System.Drawing.Point(43, 3);
            this.picbox_Detected.Name = "picbox_Detected";
            this.picbox_Detected.Size = new System.Drawing.Size(600, 600);
            this.picbox_Detected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_Detected.TabIndex = 1;
            this.picbox_Detected.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.tb_Wynik);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Save);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tb_maxVal);
            this.splitContainer1.Panel1.Controls.Add(this.tb_minVal);
            this.splitContainer1.Panel1.Controls.Add(this.bt_macz);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Wykryj);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Open);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picbox_Detected);
            this.splitContainer1.Size = new System.Drawing.Size(1258, 824);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 2;
            // 
            // tb_Wynik
            // 
            this.tb_Wynik.Location = new System.Drawing.Point(116, 549);
            this.tb_Wynik.Name = "tb_Wynik";
            this.tb_Wynik.Size = new System.Drawing.Size(100, 20);
            this.tb_Wynik.TabIndex = 9;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(141, 470);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 8;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "maxLoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "minLoc";
            // 
            // tb_maxVal
            // 
            this.tb_maxVal.Location = new System.Drawing.Point(72, 401);
            this.tb_maxVal.Name = "tb_maxVal";
            this.tb_maxVal.Size = new System.Drawing.Size(100, 20);
            this.tb_maxVal.TabIndex = 3;
            // 
            // tb_minVal
            // 
            this.tb_minVal.Location = new System.Drawing.Point(72, 375);
            this.tb_minVal.Name = "tb_minVal";
            this.tb_minVal.Size = new System.Drawing.Size(100, 20);
            this.tb_minVal.TabIndex = 2;
            // 
            // bt_macz
            // 
            this.bt_macz.Location = new System.Drawing.Point(141, 332);
            this.bt_macz.Name = "bt_macz";
            this.bt_macz.Size = new System.Drawing.Size(75, 23);
            this.bt_macz.TabIndex = 1;
            this.bt_macz.Text = "macz";
            this.bt_macz.UseVisualStyleBackColor = true;
            this.bt_macz.Click += new System.EventHandler(this.bt_macz_Click);
            // 
            // bt_Wykryj
            // 
            this.bt_Wykryj.Location = new System.Drawing.Point(282, 332);
            this.bt_Wykryj.Name = "bt_Wykryj";
            this.bt_Wykryj.Size = new System.Drawing.Size(75, 23);
            this.bt_Wykryj.TabIndex = 0;
            this.bt_Wykryj.Text = "Wykryj";
            this.bt_Wykryj.UseVisualStyleBackColor = true;
            this.bt_Wykryj.Click += new System.EventHandler(this.bt_Wykryj_Click);
            // 
            // bt_Open
            // 
            this.bt_Open.Location = new System.Drawing.Point(13, 332);
            this.bt_Open.Name = "bt_Open";
            this.bt_Open.Size = new System.Drawing.Size(75, 23);
            this.bt_Open.TabIndex = 0;
            this.bt_Open.Text = "Otwórz";
            this.bt_Open.UseVisualStyleBackColor = true;
            this.bt_Open.Click += new System.EventHandler(this.bt_Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 401);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 824);
            this.Controls.Add(this.picbox_Original);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Detected)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Original;
        private System.Windows.Forms.PictureBox picbox_Detected;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_Open;
        private System.Windows.Forms.Button bt_Wykryj;
        private System.Windows.Forms.Button bt_macz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_maxVal;
        private System.Windows.Forms.TextBox tb_minVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.TextBox tb_Wynik;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

