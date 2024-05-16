namespace HotelManagement.GUI
{
    partial class FormDatLaiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatLaiMatKhau));
            this.PictureBoxBack = new System.Windows.Forms.PictureBox();
            this.ButtonOK = new HotelManagement.CTControls.CTButton();
            this.textBoxPassConfirm = new HotelManagement.CTControls.CTTextBox();
            this.textBoxPassword = new HotelManagement.CTControls.CTTextBox();
            this.ctEyePassword1 = new HotelManagement.CTControls.CTEyePassword();
            this.ctEyePassword2 = new HotelManagement.CTControls.CTEyePassword();
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
            this.PictureBoxBack.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBack.TabIndex = 15;
            this.PictureBoxBack.TabStop = false;
            this.PictureBoxBack.Click += new System.EventHandler(this.PictureBoxBack_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonOK.BorderColor = System.Drawing.Color.White;
            this.ButtonOK.BorderRadius = 0;
            this.ButtonOK.BorderSize = 0;
            this.ButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOK.ForeColor = System.Drawing.Color.Black;
            this.ButtonOK.Location = new System.Drawing.Point(20, 340);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(321, 47);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "Done";
            this.ButtonOK.TextColor = System.Drawing.Color.Black;
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // textBoxPassConfirm
            // 
            this.textBoxPassConfirm.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(145)))), ((int)(((byte)(175)))));
            this.textBoxPassConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxPassConfirm.BorderRadius = 0;
            this.textBoxPassConfirm.BorderSize = 1;
            this.textBoxPassConfirm.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPassConfirm.IsFocused = false;
            this.textBoxPassConfirm.Location = new System.Drawing.Point(20, 239);
            this.textBoxPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassConfirm.Multiline = false;
            this.textBoxPassConfirm.Name = "textBoxPassConfirm";
            this.textBoxPassConfirm.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassConfirm.PasswordChar = false;
            this.textBoxPassConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassConfirm.PlaceholderText = "Confirm new password";
            this.textBoxPassConfirm.ReadOnly = false;
            this.textBoxPassConfirm.Size = new System.Drawing.Size(321, 40);
            this.textBoxPassConfirm.TabIndex = 2;
            this.textBoxPassConfirm.Texts = "";
            this.textBoxPassConfirm.UnderlineedStyle = false;
            this.textBoxPassConfirm._TextChanged += new System.EventHandler(this.textBoxPassConfirm__TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.textBoxPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(82)))));
            this.textBoxPassword.BorderRadius = 0;
            this.textBoxPassword.BorderSize = 1;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBoxPassword.IsFocused = false;
            this.textBoxPassword.Location = new System.Drawing.Point(20, 173);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Padding = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.textBoxPassword.PasswordChar = false;
            this.textBoxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPassword.PlaceholderText = "New password";
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.Size = new System.Drawing.Size(321, 40);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Texts = "";
            this.textBoxPassword.UnderlineedStyle = false;
            this.textBoxPassword._TextChanged += new System.EventHandler(this.textBoxPassword__TextChanged);
            // 
            // ctEyePassword1
            // 
            this.ctEyePassword1.BackColor = System.Drawing.Color.White;
            this.ctEyePassword1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctEyePassword1.BackgroundImage")));
            this.ctEyePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctEyePassword1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctEyePassword1.IsShow = false;
            this.ctEyePassword1.Location = new System.Drawing.Point(302, 181);
            this.ctEyePassword1.Name = "ctEyePassword1";
            this.ctEyePassword1.Size = new System.Drawing.Size(30, 26);
            this.ctEyePassword1.TabIndex = 17;
            this.ctEyePassword1.Click += new System.EventHandler(this.ctEyePassword1_Click);
            // 
            // ctEyePassword2
            // 
            this.ctEyePassword2.BackColor = System.Drawing.Color.White;
            this.ctEyePassword2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctEyePassword2.BackgroundImage")));
            this.ctEyePassword2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctEyePassword2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctEyePassword2.IsShow = false;
            this.ctEyePassword2.Location = new System.Drawing.Point(304, 246);
            this.ctEyePassword2.Name = "ctEyePassword2";
            this.ctEyePassword2.Size = new System.Drawing.Size(30, 26);
            this.ctEyePassword2.TabIndex = 18;
            this.ctEyePassword2.Click += new System.EventHandler(this.ctEyePassword2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(34, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Forgot Your Password?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(56, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter your new password to log in.";
            // 
            // FormDatLaiMatKhau
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(374, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctEyePassword2);
            this.Controls.Add(this.ctEyePassword1);
            this.Controls.Add(this.PictureBoxBack);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.textBoxPassConfirm);
            this.Controls.Add(this.textBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatLaiMatKhau";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormDatLaiMatKhau";
            this.Load += new System.EventHandler(this.FormDatLaiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTControls.CTButton ButtonOK;
        private CTControls.CTTextBox textBoxPassword;
        private CTControls.CTTextBox textBoxPassConfirm;
        private System.Windows.Forms.PictureBox PictureBoxBack;
        private CTControls.CTEyePassword ctEyePassword1;
        private CTControls.CTEyePassword ctEyePassword2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}