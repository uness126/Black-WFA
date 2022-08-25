using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Black
{
    public partial class MainForm : Form
    {
        ClsDataBase db = new ClsDataBase();
        ClsUtility clsUtility = new ClsUtility();
        ClsSetting clsSetting = new ClsSetting();
        
        public bool LoginUser { get; private set; }
        public MainForm()
        {
            InitializeComponent();            
            SetPermission();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { }

        private void SetPermission()
        {
            try
            {
                if (ClsUtility.SYS_USR_ROLE_TYPE != 1)
                {
                    tsmUser.Visible = false;
                    tsmSqlSetting.Visible = false;
                    tsmSetting.Visible = false;
                }
                tslblStatus.Text = "";
                tslblStatus.Text += "نام کاربر:" + ClsUtility.SYS_USR_FIRST_NAME + " " + ClsUtility.SYS_USR_LAST_NAME + "|";
                tslblStatus.Text += "زمان ورود:" + clsUtility.GetTime(DateTime.Now);
                var set = clsSetting.SelectKeys("BACKGROUND_IMAGE").Rows[0];
                if (set != null)
                {
                    pictureBox1.Image = ClsCommon.ConvertBase64ToImage(set["BACKGROUND_IMAGE"].ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsmBusinessUnit_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessUnitForm form = new BusinessUnitForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerForm form = new CustomerForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void tsmUser_Click(object sender, EventArgs e)
        {
            try
            {
                UsersForm form = new UsersForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void tsmLogout_Click(object sender, EventArgs e)
        {
            LoginUser = true;
            this.Close();
        }

        private void tsmSqlSetting_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionForm form = new SqlConnectionForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmBackup_Click(object sender, EventArgs e)
        {
            try
            {
                BackupForm form = new BackupForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmSetting_Click(object sender, EventArgs e)
        {
            try
            {
                SettingForm form = new SettingForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            LoginUser = false;
            Close();
        }        
    }
}
