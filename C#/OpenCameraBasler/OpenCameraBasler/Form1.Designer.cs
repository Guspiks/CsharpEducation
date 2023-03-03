namespace OpenCameraBasler
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
            this.bt_Get = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Parametry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Get
            // 
            this.bt_Get.Location = new System.Drawing.Point(587, 173);
            this.bt_Get.Name = "bt_Get";
            this.bt_Get.Size = new System.Drawing.Size(75, 23);
            this.bt_Get.TabIndex = 0;
            this.bt_Get.Text = "Get";
            this.bt_Get.UseVisualStyleBackColor = true;
            this.bt_Get.Click += new System.EventHandler(this.bt_Get_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Get Camera Parameters";
            // 
            // tb_Parametry
            // 
            this.tb_Parametry.Location = new System.Drawing.Point(13, 13);
            this.tb_Parametry.Multiline = true;
            this.tb_Parametry.Name = "tb_Parametry";
            this.tb_Parametry.ReadOnly = true;
            this.tb_Parametry.Size = new System.Drawing.Size(526, 425);
            this.tb_Parametry.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Parametry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Get);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Parametry;
        private System.Windows.Forms.Button button1;
    }
}

