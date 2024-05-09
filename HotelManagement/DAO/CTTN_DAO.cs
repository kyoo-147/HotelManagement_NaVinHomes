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
    internal class CTTN_DAO
    {
        // instance: Biến static của lớp, đại diện cho một phiên bản duy nhất của lớp CTTN_DAO.
        // Instance: Thuộc tính static dùng để truy cập đến phiên bản duy nhất của lớp CTTN_DAO.Sử dụng mẫu Singleton để đảm bảo chỉ có một đối tượng được tạo ra trong suốt vòng đời của ứng dụng.
                HotelDTO db = new HotelDTO();
        private static CTTN_DAO instance;
        public static CTTN_DAO Instance
        {
            get { if (instance == null) instance = new CTTN_DAO(); return instance; }
            private set { instance = value; }
        }
        private CTTN_DAO() { }
        // Truy xuất và trả về tất cả các chi tiết tiện nghi không bị đánh dấu xóa từ cơ sở dữ liệu.
        public List<CTTN> GetCTTNs()
        {

                return db.CTTNs.Where(p => p.DaXoa == false).ToList();
            
        }
        // Cập nhật hoặc chèn mới một chi tiết tiện nghi vào cơ sở dữ liệu.
        // Đầu tiên, kiểm tra xem chi tiết tiện nghi đã tồn tại trong cơ sở dữ liệu chưa.Nếu chưa, thêm mới vào.
        // Nếu đã tồn tại, cập nhật thông tin của chi tiết tiện nghi.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void UpdateOrInsert(CTTN cTTN)
        {
            try
            {
                cTTN.DaXoa = false;
                cTTN.TienNghi = db.TienNghis.Find(cTTN.MaTN);
                
                db.CTTNs.AddOrUpdate(cTTN);
                db.SaveChanges();
                instance = null;
            }
            catch(Exception)
            {
                db.CTTNs.Remove(cTTN);
            }
        }
        // Đánh dấu một chi tiết tiện nghi là đã bị xóa bằng cách thiết lập trạng thái DaXoa là true.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void RemoveCTTN(CTTN cTTN)
        {
            try
            {

                cTTN.DaXoa = true;
                db.CTTNs.AddOrUpdate(cTTN);
                db.SaveChanges();
                instance = null;
            }
            catch (Exception)
            {
                db.CTTNs.Remove(cTTN);
            }

        }
        // Truy xuất và trả về tất cả các chi tiết tiện nghi dựa trên mã loại phòng, mà không bị đánh dấu xóa từ cơ sở dữ liệu.
        public List<CTTN> FindCTTN(string MaLPH)
        {

                return db.CTTNs.Where(p => p.MaLPH == MaLPH && p.DaXoa == false).ToList();
        }

    }
}
// Lớp này cung cấp các phương thức cơ bản để thực hiện các thao tác CRUD (Create, Read, Update, Delete) trên dữ liệu của các chi tiết tiện nghi trong cơ sở dữ liệu