using System.Windows.Forms;

namespace Black
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_USERNAME = new System.Windows.Forms.TextBox();
            this.TXT_PASSWORD = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnEnterLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 51);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.77193F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.22807F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TXT_USERNAME, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_PASSWORD, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.57534F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.42466F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(180, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "کلمه عبور:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام کاربری:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(2, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "*";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(2, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_USERNAME
            // 
            this.TXT_USERNAME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_USERNAME.Location = new System.Drawing.Point(28, 2);
            this.TXT_USERNAME.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_USERNAME.MaxLength = 15;
            this.TXT_USERNAME.Name = "TXT_USERNAME";
            this.TXT_USERNAME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_USERNAME.Size = new System.Drawing.Size(147, 22);
            this.TXT_USERNAME.TabIndex = 0;
            this.TXT_USERNAME.Enter += new System.EventHandler(this.ChangeLanguage_Enter);
            this.TXT_USERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectNextControl_KeyUp);
            // 
            // TXT_PASSWORD
            // 
            this.TXT_PASSWORD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_PASSWORD.Location = new System.Drawing.Point(28, 25);
            this.TXT_PASSWORD.Margin = new System.Windows.Forms.Padding(2);
            this.TXT_PASSWORD.MaxLength = 30;
            this.TXT_PASSWORD.Name = "TXT_PASSWORD";
            this.TXT_PASSWORD.PasswordChar = '●';
            this.TXT_PASSWORD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXT_PASSWORD.Size = new System.Drawing.Size(147, 22);
            this.TXT_PASSWORD.TabIndex = 1;
            this.TXT_PASSWORD.UseSystemPasswordChar = true;
            this.TXT_PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_PASSWORD_KeyDown);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.5679F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.4321F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel5.Controls.Add(this.btnCancelLogin, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnEnterLogin, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 43);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelLogin.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCancelLogin.Image = global::Black.Properties.Resources.close_32;
            this.btnCancelLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelLogin.Location = new System.Drawing.Point(44, 2);
            this.btnCancelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(79, 39);
            this.btnCancelLogin.TabIndex = 1;
            this.btnCancelLogin.Text = "خروج";
            this.btnCancelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnEnterLogin
            // 
            this.btnEnterLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnterLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnterLogin.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnEnterLogin.Image = global::Black.Properties.Resources.save_green_32;
            this.btnEnterLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnterLogin.Location = new System.Drawing.Point(127, 2);
            this.btnEnterLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterLogin.Name = "btnEnterLogin";
            this.btnEnterLogin.Size = new System.Drawing.Size(81, 39);
            this.btnEnterLogin.TabIndex = 0;
            this.btnEnterLogin.Text = "تایید";
            this.btnEnterLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnterLogin.Click += new System.EventHandler(this.btnEnterLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelLogin;
            this.ClientSize = new System.Drawing.Size(254, 96);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به برنامه";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Button btnCancelLogin;
        private Button btnEnterLogin;
        private TextBox TXT_USERNAME;
        private TextBox TXT_PASSWORD;
    }
}