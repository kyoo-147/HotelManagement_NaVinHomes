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

namespace HotelManagement.CTControls
{
    public partial class CTEyePassword : UserControl
    {
        public CTEyePassword()
        {
            InitializeComponent();
        }

        private bool isShow = false;

        public bool IsShow { get => isShow; set => isShow = value; }

        private void CTEyePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
