namespace Black
{
    partial class BusinessUnitForm
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.BusinessUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROW_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExitCompany = new System.Windows.Forms.Button();
            this.btnUpdateCompany = new System.Windows.Forms.Button();
            this.btnSaveCompany = new System.Windows.Forms.Button();
            this.btnNewCompany = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 150F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridViewCompany, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 77);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.23746F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(461, 142);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.AllowUserToAddRows = false;
            this.dataGridViewCompany.AllowUserToDeleteRows = false;
            this.dataGridViewCompany.AllowUserToResizeColumns = false;
            this.dataGridViewCompany.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompany.ColumnHeadersHeight = 30;
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.BusinessUnitId,
            this.ROW_NUMBER,
            this.BusinessUnitName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompany.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompany.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewCompany.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCompany.MultiSelect = false;
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCompany.RowHeadersVisible = false;
            this.dataGridViewCompany.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCompany.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCompany.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCompany.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewCompany.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompany.RowTemplate.Height = 30;
            this.dataGridViewCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompany.Size = new System.Drawing.Size(457, 138);
            this.dataGridViewCompany.TabIndex = 0;
            this.dataGridViewCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompany_CellClick);
            // 
            // Delete
            // 
            this.Delete.FillWeight = 40F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Black.Properties.Resources.delete_32;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BusinessUnitId
            // 
            this.BusinessUnitId.DataPropertyName = "BusinessUnitId";
            this.BusinessUnitId.HeaderText = "BusinessUnitId";
            this.BusinessUnitId.Name = "BusinessUnitId";
            this.BusinessUnitId.ReadOnly = true;
            this.BusinessUnitId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BusinessUnitId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BusinessUnitId.Visible = false;
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
            // BusinessUnitName
            // 
            this.BusinessUnitName.DataPropertyName = "Name";
            this.BusinessUnitName.FillWeight = 150F;
            this.BusinessUnitName.HeaderText = "نام شرکت";
            this.BusinessUnitName.Name = "BusinessUnitName";
            this.BusinessUnitName.ReadOnly = true;
            this.BusinessUnitName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BusinessUnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(461, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(395, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام شرکت:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(225, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 27);
            this.label10.TabIndex = 8;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(245, 2);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 22);
            this.txtName.TabIndex = 0;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnExitCompany, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnUpdateCompany, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSaveCompany, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnNewCompany, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(461, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnExitCompany
            // 
            this.btnExitCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExitCompany.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitCompany.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnExitCompany.Image = global::Black.Properties.Resources.close_32;
            this.btnExitCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitCompany.Location = new System.Drawing.Point(77, 2);
            this.btnExitCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitCompany.Name = "btnExitCompany";
            this.btnExitCompany.Size = new System.Drawing.Size(74, 46);
            this.btnExitCompany.TabIndex = 3;
            this.btnExitCompany.Text = "خروج";
            this.btnExitCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitCompany.UseVisualStyleBackColor = false;
            this.btnExitCompany.Click += new System.EventHandler(this.btnExitCompany_Click);
            // 
            // btnUpdateCompany
            // 
            this.btnUpdateCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdateCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateCompany.Enabled = false;
            this.btnUpdateCompany.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnUpdateCompany.Image = global::Black.Properties.Resources.save_yellow_32;
            this.btnUpdateCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCompany.Location = new System.Drawing.Point(155, 2);
            this.btnUpdateCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCompany.Name = "btnUpdateCompany";
            this.btnUpdateCompany.Size = new System.Drawing.Size(74, 46);
            this.btnUpdateCompany.TabIndex = 1;
            this.btnUpdateCompany.Text = "اصلاح";
            this.btnUpdateCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCompany.UseVisualStyleBackColor = false;
            this.btnUpdateCompany.Click += new System.EventHandler(this.btnUpdateCompany_Click);
            // 
            // btnSaveCompany
            // 
            this.btnSaveCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveCompany.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSaveCompany.Image = global::Black.Properties.Resources.save_green_32;
            this.btnSaveCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCompany.Location = new System.Drawing.Point(233, 2);
            this.btnSaveCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCompany.Name = "btnSaveCompany";
            this.btnSaveCompany.Size = new System.Drawing.Size(74, 46);
            this.btnSaveCompany.TabIndex = 0;
            this.btnSaveCompany.Text = "ثبت";
            this.btnSaveCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCompany.UseVisualStyleBackColor = false;
            this.btnSaveCompany.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnNewCompany
            // 
            this.btnNewCompany.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNewCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewCompany.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnNewCompany.Image = global::Black.Properties.Resources.add_32;
            this.btnNewCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCompany.Location = new System.Drawing.Point(311, 2);
            this.btnNewCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCompany.Name = "btnNewCompany";
            this.btnNewCompany.Size = new System.Drawing.Size(74, 46);
            this.btnNewCompany.TabIndex = 2;
            this.btnNewCompany.Text = "جدید";
            this.btnNewCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCompany.UseVisualStyleBackColor = false;
            this.btnNewCompany.Click += new System.EventHandler(this.btnNewCompany_Click);
            this.btnNewCompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 40F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Black.Properties.Resources.delete_32;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 79;
            // 
            // BusinessUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 219);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BusinessUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "معرفی شرکت";
            this.Load += new System.EventHandler(this.CreateCompanyForm_Load);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnExitCompany;
        private System.Windows.Forms.Button btnUpdateCompany;
        private System.Windows.Forms.Button btnSaveCompany;
        private System.Windows.Forms.Button btnNewCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROW_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessUnitName;
    }
}