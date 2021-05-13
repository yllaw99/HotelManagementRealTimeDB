namespace HotelManagement_FireBase
{
    partial class FormCheckIn
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
            this.button_bookingCancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_checkInID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_roomID = new System.Windows.Forms.Label();
            this.label_cusName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.10386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.89614F));
            this.tableLayoutPanel1.Controls.Add(this.button_bookingCancel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_confirm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_roomID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_cusName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_checkInID, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.54545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_bookingCancel
            // 
            this.button_bookingCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_bookingCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bookingCancel.Location = new System.Drawing.Point(155, 215);
            this.button_bookingCancel.Name = "button_bookingCancel";
            this.button_bookingCancel.Size = new System.Drawing.Size(110, 57);
            this.button_bookingCancel.TabIndex = 7;
            this.button_bookingCancel.Text = "Huỷ đặt phòng";
            this.button_bookingCancel.UseVisualStyleBackColor = true;
            this.button_bookingCancel.Click += new System.EventHandler(this.button_bookingCancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(55, 215);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(94, 57);
            this.button_confirm.TabIndex = 6;
            this.button_confirm.Text = "Xác nhận";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_4
            // 
            this.label_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_4.AutoSize = true;
            this.label_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_4.Location = new System.Drawing.Point(3, 34);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(146, 16);
            this.label_4.TabIndex = 0;
            this.label_4.Text = "Họ tên khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mã nhận phòng";
            // 
            // textBox_checkInID
            // 
            this.textBox_checkInID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_checkInID.Location = new System.Drawing.Point(155, 166);
            this.textBox_checkInID.Name = "textBox_checkInID";
            this.textBox_checkInID.Size = new System.Drawing.Size(179, 20);
            this.textBox_checkInID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phòng";
            // 
            // label_roomID
            // 
            this.label_roomID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_roomID.AutoSize = true;
            this.label_roomID.Location = new System.Drawing.Point(155, 106);
            this.label_roomID.Name = "label_roomID";
            this.label_roomID.Size = new System.Drawing.Size(179, 13);
            this.label_roomID.TabIndex = 4;
            this.label_roomID.Text = "roomID";
            // 
            // label_cusName
            // 
            this.label_cusName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cusName.AutoSize = true;
            this.label_cusName.Location = new System.Drawing.Point(155, 36);
            this.label_cusName.Name = "label_cusName";
            this.label_cusName.Size = new System.Drawing.Size(179, 13);
            this.label_cusName.TabIndex = 5;
            this.label_cusName.Text = "cusName";
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.TextBox textBox_checkInID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_roomID;
        private System.Windows.Forms.Label label_cusName;
        private System.Windows.Forms.Button button_bookingCancel;
        private System.Windows.Forms.Button button_confirm;
    }
}