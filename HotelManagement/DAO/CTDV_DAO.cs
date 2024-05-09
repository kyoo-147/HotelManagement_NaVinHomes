using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.DAO
{
    internal class CTDV_DAO
    {
        // instance: Biến static của lớp, đại diện cho một phiên bản duy nhất của lớp CTDV_DAO.
        // Instance: Thuộc tính static dùng để truy cập đến phiên bản duy nhất của lớp CTDV_DAO.Sử dụng mẫu Singleton để đảm bảo chỉ có một đối tượng được tạo ra trong suốt vòng đời của ứng dụng.
                HotelDTO db = new HotelDTO();
        private static CTDV_DAO instance;
        public static CTDV_DAO Instance
        {
            get { if (instance == null) instance = new CTDV_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTDV_DAO() { }
        // Truy xuất và trả về tất cả các chi tiết dịch vụ dựa trên mã chi tiết đặt phòng.
        public List<CTDV> FindCTDV(string MaCTDP)
        {

                return db.CTDVs.Where(p => p.MaCTDP == MaCTDP && p.DaXoa == false).ToList();           
        }
        // Thêm mới hoặc cập nhật danh sách các chi tiết dịch vụ.
        // Duyệt qua từng phần tử trong danh sách và kiểm tra số lượng dịch vụ.Nếu số lượng khác 0, thực hiện cập nhật hoặc thêm mới dịch vụ vào cơ sở dữ liệu.
        // Nếu số lượng dịch vụ bằng 0 và tồn tại một chi tiết dịch vụ tương tự trong cơ sở dữ liệu, xóa chi tiết dịch vụ đó khỏi cơ sở dữ liệu.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void InsertOrUpdateList(List<CTDV> cTDVs)
        {
        HotelDTO db = new HotelDTO();

            foreach (CTDV cTDV in cTDVs)
                {
                    if (cTDV.SL != 0)
                    {
                        db.CTDVs.AddOrUpdate(cTDV);
                        CTDV cTDV1 = db.CTDVs.Where(p => p.DonGia == cTDV.DonGia && p.MaDV == cTDV.MaDV && p.MaCTDP == cTDV.MaCTDP).SingleOrDefault();
                        if (cTDV.SL == 0 && cTDV1 != null)
                        {
                        
                            //CTDV ctdv = db.CTDVs.Where(p => p.MaDV == cTDV.MaDV && p.DonGia == cTDV.DonGia && p.MaHD == cTDV.MaHD).SingleOrDefault();
                            db.CTDVs.Remove(cTDV1);
                        }
                            db.SaveChanges();
                    }
                }
            db.Dispose();
            instance = null;
        }    

    }
}
