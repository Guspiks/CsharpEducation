namespace sinikiaerotech
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
            this.bt_Connect = new System.Windows.Forms.Button();
            this.chkbx_Connected = new System.Windows.Forms.CheckBox();
            this.grpBox_Axis = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Enabled = new System.Windows.Forms.Label();
            this.lbl_Falut = new System.Windows.Forms.Label();
            this.lbl_Homed = new System.Windows.Forms.Label();
            this.lbl_Speed = new System.Windows.Forms.Label();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_CCW = new System.Windows.Forms.Button();
            this.bt_CW = new System.Windows.Forms.Button();
            this.tb_FrRunSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Disable = new System.Windows.Forms.Button();
            this.bt_Enable = new System.Windows.Forms.Button();
            this.cmb_Axis = new System.Windows.Forms.ComboBox();
            this.grpBox_Error = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Tasks = new System.Windows.Forms.ComboBox();
            this.lbl_State = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_PrgmStop = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_ErrClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ErrorMsg = new System.Windows.Forms.Label();
            this.grpBox_Axis.SuspendLayout();
            this.grpBox_Error.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(13, 13);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(75, 23);
            this.bt_Connect.TabIndex = 0;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // chkbx_Connected
            // 
            this.chkbx_Connected.AutoCheck = false;
            this.chkbx_Connected.AutoSize = true;
            this.chkbx_Connected.Location = new System.Drawing.Point(95, 18);
            this.chkbx_Connected.Name = "chkbx_Connected";
            this.chkbx_Connected.Size = new System.Drawing.Size(84, 17);
            this.chkbx_Connected.TabIndex = 1;
            this.chkbx_Connected.Text = "Connected?";
            this.chkbx_Connected.UseVisualStyleBackColor = true;
            // 
            // grpBox_Axis
            // 
            this.grpBox_Axis.Controls.Add(this.label14);
            this.grpBox_Axis.Controls.Add(this.label13);
            this.grpBox_Axis.Controls.Add(this.label12);
            this.grpBox_Axis.Controls.Add(this.label11);
            this.grpBox_Axis.Controls.Add(this.label10);
            this.grpBox_Axis.Controls.Add(this.lbl_Enabled);
            this.grpBox_Axis.Controls.Add(this.lbl_Falut);
            this.grpBox_Axis.Controls.Add(this.lbl_Homed);
            this.grpBox_Axis.Controls.Add(this.lbl_Speed);
            this.grpBox_Axis.Controls.Add(this.lbl_Position);
            this.grpBox_Axis.Controls.Add(this.label3);
            this.grpBox_Axis.Controls.Add(this.bt_CCW);
            this.grpBox_Axis.Controls.Add(this.bt_CW);
            this.grpBox_Axis.Controls.Add(this.tb_FrRunSpeed);
            this.grpBox_Axis.Controls.Add(this.label2);
            this.grpBox_Axis.Controls.Add(this.label1);
            this.grpBox_Axis.Controls.Add(this.bt_Disable);
            this.grpBox_Axis.Controls.Add(this.bt_Enable);
            this.grpBox_Axis.Controls.Add(this.cmb_Axis);
            this.grpBox_Axis.Location = new System.Drawing.Point(13, 43);
            this.grpBox_Axis.Name = "grpBox_Axis";
            this.grpBox_Axis.Size = new System.Drawing.Size(775, 117);
            this.grpBox_Axis.TabIndex = 2;
            this.grpBox_Axis.TabStop = false;
            this.grpBox_Axis.Text = "Axis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(479, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Fault";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Homed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(465, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Enabled";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Speed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Position";
            // 
            // lbl_Enabled
            // 
            this.lbl_Enabled.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Enabled.Location = new System.Drawing.Point(515, 23);
            this.lbl_Enabled.Name = "lbl_Enabled";
            this.lbl_Enabled.Size = new System.Drawing.Size(54, 17);
            this.lbl_Enabled.TabIndex = 17;
            // 
            // lbl_Falut
            // 
            this.lbl_Falut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Falut.Location = new System.Drawing.Point(515, 83);
            this.lbl_Falut.Name = "lbl_Falut";
            this.lbl_Falut.Size = new System.Drawing.Size(54, 17);
            this.lbl_Falut.TabIndex = 16;
            // 
            // lbl_Homed
            // 
            this.lbl_Homed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Homed.Location = new System.Drawing.Point(515, 53);
            this.lbl_Homed.Name = "lbl_Homed";
            this.lbl_Homed.Size = new System.Drawing.Size(54, 17);
            this.lbl_Homed.TabIndex = 15;
            // 
            // lbl_Speed
            // 
            this.lbl_Speed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Speed.Location = new System.Drawing.Point(372, 83);
            this.lbl_Speed.Name = "lbl_Speed";
            this.lbl_Speed.Size = new System.Drawing.Size(54, 17);
            this.lbl_Speed.TabIndex = 14;
            // 
            // lbl_Position
            // 
            this.lbl_Position.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Position.Location = new System.Drawing.Point(372, 51);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(54, 17);
            this.lbl_Position.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Axis State";
            // 
            // bt_CCW
            // 
            this.bt_CCW.Location = new System.Drawing.Point(204, 77);
            this.bt_CCW.Name = "bt_CCW";
            this.bt_CCW.Size = new System.Drawing.Size(43, 23);
            this.bt_CCW.TabIndex = 7;
            this.bt_CCW.Text = "CCW";
            this.bt_CCW.UseVisualStyleBackColor = true;
            this.bt_CCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_CCW_MouseDown);
            this.bt_CCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_CCW_MouseUp);
            // 
            // bt_CW
            // 
            this.bt_CW.Location = new System.Drawing.Point(161, 77);
            this.bt_CW.Name = "bt_CW";
            this.bt_CW.Size = new System.Drawing.Size(40, 23);
            this.bt_CW.TabIndex = 6;
            this.bt_CW.Text = "CW";
            this.bt_CW.UseVisualStyleBackColor = true;
            this.bt_CW.Click += new System.EventHandler(this.bt_CW_Click);
            this.bt_CW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_CW_MouseDown);
            this.bt_CW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_CW_MouseUp);
            // 
            // tb_FrRunSpeed
            // 
            this.tb_FrRunSpeed.Location = new System.Drawing.Point(208, 44);
            this.tb_FrRunSpeed.Name = "tb_FrRunSpeed";
            this.tb_FrRunSpeed.Size = new System.Drawing.Size(39, 20);
            this.tb_FrRunSpeed.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Freerun";
            // 
            // bt_Disable
            // 
            this.bt_Disable.Location = new System.Drawing.Point(45, 77);
            this.bt_Disable.Name = "bt_Disable";
            this.bt_Disable.Size = new System.Drawing.Size(75, 23);
            this.bt_Disable.TabIndex = 2;
            this.bt_Disable.Text = "Disable";
            this.bt_Disable.UseVisualStyleBackColor = true;
            this.bt_Disable.Click += new System.EventHandler(this.bt_Disable_Click);
            // 
            // bt_Enable
            // 
            this.bt_Enable.Location = new System.Drawing.Point(45, 47);
            this.bt_Enable.Name = "bt_Enable";
            this.bt_Enable.Size = new System.Drawing.Size(75, 23);
            this.bt_Enable.TabIndex = 1;
            this.bt_Enable.Text = "Enable";
            this.bt_Enable.UseVisualStyleBackColor = true;
            this.bt_Enable.Click += new System.EventHandler(this.bt_Enable_Click);
            // 
            // cmb_Axis
            // 
            this.cmb_Axis.FormattingEnabled = true;
            this.cmb_Axis.Location = new System.Drawing.Point(45, 19);
            this.cmb_Axis.Name = "cmb_Axis";
            this.cmb_Axis.Size = new System.Drawing.Size(75, 21);
            this.cmb_Axis.TabIndex = 0;
            this.cmb_Axis.SelectedIndexChanged += new System.EventHandler(this.cmb_Axis_SelectedIndexChanged);
            // 
            // grpBox_Error
            // 
            this.grpBox_Error.Controls.Add(this.label7);
            this.grpBox_Error.Controls.Add(this.cmb_Tasks);
            this.grpBox_Error.Controls.Add(this.lbl_State);
            this.grpBox_Error.Controls.Add(this.label4);
            this.grpBox_Error.Controls.Add(this.bt_PrgmStop);
            this.grpBox_Error.Controls.Add(this.label6);
            this.grpBox_Error.Controls.Add(this.bt_ErrClear);
            this.grpBox_Error.Controls.Add(this.label5);
            this.grpBox_Error.Controls.Add(this.lbl_ErrorMsg);
            this.grpBox_Error.Location = new System.Drawing.Point(13, 167);
            this.grpBox_Error.Name = "grpBox_Error";
            this.grpBox_Error.Size = new System.Drawing.Size(775, 142);
            this.grpBox_Error.TabIndex = 3;
            this.grpBox_Error.TabStop = false;
            this.grpBox_Error.Text = "Error";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tasks";
            // 
            // cmb_Tasks
            // 
            this.cmb_Tasks.FormattingEnabled = true;
            this.cmb_Tasks.Location = new System.Drawing.Point(99, 33);
            this.cmb_Tasks.Name = "cmb_Tasks";
            this.cmb_Tasks.Size = new System.Drawing.Size(84, 21);
            this.cmb_Tasks.TabIndex = 7;
            this.cmb_Tasks.SelectedIndexChanged += new System.EventHandler(this.cmb_Tasks_SelectedIndexChanged);
            // 
            // lbl_State
            // 
            this.lbl_State.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_State.Location = new System.Drawing.Point(204, 35);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(565, 20);
            this.lbl_State.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "State";
            // 
            // bt_PrgmStop
            // 
            this.bt_PrgmStop.Location = new System.Drawing.Point(6, 32);
            this.bt_PrgmStop.Name = "bt_PrgmStop";
            this.bt_PrgmStop.Size = new System.Drawing.Size(75, 23);
            this.bt_PrgmStop.TabIndex = 4;
            this.bt_PrgmStop.Text = "Stop";
            this.bt_PrgmStop.UseVisualStyleBackColor = true;
            this.bt_PrgmStop.Click += new System.EventHandler(this.bt_PrgmStop_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Program Stop";
            // 
            // bt_ErrClear
            // 
            this.bt_ErrClear.Location = new System.Drawing.Point(6, 108);
            this.bt_ErrClear.Name = "bt_ErrClear";
            this.bt_ErrClear.Size = new System.Drawing.Size(75, 23);
            this.bt_ErrClear.TabIndex = 2;
            this.bt_ErrClear.Text = "Clear";
            this.bt_ErrClear.UseVisualStyleBackColor = true;
            this.bt_ErrClear.Click += new System.EventHandler(this.bt_ErrClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Error Message";
            // 
            // lbl_ErrorMsg
            // 
            this.lbl_ErrorMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ErrorMsg.Location = new System.Drawing.Point(6, 84);
            this.lbl_ErrorMsg.Name = "lbl_ErrorMsg";
            this.lbl_ErrorMsg.Size = new System.Drawing.Size(763, 20);
            this.lbl_ErrorMsg.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpBox_Error);
            this.Controls.Add(this.grpBox_Axis);
            this.Controls.Add(this.chkbx_Connected);
            this.Controls.Add(this.bt_Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox_Axis.ResumeLayout(false);
            this.grpBox_Axis.PerformLayout();
            this.grpBox_Error.ResumeLayout(false);
            this.grpBox_Error.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.CheckBox chkbx_Connected;
        private System.Windows.Forms.GroupBox grpBox_Axis;
        private System.Windows.Forms.Button bt_CCW;
        private System.Windows.Forms.Button bt_CW;
        private System.Windows.Forms.TextBox tb_FrRunSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Disable;
        private System.Windows.Forms.Button bt_Enable;
        private System.Windows.Forms.ComboBox cmb_Axis;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Enabled;
        private System.Windows.Forms.Label lbl_Falut;
        private System.Windows.Forms.Label lbl_Homed;
        private System.Windows.Forms.Label lbl_Speed;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBox_Error;
        private System.Windows.Forms.Button bt_PrgmStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_ErrClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ErrorMsg;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Tasks;
    }
}

