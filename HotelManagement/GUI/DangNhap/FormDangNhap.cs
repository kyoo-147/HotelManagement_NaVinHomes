using HotelManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement.CTControls;
using HotelManagement.DTO;
using System.Security.Cryptography;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.GUI
{
    public partial class FormDangNhap : Form
    {
        private FormLogin formLoginParent;
        public FormDangNhap(FormLogin formMain)
        {
            InitializeComponent();
            formLoginParent = formMain;
        }
        
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                formLoginParent.openChildForm(new FormQuenMatKhauLayOTP(formLoginParent));
                formLoginParent.bringControlBoxAndTBTLabelToFront();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        // Ham duoc goi khi nhan nut login
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Kiem tra co du lieu trong textbox user vaf pass khong
            if (TaiKhoanBUS.Instance.checkLogin(this.textBoxUsername.Texts, textBoxPassword.Texts))
            {
                // Lay chuoi ten tai khoan
                string account = textBoxUsername.Texts;
                
                HotelDTO db = new HotelDTO();
                TaiKhoan taiKhoan = db.TaiKhoans.Find(account);
                FormMain formMain = new FormMain(taiKhoan);
                // an form login cha 
                formLoginParent.Hide(); 
                // show form main
                formMain.ShowDialog();
                formLoginParent.Close();
            }
            else
            {
                // neu khong thi hien thi thong bao nhap sai thong tin
                CTMessageBox.Show("Wrong login information! Please check again.", "Notifications",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void textBoxPassword__TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.PreviewKeyDown += TextBox_PreviewKeyDown;
            if(textBoxPassword.Texts.Length>0 && ctEyePassword1.IsShow == false)
            {
                textBoxPassword.PasswordChar = true;
            }
        }

        private void TextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab && textBoxPassword.Texts.Length == 0)
            {
                e.IsInputKey = false;
            }
        }

        private void ctEyePassword1_Click(object sender, EventArgs e)
        {
            if (ctEyePassword1.IsShow == false)
            {
                ctEyePassword1.IsShow = true;
                textBoxPassword.PasswordChar = false;
                ctEyePassword1.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                ctEyePassword1.IsShow = false;
                if (textBoxPassword.Texts != "")
                {
                    textBoxPassword.PasswordChar = true;
                }
                ctEyePassword1.BackgroundImage = Properties.Resources.show;
            }
        }

        private void labelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
