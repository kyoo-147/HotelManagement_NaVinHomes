namespace HotelManagement.GUI
{
    partial class FormKetNoiCSDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKetNoiCSDL));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDefault = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDB = new HotelManagement.CTControls.CTTextBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.ctMaximize = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize = new HotelManagement.CTControls.CTMinimize();
            this.ctClose = new HotelManagement.CTControls.CTClose();
            this.checkBoxLuu = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonKetNoi = new HotelManagement.CTControls.CTButton();
            this.textBoxServer = new HotelManagement.CTControls.CTTextBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.buttonDefault);
            this.panelBackground.Controls.Add(this.pictureBox1);
            this.panelBackground.Controls.Add(this.textBoxDB);
            this.panelBackground.Controls.Add(this.panelControlBox);
            this.panelBackground.Controls.Add(this.checkBoxLuu);
            this.panelBackground.Controls.Add(this.labelTitle);
            this.panelBackground.Controls.Add(this.buttonKetNoi);
            this.panelBackground.Controls.Add(this.textBoxServer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(372, 353);
            this.panelBackground.TabIndex = 0;
            this.panelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBackground_Paint);
            this.panelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBackground_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(5, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Copyright © 2024 NaVin AIF Technology";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonDefault
            // 
            this.buttonDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.buttonDefault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.buttonDefault.BorderColor = System.Drawing.Color.White;
            this.buttonDefault.BorderRadius = 0;
            this.buttonDefault.BorderSize = 0;
            this.buttonDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDefault.FlatAppearance.BorderSize = 0;
            this.buttonDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefault.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDefault.ForeColor = System.Drawing.Color.Black;
            this.buttonDefault.Location = new System.Drawing.Point(46, 251);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(271, 30);
            this.buttonDefault.TabIndex = 16;
            this.buttonDefault.Text = "Default Database";
            this.buttonDefault.TextColor = System.Drawing.Color.Black;
            this.buttonDefault.UseVisualStyleBackColor = false;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            this.buttonDefault.MouseLeave += new System.EventHandler(this.buttonDefault_MouseLeave);
            this.buttonDefault.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonDefault_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(133, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxDB
            // 
            this.textBoxDB.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDB.BorderColor = System.Drawing.Color.Gray;
            this.textBoxDB.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxDB.BorderRadius = 0;
            this.textBoxDB.BorderSize = 0;
            this.textBoxDB.ForeColor = System.Drawing.Color.Black;
            this.textBoxDB.IsFocused = false;
            this.textBoxDB.Location = new System.Drawing.Point(46, 180);
            this.textBoxDB.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDB.Multiline = false;
            this.textBoxDB.Name = "textBoxDB";
            this.textBoxDB.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxDB.PasswordChar = false;
            this.textBoxDB.PlaceholderColor = System.Drawing.Color.Silver;
            this.textBoxDB.PlaceholderText = "Name of database";
            this.textBoxDB.ReadOnly = false;
            this.textBoxDB.Size = new System.Drawing.Size(271, 28);
            this.textBoxDB.TabIndex = 11;
            this.textBoxDB.Texts = "";
            this.textBoxDB.UnderlineedStyle = false;
            this.textBoxDB._TextChanged += new System.EventHandler(this.textBoxDB__TextChanged);
            // 
            // panelControlBox
            // 
            this.panelControlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.panelControlBox.Controls.Add(this.ctMaximize);
            this.panelControlBox.Controls.Add(this.ctMinimize);
            this.panelControlBox.Controls.Add(this.ctClose);
            this.panelControlBox.Location = new System.Drawing.Point(278, 3);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(95, 30);
            this.panelControlBox.TabIndex = 14;
            this.panelControlBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlBox_Paint);
            this.panelControlBox.MouseLeave += new System.EventHandler(this.panelControlBox_MouseLeave);
            this.panelControlBox.MouseHover += new System.EventHandler(this.panelControlBox_MouseHover);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelControlBox_MouseMove);
            // 
            // ctMaximize
            // 
            this.ctMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize.BackgroundImage")));
            this.ctMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize.Enabled = false;
            this.ctMaximize.Location = new System.Drawing.Point(10, 7);
            this.ctMaximize.Name = "ctMaximize";
            this.ctMaximize.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize.TabIndex = 2;
            this.ctMaximize.Load += new System.EventHandler(this.ctMaximize_Load);
            // 
            // ctMinimize
            // 
            this.ctMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize.BackgroundImage")));
            this.ctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize.Location = new System.Drawing.Point(40, 6);
            this.ctMinimize.Name = "ctMinimize";
            this.ctMinimize.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize.TabIndex = 1;
            this.ctMinimize.Load += new System.EventHandler(this.ctMinimize_Load);
            this.ctMinimize.Click += new System.EventHandler(this.ctMinimize_Click);
            // 
            // ctClose
            // 
            this.ctClose.BackColor = System.Drawing.Color.Transparent;
            this.ctClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose.BackgroundImage")));
            this.ctClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose.Location = new System.Drawing.Point(70, 6);
            this.ctClose.Name = "ctClose";
            this.ctClose.Size = new System.Drawing.Size(15, 15);
            this.ctClose.TabIndex = 0;
            this.ctClose.Load += new System.EventHandler(this.ctClose_Load);
            this.ctClose.Click += new System.EventHandler(this.ctClose_Click);
            // 
            // checkBoxLuu
            // 
            this.checkBoxLuu.AutoSize = true;
            this.checkBoxLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLuu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxLuu.Location = new System.Drawing.Point(192, 216);
            this.checkBoxLuu.Name = "checkBoxLuu";
            this.checkBoxLuu.Size = new System.Drawing.Size(127, 25);
            this.checkBoxLuu.TabIndex = 13;
            this.checkBoxLuu.Text = "Stay logged in";
            this.checkBoxLuu.UseVisualStyleBackColor = true;
            this.checkBoxLuu.CheckedChanged += new System.EventHandler(this.checkBoxLuu_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(32, 96);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(311, 32);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Connect to your Database";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonKetNoi
            // 
            this.buttonKetNoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.buttonKetNoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.buttonKetNoi.BorderColor = System.Drawing.Color.White;
            this.buttonKetNoi.BorderRadius = 0;
            this.buttonKetNoi.BorderSize = 0;
            this.buttonKetNoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKetNoi.FlatAppearance.BorderSize = 0;
            this.buttonKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKetNoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKetNoi.ForeColor = System.Drawing.Color.Black;
            this.buttonKetNoi.Location = new System.Drawing.Point(46, 287);
            this.buttonKetNoi.Name = "buttonKetNoi";
            this.buttonKetNoi.Size = new System.Drawing.Size(271, 30);
            this.buttonKetNoi.TabIndex = 12;
            this.buttonKetNoi.Text = "Connect";
            this.buttonKetNoi.TextColor = System.Drawing.Color.Black;
            this.buttonKetNoi.UseVisualStyleBackColor = false;
            this.buttonKetNoi.Click += new System.EventHandler(this.buttonKetNoi_Click);
            this.buttonKetNoi.MouseLeave += new System.EventHandler(this.buttonKetNoi_MouseLeave);
            this.buttonKetNoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonKetNoi_MouseMove);
            // 
            // textBoxServer
            // 
            this.textBoxServer.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxServer.BorderColor = System.Drawing.Color.Gray;
            this.textBoxServer.BorderFocusColor = System.Drawing.Color.Black;
            this.textBoxServer.BorderRadius = 0;
            this.textBoxServer.BorderSize = 0;
            this.textBoxServer.ForeColor = System.Drawing.Color.Black;
            this.textBoxServer.IsFocused = false;
            this.textBoxServer.Location = new System.Drawing.Point(46, 134);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxServer.Multiline = false;
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Padding = new System.Windows.Forms.Padding(20, 7, 7, 7);
            this.textBoxServer.PasswordChar = false;
            this.textBoxServer.PlaceholderColor = System.Drawing.Color.Silver;
            this.textBoxServer.PlaceholderText = "Name of server";
            this.textBoxServer.ReadOnly = false;
            this.textBoxServer.Size = new System.Drawing.Size(271, 28);
            this.textBoxServer.TabIndex = 10;
            this.textBoxServer.Texts = "";
            this.textBoxServer.UnderlineedStyle = false;
            this.textBoxServer._TextChanged += new System.EventHandler(this.textBoxServer__TextChanged);
            // 
            // FormKetNoiCSDL
            // 
            this.AcceptButton = this.buttonKetNoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.panelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKetNoiCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKetNoiCSDL";
            this.Activated += new System.EventHandler(this.FormKetNoiCSDL_Activated);
            this.Load += new System.EventHandler(this.FormKetNoiCSDL_Load);
            this.SizeChanged += new System.EventHandler(this.FormKetNoiCSDL_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormKetNoiCSDL_Paint);
            this.Resize += new System.EventHandler(this.FormKetNoiCSDL_Resize);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private CTControls.CTTextBox textBoxDB;
        private System.Windows.Forms.Panel panelControlBox;
        private CTControls.CTMaximize ctMaximize;
        private CTControls.CTMinimize ctMinimize;
        private CTControls.CTClose ctClose;
        private System.Windows.Forms.CheckBox checkBoxLuu;
        private System.Windows.Forms.Label labelTitle;
        private CTControls.CTButton buttonKetNoi;
        private CTControls.CTTextBox textBoxServer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTButton buttonDefault;
        private System.Windows.Forms.Label label1;
    }
}