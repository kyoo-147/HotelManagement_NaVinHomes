using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace ApplicationSettings
{
    internal class WinAPI
    {
        // hằng số được sử dụng để chỉ định hướng và kiểu hiển thị của hiệu ứng khi sử dụng hàm AnimateWindow
        // Đây là các giá trị được sử dụng để điều chỉnh cách cửa sổ xuất hiện hoặc biến mất trên màn hình
        public const int HOR_Positive = 0x1;

        public const int HOR_Negative = 0x2;

        public const int VER_Positive = 0x4;

        public const int VER_Negative = 0x8;

        public const int CENTER = 0x10;

        public const int BLEND = 0x8000;

        // Directive này đánh dấu một phương thức được gọi từ một thư viện động ngoài, trong trường hợp này là user32.dll, chứa các hàm API của Windows liên quan đến giao diện người dùng.
        // CharSet = CharSet.Auto chỉ định kiểu ký tự mà một chuỗi nên được chuyển thành khi truyền vào hoặc nhận từ hàm API, có thể là ANSI hoặc Unicode tùy thuộc vào cài đặt của hệ thống.
        [DllImport("user32.dll", CharSet = CharSet.Auto)]

        // Phương thức này được sử dụng để tạo ra các hiệu ứng hoạt hình khi hiển thị hoặc ẩn cửa sổ trên màn hình.
        // hwand: Tham số này là một con trỏ tới cửa sổ mục tiêu.
        // dwTime: Thời gian thực hiện hiệu ứng, tính bằng mili giây.
        // dwFlags: Các cờ chỉ định kiểu hiển thị và hành động của hiệu ứng, có thể là một hoặc nhiều giá trị từ các hằng số đã được định nghĩa trước đó.
        public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);
    }
}
