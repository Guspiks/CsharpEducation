namespace imgProcBasic
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
            this.picbox_Computed = new System.Windows.Forms.PictureBox();
            this.bt_Open = new System.Windows.Forms.Button();
            this.bt_Gray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Computed)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_Original
            // 
            this.picbox_Original.Location = new System.Drawing.Point(13, 13);
            this.picbox_Original.Name = "picbox_Original";
            this.picbox_Original.Size = new System.Drawing.Size(309, 313);
            this.picbox_Original.TabIndex = 0;
            this.picbox_Original.TabStop = false;
            // 
            // picbox_Computed
            // 
            this.picbox_Computed.Location = new System.Drawing.Point(469, 13);
            this.picbox_Computed.Name = "picbox_Computed";
            this.picbox_Computed.Size = new System.Drawing.Size(319, 313);
            this.picbox_Computed.TabIndex = 1;
            this.picbox_Computed.TabStop = false;
            // 
            // bt_Open
            // 
            this.bt_Open.Location = new System.Drawing.Point(123, 332);
            this.bt_Open.Name = "bt_Open";
            this.bt_Open.Size = new System.Drawing.Size(75, 23);
            this.bt_Open.TabIndex = 2;
            this.bt_Open.Text = "Open";
            this.bt_Open.UseVisualStyleBackColor = true;
            this.bt_Open.Click += new System.EventHandler(this.bt_Open_Click);
            // 
            // bt_Gray
            // 
            this.bt_Gray.Location = new System.Drawing.Point(595, 332);
            this.bt_Gray.Name = "bt_Gray";
            this.bt_Gray.Size = new System.Drawing.Size(75, 23);
            this.bt_Gray.TabIndex = 3;
            this.bt_Gray.Text = "Gray";
            this.bt_Gray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Gray);
            this.Controls.Add(this.bt_Open);
            this.Controls.Add(this.picbox_Computed);
            this.Controls.Add(this.picbox_Original);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Computed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Original;
        private System.Windows.Forms.PictureBox picbox_Computed;
        private System.Windows.Forms.Button bt_Open;
        private System.Windows.Forms.Button bt_Gray;
    }
}

