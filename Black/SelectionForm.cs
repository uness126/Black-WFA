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
    public partial class SelectionForm : Form
    {
        public List<Int32> IdList = new List<Int32>();
        public string txtSelectCount { get; set; }
        public string txtSerachWord { get; set; }
        public string ColumnCondition { get; set; }
        public string DataType { get; set; }
        public int SearchType { get; set; } //فیلتر روی نام کالا یا کد کالا
        public Control Component { get; set; } // 
        public string Type { get; set; } // حالت پر کردن فیلد، کد، نام، کد و نام 
        public string RowValue { get; set; } // مقدار فیلد
        public string RowValue2 { get; set; } // اگر نوع کد و نام بود کاربرد دارد

        DataTable _dataTableDynamicSearch = new DataTable();
        ClsUtility clsUtility = new ClsUtility();
        ClsCustomer clsCustomer = new ClsCustomer();
        public SelectionForm()
        {
            InitializeComponent();
            SetKeyboardLayout(GetInputLanguageByName("persian"));
        }

        public SelectionForm(string DataType, string ColumnCondition, Control Component, string Type)
        {
            InitializeComponent();
            SetKeyboardLayout(GetInputLanguageByName("persian"));
            this.DataType = DataType;
            this.ColumnCondition = ColumnCondition;
            this.Component = Component;
            this.Type = Type;
            if (Type == "NAME")
                SearchType = 1;
            else if (Type == "CODE")
                SearchType = 2;
        }

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

        #region BIND_DATA_IN_DATAGRIDVIEW

        public void BindDataInDataGridView(string dataType)
        {
            switch (dataType)
            {
                case "CUSTOMER":
                    {
                        #region BIND_DATA_IN_DYNAMIC_SEARCH_CUSTOMER

                        dataGridView.Columns.Clear();
                        dataGridView.DataSource = null;
                        if (dataGridView.Columns.Count == 0)
                        {
                            dataGridView.AutoGenerateColumns = false;
                            dataGridView.Columns.Add("CustomerId", "CustomerId");
                            dataGridView.Columns[0].DataPropertyName = "CustomerId";
                            dataGridView.Columns.Add("BusinessUnitName", "نام شرکت");
                            dataGridView.Columns[1].DataPropertyName = "BusinessUnitName";
                            dataGridView.Columns[1].FillWeight = 40;
                            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dataGridView.Columns.Add("FirstName", "نام");
                            dataGridView.Columns[2].DataPropertyName = "FirstName";
                            dataGridView.Columns[2].FillWeight = 50;
                            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dataGridView.Columns.Add("LastName", "نام خانوادگی");
                            dataGridView.Columns[3].DataPropertyName = "LastName";
                            dataGridView.Columns[3].FillWeight = 60;
                            dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dataGridView.Columns.Add("Mobile", "موبایل");
                            dataGridView.Columns[4].DataPropertyName = "Mobile";
                            dataGridView.Columns[4].FillWeight = 60;
                            dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dataGridView.Columns.Add("AccountCode", "کد حساب");
                            dataGridView.Columns[5].DataPropertyName = "AccountCode";
                            dataGridView.Columns[5].FillWeight = 30;
                            dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                            dataGridView.Columns.Add("NationalId", "کد ملی");
                            dataGridView.Columns[6].DataPropertyName = "NationalId";
                            dataGridView.Columns[6].FillWeight = 50;
                            dataGridView.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
                        }
                        _dataTableDynamicSearch = clsCustomer.SelectCustomers();
                        Fill(_dataTableDynamicSearch);
                        this.Size = new Size(500, 215);

                        #endregion
                    }
                    break;
            }
        }

        #endregion

        #region SET_VALUE

        public void setValue(Int32 ID, string dataType)
        {
            switch (dataType)
            {
                case "CUSTOMER":
                    {
                        var query = clsCustomer.SelectCustomerById(ID);
                        if (query.Rows.Count > 0)
                        {
                            if (Type == "CODE")
                            {
                                RowValue = query.Rows[0]["NationalId"].ToString();
                            }
                            else if (Type == "NAME")
                            {
                                RowValue = query.Rows[0]["FirstName"].ToString() + " " + query.Rows[0]["LastName"].ToString();
                            }
                        }
                        else
                        {
                            RowValue = string.Empty;
                        }
                    }
                    break;
            }
        }

        #endregion

        public void Fill(DataTable dataTable)
        {
            dataTable.DefaultView.RowFilter = string.Empty;
            dataGridView.DataSource = dataTable;
            dataGridView.Columns[0].Visible = false;
        }

        public void Search(DataTable dataTable, string Condition, string SearchText)
        {
            int count = 0;
            string where = Condition + " Like '%" + SearchText + "%'";
            string[] condition = Condition.Split(',');
            if (condition.Length > 1)
            {
                where = "";
                for (int i = 0; i < condition.Length; i++)
                {
                    count++;
                    where += condition[i] + " Like '%" + SearchText + "%' ";
                    if (count < condition.Length)
                        where += " OR ";
                }
            }
            DataView dataView = dataTable.DefaultView;
            dataView.RowFilter = string.Format(where);
            dataGridView.DataSource = dataView;
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.Green)
                {
                    IdList.Add(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                    var itemToRemove =
                        IdList.Single(r => r.Equals(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())));
                    IdList.Remove(itemToRemove);
                }
                if (dataGridView.CurrentRow.Index != (dataGridView.Rows.Count - 1))
                {
                    dataGridView.CurrentRow.Selected = false;
                    dataGridView.Rows[e.RowIndex + 1].Selected = true;
                    dataGridView.CurrentCell = dataGridView[1, e.RowIndex + 1];
                }
                LBL_SELECT.Text = "انتخاب :" + IdList.Count;
            }
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (IdList.Count > 0)
                txtSelectCount = "تعداد انتخاب شده: " + IdList.Count;
            txtSerachWord = string.Empty;
            this.Close();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            LBL_SELECT.Text = "انتخاب :" + IdList.Count;
            dataGridView.Select();
            dataGridView.Focus();
            txtSerachWord = "";
                //Component.Text;
            LBL_SEARCH.Text = txtSerachWord;
            BindDataInDataGridView(DataType);
        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (IdList.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    for (int j = 0; j < IdList.Count; j++)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value.ToString()) == IdList[j])
                        {
                            row.DefaultCellStyle.BackColor = Color.Green;
                            row.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            txtSelectCount = "تعداد انتخاب شده: " + IdList.Count;
            txtSerachWord = string.Empty;
            this.Close();
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable temp = null;
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                txtSerachWord += e.KeyChar;
            }
            else
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    if (txtSerachWord.Length > 0)
                    {
                        txtSerachWord = txtSerachWord.Substring(0, (txtSerachWord.Length - 1));
                    }
                }
            }
            if (dataGridView.DataSource.GetType() == typeof(DataView))
            {
                temp = (dataGridView.DataSource as DataView).Table;
            }
            else
            {
                temp = (DataTable)dataGridView.DataSource;
            }

            LBL_SEARCH.Text = txtSerachWord;
            Search(temp, ColumnCondition, txtSerachWord);
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                if (dataGridView.CurrentCell.RowIndex != -1)
                {
                    if (dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DefaultCellStyle.BackColor != Color.Green)
                    {
                        IdList.Add(Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                        dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                        var itemToRemove =
                            IdList.Single(r => r.Equals(Convert.ToInt32(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString())));
                        IdList.Remove(itemToRemove);
                    }
                    if (dataGridView.CurrentRow.Index != (dataGridView.Rows.Count - 1))
                    {
                        dataGridView.CurrentRow.Selected = false;
                        dataGridView.Rows[dataGridView.CurrentCell.RowIndex + 1].Selected = true;
                        dataGridView.CurrentCell = dataGridView[1, dataGridView.CurrentCell.RowIndex + 1];
                    }
                    LBL_SELECT.Text = "انتخاب :" + IdList.Count;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                txtSelectCount = "تعداد انتخاب شده: " + IdList.Count;
                txtSerachWord = string.Empty;
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                LBL_SELECT.Text = txtSerachWord = string.Empty;
                SendKeys.Send("{BACKSPACE}");
                //Search(temp, ColumnCondition, txtSerachWord);
            }
        }

    }
}
