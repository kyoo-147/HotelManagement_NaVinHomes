﻿using System.Windows.Forms;

namespace HotelManagement.GUI
{
    partial class FormDatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public class DoubleBufferPanel : Panel

        {

            public DoubleBufferPanel()

            {

                // Set the value of the double-buffering style bits to true.

                this.DoubleBuffered = true;

                this.SetStyle(ControlStyles.AllPaintingInWmPaint |

                ControlStyles.UserPaint |

                ControlStyles.OptimizedDoubleBuffer, true);

                UpdateStyles();

            }

        }
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new HotelManagement.GUI.FormDatPhong.DoubleBufferPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBoxLetterKetThuc = new HotelManagement.CTControls.CTComboBox();
            this.cbBoxGioKetThuc = new HotelManagement.CTControls.CTComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxLetterBatDau = new HotelManagement.CTControls.CTComboBox();
            this.cbBoxGioBatDau = new HotelManagement.CTControls.CTComboBox();
            this.ComboBoxGioiTinh = new HotelManagement.CTControls.CTComboBox();
            this.gridPhongTrong = new System.Windows.Forms.DataGridView();
            this.gridPhongDaChon = new System.Windows.Forms.DataGridView();
            this.ctPanel2 = new CTPanel.CTPanel();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.PictureBoxCCCD = new System.Windows.Forms.PictureBox();
            this.PictureBoxGioiTinh = new System.Windows.Forms.PictureBox();
            this.PictureBoxDiaChi = new System.Windows.Forms.PictureBox();
            this.PictureBoxSDT = new System.Windows.Forms.PictureBox();
            this.PictureBoxTen = new System.Windows.Forms.PictureBox();
            this.CTTextBoxNhapDiaChi = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapSDT = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapCCCD = new HotelManagement.CTControls.CTTextBox();
            this.CTTextBoxNhapHoTen = new HotelManagement.CTControls.CTTextBox();
            this.LabelThongTinKH = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxGioBD = new System.Windows.Forms.PictureBox();
            this.PictureBoxNgayBD = new System.Windows.Forms.PictureBox();
            this.PictureBoxNgayKT = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CTDatePickerNgayKT = new HotelManagement.CTControls.CTDatePicker();
            this.CTDatePickerNgayBD = new HotelManagement.CTControls.CTDatePicker();
            this.LabelThongTinPhong = new System.Windows.Forms.Label();
            this.LabelDatPhong = new System.Windows.Forms.Label();
            this.PanelBackground = new HotelManagement.GUI.FormDatPhong.DoubleBufferPanel();
            this.CTButtonHuy = new HotelManagement.CTControls.CTButton();
            this.CTButtonDatTruoc = new HotelManagement.CTControls.CTButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCCCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGioBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayKT)).BeginInit();
            this.PanelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbBoxLetterKetThuc);
            this.panel1.Controls.Add(this.cbBoxGioKetThuc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbBoxLetterBatDau);
            this.panel1.Controls.Add(this.cbBoxGioBatDau);
            this.panel1.Controls.Add(this.ComboBoxGioiTinh);
            this.panel1.Controls.Add(this.gridPhongTrong);
            this.panel1.Controls.Add(this.gridPhongDaChon);
            this.panel1.Controls.Add(this.ctPanel2);
            this.panel1.Controls.Add(this.ctPanel1);
            this.panel1.Controls.Add(this.PictureBoxCCCD);
            this.panel1.Controls.Add(this.PictureBoxGioiTinh);
            this.panel1.Controls.Add(this.PictureBoxDiaChi);
            this.panel1.Controls.Add(this.PictureBoxSDT);
            this.panel1.Controls.Add(this.PictureBoxTen);
            this.panel1.Controls.Add(this.CTTextBoxNhapDiaChi);
            this.panel1.Controls.Add(this.CTTextBoxNhapSDT);
            this.panel1.Controls.Add(this.CTTextBoxNhapCCCD);
            this.panel1.Controls.Add(this.CTTextBoxNhapHoTen);
            this.panel1.Controls.Add(this.LabelThongTinKH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PictureBoxGioBD);
            this.panel1.Controls.Add(this.PictureBoxNgayBD);
            this.panel1.Controls.Add(this.PictureBoxNgayKT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CTDatePickerNgayKT);
            this.panel1.Controls.Add(this.CTDatePickerNgayBD);
            this.panel1.Controls.Add(this.LabelThongTinPhong);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(36, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 467);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(751, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "End Time";
            // 
            // cbBoxLetterKetThuc
            // 
            this.cbBoxLetterKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbBoxLetterKetThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxLetterKetThuc.BorderSize = 2;
            this.cbBoxLetterKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxLetterKetThuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxLetterKetThuc.ForeColor = System.Drawing.Color.White;
            this.cbBoxLetterKetThuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxLetterKetThuc.Items.AddRange(new object[] {
            "   AM",
            "   PM"});
            this.cbBoxLetterKetThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.cbBoxLetterKetThuc.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxLetterKetThuc.Location = new System.Drawing.Point(803, 136);
            this.cbBoxLetterKetThuc.Name = "cbBoxLetterKetThuc";
            this.cbBoxLetterKetThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxLetterKetThuc.Size = new System.Drawing.Size(80, 33);
            this.cbBoxLetterKetThuc.TabIndex = 10;
            this.cbBoxLetterKetThuc.Texts = "   AM";
            this.cbBoxLetterKetThuc.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxLetterKetThuc_OnSelectedIndexChanged);
            // 
            // cbBoxGioKetThuc
            // 
            this.cbBoxGioKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbBoxGioKetThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxGioKetThuc.BorderSize = 2;
            this.cbBoxGioKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGioKetThuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxGioKetThuc.ForeColor = System.Drawing.Color.White;
            this.cbBoxGioKetThuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxGioKetThuc.Items.AddRange(new object[] {
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30"});
            this.cbBoxGioKetThuc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.cbBoxGioKetThuc.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxGioKetThuc.Location = new System.Drawing.Point(725, 136);
            this.cbBoxGioKetThuc.Name = "cbBoxGioKetThuc";
            this.cbBoxGioKetThuc.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxGioKetThuc.Size = new System.Drawing.Size(80, 33);
            this.cbBoxGioKetThuc.TabIndex = 9;
            this.cbBoxGioKetThuc.Texts = "12:00";
            this.cbBoxGioKetThuc.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxGioKetThuc_OnSelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.ClockPick;
            this.pictureBox1.Location = new System.Drawing.Point(675, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(754, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // cbBoxLetterBatDau
            // 
            this.cbBoxLetterBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbBoxLetterBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxLetterBatDau.BorderSize = 2;
            this.cbBoxLetterBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxLetterBatDau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxLetterBatDau.ForeColor = System.Drawing.Color.White;
            this.cbBoxLetterBatDau.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxLetterBatDau.Items.AddRange(new object[] {
            "   AM",
            "   PM"});
            this.cbBoxLetterBatDau.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.cbBoxLetterBatDau.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxLetterBatDau.Location = new System.Drawing.Point(803, 69);
            this.cbBoxLetterBatDau.Name = "cbBoxLetterBatDau";
            this.cbBoxLetterBatDau.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxLetterBatDau.Size = new System.Drawing.Size(80, 33);
            this.cbBoxLetterBatDau.TabIndex = 7;
            this.cbBoxLetterBatDau.Texts = "   AM";
            this.cbBoxLetterBatDau.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxLetterBatDau_OnSelectedIndexChanged);
            // 
            // cbBoxGioBatDau
            // 
            this.cbBoxGioBatDau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.cbBoxGioBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxGioBatDau.BorderSize = 2;
            this.cbBoxGioBatDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGioBatDau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxGioBatDau.ForeColor = System.Drawing.Color.White;
            this.cbBoxGioBatDau.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.cbBoxGioBatDau.Items.AddRange(new object[] {
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30"});
            this.cbBoxGioBatDau.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.cbBoxGioBatDau.ListTextColor = System.Drawing.Color.Black;
            this.cbBoxGioBatDau.Location = new System.Drawing.Point(725, 69);
            this.cbBoxGioBatDau.Name = "cbBoxGioBatDau";
            this.cbBoxGioBatDau.Padding = new System.Windows.Forms.Padding(2);
            this.cbBoxGioBatDau.Size = new System.Drawing.Size(80, 33);
            this.cbBoxGioBatDau.TabIndex = 6;
            this.cbBoxGioBatDau.Texts = "12:00";
            this.cbBoxGioBatDau.OnSelectedIndexChanged += new System.EventHandler(this.cbBoxGioBatDau_OnSelectedIndexChanged);
            // 
            // ComboBoxGioiTinh
            // 
            this.ComboBoxGioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ComboBoxGioiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ComboBoxGioiTinh.BorderSize = 2;
            this.ComboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxGioiTinh.ForeColor = System.Drawing.Color.White;
            this.ComboBoxGioiTinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ComboBoxGioiTinh.Items.AddRange(new object[] {
            "  Nam",
            "  Nữ"});
            this.ComboBoxGioiTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ComboBoxGioiTinh.ListTextColor = System.Drawing.Color.White;
            this.ComboBoxGioiTinh.Location = new System.Drawing.Point(79, 395);
            this.ComboBoxGioiTinh.Name = "ComboBoxGioiTinh";
            this.ComboBoxGioiTinh.Padding = new System.Windows.Forms.Padding(2);
            this.ComboBoxGioiTinh.Size = new System.Drawing.Size(153, 33);
            this.ComboBoxGioiTinh.TabIndex = 5;
            this.ComboBoxGioiTinh.Texts = "Gender";
            // 
            // gridPhongTrong
            // 
            this.gridPhongTrong.AllowUserToAddRows = false;
            this.gridPhongTrong.AllowUserToDeleteRows = false;
            this.gridPhongTrong.AllowUserToResizeColumns = false;
            this.gridPhongTrong.AllowUserToResizeRows = false;
            this.gridPhongTrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPhongTrong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPhongTrong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gridPhongTrong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPhongTrong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPhongTrong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhongTrong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridPhongTrong.ColumnHeadersHeight = 50;
            this.gridPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridPhongTrong.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPhongTrong.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridPhongTrong.EnableHeadersVisualStyles = false;
            this.gridPhongTrong.Location = new System.Drawing.Point(319, 239);
            this.gridPhongTrong.MultiSelect = false;
            this.gridPhongTrong.Name = "gridPhongTrong";
            this.gridPhongTrong.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhongTrong.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridPhongTrong.RowHeadersVisible = false;
            this.gridPhongTrong.RowHeadersWidth = 40;
            this.gridPhongTrong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPhongTrong.RowTemplate.Height = 40;
            this.gridPhongTrong.RowTemplate.ReadOnly = true;
            this.gridPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPhongTrong.Size = new System.Drawing.Size(284, 198);
            this.gridPhongTrong.TabIndex = 11;
            this.gridPhongTrong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhongTrong_CellClick);
            this.gridPhongTrong.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhongTrong_CellMouseLeave);
            this.gridPhongTrong.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPhongTrong_CellMouseMove);
            // 
            // gridPhongDaChon
            // 
            this.gridPhongDaChon.AllowUserToAddRows = false;
            this.gridPhongDaChon.AllowUserToDeleteRows = false;
            this.gridPhongDaChon.AllowUserToResizeColumns = false;
            this.gridPhongDaChon.AllowUserToResizeRows = false;
            this.gridPhongDaChon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPhongDaChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridPhongDaChon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.gridPhongDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPhongDaChon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPhongDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhongDaChon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.gridPhongDaChon.ColumnHeadersHeight = 50;
            this.gridPhongDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPhongDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridPhongDaChon.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPhongDaChon.DefaultCellStyle = dataGridViewCellStyle17;
            this.gridPhongDaChon.EnableHeadersVisualStyles = false;
            this.gridPhongDaChon.Location = new System.Drawing.Point(638, 239);
            this.gridPhongDaChon.MultiSelect = false;
            this.gridPhongDaChon.Name = "gridPhongDaChon";
            this.gridPhongDaChon.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPhongDaChon.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.gridPhongDaChon.RowHeadersVisible = false;
            this.gridPhongDaChon.RowHeadersWidth = 40;
            this.gridPhongDaChon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridPhongDaChon.RowTemplate.Height = 40;
            this.gridPhongDaChon.RowTemplate.ReadOnly = true;
            this.gridPhongDaChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPhongDaChon.Size = new System.Drawing.Size(285, 198);
            this.gridPhongDaChon.TabIndex = 12;
            this.gridPhongDaChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhongDaChon_CellClick);
            this.gridPhongDaChon.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhongDaChon_CellMouseLeave);
            this.gridPhongDaChon.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPhongDaChon_CellMouseMove);
            // 
            // ctPanel2
            // 
            this.ctPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ctPanel2.BorderRadius = 0;
            this.ctPanel2.ForeColor = System.Drawing.Color.Black;
            this.ctPanel2.GradientAngle = 0F;
            this.ctPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel2.Location = new System.Drawing.Point(627, 231);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Size = new System.Drawing.Size(305, 224);
            this.ctPanel2.TabIndex = 31;
            // 
            // ctPanel1
            // 
            this.ctPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ctPanel1.BorderRadius = 0;
            this.ctPanel1.ForeColor = System.Drawing.Color.Black;
            this.ctPanel1.GradientAngle = 0F;
            this.ctPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel1.Location = new System.Drawing.Point(308, 231);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(305, 224);
            this.ctPanel1.TabIndex = 29;
            // 
            // PictureBoxCCCD
            // 
            this.PictureBoxCCCD.BackColor = System.Drawing.Color.White;
            this.PictureBoxCCCD.Image = global::HotelManagement.Properties.Resources.CCCD;
            this.PictureBoxCCCD.Location = new System.Drawing.Point(38, 180);
            this.PictureBoxCCCD.Name = "PictureBoxCCCD";
            this.PictureBoxCCCD.Size = new System.Drawing.Size(38, 27);
            this.PictureBoxCCCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCCCD.TabIndex = 24;
            this.PictureBoxCCCD.TabStop = false;
            // 
            // PictureBoxGioiTinh
            // 
            this.PictureBoxGioiTinh.BackColor = System.Drawing.Color.White;
            this.PictureBoxGioiTinh.Image = global::HotelManagement.Properties.Resources.Gender;
            this.PictureBoxGioiTinh.Location = new System.Drawing.Point(42, 398);
            this.PictureBoxGioiTinh.Name = "PictureBoxGioiTinh";
            this.PictureBoxGioiTinh.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxGioiTinh.TabIndex = 20;
            this.PictureBoxGioiTinh.TabStop = false;
            // 
            // PictureBoxDiaChi
            // 
            this.PictureBoxDiaChi.BackColor = System.Drawing.Color.White;
            this.PictureBoxDiaChi.Image = global::HotelManagement.Properties.Resources.Address;
            this.PictureBoxDiaChi.Location = new System.Drawing.Point(42, 320);
            this.PictureBoxDiaChi.Name = "PictureBoxDiaChi";
            this.PictureBoxDiaChi.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxDiaChi.TabIndex = 21;
            this.PictureBoxDiaChi.TabStop = false;
            // 
            // PictureBoxSDT
            // 
            this.PictureBoxSDT.BackColor = System.Drawing.Color.White;
            this.PictureBoxSDT.Image = global::HotelManagement.Properties.Resources.Phone;
            this.PictureBoxSDT.Location = new System.Drawing.Point(42, 249);
            this.PictureBoxSDT.Name = "PictureBoxSDT";
            this.PictureBoxSDT.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxSDT.TabIndex = 22;
            this.PictureBoxSDT.TabStop = false;
            // 
            // PictureBoxTen
            // 
            this.PictureBoxTen.BackColor = System.Drawing.Color.White;
            this.PictureBoxTen.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.PictureBoxTen.Location = new System.Drawing.Point(42, 105);
            this.PictureBoxTen.Name = "PictureBoxTen";
            this.PictureBoxTen.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTen.TabIndex = 23;
            this.PictureBoxTen.TabStop = false;
            // 
            // CTTextBoxNhapDiaChi
            // 
            this.CTTextBoxNhapDiaChi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTTextBoxNhapDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxNhapDiaChi.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxNhapDiaChi.BorderRadius = 0;
            this.CTTextBoxNhapDiaChi.BorderSize = 1;
            this.CTTextBoxNhapDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapDiaChi.ForeColor = System.Drawing.Color.White;
            this.CTTextBoxNhapDiaChi.IsFocused = false;
            this.CTTextBoxNhapDiaChi.Location = new System.Drawing.Point(79, 314);
            this.CTTextBoxNhapDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapDiaChi.Multiline = false;
            this.CTTextBoxNhapDiaChi.Name = "CTTextBoxNhapDiaChi";
            this.CTTextBoxNhapDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapDiaChi.PasswordChar = false;
            this.CTTextBoxNhapDiaChi.PlaceholderColor = System.Drawing.Color.White;
            this.CTTextBoxNhapDiaChi.PlaceholderText = "Enter citizenship";
            this.CTTextBoxNhapDiaChi.ReadOnly = false;
            this.CTTextBoxNhapDiaChi.Size = new System.Drawing.Size(205, 36);
            this.CTTextBoxNhapDiaChi.TabIndex = 4;
            this.CTTextBoxNhapDiaChi.Texts = "";
            this.CTTextBoxNhapDiaChi.UnderlineedStyle = true;
            this.CTTextBoxNhapDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CTTextBoxNhapDiaChi_KeyPress);
            // 
            // CTTextBoxNhapSDT
            // 
            this.CTTextBoxNhapSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTTextBoxNhapSDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxNhapSDT.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxNhapSDT.BorderRadius = 0;
            this.CTTextBoxNhapSDT.BorderSize = 1;
            this.CTTextBoxNhapSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapSDT.ForeColor = System.Drawing.Color.White;
            this.CTTextBoxNhapSDT.IsFocused = false;
            this.CTTextBoxNhapSDT.Location = new System.Drawing.Point(79, 243);
            this.CTTextBoxNhapSDT.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapSDT.Multiline = false;
            this.CTTextBoxNhapSDT.Name = "CTTextBoxNhapSDT";
            this.CTTextBoxNhapSDT.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapSDT.PasswordChar = false;
            this.CTTextBoxNhapSDT.PlaceholderColor = System.Drawing.Color.White;
            this.CTTextBoxNhapSDT.PlaceholderText = "Enter your phone number";
            this.CTTextBoxNhapSDT.ReadOnly = false;
            this.CTTextBoxNhapSDT.Size = new System.Drawing.Size(205, 36);
            this.CTTextBoxNhapSDT.TabIndex = 3;
            this.CTTextBoxNhapSDT.Texts = "";
            this.CTTextBoxNhapSDT.UnderlineedStyle = true;
            this.CTTextBoxNhapSDT._TextChanged += new System.EventHandler(this.CTTextBoxNhapSDT__TextChanged);
            // 
            // CTTextBoxNhapCCCD
            // 
            this.CTTextBoxNhapCCCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTTextBoxNhapCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxNhapCCCD.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxNhapCCCD.BorderRadius = 0;
            this.CTTextBoxNhapCCCD.BorderSize = 1;
            this.CTTextBoxNhapCCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapCCCD.ForeColor = System.Drawing.Color.White;
            this.CTTextBoxNhapCCCD.IsFocused = false;
            this.CTTextBoxNhapCCCD.Location = new System.Drawing.Point(79, 172);
            this.CTTextBoxNhapCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapCCCD.Multiline = false;
            this.CTTextBoxNhapCCCD.Name = "CTTextBoxNhapCCCD";
            this.CTTextBoxNhapCCCD.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapCCCD.PasswordChar = false;
            this.CTTextBoxNhapCCCD.PlaceholderColor = System.Drawing.Color.White;
            this.CTTextBoxNhapCCCD.PlaceholderText = "Enter National ID number";
            this.CTTextBoxNhapCCCD.ReadOnly = false;
            this.CTTextBoxNhapCCCD.Size = new System.Drawing.Size(205, 36);
            this.CTTextBoxNhapCCCD.TabIndex = 2;
            this.CTTextBoxNhapCCCD.Texts = "";
            this.CTTextBoxNhapCCCD.UnderlineedStyle = true;
            this.CTTextBoxNhapCCCD._TextChanged += new System.EventHandler(this.CTTextBoxNhapCCCD__TextChanged);
            // 
            // CTTextBoxNhapHoTen
            // 
            this.CTTextBoxNhapHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTTextBoxNhapHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTTextBoxNhapHoTen.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxNhapHoTen.BorderRadius = 0;
            this.CTTextBoxNhapHoTen.BorderSize = 1;
            this.CTTextBoxNhapHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxNhapHoTen.ForeColor = System.Drawing.Color.White;
            this.CTTextBoxNhapHoTen.IsFocused = false;
            this.CTTextBoxNhapHoTen.Location = new System.Drawing.Point(79, 99);
            this.CTTextBoxNhapHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxNhapHoTen.Multiline = false;
            this.CTTextBoxNhapHoTen.Name = "CTTextBoxNhapHoTen";
            this.CTTextBoxNhapHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.CTTextBoxNhapHoTen.PasswordChar = false;
            this.CTTextBoxNhapHoTen.PlaceholderColor = System.Drawing.Color.White;
            this.CTTextBoxNhapHoTen.PlaceholderText = "Enter the customer\'s full name";
            this.CTTextBoxNhapHoTen.ReadOnly = false;
            this.CTTextBoxNhapHoTen.Size = new System.Drawing.Size(228, 36);
            this.CTTextBoxNhapHoTen.TabIndex = 1;
            this.CTTextBoxNhapHoTen.Texts = "";
            this.CTTextBoxNhapHoTen.UnderlineedStyle = true;
            this.CTTextBoxNhapHoTen._TextChanged += new System.EventHandler(this.CTTextBoxNhapHoTen__TextChanged);
            // 
            // LabelThongTinKH
            // 
            this.LabelThongTinKH.AutoSize = true;
            this.LabelThongTinKH.BackColor = System.Drawing.Color.Transparent;
            this.LabelThongTinKH.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThongTinKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelThongTinKH.Location = new System.Drawing.Point(25, 27);
            this.LabelThongTinKH.Name = "LabelThongTinKH";
            this.LabelThongTinKH.Size = new System.Drawing.Size(269, 32);
            this.LabelThongTinKH.TabIndex = 15;
            this.LabelThongTinKH.Text = "Customer Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(707, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selected room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(350, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "List of available rooms";
            // 
            // PictureBoxGioBD
            // 
            this.PictureBoxGioBD.BackColor = System.Drawing.Color.White;
            this.PictureBoxGioBD.Image = global::HotelManagement.Properties.Resources.ClockPick;
            this.PictureBoxGioBD.Location = new System.Drawing.Point(675, 67);
            this.PictureBoxGioBD.Name = "PictureBoxGioBD";
            this.PictureBoxGioBD.Size = new System.Drawing.Size(35, 35);
            this.PictureBoxGioBD.TabIndex = 6;
            this.PictureBoxGioBD.TabStop = false;
            // 
            // PictureBoxNgayBD
            // 
            this.PictureBoxNgayBD.BackColor = System.Drawing.Color.White;
            this.PictureBoxNgayBD.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.PictureBoxNgayBD.Location = new System.Drawing.Point(371, 67);
            this.PictureBoxNgayBD.Name = "PictureBoxNgayBD";
            this.PictureBoxNgayBD.Size = new System.Drawing.Size(35, 35);
            this.PictureBoxNgayBD.TabIndex = 6;
            this.PictureBoxNgayBD.TabStop = false;
            // 
            // PictureBoxNgayKT
            // 
            this.PictureBoxNgayKT.BackColor = System.Drawing.Color.White;
            this.PictureBoxNgayKT.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.PictureBoxNgayKT.Location = new System.Drawing.Point(371, 134);
            this.PictureBoxNgayKT.Name = "PictureBoxNgayKT";
            this.PictureBoxNgayKT.Size = new System.Drawing.Size(35, 35);
            this.PictureBoxNgayKT.TabIndex = 6;
            this.PictureBoxNgayKT.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(442, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(440, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Day";
            // 
            // CTDatePickerNgayKT
            // 
            this.CTDatePickerNgayKT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTDatePickerNgayKT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTDatePickerNgayKT.BorderSize = 2;
            this.CTDatePickerNgayKT.CustomFormat = "dd/MM/yyyy";
            this.CTDatePickerNgayKT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTDatePickerNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CTDatePickerNgayKT.Location = new System.Drawing.Point(422, 134);
            this.CTDatePickerNgayKT.MinimumSize = new System.Drawing.Size(4, 35);
            this.CTDatePickerNgayKT.Name = "CTDatePickerNgayKT";
            this.CTDatePickerNgayKT.Size = new System.Drawing.Size(170, 35);
            this.CTDatePickerNgayKT.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTDatePickerNgayKT.TabIndex = 8;
            this.CTDatePickerNgayKT.TextColor = System.Drawing.Color.White;
            this.CTDatePickerNgayKT.ValueChanged += new System.EventHandler(this.CTDatePickerNgayKT_ValueChanged);
            // 
            // CTDatePickerNgayBD
            // 
            this.CTDatePickerNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTDatePickerNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTDatePickerNgayBD.BorderSize = 2;
            this.CTDatePickerNgayBD.CustomFormat = "dd/MM/yyyy";
            this.CTDatePickerNgayBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTDatePickerNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CTDatePickerNgayBD.Location = new System.Drawing.Point(422, 67);
            this.CTDatePickerNgayBD.MinimumSize = new System.Drawing.Size(4, 35);
            this.CTDatePickerNgayBD.Name = "CTDatePickerNgayBD";
            this.CTDatePickerNgayBD.Size = new System.Drawing.Size(170, 35);
            this.CTDatePickerNgayBD.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTDatePickerNgayBD.TabIndex = 5;
            this.CTDatePickerNgayBD.TextColor = System.Drawing.Color.White;
            this.CTDatePickerNgayBD.ValueChanged += new System.EventHandler(this.CTDatePickerNgayBD_ValueChanged);
            // 
            // LabelThongTinPhong
            // 
            this.LabelThongTinPhong.AutoSize = true;
            this.LabelThongTinPhong.BackColor = System.Drawing.Color.Transparent;
            this.LabelThongTinPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThongTinPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelThongTinPhong.Location = new System.Drawing.Point(529, 10);
            this.LabelThongTinPhong.Name = "LabelThongTinPhong";
            this.LabelThongTinPhong.Size = new System.Drawing.Size(226, 32);
            this.LabelThongTinPhong.TabIndex = 1;
            this.LabelThongTinPhong.Text = "Room Information";
            // 
            // LabelDatPhong
            // 
            this.LabelDatPhong.AutoSize = true;
            this.LabelDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.LabelDatPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelDatPhong.Location = new System.Drawing.Point(431, 9);
            this.LabelDatPhong.Name = "LabelDatPhong";
            this.LabelDatPhong.Size = new System.Drawing.Size(160, 37);
            this.LabelDatPhong.TabIndex = 0;
            this.LabelDatPhong.Text = "Book room";
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.CTButtonHuy);
            this.PanelBackground.Controls.Add(this.CTButtonDatTruoc);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(1022, 587);
            this.PanelBackground.TabIndex = 3;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonHuy
            // 
            this.CTButtonHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonHuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonHuy.BorderColor = System.Drawing.Color.White;
            this.CTButtonHuy.BorderRadius = 0;
            this.CTButtonHuy.BorderSize = 2;
            this.CTButtonHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonHuy.FlatAppearance.BorderSize = 0;
            this.CTButtonHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonHuy.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonHuy.ForeColor = System.Drawing.Color.White;
            this.CTButtonHuy.Location = new System.Drawing.Point(836, 529);
            this.CTButtonHuy.Name = "CTButtonHuy";
            this.CTButtonHuy.Size = new System.Drawing.Size(150, 40);
            this.CTButtonHuy.TabIndex = 17;
            this.CTButtonHuy.Text = "Cancel";
            this.CTButtonHuy.TextColor = System.Drawing.Color.White;
            this.CTButtonHuy.UseVisualStyleBackColor = false;
            this.CTButtonHuy.Click += new System.EventHandler(this.CTButtonHuy_Click);
            // 
            // CTButtonDatTruoc
            // 
            this.CTButtonDatTruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonDatTruoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonDatTruoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(196)))), ((int)(((byte)(68)))));
            this.CTButtonDatTruoc.BorderRadius = 0;
            this.CTButtonDatTruoc.BorderSize = 0;
            this.CTButtonDatTruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonDatTruoc.FlatAppearance.BorderSize = 0;
            this.CTButtonDatTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonDatTruoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonDatTruoc.ForeColor = System.Drawing.Color.Black;
            this.CTButtonDatTruoc.Location = new System.Drawing.Point(663, 529);
            this.CTButtonDatTruoc.Name = "CTButtonDatTruoc";
            this.CTButtonDatTruoc.Size = new System.Drawing.Size(150, 40);
            this.CTButtonDatTruoc.TabIndex = 16;
            this.CTButtonDatTruoc.Text = "Pre-book";
            this.CTButtonDatTruoc.TextColor = System.Drawing.Color.Black;
            this.CTButtonDatTruoc.UseVisualStyleBackColor = false;
            this.CTButtonDatTruoc.Click += new System.EventHandler(this.CTButtonDatTruoc_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 75F;
            this.Column3.HeaderText = "Add";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Cancel";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "End Date";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 68;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Start Day";
            this.Column6.MinimumWidth = 30;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 69;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "No. of People";
            this.Column5.MinimumWidth = 20;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 95;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Room Number";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // FormDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 587);
            this.Controls.Add(this.LabelDatPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatPhong";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDatPhong";
            this.Activated += new System.EventHandler(this.FormDatPhong_Activated);
            this.Load += new System.EventHandler(this.FormDatPhong_Load);
            this.SizeChanged += new System.EventHandler(this.FormDatPhong_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDatPhong_Paint);
            this.Resize += new System.EventHandler(this.FormDatPhong_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhongDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCCCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxGioBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayKT)).EndInit();
            this.PanelBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelThongTinPhong;
        private System.Windows.Forms.Label LabelDatPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBoxNgayBD;
        private System.Windows.Forms.PictureBox PictureBoxNgayKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CTControls.CTDatePicker CTDatePickerNgayKT;
        private CTControls.CTDatePicker CTDatePickerNgayBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PictureBoxGioBD;
        private CTControls.CTButton CTButtonDatTruoc;
        private CTControls.CTButton CTButtonHuy;
        private System.Windows.Forms.PictureBox PictureBoxCCCD;
        private System.Windows.Forms.PictureBox PictureBoxGioiTinh;
        private System.Windows.Forms.PictureBox PictureBoxDiaChi;
        private System.Windows.Forms.PictureBox PictureBoxSDT;
        private System.Windows.Forms.PictureBox PictureBoxTen;
        private CTControls.CTTextBox CTTextBoxNhapDiaChi;
        private CTControls.CTTextBox CTTextBoxNhapSDT;
        private System.Windows.Forms.Label LabelThongTinKH;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridView gridPhongTrong;
        private System.Windows.Forms.DataGridView gridPhongDaChon;
        private CTPanel.CTPanel ctPanel2;
        private CTControls.CTTextBox CTTextBoxNhapCCCD;
        private CTControls.CTComboBox ComboBoxGioiTinh;
        private CTControls.CTTextBox CTTextBoxNhapHoTen;
        private CTControls.CTComboBox cbBoxLetterBatDau;
        private CTControls.CTComboBox cbBoxGioBatDau;
        private System.Windows.Forms.Label label6;
        private CTControls.CTComboBox cbBoxLetterKetThuc;
        private CTControls.CTComboBox cbBoxGioKetThuc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DoubleBufferPanel panel1;
        private DoubleBufferPanel PanelBackground;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewImageColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewImageColumn Column8;
    }
}