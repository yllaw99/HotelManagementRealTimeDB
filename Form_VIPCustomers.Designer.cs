namespace HotelManagement_FireBase
{
    partial class Form_VIPCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VIPCustomers));
            this.dataGridView_customerView = new System.Windows.Forms.DataGridView();
            this.panel_customer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker_dOb = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox_customer_nationality = new HotelManagement_FireBase.roundedTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_customer_phoneNum = new HotelManagement_FireBase.roundedTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_customer_CMND = new HotelManagement_FireBase.roundedTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_dOb = new System.Windows.Forms.Panel();
            this.textBox_customer_address = new HotelManagement_FireBase.roundedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_update = new ePOSOne.btnProduct.Button_WOC();
            this.button_add = new ePOSOne.btnProduct.Button_WOC();
            this.button_delete = new ePOSOne.btnProduct.Button_WOC();
            this.panel_customerName = new System.Windows.Forms.Panel();
            this.textBox_customerName = new HotelManagement_FireBase.roundedTextbox();
            this.label_customerName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_exit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerView)).BeginInit();
            this.panel_customer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_dOb.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel_customerName.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_customerView
            // 
            this.dataGridView_customerView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_customerView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_customerView.Name = "dataGridView_customerView";
            this.dataGridView_customerView.Size = new System.Drawing.Size(379, 337);
            this.dataGridView_customerView.TabIndex = 1;
            this.dataGridView_customerView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customerView_CellClick);
            // 
            // panel_customer
            // 
            this.panel_customer.Controls.Add(this.panel5);
            this.panel_customer.Controls.Add(this.panel4);
            this.panel_customer.Controls.Add(this.panel3);
            this.panel_customer.Controls.Add(this.panel2);
            this.panel_customer.Controls.Add(this.panel_dOb);
            this.panel_customer.Controls.Add(this.panel1);
            this.panel_customer.Controls.Add(this.panel_customerName);
            this.panel_customer.Location = new System.Drawing.Point(388, 3);
            this.panel_customer.Name = "panel_customer";
            this.panel_customer.Size = new System.Drawing.Size(379, 337);
            this.panel_customer.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateTimePicker_dOb);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 220);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Size = new System.Drawing.Size(379, 43);
            this.panel5.TabIndex = 15;
            // 
            // dateTimePicker_dOb
            // 
            this.dateTimePicker_dOb.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker_dOb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dOb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dOb.Location = new System.Drawing.Point(86, 6);
            this.dateTimePicker_dOb.Name = "dateTimePicker_dOb";
            this.dateTimePicker_dOb.Size = new System.Drawing.Size(276, 21);
            this.dateTimePicker_dOb.TabIndex = 25;
            this.dateTimePicker_dOb.Value = new System.DateTime(2021, 5, 23, 16, 33, 2, 0);
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
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày sinh";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_customer_nationality);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 176);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel4.Size = new System.Drawing.Size(379, 44);
            this.panel4.TabIndex = 14;
            // 
            // textBox_customer_nationality
            // 
            this.textBox_customer_nationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_nationality.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_customer_nationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_customer_nationality.Location = new System.Drawing.Point(86, 8);
            this.textBox_customer_nationality.Multiline = true;
            this.textBox_customer_nationality.Name = "textBox_customer_nationality";
            this.textBox_customer_nationality.Size = new System.Drawing.Size(276, 30);
            this.textBox_customer_nationality.TabIndex = 27;
            this.textBox_customer_nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 10);
            this.label5.MinimumSize = new System.Drawing.Size(86, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quốc tịch";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_customer_phoneNum);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(379, 44);
            this.panel3.TabIndex = 13;
            // 
            // textBox_customer_phoneNum
            // 
            this.textBox_customer_phoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_phoneNum.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_customer_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_customer_phoneNum.Location = new System.Drawing.Point(86, 6);
            this.textBox_customer_phoneNum.Multiline = true;
            this.textBox_customer_phoneNum.Name = "textBox_customer_phoneNum";
            this.textBox_customer_phoneNum.Size = new System.Drawing.Size(276, 30);
            this.textBox_customer_phoneNum.TabIndex = 26;
            this.textBox_customer_phoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.MinimumSize = new System.Drawing.Size(86, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "SĐT";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_customer_CMND);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(379, 44);
            this.panel2.TabIndex = 12;
            // 
            // textBox_customer_CMND
            // 
            this.textBox_customer_CMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_CMND.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_customer_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_customer_CMND.Location = new System.Drawing.Point(86, 7);
            this.textBox_customer_CMND.Multiline = true;
            this.textBox_customer_CMND.Name = "textBox_customer_CMND";
            this.textBox_customer_CMND.Size = new System.Drawing.Size(276, 30);
            this.textBox_customer_CMND.TabIndex = 25;
            this.textBox_customer_CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.MinimumSize = new System.Drawing.Size(86, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "CMND";
            // 
            // panel_dOb
            // 
            this.panel_dOb.Controls.Add(this.textBox_customer_address);
            this.panel_dOb.Controls.Add(this.label2);
            this.panel_dOb.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_dOb.Location = new System.Drawing.Point(0, 44);
            this.panel_dOb.Name = "panel_dOb";
            this.panel_dOb.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_dOb.Size = new System.Drawing.Size(379, 44);
            this.panel_dOb.TabIndex = 11;
            // 
            // textBox_customer_address
            // 
            this.textBox_customer_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customer_address.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_customer_address.Location = new System.Drawing.Point(86, 8);
            this.textBox_customer_address.Multiline = true;
            this.textBox_customer_address.Name = "textBox_customer_address";
            this.textBox_customer_address.Size = new System.Drawing.Size(276, 30);
            this.textBox_customer_address.TabIndex = 24;
            this.textBox_customer_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.MinimumSize = new System.Drawing.Size(86, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Địa chỉ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 52);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button_update, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_add, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button_delete, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 52);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button_update
            // 
            this.button_update.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_update.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(129, 3);
            this.button_update.Name = "button_update";
            this.button_update.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_update.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Size = new System.Drawing.Size(120, 46);
            this.button_update.TabIndex = 24;
            this.button_update.Text = "Cập nhật";
            this.button_update.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_updateRoom_Click);
            // 
            // button_add
            // 
            this.button_add.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_add.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(3, 3);
            this.button_add.Name = "button_add";
            this.button_add.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_add.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.Size = new System.Drawing.Size(120, 46);
            this.button_add.TabIndex = 22;
            this.button_add.Text = "Thêm";
            this.button_add.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_addCus_Click);
            // 
            // button_delete
            // 
            this.button_delete.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_delete.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(255, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_delete.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_delete.Size = new System.Drawing.Size(121, 46);
            this.button_delete.TabIndex = 23;
            this.button_delete.Text = "Xoá";
            this.button_delete.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_deleteRoom_Click);
            // 
            // panel_customerName
            // 
            this.panel_customerName.Controls.Add(this.textBox_customerName);
            this.panel_customerName.Controls.Add(this.label_customerName);
            this.panel_customerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_customerName.Location = new System.Drawing.Point(0, 0);
            this.panel_customerName.Name = "panel_customerName";
            this.panel_customerName.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_customerName.Size = new System.Drawing.Size(379, 44);
            this.panel_customerName.TabIndex = 8;
            // 
            // textBox_customerName
            // 
            this.textBox_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_customerName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_customerName.Location = new System.Drawing.Point(86, 3);
            this.textBox_customerName.Multiline = true;
            this.textBox_customerName.Name = "textBox_customerName";
            this.textBox_customerName.Size = new System.Drawing.Size(276, 30);
            this.textBox_customerName.TabIndex = 22;
            this.textBox_customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customerName.Location = new System.Drawing.Point(0, 10);
            this.label_customerName.MinimumSize = new System.Drawing.Size(86, 16);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(86, 16);
            this.label_customerName.TabIndex = 0;
            this.label_customerName.Text = "Tên KH";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label_exit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(770, 82);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_exit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_exit.Location = new System.Drawing.Point(747, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(23, 20);
            this.label_exit.TabIndex = 20;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_customerView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_customer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 343F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 343);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form_VIPCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_VIPCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng VIP";
            this.Load += new System.EventHandler(this.Form_Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customerView)).EndInit();
            this.panel_customer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_dOb.ResumeLayout(false);
            this.panel_dOb.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel_customerName.ResumeLayout(false);
            this.panel_customerName.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_customerView;
        private System.Windows.Forms.Panel panel_customer;
        private System.Windows.Forms.Panel panel_dOb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_customerName;
        private System.Windows.Forms.Label label_customerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ePOSOne.btnProduct.Button_WOC button_update;
        private ePOSOne.btnProduct.Button_WOC button_add;
        private ePOSOne.btnProduct.Button_WOC button_delete;
        private roundedTextbox textBox_customerName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dOb;
        private System.Windows.Forms.Label label1;
        private roundedTextbox textBox_customer_nationality;
        private System.Windows.Forms.Label label5;
        private roundedTextbox textBox_customer_phoneNum;
        private System.Windows.Forms.Label label4;
        private roundedTextbox textBox_customer_CMND;
        private System.Windows.Forms.Label label3;
        private roundedTextbox textBox_customer_address;
        private System.Windows.Forms.Label label2;
    }
}