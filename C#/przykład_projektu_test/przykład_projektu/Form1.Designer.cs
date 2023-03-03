namespace przykład_projektu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_X_Value_Plus = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_Wyjscie = new System.Windows.Forms.TextBox();
            this.bt_Start_Pos_XY = new System.Windows.Forms.Button();
            this.bt_Start_Pos_Z = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_View_Camera = new System.Windows.Forms.Button();
            this.tb_Zvalue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Z_Value_Minus = new System.Windows.Forms.Button();
            this.bt_Z_Value_Plus = new System.Windows.Forms.Button();
            this.tb_Yvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Y_Value_Minus = new System.Windows.Forms.Button();
            this.bt_Y_Value_Plus = new System.Windows.Forms.Button();
            this.tb_Xvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_X_Value_Minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ręczne sterowanie serwomotorami";
            // 
            // bt_X_Value_Plus
            // 
            this.bt_X_Value_Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_X_Value_Plus.Location = new System.Drawing.Point(236, 52);
            this.bt_X_Value_Plus.Name = "bt_X_Value_Plus";
            this.bt_X_Value_Plus.Size = new System.Drawing.Size(75, 23);
            this.bt_X_Value_Plus.TabIndex = 1;
            this.bt_X_Value_Plus.Text = "+";
            this.bt_X_Value_Plus.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_Wyjscie);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Start_Pos_XY);
            this.splitContainer1.Panel1.Controls.Add(this.bt_Start_Pos_Z);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_View_Camera);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Zvalue);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Z_Value_Minus);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Z_Value_Plus);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Yvalue);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Y_Value_Minus);
            this.splitContainer1.Panel2.Controls.Add(this.bt_Y_Value_Plus);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Xvalue);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.bt_X_Value_Minus);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.bt_X_Value_Plus);
            this.splitContainer1.Size = new System.Drawing.Size(797, 436);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.TabIndex = 2;
            // 
            // tb_Wyjscie
            // 
            this.tb_Wyjscie.Location = new System.Drawing.Point(9, 109);
            this.tb_Wyjscie.Multiline = true;
            this.tb_Wyjscie.Name = "tb_Wyjscie";
            this.tb_Wyjscie.Size = new System.Drawing.Size(357, 255);
            this.tb_Wyjscie.TabIndex = 3;
            this.tb_Wyjscie.Text = "Okno tekstowo-wyjściowe";
            // 
            // bt_Start_Pos_XY
            // 
            this.bt_Start_Pos_XY.Location = new System.Drawing.Point(195, 51);
            this.bt_Start_Pos_XY.Name = "bt_Start_Pos_XY";
            this.bt_Start_Pos_XY.Size = new System.Drawing.Size(171, 52);
            this.bt_Start_Pos_XY.TabIndex = 2;
            this.bt_Start_Pos_XY.Text = "Pozycjonowanie w osi X i Y";
            this.bt_Start_Pos_XY.UseVisualStyleBackColor = true;
            // 
            // bt_Start_Pos_Z
            // 
            this.bt_Start_Pos_Z.Location = new System.Drawing.Point(9, 51);
            this.bt_Start_Pos_Z.Name = "bt_Start_Pos_Z";
            this.bt_Start_Pos_Z.Size = new System.Drawing.Size(171, 52);
            this.bt_Start_Pos_Z.TabIndex = 1;
            this.bt_Start_Pos_Z.Text = "Pozycjonowanie w osi Z";
            this.bt_Start_Pos_Z.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Automatyczne pozycjonowanie stołu";
            // 
            // bt_View_Camera
            // 
            this.bt_View_Camera.Location = new System.Drawing.Point(30, 301);
            this.bt_View_Camera.Name = "bt_View_Camera";
            this.bt_View_Camera.Size = new System.Drawing.Size(281, 63);
            this.bt_View_Camera.TabIndex = 13;
            this.bt_View_Camera.Text = "Pokaż Kamerę";
            this.bt_View_Camera.UseVisualStyleBackColor = true;
            // 
            // tb_Zvalue
            // 
            this.tb_Zvalue.Location = new System.Drawing.Point(76, 231);
            this.tb_Zvalue.Name = "tb_Zvalue";
            this.tb_Zvalue.Size = new System.Drawing.Size(154, 23);
            this.tb_Zvalue.TabIndex = 12;
            this.tb_Zvalue.Text = "Wartość w osi Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Z";
            // 
            // bt_Z_Value_Minus
            // 
            this.bt_Z_Value_Minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Z_Value_Minus.Location = new System.Drawing.Point(236, 247);
            this.bt_Z_Value_Minus.Name = "bt_Z_Value_Minus";
            this.bt_Z_Value_Minus.Size = new System.Drawing.Size(75, 23);
            this.bt_Z_Value_Minus.TabIndex = 10;
            this.bt_Z_Value_Minus.Text = "-\r\n";
            this.bt_Z_Value_Minus.UseVisualStyleBackColor = true;
            this.bt_Z_Value_Minus.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt_Z_Value_Plus
            // 
            this.bt_Z_Value_Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Z_Value_Plus.Location = new System.Drawing.Point(236, 218);
            this.bt_Z_Value_Plus.Name = "bt_Z_Value_Plus";
            this.bt_Z_Value_Plus.Size = new System.Drawing.Size(75, 23);
            this.bt_Z_Value_Plus.TabIndex = 9;
            this.bt_Z_Value_Plus.Text = "+";
            this.bt_Z_Value_Plus.UseVisualStyleBackColor = true;
            this.bt_Z_Value_Plus.Click += new System.EventHandler(this.bt_Z_Value_Plus_Click);
            // 
            // tb_Yvalue
            // 
            this.tb_Yvalue.Location = new System.Drawing.Point(76, 148);
            this.tb_Yvalue.Name = "tb_Yvalue";
            this.tb_Yvalue.Size = new System.Drawing.Size(154, 23);
            this.tb_Yvalue.TabIndex = 8;
            this.tb_Yvalue.Text = "Wartość w osi Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // bt_Y_Value_Minus
            // 
            this.bt_Y_Value_Minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Y_Value_Minus.Location = new System.Drawing.Point(236, 164);
            this.bt_Y_Value_Minus.Name = "bt_Y_Value_Minus";
            this.bt_Y_Value_Minus.Size = new System.Drawing.Size(75, 23);
            this.bt_Y_Value_Minus.TabIndex = 6;
            this.bt_Y_Value_Minus.Text = "-";
            this.bt_Y_Value_Minus.UseVisualStyleBackColor = true;
            // 
            // bt_Y_Value_Plus
            // 
            this.bt_Y_Value_Plus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Y_Value_Plus.Location = new System.Drawing.Point(236, 135);
            this.bt_Y_Value_Plus.Name = "bt_Y_Value_Plus";
            this.bt_Y_Value_Plus.Size = new System.Drawing.Size(75, 23);
            this.bt_Y_Value_Plus.TabIndex = 5;
            this.bt_Y_Value_Plus.Text = "+";
            this.bt_Y_Value_Plus.UseVisualStyleBackColor = true;
            // 
            // tb_Xvalue
            // 
            this.tb_Xvalue.Location = new System.Drawing.Point(76, 65);
            this.tb_Xvalue.Name = "tb_Xvalue";
            this.tb_Xvalue.Size = new System.Drawing.Size(154, 23);
            this.tb_Xvalue.TabIndex = 4;
            this.tb_Xvalue.Text = "Wartość w osi X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // bt_X_Value_Minus
            // 
            this.bt_X_Value_Minus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_X_Value_Minus.Location = new System.Drawing.Point(236, 81);
            this.bt_X_Value_Minus.Name = "bt_X_Value_Minus";
            this.bt_X_Value_Minus.Size = new System.Drawing.Size(75, 23);
            this.bt_X_Value_Minus.TabIndex = 2;
            this.bt_X_Value_Minus.Text = "-";
            this.bt_X_Value_Minus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button bt_X_Value_Plus;
        private SplitContainer splitContainer1;
        private TextBox tb_Zvalue;
        private Label label4;
        private Button bt_Z_Value_Minus;
        private Button bt_Z_Value_Plus;
        private TextBox tb_Yvalue;
        private Label label3;
        private Button bt_Y_Value_Minus;
        private Button bt_Y_Value_Plus;
        private TextBox tb_Xvalue;
        private Label label2;
        private Button bt_X_Value_Minus;
        private TextBox tb_Wyjscie;
        private Button bt_Start_Pos_XY;
        private Button bt_Start_Pos_Z;
        protected Label label5;
        private Button bt_View_Camera;
    }
}