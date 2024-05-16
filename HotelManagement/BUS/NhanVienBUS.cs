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
    internal class NhanVienBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng NhanVienBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp NhanVienBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng NhanVienBUS từ bên ngoài lớp.
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get { if (instance == null) instance = new NhanVienBUS(); return instance; }
            private set { instance = value; }
        }        
        // Lấy danh sách tất cả các nhân viên từ cơ sở dữ liệu.
        public List<NhanVien> GetAllNhanViens()
        {
            return NhanVienDAO.Instance.GetAllNhanViens();
        }
        // // Constructor này là private, ngăn việc tạo đối tượng NhanVienBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng NhanVienBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private NhanVienBUS() { }
        // Lấy danh sách nhân viên từ cơ sở dữ liệu.
        public List<NhanVien> GetNhanViens()
        {
            return NhanVienDAO.Instance.GetNhanViens();
        }
        // Tìm một nhân viên dựa trên mã nhân viên
        public NhanVien GetNhanVien(string MaNV)
        {
            return NhanVienDAO.Instance.GetNhanVien(MaNV);
        }
        // Cập nhật hoặc chèn một nhân viên vào cơ sở dữ liệu.
        public void UpdateOrInsert(NhanVien nhanVien)
        {
            NhanVienDAO.Instance.UpdateOrInsert(nhanVien);
        }
        // Xóa một nhân viên khỏi cơ sở dữ liệu.
        public void RemoveNhanVien(NhanVien nhanVien)
        {
            NhanVienDAO.Instance.RemoveNhanVien(nhanVien);
        }
        // Tìm các nhân viên dựa trên tên nhân viên.
        public List<NhanVien> GetNhanViensWithName(string tenNV)
        {
            return NhanVienDAO.Instance.GetNhanViensWithName(tenNV);
        }
        // Lấy mã nhân viên tiếp theo từ cơ sở dữ liệu.
        public string GetMaNVNext()
        {
            return NhanVienDAO.Instance.GetMaNVNext();
        }
    }
}
