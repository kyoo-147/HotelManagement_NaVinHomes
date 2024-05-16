using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DTO;
using HotelManagement.DAO;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.BUS
{
    internal class PhongBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng PhongBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp PhongBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng PhongBUS từ bên ngoài lớp.
        private static PhongBUS instance;
        public static PhongBUS Instance
        {
            get { if (instance == null) instance = new PhongBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng PhongBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng PhongBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private PhongBUS() { }
        // Lấy danh sách tất cả các phòng từ cơ sở dữ liệu.
        public List<Phong> GetAllPhong()
        {
            return PhongDAO.Instance.GetAllPhongs();
        }
        // Tìm một phòng dựa trên mã phòng.
        public Phong FindePhong(string MaPh)
        {
            return PhongDAO.Instance.FindPhong(MaPh);
        }
        // Tìm các phòng dựa trên mã phòng.
        public List<Phong> FindPhongWithMaPH(string MaPh)
        {
            return PhongDAO.Instance.FindPhongWithMaPH(MaPh);
        }
        // Cập nhật hoặc thêm một phòng vào cơ sở dữ liệu.
        public void UpdateOrAdd(Phong phong)
        {
            PhongDAO.Instance.UpdateOrAdd(phong);
        }
        //Tìm các phòng trống trong một khoảng thời gian cụ thể.
        public List<Phong> FindPhongTrong(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
            return PhongDAO.Instance.FindPhongTrong(Checkin, Checkout, DSPhongThem);   
        }
        // Xóa một phòng khỏi cơ sở dữ liệu.
        public void RemovePhong(string maPH)
        {
            PhongDAO.Instance.RemovePhong(maPH);
        }
    }
}
