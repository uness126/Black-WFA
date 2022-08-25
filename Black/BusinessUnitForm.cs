using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Black
{
    public partial class BusinessUnitForm : BaseForm
    {
        public BusinessUnitForm()
        {
            InitializeComponent();
        }
        ClsBusinessUnit clsBusinessUnit = new ClsBusinessUnit();
        private Int32 _BusinessUnitId;

        #region SELECT_ALL_DATA_COMPANY

        private void SelectAllDataCompany()
        {
            DataTable dataTable = clsBusinessUnit.SelectAllBusinessUnit();
            dataGridViewCompany.DataSource = dataTable;
        }

        #endregion

        #region ONLY_ENTTER_NUMERIC_TEXTBOX

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        #endregion

        #region SELECT_NEXT_CONTROL

        private void SelectNextControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.ActiveControl != null && (this.ActiveControl.Name == "btnNewCompany"))
            {
                this.ActiveControl = null;
                txtName.Focus();
                return;
            }
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
                this.SelectNextControl((Control)sender, true, true, true, true);
        }

        #endregion

        #region EMPTY_ALL_TEXTBOX

        private void EmptyAllTextBox()
        {
            txtName.Text = string.Empty;
            btnUpdateCompany.Enabled = false;
            btnSaveCompany.Enabled = true;
            btnNewCompany.Focus();
        }

        #endregion

        private void btnNewCompany_Click(object sender, EventArgs e)
        {
            EmptyAllTextBox();
        }

        private void CreateCompanyForm_Load(object sender, EventArgs e)
        {
            try
            {
                SelectAllDataCompany();
            }
            catch (Exception ex)
            {
                ex.WriteLOG(ex.ToString());
                MessageBox.Show("!!!خطا در بارگذاری اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != string.Empty)
                {
                    btnSaveCompany.Enabled = false;
                    clsBusinessUnit.Insert(txtName.Text);
                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyAllTextBox();
                    SelectAllDataCompany();
                    btnSaveCompany.Enabled = true;
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار (*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG(ex.ToString());
                btnSaveCompany.Enabled = true;
                MessageBox.Show("!!!خطا در ثبت اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != 0)
                {
                    _BusinessUnitId = Convert.ToInt32(dataGridViewCompany.Rows[e.RowIndex].Cells["BusinessUnitId"].Value.ToString());
                    var dt = clsBusinessUnit.SelectAllBusinessUnit(_BusinessUnitId);
                    if (dt.Rows.Count > 0)
                    {
                        txtName.Text = Convert.ToString(dt.Rows[0]["Name"]);
                    }
                    //
                    btnUpdateCompany.Enabled = true;
                    btnSaveCompany.Enabled = false;
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    try
                    {
                        if (MessageBox.Show("آیا مطمئن به حذف اطلاعات هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _BusinessUnitId = Convert.ToInt32(dataGridViewCompany.Rows[e.RowIndex].Cells["BusinessUnitId"].Value.ToString());

                            clsBusinessUnit.Delete(_BusinessUnitId);
                            MessageBox.Show("اطلاعات با موفقیت حذف شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SelectAllDataCompany();
                        }
                    }
                    catch (Exception ex)
                    {
                        ex.WriteLOG(ex.ToString());
                        MessageBox.Show("!!!خطا در حذف اطلاعات" + Environment.NewLine + ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG(ex.ToString());
                MessageBox.Show("!!!خطا در نمایش اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExitCompany_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != string.Empty)
                {
                    clsBusinessUnit.Update(_BusinessUnitId, txtName.Text);
                    //
                    MessageBox.Show("اطلاعات با موفقیت اصلاح شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyAllTextBox();
                    SelectAllDataCompany();
                    btnUpdateCompany.Enabled = false;
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار (*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG(ex.ToString());
                MessageBox.Show("!!!خطا در اصلاح اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
