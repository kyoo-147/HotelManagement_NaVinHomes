﻿namespace HotelManagement.GUI
{
    partial class FormDanhSachNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CTButtonThemNhanVien = new HotelManagement.CTControls.CTButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CTTextBoxTimTheoTenNhanVien = new HotelManagement.CTControls.CTTextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.buttonExport = new HotelManagement.CTControls.CTButton();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // CTButtonThemNhanVien
            // 
            this.CTButtonThemNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTButtonThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThemNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThemNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThemNhanVien.BorderRadius = 0;
            this.CTButtonThemNhanVien.BorderSize = 0;
            this.CTButtonThemNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemNhanVien.FlatAppearance.BorderSize = 0;
            this.CTButtonThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemNhanVien.ForeColor = System.Drawing.Color.Black;
            this.CTButtonThemNhanVien.Location = new System.Drawing.Point(1027, 30);
            this.CTButtonThemNhanVien.Name = "CTButtonThemNhanVien";
            this.CTButtonThemNhanVien.Size = new System.Drawing.Size(160, 40);
            this.CTButtonThemNhanVien.TabIndex = 17;
            this.CTButtonThemNhanVien.Text = "Add employees";
            this.CTButtonThemNhanVien.TextColor = System.Drawing.Color.Black;
            this.CTButtonThemNhanVien.UseVisualStyleBackColor = false;
            this.CTButtonThemNhanVien.Click += new System.EventHandler(this.CTButtonThemNhanVien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(51, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CTTextBoxTimTheoTenNhanVien
            // 
            this.CTTextBoxTimTheoTenNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CTTextBoxTimTheoTenNhanVien.BackColor = System.Drawing.Color.White;
            this.CTTextBoxTimTheoTenNhanVien.BorderColor = System.Drawing.Color.Gray;
            this.CTTextBoxTimTheoTenNhanVien.BorderFocusColor = System.Drawing.Color.Black;
            this.CTTextBoxTimTheoTenNhanVien.BorderRadius = 0;
            this.CTTextBoxTimTheoTenNhanVien.BorderSize = 0;
            this.CTTextBoxTimTheoTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTextBoxTimTheoTenNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this.CTTextBoxTimTheoTenNhanVien.IsFocused = false;
            this.CTTextBoxTimTheoTenNhanVien.Location = new System.Drawing.Point(45, 30);
            this.CTTextBoxTimTheoTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.CTTextBoxTimTheoTenNhanVien.Multiline = false;
            this.CTTextBoxTimTheoTenNhanVien.Name = "CTTextBoxTimTheoTenNhanVien";
            this.CTTextBoxTimTheoTenNhanVien.Padding = new System.Windows.Forms.Padding(40, 7, 7, 7);
            this.CTTextBoxTimTheoTenNhanVien.PasswordChar = false;
            this.CTTextBoxTimTheoTenNhanVien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CTTextBoxTimTheoTenNhanVien.PlaceholderText = "Enter employee name";
            this.CTTextBoxTimTheoTenNhanVien.ReadOnly = false;
            this.CTTextBoxTimTheoTenNhanVien.Size = new System.Drawing.Size(264, 36);
            this.CTTextBoxTimTheoTenNhanVien.TabIndex = 15;
            this.CTTextBoxTimTheoTenNhanVien.TabStop = false;
            this.CTTextBoxTimTheoTenNhanVien.Texts = "";
            this.CTTextBoxTimTheoTenNhanVien.UnderlineedStyle = false;
            this.CTTextBoxTimTheoTenNhanVien._TextChanged += new System.EventHandler(this.CTTextBoxTimTheoTenNhanVien__TextChanged);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.Silver;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(70, 100);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 40;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1097, 659);
            this.grid.TabIndex = 33;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellMouseLeave);
            this.grid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseMove);
            // 
            // ctPanel1
            // 
            this.ctPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel1.BorderRadius = 0;
            this.ctPanel1.ForeColor = System.Drawing.Color.Black;
            this.ctPanel1.GradientAngle = 0F;
            this.ctPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ctPanel1.Location = new System.Drawing.Point(45, 95);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(1142, 704);
            this.ctPanel1.TabIndex = 32;
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.buttonExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.buttonExport.BorderRadius = 0;
            this.buttonExport.BorderSize = 2;
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.White;
            this.buttonExport.Location = new System.Drawing.Point(850, 30);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(150, 40);
            this.buttonExport.TabIndex = 34;
            this.buttonExport.Text = "Export Excel";
            this.buttonExport.TextColor = System.Drawing.Color.White;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 125F;
            this.Column2.HeaderText = "Employee Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 200F;
            this.Column3.HeaderText = "Full Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Birthday";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 125F;
            this.Column6.HeaderText = "Gender";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 175F;
            this.Column7.HeaderText = "Phone No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 250F;
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.FillWeight = 75F;
            this.Column9.HeaderText = "Edit";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.FillWeight = 75F;
            this.Column10.HeaderText = "Delete";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // FormDanhSachNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1260, 833);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.ctPanel1);
            this.Controls.Add(this.CTButtonThemNhanVien);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CTTextBoxTimTheoTenNhanVien);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachNhanVien";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDanhSachNhanVien";
            this.Load += new System.EventHandler(this.FormDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CTControls.CTButton CTButtonThemNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox CTTextBoxTimTheoTenNhanVien;
        private System.Windows.Forms.DataGridView grid;
        private CTPanel.CTPanel ctPanel1;
        private CTControls.CTButton buttonExport;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column9;
        private System.Windows.Forms.DataGridViewImageColumn Column10;
    }
}