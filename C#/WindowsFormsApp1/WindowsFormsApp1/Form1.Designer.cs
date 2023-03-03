namespace WindowsFormsApp1
{
    partial class frm_AutoPosition
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
            this.bt_OpenMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brpbx_Kamera = new System.Windows.Forms.GroupBox();
            this.brpbx_Kamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_OpenMenu
            // 
            this.bt_OpenMenu.Location = new System.Drawing.Point(6, 32);
            this.bt_OpenMenu.Name = "bt_OpenMenu";
            this.bt_OpenMenu.Size = new System.Drawing.Size(204, 23);
            this.bt_OpenMenu.TabIndex = 1;
            this.bt_OpenMenu.Text = "Otwórz";
            this.bt_OpenMenu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otwórz Menu Kamery";
            // 
            // brpbx_Kamera
            // 
            this.brpbx_Kamera.Controls.Add(this.bt_OpenMenu);
            this.brpbx_Kamera.Controls.Add(this.label1);
            this.brpbx_Kamera.Location = new System.Drawing.Point(567, 12);
            this.brpbx_Kamera.Name = "brpbx_Kamera";
            this.brpbx_Kamera.Size = new System.Drawing.Size(221, 66);
            this.brpbx_Kamera.TabIndex = 4;
            this.brpbx_Kamera.TabStop = false;
            this.brpbx_Kamera.Text = "Kamera";
            // 
            // frm_AutoPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brpbx_Kamera);
            this.Name = "frm_AutoPosition";
            this.Text = "Automatyczne Pozycjonowanie";
            this.brpbx_Kamera.ResumeLayout(false);
            this.brpbx_Kamera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_OpenMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox brpbx_Kamera;
    }
}

