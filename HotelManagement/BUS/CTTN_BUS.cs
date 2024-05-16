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
    internal class CTTN_BUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng CTTN_BUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa.Nếu chưa, nó tạo một đối tượng mới của lớp CTTN_BUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng CTTN_BUS từ bên ngoài lớp.
        private static CTTN_BUS instance;
        public static CTTN_BUS Instance
        {
            get { if (instance == null) instance = new CTTN_BUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng CTTN_BUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng CTTN_BUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private CTTN_BUS() { }
        // Lấy danh sách tất cả các chi tiết thuê ngắn hạn từ cơ sở dữ liệu.
        public List<CTTN> GetCTTNs()
        {
            return CTTN_DAO.Instance.GetCTTNs();
        }
        // Cập nhật hoặc chèn một chi tiết thuê ngắn hạn vào cơ sở dữ liệu.
        public void UpdateOrInsert(CTTN cTTN)
        {
            CTTN_DAO.Instance.UpdateOrInsert(cTTN);
        }
        // Xóa một chi tiết thuê ngắn hạn khỏi cơ sở dữ liệu.
        public void RemoveCTTN(CTTN cTTN)
        {
            CTTN_DAO.Instance.RemoveCTTN(cTTN);
        }
        // Tìm các chi tiết thuê ngắn hạn dựa trên mã loại phòng hạng.
        public List<CTTN> FindCTTN(string MaLPH)
        {
            return CTTN_DAO.Instance.FindCTTN(MaLPH);
        }
    }
}
