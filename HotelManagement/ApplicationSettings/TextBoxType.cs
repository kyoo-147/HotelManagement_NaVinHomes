using HotelManagement.BUS;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace ApplicationSettings
{
    // Thuộc tính Instance:
    // Đây là một thuộc tính kiểu Singleton, cho phép chỉ có một đối tượng TextBoxType duy nhất trong ứng dụng.
    // Phương thức get kiểm tra xem instance đã được khởi tạo chưa.Nếu chưa, nó tạo một đối tượng mới của lớp TextBoxType.
    // Phương thức set được định nghĩa là private để ngăn việc gán đối tượng TextBoxType từ bên ngoài lớp.
    public class TextBoxType
    {
        private static TextBoxType instance;
        public static TextBoxType Instance
        {
            get { if (instance == null) instance = new TextBoxType(); return instance; }
            private set { instance = value; }
        }

        // Constructor này là private, ngăn việc tạo đối tượng TextBoxType từ bên ngoài lớp.
        // Điều này đảm bảo rằng đối tượng TextBoxType chỉ có thể được tạo thông qua thuộc tính Instance.
        private TextBoxType() { }

        // Phương thức này được sử dụng để chỉ cho phép nhập số vào TextBox.
        // Nếu ký tự không phải là số hoặc ký tự điều khiển(ví dụ: Backspace), thì e.Handled sẽ được thiết lập thành true, ngăn việc nhập ký tự đó.
        public void TextBoxOnlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Phương thức này được sử dụng để chỉ cho phép nhập ký tự không phải số vào TextBox.
        // Nếu ký tự không phải là chữ cái, ký tự điều khiển hoặc khoảng trắng, thì e.Handled sẽ được thiết lập thành true, ngăn việc nhập ký tự đó.
        public void TextBoxNotNumber(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Phương thức này được sử dụng để định dạng TextBox dưới dạng tiền tệ.
        // Khi TextBox được chọn và không rỗng, nó sẽ thực hiện định dạng số trong TextBox thành định dạng tiền tệ(sử dụng dấu phân cách hàng nghìn).
        // Nếu có lỗi xảy ra trong quá trình chuyển đổi, một hộp thoại thông báo lỗi sẽ hiển thị.
        // Cuối cùng, nó sẽ đặt vị trí con trỏ về cuối TextBox để giữ cho người dùng nhìn thấy dữ liệu được định dạng một cách rõ ràng.
        public void CurrencyType(object sender, EventArgs e)
        {
            TextBox textBox1 = sender as TextBox;
            if (textBox1.Focused == true)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    System.Globalization.NumberFormatInfo nfi = new System.Globalization.NumberFormatInfo();
                    nfi.NumberGroupSeparator = ",";
                    double nValue = 0;
                    bool bError = false;
                    try
                    {
                        nValue = double.Parse(textBox1.Text, System.Globalization.NumberStyles.AllowThousands, nfi);
                    }
                    catch (System.Exception se)
                    {
                        bError = true;
                        System.Windows.Forms.MessageBox.Show("Error : " + se.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        //if (!bError)
                        {
                            textBox1.Text = string.Format(nfi, "{0:N0}", nValue);
                            textBox1.Select(textBox1.Text.Length, 0);
                        }
                    }
                }
            }
        }
    }
}
