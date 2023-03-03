using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Aerotech.A3200;
using Aerotech.A3200.Exceptions;
using Aerotech.A3200.Status;
using Aerotech.A3200.Variables;
using Aerotech.A3200.Tasks;
using Aerotech.A3200.Information;
using Aerotech.Common;
using Aerotech.Common.Collections;

namespace sinikiaerotech
{
    public partial class Form1 : Form
    {
        private Controller myController;
        int axisIndex;
        int taskIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chkbx_Connected.Checked = false;
            EnableControls(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Disconnect();
        }


        #region Funkcje
        //Odblokowanie funkcji
        private void EnableControls(bool enable)
        {
            grpBox_Axis.Enabled = enable;
            grpBox_Error.Enabled = enable;
        }

        private void SetTaskState(NewTaskStatesArrivedEventArgs e)
        {
            lbl_State.Text = e.TaskStates[this.taskIndex].ToString();
        }

        private void SetAxisState(NewDiagPacketArrivedEventArgs e)
        {
            lbl_Enabled.Text=e.Data[this.axisIndex].DriveStatus.Enabled.ToString();
            lbl_Homed.Text=e.Data[this.axisIndex].AxisStatus.Homed.ToString();
            lbl_Falut.Text=(!e.Data[this.axisIndex].AxisFault.None).ToString();
            lbl_Position.Text=e.Data[this.axisIndex].PositionFeedback.ToString();
            lbl_Speed.Text=e.Data[this.axisIndex].VelocityFeedback.ToString();
        }

        #endregion Funkcje

        #region WindowsEvents

        private void bt_CW_Click(object sender, EventArgs e)
        {

        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //Połączenie do A3200 contorler
                this.myController=Controller.Connect();
                chkbx_Connected.Checked=true;
                EnableControls(true);

                //dodajemy pozycje do cmb_axis
                foreach(AxisInfo axis in this.myController.Information.Axes)
                {
                    cmb_Axis.Items.Add(axis.Name);
                }
                this.axisIndex=0;
                cmb_Axis.SelectedIndex=this.axisIndex;

                //dodajemy pozycje do task names
                foreach (Task task in this.myController.Tasks)
                {
                    if(task.State!= TaskState.Inactive)
                    {
                        cmb_Tasks.Items.Add(task.Name.ToString());
                    }
                }
                //Task 0 jest zarezerwowany
                this.taskIndex=1;
                cmb_Tasks.SelectedIndex=this.taskIndex-1;

                //rejestrujemy stany task i diagPacket i ich eventy
                this.myController.ControlCenter.TaskStates.NewTaskStatesArrived += new EventHandler<NewTaskStatesArrivedEventArgs>(TaskStates_NewTasklStatesArrived);
                this.myController.ControlCenter.Diagnostics.NewDiagPacketArrived += new EventHandler<NewDiagPacketArrivedEventArgs>(Diagnostics_NewDiagPacketArrived);
            }
            catch (A3200Exception exeption)
            {
                lbl_ErrorMsg.Text=exeption.Message;
            }
        }

        private void bt_Enable_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Enable();
            }
            catch(A3200Exception exeption)
            {
                lbl_ErrorMsg.Text= exeption.Message;
            }
        }

        private void bt_Disable_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Axes[this.axisIndex].Motion.Disable();
            }
            catch (A3200Exception exeption)
            {
                lbl_ErrorMsg.Text = exeption.Message;
            }
        }

        private void cmb_Axis_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axisIndex = cmb_Axis.SelectedIndex;
        }

        private void cmb_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.taskIndex = cmb_Tasks.SelectedIndex+1;
        }

        private void bt_PrgmStop_Click(object sender, EventArgs e)
        {
            try
            {
                this.myController.Tasks[this.taskIndex].Program.Stop();
            }
            catch(A3200Exception exception)
            {
                lbl_ErrorMsg.Text= exception.Message;
            }
        }

        private void bt_ErrClear_Click(object sender, EventArgs e)
        {
            lbl_ErrorMsg.Text = "";
        }

        private void bt_CW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, double.Parse(tb_FrRunSpeed.Text));
            }
            catch(A3200Exception exception)
            {
                lbl_ErrorMsg.Text=exception.Message;
            }
        }

        private void bt_CW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMsg.Text = exception.Message;
            }
        }

        private void bt_CCW_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, -double.Parse(tb_FrRunSpeed.Text));
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMsg.Text = exception.Message;
            }
        }

        private void bt_CCW_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.myController.Commands[this.taskIndex].Motion.FreeRun(this.axisIndex, 0);
            }
            catch (A3200Exception exception)
            {
                lbl_ErrorMsg.Text = exception.Message;
            }
        }
        #endregion WindowsEvents

        #region ControllerEvents
        private void TaskStates_NewTasklStatesArrived(object sender, NewTaskStatesArrivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action<NewTaskStatesArrivedEventArgs>(SetTaskState), e);
            }
            catch
            {
            }
        }
        
        private void Diagnostics_NewDiagPacketArrived(object sender, NewDiagPacketArrivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action<NewDiagPacketArrivedEventArgs>(SetAxisState), e);
            }
            catch
            { 
            }
        }
        #endregion ControllerEvents
    }
}