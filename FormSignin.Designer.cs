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
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_signin = new System.Windows.Forms.Button();
            this.panel_signin_pwd = new System.Windows.Forms.Panel();
            this.textBox_signin_pwd = new System.Windows.Forms.TextBox();
            this.label_signup_pwd = new System.Windows.Forms.Label();
            this.panel_signin_username = new System.Windows.Forms.Panel();
            this.textBox_signin_username = new System.Windows.Forms.TextBox();
            this.label_signup_username = new System.Windows.Forms.Label();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_signin_pwd.SuspendLayout();
            this.panel_signin_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.dataGridView1);
            this.panel_Logo.Location = new System.Drawing.Point(28, 30);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(442, 100);
            this.panel_Logo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 94);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(208, 303);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(81, 40);
            this.button_signin.TabIndex = 4;
            this.button_signin.Text = "Đăng nhập";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // panel_signin_pwd
            // 
            this.panel_signin_pwd.Controls.Add(this.textBox_signin_pwd);
            this.panel_signin_pwd.Controls.Add(this.label_signup_pwd);
            this.panel_signin_pwd.Location = new System.Drawing.Point(28, 220);
            this.panel_signin_pwd.Name = "panel_signin_pwd";
            this.panel_signin_pwd.Size = new System.Drawing.Size(442, 41);
            this.panel_signin_pwd.TabIndex = 6;
            // 
            // textBox_signin_pwd
            // 
            this.textBox_signin_pwd.Location = new System.Drawing.Point(121, 11);
            this.textBox_signin_pwd.Name = "textBox_signin_pwd";
            this.textBox_signin_pwd.Size = new System.Drawing.Size(318, 20);
            this.textBox_signin_pwd.TabIndex = 1;
            this.textBox_signin_pwd.UseSystemPasswordChar = true;
            // 
            // label_signup_pwd
            // 
            this.label_signup_pwd.AutoSize = true;
            this.label_signup_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_pwd.Location = new System.Drawing.Point(3, 11);
            this.label_signup_pwd.Name = "label_signup_pwd";
            this.label_signup_pwd.Size = new System.Drawing.Size(70, 16);
            this.label_signup_pwd.TabIndex = 0;
            this.label_signup_pwd.Text = "Mật khẩu";
            // 
            // panel_signin_username
            // 
            this.panel_signin_username.Controls.Add(this.textBox_signin_username);
            this.panel_signin_username.Controls.Add(this.label_signup_username);
            this.panel_signin_username.Location = new System.Drawing.Point(28, 148);
            this.panel_signin_username.Name = "panel_signin_username";
            this.panel_signin_username.Size = new System.Drawing.Size(442, 41);
            this.panel_signin_username.TabIndex = 5;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.Location = new System.Drawing.Point(121, 11);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(318, 20);
            this.textBox_signin_username.TabIndex = 1;
            // 
            // label_signup_username
            // 
            this.label_signup_username.AutoSize = true;
            this.label_signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_username.Location = new System.Drawing.Point(3, 11);
            this.label_signup_username.Name = "label_signup_username";
            this.label_signup_username.Size = new System.Drawing.Size(112, 16);
            this.label_signup_username.TabIndex = 0;
            this.label_signup_username.Text = "Tên đăng nhập";
            // 
            // form_signin
            // 
            this.AcceptButton = this.button_signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 368);
            this.Controls.Add(this.panel_signin_pwd);
            this.Controls.Add(this.panel_signin_username);
            this.Controls.Add(this.button_signin);
            this.Controls.Add(this.panel_Logo);
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_signin_Load);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_signin_pwd.ResumeLayout(false);
            this.panel_signin_pwd.PerformLayout();
            this.panel_signin_username.ResumeLayout(false);
            this.panel_signin_username.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Panel panel_signin_pwd;
        private System.Windows.Forms.TextBox textBox_signin_pwd;
        private System.Windows.Forms.Label label_signup_pwd;
        private System.Windows.Forms.Panel panel_signin_username;
        private System.Windows.Forms.TextBox textBox_signin_username;
        private System.Windows.Forms.Label label_signup_username;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

