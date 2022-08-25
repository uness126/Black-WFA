namespace Black
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmBaseInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBusinessUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCustomerReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTransactionReport = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSqlSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBaseInfo,
            this.tsmReports,
            this.تنظیماتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmBaseInfo
            // 
            this.tsmBaseInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBusinessUnit,
            this.tsmCustomer,
            this.tsmUser,
            this.toolStripSeparator1,
            this.tsmLogout,
            this.tsmExit});
            this.tsmBaseInfo.Name = "tsmBaseInfo";
            this.tsmBaseInfo.Size = new System.Drawing.Size(82, 20);
            this.tsmBaseInfo.Text = "ثبت اطلاعات";
            // 
            // tsmBusinessUnit
            // 
            this.tsmBusinessUnit.Image = global::Black.Properties.Resources.bookmark_16;
            this.tsmBusinessUnit.Name = "tsmBusinessUnit";
            this.tsmBusinessUnit.ShortcutKeyDisplayString = "";
            this.tsmBusinessUnit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmBusinessUnit.Size = new System.Drawing.Size(180, 22);
            this.tsmBusinessUnit.Text = "شرکت جدید";
            this.tsmBusinessUnit.Click += new System.EventHandler(this.tsmBusinessUnit_Click);
            // 
            // tsmCustomer
            // 
            this.tsmCustomer.Image = global::Black.Properties.Resources.qrcode_16;
            this.tsmCustomer.Name = "tsmCustomer";
            this.tsmCustomer.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmCustomer.Size = new System.Drawing.Size(180, 22);
            this.tsmCustomer.Text = "مشترکین";
            this.tsmCustomer.Click += new System.EventHandler(this.tsmCustomer_Click);
            // 
            // tsmUser
            // 
            this.tsmUser.Image = global::Black.Properties.Resources.user_16;
            this.tsmUser.Name = "tsmUser";
            this.tsmUser.Size = new System.Drawing.Size(180, 22);
            this.tsmUser.Text = "تعریف کاربران";
            this.tsmUser.Click += new System.EventHandler(this.tsmUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmLogout
            // 
            this.tsmLogout.Image = global::Black.Properties.Resources.change_user16;
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmLogout.Text = "خروج کاربر";
            this.tsmLogout.Click += new System.EventHandler(this.tsmLogout_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Image = global::Black.Properties.Resources.close_32;
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmExit.Size = new System.Drawing.Size(180, 22);
            this.tsmExit.Text = "خروج";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmReports
            // 
            this.tsmReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCustomerReport,
            this.tsmTransactionReport});
            this.tsmReports.Name = "tsmReports";
            this.tsmReports.Size = new System.Drawing.Size(60, 20);
            this.tsmReports.Text = "گزارشات";
            this.tsmReports.Visible = false;
            // 
            // tsmCustomerReport
            // 
            this.tsmCustomerReport.Image = global::Black.Properties.Resources.qrcode_16;
            this.tsmCustomerReport.Name = "tsmCustomerReport";
            this.tsmCustomerReport.Size = new System.Drawing.Size(117, 22);
            this.tsmCustomerReport.Text = "مشترکین";
            // 
            // tsmTransactionReport
            // 
            this.tsmTransactionReport.Image = global::Black.Properties.Resources.transaction_16;
            this.tsmTransactionReport.Name = "tsmTransactionReport";
            this.tsmTransactionReport.Size = new System.Drawing.Size(117, 22);
            this.tsmTransactionReport.Text = "تراکنش";
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSqlSetting,
            this.tsmBackup,
            this.tsmSetting});
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // tsmSqlSetting
            // 
            this.tsmSqlSetting.Image = global::Black.Properties.Resources.database_16;
            this.tsmSqlSetting.Name = "tsmSqlSetting";
            this.tsmSqlSetting.Size = new System.Drawing.Size(137, 22);
            this.tsmSqlSetting.Text = "پایگاه داده";
            this.tsmSqlSetting.Click += new System.EventHandler(this.tsmSqlSetting_Click);
            // 
            // tsmBackup
            // 
            this.tsmBackup.Image = global::Black.Properties.Resources.backup_16;
            this.tsmBackup.Name = "tsmBackup";
            this.tsmBackup.Size = new System.Drawing.Size(137, 22);
            this.tsmBackup.Text = "پشتیبان گیری";
            this.tsmBackup.Click += new System.EventHandler(this.tsmBackup_Click);
            // 
            // tsmSetting
            // 
            this.tsmSetting.Image = global::Black.Properties.Resources.Network;
            this.tsmSetting.Name = "tsmSetting";
            this.tsmSetting.Size = new System.Drawing.Size(137, 22);
            this.tsmSetting.Text = "ارتباطات";
            this.tsmSetting.Click += new System.EventHandler(this.tsmSetting_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblStatus
            // 
            this.tslblStatus.Name = "tslblStatus";
            this.tslblStatus.Size = new System.Drawing.Size(16, 17);
            this.tslblStatus.Text = "...";
            this.tslblStatus.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = global::Black.Properties.Resources.transaction_32;
            this.pictureBox1.InitialImage = global::Black.Properties.Resources.transaction_32;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 442);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 466);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "باشگاه مشترکین";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmBaseInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmBusinessUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomer;
        private System.Windows.Forms.ToolStripMenuItem tsmReports;
        private System.Windows.Forms.ToolStripMenuItem tsmCustomerReport;
        private System.Windows.Forms.ToolStripMenuItem tsmTransactionReport;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSqlSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmBackup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
    }
}

