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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_moreInfo = new System.Windows.Forms.Panel();
            this.label_currentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_accManager = new ePOSOne.btnProduct.Button_WOC();
            this.button_promo = new ePOSOne.btnProduct.Button_WOC();
            this.button_modifyRoom = new ePOSOne.btnProduct.Button_WOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_blackList = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_moreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel_moreInfo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 111);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel_moreInfo
            // 
            this.panel_moreInfo.Controls.Add(this.label_currentUser);
            this.panel_moreInfo.Controls.Add(this.label1);
            this.panel_moreInfo.Controls.Add(this.label2);
            this.panel_moreInfo.Location = new System.Drawing.Point(661, 6);
            this.panel_moreInfo.Name = "panel_moreInfo";
            this.panel_moreInfo.Size = new System.Drawing.Size(248, 33);
            this.panel_moreInfo.TabIndex = 1;
            // 
            // label_currentUser
            // 
            this.label_currentUser.AutoSize = true;
            this.label_currentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_currentUser.Location = new System.Drawing.Point(83, 4);
            this.label_currentUser.Name = "label_currentUser";
            this.label_currentUser.Size = new System.Drawing.Size(73, 16);
            this.label_currentUser.TabIndex = 21;
            this.label_currentUser.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(222, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(915, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBoxVisibleChange);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 424);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_accManager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_promo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_modifyRoom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_blackList, 0, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 424);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_accManager
            // 
            this.button_accManager.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_accManager.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_accManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_accManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_accManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_accManager.Location = new System.Drawing.Point(3, 109);
            this.button_accManager.Name = "button_accManager";
            this.button_accManager.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_accManager.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_accManager.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_accManager.Size = new System.Drawing.Size(186, 47);
            this.button_accManager.TabIndex = 8;
            this.button_accManager.Text = "TÀI KHOẢN";
            this.button_accManager.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_accManager.UseVisualStyleBackColor = true;
            this.button_accManager.Click += new System.EventHandler(this.button_accManager_Click);
            // 
            // button_promo
            // 
            this.button_promo.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_promo.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_promo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_promo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_promo.Location = new System.Drawing.Point(3, 56);
            this.button_promo.Name = "button_promo";
            this.button_promo.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_promo.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_promo.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_promo.Size = new System.Drawing.Size(186, 47);
            this.button_promo.TabIndex = 7;
            this.button_promo.Text = "KHUYẾN MÃI";
            this.button_promo.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_promo.UseVisualStyleBackColor = true;
            this.button_promo.Click += new System.EventHandler(this.button_promo_Click);
            // 
            // button_modifyRoom
            // 
            this.button_modifyRoom.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_modifyRoom.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modifyRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modifyRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_modifyRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifyRoom.Location = new System.Drawing.Point(3, 3);
            this.button_modifyRoom.Name = "button_modifyRoom";
            this.button_modifyRoom.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modifyRoom.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_modifyRoom.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_modifyRoom.Size = new System.Drawing.Size(186, 47);
            this.button_modifyRoom.TabIndex = 6;
            this.button_modifyRoom.Text = "PHÒNG";
            this.button_modifyRoom.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_modifyRoom.UseVisualStyleBackColor = true;
            this.button_modifyRoom.Click += new System.EventHandler(this.button_modifyRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(240, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 418);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(669, 418);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button_blackList
            // 
            this.button_blackList.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_blackList.ButtonColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_blackList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_blackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_blackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_blackList.Location = new System.Drawing.Point(3, 162);
            this.button_blackList.Name = "button_blackList";
            this.button_blackList.OnHoverBorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_blackList.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_blackList.OnHoverTextColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_blackList.Size = new System.Drawing.Size(186, 47);
            this.button_blackList.TabIndex = 10;
            this.button_blackList.Text = "BLACK LIST";
            this.button_blackList.TextColor = System.Drawing.SystemColors.HotTrack;
            this.button_blackList.UseVisualStyleBackColor = true;
            this.button_blackList.Click += new System.EventHandler(this.button_blackList_Click);
            // 
            // FormRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoom";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_moreInfo.ResumeLayout(false);
            this.panel_moreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_moreInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_currentUser;
        private ePOSOne.btnProduct.Button_WOC button_modifyRoom;
        private ePOSOne.btnProduct.Button_WOC button_promo;
        private ePOSOne.btnProduct.Button_WOC button_accManager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ePOSOne.btnProduct.Button_WOC button_blackList;

    }
}