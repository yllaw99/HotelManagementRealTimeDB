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
            this.button_updateRoom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_deleteRoom = new System.Windows.Forms.Button();
            this.button_addRoom = new System.Windows.Forms.Button();
            this.panel_modifyRoom = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_roomStt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_roomType = new System.Windows.Forms.Panel();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.label_roomType = new System.Windows.Forms.Label();
            this.panel_RoomID = new System.Windows.Forms.Panel();
            this.textBox_roomID = new System.Windows.Forms.TextBox();
            this.label_RoomID = new System.Windows.Forms.Label();
            this.dataGridView_roomView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_modifyRoom.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_roomType.SuspendLayout();
            this.panel_RoomID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_roomView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_modifyRoom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.32746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.31738F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.35516F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_updateRoom
            // 
            this.button_updateRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_updateRoom.Location = new System.Drawing.Point(102, 0);
            this.button_updateRoom.Name = "button_updateRoom";
            this.button_updateRoom.Size = new System.Drawing.Size(131, 42);
            this.button_updateRoom.TabIndex = 4;
            this.button_updateRoom.Text = "Cập nhật";
            this.button_updateRoom.UseVisualStyleBackColor = true;
            this.button_updateRoom.Click += new System.EventHandler(this.button_updateRoom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_updateRoom);
            this.panel1.Controls.Add(this.button_deleteRoom);
            this.panel1.Controls.Add(this.button_addRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(343, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 42);
            this.panel1.TabIndex = 10;
            // 
            // button_deleteRoom
            // 
            this.button_deleteRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_deleteRoom.Location = new System.Drawing.Point(233, 0);
            this.button_deleteRoom.Name = "button_deleteRoom";
            this.button_deleteRoom.Size = new System.Drawing.Size(102, 42);
            this.button_deleteRoom.TabIndex = 5;
            this.button_deleteRoom.Text = "Xoá";
            this.button_deleteRoom.UseVisualStyleBackColor = true;
            this.button_deleteRoom.Click += new System.EventHandler(this.button_deleteRoom_Click);
            // 
            // button_addRoom
            // 
            this.button_addRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_addRoom.Location = new System.Drawing.Point(0, 0);
            this.button_addRoom.Name = "button_addRoom";
            this.button_addRoom.Size = new System.Drawing.Size(102, 42);
            this.button_addRoom.TabIndex = 3;
            this.button_addRoom.Text = "Thêm";
            this.button_addRoom.UseVisualStyleBackColor = true;
            this.button_addRoom.Click += new System.EventHandler(this.button_addRoom_Click);
            // 
            // panel_modifyRoom
            // 
            this.panel_modifyRoom.Controls.Add(this.panel3);
            this.panel_modifyRoom.Controls.Add(this.panel_roomType);
            this.panel_modifyRoom.Controls.Add(this.panel_RoomID);
            this.panel_modifyRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_modifyRoom.Location = new System.Drawing.Point(343, 44);
            this.panel_modifyRoom.Name = "panel_modifyRoom";
            this.panel_modifyRoom.Size = new System.Drawing.Size(335, 162);
            this.panel_modifyRoom.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_roomStt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(335, 44);
            this.panel3.TabIndex = 11;
            // 
            // comboBox_roomStt
            // 
            this.comboBox_roomStt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_roomStt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomStt.FormattingEnabled = true;
            this.comboBox_roomStt.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.comboBox_roomStt.Location = new System.Drawing.Point(86, 10);
            this.comboBox_roomStt.Name = "comboBox_roomStt";
            this.comboBox_roomStt.Size = new System.Drawing.Size(249, 21);
            this.comboBox_roomStt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.MinimumSize = new System.Drawing.Size(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái";
            // 
            // panel_roomType
            // 
            this.panel_roomType.Controls.Add(this.comboBox_roomType);
            this.panel_roomType.Controls.Add(this.label_roomType);
            this.panel_roomType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_roomType.Location = new System.Drawing.Point(0, 44);
            this.panel_roomType.Name = "panel_roomType";
            this.panel_roomType.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_roomType.Size = new System.Drawing.Size(335, 44);
            this.panel_roomType.TabIndex = 8;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_roomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Family"});
            this.comboBox_roomType.Location = new System.Drawing.Point(86, 10);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(249, 21);
            this.comboBox_roomType.TabIndex = 1;
            // 
            // label_roomType
            // 
            this.label_roomType.AutoSize = true;
            this.label_roomType.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_roomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_roomType.Location = new System.Drawing.Point(0, 10);
            this.label_roomType.Name = "label_roomType";
            this.label_roomType.Size = new System.Drawing.Size(86, 16);
            this.label_roomType.TabIndex = 0;
            this.label_roomType.Text = "Loại Phòng";
            // 
            // panel_RoomID
            // 
            this.panel_RoomID.Controls.Add(this.textBox_roomID);
            this.panel_RoomID.Controls.Add(this.label_RoomID);
            this.panel_RoomID.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_RoomID.Location = new System.Drawing.Point(0, 0);
            this.panel_RoomID.Name = "panel_RoomID";
            this.panel_RoomID.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_RoomID.Size = new System.Drawing.Size(335, 44);
            this.panel_RoomID.TabIndex = 7;
            // 
            // textBox_roomID
            // 
            this.textBox_roomID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_roomID.Location = new System.Drawing.Point(86, 10);
            this.textBox_roomID.Name = "textBox_roomID";
            this.textBox_roomID.Size = new System.Drawing.Size(249, 20);
            this.textBox_roomID.TabIndex = 1;
            // 
            // label_RoomID
            // 
            this.label_RoomID.AutoSize = true;
            this.label_RoomID.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_RoomID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RoomID.Location = new System.Drawing.Point(0, 10);
            this.label_RoomID.MinimumSize = new System.Drawing.Size(86, 16);
            this.label_RoomID.Name = "label_RoomID";
            this.label_RoomID.Size = new System.Drawing.Size(86, 16);
            this.label_RoomID.TabIndex = 0;
            this.label_RoomID.Text = "Mã Phòng";
            // 
            // dataGridView_roomView
            // 
            this.dataGridView_roomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_roomView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_roomView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_roomView.Name = "dataGridView_roomView";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView_roomView, 3);
            this.dataGridView_roomView.Size = new System.Drawing.Size(334, 392);
            this.dataGridView_roomView.TabIndex = 2;
            this.dataGridView_roomView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_roomView_CellClick);
            // 
            // Form_ModifyRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_ModifyRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ModifyRoom";
            this.Load += new System.EventHandler(this.Form_ModifyRoom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_modifyRoom.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_roomType.ResumeLayout(false);
            this.panel_roomType.PerformLayout();
            this.panel_RoomID.ResumeLayout(false);
            this.panel_RoomID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_roomView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_updateRoom;
        private System.Windows.Forms.Button button_deleteRoom;
        private System.Windows.Forms.Button button_addRoom;
        private System.Windows.Forms.Panel panel_modifyRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox_roomStt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_roomType;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.Label label_roomType;
        private System.Windows.Forms.Panel panel_RoomID;
        private System.Windows.Forms.TextBox textBox_roomID;
        private System.Windows.Forms.Label label_RoomID;
        private System.Windows.Forms.DataGridView dataGridView_roomView;



    }
}