using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.DAO
{
    internal class HoaDonDAO
    {
        // instance: Biến static của lớp, đại diện cho một phiên bản duy nhất của lớp HoaDonDAO.
        // Instance: Thuộc tính static dùng để truy cập đến phiên bản duy nhất của lớp HoaDonDAO.Sử dụng mẫu Singleton để đảm bảo chỉ có một đối tượng được tạo ra trong suốt vòng đời của ứng dụng.
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private HoaDonDAO() { }
        public List<HoaDon> GetHoaDons()
        {
            HotelDTO db = new HotelDTO();

            return db.HoaDons.ToList();
            
        } 
        public HoaDon FindHD(string MaHD)
        {
            HotelDTO db = new HotelDTO();

            return db.HoaDons.Find(MaHD);
            
        }
        public void Update_InsertHD(HoaDon HD)
        {
            HotelDTO db = new HotelDTO();

            HD.CTDP = db.CTDPs.Find(HD.MaCTDP);
                HD.NhanVien = db.NhanViens.Find(HD.MaNV);
                
                db.HoaDons.AddOrUpdate(HD);
                db.SaveChanges();
                
        }
        public void ThanhToanHD(HoaDon HD)
        {
            HotelDTO db = new HotelDTO();
            HD.CTDP = db.CTDPs.Find(HD.MaCTDP);
            HD.NhanVien = db.NhanViens.Find(HD.MaNV);
            db.HoaDons.AddOrUpdate(HD);
            db.SaveChanges();
            db.Dispose();
        }    
        public List<HoaDon> FindHoaDonWith_CCCD(string cccd)
        {
            HotelDTO db = new HotelDTO();

            return db.HoaDons.Where(p => p.CTDP.PhieuThue.KhachHang.CCCD_Passport.StartsWith(cccd)).ToList();
        }
        public List<HoaDon> FindHoaDonWith_Date(DateTime dateTime)
        {
            HotelDTO db = new HotelDTO();

            return db.HoaDons.Where(p => p.NgHD.Value.Month == dateTime.Month && p.NgHD.Value.Year == dateTime.Year && p.NgHD.Value.Day == dateTime.Day).ToList();
        }

        public List<HoaDon> FindHoaDonWith_DateAndCCCD(DateTime dateTime, string cccd)
        {
            HotelDTO db = new HotelDTO();

            return db.HoaDons.Where(p => p.NgHD.Value.Month == dateTime.Month && p.NgHD.Value.Year == dateTime.Year && p.NgHD.Value.Day == dateTime.Day
                                    && p.CTDP.PhieuThue.KhachHang.CCCD_Passport.StartsWith(cccd)).ToList();
        }

        public string getMaHDNext()
        {
            HotelDTO db = new HotelDTO();


            List<HoaDon> HD = db.HoaDons.ToList();
                string MaMax = HD[HD.Count - 1].MaHD.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "HD00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "HD0" + max.ToString();
                }
                return "HD" + max.ToString();
            
        }
        public void RemoveHD(HoaDon hoaDon)
        {
            HotelDTO db = new HotelDTO();

            db.HoaDons.Remove(hoaDon);
            db.SaveChanges();
        }
    }
}
