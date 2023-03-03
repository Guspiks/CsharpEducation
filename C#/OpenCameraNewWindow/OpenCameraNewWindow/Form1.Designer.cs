namespace OpenCameraNewWindow
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
            this.bt_OpenCamera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_OpenCamera
            // 
            this.bt_OpenCamera.Location = new System.Drawing.Point(272, 147);
            this.bt_OpenCamera.Name = "bt_OpenCamera";
            this.bt_OpenCamera.Size = new System.Drawing.Size(251, 126);
            this.bt_OpenCamera.TabIndex = 0;
            this.bt_OpenCamera.Text = "Otwórz Kamerę";
            this.bt_OpenCamera.UseVisualStyleBackColor = true;
            this.bt_OpenCamera.Click += new System.EventHandler(this.bt_OpenCamera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_OpenCamera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_OpenCamera;
    }
}

