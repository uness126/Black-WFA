using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black
{
    public partial class SqlConnectionForm : BaseForm
    {
        public SqlConnectionForm()
        {
            InitializeComponent();
        }

        ClsDataBase clsDataBase = new ClsDataBase();
        ClsEncryptionAndDecryption clsEncryptionAndDecryption = new ClsEncryptionAndDecryption();
        string ConnectionString = string.Empty;

        private void SqlConnectionForm_Load(object sender, EventArgs e)
        {
            try
            {
                TXT_DB_USER_NAME.Text = Properties.Settings.Default.user;
                TXT_DB_PASSWORD.Text = clsEncryptionAndDecryption.Decrypt("" + Properties.Settings.Default.password);
                TXT_DB_SERVER.Text = Properties.Settings.Default.server;
                if (CheckDataBase())
                    btnCreateDB.Enabled = false;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در اتصال به بانک اطلاعاتی", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.user = TXT_DB_USER_NAME.Text;
                Properties.Settings.Default.password = clsEncryptionAndDecryption.Encrypt(TXT_DB_PASSWORD.Text);
                Properties.Settings.Default.server = TXT_DB_SERVER.Text;
                Properties.Settings.Default.Save();
                ClsDataBase db = new ClsDataBase();
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در ثبت اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblServer_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDataBase db = new ClsDataBase();
                using (var l_oConnection = new SqlConnection(ClsDataBase.ConnectionString))
                {
                    try
                    {
                        l_oConnection.Open();
                        MessageBox.Show("Connected.");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Disconnected.");
                    }
                    finally
                    {
                        l_oConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CheckDataBase()
        {
            try
            {
                ServerConnection sc = new ServerConnection(TXT_DB_SERVER.Text, TXT_DB_USER_NAME.Text, TXT_DB_PASSWORD.Text);
                Server svr = new Server(sc);
                Database db = svr.Databases["Club"];
                if (db != null && db.Name.ToLower() == "club")
                    return true;
                else return false;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDataBase db = new ClsDataBase();
                if (db.CreateDataBase())
                {
                    MessageBox.Show("دیتابیس با موفقیت ایجاد شد.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.UpdateModifiedDataBase();
                }
                else
                    MessageBox.Show("خطا در ایجاد دیتابیس برنامه.", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
