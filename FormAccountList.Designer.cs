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
            this.button_acc_add = new System.Windows.Forms.Button();
            this.panel_acc_info = new System.Windows.Forms.Panel();
            this.panel_accInfo_phonenum = new System.Windows.Forms.Panel();
            this.textBox_accInfo_phonenum = new System.Windows.Forms.TextBox();
            this.label_accInfo_phonenum = new System.Windows.Forms.Label();
            this.panel_accInfo_fullname = new System.Windows.Forms.Panel();
            this.textBox_accInfo_fullname = new System.Windows.Forms.TextBox();
            this.label_accInfo_fullname = new System.Windows.Forms.Label();
            this.panel_accInfo_gender = new System.Windows.Forms.Panel();
            this.textBox_accInfo_gender = new System.Windows.Forms.TextBox();
            this.label_accInfo_gender = new System.Windows.Forms.Label();
            this.panel_accInfo_pwd = new System.Windows.Forms.Panel();
            this.textBox_accInfo_pwd = new System.Windows.Forms.TextBox();
            this.label_accInfo_pwd = new System.Windows.Forms.Label();
            this.panel_accInfo_username = new System.Windows.Forms.Panel();
            this.textBox_accInfo_username = new System.Windows.Forms.TextBox();
            this.label_accInfo_username = new System.Windows.Forms.Label();
            this.button_acc_update = new System.Windows.Forms.Button();
            this.button_acc_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accInfo)).BeginInit();
            this.panel_acc_info.SuspendLayout();
            this.panel_accInfo_phonenum.SuspendLayout();
            this.panel_accInfo_fullname.SuspendLayout();
            this.panel_accInfo_gender.SuspendLayout();
            this.panel_accInfo_pwd.SuspendLayout();
            this.panel_accInfo_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_accInfo
            // 
            this.dataGridView_accInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_accInfo.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_accInfo.Name = "dataGridView_accInfo";
            this.dataGridView_accInfo.Size = new System.Drawing.Size(282, 229);
            this.dataGridView_accInfo.TabIndex = 0;
            this.dataGridView_accInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_accInfo_CellClick);
            // 
            // button_acc_add
            // 
            this.button_acc_add.Location = new System.Drawing.Point(389, 265);
            this.button_acc_add.Name = "button_acc_add";
            this.button_acc_add.Size = new System.Drawing.Size(75, 23);
            this.button_acc_add.TabIndex = 1;
            this.button_acc_add.Text = "Thêm";
            this.button_acc_add.UseVisualStyleBackColor = true;
            this.button_acc_add.Click += new System.EventHandler(this.button_add_account_Click);
            // 
            // panel_acc_info
            // 
            this.panel_acc_info.Controls.Add(this.panel_accInfo_phonenum);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_fullname);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_gender);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_pwd);
            this.panel_acc_info.Controls.Add(this.panel_accInfo_username);
            this.panel_acc_info.Location = new System.Drawing.Point(300, 12);
            this.panel_acc_info.Name = "panel_acc_info";
            this.panel_acc_info.Size = new System.Drawing.Size(339, 229);
            this.panel_acc_info.TabIndex = 2;
            // 
            // panel_accInfo_phonenum
            // 
            this.panel_accInfo_phonenum.Controls.Add(this.textBox_accInfo_phonenum);
            this.panel_accInfo_phonenum.Controls.Add(this.label_accInfo_phonenum);
            this.panel_accInfo_phonenum.Location = new System.Drawing.Point(2, 141);
            this.panel_accInfo_phonenum.Name = "panel_accInfo_phonenum";
            this.panel_accInfo_phonenum.Size = new System.Drawing.Size(334, 41);
            this.panel_accInfo_phonenum.TabIndex = 11;
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
            this.panel_accInfo_fullname.Location = new System.Drawing.Point(2, 94);
            this.panel_accInfo_fullname.Name = "panel_accInfo_fullname";
            this.panel_accInfo_fullname.Size = new System.Drawing.Size(334, 41);
            this.panel_accInfo_fullname.TabIndex = 10;
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
            this.panel_accInfo_gender.Controls.Add(this.textBox_accInfo_gender);
            this.panel_accInfo_gender.Controls.Add(this.label_accInfo_gender);
            this.panel_accInfo_gender.Location = new System.Drawing.Point(2, 188);
            this.panel_accInfo_gender.Name = "panel_accInfo_gender";
            this.panel_accInfo_gender.Size = new System.Drawing.Size(334, 41);
            this.panel_accInfo_gender.TabIndex = 9;
            // 
            // textBox_accInfo_gender
            // 
            this.textBox_accInfo_gender.Location = new System.Drawing.Point(121, 10);
            this.textBox_accInfo_gender.Name = "textBox_accInfo_gender";
            this.textBox_accInfo_gender.Size = new System.Drawing.Size(203, 20);
            this.textBox_accInfo_gender.TabIndex = 2;
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
            this.panel_accInfo_pwd.Location = new System.Drawing.Point(2, 47);
            this.panel_accInfo_pwd.Name = "panel_accInfo_pwd";
            this.panel_accInfo_pwd.Size = new System.Drawing.Size(334, 41);
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
            this.panel_accInfo_username.Location = new System.Drawing.Point(2, 0);
            this.panel_accInfo_username.Name = "panel_accInfo_username";
            this.panel_accInfo_username.Size = new System.Drawing.Size(334, 41);
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
            // button_acc_update
            // 
            this.button_acc_update.Location = new System.Drawing.Point(470, 265);
            this.button_acc_update.Name = "button_acc_update";
            this.button_acc_update.Size = new System.Drawing.Size(75, 23);
            this.button_acc_update.TabIndex = 3;
            this.button_acc_update.Text = "Cập nhật";
            this.button_acc_update.UseVisualStyleBackColor = true;
            // 
            // button_acc_del
            // 
            this.button_acc_del.Location = new System.Drawing.Point(551, 265);
            this.button_acc_del.Name = "button_acc_del";
            this.button_acc_del.Size = new System.Drawing.Size(75, 23);
            this.button_acc_del.TabIndex = 4;
            this.button_acc_del.Text = "Xoá";
            this.button_acc_del.UseVisualStyleBackColor = true;
            this.button_acc_del.Click += new System.EventHandler(this.button_acc_del_Click);
            // 
            // FormAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 303);
            this.Controls.Add(this.button_acc_del);
            this.Controls.Add(this.button_acc_update);
            this.Controls.Add(this.panel_acc_info);
            this.Controls.Add(this.button_acc_add);
            this.Controls.Add(this.dataGridView_accInfo);
            this.Name = "FormAccountList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAccountList";
            this.Load += new System.EventHandler(this.FormAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accInfo)).EndInit();
            this.panel_acc_info.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_accInfo;
        private System.Windows.Forms.Button button_acc_add;
        private System.Windows.Forms.Panel panel_acc_info;
        private System.Windows.Forms.Panel panel_accInfo_phonenum;
        private System.Windows.Forms.TextBox textBox_accInfo_phonenum;
        private System.Windows.Forms.Label label_accInfo_phonenum;
        private System.Windows.Forms.Panel panel_accInfo_fullname;
        private System.Windows.Forms.TextBox textBox_accInfo_fullname;
        private System.Windows.Forms.Label label_accInfo_fullname;
        private System.Windows.Forms.Panel panel_accInfo_gender;
        private System.Windows.Forms.TextBox textBox_accInfo_gender;
        private System.Windows.Forms.Label label_accInfo_gender;
        private System.Windows.Forms.Panel panel_accInfo_pwd;
        private System.Windows.Forms.TextBox textBox_accInfo_pwd;
        private System.Windows.Forms.Label label_accInfo_pwd;
        private System.Windows.Forms.Panel panel_accInfo_username;
        private System.Windows.Forms.TextBox textBox_accInfo_username;
        private System.Windows.Forms.Label label_accInfo_username;
        private System.Windows.Forms.Button button_acc_update;
        private System.Windows.Forms.Button button_acc_del;
    }
}