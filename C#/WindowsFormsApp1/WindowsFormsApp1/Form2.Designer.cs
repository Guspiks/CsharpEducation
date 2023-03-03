namespace WindowsFormsApp1
{
    partial class frm_MenuKamery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bt_SaveShot = new System.Windows.Forms.Button();
            this.bt_OneShot = new System.Windows.Forms.Button();
            this.bt_StopCamera = new System.Windows.Forms.Button();
            this.bt_StartCamera = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Controls.Add(this.bt_SaveShot);
            this.splitContainer1.Panel1.Controls.Add(this.bt_OneShot);
            this.splitContainer1.Panel1.Controls.Add(this.bt_StopCamera);
            this.splitContainer1.Panel1.Controls.Add(this.bt_StartCamera);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(874, 732);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // bt_SaveShot
            // 
            this.bt_SaveShot.Location = new System.Drawing.Point(13, 103);
            this.bt_SaveShot.Name = "bt_SaveShot";
            this.bt_SaveShot.Size = new System.Drawing.Size(111, 23);
            this.bt_SaveShot.TabIndex = 3;
            this.bt_SaveShot.Text = "Zapisz Zdjęcie";
            this.bt_SaveShot.UseVisualStyleBackColor = true;
            // 
            // bt_OneShot
            // 
            this.bt_OneShot.Location = new System.Drawing.Point(13, 73);
            this.bt_OneShot.Name = "bt_OneShot";
            this.bt_OneShot.Size = new System.Drawing.Size(111, 23);
            this.bt_OneShot.TabIndex = 2;
            this.bt_OneShot.Text = "Pojedyńcze Zdjęcie";
            this.bt_OneShot.UseVisualStyleBackColor = true;
            // 
            // bt_StopCamera
            // 
            this.bt_StopCamera.Location = new System.Drawing.Point(13, 43);
            this.bt_StopCamera.Name = "bt_StopCamera";
            this.bt_StopCamera.Size = new System.Drawing.Size(111, 23);
            this.bt_StopCamera.TabIndex = 1;
            this.bt_StopCamera.Text = "Stop";
            this.bt_StopCamera.UseVisualStyleBackColor = true;
            // 
            // bt_StartCamera
            // 
            this.bt_StartCamera.Location = new System.Drawing.Point(13, 13);
            this.bt_StartCamera.Name = "bt_StartCamera";
            this.bt_StartCamera.Size = new System.Drawing.Size(111, 23);
            this.bt_StartCamera.TabIndex = 0;
            this.bt_StartCamera.Text = "Włącz Obraz";
            this.bt_StartCamera.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(111, 211);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frm_MenuKamery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 732);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_MenuKamery";
            this.Text = "Menu Kamery";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_SaveShot;
        private System.Windows.Forms.Button bt_OneShot;
        private System.Windows.Forms.Button bt_StopCamera;
        private System.Windows.Forms.Button bt_StartCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
    }
}