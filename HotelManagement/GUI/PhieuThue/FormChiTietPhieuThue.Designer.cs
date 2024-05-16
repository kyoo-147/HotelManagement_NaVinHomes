namespace HotelManagement.GUI
{
    partial class FormChiTietPhieuThue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietPhieuThue));
            this.LabelChiTietPhieuThueTieuDe = new System.Windows.Forms.Label();
            this.PanelChuaThongTin = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.ctPanel1 = new CTPanel.CTPanel();
            this.LabelNhanVienLapPhieu = new System.Windows.Forms.Label();
            this.LabelThoiGianLapPhieu = new System.Windows.Forms.Label();
            this.LabelTen = new System.Windows.Forms.Label();
            this.PictureBoxSoNguoi = new System.Windows.Forms.PictureBox();
            this.PictureBoxNgayCheckin = new System.Windows.Forms.PictureBox();
            this.PictureBoxTen = new System.Windows.Forms.PictureBox();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.CTButtonThemPT = new HotelManagement.CTControls.CTButton();
            this.CTButtonOK = new HotelManagement.CTControls.CTButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.PanelChuaThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).BeginInit();
            this.PanelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelChiTietPhieuThueTieuDe
            // 
            this.LabelChiTietPhieuThueTieuDe.AutoSize = true;
            this.LabelChiTietPhieuThueTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.LabelChiTietPhieuThueTieuDe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChiTietPhieuThueTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelChiTietPhieuThueTieuDe.Location = new System.Drawing.Point(239, 12);
            this.LabelChiTietPhieuThueTieuDe.Name = "LabelChiTietPhieuThueTieuDe";
            this.LabelChiTietPhieuThueTieuDe.Size = new System.Drawing.Size(509, 37);
            this.LabelChiTietPhieuThueTieuDe.TabIndex = 5;
            this.LabelChiTietPhieuThueTieuDe.Text = "Rental ticket details {voucher number}";
            // 
            // PanelChuaThongTin
            // 
            this.PanelChuaThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelChuaThongTin.Controls.Add(this.grid);
            this.PanelChuaThongTin.Controls.Add(this.ctPanel1);
            this.PanelChuaThongTin.Controls.Add(this.LabelNhanVienLapPhieu);
            this.PanelChuaThongTin.Controls.Add(this.LabelThoiGianLapPhieu);
            this.PanelChuaThongTin.Controls.Add(this.LabelTen);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxSoNguoi);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxNgayCheckin);
            this.PanelChuaThongTin.Controls.Add(this.PictureBoxTen);
            this.PanelChuaThongTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelChuaThongTin.Location = new System.Drawing.Point(48, 58);
            this.PanelChuaThongTin.Name = "PanelChuaThongTin";
            this.PanelChuaThongTin.Size = new System.Drawing.Size(883, 435);
            this.PanelChuaThongTin.TabIndex = 11;
            this.PanelChuaThongTin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid.ColumnHeadersHeight = 50;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Location = new System.Drawing.Point(45, 92);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 40;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(791, 296);
            this.grid.TabIndex = 30;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellMouseLeave);
            this.grid.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseMove);
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
            this.ctPanel1.Location = new System.Drawing.Point(22, 82);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.Size = new System.Drawing.Size(828, 325);
            this.ctPanel1.TabIndex = 29;
            // 
            // LabelNhanVienLapPhieu
            // 
            this.LabelNhanVienLapPhieu.AutoSize = true;
            this.LabelNhanVienLapPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNhanVienLapPhieu.ForeColor = System.Drawing.Color.White;
            this.LabelNhanVienLapPhieu.Location = new System.Drawing.Point(708, 37);
            this.LabelNhanVienLapPhieu.Name = "LabelNhanVienLapPhieu";
            this.LabelNhanVienLapPhieu.Size = new System.Drawing.Size(164, 21);
            this.LabelNhanVienLapPhieu.TabIndex = 3;
            this.LabelNhanVienLapPhieu.Text = "Employee\'s Full Name";
            // 
            // LabelThoiGianLapPhieu
            // 
            this.LabelThoiGianLapPhieu.AutoSize = true;
            this.LabelThoiGianLapPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelThoiGianLapPhieu.ForeColor = System.Drawing.Color.White;
            this.LabelThoiGianLapPhieu.Location = new System.Drawing.Point(395, 37);
            this.LabelThoiGianLapPhieu.Name = "LabelThoiGianLapPhieu";
            this.LabelThoiGianLapPhieu.Size = new System.Drawing.Size(88, 21);
            this.LabelThoiGianLapPhieu.TabIndex = 3;
            this.LabelThoiGianLapPhieu.Text = "Ticket Time";
            // 
            // LabelTen
            // 
            this.LabelTen.AutoSize = true;
            this.LabelTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTen.ForeColor = System.Drawing.Color.White;
            this.LabelTen.Location = new System.Drawing.Point(67, 37);
            this.LabelTen.Name = "LabelTen";
            this.LabelTen.Size = new System.Drawing.Size(164, 21);
            this.LabelTen.TabIndex = 3;
            this.LabelTen.Text = "Customer\'s Full Name";
            // 
            // PictureBoxSoNguoi
            // 
            this.PictureBoxSoNguoi.BackColor = System.Drawing.Color.White;
            this.PictureBoxSoNguoi.Image = global::HotelManagement.Properties.Resources.NhanVien1;
            this.PictureBoxSoNguoi.Location = new System.Drawing.Point(672, 33);
            this.PictureBoxSoNguoi.Name = "PictureBoxSoNguoi";
            this.PictureBoxSoNguoi.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxSoNguoi.TabIndex = 0;
            this.PictureBoxSoNguoi.TabStop = false;
            // 
            // PictureBoxNgayCheckin
            // 
            this.PictureBoxNgayCheckin.BackColor = System.Drawing.Color.White;
            this.PictureBoxNgayCheckin.Image = global::HotelManagement.Properties.Resources.CalendarPick;
            this.PictureBoxNgayCheckin.Location = new System.Drawing.Point(360, 33);
            this.PictureBoxNgayCheckin.Name = "PictureBoxNgayCheckin";
            this.PictureBoxNgayCheckin.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxNgayCheckin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxNgayCheckin.TabIndex = 0;
            this.PictureBoxNgayCheckin.TabStop = false;
            // 
            // PictureBoxTen
            // 
            this.PictureBoxTen.BackColor = System.Drawing.Color.White;
            this.PictureBoxTen.Image = global::HotelManagement.Properties.Resources.NameKH;
            this.PictureBoxTen.Location = new System.Drawing.Point(31, 33);
            this.PictureBoxTen.Name = "PictureBoxTen";
            this.PictureBoxTen.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxTen.TabIndex = 0;
            this.PictureBoxTen.TabStop = false;
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.CTButtonThemPT);
            this.PanelBackground.Controls.Add(this.LabelChiTietPhieuThueTieuDe);
            this.PanelBackground.Controls.Add(this.CTButtonOK);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(979, 550);
            this.PanelBackground.TabIndex = 15;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // CTButtonThemPT
            // 
            this.CTButtonThemPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThemPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CTButtonThemPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonThemPT.BorderRadius = 0;
            this.CTButtonThemPT.BorderSize = 2;
            this.CTButtonThemPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonThemPT.FlatAppearance.BorderSize = 0;
            this.CTButtonThemPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonThemPT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonThemPT.ForeColor = System.Drawing.Color.White;
            this.CTButtonThemPT.Location = new System.Drawing.Point(558, 499);
            this.CTButtonThemPT.Name = "CTButtonThemPT";
            this.CTButtonThemPT.Size = new System.Drawing.Size(192, 40);
            this.CTButtonThemPT.TabIndex = 14;
            this.CTButtonThemPT.Text = "See more rental rooms";
            this.CTButtonThemPT.TextColor = System.Drawing.Color.White;
            this.CTButtonThemPT.UseVisualStyleBackColor = false;
            this.CTButtonThemPT.Click += new System.EventHandler(this.CTButtonThemPT_Click);
            // 
            // CTButtonOK
            // 
            this.CTButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.CTButtonOK.BorderRadius = 0;
            this.CTButtonOK.BorderSize = 0;
            this.CTButtonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CTButtonOK.FlatAppearance.BorderSize = 0;
            this.CTButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CTButtonOK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTButtonOK.ForeColor = System.Drawing.Color.Black;
            this.CTButtonOK.Location = new System.Drawing.Point(781, 499);
            this.CTButtonOK.Name = "CTButtonOK";
            this.CTButtonOK.Size = new System.Drawing.Size(150, 40);
            this.CTButtonOK.TabIndex = 13;
            this.CTButtonOK.Text = "Done";
            this.CTButtonOK.TextColor = System.Drawing.Color.Black;
            this.CTButtonOK.UseVisualStyleBackColor = false;
            this.CTButtonOK.Click += new System.EventHandler(this.CTButtonOK_Click);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 175F;
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 225F;
            this.Column2.HeaderText = "Start Day";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 225F;
            this.Column3.HeaderText = "End Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column5.HeaderText = "Cancel";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormChiTietPhieuThue
            // 
            this.AcceptButton = this.CTButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 550);
            this.Controls.Add(this.PanelChuaThongTin);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChiTietPhieuThue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCTPhieuThue";
            this.Activated += new System.EventHandler(this.FormCTPhieuThue_Activated);
            this.Load += new System.EventHandler(this.FormChiTietPhieuThue_Load);
            this.SizeChanged += new System.EventHandler(this.FormCTPhieuThue_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCTPhieuThue_Paint);
            this.Resize += new System.EventHandler(this.FormCTPhieuThue_Resize);
            this.PanelChuaThongTin.ResumeLayout(false);
            this.PanelChuaThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxNgayCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTen)).EndInit();
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelChiTietPhieuThueTieuDe;
        private System.Windows.Forms.Panel PanelChuaThongTin;
        private System.Windows.Forms.Label LabelNhanVienLapPhieu;
        private System.Windows.Forms.Label LabelThoiGianLapPhieu;
        private System.Windows.Forms.Label LabelTen;
        private System.Windows.Forms.PictureBox PictureBoxSoNguoi;
        private System.Windows.Forms.PictureBox PictureBoxNgayCheckin;
        private System.Windows.Forms.PictureBox PictureBoxTen;
        private CTControls.CTButton CTButtonOK;
        private CTControls.CTButton CTButtonThemPT;
        private System.Windows.Forms.Panel PanelBackground;
        private CTPanel.CTPanel ctPanel1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}