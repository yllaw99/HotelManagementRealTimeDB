namespace HotelManagement_FireBase
{
    partial class FormRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_accManager = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_modifyRoom = new System.Windows.Forms.Button();
            this.button_promo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 42);
            this.panel1.TabIndex = 0;
            // 
            // button_customers
            // 
            this.button_customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_customers.Location = new System.Drawing.Point(3, 186);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(186, 55);
            this.button_customers.TabIndex = 4;
            this.button_customers.Text = "KHÁCH HÀNG VIP";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_accManager
            // 
            this.button_accManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_accManager.Location = new System.Drawing.Point(3, 125);
            this.button_accManager.Name = "button_accManager";
            this.button_accManager.Size = new System.Drawing.Size(186, 55);
            this.button_accManager.TabIndex = 3;
            this.button_accManager.Text = "TÀI KHOẢN";
            this.button_accManager.UseVisualStyleBackColor = true;
            this.button_accManager.Click += new System.EventHandler(this.button_accManager_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 493);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_customers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_modifyRoom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_accManager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_promo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 493);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(192, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(753, 493);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // button_modifyRoom
            // 
            this.button_modifyRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_modifyRoom.Location = new System.Drawing.Point(3, 3);
            this.button_modifyRoom.Name = "button_modifyRoom";
            this.button_modifyRoom.Size = new System.Drawing.Size(183, 55);
            this.button_modifyRoom.TabIndex = 1;
            this.button_modifyRoom.Text = "PHÒNG";
            this.button_modifyRoom.UseVisualStyleBackColor = true;
            this.button_modifyRoom.Click += new System.EventHandler(this.button_modifyRoom_Click);
            // 
            // button_promo
            // 
            this.button_promo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_promo.Location = new System.Drawing.Point(3, 64);
            this.button_promo.Name = "button_promo";
            this.button_promo.Size = new System.Drawing.Size(186, 55);
            this.button_promo.TabIndex = 3;
            this.button_promo.Text = "KHUYẾN MÃI";
            this.button_promo.UseVisualStyleBackColor = true;
            this.button_promo.Click += new System.EventHandler(this.button_promo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(896, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_accManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_modifyRoom;
        private System.Windows.Forms.Button button_promo;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}