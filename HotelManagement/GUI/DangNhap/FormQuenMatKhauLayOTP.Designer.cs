namespace HotelManagement.GUI
{
    partial class FormQuenMatKhauLayOTP
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
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.ButtonLayOTP = new HotelManagement.CTControls.CTButton();
            this.TextBoxEmail = new HotelManagement.CTControls.CTTextBox();
            this.textBoxUsername = new HotelManagement.CTControls.CTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 7;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // ButtonLayOTP
            // 
            this.ButtonLayOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonLayOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonLayOTP.BorderColor = System.Drawing.Color.White;
            this.ButtonLayOTP.BorderRadius = 0;
            this.ButtonLayOTP.BorderSize = 0;
            this.ButtonLayOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLayOTP.FlatAppearance.BorderSize = 0;
            this.ButtonLayOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLayOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLayOTP.ForeColor = System.Drawing.Color.Black;
            this.ButtonLayOTP.Location = new System.Drawing.Point(26, 337);
            this.ButtonLayOTP.Name = "ButtonLayOTP";
            this.ButtonLayOTP.Size = new System.Drawing.Size(324, 47);
            this.ButtonLayOTP.TabIndex = 6;
            this.ButtonLayOTP.Text = "Get OTP Code";
            this.ButtonLayOTP.TextColor = System.Drawing.Color.Black;
            this.ButtonLayOTP.UseVisualStyleBackColor = false;
            this.ButtonLayOTP.Click += new System.EventHandler(this.ButtonLayOTP_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.TextBoxEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.TextBoxEmail.BorderRadius = 0;
            this.TextBoxEmail.BorderSize = 1;
            this.TextBoxEmail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.TextBoxEmail.IsFocused = false;
            this.TextBoxEmail.Location = new System.Drawing.Point(26, 246);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmail.Multiline = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.TextBoxEmail.PasswordChar = false;
            this.TextBoxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TextBoxEmail.PlaceholderText = "Email";
            this.TextBoxEmail.ReadOnly = false;
            this.TextBoxEmail.Size = new System.Drawing.Size(324, 40);
            this.TextBoxEmail.TabIndex = 4;
            this.TextBoxEmail.Texts = "";
            this.TextBoxEmail.UnderlineedStyle = false;
            this.TextBoxEmail._TextChanged += new System.EventHandler(this.TextBoxEmail__TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxUsername.BorderRadius = 0;
            this.textBoxUsername.BorderSize = 1;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxUsername.IsFocused = false;
            this.textBoxUsername.Location = new System.Drawing.Point(26, 186);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Multiline = false;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxUsername.PasswordChar = false;
            this.textBoxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxUsername.PlaceholderText = "Username";
            this.textBoxUsername.ReadOnly = false;
            this.textBoxUsername.Size = new System.Drawing.Size(324, 40);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.Texts = "";
            this.textBoxUsername.UnderlineedStyle = false;
            this.textBoxUsername._TextChanged += new System.EventHandler(this.textBoxUsername__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(38, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Forgot Your Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(16, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter your username and email to get OTP code.";
            // 
            // FormQuenMatKhauLayOTP
            // 
            this.AcceptButton = this.ButtonLayOTP;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(374, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonLayOTP);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauLayOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuenMatKhau";
            this.Load += new System.EventHandler(this.FormQuenMatKhauLayOTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CTControls.CTTextBox textBoxUsername;
        private CTControls.CTTextBox TextBoxEmail;
        private CTControls.CTButton ButtonLayOTP;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}