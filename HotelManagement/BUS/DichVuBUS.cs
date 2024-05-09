using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.BUS
{
    internal class DichVuBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng DichVuBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa.Nếu chưa, nó tạo một đối tượng mới của lớp DichVuBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng DichVuBUS từ bên ngoài lớp.
        private static DichVuBUS instance;
        public static DichVuBUS Instance
        {
            get { if (instance == null) instance = new DichVuBUS(); return instance; }
            private set { instance = value; }
        }

        // Constructor này là private, ngăn việc tạo đối tượng DichVuBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng DichVuBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private DichVuBUS() { }

        // Lấy danh sách tất cả các dịch vụ từ cơ sở dữ liệu.
        public List<DichVu> GetDichVus()
        {
            return DichVuDAO.Instance.GetDichVus();
        }

        // Tìm một dịch vụ dựa trên mã dịch vụ.
        public DichVu FindDichVu(string MaDV)
        {
            return DichVuDAO.Instance.FindDichVu(MaDV);     
        }

        // Cập nhật hoặc chèn một dịch vụ vào cơ sở dữ liệu.
        public void UpdateORAdd(DichVu dv)
        {
            DichVuDAO.Instance.UpdateORAdd(dv);
        }

        // Xóa một dịch vụ khỏi cơ sở dữ liệu.
        public void RemoveDV(DichVu dv)
        { 
            DichVuDAO.Instance.RemoveDV(dv);
        }

        // Lấy mã dịch vụ tiếp theo từ cơ sở dữ liệu.
        public string GetMaDVNext()
        {
           return DichVuDAO.Instance.GetMaDVNext();
        }

        // Tìm các dịch vụ dựa trên tên dịch vụ.
        public List<DichVu> FindDichVuWithName(string TenDV)
        {
            return DichVuDAO.Instance.FindDichVuWithName(TenDV);
        }

        // Lấy danh sách các dịch vụ còn lại (chưa được sử dụng)
        public List<DichVu> GetDichVusConLai()
        {
            return DichVuDAO.Instance.GetDichVusConLai();
        }

        //  Tìm một dịch vụ dựa trên tên dịch vụ và đơn giá.
        public DichVu FindDichVuWithNameAndDonGia(string TenDV, string DonGia)
        {
            return DichVuDAO.Instance.FindDichVuWithNameAndDonGia(TenDV, DonGia);
        }

        // Cập nhật danh sách các dịch vụ vào cơ sở dữ liệu.
        public void UpdateDV(List<DichVu> dichVus)
        {
            DichVuDAO.Instance.UpdateDV(dichVus);
        }    
    }
}
