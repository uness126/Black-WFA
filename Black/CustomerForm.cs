using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using GenCode128;

namespace Black
{
    public partial class CustomerForm : BaseForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            SetPermission();
        }

        #region Variable
        ClsSetting clsSetting = new ClsSetting();
        ClsUtility clsUtility = new ClsUtility();
        ClsCustomer clsCustomer = new ClsCustomer();
        ClsBusinessUnit clsBusinessUnit = new ClsBusinessUnit();
        //ClsTransaction clsTransaction = new ClsTransaction();
        private Int32 _CustomerId;
        private string BARCODE_TYPE;
        Control PreviousActiveControl;
        #endregion

        #region ONLY_ENTTER_NUMERIC_TEXTBOX

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        #endregion

        #region CURRENCY_NUMBER

        private void CurrencyNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = string.Format("{0:N0}", (txt.Text == string.Empty ? 0 : Convert.ToDecimal(txt.Text)));
            txt.SelectionStart = txt.Text.Length;
        }

        #endregion

        private void BindDataComboBoxBusinessUnit()
        {
            cmbBusinessUnit.DataSource = clsBusinessUnit.SelectBusinessUnitList();
            cmbBusinessUnit.DisplayMember = "Name";
            cmbBusinessUnit.ValueMember = "BusinessUnitId";
        }

        #region SELECT_ALL_DATA_CUSTOMER

        private void SelectAllDataCustomer()
        {
            DataTable dataTable = clsCustomer.SelectAllCustomer();
            dgvCustomer.DataSource = dataTable;
        }

        #endregion

        private void SelectSetting()
        {
            var set = clsSetting.SelectKeys("BARCODE_TYPE").Rows[0];
            if (set != null)
            {
                BARCODE_TYPE = set["BARCODE_TYPE"].ToString();
            }
        }

        #region EMPTY_ALL_TEXTBOX

        private void EmptyAllTextBox()
        {
            _CustomerId = -1;
            cmbBusinessUnit.SelectedIndex = 0;
            txtCustomerId.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobile.Text = string.Empty;
            txtTotalCredit.Text = "0";
            txtCreditRemain.Text = "0";
            txtNationalId.Text = string.Empty;
            txtAccountCode.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCreditUsed.Text = "0";
            txtCredit.Text = "0";
            txtCredit.Enabled = true;
            if (BARCODE_TYPE == "1") rdbOne.Checked = true;
            else if (BARCODE_TYPE == "2") rdbTwo.Checked = true;
            picBarcode.Image = Properties.Resources.qrcode_32;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            cmbBusinessUnit.Select();
            PreviousActiveControl = tabControl1.TabPages["tabPage1"];
            GC.Collect();
        }

        #endregion

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            try
            {
                BindDataComboBoxBusinessUnit();
                SelectAllDataCustomer();
                SelectSetting();
                EmptyAllTextBox();
            }
            catch (Exception ex)
            {
                ex.WriteLOG(ex.ToString());
                MessageBox.Show("!!!خطا در بارگذاری اطلاعات", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPermission()
        {
            try
            {
                if (!ClsRole.ShowPassword)
                {
                    txtPassword.PasswordChar = '*';
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                EmptyAllTextBox();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PreviousActiveControl = btnSave;
                if (cmbBusinessUnit.SelectedIndex > 0 && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtNationalId.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    if (clsCustomer.CheckNationalId(txtNationalId.Text) > 0)
                    {
                        MessageBox.Show("کد ملی تکراری است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNationalId.Focus();
                        txtNationalId.SelectAll();
                        return;
                    }
                    btnSave.Enabled = false;
                    _CustomerId = clsCustomer.Insert(Convert.ToInt32(cmbBusinessUnit.SelectedValue), txtFirstName.Text, txtLastName.Text, txtMobile.Text, txtAccountCode.Text, txtNationalId.Text, txtPassword.Text, picBarcode.Image);
                    //
                    //if (Convert.ToDecimal(txtCredit.Text) > 0)
                    //    clsTransaction.Insert(_CustomerId, Convert.ToDecimal(txtCredit.Text), TransactionType.POS, "بابت اعتبار اولیه مشترک", TransactionState.Active, string.Empty, DateTime.Now, clsUtility.Convert2Persian(DateTime.Now));

                    MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerId.Text = _CustomerId.ToString();
                    EmptyAllTextBox();
                    SelectAllDataCustomer();
                    btnUpdate.Enabled = true;
                }
                else
                    MessageBox.Show("لطفا فیدهای ستاره دار (*) را تکمیل نمایید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBusinessUnit.SelectedIndex > 0 && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtNationalId.Text != string.Empty && txtPassword.Text != string.Empty)
                {
                    var _id = clsCustomer.CheckNationalId(txtNationalId.Text);
                    if (_id == Convert.ToInt32(txtCustomerId.Text) || _id == -1)
                        clsCustomer.Update(_CustomerId, Convert.ToInt32(cmbBusinessUnit.SelectedValue), txtFirstName.Text, txtLastName.Text, txtMobile.Text, txtAccountCode.Text, txtNationalId.Text, txtPassword.Text, picBarcode.Image);
                    //
                    MessageBox.Show("اطلاعات با موفقیت اصلاح شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EmptyAllTextBox();
                    SelectAllDataCustomer();
                    btnUpdate.Enabled = false;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex != 0)
                {
                    _CustomerId = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                    cmbBusinessUnit.SelectedValue = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["BusinessUnitId"].Value.ToString());
                    txtCustomerId.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                    txtFirstName.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["FirstName"].Value.ToString());
                    txtLastName.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["LastName"].Value.ToString());
                    txtMobile.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["Mobile"].Value.ToString()); ;
                    txtTotalCredit.Text = Convert.ToDecimal(dgvCustomer.Rows[e.RowIndex].Cells["TotalCredit"].Value).ToString("N0");
                    txtCreditRemain.Text = Convert.ToDecimal(dgvCustomer.Rows[e.RowIndex].Cells["CreditRemain"].Value).ToString("N0");
                    txtNationalId.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["NationalId"].Value.ToString());
                    txtAccountCode.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["AccountCode"].Value.ToString());
                    txtPassword.Text = Convert.ToString(dgvCustomer.Rows[e.RowIndex].Cells["P"].Value.ToString());
                    txtCreditUsed.Text = Convert.ToDecimal(dgvCustomer.Rows[e.RowIndex].Cells["CreditUsed"].Value).ToString("N0");
                    txtCredit.Text = "0";
                    txtCredit.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                }
                else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                {
                    try
                    {
                        if (MessageBox.Show("آیا مطمئن به حذف اطلاعات هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _CustomerId = Convert.ToInt32(dgvCustomer.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString());
                            clsCustomer.Delete(_CustomerId);
                            MessageBox.Show("اطلاعات با موفقیت حذف شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SelectAllDataCustomer();
                            EmptyAllTextBox();
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

        private void txtNationalId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Image Iimage;
                Bitmap Bimage;
                if (rdbTwo.Checked)
                {
                    QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                    Bimage = qrCodeEncoder.Encode(txtNationalId.Text);
                    Bimage.Save(Application.StartupPath + "\\Barcode.bmp");
                    picBarcode.Image = Bimage;
                    picBarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else if (rdbOne.Checked)
                {
                    Iimage = Code128Rendering.MakeBarcodeImage(txtNationalId.Text, 1, true);
                    Iimage.Save(Application.StartupPath + "\\Barcode.bmp");
                    picBarcode.Image = Iimage;
                    picBarcode.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void rdbBarcode_CheckedChanged(object sender, EventArgs e)
        {
            txtNationalId_TextChanged(null, null);
        }

        private void btnPrintQR_Click(object sender, EventArgs e)
        {
            try
            {
                if (_CustomerId > 0)
                {
                    var dt = clsCustomer.SelectBarcodeById(_CustomerId);
                    DataSet ds = new DataSet("Tables");
                    dt.Columns.Add("BarcodeImage", typeof(Image));
                    if (dt.Rows.Count > 0)
                        dt.Rows[0]["BarcodeImage"] = ClsCommon.ConvertBase64ToImage(Convert.ToString(dt.Rows[0]["Barcode"]));
                    dt.Columns.Remove("Barcode");
                    ds.Tables.Add(dt);
                    var fr = new FastReport.Report();
                    fr.FileName = "barcode";
                    FastReportPreviewForm previewForm = new FastReportPreviewForm();
                    if (rdbTwo.Checked)
                    {
                        if (ClsCommon.CheckFileExists(Application.StartupPath + @"\Reports\barcode2.frx"))
                            fr.Load(Application.StartupPath + @"\Reports\barcode2.frx");
                        else
                        {
                            var name = "Club.Reports.barcode2.frx";
                            var l = ClsCommon.ReadResource(name);
                            fr.Load(l);
                        }
                        previewForm.reportName = Application.StartupPath + @"\Reports\barcode2.frx";
                    }
                    else if (rdbOne.Checked)
                    {
                        if (ClsCommon.CheckFileExists(Application.StartupPath + @"\Reports\barcode1.frx"))
                            fr.Load(Application.StartupPath + @"\Reports\barcode1.frx");
                        else
                        {
                            var name = "Club.Reports.barcode1.frx";
                            var l = ClsCommon.ReadResource(name);
                            fr.Load(l);
                        }
                        previewForm.reportName = Application.StartupPath + @"\Reports\barcode1.frx";
                    }
                    previewForm.FReport = fr;
                    previewForm.FDataSet = ds;
                    previewForm.ShowDialog();
                }
                else
                    MessageBox.Show("لطفا مشترک را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable;
                if (dgvCustomer.DataSource.GetType() == typeof(DataView))
                {
                    dataTable = (dgvCustomer.DataSource as DataView).Table;
                }
                else
                {
                    dataTable = (DataTable)dgvCustomer.DataSource;
                }
                string where = "FirstName Like '%" + txtSearch.Text + "%' OR LastName Like '%" + txtSearch.Text + "%' OR " +
                    "Mobile Like '%" + txtSearch.Text + "%' OR AccountCode Like '%" + txtSearch.Text + "%' OR NationalId Like '%" + txtSearch.Text + "%' ";
                DataView dataView = dataTable.DefaultView;
                dataView.RowFilter = string.Format(where);
                dgvCustomer.DataSource = dataView;
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            cmbBusinessUnit.Focus();
        }

        private void CustomerForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (PreviousActiveControl != null && (PreviousActiveControl.Name == "btnSave" || PreviousActiveControl.Name == "tabPage1"))
            {
                PreviousActiveControl = null;
                return;
            }
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void btnListTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if (_CustomerId != -1)
                {
                    //TransactionForm form = new TransactionForm();
                    //form.TypeForm = 2;
                    //form.CustomerId = _CustomerId;
                    //form.ShowDialog();
                    SelectAllDataCustomer();
                }
                else
                    MessageBox.Show("لطفا مشترک را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("خطا در نمایش اطلاعات." + Environment.NewLine + ex.Message);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\'')
                    e.Handled = true;
                //
                if (e.KeyChar == (char)Keys.Enter)
                    if (dgvCustomer.Rows.Count > 0)
                    {
                        dgvCustomer.Rows[0].Selected = true;
                        var args = new DataGridViewCellEventArgs(1, 0);
                        dgvCustomer_CellClick(dgvCustomer, args);
                        tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
                        tabControl1.TabPages["tabPage1"].Focus();
                    }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                throw;
            }
        }

    }
}
