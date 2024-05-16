using HotelManagement.DAO;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.BUS
{
    internal class KhachHangBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng KhachHangBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp KhachHangBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng KhachHangBUS từ bên ngoài lớp.
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng KhachHangBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng KhachHangBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private KhachHangBUS() { }
        // Lấy danh sách tất cả các khách hàng từ cơ sở dữ liệ
        public List<KhachHang> GetKhachHangs()
        {
            return KhachHangDAO.Instance.GetKhachHangs();
        }
        // Tìm một khách hàng dựa trên mã khách hàng.
        public KhachHang FindKhachHang(string MaKH)
        {
            return KhachHangDAO.Instance.FindKhachHang(MaKH);
        }
        // Cập nhật hoặc chèn một khách hàng vào cơ sở dữ liệu.
        public void UpdateOrAdd(KhachHang khachHang)
        {
            KhachHangDAO.Instance.UpdateOrAdd(khachHang);
        }
        // Xóa một khách hàng khỏi cơ sở dữ liệu.
        public void RemoveKH(KhachHang khachHang)
        {
            KhachHangDAO.Instance.RemoveKH(khachHang);
        }
        // Tìm các khách hàng dựa trên tên khách hàng.
        public List<KhachHang> FindKhachHangWithName(string TenKH)
        {
            return KhachHangDAO.Instance.FindKhachHangWithName(TenKH);
        }
        // Lấy mã khách hàng tiếp theo từ cơ sở dữ liệu.
        public string GetMaKHNext()
        {
            return KhachHangDAO.Instance.GetMaKHNext();
        }
        // Tìm một khách hàng dựa trên số CMND/Căn cước công dân.
        public KhachHang FindKHWithCCCD(string cccd)
        {
            return KhachHangDAO.Instance.FindKHWithCCCD(cccd);
        }
    }
}
