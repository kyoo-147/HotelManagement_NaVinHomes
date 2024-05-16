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
    internal class PhieuThueBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng PhieuThueBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp PhieuThueBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng PhieuThueBUS từ bên ngoài lớp.
        private static PhieuThueBUS instance;
        public static PhieuThueBUS Instance
        {
            get { if (instance == null) instance = new PhieuThueBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng PhieuThueBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng PhieuThueBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private PhieuThueBUS() { }
        // Lấy danh sách tất cả các phiếu thuê từ cơ sở dữ liệu.
        public List<PhieuThue> GetPhieuThues()
        {
            return PhieuThueDAO.Instance.GetPhieuThues();
        }
        // Tìm một phiếu thuê dựa trên mã phiếu thuê.
        public PhieuThue GetPhieuThue(string MaPT)
        {
            return PhieuThueDAO.Instance.GetPhieuThue(MaPT);
        }
        // Thêm hoặc cập nhật một phiếu thuê vào cơ sở dữ liệu.
        public void AddOrUpdatePhieuThue(PhieuThue phieuThue)
        {
            PhieuThueDAO.Instance.UpdatePhieuThue(phieuThue);
        }
        // Tìm các phiếu thuê dựa trên tên khách hàng.
        public List<PhieuThue> GetPhieuThuesWithNameCus(string name)
        {
            return PhieuThueDAO.Instance.GetPhieuThuesWithNameCus(name);
        }
        // Lấy mã phiếu thuê tiếp theo từ cơ sở dữ liệu.
        public string GetMaPTNext()
        {
            return PhieuThueDAO.Instance.GetMaPTNext();
        }
    }
}
