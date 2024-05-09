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
    internal class LoaiPhongBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng LoaiPhongBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp LoaiPhongBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng LoaiPhongBUS từ bên ngoài lớp.
        private static LoaiPhongBUS instance;
        public static LoaiPhongBUS Instance
        {
            get { if (instance == null) instance = new LoaiPhongBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng LoaiPhongBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng LoaiPhongBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private LoaiPhongBUS() { }
        // Lấy danh sách tất cả các loại phòng từ cơ sở dữ liệu.
        public List<LoaiPhong> GetLoaiPhongs()
        {
            return LoaiPhongDAO.Instance.GetLoaiPhongs();
        }
        // Tìm một loại phòng dựa trên mã loại phòng.
        public LoaiPhong getLoaiPhong(string MaLP)
        {
            return LoaiPhongDAO.Instance.getLoaiPhong(MaLP);
        }
        // Thêm hoặc cập nhật một loại phòng vào cơ sở dữ liệu.
        public void AddOrUpdate(LoaiPhong loaiPhong)
        {
            LoaiPhongDAO.Instance.AddOrUpdate(loaiPhong);
        }
        // Xóa một loại phòng khỏi cơ sở dữ liệu.
        public void RemoveLoaiPhong(LoaiPhong loaiPhong)
        {
            LoaiPhongDAO.Instance.RemoveLoaiPhong(loaiPhong);
        }
        // Tìm các loại phòng dựa trên tên loại phòng.
        public List<LoaiPhong> getLoaiPhongWithName(string TenLP)
        {
            return LoaiPhongDAO.Instance.getLoaiPhongWithName(TenLP);
        }
    }
}
