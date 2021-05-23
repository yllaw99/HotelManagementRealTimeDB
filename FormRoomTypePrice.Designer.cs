namespace HotelManagement_FireBase
{
    partial class FormRoomTypePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomTypePrice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_roomType = new HotelManagement_FireBase.roundedTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_price = new HotelManagement_FireBase.roundedTextbox();
            this.button_Change = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 24);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 35);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 35);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox_roomType);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.textBox_price);
            this.panel3.Controls.Add(this.button_Change);
            this.panel3.Location = new System.Drawing.Point(27, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 147);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_roomType
            // 
            this.textBox_roomType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_roomType.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_roomType.Location = new System.Drawing.Point(16, 18);
            this.textBox_roomType.Name = "textBox_roomType";
            this.textBox_roomType.Size = new System.Drawing.Size(250, 31);
            this.textBox_roomType.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 230;
            this.comboBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ""});
            this.comboBox1.Location = new System.Drawing.Point(25, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_price.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_price.Location = new System.Drawing.Point(16, 55);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(250, 31);
            this.textBox_price.TabIndex = 1;
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Change.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button_Change.ButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_Change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Change.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.button_Change.Location = new System.Drawing.Point(16, 92);
            this.button_Change.Name = "button_Change";
            this.button_Change.OnHoverBorderColor = System.Drawing.Color.LightSteelBlue;
            this.button_Change.OnHoverButtonColor = System.Drawing.Color.AliceBlue;
            this.button_Change.OnHoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.button_Change.Size = new System.Drawing.Size(250, 32);
            this.button_Change.TabIndex = 2;
            this.button_Change.Text = "Update";
            this.button_Change.TextColor = System.Drawing.Color.White;
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // FormRoomTypePrice
            // 
            this.AcceptButton = this.button_Change;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(335, 324);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoomTypePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoomTypePrice";
            this.Load += new System.EventHandler(this.FormRoomTypePrice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private roundedTextbox textBox_price;
        private ePOSOne.btnProduct.Button_WOC button_Change;
        private roundedTextbox textBox_roomType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}