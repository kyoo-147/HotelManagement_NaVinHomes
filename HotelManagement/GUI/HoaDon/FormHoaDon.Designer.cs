﻿namespace HotelManagement.GUI
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.ctClose1 = new HotelManagement.CTControls.CTClose();
            this.Printer = new System.Windows.Forms.PictureBox();
            this.ctMaximize1 = new HotelManagement.CTControls.CTMaximize();
            this.ctMinimize1 = new HotelManagement.CTControls.CTMinimize();
            this.TextBoxTenNV = new System.Windows.Forms.TextBox();
            this.TextBoxSoNgay = new System.Windows.Forms.TextBox();
            this.TextBoxLoaiPhong = new System.Windows.Forms.TextBox();
            this.TextBoxMaPhong = new System.Windows.Forms.TextBox();
            this.TextBoxSoHD = new System.Windows.Forms.TextBox();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.TextBoxNgayHD = new System.Windows.Forms.TextBox();
            this.TextBoxTenKH = new System.Windows.Forms.TextBox();
            this.LabelTongTien = new System.Windows.Forms.Label();
            this.DataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelNgayHD = new System.Windows.Forms.Label();
            this.LabelTenKH = new System.Windows.Forms.Label();
            this.LabelHoaDon = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.DichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.ctClose1);
            this.PanelBackground.Controls.Add(this.Printer);
            this.PanelBackground.Controls.Add(this.ctMaximize1);
            this.PanelBackground.Controls.Add(this.ctMinimize1);
            this.PanelBackground.Controls.Add(this.TextBoxTenNV);
            this.PanelBackground.Controls.Add(this.TextBoxSoNgay);
            this.PanelBackground.Controls.Add(this.TextBoxLoaiPhong);
            this.PanelBackground.Controls.Add(this.TextBoxMaPhong);
            this.PanelBackground.Controls.Add(this.TextBoxSoHD);
            this.PanelBackground.Controls.Add(this.PictureIcon);
            this.PanelBackground.Controls.Add(this.TextBoxNgayHD);
            this.PanelBackground.Controls.Add(this.TextBoxTenKH);
            this.PanelBackground.Controls.Add(this.LabelTongTien);
            this.PanelBackground.Controls.Add(this.DataGridViewDichVu);
            this.PanelBackground.Controls.Add(this.label4);
            this.PanelBackground.Controls.Add(this.label3);
            this.PanelBackground.Controls.Add(this.label7);
            this.PanelBackground.Controls.Add(this.label6);
            this.PanelBackground.Controls.Add(this.label5);
            this.PanelBackground.Controls.Add(this.LabelNgayHD);
            this.PanelBackground.Controls.Add(this.LabelTenKH);
            this.PanelBackground.Controls.Add(this.LabelHoaDon);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(563, 677);
            this.PanelBackground.TabIndex = 0;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // ctClose1
            // 
            this.ctClose1.BackColor = System.Drawing.Color.Transparent;
            this.ctClose1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctClose1.BackgroundImage")));
            this.ctClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctClose1.Location = new System.Drawing.Point(536, 10);
            this.ctClose1.Name = "ctClose1";
            this.ctClose1.Size = new System.Drawing.Size(15, 15);
            this.ctClose1.TabIndex = 38;
            this.ctClose1.Click += new System.EventHandler(this.ctClose1_Click);
            // 
            // Printer
            // 
            this.Printer.BackColor = System.Drawing.Color.White;
            this.Printer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printer.Image = global::HotelManagement.Properties.Resources.printer;
            this.Printer.Location = new System.Drawing.Point(429, 62);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(40, 40);
            this.Printer.TabIndex = 37;
            this.Printer.TabStop = false;
            this.Printer.Click += new System.EventHandler(this.Printer_Click);
            // 
            // ctMaximize1
            // 
            this.ctMaximize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMaximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMaximize1.BackgroundImage")));
            this.ctMaximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMaximize1.Enabled = false;
            this.ctMaximize1.Location = new System.Drawing.Point(470, 10);
            this.ctMaximize1.Name = "ctMaximize1";
            this.ctMaximize1.Size = new System.Drawing.Size(15, 15);
            this.ctMaximize1.TabIndex = 36;
            // 
            // ctMinimize1
            // 
            this.ctMinimize1.BackColor = System.Drawing.Color.Transparent;
            this.ctMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctMinimize1.BackgroundImage")));
            this.ctMinimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctMinimize1.Enabled = false;
            this.ctMinimize1.Location = new System.Drawing.Point(502, 10);
            this.ctMinimize1.Name = "ctMinimize1";
            this.ctMinimize1.Size = new System.Drawing.Size(15, 15);
            this.ctMinimize1.TabIndex = 35;
            // 
            // TextBoxTenNV
            // 
            this.TextBoxTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTenNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenNV.ForeColor = System.Drawing.Color.White;
            this.TextBoxTenNV.Location = new System.Drawing.Point(86, 259);
            this.TextBoxTenNV.Name = "TextBoxTenNV";
            this.TextBoxTenNV.ReadOnly = true;
            this.TextBoxTenNV.Size = new System.Drawing.Size(199, 22);
            this.TextBoxTenNV.TabIndex = 30;
            this.TextBoxTenNV.Text = "Employee\'s full name";
            // 
            // TextBoxSoNgay
            // 
            this.TextBoxSoNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxSoNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSoNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSoNgay.ForeColor = System.Drawing.Color.White;
            this.TextBoxSoNgay.Location = new System.Drawing.Point(456, 260);
            this.TextBoxSoNgay.Name = "TextBoxSoNgay";
            this.TextBoxSoNgay.ReadOnly = true;
            this.TextBoxSoNgay.Size = new System.Drawing.Size(72, 22);
            this.TextBoxSoNgay.TabIndex = 29;
            this.TextBoxSoNgay.Text = "0 days";
            // 
            // TextBoxLoaiPhong
            // 
            this.TextBoxLoaiPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxLoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.TextBoxLoaiPhong.Location = new System.Drawing.Point(417, 220);
            this.TextBoxLoaiPhong.Name = "TextBoxLoaiPhong";
            this.TextBoxLoaiPhong.ReadOnly = true;
            this.TextBoxLoaiPhong.Size = new System.Drawing.Size(100, 22);
            this.TextBoxLoaiPhong.TabIndex = 28;
            this.TextBoxLoaiPhong.Text = "Single room";
            // 
            // TextBoxMaPhong
            // 
            this.TextBoxMaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaPhong.ForeColor = System.Drawing.Color.White;
            this.TextBoxMaPhong.Location = new System.Drawing.Point(422, 140);
            this.TextBoxMaPhong.Name = "TextBoxMaPhong";
            this.TextBoxMaPhong.ReadOnly = true;
            this.TextBoxMaPhong.Size = new System.Drawing.Size(72, 22);
            this.TextBoxMaPhong.TabIndex = 27;
            this.TextBoxMaPhong.Text = "P000";
            // 
            // TextBoxSoHD
            // 
            this.TextBoxSoHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxSoHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxSoHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSoHD.ForeColor = System.Drawing.Color.White;
            this.TextBoxSoHD.Location = new System.Drawing.Point(157, 219);
            this.TextBoxSoHD.Name = "TextBoxSoHD";
            this.TextBoxSoHD.ReadOnly = true;
            this.TextBoxSoHD.Size = new System.Drawing.Size(92, 22);
            this.TextBoxSoHD.TabIndex = 26;
            this.TextBoxSoHD.Text = "HD number";
            // 
            // PictureIcon
            // 
            this.PictureIcon.BackColor = System.Drawing.Color.Transparent;
            this.PictureIcon.Image = ((System.Drawing.Image)(resources.GetObject("PictureIcon.Image")));
            this.PictureIcon.Location = new System.Drawing.Point(1, 1);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(72, 64);
            this.PictureIcon.TabIndex = 32;
            this.PictureIcon.TabStop = false;
            this.PictureIcon.Click += new System.EventHandler(this.PictureIcon_Click);
            // 
            // TextBoxNgayHD
            // 
            this.TextBoxNgayHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxNgayHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxNgayHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNgayHD.ForeColor = System.Drawing.Color.White;
            this.TextBoxNgayHD.Location = new System.Drawing.Point(170, 179);
            this.TextBoxNgayHD.Name = "TextBoxNgayHD";
            this.TextBoxNgayHD.ReadOnly = true;
            this.TextBoxNgayHD.Size = new System.Drawing.Size(302, 22);
            this.TextBoxNgayHD.TabIndex = 31;
            this.TextBoxNgayHD.Text = "dd/MM/yyyy hh:mm:ss AM";
            // 
            // TextBoxTenKH
            // 
            this.TextBoxTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.TextBoxTenKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTenKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxTenKH.ForeColor = System.Drawing.Color.White;
            this.TextBoxTenKH.Location = new System.Drawing.Point(125, 139);
            this.TextBoxTenKH.Name = "TextBoxTenKH";
            this.TextBoxTenKH.ReadOnly = true;
            this.TextBoxTenKH.Size = new System.Drawing.Size(184, 22);
            this.TextBoxTenKH.TabIndex = 25;
            this.TextBoxTenKH.Text = "Customer name";
            // 
            // LabelTongTien
            // 
            this.LabelTongTien.AutoSize = true;
            this.LabelTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LabelTongTien.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelTongTien.Location = new System.Drawing.Point(267, 636);
            this.LabelTongTien.Name = "LabelTongTien";
            this.LabelTongTien.Size = new System.Drawing.Size(89, 37);
            this.LabelTongTien.TabIndex = 24;
            this.LabelTongTien.Text = "Total:";
            // 
            // DataGridViewDichVu
            // 
            this.DataGridViewDichVu.AllowUserToAddRows = false;
            this.DataGridViewDichVu.AllowUserToDeleteRows = false;
            this.DataGridViewDichVu.AllowUserToResizeColumns = false;
            this.DataGridViewDichVu.AllowUserToResizeRows = false;
            this.DataGridViewDichVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridViewDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDichVu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DataGridViewDichVu.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DataGridViewDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridViewDichVu.ColumnHeadersHeight = 40;
            this.DataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DichVu,
            this.GiaTien,
            this.SoLuong,
            this.ThanhTien});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridViewDichVu.EnableHeadersVisualStyles = false;
            this.DataGridViewDichVu.Location = new System.Drawing.Point(13, 310);
            this.DataGridViewDichVu.Name = "DataGridViewDichVu";
            this.DataGridViewDichVu.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DataGridViewDichVu.RowHeadersVisible = false;
            this.DataGridViewDichVu.RowHeadersWidth = 40;
            this.DataGridViewDichVu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDichVu.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridViewDichVu.RowTemplate.Height = 25;
            this.DataGridViewDichVu.RowTemplate.ReadOnly = true;
            this.DataGridViewDichVu.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewDichVu.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridViewDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridViewDichVu.Size = new System.Drawing.Size(544, 273);
            this.DataGridViewDichVu.TabIndex = 22;
            this.DataGridViewDichVu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridViewDichVu_CellPainting);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(20, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Invoice number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(315, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Number of days:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(315, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Room type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(315, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Room code:";
            // 
            // LabelNgayHD
            // 
            this.LabelNgayHD.AutoSize = true;
            this.LabelNgayHD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNgayHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelNgayHD.Location = new System.Drawing.Point(20, 179);
            this.LabelNgayHD.Name = "LabelNgayHD";
            this.LabelNgayHD.Size = new System.Drawing.Size(104, 21);
            this.LabelNgayHD.TabIndex = 16;
            this.LabelNgayHD.Text = "Invoice date:";
            // 
            // LabelTenKH
            // 
            this.LabelTenKH.AutoSize = true;
            this.LabelTenKH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelTenKH.Location = new System.Drawing.Point(20, 139);
            this.LabelTenKH.Name = "LabelTenKH";
            this.LabelTenKH.Size = new System.Drawing.Size(86, 21);
            this.LabelTenKH.TabIndex = 15;
            this.LabelTenKH.Text = "Customer:";
            // 
            // LabelHoaDon
            // 
            this.LabelHoaDon.AutoSize = true;
            this.LabelHoaDon.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelHoaDon.Location = new System.Drawing.Point(156, 54);
            this.LabelHoaDon.Name = "LabelHoaDon";
            this.LabelHoaDon.Size = new System.Drawing.Size(241, 50);
            this.LabelHoaDon.TabIndex = 14;
            this.LabelHoaDon.Text = "Bill Payment";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // DichVu
            // 
            this.DichVu.FillWeight = 150F;
            this.DichVu.HeaderText = "Services";
            this.DichVu.Name = "DichVu";
            this.DichVu.ReadOnly = true;
            this.DichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Unit Price";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            this.GiaTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuong
            // 
            this.SoLuong.FillWeight = 75F;
            this.SoLuong.HeaderText = "Quantity";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Price";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 677);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Activated += new System.EventHandler(this.FormHoaDon_Activated);
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.SizeChanged += new System.EventHandler(this.FormHoaDon_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormHoaDon_Paint);
            this.Resize += new System.EventHandler(this.FormHoaDon_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Printer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTMaximize ctMaximize1;
        private CTControls.CTMinimize ctMinimize1;
        private System.Windows.Forms.TextBox TextBoxTenNV;
        private System.Windows.Forms.TextBox TextBoxSoNgay;
        private System.Windows.Forms.TextBox TextBoxLoaiPhong;
        private System.Windows.Forms.TextBox TextBoxMaPhong;
        private System.Windows.Forms.TextBox TextBoxSoHD;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.TextBox TextBoxNgayHD;
        private System.Windows.Forms.TextBox TextBoxTenKH;
        private System.Windows.Forms.Label LabelTongTien;
        private System.Windows.Forms.DataGridView DataGridViewDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelNgayHD;
        private System.Windows.Forms.Label LabelTenKH;
        private System.Windows.Forms.Label LabelHoaDon;
        private System.Windows.Forms.PictureBox Printer;
        private CTControls.CTClose ctClose1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn DichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}