using System.Windows.Forms;

namespace Black
{
    partial class FastReportPreviewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastReportPreviewForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_PRINT = new System.Windows.Forms.Button();
            this.BTN_PRINT_SETTING = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ZOOM_IN = new System.Windows.Forms.Button();
            this.BTN_ZOOM_OUT = new System.Windows.Forms.Button();
            this.BTN_END_PAGE = new System.Windows.Forms.Button();
            this.TXT_PAGE_NUMBER = new System.Windows.Forms.TextBox();
            this.BTN_FIRST_PAGE = new System.Windows.Forms.Button();
            this.BTN_PRIOR = new System.Windows.Forms.Button();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_EXPORT_PDF = new System.Windows.Forms.Button();
            this.BTN_EXPORT_EXCEL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.previewControl1 = new FastReport.Preview.PreviewControl();
            this.exportSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1169, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 49);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 15;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_PRINT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_PRINT_SETTING, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_EDIT, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_ZOOM_IN, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_ZOOM_OUT, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_END_PAGE, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_PAGE_NUMBER, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_FIRST_PAGE, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_PRIOR, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_NEXT, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_EXIT, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_EXPORT_PDF, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_EXPORT_EXCEL, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1161, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BTN_PRINT
            // 
            this.BTN_PRINT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_PRINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PRINT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_PRINT.Location = new System.Drawing.Point(1069, 3);
            this.BTN_PRINT.Name = "BTN_PRINT";
            this.BTN_PRINT.Size = new System.Drawing.Size(89, 41);
            this.BTN_PRINT.TabIndex = 0;
            this.BTN_PRINT.Text = "چاپ";
            this.BTN_PRINT.UseVisualStyleBackColor = false;
            this.BTN_PRINT.Click += new System.EventHandler(this.BTN_PRINT_Click);
            // 
            // BTN_PRINT_SETTING
            // 
            this.BTN_PRINT_SETTING.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_PRINT_SETTING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PRINT_SETTING.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_PRINT_SETTING.Location = new System.Drawing.Point(974, 3);
            this.BTN_PRINT_SETTING.Name = "BTN_PRINT_SETTING";
            this.BTN_PRINT_SETTING.Size = new System.Drawing.Size(89, 41);
            this.BTN_PRINT_SETTING.TabIndex = 0;
            this.BTN_PRINT_SETTING.Text = "تنظیمات";
            this.BTN_PRINT_SETTING.UseVisualStyleBackColor = false;
            this.BTN_PRINT_SETTING.Click += new System.EventHandler(this.BTN_PRINT_SETTING_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_EDIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EDIT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EDIT.Location = new System.Drawing.Point(879, 3);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(89, 41);
            this.BTN_EDIT.TabIndex = 0;
            this.BTN_EDIT.Text = "طراحی";
            this.BTN_EDIT.UseVisualStyleBackColor = false;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_ZOOM_IN
            // 
            this.BTN_ZOOM_IN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_ZOOM_IN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ZOOM_IN.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_ZOOM_IN.Location = new System.Drawing.Point(339, 4);
            this.BTN_ZOOM_IN.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ZOOM_IN.Name = "BTN_ZOOM_IN";
            this.BTN_ZOOM_IN.Size = new System.Drawing.Size(27, 39);
            this.BTN_ZOOM_IN.TabIndex = 0;
            this.BTN_ZOOM_IN.Text = "+";
            this.BTN_ZOOM_IN.UseVisualStyleBackColor = false;
            this.BTN_ZOOM_IN.Click += new System.EventHandler(this.BTN_ZOOM_IN_Click);
            // 
            // BTN_ZOOM_OUT
            // 
            this.BTN_ZOOM_OUT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_ZOOM_OUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ZOOM_OUT.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_ZOOM_OUT.Location = new System.Drawing.Point(304, 4);
            this.BTN_ZOOM_OUT.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ZOOM_OUT.Name = "BTN_ZOOM_OUT";
            this.BTN_ZOOM_OUT.Size = new System.Drawing.Size(27, 39);
            this.BTN_ZOOM_OUT.TabIndex = 0;
            this.BTN_ZOOM_OUT.Text = "-";
            this.BTN_ZOOM_OUT.UseVisualStyleBackColor = false;
            this.BTN_ZOOM_OUT.Click += new System.EventHandler(this.BTN_ZOOM_OUT_Click);
            // 
            // BTN_END_PAGE
            // 
            this.BTN_END_PAGE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_END_PAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_END_PAGE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_END_PAGE.Location = new System.Drawing.Point(218, 8);
            this.BTN_END_PAGE.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BTN_END_PAGE.Name = "BTN_END_PAGE";
            this.BTN_END_PAGE.Size = new System.Drawing.Size(44, 31);
            this.BTN_END_PAGE.TabIndex = 1;
            this.BTN_END_PAGE.Text = "انتها";
            this.BTN_END_PAGE.UseVisualStyleBackColor = false;
            this.BTN_END_PAGE.Click += new System.EventHandler(this.BTN_END_PAGE_Click);
            // 
            // TXT_PAGE_NUMBER
            // 
            this.TXT_PAGE_NUMBER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PAGE_NUMBER.Location = new System.Drawing.Point(103, 9);
            this.TXT_PAGE_NUMBER.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.TXT_PAGE_NUMBER.Name = "TXT_PAGE_NUMBER";
            this.TXT_PAGE_NUMBER.Size = new System.Drawing.Size(59, 28);
            this.TXT_PAGE_NUMBER.TabIndex = 2;
            this.TXT_PAGE_NUMBER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_FIRST_PAGE
            // 
            this.BTN_FIRST_PAGE.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_FIRST_PAGE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_FIRST_PAGE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_FIRST_PAGE.Location = new System.Drawing.Point(3, 8);
            this.BTN_FIRST_PAGE.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BTN_FIRST_PAGE.Name = "BTN_FIRST_PAGE";
            this.BTN_FIRST_PAGE.Size = new System.Drawing.Size(44, 31);
            this.BTN_FIRST_PAGE.TabIndex = 1;
            this.BTN_FIRST_PAGE.Text = "ابتدا";
            this.BTN_FIRST_PAGE.UseVisualStyleBackColor = false;
            this.BTN_FIRST_PAGE.Click += new System.EventHandler(this.BTN_FIRST_PAGE_Click);
            // 
            // BTN_PRIOR
            // 
            this.BTN_PRIOR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_PRIOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_PRIOR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_PRIOR.Location = new System.Drawing.Point(53, 8);
            this.BTN_PRIOR.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BTN_PRIOR.Name = "BTN_PRIOR";
            this.BTN_PRIOR.Size = new System.Drawing.Size(44, 31);
            this.BTN_PRIOR.TabIndex = 1;
            this.BTN_PRIOR.Text = "قبلی";
            this.BTN_PRIOR.UseVisualStyleBackColor = false;
            this.BTN_PRIOR.Click += new System.EventHandler(this.BTN_PRIOR_Click);
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_NEXT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_NEXT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_NEXT.Location = new System.Drawing.Point(168, 8);
            this.BTN_NEXT.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(44, 31);
            this.BTN_NEXT.TabIndex = 1;
            this.BTN_NEXT.Text = "بعدی";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_EXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_EXIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EXIT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXIT.Location = new System.Drawing.Point(674, 3);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(89, 41);
            this.BTN_EXIT.TabIndex = 0;
            this.BTN_EXIT.Text = "خروج";
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // BTN_EXPORT_PDF
            // 
            this.BTN_EXPORT_PDF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_EXPORT_PDF.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_EXPORT_PDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EXPORT_PDF.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXPORT_PDF.Image = global::Black.Properties.Resources.adobe_acrobat_reader_32;
            this.BTN_EXPORT_PDF.Location = new System.Drawing.Point(824, 3);
            this.BTN_EXPORT_PDF.Name = "BTN_EXPORT_PDF";
            this.BTN_EXPORT_PDF.Size = new System.Drawing.Size(49, 41);
            this.BTN_EXPORT_PDF.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BTN_EXPORT_PDF, "PDF");
            this.BTN_EXPORT_PDF.UseVisualStyleBackColor = false;
            this.BTN_EXPORT_PDF.Click += new System.EventHandler(this.BTN_EXPORT_PDF_Click);
            // 
            // BTN_EXPORT_EXCEL
            // 
            this.BTN_EXPORT_EXCEL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_EXPORT_EXCEL.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_EXPORT_EXCEL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_EXPORT_EXCEL.Font = new System.Drawing.Font("B Titr", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTN_EXPORT_EXCEL.Image = global::Black.Properties.Resources.microsoft_excel_32;
            this.BTN_EXPORT_EXCEL.Location = new System.Drawing.Point(769, 3);
            this.BTN_EXPORT_EXCEL.Name = "BTN_EXPORT_EXCEL";
            this.BTN_EXPORT_EXCEL.Size = new System.Drawing.Size(49, 41);
            this.BTN_EXPORT_EXCEL.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BTN_EXPORT_EXCEL, "Excel");
            this.BTN_EXPORT_EXCEL.UseVisualStyleBackColor = false;
            this.BTN_EXPORT_EXCEL.Click += new System.EventHandler(this.BTN_EXPORT_EXCEL_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.previewControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 457);
            this.panel2.TabIndex = 0;
            // 
            // previewControl1
            // 
            this.previewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl1.Font = new System.Drawing.Font("B Nazanin", 8F);
            this.previewControl1.Location = new System.Drawing.Point(0, 0);
            this.previewControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.previewControl1.Name = "previewControl1";
            this.previewControl1.PageOffset = new System.Drawing.Point(10, 10);
            this.previewControl1.Size = new System.Drawing.Size(1161, 455);
            this.previewControl1.StatusbarVisible = false;
            this.previewControl1.TabIndex = 1;
            this.previewControl1.ToolbarVisible = false;
            this.previewControl1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2005;
            this.previewControl1.PageChanged += new System.EventHandler(this.previewControl1_PageChanged);
            // 
            // exportSaveDialog
            // 
            this.exportSaveDialog.CheckPathExists = false;
            // 
            // FastReportPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_EXIT;
            this.ClientSize = new System.Drawing.Size(1169, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FastReportPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیش نمایش";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FastReportPreviewForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FastReport.Preview.PreviewControl previewControl1;
        private Button BTN_PRINT;
        private Button BTN_PRINT_SETTING;
        private Button BTN_EDIT;
        private Button BTN_EXIT;
        private Button BTN_ZOOM_IN;
        private Button BTN_ZOOM_OUT;
        private Button BTN_END_PAGE;
        private TextBox TXT_PAGE_NUMBER;
        private Button BTN_FIRST_PAGE;
        private Button BTN_PRIOR;
        private Button BTN_NEXT;
        private Button BTN_EXPORT_PDF;
        private Button BTN_EXPORT_EXCEL;
        private System.Windows.Forms.SaveFileDialog exportSaveDialog;
        private ToolTip toolTip1;
    }
}