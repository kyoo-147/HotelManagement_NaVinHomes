﻿using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.GUI;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.CTControls
{
    public partial class CTRoomDaDat : CTRoom
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.FromArgb(63, 130, 0);
        CTDP ctdp = new CTDP();
        FormSoDoPhong SoDoPhong;
        FormMain formMain;
        TaiKhoan taiKhoan;
        public override string getMaPhong()
        {
            return this.LabelMaPhong.Text;
        }
        public override void setLoaiPhong(string LoaiPhong)
        {
            this.LabelLoaiPhong.Text = LoaiPhong;
        }
        public override void setGhiChu(string ghiChu)
        {
        }
        public override void setMaPhong(string maPhong)
        {
            this.LabelMaPhong.Text = maPhong;
            this.MaPhong=maPhong;
        }
        public override void setTrangThai(string trangThai)
        {
            this.LabelLoaiPhong.Text = trangThai;
            this.LabelTrangThaiLon.Text = trangThai;
        }
        public override void setThoiGianNone()
        {
            LabelThoiGian.Text = "";
        }
        public override void setThoiGian(string thoiGian)
        {
            this.LabelThoiGian.Text = thoiGian;
        }
        public override void setPhongTrong()
        {
            setThoiGianNone();
            setTrangThai("Phòng trống");
            PictureBoxTrangThai.Image = Properties.Resources.Trong;
        }
        public override void setChuaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.ChuaDonDep;
            LabelTrangThaiDonDep.Text = "Chưa dọn dẹp";
        }
        public override void setDaDonDep()
        {
            PictureBoxTrangThaiDonDep.Image = Properties.Resources.DaDonDep;
            LabelTrangThaiDonDep.Text = "Đã dọn dẹp";
        }


        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        //Constructor
        public CTRoomDaDat()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(63, 130, 0);
            this.ForeColor = Color.White;
            InitializeComponent();
        }
        public CTRoomDaDat(CTDP cTDP, FormSoDoPhong SoDoPhong, FormMain formMain,TaiKhoan taiKhoan)
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.Size = new Size(280, 155);
            this.BackColor = Color.FromArgb(63, 130, 0);
            this.ForeColor = Color.White;
            ctdp = cTDP;
            this.SoDoPhong = SoDoPhong;
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan = taiKhoan;
            this.LoaiPhong = "DaDat";
            this.MaPhong = cTDP.MaPH;
        }
        //Methods
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;
            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

        }



        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        //Private methods
        private void CTRoomDaDat_VisibleChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void CTRoomDaDat_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        
        private void CTRoomDaDat_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThongTinPhong formThongTinPhong = new FormThongTinPhong(formMain, this.LabelTrangThaiLon.Text, ctdp, BUS.PhongBUS.Instance.FindePhong(ctdp.MaPH), taiKhoan))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThongTinPhong.Owner = formBackground;
                    formThongTinPhong.ShowDialog();
                    this.SoDoPhong.LoadLanDau();
                    formBackground.Dispose();
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notifications",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { formBackground.Dispose(); }
        }
        private void setColorMove(Color colorTop, Color colorBack)
        {
            LabelMaPhong.BackColor
                = LabelLoaiPhong.BackColor
                = PictureBoxTrangThai.BackColor
                = LabelTrangThaiLon.BackColor
                = LabelGhiChu.BackColor
                = PanelTop.BackColor = colorTop;
            this.BackColor
                = PictureBoxThoiGian.BackColor
                = PictureBoxTrangThaiDonDep.BackColor
                = LabelThoiGian.BackColor
                = LabelTrangThaiDonDep.BackColor
                = colorBack;
        }
        private void setColorLeave(Color colorTop, Color colorBack)
        {
            LabelMaPhong.BackColor
                = LabelLoaiPhong.BackColor
                = PictureBoxTrangThai.BackColor
                = LabelTrangThaiLon.BackColor
                = PanelTop.BackColor
                = LabelGhiChu.BackColor
                = colorTop;
            this.BackColor
                = PictureBoxThoiGian.BackColor
                = PictureBoxTrangThaiDonDep.BackColor
                = LabelThoiGian.BackColor
                = LabelTrangThaiDonDep.BackColor
                = colorBack;
        }
        private void CTRoomDaDat_MouseLeave(object sender, EventArgs e)
        {
            setColorLeave(Color.FromArgb(63, 130, 0), Color.FromArgb(63, 130, 0));
        }

        private void CTRoomDaDat_MouseMove(object sender, MouseEventArgs e)
        {
            setColorMove(Color.FromArgb(63, 130, 0), Color.FromArgb(63, 130, 0));
        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
