using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.ApplicationSettings
{
    public class SqlHelper
    {
        SqlConnection cn;
        // Nó nhận một tham số là connectionString, là chuỗi kết nối đến cơ sở dữ liệu SQL
        public SqlHelper(string connectionString)
        {
            // một kết nối mới SqlConnection được khởi tạo với chuỗi kết nối được cung cấp.
            cn = new SqlConnection(connectionString);
        }

        // thuộc tính chỉ đọc, được sử dụng để kiểm tra trạng thái của kết nối.
        public bool isConnected
        {
            // Nếu trạng thái của kết nối là Closed, nó sẽ mở kết nối bằng cách gọi cn.Open().
            // nó trả về true, chỉ ra rằng kết nối hiện đang được mở
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
            }
        }
    }
}

// lớp SqlHelper này được thiết kế để hỗ trợ việc kết nối đến cơ sở dữ liệu SQL và kiểm tra trạng thái của kết nối.
// Bằng cách sử dụng constructor để cung cấp chuỗi kết nối và thuộc tính isConnected để kiểm tra và mở kết nối khi cần thiết,
// lớp này có thể giúp quản lý việc kết nối đến cơ sở dữ liệu một cách dễ dàng và hiệu quả.