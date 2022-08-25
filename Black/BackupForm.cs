using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black
{
    public partial class BackupForm : BaseForm
    {
        public BackupForm()
        {
            InitializeComponent();
        }

        ClsUtility clsUtility = new ClsUtility();
        ClsEncryptionAndDecryption clsEncryptionAndDecryption = new ClsEncryptionAndDecryption();
        public int TypeBackup = 1;
        Backup backup = new Backup();
        public delegate void ShowPercentCompleteDelegate(int percent);
        public delegate void ShowMessageDelegate(string message);
        private void BackupForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (TypeBackup == 2)
                    btnStart.Visible = false;
                txtPath.Text = Black.Properties.Settings.Default.path;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                ServerConnection sc = new ServerConnection(Properties.Settings.Default.server, Properties.Settings.Default.user, clsEncryptionAndDecryption.Decrypt(Properties.Settings.Default.password));
                Server server = new Server(sc);
                Database db = server.Databases["Club"];

                backup.Action = BackupActionType.Database;
                backup.BackupSetName = "Black";
                backup.Database = db.Name;
                var path = string.Empty;
                if (Properties.Settings.Default.path.EndsWith("\\"))
                    path = Properties.Settings.Default.path + @"Club_" + clsUtility.Convert2Persian(DateTime.Now).Replace("/", "_") + ".bak";
                else
                    path = Properties.Settings.Default.path + @"\Club_" + clsUtility.Convert2Persian(DateTime.Now).Replace("/", "_") + ".bak";
                BackupDeviceItem backupDeviceItem = new BackupDeviceItem(path, DeviceType.File);
                backup.Devices.Add(backupDeviceItem);

                backup.Initialize = false;
                backup.Incremental = false;
                backup.CompressionOption = BackupCompressionOptions.On;
                backup.PercentCompleteNotification = 1;

                backup.PercentComplete += new PercentCompleteEventHandler(Backup_PercentComplete);
                backup.Complete += new ServerMessageEventHandler(Backup_Complete);
                backup.Information += new ServerMessageEventHandler(Backup_Information);

                backup.SqlBackupAsync(server);
                Properties.Settings.Default.path = txtPath.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.Cancel;
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void Backup_Information(object sender, ServerMessageEventArgs e)
        {
            //object[] message = new object[1];
            //message[0] = e.Error.Message;

            //this.BeginInvoke(
            //  new ShowMessageDelegate(ShowMessage), message);
        }

        private delegate void InvokeDelegate();
        private void Backup_Complete(object sender, ServerMessageEventArgs e)
        {
            object[] message = new object[1];
            message[0] = "Backup complete";
            if (TypeBackup == 2)
            {
                DialogResult = DialogResult.OK;
                this.BeginInvoke(new Action(InvokeMethod));
            }
            else if (TypeBackup == 1)
                MessageBox.Show("پشتیبانی با موفقیت انجام شد." + Environment.NewLine + e.Error.Message);
        }

        public void InvokeMethod()
        {
            Close();
        }

        private void Backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            object[] percent = new object[1];
            percent[0] = e.Percent;

            this.BeginInvoke(new ShowPercentCompleteDelegate(ShowPercentComplete), percent);
        }

        public void ShowPercentComplete(int percent)
        {
            progressBar1.Value = percent;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.ShowNewFolderButton = false;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    txtPath.Text = folderBrowserDialog.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackupForm_Shown(object sender, EventArgs e)
        {
            try
            {
                if (TypeBackup == 2)
                {
                    System.Threading.Thread.Sleep(500);
                    btnStart_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                backup.Abort();
                Close();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }
    }
}
