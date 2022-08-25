using System.Windows.Forms;

namespace Black
{
    partial class UsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExitUsers = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROW_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnSaveUsers = new System.Windows.Forms.Button();
            this.btnNewUsers = new System.Windows.Forms.Button();
            this.CHK_SHOW_ALL = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbRoleId = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRole = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.cRoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowPassword = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rowguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 150F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // btnExitUsers
            // 
            this.btnExitUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExitUsers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitUsers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExitUsers.Image = global::Black.Properties.Resources.close_32;
            this.btnExitUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitUsers.Location = new System.Drawing.Point(2, 2);
            this.btnExitUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitUsers.Name = "btnExitUsers";
            this.btnExitUsers.Size = new System.Drawing.Size(82, 45);
            this.btnExitUsers.TabIndex = 3;
            this.btnExitUsers.Text = "خروج";
            this.btnExitUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitUsers.UseVisualStyleBackColor = false;
            this.btnExitUsers.Click += new System.EventHandler(this.btnExitUsers_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 335);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "کاربران";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewUsers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 302);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeight = 30;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.UserId,
            this.ROW_NUMBER,
            this.FirstName,
            this.LastName,
            this.UserName,
            this.RoleId,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(2, 162);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewUsers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowTemplate.Height = 42;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(536, 138);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellClick);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Black.Properties.Resources.delete_32;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Visible = false;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserId.Visible = false;
            // 
            // ROW_NUMBER
            // 
            this.ROW_NUMBER.DataPropertyName = "ROW_NUMBER";
            this.ROW_NUMBER.FillWeight = 40F;
            this.ROW_NUMBER.HeaderText = "ردیف";
            this.ROW_NUMBER.Name = "ROW_NUMBER";
            this.ROW_NUMBER.ReadOnly = true;
            this.ROW_NUMBER.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ROW_NUMBER.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "نام";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "نام کاربری";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.HeaderText = "RoleId";
            this.RoleId.Name = "RoleId";
            this.RoleId.ReadOnly = true;
            this.RoleId.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel5.Controls.Add(this.btnExitUsers, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnUpdateUsers, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSaveUsers, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnNewUsers, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.CHK_SHOW_ALL, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(25, 110);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(515, 49);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateUsers.Enabled = false;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateUsers.Image = global::Black.Properties.Resources.save_yellow_32;
            this.btnUpdateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.Location = new System.Drawing.Point(88, 2);
            this.btnUpdateUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(82, 45);
            this.btnUpdateUsers.TabIndex = 1;
            this.btnUpdateUsers.Text = "اصلاح";
            this.btnUpdateUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
            // 
            // btnSaveUsers
            // 
            this.btnSaveUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveUsers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSaveUsers.Image = global::Black.Properties.Resources.save_green_32;
            this.btnSaveUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUsers.Location = new System.Drawing.Point(174, 2);
            this.btnSaveUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveUsers.Name = "btnSaveUsers";
            this.btnSaveUsers.Size = new System.Drawing.Size(82, 45);
            this.btnSaveUsers.TabIndex = 0;
            this.btnSaveUsers.Text = "ثبت";
            this.btnSaveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUsers.UseVisualStyleBackColor = false;
            this.btnSaveUsers.Click += new System.EventHandler(this.btnSaveUsers_Click);
            // 
            // btnNewUsers
            // 
            this.btnNewUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewUsers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNewUsers.Image = global::Black.Properties.Resources.add_32;
            this.btnNewUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUsers.Location = new System.Drawing.Point(260, 2);
            this.btnNewUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewUsers.Name = "btnNewUsers";
            this.btnNewUsers.Size = new System.Drawing.Size(82, 45);
            this.btnNewUsers.TabIndex = 2;
            this.btnNewUsers.Text = "جدید";
            this.btnNewUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUsers.UseVisualStyleBackColor = false;
            this.btnNewUsers.Click += new System.EventHandler(this.btnNewUsers_Click);
            // 
            // CHK_SHOW_ALL
            // 
            this.CHK_SHOW_ALL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHK_SHOW_ALL.Location = new System.Drawing.Point(346, 2);
            this.CHK_SHOW_ALL.Margin = new System.Windows.Forms.Padding(2);
            this.CHK_SHOW_ALL.Name = "CHK_SHOW_ALL";
            this.CHK_SHOW_ALL.Size = new System.Drawing.Size(167, 45);
            this.CHK_SHOW_ALL.TabIndex = 13;
            this.CHK_SHOW_ALL.Text = "نمایش کاربران غیرفعال";
            this.CHK_SHOW_ALL.CheckedChanged += new System.EventHandler(this.CHK_SHOW_ALL_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.77311F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.22689F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Controls.Add(this.label21, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label12, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLastName, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUserName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label16, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label13, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkStatus, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbRoleId, 4, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 110);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(2, 55);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 30);
            this.label21.TabIndex = 10;
            this.label21.Text = "*";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(2, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 30);
            this.label12.TabIndex = 10;
            this.label12.Text = "*";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(468, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(210, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(294, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(314, 2);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(149, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Enter += new System.EventHandler(this.ChangeLanguage_Enter);
            this.txtFirstName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(46, 2);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 22);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Enter += new System.EventHandler(this.ChangeLanguage_Enter);
            this.txtLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(468, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "نام کاربری:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(314, 32);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(149, 22);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Enter += new System.EventHandler(this.ChangeLanguage_Enter);
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(294, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "*";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(210, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "کلمه عبور:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(46, 32);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(159, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Enter += new System.EventHandler(this.ChangeLanguage_Enter);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(2, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 25);
            this.label16.TabIndex = 9;
            this.label16.Text = "*";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(210, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 30);
            this.label13.TabIndex = 12;
            this.label13.Text = "گروه:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkStatus
            // 
            this.chkStatus.Location = new System.Drawing.Point(348, 87);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(2);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(115, 21);
            this.chkStatus.TabIndex = 5;
            this.chkStatus.Text = "فعال";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(468, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "وضعیت:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRoleId
            // 
            this.cmbRoleId.FormattingEnabled = true;
            this.cmbRoleId.Location = new System.Drawing.Point(47, 58);
            this.cmbRoleId.Name = "cmbRoleId";
            this.cmbRoleId.Size = new System.Drawing.Size(157, 22);
            this.cmbRoleId.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "سطح دسترسی";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgvRoles, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 302);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnSaveRole, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnExit, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 252);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(540, 50);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnSaveRole
            // 
            this.btnSaveRole.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveRole.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSaveRole.Image = global::Black.Properties.Resources.save_green_32;
            this.btnSaveRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveRole.Location = new System.Drawing.Point(272, 2);
            this.btnSaveRole.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveRole.Name = "btnSaveRole";
            this.btnSaveRole.Size = new System.Drawing.Size(82, 46);
            this.btnSaveRole.TabIndex = 0;
            this.btnSaveRole.Text = "ثبت";
            this.btnSaveRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveRole.UseVisualStyleBackColor = false;
            this.btnSaveRole.Click += new System.EventHandler(this.btnSaveRole_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExit.Image = global::Black.Properties.Resources.close_32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(186, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExitUsers_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AllowUserToAddRows = false;
            this.dgvRoles.AllowUserToDeleteRows = false;
            this.dgvRoles.AllowUserToResizeColumns = false;
            this.dgvRoles.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoles.ColumnHeadersHeight = 30;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRoleId,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ShowPassword,
            this.rowguid});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(2, 2);
            this.dgvRoles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRoles.MultiSelect = false;
            this.dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoles.RowHeadersVisible = false;
            this.dgvRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoles.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvRoles.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowTemplate.Height = 30;
            this.dgvRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoles.Size = new System.Drawing.Size(536, 248);
            this.dgvRoles.TabIndex = 1;
            // 
            // cRoleId
            // 
            this.cRoleId.DataPropertyName = "RoleId";
            this.cRoleId.HeaderText = "RoleId";
            this.cRoleId.Name = "cRoleId";
            this.cRoleId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cRoleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRoleId.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ROW_NUMBER";
            this.dataGridViewTextBoxColumn2.FillWeight = 40F;
            this.dataGridViewTextBoxColumn2.HeaderText = "ردیف";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "نام";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ShowPassword
            // 
            this.ShowPassword.DataPropertyName = "ShowPassword";
            this.ShowPassword.HeaderText = "نمایش پسورد";
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rowguid
            // 
            this.rowguid.DataPropertyName = "rowguid";
            this.rowguid.HeaderText = "rowguid";
            this.rowguid.Name = "rowguid";
            this.rowguid.Visible = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitUsers;
            this.ClientSize = new System.Drawing.Size(554, 335);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعریف کاربران";
            this.Load += new System.EventHandler(this.SystemUsersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private TextBox txtFirstName;
        private TextBox txtUserName;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Button btnSaveUsers;
        private Button btnNewUsers;
        private Button btnUpdateUsers;
        private Button btnExitUsers;
        private System.Windows.Forms.Label label13;
        private CheckBox chkStatus;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private CheckBox CHK_SHOW_ALL;
        private DataGridViewImageColumn Delete;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn ROW_NUMBER;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn RoleId;
        private DataGridViewCheckBoxColumn Status;
        private ComboBox cmbRoleId;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dgvRoles;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnSaveRole;
        private Button btnExit;
        private DataGridViewTextBoxColumn cRoleId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn ShowPassword;
        private DataGridViewTextBoxColumn rowguid;
    }
}