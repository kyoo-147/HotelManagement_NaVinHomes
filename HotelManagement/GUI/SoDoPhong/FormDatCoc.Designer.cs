namespace HotelManagement.GUI.SoDoPhong
{
    partial class FormDatCoc
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
            this.ButtonThoat = new HotelManagement.CTControls.CTButton();
            this.ButtonDatCoc = new HotelManagement.CTControls.CTButton();
            this.LabelDatCoc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBoxDatCoc = new HotelManagement.CTControls.CTComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxGiaTien = new HotelManagement.CTControls.CTTextBox();
            this.PanelBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PanelBackground.Controls.Add(this.ButtonThoat);
            this.PanelBackground.Controls.Add(this.ButtonDatCoc);
            this.PanelBackground.Controls.Add(this.LabelDatCoc);
            this.PanelBackground.Controls.Add(this.panel1);
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(0, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(533, 344);
            this.PanelBackground.TabIndex = 4;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            this.PanelBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            // 
            // ButtonThoat
            // 
            this.ButtonThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ButtonThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ButtonThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonThoat.BorderRadius = 0;
            this.ButtonThoat.BorderSize = 2;
            this.ButtonThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonThoat.FlatAppearance.BorderSize = 0;
            this.ButtonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThoat.ForeColor = System.Drawing.Color.White;
            this.ButtonThoat.Location = new System.Drawing.Point(337, 287);
            this.ButtonThoat.Name = "ButtonThoat";
            this.ButtonThoat.Size = new System.Drawing.Size(132, 40);
            this.ButtonThoat.TabIndex = 4;
            this.ButtonThoat.Text = "Exit";
            this.ButtonThoat.TextColor = System.Drawing.Color.White;
            this.ButtonThoat.UseVisualStyleBackColor = false;
            this.ButtonThoat.Click += new System.EventHandler(this.ButtonThoat_Click);
            // 
            // ButtonDatCoc
            // 
            this.ButtonDatCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonDatCoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.ButtonDatCoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(172)))), ((int)(((byte)(62)))));
            this.ButtonDatCoc.BorderRadius = 0;
            this.ButtonDatCoc.BorderSize = 0;
            this.ButtonDatCoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDatCoc.FlatAppearance.BorderSize = 0;
            this.ButtonDatCoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDatCoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDatCoc.ForeColor = System.Drawing.Color.Black;
            this.ButtonDatCoc.Location = new System.Drawing.Point(180, 287);
            this.ButtonDatCoc.Name = "ButtonDatCoc";
            this.ButtonDatCoc.Size = new System.Drawing.Size(140, 40);
            this.ButtonDatCoc.TabIndex = 3;
            this.ButtonDatCoc.Text = "Deposit";
            this.ButtonDatCoc.TextColor = System.Drawing.Color.Black;
            this.ButtonDatCoc.UseVisualStyleBackColor = false;
            this.ButtonDatCoc.Click += new System.EventHandler(this.ButtonDatCoc_Click);
            // 
            // LabelDatCoc
            // 
            this.LabelDatCoc.AutoSize = true;
            this.LabelDatCoc.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDatCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.LabelDatCoc.Location = new System.Drawing.Point(213, 10);
            this.LabelDatCoc.Name = "LabelDatCoc";
            this.LabelDatCoc.Size = new System.Drawing.Size(117, 37);
            this.LabelDatCoc.TabIndex = 0;
            this.LabelDatCoc.Text = "Deposit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.comboBoxDatCoc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxGiaTien);
            this.panel1.Location = new System.Drawing.Point(53, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 212);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::HotelManagement.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(73, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // comboBoxDatCoc
            // 
            this.comboBoxDatCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.comboBoxDatCoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxDatCoc.BorderSize = 2;
            this.comboBoxDatCoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatCoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDatCoc.ForeColor = System.Drawing.Color.White;
            this.comboBoxDatCoc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.comboBoxDatCoc.Items.AddRange(new object[] {
            "  50%",
            "  75%",
            "  100%"});
            this.comboBoxDatCoc.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.comboBoxDatCoc.ListTextColor = System.Drawing.Color.White;
            this.comboBoxDatCoc.Location = new System.Drawing.Point(111, 49);
            this.comboBoxDatCoc.Name = "comboBoxDatCoc";
            this.comboBoxDatCoc.Padding = new System.Windows.Forms.Padding(2);
            this.comboBoxDatCoc.Size = new System.Drawing.Size(250, 33);
            this.comboBoxDatCoc.TabIndex = 1;
            this.comboBoxDatCoc.Texts = "Pile percentage";
            this.comboBoxDatCoc.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxDatCoc_OnSelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.DichVu;
            this.pictureBox1.Location = new System.Drawing.Point(73, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textBoxGiaTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.textBoxGiaTien.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(96)))), ((int)(((byte)(116)))));
            this.textBoxGiaTien.BorderRadius = 0;
            this.textBoxGiaTien.BorderSize = 2;
            this.textBoxGiaTien.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaTien.ForeColor = System.Drawing.Color.White;
            this.textBoxGiaTien.IsFocused = false;
            this.textBoxGiaTien.Location = new System.Drawing.Point(111, 115);
            this.textBoxGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGiaTien.Multiline = false;
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxGiaTien.PasswordChar = false;
            this.textBoxGiaTien.PlaceholderColor = System.Drawing.Color.DimGray;
            this.textBoxGiaTien.PlaceholderText = "Corresponding price";
            this.textBoxGiaTien.ReadOnly = true;
            this.textBoxGiaTien.Size = new System.Drawing.Size(250, 35);
            this.textBoxGiaTien.TabIndex = 2;
            this.textBoxGiaTien.Texts = "";
            this.textBoxGiaTien.UnderlineedStyle = true;
            // 
            // FormDatCoc
            // 
            this.AcceptButton = this.ButtonDatCoc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 344);
            this.Controls.Add(this.PanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDatCoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormThemTienNghi";
            this.Activated += new System.EventHandler(this.FormDatCoc_Activated);
            this.Load += new System.EventHandler(this.FormDatCoc_Load);
            this.SizeChanged += new System.EventHandler(this.FormDatCoc_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormDatCoc_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBackground_MouseDown);
            this.Resize += new System.EventHandler(this.FormDatCoc_Resize);
            this.PanelBackground.ResumeLayout(false);
            this.PanelBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBackground;
        private CTControls.CTButton ButtonThoat;
        private CTControls.CTButton ButtonDatCoc;
        private System.Windows.Forms.Label LabelDatCoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CTControls.CTTextBox textBoxGiaTien;
        private CTControls.CTComboBox comboBoxDatCoc;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}