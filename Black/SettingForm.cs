using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Black
{
    public partial class SettingForm : BaseForm
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        ClsSetting clsSetting = new ClsSetting();
        ClsEncryptionAndDecryption clsEncryptionAndDecryption = new ClsEncryptionAndDecryption();
        private string BACKGROUND_IMAGE;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                var set = clsSetting.SelectKeys("SHY_PERIOD", "SHY_SERVER", "SHY_BRIEFNAME", "SHY_PASSWORD", "BARCODE_TYPE", "BACKGROUND_IMAGE").Rows[0];
                if (set != null)
                {
                    txtSHY_BRIEFNAME.Text = set["SHY_BRIEFNAME"].ToString();
                    txtSHY_PERIOD.Text = set["SHY_PERIOD"].ToString();
                    txtSHY_SERVER.Text = set["SHY_SERVER"].ToString();
                    txtSHY_PASSWORD.Text = clsEncryptionAndDecryption.Decrypt(set["SHY_PASSWORD"].ToString());
                    if (set["BARCODE_TYPE"].ToString() == "1") rdbOne.Checked = true;
                    else if (set["BARCODE_TYPE"].ToString() == "2") rdbTwo.Checked = true;
                    BACKGROUND_IMAGE = set["BACKGROUND_IMAGE"].ToString();
                    picBackground.Image = ClsCommon.ConvertBase64ToImage(BACKGROUND_IMAGE);
                }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("خطا در باگذاری اطلاعات." + Environment.NewLine + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsSetting.Update("SHY_BRIEFNAME", txtSHY_BRIEFNAME.Text);
                clsSetting.Update("SHY_SERVER", txtSHY_SERVER.Text);
                clsSetting.Update("SHY_PERIOD", txtSHY_PERIOD.Text);
                clsSetting.Update("SHY_PASSWORD", clsEncryptionAndDecryption.Encrypt(txtSHY_PASSWORD.Text));
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("خطا در ثبت اطلاعات.");
            }
        }

        private void lblTest_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDataBase db = new ClsDataBase();
                SqlConnectionStringBuilder scb = new SqlConnectionStringBuilder(ClsDataBase.ConnectionString);
                scb.InitialCatalog = "CY" + txtSHY_BRIEFNAME.Text + txtSHY_PERIOD.Text;
                scb.DataSource = txtSHY_SERVER.Text;
                scb.Password = txtSHY_PASSWORD.Text;
                using (var l_oConnection = new SqlConnection(scb.ConnectionString))
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

        //----------------------------------------------------------------------------
        private void btnSelectBackground_Click(object sender, EventArgs e)
        {
            var openFileDialogPic = new OpenFileDialog();
            openFileDialogPic.Filter = "Images (*.BMP;*.JPG;*.PNG;)|*.BMP;*.JPG;*.PNG;|All files (*.*)|*.*";
            openFileDialogPic.Multiselect = false;
            openFileDialogPic.Title = "انتخاب عکس";
            GC.Collect();
            if (openFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    BACKGROUND_IMAGE = ClsCommon.ConvertImageToBase64(openFileDialogPic.FileName);
                    picBackground.Image = ClsCommon.ConvertBase64ToImage(BACKGROUND_IMAGE);
                    GC.Collect();
                }
                catch (Exception ex)
                {
                    ex.WriteLOG();
                }
            }
        }

        private void btnDeleteBackground_Click(object sender, EventArgs e)
        {
            try
            {
                BACKGROUND_IMAGE = "0";
                picBackground.Image = ClsCommon.ConvertBase64ToImage(BACKGROUND_IMAGE);
                GC.Collect();
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void btnSaveApp_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbTwo.Checked) clsSetting.Update("BARCODE_TYPE", "2");
                else if (rdbOne.Checked) clsSetting.Update("BARCODE_TYPE", "1");
                if (chkDefault.Checked)
                {
                    var bg = ClsCommon.ReadResource("Black.Resources.credit_cards_visa_money.jpg");
                    picBackground.Image = System.Drawing.Image.FromStream(bg);

                    using (Image image = picBackground.Image)
                    {
                        using (MemoryStream m = new MemoryStream())
                        {
                            image.Save(m, image.RawFormat);
                            byte[] imageBytes = m.ToArray();
                            BACKGROUND_IMAGE = Convert.ToBase64String(imageBytes);
                        }
                    }
                }
                clsSetting.Update("BACKGROUND_IMAGE", BACKGROUND_IMAGE);
                MessageBox.Show("اطلاعات با موفقیت ثبت شد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
                MessageBox.Show("خطا در ثبت اطلاعات.");
            }
        }
    }
}
