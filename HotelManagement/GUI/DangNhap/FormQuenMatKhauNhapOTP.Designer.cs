namespace HotelManagement.GUI
{
    partial class FormQuenMatKhauNhapOTP
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
            this.components = new System.ComponentModel.Container();
            this.ButtonContinue = new HotelManagement.CTControls.CTButton();
            this.textBoxOTP = new HotelManagement.CTControls.CTTextBox();
            this.ButtonResend = new HotelManagement.CTControls.CTButton();
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonContinue.BorderColor = System.Drawing.Color.White;
            this.ButtonContinue.BorderRadius = 0;
            this.ButtonContinue.BorderSize = 0;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.FlatAppearance.BorderSize = 0;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContinue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonContinue.ForeColor = System.Drawing.Color.Black;
            this.ButtonContinue.Location = new System.Drawing.Point(18, 333);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(299, 40);
            this.ButtonContinue.TabIndex = 10;
            this.ButtonContinue.Text = "Countinue";
            this.ButtonContinue.TextColor = System.Drawing.Color.Black;
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxOTP.BorderRadius = 0;
            this.textBoxOTP.BorderSize = 1;
            this.textBoxOTP.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxOTP.IsFocused = false;
            this.textBoxOTP.Location = new System.Drawing.Point(18, 189);
            this.textBoxOTP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTP.Multiline = false;
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxOTP.PasswordChar = false;
            this.textBoxOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxOTP.PlaceholderText = "Enter OTP Code";
            this.textBoxOTP.ReadOnly = false;
            this.textBoxOTP.Size = new System.Drawing.Size(297, 40);
            this.textBoxOTP.TabIndex = 8;
            this.textBoxOTP.Texts = "";
            this.textBoxOTP.UnderlineedStyle = false;
            // 
            // ButtonResend
            // 
            this.ButtonResend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonResend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonResend.BorderColor = System.Drawing.Color.White;
            this.ButtonResend.BorderRadius = 0;
            this.ButtonResend.BorderSize = 0;
            this.ButtonResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResend.FlatAppearance.BorderSize = 0;
            this.ButtonResend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResend.ForeColor = System.Drawing.Color.Black;
            this.ButtonResend.Location = new System.Drawing.Point(18, 285);
            this.ButtonResend.Name = "ButtonResend";
            this.ButtonResend.Size = new System.Drawing.Size(299, 40);
            this.ButtonResend.TabIndex = 10;
            this.ButtonResend.Text = "Resend";
            this.ButtonResend.TextColor = System.Drawing.Color.Black;
            this.ButtonResend.UseVisualStyleBackColor = false;
            this.ButtonResend.Click += new System.EventHandler(this.ButtonResend_Click);
            // 
            // PictureBoxBack
            // 
            this.PictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxBack.Image = global::HotelManagement.Properties.Resources.back;
            this.PictureBoxBack.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxBack.Name = "PictureBoxBack";
            this.PictureBoxBack.Size = new System.Drawing.Size(28, 29);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 11;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Forgot Your Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(57, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Enter the OTP code we sent you";
            // 
            // FormQuenMatKhauNhapOTP
            // 
            this.AcceptButton = this.ButtonContinue;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(337, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonResend);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.textBoxOTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhauNhapOTP";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormQuenMatKhauNhapOTP";
            this.Load += new System.EventHandler(this.FormQuenMatKhauNhapOTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton ButtonContinue;
        private CTControls.CTTextBox textBoxOTP;
        private CTControls.CTButton ButtonResend;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}