namespace HotelManagement_FireBase
{
    partial class FormAccountList
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
            this.dataGridView_accInfo = new System.Windows.Forms.DataGridView();
            this.panel_acc_info = new System.Windows.Forms.Panel();
            this.panel_accInfo_role = new System.Windows.Forms.Panel();
            this.comboBox_accInfo_role = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_accInfo_role = new System.Windows.Forms.Label();
            this.panel_accInfo_phonenum = new System.Windows.Forms.Panel();
            this.textBox_accInfo_phonenum = new System.Windows.Forms.TextBox();
            this.label_accInfo_phonenum = new System.Windows.Forms.Label();
            this.panel_accInfo_fullname = new System.Windows.Forms.Panel();
            this.textBox_accInfo_fullname = new System.Windows.Forms.TextBox();
            this.label_accInfo_fullname = new System.Windows.Forms.Label();
            this.panel_accInfo_gender = new System.Windows.Forms.Panel();
            this.comboBox_accInfo_gender = new System.Windows.Forms.ComboBox();
            this.label_accInfo_gender = new System.Windows.Forms.Label();
            this.panel_accInfo_pwd = new System.Windows.Forms.Panel();
            this.textBox_accInfo_pwd = new System.Windows.Forms.TextBox();
            this.label_accInfo_pwd = new System.Windows.Forms.Label();
            this.panel_accInfo_username = new System.Windows.Forms.Panel();
            this.textBox_accInfo_username = new System.Windows.Forms.TextBox();
            this.label_accInfo_username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_acc_update = new System.Windows.Forms.Button();
            this.button_acc_del = new System.Windows.Forms.Button();
            this.button_acc_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accInfo)).BeginInit();
            this.panel_acc_info.SuspendLayout();
            this.panel_accInfo_role.SuspendLayout();
            this.panel_accInfo_phonenum.SuspendLayout();
            this.panel_accInfo_fullname.SuspendLayout();
            this.panel_accInfo_gender.SuspendLayout();
            this.panel_accInfo_pwd.SuspendLayout();
            this.panel_accInfo_username.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_accInfo
            // 
            this.dataGridView_accInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_accInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView_accInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_accInfo.Name = "dataGridView_accInfo";
            this.dataGridView_accInfo.Size = new System.Drawing.Size(282, 303);
            this.dataGridView_accInfo.TabIndex = 0;
            this.dataGridView_accInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_accInfo_CellClick);
            // 
            // panel_acc_info
            // 
            this.panel_acc_info.Controls.Add(this.panel_accInfo_role);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_phonenum);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_fullname);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_gender);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_pwd);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_username);
            this.panel_acc_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_acc_info.Location = new System.Drawing.Point(282, 0);
            this.panel_acc_info.Name = "panel_acc_info";
            this.panel_acc_info.Size = new System.Drawing.Size(362, 261);
            this.panel_acc_info.TabIndex = 2;
            // 
            // panel_accInfo_role
            // 
            this.panel_accInfo_role.Controls.Add(this.comboBox_accInfo_role);
            this.panel_accInfo_role.Controls.Add(this.comboBox2);
            this.panel_accInfo_role.Controls.Add(this.label_accInfo_role);
            this.panel_accInfo_role.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_role.Location = new System.Drawing.Point(0, 205);
            this.panel_accInfo_role.Name = "panel_accInfo_role";
            this.panel_accInfo_role.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_role.TabIndex = 11;
            // 
            // comboBox_accInfo_role
            // 
            this.comboBox_accInfo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_accInfo_role.FormattingEnabled = true;
            this.comboBox_accInfo_role.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.comboBox_accInfo_role.Location = new System.Drawing.Point(121, 10);
            this.comboBox_accInfo_role.MaxDropDownItems = 2;
            this.comboBox_accInfo_role.Name = "comboBox_accInfo_role";
            this.comboBox_accInfo_role.Size = new System.Drawing.Size(203, 21);
            this.comboBox_accInfo_role.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox2.Location = new System.Drawing.Point(121, 10);
            this.comboBox2.MaxDropDownItems = 3;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label_accInfo_role
            // 
            this.label_accInfo_role.AutoSize = true;
            this.label_accInfo_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_role.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_role.Name = "label_accInfo_role";
            this.label_accInfo_role.Size = new System.Drawing.Size(62, 16);
            this.label_accInfo_role.TabIndex = 0;
            this.label_accInfo_role.Text = "Chức vụ";
            // 
            // panel_accInfo_phonenum
            // 
            this.panel_accInfo_phonenum.Controls.Add(this.textBox_accInfo_phonenum);
            this.panel_accInfo_phonenum.Controls.Add(this.label_accInfo_phonenum);
            this.panel_accInfo_phonenum.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_phonenum.Location = new System.Drawing.Point(0, 164);
            this.panel_accInfo_phonenum.Name = "panel_accInfo_phonenum";
            this.panel_accInfo_phonenum.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_phonenum.TabIndex = 10;
            // 
            // textBox_accInfo_phonenum
            // 
            this.textBox_accInfo_phonenum.Location = new System.Drawing.Point(121, 11);
            this.textBox_accInfo_phonenum.Name = "textBox_accInfo_phonenum";
            this.textBox_accInfo_phonenum.Size = new System.Drawing.Size(203, 20);
            this.textBox_accInfo_phonenum.TabIndex = 1;
            // 
            // label_accInfo_phonenum
            // 
            this.label_accInfo_phonenum.AutoSize = true;
            this.label_accInfo_phonenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_phonenum.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_phonenum.Name = "label_accInfo_phonenum";
            this.label_accInfo_phonenum.Size = new System.Drawing.Size(99, 16);
            this.label_accInfo_phonenum.TabIndex = 0;
            this.label_accInfo_phonenum.Text = "Số điện thoại";
            // 
            // panel_accInfo_fullname
            // 
            this.panel_accInfo_fullname.Controls.Add(this.textBox_accInfo_fullname);
            this.panel_accInfo_fullname.Controls.Add(this.label_accInfo_fullname);
            this.panel_accInfo_fullname.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_fullname.Location = new System.Drawing.Point(0, 123);
            this.panel_accInfo_fullname.Name = "panel_accInfo_fullname";
            this.panel_accInfo_fullname.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_fullname.TabIndex = 9;
            // 
            // textBox_accInfo_fullname
            // 
            this.textBox_accInfo_fullname.Location = new System.Drawing.Point(121, 11);
            this.textBox_accInfo_fullname.Name = "textBox_accInfo_fullname";
            this.textBox_accInfo_fullname.Size = new System.Drawing.Size(203, 20);
            this.textBox_accInfo_fullname.TabIndex = 1;
            // 
            // label_accInfo_fullname
            // 
            this.label_accInfo_fullname.AutoSize = true;
            this.label_accInfo_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_fullname.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_fullname.Name = "label_accInfo_fullname";
            this.label_accInfo_fullname.Size = new System.Drawing.Size(74, 16);
            this.label_accInfo_fullname.TabIndex = 0;
            this.label_accInfo_fullname.Text = "Họ và tên";
            // 
            // panel_accInfo_gender
            // 
            this.panel_accInfo_gender.Controls.Add(this.comboBox_accInfo_gender);
            this.panel_accInfo_gender.Controls.Add(this.label_accInfo_gender);
            this.panel_accInfo_gender.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_gender.Location = new System.Drawing.Point(0, 82);
            this.panel_accInfo_gender.Name = "panel_accInfo_gender";
            this.panel_accInfo_gender.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_gender.TabIndex = 8;
            // 
            // comboBox_accInfo_gender
            // 
            this.comboBox_accInfo_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_accInfo_gender.FormattingEnabled = true;
            this.comboBox_accInfo_gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBox_accInfo_gender.Location = new System.Drawing.Point(121, 10);
            this.comboBox_accInfo_gender.MaxDropDownItems = 2;
            this.comboBox_accInfo_gender.Name = "comboBox_accInfo_gender";
            this.comboBox_accInfo_gender.Size = new System.Drawing.Size(203, 21);
            this.comboBox_accInfo_gender.TabIndex = 4;
            // 
            // label_accInfo_gender
            // 
            this.label_accInfo_gender.AutoSize = true;
            this.label_accInfo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_gender.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_gender.Name = "label_accInfo_gender";
            this.label_accInfo_gender.Size = new System.Drawing.Size(64, 16);
            this.label_accInfo_gender.TabIndex = 0;
            this.label_accInfo_gender.Text = "Giới tính";
            // 
            // panel_accInfo_pwd
            // 
            this.panel_accInfo_pwd.Controls.Add(this.textBox_accInfo_pwd);
            this.panel_accInfo_pwd.Controls.Add(this.label_accInfo_pwd);
            this.panel_accInfo_pwd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_pwd.Location = new System.Drawing.Point(0, 41);
            this.panel_accInfo_pwd.Name = "panel_accInfo_pwd";
            this.panel_accInfo_pwd.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_pwd.TabIndex = 7;
            // 
            // textBox_accInfo_pwd
            // 
            this.textBox_accInfo_pwd.Location = new System.Drawing.Point(121, 11);
            this.textBox_accInfo_pwd.Name = "textBox_accInfo_pwd";
            this.textBox_accInfo_pwd.Size = new System.Drawing.Size(203, 20);
            this.textBox_accInfo_pwd.TabIndex = 1;
            // 
            // label_accInfo_pwd
            // 
            this.label_accInfo_pwd.AutoSize = true;
            this.label_accInfo_pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_pwd.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_pwd.Name = "label_accInfo_pwd";
            this.label_accInfo_pwd.Size = new System.Drawing.Size(70, 16);
            this.label_accInfo_pwd.TabIndex = 0;
            this.label_accInfo_pwd.Text = "Mật khẩu";
            // 
            // panel_accInfo_username
            // 
            this.panel_accInfo_username.Controls.Add(this.textBox_accInfo_username);
            this.panel_accInfo_username.Controls.Add(this.label_accInfo_username);
            this.panel_accInfo_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_accInfo_username.Location = new System.Drawing.Point(0, 0);
            this.panel_accInfo_username.Name = "panel_accInfo_username";
            this.panel_accInfo_username.Size = new System.Drawing.Size(362, 41);
            this.panel_accInfo_username.TabIndex = 6;
            // 
            // textBox_accInfo_username
            // 
            this.textBox_accInfo_username.Location = new System.Drawing.Point(121, 11);
            this.textBox_accInfo_username.Name = "textBox_accInfo_username";
            this.textBox_accInfo_username.Size = new System.Drawing.Size(203, 20);
            this.textBox_accInfo_username.TabIndex = 1;
            // 
            // label_accInfo_username
            // 
            this.label_accInfo_username.AutoSize = true;
            this.label_accInfo_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_accInfo_username.Location = new System.Drawing.Point(3, 11);
            this.label_accInfo_username.Name = "label_accInfo_username";
            this.label_accInfo_username.Size = new System.Drawing.Size(112, 16);
            this.label_accInfo_username.TabIndex = 0;
            this.label_accInfo_username.Text = "Tên đăng nhập";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_acc_update);
            this.panel1.Controls.Add(this.button_acc_del);
            this.panel1.Controls.Add(this.button_acc_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(282, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 42);
            this.panel1.TabIndex = 6;
            // 
            // button_acc_update
            // 
            this.button_acc_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_acc_update.Location = new System.Drawing.Point(102, 0);
            this.button_acc_update.Name = "button_acc_update";
            this.button_acc_update.Size = new System.Drawing.Size(158, 42);
            this.button_acc_update.TabIndex = 5;
            this.button_acc_update.Text = "Cập nhật";
            this.button_acc_update.UseVisualStyleBackColor = true;
            this.button_acc_update.Click += new System.EventHandler(this.button_acc_update_Click);
            // 
            // button_acc_del
            // 
            this.button_acc_del.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_acc_del.Location = new System.Drawing.Point(260, 0);
            this.button_acc_del.Name = "button_acc_del";
            this.button_acc_del.Size = new System.Drawing.Size(102, 42);
            this.button_acc_del.TabIndex = 4;
            this.button_acc_del.Text = "Xoá";
            this.button_acc_del.UseVisualStyleBackColor = true;
            this.button_acc_del.Click += new System.EventHandler(this.button_acc_del_Click);
            // 
            // button_acc_add
            // 
            this.button_acc_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_acc_add.Location = new System.Drawing.Point(0, 0);
            this.button_acc_add.Name = "button_acc_add";
            this.button_acc_add.Size = new System.Drawing.Size(102, 42);
            this.button_acc_add.TabIndex = 1;
            this.button_acc_add.Text = "Thêm";
            this.button_acc_add.UseVisualStyleBackColor = true;
            this.button_acc_add.Click += new System.EventHandler(this.button_add_account_Click);
            // 
            // FormAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 303);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_acc_info);
            this.Controls.Add(this.dataGridView_accInfo);
            this.Name = "FormAccountList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí tài khoản";
            this.Load += new System.EventHandler(this.FormAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accInfo)).EndInit();
            this.panel_acc_info.ResumeLayout(false);
            this.panel_accInfo_role.ResumeLayout(false);
            this.panel_accInfo_role.PerformLayout();
            this.panel_accInfo_phonenum.ResumeLayout(false);
            this.panel_accInfo_phonenum.PerformLayout();
            this.panel_accInfo_fullname.ResumeLayout(false);
            this.panel_accInfo_fullname.PerformLayout();
            this.panel_accInfo_gender.ResumeLayout(false);
            this.panel_accInfo_gender.PerformLayout();
            this.panel_accInfo_pwd.ResumeLayout(false);
            this.panel_accInfo_pwd.PerformLayout();
            this.panel_accInfo_username.ResumeLayout(false);
            this.panel_accInfo_username.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_accInfo;
        private System.Windows.Forms.Panel panel_acc_info;
        private System.Windows.Forms.Panel panel_accInfo_phonenum;
        private System.Windows.Forms.TextBox textBox_accInfo_phonenum;
        private System.Windows.Forms.Label label_accInfo_phonenum;
        private System.Windows.Forms.Panel panel_accInfo_fullname;
        private System.Windows.Forms.TextBox textBox_accInfo_fullname;
        private System.Windows.Forms.Label label_accInfo_fullname;
        private System.Windows.Forms.Panel panel_accInfo_gender;
        private System.Windows.Forms.Label label_accInfo_gender;
        private System.Windows.Forms.Panel panel_accInfo_pwd;
        private System.Windows.Forms.TextBox textBox_accInfo_pwd;
        private System.Windows.Forms.Label label_accInfo_pwd;
        private System.Windows.Forms.Panel panel_accInfo_username;
        private System.Windows.Forms.TextBox textBox_accInfo_username;
        private System.Windows.Forms.Label label_accInfo_username;
        private System.Windows.Forms.Panel panel_accInfo_role;
        private System.Windows.Forms.Label label_accInfo_role;
        private System.Windows.Forms.ComboBox comboBox_accInfo_role;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox_accInfo_gender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_acc_update;
        private System.Windows.Forms.Button button_acc_del;
        private System.Windows.Forms.Button button_acc_add;
    }
}