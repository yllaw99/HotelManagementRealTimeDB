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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_signin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_signup_username = new System.Windows.Forms.Label();
            this.textBox_signin_username = new System.Windows.Forms.TextBox();
            this.textBox_signin_pwd = new System.Windows.Forms.TextBox();
            this.label_signup_pwd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_signin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.39098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.60902F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(873, 532);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // button_signin
            // 
            this.button_signin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_signin.Location = new System.Drawing.Point(439, 303);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(431, 40);
            this.button_signin.TabIndex = 2;
            this.button_signin.Text = "Đăng nhập";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(430, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.28306F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.71694F));
            this.tableLayoutPanel2.Controls.Add(this.label_signup_username, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_signin_username, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_signin_pwd, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label_signup_pwd, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(439, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.10239F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.897611F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(431, 294);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_signup_username
            // 
            this.label_signup_username.AutoSize = true;
            this.label_signup_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_username.Location = new System.Drawing.Point(3, 240);
            this.label_signup_username.Name = "label_signup_username";
            this.label_signup_username.Size = new System.Drawing.Size(158, 24);
            this.label_signup_username.TabIndex = 12;
            this.label_signup_username.Text = "Tên đăng nhập";
            this.label_signup_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_signin_username.Location = new System.Drawing.Point(167, 241);
            this.textBox_signin_username.MaximumSize = new System.Drawing.Size(250, 20);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(250, 20);
            this.textBox_signin_username.TabIndex = 0;
            // 
            // textBox_signin_pwd
            // 
            this.textBox_signin_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_signin_pwd.Location = new System.Drawing.Point(167, 271);
            this.textBox_signin_pwd.MaximumSize = new System.Drawing.Size(250, 20);
            this.textBox_signin_pwd.Name = "textBox_signin_pwd";
            this.textBox_signin_pwd.Size = new System.Drawing.Size(250, 20);
            this.textBox_signin_pwd.TabIndex = 1;
            this.textBox_signin_pwd.UseSystemPasswordChar = true;
            // 
            // label_signup_pwd
            // 
            this.label_signup_pwd.AutoSize = true;
            this.label_signup_pwd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_signup_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup_pwd.Location = new System.Drawing.Point(3, 270);
            this.label_signup_pwd.Name = "label_signup_pwd";
            this.label_signup_pwd.Size = new System.Drawing.Size(158, 24);
            this.label_signup_pwd.TabIndex = 10;
            this.label_signup_pwd.Text = "Mật khẩu";
            this.label_signup_pwd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // form_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_signup_username;
        public System.Windows.Forms.TextBox textBox_signin_username;
        private System.Windows.Forms.TextBox textBox_signin_pwd;
        private System.Windows.Forms.Label label_signup_pwd;

    }
}

