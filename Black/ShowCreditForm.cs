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
    public partial class ShowCreditForm : BaseForm
    {
        public ShowCreditForm()
        {
            InitializeComponent();
        }
        ClsCustomer clsCustomer = new ClsCustomer();

        private void btnQR_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = clsCustomer.SelectAllCustomer(txtBarcode.Text);
                if (dt.Rows.Count > 0)
                {
                    txtCreditRemain.Text = Convert.ToDecimal(dt.Rows[0]["CreditRemain"] == DBNull.Value ? "0" : dt.Rows[0]["CreditRemain"].ToString()).ToString("N0");
                    txtBarcode.Text = string.Empty;
                    txtBarcode.Select();
                }
                else
                {
                    MessageBox.Show("بارکد نامعتبر است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnQR.PerformClick();
                e.Handled = true;
            }
        }
    }
}
