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
    internal class TaiKhoanBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng TaiKhoanBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp TaiKhoanBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng TaiKhoanBUS từ bên ngoài lớp.
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get { if (instance == null) instance = new TaiKhoanBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng TaiKhoanBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng TaiKhoanBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private TaiKhoanBUS() { }
        // Kiểm tra tính hợp lệ của thông tin đăng nhập.
        public bool checkLogin(string username, string password)
        {
            return TaiKhoanDAO.Instance.CheckLogin(username, password);
        }
        // Lấy quyền truy cập của một tài khoản dựa trên tên đăng nhập.
        public int getQuyenTruyCap(string username)
        {
            return TaiKhoanDAO.Instance.GetQuyenTruyCap(username);
        }
        // Lấy danh sách tất cả các tài khoản từ cơ sở dữ liệu.
        public List<TaiKhoan> GetTaiKhoans()
        {
            return TaiKhoanDAO.Instance.GetTaiKhoans();
        }
        // Lấy danh sách các tài khoản dựa trên tên đăng nhập. 
        public List<TaiKhoan> GetTaiKhoansWithUserName(string username)
        {
            return TaiKhoanDAO.Instance.GetTaiKhoansWithUserName(username);
        }
        // Kiểm tra tính hợp lệ của tên đăng nhập và địa chỉ email.
        public TaiKhoan CheckLegit(string username, string email)
        {
            return TaiKhoanDAO.Instance.CheckLegit(username, email);
        }
        // Thêm hoặc cập nhật một tài khoản vào cơ sở dữ liệu.
        public void AddOrUpdateTK(TaiKhoan taiKhoan)
        {
            TaiKhoanDAO.Instance.AddOrUpdateTK(taiKhoan);
        }
        // Xóa một tài khoản khỏi cơ sở dữ liệu.
        public void RemoveTk(TaiKhoan taiKhoan)
        {
            TaiKhoanDAO.Instance.RemoveTk(taiKhoan);
        }
        // Lấy thông tin về tài khoản đang đăng nhập dựa trên tên đăng nhập.
        public TaiKhoan GetTKDangNhap(string username)
        {
            return TaiKhoanDAO.Instance.GetTKDangNhap(username);
        }
    }
}
