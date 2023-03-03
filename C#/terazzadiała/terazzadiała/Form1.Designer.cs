namespace terazzadiała
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
            this.components = new System.ComponentModel.Container();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_OneShot = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.lv_Device = new System.Windows.Forms.ListView();
            this.updateDeviceListTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bt_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(12, 35);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(182, 23);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "Szukaj Kamer";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(12, 64);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(182, 23);
            this.bt_Start.TabIndex = 1;
            this.bt_Start.Text = "Włącz Kamerę";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_OneShot
            // 
            this.bt_OneShot.Location = new System.Drawing.Point(12, 122);
            this.bt_OneShot.Name = "bt_OneShot";
            this.bt_OneShot.Size = new System.Drawing.Size(182, 23);
            this.bt_OneShot.TabIndex = 3;
            this.bt_OneShot.Text = "Pojedyńcze zdjęcie";
            this.bt_OneShot.UseVisualStyleBackColor = true;
            this.bt_OneShot.Click += new System.EventHandler(this.bt_OneShot_Click);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(12, 93);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(182, 23);
            this.bt_Stop.TabIndex = 4;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // lv_Device
            // 
            this.lv_Device.HideSelection = false;
            this.lv_Device.Location = new System.Drawing.Point(12, 181);
            this.lv_Device.MultiSelect = false;
            this.lv_Device.Name = "lv_Device";
            this.lv_Device.ShowItemToolTips = true;
            this.lv_Device.Size = new System.Drawing.Size(182, 155);
            this.lv_Device.TabIndex = 0;
            this.lv_Device.UseCompatibleStateImageBehavior = false;
            this.lv_Device.View = System.Windows.Forms.View.Tile;
            this.lv_Device.SelectedIndexChanged += new System.EventHandler(this.lv_Device_SelectedIndexChanged);
            this.lv_Device.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lv_Device_KeyDown);
            // 
            // updateDeviceListTimer
            // 
            this.updateDeviceListTimer.Tick += new System.EventHandler(this.updateDeviceListTimer_Tick);
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
            this.splitContainer1.Panel1.Controls.Add(this.bt_Save);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Connect);
            this.splitContainer1.Panel1.Controls.Add(this.lv_Device);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Start);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Stop);
            this.splitContainer1.Panel1.Controls.Add(this.bt_OneShot);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 5;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(12, 152);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(182, 23);
            this.bt_Save.TabIndex = 5;
            this.bt_Save.Text = "Zapisz";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_OneShot;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.ListView lv_Device;
        private System.Windows.Forms.Timer updateDeviceListTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_Save;
    }
}

