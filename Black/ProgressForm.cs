using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Black
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            th = new Thread(new ThreadStart(ShowForm));
            th.Start();
        }
        public static bool status = true;
        private Thread th = null;
        public void UpdateProgress(string Message, int progress, Int16 CurrentStep, Int16 TotalStep)
        {
            if (PRG_PROCESS.InvokeRequired)
            {
                int percent = (100 * progress) / PRG_PROCESS.Maximum;
                PRG_PROCESS.BeginInvoke(new Action(() => PRG_PROCESS.Value = progress));
                PRG_PROCESS.BeginInvoke(new Action(() => LBL_TITLE.Text = Message + " " + percent.ToString() + "%"));
                PRG_PROCESS.BeginInvoke(new Action(() => LBL_STEP.Text = CurrentStep.ToString() + "/" + TotalStep.ToString()));
            }
            else
                PRG_PROCESS.Value = progress;
        }

        public void ResetProgress()
        {
            PRG_PROCESS.BeginInvoke(new Action(() => PRG_PROCESS.Value = 0));
        }

        ////public void SetMinMax(Int32 Min, Int32 Max)
        ////{
        ////    if (PRG_PROCESS.InvokeRequired)
        ////    {
        ////        PRG_PROCESS.BeginInvoke(new Action(() => PRG_PROCESS.Minimum = Min));
        ////        PRG_PROCESS.BeginInvoke(new Action(() => PRG_PROCESS.Maximum = Max));
        ////    }
        ////}

        public delegate void setminm(Int32 Min, Int32 Max);
        public void setMinMax(Int32 Min, Int32 Max)
        {
            if (InvokeRequired)
                Invoke(new setminm(setMinMax), Min, Max);
            else
            {
                PRG_PROCESS.Minimum = Min;
                PRG_PROCESS.Maximum = Max;
            }
        }

        public delegate void setValueDelegate(string Message, int progress, Int16 CurrentStep, Int16 TotalStep);
        public void setValue(string Message, int progress, Int16 CurrentStep, Int16 TotalStep)
        {
            if (this.InvokeRequired)
                this.Invoke(new setValueDelegate(setValue), Message, progress, CurrentStep, TotalStep);
            else
            {
                int percent = (100 * progress) / PRG_PROCESS.Maximum;
                PRG_PROCESS.Value = progress;
                LBL_TITLE.Text = Message + " " + percent.ToString() + "%";
                LBL_STEP.Text = CurrentStep.ToString() + "/" + TotalStep.ToString();
            }
            Thread.Sleep(50);
        }

        public delegate void stopDelegate();
        public void Stop()
        {
            if (InvokeRequired)
                Invoke(new stopDelegate(Stop));
            else
            {
                status = false;
                this.Close();
            }
        }

        public delegate bool getStat();
        public bool getStatus()
        {
            if (InvokeRequired)
                Invoke(new getStat(getStatus));

            return status;
        }

        public void ShowForm()
        {
            this.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            status = false;
        }
    }
}
