namespace HotelManagement_FireBase
{
    partial class FormReservation
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
            this.textBox_roomID = new System.Windows.Forms.TextBox();
            this.textBox_cmnd = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_checkIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_checkOut = new System.Windows.Forms.DateTimePicker();
            this.button_quit = new System.Windows.Forms.Button();
            this.button_booking = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 458);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 458);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_roomID, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBox_cmnd, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_phone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_fullname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_checkIn, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker_checkOut, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button_quit, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.button_booking, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.423689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.423689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.423689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.423689F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53511F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.48806F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 458);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox_roomID
            // 
            this.textBox_roomID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_roomID.Enabled = false;
            this.textBox_roomID.Location = new System.Drawing.Point(3, 337);
            this.textBox_roomID.Name = "textBox_roomID";
            this.textBox_roomID.Size = new System.Drawing.Size(197, 20);
            this.textBox_roomID.TabIndex = 26;
            // 
            // textBox_cmnd
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_cmnd, 2);
            this.textBox_cmnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_cmnd.Location = new System.Drawing.Point(3, 193);
            this.textBox_cmnd.Name = "textBox_cmnd";
            this.textBox_cmnd.Size = new System.Drawing.Size(401, 20);
            this.textBox_cmnd.TabIndex = 18;
            // 
            // textBox_phone
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_phone, 2);
            this.textBox_phone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_phone.Location = new System.Drawing.Point(3, 121);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(401, 20);
            this.textBox_phone.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỌ VÀ TÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SỐ ĐIỆN THOẠI";
            // 
            // textBox_fullname
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_fullname, 2);
            this.textBox_fullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_fullname.Location = new System.Drawing.Point(3, 49);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(401, 20);
            this.textBox_fullname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(3, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(206, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "CHECK OUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "CHECK IN";
            // 
            // dateTimePicker_checkIn
            // 
            this.dateTimePicker_checkIn.Location = new System.Drawing.Point(3, 265);
            this.dateTimePicker_checkIn.Name = "dateTimePicker_checkIn";
            this.dateTimePicker_checkIn.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_checkIn.TabIndex = 21;
            // 
            // dateTimePicker_checkOut
            // 
            this.dateTimePicker_checkOut.Location = new System.Drawing.Point(206, 265);
            this.dateTimePicker_checkOut.Name = "dateTimePicker_checkOut";
            this.dateTimePicker_checkOut.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_checkOut.TabIndex = 22;
            // 
            // button_quit
            // 
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_quit.Location = new System.Drawing.Point(206, 389);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(198, 40);
            this.button_quit.TabIndex = 24;
            this.button_quit.Text = "THOÁT";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // button_booking
            // 
            this.button_booking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_booking.Location = new System.Drawing.Point(3, 389);
            this.button_booking.Name = "button_booking";
            this.button_booking.Size = new System.Drawing.Size(197, 40);
            this.button_booking.TabIndex = 23;
            this.button_booking.Text = "ĐẶT PHÒNG";
            this.button_booking.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "PHÒNG";
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cmnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_checkIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_checkOut;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Button button_booking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_roomID;

    }
}