namespace OpenCameraNewWindow
{
    partial class Form2
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
            this.bt_CloseCamera = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCameraDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCameraResolution = new System.Windows.Forms.ComboBox();
            this.bt_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_CloseCamera
            // 
            this.bt_CloseCamera.Location = new System.Drawing.Point(12, 379);
            this.bt_CloseCamera.Name = "bt_CloseCamera";
            this.bt_CloseCamera.Size = new System.Drawing.Size(776, 59);
            this.bt_CloseCamera.TabIndex = 0;
            this.bt_CloseCamera.Text = "Zamknij Kamerę";
            this.bt_CloseCamera.UseVisualStyleBackColor = true;
            this.bt_CloseCamera.Click += new System.EventHandler(this.bt_CloseCamera_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 361);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbCameraDevices
            // 
            this.cmbCameraDevices.FormattingEnabled = true;
            this.cmbCameraDevices.Location = new System.Drawing.Point(551, 41);
            this.cmbCameraDevices.Name = "cmbCameraDevices";
            this.cmbCameraDevices.Size = new System.Drawing.Size(237, 21);
            this.cmbCameraDevices.TabIndex = 2;
            this.cmbCameraDevices.SelectedIndexChanged += new System.EventHandler(this.cmbCameraDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kamera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rozdzielczość";
            // 
            // cmbCameraResolution
            // 
            this.cmbCameraResolution.FormattingEnabled = true;
            this.cmbCameraResolution.Location = new System.Drawing.Point(551, 99);
            this.cmbCameraResolution.Name = "cmbCameraResolution";
            this.cmbCameraResolution.Size = new System.Drawing.Size(237, 21);
            this.cmbCameraResolution.TabIndex = 4;
            this.cmbCameraResolution.SelectedIndexChanged += new System.EventHandler(this.cmbCameraResolution_SelectedIndexChanged);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(551, 150);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(237, 23);
            this.bt_Save.TabIndex = 6;
            this.bt_Save.Text = "Zapisz";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCameraResolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCameraDevices);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_CloseCamera);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_CloseCamera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCameraDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCameraResolution;
        private System.Windows.Forms.Button bt_Save;
    }
}