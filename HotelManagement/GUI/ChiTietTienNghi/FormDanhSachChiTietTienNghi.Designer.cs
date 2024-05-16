namespace HotelManagement.GUI
{
    partial class FormDanhSachChiTietTienNghi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelTenLoaiPhong = new System.Windows.Forms.Label();
            this.PanelChuaThongTin = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThemChiTietTienNghi = new HotelManagement.CTControls.CTButton();
            this.CTButtonLuu = new HotelManagement.CTControls.CTButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelChuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.PanelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTenLoaiPhong
            // 
            this.LabelTenLoaiPhong.AutoSize = true;
            this.LabelTenLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.LabelTenLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTenLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelTenLoaiPhong.Location = new System.Drawing.Point(416, 9);
            this.LabelTenLoaiPhong.Name = "LabelTenLoaiPhong";
            this.LabelTenLoaiPhong.Size = new System.Drawing.Size(182, 37);
            this.LabelTenLoaiPhong.TabIndex = 5;
            this.LabelTenLoaiPhong.Text = "{Room Type}";
            // 
            // PanelChuaThongTin
            // 
            this.PanelChuaThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelChuaThongTin.Controls.Add(this.grid);
            this.PanelChuaThongTin.Controls.Add(this.ctPanel1);
            this.PanelChuaThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelChuaThongTin.Location = new System.Drawing.Point(48, 58);
            this.PanelChuaThongTin.Name = "PanelChuaThongTin";
            this.PanelChuaThongTin.Size = new System.Drawing.Size(883, 435);
            this.PanelChuaThongTin.TabIndex = 11;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(45, 37);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 40;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(791, 355);
            this.grid.TabIndex = 30;
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
            this.ctPanel1.Location = new System.Drawing.Point(22, 27);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(828, 384);
            this.ctPanel1.TabIndex = 29;
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.CTButtonThemChiTietTienNghi);
            this.PanelBackground.Controls.Add(this.LabelTenLoaiPhong);
            this.PanelBackground.Controls.Add(this.CTButtonLuu);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(979, 550);
            this.PanelBackground.TabIndex = 15;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonThemChiTietTienNghi
            // 
            this.CTButtonThemChiTietTienNghi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThemChiTietTienNghi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThemChiTietTienNghi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThemChiTietTienNghi.BorderRadius = 0;
            this.CTButtonThemChiTietTienNghi.BorderSize = 2;
            this.CTButtonThemChiTietTienNghi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemChiTietTienNghi.FlatAppearance.BorderSize = 0;
            this.CTButtonThemChiTietTienNghi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemChiTietTienNghi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemChiTietTienNghi.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.Location = new System.Drawing.Point(603, 499);
            this.CTButtonThemChiTietTienNghi.Name = "CTButtonThemChiTietTienNghi";
            this.CTButtonThemChiTietTienNghi.Size = new System.Drawing.Size(155, 40);
            this.CTButtonThemChiTietTienNghi.TabIndex = 14;
            this.CTButtonThemChiTietTienNghi.Text = "Added amenities";
            this.CTButtonThemChiTietTienNghi.TextColor = System.Drawing.Color.White;
            this.CTButtonThemChiTietTienNghi.UseVisualStyleBackColor = false;
            this.CTButtonThemChiTietTienNghi.Click += new System.EventHandler(this.CTButtonThemChiTietTienNghi_Click);
            // 
            // CTButtonLuu
            // 
            this.CTButtonLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonLuu.BorderRadius = 0;
            this.CTButtonLuu.BorderSize = 0;
            this.CTButtonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonLuu.FlatAppearance.BorderSize = 0;
            this.CTButtonLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonLuu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonLuu.ForeColor = System.Drawing.Color.Black;
            this.CTButtonLuu.Location = new System.Drawing.Point(781, 499);
            this.CTButtonLuu.Name = "CTButtonLuu";
            this.CTButtonLuu.Size = new System.Drawing.Size(150, 40);
            this.CTButtonLuu.TabIndex = 13;
            this.CTButtonLuu.Text = "Done";
            this.CTButtonLuu.TextColor = System.Drawing.Color.Black;
            this.CTButtonLuu.UseVisualStyleBackColor = false;
            this.CTButtonLuu.Click += new System.EventHandler(this.CTButtonLuu_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 225F;
            this.Column1.HeaderText = "Amenity name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 175F;
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 225F;
            this.Column3.HeaderText = "Note";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 75F;
            this.Column4.HeaderText = "Repair";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 75F;
            this.Column5.HeaderText = "Delete";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormDanhSachChiTietTienNghi
            // 
            this.AcceptButton = this.CTButtonLuu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 550);
            this.Controls.Add(this.PanelChuaThongTin);
            this.Controls.Add(this.PanelBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDanhSachChiTietTienNghi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCTPhieuThue";
            this.Activated += new System.EventHandler(this.FormDanhSachChiTietTienNghi_Activated);
            this.Load += new System.EventHandler(this.FormDanhSachChiTietTienNghi_Load);
            this.SizeChanged += new System.EventHandler(this.FormDanhSachChiTietTienNghi_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDanhSachChiTietTienNghi_Paint);
            this.Resize += new System.EventHandler(this.FormDanhSachChiTietTienNghi_Resize);
            this.PanelChuaThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTenLoaiPhong;
        private System.Windows.Forms.Panel PanelChuaThongTin;
        private CTControls.CTButton CTButtonLuu;
        private CTControls.CTButton CTButtonThemChiTietTienNghi;
        private System.Windows.Forms.Panel PanelBackground;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}