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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_pwd = new HotelManagement_FireBase.roundedTextbox();
            this.textBox_signin_username = new HotelManagement_FireBase.roundedTextbox();
            this.button_signin = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 532);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelManagement_FireBase.Properties.Resources.blue_paradise_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 532);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.textBox_pwd);
            this.panel2.Controls.Add(this.textBox_signin_username);
            this.panel2.Controls.Add(this.button_signin);
            this.panel2.Location = new System.Drawing.Point(565, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 147);
            this.panel2.TabIndex = 13;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_pwd.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_pwd.Location = new System.Drawing.Point(16, 55);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(250, 31);
            this.textBox_pwd.TabIndex = 1;
            this.textBox_pwd.Text = "1";
            this.textBox_pwd.UseSystemPasswordChar = true;
            // 
            // textBox_signin_username
            // 
            this.textBox_signin_username.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_signin_username.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox_signin_username.Location = new System.Drawing.Point(16, 17);
            this.textBox_signin_username.Name = "textBox_signin_username";
            this.textBox_signin_username.Size = new System.Drawing.Size(250, 31);
            this.textBox_signin_username.TabIndex = 0;
            this.textBox_signin_username.Text = "t";
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_signin.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button_signin.ButtonColor = System.Drawing.SystemColors.HotTrack;
            this.button_signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F);
            this.button_signin.Location = new System.Drawing.Point(16, 92);
            this.button_signin.Name = "button_signin";
            this.button_signin.OnHoverBorderColor = System.Drawing.Color.LightSteelBlue;
            this.button_signin.OnHoverButtonColor = System.Drawing.Color.AliceBlue;
            this.button_signin.OnHoverTextColor = System.Drawing.Color.LightSteelBlue;
            this.button_signin.Size = new System.Drawing.Size(250, 32);
            this.button_signin.TabIndex = 2;
            this.button_signin.Text = "Log In";
            this.button_signin.TextColor = System.Drawing.Color.White;
            this.button_signin.UseVisualStyleBackColor = false;
            this.button_signin.Click += new System.EventHandler(this.button_signin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(822, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // form_signin
            // 
            this.AcceptButton = this.button_signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC button_signin;
        private roundedTextbox textBox_signin_username;
        private roundedTextbox textBox_pwd;
        private System.Windows.Forms.PictureBox pictureBox2;



    }
}

