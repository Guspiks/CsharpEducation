namespace wykrywaniekształtu
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Wiad = new System.Windows.Forms.TextBox();
            this.bt_wykryj = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_conshot = new System.Windows.Forms.Button();
            this.bt_oneshot = new System.Windows.Forms.Button();
            this.bt_dis = new System.Windows.Forms.Button();
            this.bt_con = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Wiad);
            this.splitContainer1.Panel1.Controls.Add(this.bt_wykryj);
            this.splitContainer1.Panel1.Controls.Add(this.bt_stop);
            this.splitContainer1.Panel1.Controls.Add(this.bt_conshot);
            this.splitContainer1.Panel1.Controls.Add(this.bt_oneshot);
            this.splitContainer1.Panel1.Controls.Add(this.bt_dis);
            this.splitContainer1.Panel1.Controls.Add(this.bt_con);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 807);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 0;
            // 
            // tb_Wiad
            // 
            this.tb_Wiad.Location = new System.Drawing.Point(13, 369);
            this.tb_Wiad.Multiline = true;
            this.tb_Wiad.Name = "tb_Wiad";
            this.tb_Wiad.Size = new System.Drawing.Size(75, 69);
            this.tb_Wiad.TabIndex = 6;
            // 
            // bt_wykryj
            // 
            this.bt_wykryj.Location = new System.Drawing.Point(13, 161);
            this.bt_wykryj.Name = "bt_wykryj";
            this.bt_wykryj.Size = new System.Drawing.Size(75, 201);
            this.bt_wykryj.TabIndex = 5;
            this.bt_wykryj.Text = "wykrywaj";
            this.bt_wykryj.UseVisualStyleBackColor = true;
            this.bt_wykryj.Click += new System.EventHandler(this.bt_wykryj_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(13, 131);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 4;
            this.bt_stop.Text = "stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_conshot
            // 
            this.bt_conshot.Location = new System.Drawing.Point(13, 101);
            this.bt_conshot.Name = "bt_conshot";
            this.bt_conshot.Size = new System.Drawing.Size(75, 23);
            this.bt_conshot.TabIndex = 3;
            this.bt_conshot.Text = "con shot";
            this.bt_conshot.UseVisualStyleBackColor = true;
            this.bt_conshot.Click += new System.EventHandler(this.bt_conshot_Click);
            // 
            // bt_oneshot
            // 
            this.bt_oneshot.Location = new System.Drawing.Point(13, 71);
            this.bt_oneshot.Name = "bt_oneshot";
            this.bt_oneshot.Size = new System.Drawing.Size(75, 23);
            this.bt_oneshot.TabIndex = 2;
            this.bt_oneshot.Text = "one shot";
            this.bt_oneshot.UseVisualStyleBackColor = true;
            this.bt_oneshot.Click += new System.EventHandler(this.bt_oneshot_Click);
            // 
            // bt_dis
            // 
            this.bt_dis.Location = new System.Drawing.Point(13, 42);
            this.bt_dis.Name = "bt_dis";
            this.bt_dis.Size = new System.Drawing.Size(75, 23);
            this.bt_dis.TabIndex = 1;
            this.bt_dis.Text = "dis";
            this.bt_dis.UseVisualStyleBackColor = true;
            this.bt_dis.Click += new System.EventHandler(this.bt_dis_Click);
            // 
            // bt_con
            // 
            this.bt_con.Location = new System.Drawing.Point(13, 13);
            this.bt_con.Name = "bt_con";
            this.bt_con.Size = new System.Drawing.Size(75, 23);
            this.bt_con.TabIndex = 0;
            this.bt_con.Text = "con";
            this.bt_con.UseVisualStyleBackColor = true;
            this.bt_con.Click += new System.EventHandler(this.bt_con_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 807);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_dis;
        private System.Windows.Forms.Button bt_con;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_conshot;
        private System.Windows.Forms.Button bt_oneshot;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_wykryj;
        private System.Windows.Forms.TextBox tb_Wiad;
    }
}

