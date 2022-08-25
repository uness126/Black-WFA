using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Black
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetCultureApplication();
            UpdateDataBase();
        }

        ClsDataBase db = new ClsDataBase();

        private void SetCultureApplication()
        {
            System.Globalization.CultureInfo myCI = new System.Globalization.CultureInfo("en-US", false);

            // Clones myCI and modifies the DTFI and NFI instances associated with the clone.
            System.Globalization.CultureInfo myCIclone = (System.Globalization.CultureInfo)myCI.Clone();
            myCIclone.DateTimeFormat.LongDatePattern = "dddd, MMMM dd, yyyy";
            myCIclone.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
            myCIclone.DateTimeFormat.ShortTimePattern = "hh:mm tt";
            myCIclone.DateTimeFormat.LongTimePattern = "hh:mm:ss tt";
            myCIclone.DateTimeFormat.AMDesignator = "AM";
            myCIclone.DateTimeFormat.PMDesignator = "PM";
            myCIclone.NumberFormat.CurrencyDecimalDigits = 2;
            myCIclone.NumberFormat.CurrencyDecimalSeparator = ".";
            myCIclone.NumberFormat.CurrencyGroupSeparator = ",";
            myCIclone.NumberFormat.NumberDecimalDigits = 2;
            myCIclone.NumberFormat.NumberDecimalSeparator = ".";
            myCIclone.NumberFormat.NumberGroupSeparator = ",";

            Application.CurrentCulture = myCIclone;
        }

        #region SELECT_NEXT_CONTROL

        private void SelectNextControl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
                this.SelectNextControl((Control)sender, true, true, true, true);
        }

        #endregion

        #region CHANGE_LANGUAGE_KEYBOARD

        public static InputLanguage GetInputLanguageByName(string inputName)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (lang.Culture.EnglishName.ToLower().StartsWith(inputName.ToLower()))
                    return lang;
            }
            return null;
        }

        public void SetKeyboardLayout(InputLanguage layout)
        {
            InputLanguage.CurrentInputLanguage = layout;
        }

        #endregion

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnterLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_USERNAME.Text != string.Empty && TXT_PASSWORD.Text != string.Empty)
                {
                    ClsUser clsUser = new ClsUser();
                    ClsRole clsRole = new ClsRole();
                    var query = clsUser.CheckedLoginUsers(TXT_USERNAME.Text, TXT_PASSWORD.Text);
                    if (query.Rows.Count > 0)
                    {
                        ClsUtility.UserID = Convert.ToInt32(query.Rows[0]["UserId"]);
                        ClsUtility.SYS_USR_ROLE_ID = Convert.ToInt32(query.Rows[0]["RoleId"]);
                        ClsUtility.SYS_USR_ROLE_TYPE = Convert.ToInt32(query.Rows[0]["RoleType"]);
                        ClsUtility.SYS_USR_FIRST_NAME = Convert.ToString(query.Rows[0]["FirstName"]);
                        ClsUtility.SYS_USR_LAST_NAME = Convert.ToString(query.Rows[0]["LastName"]);
                        ClsUtility.SYS_USR_USERNAME = TXT_USERNAME.Text;
                        ClsUtility.SYS_USR_PASSWORD = TXT_PASSWORD.Text;
                        if (query.Rows[0]["rowguid"] != DBNull.Value && Guid.Parse(query.Rows[0]["rowguid"].ToString()) == Guid.Parse("8201D5FD-EC45-4B76-BFF3-662986F67540"))
                        {
                            ClsRole.ShowPassword = true;
                        }
                        else
                        {
                            var dtrole = clsRole.SelectRolesById(ClsUtility.SYS_USR_ROLE_ID);
                            if (dtrole.Rows.Count > 0)
                            {
                                ClsRole.ShowPassword = (bool)dtrole.Rows[0]["ShowPassword"];
                                dtrole.Dispose();
                            }
                        }
                        MainForm mainForm = new MainForm();
                        SetKeyboardLayout(GetInputLanguageByName("persian"));
                        this.Hide();
                        mainForm.ShowDialog();
                        if (mainForm.LoginUser)
                        {
                            TXT_USERNAME.Text = TXT_PASSWORD.Text = string.Empty;
                            SetKeyboardLayout(GetInputLanguageByName("English"));
                            TXT_USERNAME.Select();
                            this.Show();
                            this.BringToFront();
                            this.Activate();
                        }
                        else
                            this.Dispose();
                    }
                    else
                        MessageBox.Show("لطفا نام کاربری و کلمه عبور را صحیح وارد نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار (*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در ورود به سیستم", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetKeyboardLayout(GetInputLanguageByName("English"));
            TXT_USERNAME.Select();
            this.BringToFront();
        }

        private void UpdateDataBase()
        {
            try
            {
                if (db.CheckDataBase())
                {
                    db.UpdateModifiedDataBase();
                    ClsUser clsUser = new ClsUser();
                    clsUser.UpdatePassword(Guid.Parse("8201D5FD-EC45-4B76-BFF3-662986F67540"), "admin");
                }
                else
                {
                    SqlConnectionForm form = new SqlConnectionForm();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("خطا در بروزرسانی دیتابیس" + Environment.NewLine + ex.Message, "هشدار");
                SqlConnectionForm form = new SqlConnectionForm();
                form.ShowDialog();
            }
        }

        private void TXT_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnEnterLogin.PerformClick();
        }

        private void ChangeLanguage_Enter(object sender, EventArgs e)
        {
            SetKeyboardLayout(GetInputLanguageByName("English"));
        }
    }
}
