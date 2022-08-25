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
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        ClsUser clsSystemUser = new ClsUser();
        ClsRole clsRole = new ClsRole();
        ClsDataBase clsDataBase = new ClsDataBase();

        private Int32 _UserId;

        #region SELECT_ALL_DATA_USERS_IN_SELECT_COMPANY

        private void SelectAllDataUsers()
        {
            dataGridViewUsers.DataSource = clsSystemUser.SelectAllUsers(!CHK_SHOW_ALL.Checked);
        }

        #endregion

        #region BIND_DATA_IN_COMBOBOX_ROLE

        private void BindDataInComboBoxRole()
        {
            dgvRoles.DataSource = clsRole.SelectRoles();
            for (int i = 0; i < dgvRoles.RowCount; i++)
            {
                if (Guid.Parse(dgvRoles.Rows[i].Cells["rowguid"].Value.ToString()) == Guid.Parse("58E49343-BF5F-4455-888D-3231AD076A55"))
                {
                    dgvRoles.Rows[i].Cells["ShowPassword"].ReadOnly = true;
                }
            }
            //
            cmbRoleId.DataSource = clsRole.SelectRoles();
            cmbRoleId.DisplayMember = "RoleName";
            cmbRoleId.ValueMember = "RoleId";
        }

        #endregion

        #region SELECT_NEXT_CONTROL

        private void SelectNextControl_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
                this.SelectNextControl((Control)sender, true, true, true, true);
        }

        #endregion

        #region EMPTY_ALL_TEXTBOX

        private void EmptyAllTextBox()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            chkStatus.Checked = true;
            cmbRoleId.SelectedIndex = 0;
            btnSaveUsers.Enabled = true;
            btnUpdateUsers.Enabled = false;
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

        private void SystemUsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                BindDataInComboBoxRole();
                SelectAllDataUsers();
                EmptyAllTextBox();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در بارگذاری اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExitUsers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewUsers_Click(object sender, EventArgs e)
        {
            try
            {
                EmptyAllTextBox();
            }
            catch (Exception exception)
            {
                exception.WriteLOG();
            }
        }

        private void btnSaveUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != string.Empty && txtLastName.Text.ToString() != string.Empty && txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    if (clsSystemUser.CheckedUserName(txtUserName.Text) == -1 || clsSystemUser.CheckedUserName(txtUserName.Text) != ClsUtility.UserID)
                    {
                        clsSystemUser.Insert(txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, Convert.ToInt32(cmbRoleId.SelectedValue));
                        MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmptyAllTextBox();
                        SelectAllDataUsers();
                    }
                    else
                        MessageBox.Show("نام کاربری تکراری می باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار(*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در ثبت اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != string.Empty && txtLastName.Text.ToString() != string.Empty && txtUserName.Text != string.Empty)
                {
                    if (clsSystemUser.CheckedUserName(txtUserName.Text) == -1 || clsSystemUser.CheckedUserName(txtUserName.Text) == _UserId)
                    {
                        if (ClsUtility.UserID == _UserId && chkStatus.Checked == false)
                        {
                            MessageBox.Show("امکان غیرفعال کردن کاربر جاری نیست.");
                            return;
                        }
                        if (txtPassword.Text != string.Empty)
                            clsSystemUser.Update(_UserId, txtFirstName.Text, txtLastName.Text, txtUserName.Text, txtPassword.Text, Convert.ToInt32(cmbRoleId.SelectedValue), chkStatus.Checked);
                        else
                            clsSystemUser.Update(_UserId, txtFirstName.Text, txtLastName.Text, txtUserName.Text, Convert.ToInt32(cmbRoleId.SelectedValue), chkStatus.Checked);
                        MessageBox.Show("اطلاعات با موفقیت اصلاح شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmptyAllTextBox();
                        SelectAllDataUsers();
                    }
                    else
                        MessageBox.Show("نام کاربری تکراری می باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار (*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در اصلاح اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != 0)
                {
                    _UserId = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["UserId"].Value);
                    txtFirstName.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["FirstName"].Value);
                    txtLastName.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["LastName"].Value);
                    txtUserName.Text = Convert.ToString(dataGridViewUsers.Rows[e.RowIndex].Cells["UserName"].Value);
                    cmbRoleId.SelectedValue = dataGridViewUsers.Rows[e.RowIndex].Cells["RoleId"].Value == DBNull.Value ? 0 : Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["RoleId"].Value);
                    chkStatus.Checked = Convert.ToBoolean(dataGridViewUsers.Rows[e.RowIndex].Cells["Status"].Value);
                    //
                    btnUpdateUsers.Enabled = true;
                    btnSaveUsers.Enabled = false;
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    try
                    {
                        if (MessageBox.Show("آیا مطمئن به حذف اطلاعات هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        ex.WriteLOG();
                        MessageBox.Show("!!!خطا در حذف اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در نمایش اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeLanguage_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Select();
            if (textBox.Name == "txtUserName" || textBox.Name == "txtPassword")
                SetKeyboardLayout(GetInputLanguageByName("English"));
            else
                SetKeyboardLayout(GetInputLanguageByName("persian"));
        }

        private void CHK_SHOW_ALL_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SelectAllDataUsers();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("!!!خطا در بارگذاری اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvRoles.RowCount; i++)
                {
                    clsRole.Update(Convert.ToInt32(dgvRoles.Rows[i].Cells["cRoleId"].Value), Convert.ToBoolean(dgvRoles.Rows[i].Cells["ShowPassword"].Value), Guid.Parse(dgvRoles.Rows[i].Cells["rowguid"].Value.ToString()));
                }
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
