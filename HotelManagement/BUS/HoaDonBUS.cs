using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;
using HotelManagement.DTO;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.BUS
{
    internal class HoaDonBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng HoaDonBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp HoaDonBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng HoaDonBUS từ bên ngoài lớp.
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get { if (instance == null) instance = new HoaDonBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng HoaDonBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng HoaDonBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private HoaDonBUS() { }
        // Lấy danh sách tất cả các hóa đơn từ cơ sở dữ liệu.
        public List<HoaDon> GetHoaDons()
        {
            return HoaDonDAO.Instance.GetHoaDons();
        }
        // Tìm một hóa đơn dựa trên mã hóa đơn.
        public HoaDon FindHD(string MaHD)
        {
            return HoaDonDAO.Instance.FindHD(MaHD);
        }
        // Cập nhật hoặc chèn một hóa đơn vào cơ sở dữ liệu.
        public void Update_Inserthd(HoaDon HD)
        {
            HoaDonDAO.Instance.Update_InsertHD(HD);
        }
        // Tìm các hóa đơn dựa trên số CMND/Căn cước công dân của khách hàng.
        public List<HoaDon> FindHoaDonWith_CCCD(string cccd)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_CCCD(cccd);
        }
        // Tìm các hóa đơn dựa trên ngày và số CMND/Căn cước công dân của khách hàng.
        public List<HoaDon> FindHoaDonWith_DateAndCCCD(DateTime dateTime, string cccd)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_DateAndCCCD(dateTime, cccd);
        }
        // Lấy mã hóa đơn tiếp theo từ cơ sở dữ liệu.
        public string getMaHDNext()
        {
            return HoaDonDAO.Instance.getMaHDNext();
        }
        // Thực hiện thanh toán cho một hóa đơn.
        public void ThanhToanHD(HoaDon HD)
        {
            HoaDonDAO.Instance.ThanhToanHD(HD);
        }
        // Xóa một hóa đơn khỏi cơ sở dữ liệu
        public void RemoveHD(HoaDon hd)
        {
            HoaDonDAO.Instance.RemoveHD(hd);
        }
        // Tìm các hóa đơn dựa trên ngày tạo hóa đơn.
        public List<HoaDon> FindHoaDonWith_Date(DateTime dateTime)
        {
            return HoaDonDAO.Instance.FindHoaDonWith_Date(dateTime);
        }
    }
}
