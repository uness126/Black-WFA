namespace Black
{
    partial class ShowCreditForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnQR = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCreditRemain = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnQR, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtBarcode, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(345, 41);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnQR
            // 
            this.btnQR.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQR.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnQR.Image = global::Black.Properties.Resources.qrcode_32;
            this.btnQR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQR.Location = new System.Drawing.Point(254, 2);
            this.btnQR.Margin = new System.Windows.Forms.Padding(2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(89, 37);
            this.btnQR.TabIndex = 2;
            this.btnQR.Text = "بارکد";
            this.btnQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(2, 4);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.txtBarcode.MaxLength = 10;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(248, 30);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtCreditRemain, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(341, 42);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtCreditRemain
            // 
            this.txtCreditRemain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCreditRemain.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditRemain.ForeColor = System.Drawing.Color.Black;
            this.txtCreditRemain.Location = new System.Drawing.Point(2, 2);
            this.txtCreditRemain.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreditRemain.MaxLength = 50;
            this.txtCreditRemain.Name = "txtCreditRemain";
            this.txtCreditRemain.ReadOnly = true;
            this.txtCreditRemain.Size = new System.Drawing.Size(244, 36);
            this.txtCreditRemain.TabIndex = 18;
            this.txtCreditRemain.TabStop = false;
            this.txtCreditRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label10.Location = new System.Drawing.Point(251, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 42);
            this.label10.TabIndex = 17;
            this.label10.Text = "اعتبار باقیمانده:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 91);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowCreditForm";
            this.Text = "اعتبار";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreditRemain;
    }
}