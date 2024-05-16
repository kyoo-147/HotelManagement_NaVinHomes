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
    internal class DichVuDAO
    {
        // instance: Biến static của lớp, đại diện cho một phiên bản duy nhất của lớp DichVuDAO.
        //Instance: Thuộc tính static dùng để truy cập đến phiên bản duy nhất của lớp DichVuDAO.Sử dụng mẫu Singleton để đảm bảo chỉ có một đối tượng được tạo ra trong suốt vòng đời của ứng dụng.
        HotelDTO db = new HotelDTO();
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }
        private DichVuDAO() { }
        // Tìm và trả về dịch vụ dựa trên mã dịch vụ.
        public List<DichVu> GetDichVus()
        {
            instance = null;
                return db.DichVus.Where(p => p.DaXoa == false).ToList();
            
        }
        // Tìm và trả về dịch vụ dựa trên mã dịch vụ.
        public DichVu FindDichVu(string MaDV)
        {
            using (HotelDTO hotelDTO = new HotelDTO())
            {
                return hotelDTO.DichVus.Find(MaDV);
            }
            
        }
        // Cập nhật hoặc thêm mới một dịch vụ vào cơ sở dữ liệu.
        // Đầu tiên, kiểm tra xem dịch vụ đã tồn tại trong cơ sở dữ liệu chưa.Nếu chưa, thêm mới vào.
        // Nếu đã tồn tại, cập nhật thông tin của dịch vụ.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void UpdateORAdd(DichVu dv)
        {

            try
            {
                dv.DaXoa = false;
                db.DichVus.AddOrUpdate(dv);
                db.SaveChanges();
                instance = null;
            }
            catch(Exception )
            {
                db.DichVus.Remove(dv);
            }

        }
        // Đánh dấu một dịch vụ là đã bị xóa bằng cách thiết lập trạng thái DaXoa là true.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void RemoveDV(DichVu dv)
        {
            try
            {
                dv.DaXoa = true;
                db.DichVus.AddOrUpdate(dv);
                db.SaveChanges();
                instance = null;
            }
            catch (Exception)
            {
                db.DichVus.Remove(dv);
            }

        }
        // Tạo và trả về mã dịch vụ tiếp theo trong chuỗi.
        public string GetMaDVNext()
        {

                List<DichVu> DV = db.DichVus.ToList();
                string MaMax = DV[DV.Count - 1].MaDV.ToString();
                MaMax = MaMax.Substring(MaMax.Length - 2, 2);
                int max = int.Parse(MaMax);
                max++;
                if (max < 10)
                {
                    return "DV0" + max.ToString();
                }
                return "DV" + max.ToString();
            
        }
        // Tìm và trả về danh sách các dịch vụ dựa trên tên dịch vụ.
        public List<DichVu> FindDichVuWithName(string TenDV)
        {

                return db.DichVus.Where(p => p.TenDV.Contains(TenDV) && p.DaXoa == false).ToList();
            
        }
        // Truy xuất và trả về tất cả các dịch vụ còn lại (không bị hết hàng) từ cơ sở dữ liệu.
        public List<DichVu> GetDichVusConLai()
        {
            return db.DichVus.Where(p => p.DaXoa == false && p.SLConLai != 0).ToList();
        }
        // Tìm và trả về một dịch vụ dựa trên tên và đơn giá.
        public DichVu FindDichVuWithNameAndDonGia(string TenDV, string DonGia)
        {
            decimal dongia = decimal.Parse(DonGia);
            return db.DichVus.Where(p => p.TenDV == TenDV && p.DonGia == dongia ).SingleOrDefault();
        }

        // Cập nhật thông tin của một danh sách các dịch vụ vào cơ sở dữ liệu.
        // Lưu thay đổi vào cơ sở dữ liệu và giải phóng tài nguyên sau khi hoàn thành.
        public void UpdateDV(List<DichVu> dichVus)
        {
            try
            {
                foreach (DichVu dichVu in dichVus)
                {
                    //     if(dichVu.SLConLai!=-1)
                    db.DichVus.AddOrUpdate(dichVu);
                }
                db.SaveChanges();
                instance = null;
            }
            catch (Exception)
            {
                foreach (DichVu dichVu in dichVus)
                {
                    db.DichVus.Remove(dichVu);
                }
            }

        }
    }
}
