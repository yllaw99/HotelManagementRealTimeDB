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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModifyRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_roomView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_roomStt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_updateRoom = new ePOSOne.btnProduct.Button_WOC();
            this.button_addRoom = new ePOSOne.btnProduct.Button_WOC();
            this.button_deleteRoom = new ePOSOne.btnProduct.Button_WOC();
            this.textBox_dateCheckIn = new HotelManagement_FireBase.roundedTextbox();
            this.textBox_roomID = new HotelManagement_FireBase.roundedTextbox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 39);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 39);
            this.panel3.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(750, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 20);
            this.label16.TabIndex = 24;
            this.label16.Text = "X";
            this.label16.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 39);
            this.panel5.TabIndex = 18;
            this.panel5.Click += new System.EventHandler(this.panel5_click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(36, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_roomView
            // 
            this.dataGridView_roomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roomView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_roomView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_roomView.Name = "dataGridView_roomView";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView_roomView, 2);
            this.dataGridView_roomView.Size = new System.Drawing.Size(417, 363);
            this.dataGridView_roomView.TabIndex = 0;
            this.dataGridView_roomView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roomView_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.01274F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.98726F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_roomView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.19783F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.80217F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 369);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.53741F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.46259F));
            this.tableLayoutPanel2.Controls.Add(this.textBox_roomID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_dateCheckIn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_roomStt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_roomType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(426, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 300);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày check in";
            // 
            // comboBox_roomStt
            // 
            this.comboBox_roomStt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_roomStt.FormattingEnabled = true;
            this.comboBox_roomStt.Items.AddRange(new object[] {
            "Trống",
            "Có người",
            "Đã đặt"});
            this.comboBox_roomStt.Location = new System.Drawing.Point(157, 177);
            this.comboBox_roomStt.Name = "comboBox_roomStt";
            this.comboBox_roomStt.Size = new System.Drawing.Size(196, 21);
            this.comboBox_roomStt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại phòng";
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Items.AddRange(new object[] {
            "Single Bed",
            "Double Bed",
            "Triple Bed",
            "Family"});
            this.comboBox_roomType.Location = new System.Drawing.Point(157, 102);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(196, 21);
            this.comboBox_roomType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button_updateRoom, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_addRoom, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_deleteRoom, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(426, 309);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 57);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // button_updateRoom
            // 
            this.button_updateRoom.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_updateRoom.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_updateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_updateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateRoom.Location = new System.Drawing.Point(121, 3);
            this.button_updateRoom.Name = "button_updateRoom";
            this.button_updateRoom.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_updateRoom.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_updateRoom.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_updateRoom.Size = new System.Drawing.Size(112, 51);
            this.button_updateRoom.TabIndex = 24;
            this.button_updateRoom.Text = "Cập nhật";
            this.button_updateRoom.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_updateRoom.UseVisualStyleBackColor = true;
            this.button_updateRoom.Click += new System.EventHandler(this.button_updateRoom_Click);
            // 
            // button_addRoom
            // 
            this.button_addRoom.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_addRoom.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_addRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addRoom.Location = new System.Drawing.Point(3, 3);
            this.button_addRoom.Name = "button_addRoom";
            this.button_addRoom.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_addRoom.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_addRoom.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_addRoom.Size = new System.Drawing.Size(112, 51);
            this.button_addRoom.TabIndex = 22;
            this.button_addRoom.Text = "Thêm";
            this.button_addRoom.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_addRoom.UseVisualStyleBackColor = true;
            this.button_addRoom.Click += new System.EventHandler(this.button_addRoom_Click);
            // 
            // button_deleteRoom
            // 
            this.button_deleteRoom.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_deleteRoom.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_deleteRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_deleteRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteRoom.Location = new System.Drawing.Point(239, 3);
            this.button_deleteRoom.Name = "button_deleteRoom";
            this.button_deleteRoom.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_deleteRoom.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_deleteRoom.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_deleteRoom.Size = new System.Drawing.Size(114, 51);
            this.button_deleteRoom.TabIndex = 23;
            this.button_deleteRoom.Text = "Xoá";
            this.button_deleteRoom.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_deleteRoom.UseVisualStyleBackColor = true;
            this.button_deleteRoom.Click += new System.EventHandler(this.button_deleteRoom_Click);
            // 
            // textBox_dateCheckIn
            // 
            this.textBox_dateCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_dateCheckIn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_dateCheckIn.Location = new System.Drawing.Point(157, 247);
            this.textBox_dateCheckIn.Multiline = true;
            this.textBox_dateCheckIn.Name = "textBox_dateCheckIn";
            this.textBox_dateCheckIn.ReadOnly = true;
            this.textBox_dateCheckIn.Size = new System.Drawing.Size(196, 30);
            this.textBox_dateCheckIn.TabIndex = 25;
            // 
            // textBox_roomID
            // 
            this.textBox_roomID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_roomID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_roomID.Location = new System.Drawing.Point(157, 22);
            this.textBox_roomID.Multiline = true;
            this.textBox_roomID.Name = "textBox_roomID";
            this.textBox_roomID.ReadOnly = true;
            this.textBox_roomID.Size = new System.Drawing.Size(196, 30);
            this.textBox_roomID.TabIndex = 26;
            // 
            // Form_ModifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(785, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ModifyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.Form_ModifyRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_roomView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_roomStt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ePOSOne.btnProduct.Button_WOC button_updateRoom;
        private ePOSOne.btnProduct.Button_WOC button_addRoom;
        private ePOSOne.btnProduct.Button_WOC button_deleteRoom;
        private roundedTextbox textBox_roomID;
        private roundedTextbox textBox_dateCheckIn;




    }
}