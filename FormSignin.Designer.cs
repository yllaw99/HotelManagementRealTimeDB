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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_signin_username = new System.Windows.Forms.Panel();
            this.textBox_signin_username = new System.Windows.Forms.TextBox();
            this.label_signup_username = new System.Windows.Forms.Label();
            this.panel_signin_pwd = new System.Windows.Forms.Panel();
            this.textBox_signin_pwd = new System.Windows.Forms.TextBox();
            this.label_signup_pwd = new System.Windows.Forms.Label();
            this.button_signin = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_signin_username.SuspendLayout();
            this.panel_signin_pwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 532);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button_signin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(501, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 532);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_signin_username);
            this.panel3.Controls.Add(this.panel_signin_pwd);
            this.panel3.Location = new System.Drawing.Point(23, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 90);
            this.panel3.TabIndex = 6;
            // 
            // panel_signin_username
            // 
            this.panel_signin_username.Controls.Add(this.textBox_signin_username);
            this.panel_signin_username.Controls.Add(this.label_signup_username);
            this.panel_signin_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_signin_username.Location = new System.Drawing.Point(0, 8);
            this.panel_signin_username.Name = "panel_signin_username";
            this.panel_signin_username.Size = new System.Drawing.Size(314, 41);
            this.panel_signin_username.TabIndex = 1;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.Location = new System.Drawing.Point(121, 11);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(170, 20);
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
            // panel_signin_pwd
            // 
            this.panel_signin_pwd.Controls.Add(this.textBox_signin_pwd);
            this.panel_signin_pwd.Controls.Add(this.label_signup_pwd);
            this.panel_signin_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_signin_pwd.Location = new System.Drawing.Point(0, 49);
            this.panel_signin_pwd.Name = "panel_signin_pwd";
            this.panel_signin_pwd.Size = new System.Drawing.Size(314, 41);
            this.panel_signin_pwd.TabIndex = 2;
            // 
            // textBox_signin_pwd
            // 
            this.textBox_signin_pwd.Location = new System.Drawing.Point(121, 11);
            this.textBox_signin_pwd.Name = "textBox_signin_pwd";
            this.textBox_signin_pwd.Size = new System.Drawing.Size(170, 20);
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
            // button_signin
            // 
            this.button_signin.Location = new System.Drawing.Point(152, 318);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(81, 40);
            this.button_signin.TabIndex = 5;
            this.button_signin.Text = "Đăng nhập";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // form_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_signin_username.ResumeLayout(false);
            this.panel_signin_username.PerformLayout();
            this.panel_signin_pwd.ResumeLayout(false);
            this.panel_signin_pwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_signin_username;
        private System.Windows.Forms.Label label_signup_username;
        private System.Windows.Forms.Panel panel_signin_pwd;
        private System.Windows.Forms.TextBox textBox_signin_pwd;
        private System.Windows.Forms.Label label_signup_pwd;
        private System.Windows.Forms.Button button_signin;
        public System.Windows.Forms.TextBox textBox_signin_username;
    }
}

