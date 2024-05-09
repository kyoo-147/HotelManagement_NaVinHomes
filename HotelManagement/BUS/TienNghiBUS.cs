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
    internal class TienNghiBUS
    {
        // Đây là một thuộc tính kiểu Singleton, giúp chỉ có một đối tượng TienNghiBUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa. Nếu chưa, nó tạo một đối tượng mới của lớp TienNghiBUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng TienNghiBUS từ bên ngoài lớp.
        private static TienNghiBUS instance;
        public static TienNghiBUS Instance
        {
            get { if (instance == null) instance = new TienNghiBUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng TienNghiBUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng TienNghiBUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private TienNghiBUS() { }
        // Lấy danh sách tất cả các tiện nghi từ cơ sở dữ liệu.
        public List<TienNghi> GetTienNghis()
        {
            return TienNghiDAO.Instance.GetTienNghis();
        }
        // Tìm một tiện nghi dựa trên mã tiện nghi.
        public TienNghi FindTienNghi(string MaTN)
        {
            return TienNghiDAO.Instance.FindTienNghi(MaTN);
        }
        // Xóa một tiện nghi khỏi cơ sở dữ liệu.
        public void RemoveTN(TienNghi tienNghi) // try catch th có phòng có mã tiện nghi đó
        {
            TienNghiDAO.Instance.RemoveTN(tienNghi);
        }
        // Thêm hoặc cập nhật một tiện nghi vào cơ sở dữ liệu.
        public void InsertOrUpdate(TienNghi tienNghi)
        {
            TienNghiDAO.Instance.InsertOrUpdate(tienNghi);
        }
        // Tìm các tiện nghi dựa trên tên tiện nghi.
        public List<TienNghi> FindTienNghiWithName(string name)
        {
            return TienNghiDAO.Instance.FindTienNghiWithName(name);
        }
        // Lấy mã tiện nghi tiếp theo từ cơ sở dữ liệu.
        public string GetMaTNNext()
        {
            return TienNghiDAO.Instance.GetMaTNNext();
        }    
    }
}
