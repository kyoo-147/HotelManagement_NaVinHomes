using HotelManagement.CTControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.GUI
{
    public partial class FormTrangChu : Form
    {
        private FormMain formMain;
        public FormTrangChu()
        {
            InitializeComponent();
        }

        // form nay se duoc goi khi nut menu duoc click
        public FormTrangChu(FormMain formMain)
        {
            // duoc tu dong tao ra de khoi dong cac phan tu cua design
            InitializeComponent();
            // hien thi form cua hien tai
            this.formMain = formMain;
        }

        private void CTButtonTest_Click(object sender, EventArgs e)
        {
            CTMessageBox.Show("Just a normal notifications!","Warning",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
