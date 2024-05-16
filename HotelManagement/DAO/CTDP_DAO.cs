using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.CTControls;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.DAO
{
    internal class CTDP_DAO
    {
        // instance: Biến static của lớp, đại diện cho một phiên bản duy nhất của lớp CTDP_DAO.
        // Instance: Thuộc tính static dùng để truy cập đến phiên bản duy nhất của lớp CTDP_DAO.Sử dụng mẫu Singleton để đảm bảo chỉ có một đối tượng được tạo ra trong suốt vòng đời của ứng dụng.
        private static CTDP_DAO instance;
        public static CTDP_DAO Instance
        {
            get { if (instance == null) instance = new CTDP_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDP_DAO() { }
        // Truy xuất và trả về tất cả các chi tiết đặt phòng từ cơ sở dữ liệu.
        public List<CTDP> GetCTDPs()
        {
            HotelDTO db = new HotelDTO();
            return db.CTDPs.ToList();
        }
        // Nhận mã chi tiết đặt phòng và tính toán khoảng thời gian ở dưới dạng số ngày.
        public int getKhoangTGTheoNgay(string MaCTDP)
        {
            CTDP ctdp;
            TimeSpan timeSpan = new TimeSpan();
            HotelDTO db = new HotelDTO();
            
                ctdp = db.CTDPs.Find(MaCTDP);
            
            DateTime checkin = new DateTime();
                DateTime checkout = new DateTime();
               
                if (ctdp != null)
                {
                    checkin = ctdp.CheckIn;
                    checkout = ctdp.CheckOut;
                    timeSpan = checkout.Subtract(checkin);
                }
              return timeSpan.Days;
        }
        // Nhận mã chi tiết đặt phòng và tính toán khoảng thời gian ở dưới dạng số giờ.
        public int getKhoangTGTheoGio(string MaCTDP)
        {
            CTDP ctdp;
            TimeSpan timeSpan = new TimeSpan();
            HotelDTO db = new HotelDTO();

            ctdp = db.CTDPs.Find(MaCTDP);

            DateTime checkin = new DateTime();
            DateTime checkout = new DateTime();

            if (ctdp != null)
            {
                checkin = ctdp.CheckIn;
                checkout = ctdp.CheckOut;
                timeSpan = checkout.Subtract(checkin);
            }
            return timeSpan.Hours;
        }
        // Tìm kiếm chi tiết đặt phòng dựa trên mã phòng và thời gian hiện tại.
        public CTDP FindCTDP(string MaPhong, DateTime currentTime)
        {
                HotelDTO db = new HotelDTO();
                CTDP ctdp;
                ctdp = db.CTDPs.Where(p => p.MaPH == MaPhong && ((p.CheckIn <= currentTime && currentTime <= p.CheckOut) || p.CheckIn == currentTime) && p.TrangThai != "Đã xong" && p.TrangThai != "Đã hủy").SingleOrDefault();            
                return ctdp;
            
        }
        // Trả về danh sách các chi tiết đặt phòng dựa trên thời gian nhận phòng (Checkin) và thời gian trả phòng (Checkout).
        public List<CTDP> getCTDPonTime(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
                
                List<CTDP> listCTDP;
                HotelDTO db = new HotelDTO();
                listCTDP= db.CTDPs.Where(p=>p.DaXoa==false).ToList();
                if (DSPhongThem != null)
                {
                    foreach (var ctdp in DSPhongThem)
                    {
                        listCTDP.Add(ctdp);
                    } 
                }
                var cTDPs = from p in listCTDP where (((Checkin >= p.CheckIn && Checkin <= p.CheckOut) || (p.CheckIn <= Checkout && Checkout <= p.CheckOut) || (Checkin <= p.CheckIn && Checkout >= p.CheckOut)) && (p.TrangThai!="Đã xong" &&  p.TrangThai!="Đã hủy") ) select p;

                List<CTDP> ctdpList = new List<CTDP>();
                foreach (var ctdp in cTDPs)
                {
                    ctdpList.Add(ctdp);
                }
                return ctdpList;
            
        }
        // Trả về mã chi tiết đặt phòng tiếp theo dựa trên các mã đã tồn tại trong cơ sở dữ liệu.
        public string getNextCTDP()
        {
                List<CTDP> cTDPs;
                HotelDTO db = new HotelDTO();      
                cTDPs = db.CTDPs.ToList();
                string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "CTDP00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();
           
        }
        // Cập nhật hoặc thêm mới một chi tiết đặt phòng vào cơ sở dữ liệu.
        public void UpdateOrAddCTDP(CTDP ctdp)
        {
            try
            {
                HotelDTO db = new HotelDTO();
                
                    ctdp.PhieuThue = db.PhieuThues.Find(ctdp.MaPT);
                    ctdp.Phong = db.Phongs.Find(ctdp.MaPH);
                    ctdp.DaXoa = false;
                    db.CTDPs.AddOrUpdate(ctdp);
                    db.SaveChanges();
                
                    instance = null;
                db.Dispose();

            }
            catch (Exception)
            {
               
            }
        }
        // Xóa một chi tiết đặt phòng khỏi cơ sở dữ liệu.
        public void RemoveCTDP(CTDP cTDP)
        {
            HotelDTO db = new HotelDTO();
                
                cTDP.DaXoa = true;
                db.CTDPs.AddOrUpdate(cTDP);
                db.SaveChanges();

        }
        // Trả về mã chi tiết đặt phòng tiếp theo dựa trên danh sách chi tiết đặt phòng đã được cung cấp.
        public string getNextCTDPwithList(List<CTDP> list)
        {
            List<CTDP> cTDPs;
            HotelDTO db = new HotelDTO();

            cTDPs = db.CTDPs.ToList();       
                if (list.Count > 0)
                {
                    foreach (var ctdp in list)
                    {
                        cTDPs.Add(ctdp);
                    }
                }
                string MaMax = cTDPs[cTDPs.Count - 1].MaCTDP.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 3, 3);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "CTDP00" + max.ToString();
                }
                else if (max < 100)
                {
                    return "CTDP0" + max.ToString();
                }
                return "CTDP" + max.ToString();      
        }

    }
}
