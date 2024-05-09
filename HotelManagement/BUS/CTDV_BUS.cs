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
    internal class CTDV_BUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng CTDV_BUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa.Nếu chưa, nó tạo một đối tượng mới của lớp CTDV_BUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng CTDV_BUS từ bên ngoài lớp.
        private static CTDV_BUS instance;
        public static CTDV_BUS Instance
        {
            get { if (instance == null) instance = new CTDV_BUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng CTDV_BUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng CTDV_BUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private CTDV_BUS() { }

        // Tìm các chi tiết dịch vụ dựa trên mã hóa đơn (MaHD).
        public List<CTDV> FindCTDV(string MaHD)
        {
            return CTDV_DAO.Instance.FindCTDV(MaHD);
        }
        // Chèn hoặc cập nhật một danh sách các chi tiết dịch vụ vào cơ sở dữ liệu.
        public void InsertOrUpdateList(List<CTDV> cTDVs)
        {
            CTDV_DAO.Instance.InsertOrUpdateList(cTDVs);
        }
    }
}
