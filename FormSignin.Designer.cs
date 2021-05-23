namespace HotelManagement_FireBase
{
    partial class form_signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_signin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_signin = new ePOSOne.btnProduct.Button_WOC();
            this.textBox_pwd = new HotelManagement_FireBase.roundedTextbox();
            this.textBox_signin_username = new HotelManagement_FireBase.roundedTextbox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 532);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelManagement_FireBase.Properties.Resources.blue_paradise_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(748, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.button_signin);
            this.panel2.Controls.Add(this.textBox_pwd);
            this.panel2.Controls.Add(this.textBox_signin_username);
            this.panel2.Location = new System.Drawing.Point(482, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 152);
            this.panel2.TabIndex = 19;
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.ButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.button_signin.Location = new System.Drawing.Point(12, 100);
            this.button_signin.Name = "button_signin";
            this.button_signin.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.OnHoverButtonColor = System.Drawing.Color.AliceBlue;
            this.button_signin.OnHoverTextColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.Size = new System.Drawing.Size(250, 32);
            this.button_signin.TabIndex = 19;
            this.button_signin.Text = "Log In";
            this.button_signin.TextColor = System.Drawing.Color.White;
            this.button_signin.UseVisualStyleBackColor = false;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_pwd.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_pwd.Location = new System.Drawing.Point(12, 49);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(250, 31);
            this.textBox_pwd.TabIndex = 18;
            this.textBox_pwd.Text = "1";
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_signin_username.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_signin_username.Location = new System.Drawing.Point(12, 12);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(250, 31);
            this.textBox_signin_username.TabIndex = 17;
            this.textBox_signin_username.Text = "t";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(579, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // form_signin
            // 
            this.AcceptButton = this.button_signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(783, 532);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC button_signin;
        private roundedTextbox textBox_pwd;
        private roundedTextbox textBox_signin_username;
        private System.Windows.Forms.PictureBox pictureBox3;



    }
}

