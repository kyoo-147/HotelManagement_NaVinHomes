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
    internal class CTDP_BUS
    {
        // Đây là một thuộc tính kiểu Singleton, cho phép chỉ có một đối tượng CTDP_BUS duy nhất trong ứng dụng.
        // Phương thức get kiểm tra xem instance đã được khởi tạo chưa.Nếu chưa, nó tạo một đối tượng mới của lớp CTDP_BUS.
        // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng CTDP_BUS từ bên ngoài lớp.
        private static CTDP_BUS instance;
        public static CTDP_BUS Instance
        {
            get { if (instance == null) instance = new CTDP_BUS(); return instance; }
            private set { instance = value; }
        }
        // Constructor này là private, ngăn việc tạo đối tượng CTDP_BUS từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng CTDP_BUS chỉ có thể được tạo thông qua thuộc tính Instance.
        private CTDP_BUS() { }

        // Lấy tất cả CTDP
        public List<CTDP> GetCTDPs() 
        {
            return CTDP_DAO.Instance.GetCTDPs();
        }

        // Lấy thời gian ở của khách hàng tại 1 phòng nào đó
        public int getKhoangTGTheoNgay(string MaCTDP) 
        {
            return CTDP_DAO.Instance.getKhoangTGTheoNgay(MaCTDP);
        }

        // Lấy thời gian ở của khách hàng tại 1 phòng nào đó
        public int getKhoangTGTheoGio(string MaCTDP) 
        {
            return CTDP_DAO.Instance.getKhoangTGTheoGio(MaCTDP);
        }

        // Tìm một chi tiết đặt phòng dựa trên mã phòng và thời gian hiện tại.
        public CTDP FindCTDP(string MaPhong, DateTime currentTime) // Tìm Mã phòng theo 
        {
            return CTDP_DAO.Instance.FindCTDP(MaPhong, currentTime);
        }

        // Lấy danh sách các chi tiết đặt phòng dựa trên thời gian nhận phòng và trả phòng, cũng như danh sách các chi tiết đặt phòng bổ sung.
        public List<CTDP> getCTDPonTime(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
            return CTDP_DAO.Instance.getCTDPonTime(Checkin, Checkout, DSPhongThem);
        }

        // Lấy mã chi tiết đặt phòng tiếp theo.
        public string getNextCTDP()
        {
            return CTDP_DAO.Instance.getNextCTDP();
        }

        // Cập nhật hoặc thêm một chi tiết đặt phòng vào cơ sở dữ liệu.
        public void UpdateOrAddCTDP(CTDP ctdp)
        {
            CTDP_DAO.Instance.UpdateOrAddCTDP(ctdp);
        }

        //  Lấy mã chi tiết đặt phòng tiếp theo dựa trên một danh sách đã cho.
        public string getNextCTDPwithList(List<CTDP> list)
        {
            return CTDP_DAO.Instance.getNextCTDPwithList(list);
        }

        // Xóa một chi tiết đặt phòng khỏi cơ sở dữ liệu.
        public void RemoveCTDP(CTDP cTDP)
        {
            CTDP_DAO.Instance.RemoveCTDP(cTDP);
        }    
    }
}
