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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedTextbox1 = new HotelManagement_FireBase.roundedTextbox();
            this.textBox123 = new HotelManagement_FireBase.roundedTextbox();
            this.textBox_signin_username = new HotelManagement_FireBase.roundedTextbox();
            this.button_signin = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pictureBox1.Image = global::HotelManagement_FireBase.Properties.Resources.blue_paradise_21;
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox123);
            this.panel2.Controls.Add(this.textBox_signin_username);
            this.panel2.Controls.Add(this.button_signin);
            this.panel2.Location = new System.Drawing.Point(565, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 147);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(831, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // roundedTextbox1
            // 
            this.roundedTextbox1.Location = new System.Drawing.Point(649, 61);
            this.roundedTextbox1.Name = "roundedTextbox1";
            this.roundedTextbox1.Size = new System.Drawing.Size(110, 20);
            this.roundedTextbox1.TabIndex = 15;
            this.roundedTextbox1.UseSystemPasswordChar = true;
            // 
            // textBox123
            // 
            this.textBox123.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox123.Font = new System.Drawing.Font("Ebrima", 13F);
            this.textBox123.Location = new System.Drawing.Point(16, 55);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(250, 31);
            this.textBox123.TabIndex = 1;
            this.textBox123.Text = "1";
            this.textBox123.UseSystemPasswordChar = true;
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
            // form_signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(873, 532);
            this.Controls.Add(this.roundedTextbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.button_signin_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private ePOSOne.btnProduct.Button_WOC button_signin;
        private System.Windows.Forms.Label label1;
        private roundedTextbox textBox_signin_username;
        private roundedTextbox textBox123;
        private roundedTextbox roundedTextbox1;



    }
}

