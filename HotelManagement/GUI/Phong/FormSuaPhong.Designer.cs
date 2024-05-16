﻿namespace HotelManagement.GUI
{
    partial class FormSuaPhong
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
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThoat = new HotelManagement.CTControls.CTButton();
            this.CTButtonCapNhat = new HotelManagement.CTControls.CTButton();
            this.LabelSuaPhong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxLoaiPhong = new HotelManagement.CTControls.CTComboBox();
            this.comboBoxDonDep = new HotelManagement.CTControls.CTComboBox();
            this.comboBoxTinhTrangPhong = new HotelManagement.CTControls.CTComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctTextBoxGhiChu = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelSuaPhong);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 535);
            this.PanelBackground.TabIndex = 0;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonThoat
            // 
            this.CTButtonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThoat.BorderRadius = 0;
            this.CTButtonThoat.BorderSize = 2;
            this.CTButtonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThoat.FlatAppearance.BorderSize = 0;
            this.CTButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThoat.ForeColor = System.Drawing.Color.White;
            this.CTButtonThoat.Location = new System.Drawing.Point(345, 480);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 7;
            this.CTButtonThoat.Text = "Exit";
            this.CTButtonThoat.TextColor = System.Drawing.Color.White;
            this.CTButtonThoat.UseVisualStyleBackColor = false;
            this.CTButtonThoat.Click += new System.EventHandler(this.CTButtonThoat_Click);
            // 
            // CTButtonCapNhat
            // 
            this.CTButtonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.CTButtonCapNhat.BorderRadius = 0;
            this.CTButtonCapNhat.BorderSize = 0;
            this.CTButtonCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonCapNhat.FlatAppearance.BorderSize = 0;
            this.CTButtonCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonCapNhat.ForeColor = System.Drawing.Color.Black;
            this.CTButtonCapNhat.Location = new System.Drawing.Point(193, 480);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 6;
            this.CTButtonCapNhat.Text = "Update";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.Black;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // LabelSuaPhong
            // 
            this.LabelSuaPhong.AutoSize = true;
            this.LabelSuaPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelSuaPhong.Location = new System.Drawing.Point(188, 12);
            this.LabelSuaPhong.Name = "LabelSuaPhong";
            this.LabelSuaPhong.Size = new System.Drawing.Size(183, 37);
            this.LabelSuaPhong.TabIndex = 1;
            this.LabelSuaPhong.Text = "Repair Room";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.comboBoxLoaiPhong);
            this.panel1.Controls.Add(this.comboBoxDonDep);
            this.panel1.Controls.Add(this.comboBoxTinhTrangPhong);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ctTextBoxGhiChu);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 404);
            this.panel1.TabIndex = 9;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxLoaiPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxLoaiPhong.BorderSize = 2;
            this.comboBoxLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.comboBoxLoaiPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxLoaiPhong.Items.AddRange(new object[] {
            "Thường đơn",
            "Thường đôi",
            "VIP đơn",
            "VIP đôi"});
            this.comboBoxLoaiPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxLoaiPhong.ListTextColor = System.Drawing.Color.White;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(107, 214);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(250, 33);
            this.comboBoxLoaiPhong.TabIndex = 4;
            this.comboBoxLoaiPhong.Texts = "Room Type";
            // 
            // comboBoxDonDep
            // 
            this.comboBoxDonDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxDonDep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxDonDep.BorderSize = 2;
            this.comboBoxDonDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDonDep.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDonDep.ForeColor = System.Drawing.Color.White;
            this.comboBoxDonDep.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxDonDep.Items.AddRange(new object[] {
            "Đã dọn dẹp",
            "Chưa dọn dẹp"});
            this.comboBoxDonDep.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxDonDep.ListTextColor = System.Drawing.Color.White;
            this.comboBoxDonDep.Location = new System.Drawing.Point(107, 133);
            this.comboBoxDonDep.Name = "comboBoxDonDep";
            this.comboBoxDonDep.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxDonDep.Size = new System.Drawing.Size(250, 33);
            this.comboBoxDonDep.TabIndex = 3;
            this.comboBoxDonDep.Texts = "Clean Status";
            // 
            // comboBoxTinhTrangPhong
            // 
            this.comboBoxTinhTrangPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxTinhTrangPhong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxTinhTrangPhong.BorderSize = 2;
            this.comboBoxTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTinhTrangPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTinhTrangPhong.ForeColor = System.Drawing.Color.White;
            this.comboBoxTinhTrangPhong.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxTinhTrangPhong.Items.AddRange(new object[] {
            "Bình thường",
            "Đang sửa chữa"});
            this.comboBoxTinhTrangPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxTinhTrangPhong.ListTextColor = System.Drawing.Color.White;
            this.comboBoxTinhTrangPhong.Location = new System.Drawing.Point(107, 55);
            this.comboBoxTinhTrangPhong.Name = "comboBoxTinhTrangPhong";
            this.comboBoxTinhTrangPhong.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxTinhTrangPhong.Size = new System.Drawing.Size(250, 33);
            this.comboBoxTinhTrangPhong.TabIndex = 2;
            this.comboBoxTinhTrangPhong.Texts = "Room Status";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(71, 299);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources._3people;
            this.pictureBox3.Location = new System.Drawing.Point(71, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.clean;
            this.pictureBox2.Location = new System.Drawing.Point(69, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.pictureBox1.Location = new System.Drawing.Point(69, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctTextBoxGhiChu
            // 
            this.ctTextBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ctTextBoxGhiChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ctTextBoxGhiChu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.ctTextBoxGhiChu.BorderRadius = 0;
            this.ctTextBoxGhiChu.BorderSize = 2;
            this.ctTextBoxGhiChu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxGhiChu.ForeColor = System.Drawing.Color.White;
            this.ctTextBoxGhiChu.IsFocused = false;
            this.ctTextBoxGhiChu.Location = new System.Drawing.Point(107, 294);
            this.ctTextBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGhiChu.Multiline = false;
            this.ctTextBoxGhiChu.Name = "ctTextBoxGhiChu";
            this.ctTextBoxGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGhiChu.PasswordChar = false;
            this.ctTextBoxGhiChu.PlaceholderColor = System.Drawing.Color.White;
            this.ctTextBoxGhiChu.PlaceholderText = "Note";
            this.ctTextBoxGhiChu.ReadOnly = false;
            this.ctTextBoxGhiChu.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGhiChu.TabIndex = 5;
            this.ctTextBoxGhiChu.Texts = "";
            this.ctTextBoxGhiChu.UnderlineedStyle = true;
            // 
            // FormSuaPhong
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 535);
            this.Controls.Add(this.PanelBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaPhong";
            this.Load += new System.EventHandler(this.FormSuaPhong_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaPhong_Paint);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelSuaPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxGhiChu;
        private CTControls.CTComboBox comboBoxTinhTrangPhong;
        private CTControls.CTComboBox comboBoxDonDep;
        private CTControls.CTComboBox comboBoxLoaiPhong;
    }
}