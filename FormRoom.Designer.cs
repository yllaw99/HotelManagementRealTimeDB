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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_accManager = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button_modifyRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_customers);
            this.panel1.Controls.Add(this.button_accManager);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button_modifyRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 35);
            this.panel1.TabIndex = 0;
            // 
            // button_customers
            // 
            this.button_customers.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_customers.Location = new System.Drawing.Point(225, 0);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(87, 35);
            this.button_customers.TabIndex = 4;
            this.button_customers.Text = "KHÁCH HÀNG";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button_customers_Click);
            // 
            // button_accManager
            // 
            this.button_accManager.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_accManager.Location = new System.Drawing.Point(150, 0);
            this.button_accManager.Name = "button_accManager";
            this.button_accManager.Size = new System.Drawing.Size(75, 35);
            this.button_accManager.TabIndex = 3;
            this.button_accManager.Text = "TÀI KHOẢN";
            this.button_accManager.UseVisualStyleBackColor = true;
            this.button_accManager.Click += new System.EventHandler(this.button_accManager_Click);
            // 
            // button18
            // 
            this.button18.Dock = System.Windows.Forms.DockStyle.Left;
            this.button18.Location = new System.Drawing.Point(75, 0);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 35);
            this.button18.TabIndex = 2;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button_modifyRoom
            // 
            this.button_modifyRoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_modifyRoom.Location = new System.Drawing.Point(0, 0);
            this.button_modifyRoom.Name = "button_modifyRoom";
            this.button_modifyRoom.Size = new System.Drawing.Size(75, 35);
            this.button_modifyRoom.TabIndex = 0;
            this.button_modifyRoom.Text = "PHÒNG";
            this.button_modifyRoom.UseVisualStyleBackColor = true;
            this.button_modifyRoom.Click += new System.EventHandler(this.button_modifyRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 464);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 464);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_accManager;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button_modifyRoom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    }
}