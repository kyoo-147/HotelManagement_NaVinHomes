namespace HotelManagement.GUI
{
    partial class FormSuaChiTietTienNghi
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
            this.LabelSuaChiTietTienNghi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxSoLuong = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxGhiChu = new HotelManagement.CTControls.CTTextBox();
            this.ctTextBoxTenTienNghi = new HotelManagement.CTControls.CTTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.CTButtonThoat);
            this.PanelBackground.Controls.Add(this.CTButtonCapNhat);
            this.PanelBackground.Controls.Add(this.LabelSuaChiTietTienNghi);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(500, 500);
            this.PanelBackground.TabIndex = 7;
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
            this.CTButtonThoat.Location = new System.Drawing.Point(322, 416);
            this.CTButtonThoat.Name = "CTButtonThoat";
            this.CTButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.CTButtonThoat.TabIndex = 6;
            this.CTButtonThoat.Text = "Exit";
            this.CTButtonThoat.TextColor = System.Drawing.Color.White;
            this.CTButtonThoat.UseVisualStyleBackColor = false;
            this.CTButtonThoat.Click += new System.EventHandler(this.CTButtonThoat_Click);
            // 
            // CTButtonCapNhat
            // 
            this.CTButtonCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonCapNhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonCapNhat.BorderRadius = 0;
            this.CTButtonCapNhat.BorderSize = 0;
            this.CTButtonCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonCapNhat.FlatAppearance.BorderSize = 0;
            this.CTButtonCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonCapNhat.ForeColor = System.Drawing.Color.Black;
            this.CTButtonCapNhat.Location = new System.Drawing.Point(160, 416);
            this.CTButtonCapNhat.Name = "CTButtonCapNhat";
            this.CTButtonCapNhat.Size = new System.Drawing.Size(140, 40);
            this.CTButtonCapNhat.TabIndex = 5;
            this.CTButtonCapNhat.Text = "Update";
            this.CTButtonCapNhat.TextColor = System.Drawing.Color.Black;
            this.CTButtonCapNhat.UseVisualStyleBackColor = false;
            this.CTButtonCapNhat.Click += new System.EventHandler(this.CTButtonCapNhat_Click);
            // 
            // LabelSuaChiTietTienNghi
            // 
            this.LabelSuaChiTietTienNghi.AutoSize = true;
            this.LabelSuaChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSuaChiTietTienNghi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelSuaChiTietTienNghi.Location = new System.Drawing.Point(115, 20);
            this.LabelSuaChiTietTienNghi.Name = "LabelSuaChiTietTienNghi";
            this.LabelSuaChiTietTienNghi.Size = new System.Drawing.Size(292, 37);
            this.LabelSuaChiTietTienNghi.TabIndex = 0;
            this.LabelSuaChiTietTienNghi.Text = "Edit amenities details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.CTTextBoxSoLuong);
            this.panel1.Controls.Add(this.ctTextBoxGhiChu);
            this.panel1.Controls.Add(this.ctTextBoxTenTienNghi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(38, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 317);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::HotelManagement.Properties.Resources.note;
            this.pictureBox4.Location = new System.Drawing.Point(84, 217);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::HotelManagement.Properties.Resources.SoLuong;
            this.pictureBox3.Location = new System.Drawing.Point(84, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // CTTextBoxSoLuong
            // 
            this.CTTextBoxSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTTextBoxSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxSoLuong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxSoLuong.BorderRadius = 0;
            this.CTTextBoxSoLuong.BorderSize = 2;
            this.CTTextBoxSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxSoLuong.ForeColor = System.Drawing.Color.Gray;
            this.CTTextBoxSoLuong.IsFocused = false;
            this.CTTextBoxSoLuong.Location = new System.Drawing.Point(121, 125);
            this.CTTextBoxSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxSoLuong.Multiline = false;
            this.CTTextBoxSoLuong.Name = "CTTextBoxSoLuong";
            this.CTTextBoxSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxSoLuong.PasswordChar = false;
            this.CTTextBoxSoLuong.PlaceholderColor = System.Drawing.Color.Transparent;
            this.CTTextBoxSoLuong.PlaceholderText = "Quantity";
            this.CTTextBoxSoLuong.ReadOnly = false;
            this.CTTextBoxSoLuong.Size = new System.Drawing.Size(250, 35);
            this.CTTextBoxSoLuong.TabIndex = 3;
            this.CTTextBoxSoLuong.Texts = "";
            this.CTTextBoxSoLuong.UnderlineedStyle = true;
            this.CTTextBoxSoLuong._TextChanged += new System.EventHandler(this.CTTextBoxSoLuong__TextChanged);
            // 
            // ctTextBoxGhiChu
            // 
            this.ctTextBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ctTextBoxGhiChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ctTextBoxGhiChu.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ctTextBoxGhiChu.BorderRadius = 0;
            this.ctTextBoxGhiChu.BorderSize = 2;
            this.ctTextBoxGhiChu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxGhiChu.ForeColor = System.Drawing.Color.Gray;
            this.ctTextBoxGhiChu.IsFocused = false;
            this.ctTextBoxGhiChu.Location = new System.Drawing.Point(121, 217);
            this.ctTextBoxGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxGhiChu.Multiline = false;
            this.ctTextBoxGhiChu.Name = "ctTextBoxGhiChu";
            this.ctTextBoxGhiChu.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxGhiChu.PasswordChar = false;
            this.ctTextBoxGhiChu.PlaceholderColor = System.Drawing.Color.Transparent;
            this.ctTextBoxGhiChu.PlaceholderText = "Describe";
            this.ctTextBoxGhiChu.ReadOnly = false;
            this.ctTextBoxGhiChu.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxGhiChu.TabIndex = 4;
            this.ctTextBoxGhiChu.Texts = "";
            this.ctTextBoxGhiChu.UnderlineedStyle = true;
            // 
            // ctTextBoxTenTienNghi
            // 
            this.ctTextBoxTenTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ctTextBoxTenTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ctTextBoxTenTienNghi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ctTextBoxTenTienNghi.BorderRadius = 0;
            this.ctTextBoxTenTienNghi.BorderSize = 2;
            this.ctTextBoxTenTienNghi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBoxTenTienNghi.ForeColor = System.Drawing.Color.DimGray;
            this.ctTextBoxTenTienNghi.IsFocused = false;
            this.ctTextBoxTenTienNghi.Location = new System.Drawing.Point(121, 39);
            this.ctTextBoxTenTienNghi.Margin = new System.Windows.Forms.Padding(4);
            this.ctTextBoxTenTienNghi.Multiline = false;
            this.ctTextBoxTenTienNghi.Name = "ctTextBoxTenTienNghi";
            this.ctTextBoxTenTienNghi.Padding = new System.Windows.Forms.Padding(7);
            this.ctTextBoxTenTienNghi.PasswordChar = false;
            this.ctTextBoxTenTienNghi.PlaceholderColor = System.Drawing.Color.White;
            this.ctTextBoxTenTienNghi.PlaceholderText = "Amenity name";
            this.ctTextBoxTenTienNghi.ReadOnly = true;
            this.ctTextBoxTenTienNghi.Size = new System.Drawing.Size(250, 35);
            this.ctTextBoxTenTienNghi.TabIndex = 2;
            this.ctTextBoxTenTienNghi.Texts = "";
            this.ctTextBoxTenTienNghi.UnderlineedStyle = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DichVu;
            this.pictureBox1.Location = new System.Drawing.Point(84, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormSuaChiTietTienNghi
            // 
            this.AcceptButton = this.CTButtonCapNhat;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSuaChiTietTienNghi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaChiTietTienNghi";
            this.Activated += new System.EventHandler(this.FormSuaChiTietTienNghi_Activated);
            this.Load += new System.EventHandler(this.FormSuaChiTietTienNghi_Load);
            this.SizeChanged += new System.EventHandler(this.FormSuaChiTietTienNghi_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSuaChiTietTienNghi_Paint);
            this.Resize += new System.EventHandler(this.FormSuaChiTietTienNghi_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton CTButtonThoat;
        private CTControls.CTButton CTButtonCapNhat;
        private System.Windows.Forms.Label LabelSuaChiTietTienNghi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox ctTextBoxTenTienNghi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CTControls.CTTextBox CTTextBoxSoLuong;
        private CTControls.CTTextBox ctTextBoxGhiChu;
    }
}