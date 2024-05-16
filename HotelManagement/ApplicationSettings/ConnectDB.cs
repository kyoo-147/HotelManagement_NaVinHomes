using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.ApplicationSettings
{
    // Constructor
    internal class ConnectDB
    {
        // Khoi tao doi tuong config bang cach su dung
        Configuration config;

        public ConnectDB()
        {
            // mở cấu hình của ứng dụng
            // app.config hoặc web.config
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        // su dung lay chuoi ket noi tu tu cai dat
        public string getConnectionString(string key)
        {
            // tra ve chuoi ket noi tuong ung voi key do
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public void saveConnectionString(string key, string value)
        {
            // luu chuoi ket noi vao cai dat
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified, true);
            // lam moi phan cai dat cac ket noi, de ung dung co the su dung ngay cac thay doi
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public void ReloadFileConfig(string key, string value)
        {
            // lam moi cau hinh tu file config
            // Nó thay đổi cấu hình trong file cấu hình và
            // sau đó làm mới các phần cài đặt kết nối để ứng dụng sử dụng ngay các thay đổi.
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}

//Tổng quan, lớp ConnectDB này cung cấp các phương thức để lấy, lưu trữ và làm mới các cài đặt kết nối đến cơ sở dữ liệu, 
//giúp ứng dụng quản lý khách sạn có thể kết nối và làm việc với cơ sở dữ liệu một cách linh hoạt và dễ dàng.
