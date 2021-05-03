namespace HotelManagement_FireBase
{
    partial class form_signin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_signup_username = new System.Windows.Forms.Label();
            this.textBox_signin_username = new System.Windows.Forms.TextBox();
            this.textBox_signin_pwd = new System.Windows.Forms.TextBox();
            this.label_signup_pwd = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_signin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 532);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 136);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(472, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 532);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.15011F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.84989F));
            this.tableLayoutPanel2.Controls.Add(this.label_signup_username, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_signin_username, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_signin_pwd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_signup_pwd, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.10239F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.897611F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 260);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label_signup_username
            // 
            this.label_signup_username.AutoSize = true;
            this.label_signup_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_username.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_signup_username.Location = new System.Drawing.Point(3, 210);
            this.label_signup_username.Name = "label_signup_username";
            this.label_signup_username.Size = new System.Drawing.Size(168, 24);
            this.label_signup_username.TabIndex = 12;
            this.label_signup_username.Text = "Tên đăng nhập";
            this.label_signup_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox_signin_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_signin_username.Location = new System.Drawing.Point(177, 211);
            this.textBox_signin_username.MaximumSize = new System.Drawing.Size(250, 20);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(215, 20);
            this.textBox_signin_username.TabIndex = 0;
            this.textBox_signin_username.Text = "t";
            // 
            // textBox_signin_pwd
            // 
            this.textBox_signin_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_signin_pwd.Location = new System.Drawing.Point(177, 237);
            this.textBox_signin_pwd.MaximumSize = new System.Drawing.Size(250, 20);
            this.textBox_signin_pwd.Name = "textBox_signin_pwd";
            this.textBox_signin_pwd.Size = new System.Drawing.Size(215, 20);
            this.textBox_signin_pwd.TabIndex = 1;
            this.textBox_signin_pwd.Text = "1";
            this.textBox_signin_pwd.UseSystemPasswordChar = true;
            // 
            // label_signup_pwd
            // 
            this.label_signup_pwd.AutoSize = true;
            this.label_signup_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_signup_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_pwd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_signup_pwd.Location = new System.Drawing.Point(3, 236);
            this.label_signup_pwd.Name = "label_signup_pwd";
            this.label_signup_pwd.Size = new System.Drawing.Size(168, 24);
            this.label_signup_pwd.TabIndex = 10;
            this.label_signup_pwd.Text = "Mật khẩu";
            this.label_signup_pwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_cancel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_signin, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 269);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(395, 260);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_cancel.FlatAppearance.BorderSize = 0;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_cancel.Location = new System.Drawing.Point(200, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(192, 40);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Thoát";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_signin.Location = new System.Drawing.Point(3, 3);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(191, 40);
            this.button_signin.TabIndex = 2;
            this.button_signin.Text = "Đăng nhập";
            this.button_signin.UseVisualStyleBackColor = false;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // form_signin
            // 
            this.AcceptButton = this.button_signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.button_signin_Click);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_signup_username;
        public System.Windows.Forms.TextBox textBox_signin_username;
        private System.Windows.Forms.TextBox textBox_signin_pwd;
        private System.Windows.Forms.Label label_signup_pwd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_signin;



    }
}

