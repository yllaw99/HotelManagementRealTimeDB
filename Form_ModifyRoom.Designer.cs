namespace HotelManagement_FireBase
{
    partial class Form_ModifyRoom
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
            this.dataGridView_roomView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_dateCheckIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_roomStt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_roomID = new System.Windows.Forms.TextBox();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_deleteRoom = new System.Windows.Forms.Button();
            this.button_updateRoom = new System.Windows.Forms.Button();
            this.button_addRoom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.23858F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.76142F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_roomView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(591, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView_roomView
            // 
            this.dataGridView_roomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roomView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_roomView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_roomView.Name = "dataGridView_roomView";
            this.dataGridView_roomView.Size = new System.Drawing.Size(285, 343);
            this.dataGridView_roomView.TabIndex = 0;
            this.dataGridView_roomView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roomView_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53741F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.46259F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_dateCheckIn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_roomStt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_roomID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_roomType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(294, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.27988F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2449F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 343);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox_dateCheckIn
            // 
            this.textBox_dateCheckIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_dateCheckIn.Location = new System.Drawing.Point(130, 207);
            this.textBox_dateCheckIn.Name = "textBox_dateCheckIn";
            this.textBox_dateCheckIn.ReadOnly = true;
            this.textBox_dateCheckIn.Size = new System.Drawing.Size(161, 20);
            this.textBox_dateCheckIn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày";
            // 
            // comboBox_roomStt
            // 
            this.comboBox_roomStt.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_roomStt.FormattingEnabled = true;
            this.comboBox_roomStt.Items.AddRange(new object[] {
            "Trống",
            "Có người",
            "Đã đặt"});
            this.comboBox_roomStt.Location = new System.Drawing.Point(130, 139);
            this.comboBox_roomStt.Name = "comboBox_roomStt";
            this.comboBox_roomStt.Size = new System.Drawing.Size(161, 21);
            this.comboBox_roomStt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "TRẠNG THÁI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOẠI PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG";
            // 
            // textBox_roomID
            // 
            this.textBox_roomID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_roomID.Location = new System.Drawing.Point(130, 3);
            this.textBox_roomID.Name = "textBox_roomID";
            this.textBox_roomID.Size = new System.Drawing.Size(161, 20);
            this.textBox_roomID.TabIndex = 1;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Items.AddRange(new object[] {
            "Single Bed",
            "Double Bed",
            "Triple Bed",
            "Family"});
            this.comboBox_roomType.Location = new System.Drawing.Point(130, 71);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(161, 21);
            this.comboBox_roomType.TabIndex = 3;
            // 
            // panel1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 37);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button_deleteRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_updateRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_addRoom, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(288, 37);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button_deleteRoom
            // 
            this.button_deleteRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_deleteRoom.Location = new System.Drawing.Point(195, 3);
            this.button_deleteRoom.Name = "button_deleteRoom";
            this.button_deleteRoom.Size = new System.Drawing.Size(90, 31);
            this.button_deleteRoom.TabIndex = 5;
            this.button_deleteRoom.Text = "Xoá";
            this.button_deleteRoom.UseVisualStyleBackColor = true;
            this.button_deleteRoom.Click += new System.EventHandler(this.button_deleteRoom_Click);
            // 
            // button_updateRoom
            // 
            this.button_updateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_updateRoom.Location = new System.Drawing.Point(99, 3);
            this.button_updateRoom.Name = "button_updateRoom";
            this.button_updateRoom.Size = new System.Drawing.Size(90, 31);
            this.button_updateRoom.TabIndex = 4;
            this.button_updateRoom.Text = "Cập nhật";
            this.button_updateRoom.UseVisualStyleBackColor = true;
            this.button_updateRoom.Click += new System.EventHandler(this.button_updateRoom_Click);
            // 
            // button_addRoom
            // 
            this.button_addRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addRoom.Location = new System.Drawing.Point(3, 3);
            this.button_addRoom.Name = "button_addRoom";
            this.button_addRoom.Size = new System.Drawing.Size(90, 31);
            this.button_addRoom.TabIndex = 3;
            this.button_addRoom.Text = "Thêm";
            this.button_addRoom.UseVisualStyleBackColor = true;
            this.button_addRoom.Click += new System.EventHandler(this.button_addRoom_Click);
            // 
            // Form_ModifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_ModifyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ModifyRoom";
            this.Load += new System.EventHandler(this.Form_ModifyRoom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_roomView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_roomID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.TextBox textBox_dateCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_roomStt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_deleteRoom;
        private System.Windows.Forms.Button button_updateRoom;
        private System.Windows.Forms.Button button_addRoom;




    }
}