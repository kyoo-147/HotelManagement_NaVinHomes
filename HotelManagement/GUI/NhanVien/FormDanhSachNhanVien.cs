using HotelManagement.BUS;
using HotelManagement.CTControls;
using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVinHomes Management (https://github.com/kyoo-147/HotelManagement_NaVinHomes) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace HotelManagement.GUI
{
    public partial class FormDanhSachNhanVien : Form
    {
        private Image NV = Properties.Resources.NhanVien;
        private Image edit = Properties.Resources.edit;
        private Image delete = Properties.Resources.delete;
        private FormMain formMain;
        private TaiKhoan taiKhoan1;
        List<NhanVien> nhanViens;
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        
        public FormDanhSachNhanVien(FormMain formMain,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.taiKhoan1 = taiKhoan;
        }   

        private void CTButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormThemNhanVien formThemNhanVien = new FormThemNhanVien())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formThemNhanVien.Owner = formBackground;
                    formThemNhanVien.ShowDialog();
                    formBackground.Dispose();

                }
                LoadAllGrid();
            }
            catch ( Exception )
            {
                CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);

            LoadAllGrid();
            /* grid.Rows.Add(new object[] { NV, "NV001", "Phan Tuấn Thành", "Giám đốc", "11/10/2003", "Nam", "0123456789", "thanhpt1110@gmail.com", edit, delete });
             grid.Rows.Add(new object[] { NV, "NV001", "Phan Tuấn Thành", "Quản lý", "11/10/2003", "Nam", "0123456789", "thanhpt1110@gmail.com", edit, delete });
             grid.Rows.Add(new object[] { NV, "NV001", "Phan Tuấn Thành", "Nhân viên", "11/10/2003", "Nam", "0123456789", "thanhpt1110@gmail.com", edit, delete });
             grid.Rows.Add(new object[] { NV, "NV001", "Phan Tuấn Thành", "Giám đốc", "11/10/2003", "Nam", "0123456789", "thanhpt1110@gmail.com", edit, delete });*/
        }
        public void LoadAllGrid()
        {
            try
            {
                if(taiKhoan1.CapDoQuyen==2)
                    this.nhanViens = NhanVienBUS.Instance.GetNhanViens().Where(p=> !p.MaNV.StartsWith("AD")).ToList();
                else
                    this.nhanViens = NhanVienBUS.Instance.GetNhanViens();
                LoadGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadGrid()
        {
            try
            {
                grid.Rows.Clear();
                foreach (NhanVien nhanvien in this.nhanViens)
                {
                    grid.Rows.Add(NV, nhanvien.MaNV, nhanvien.TenNV, nhanvien.ChucVu, String.Format("{0:dd/MM/yyyy}", nhanvien.NgaySinh), nhanvien.GioiTinh, nhanvien.SDT, nhanvien.Email, edit, delete);
                }
            }
            catch (Exception)
            {
                CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notification",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (grid.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    
                    int row = grid.Rows.Count;
                    int col = grid.Columns.Count;

                    for (int i = 1; i < col -2 + 1; i++)
                    {
                        if (i == 1) continue;
                        xcelApp.Cells[1, i -1] = grid.Columns[i-1].HeaderText;
                    }

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 2; j++)
                        {
                            xcelApp.Cells[i + 2, j] = grid.Rows[i].Cells[j].Value.ToString();
                        }
                        xcelApp.Columns.AutoFit();
                        xcelApp.Visible = true;
                    }
                    

                }
                else
                {
                    string mess = "There is no data in the table yet!";
                    CTMessageBox.Show(mess, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                string mess = "Error! An error occurred. Please try again!";
                CTMessageBox.Show(mess, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (y >= 0)
            {
                // If click Update button 
                
                if (x == 8)
                {
                    if (taiKhoan1.CapDoQuyen == 2 && this.grid.Rows[y].Cells[1].Value.ToString().StartsWith("QL"))
                    {
                        CTMessageBox.Show("You do not have permission to edit this information", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormSuaNhanVien formSuaNhanVien = new FormSuaNhanVien(NhanVienBUS.Instance.GetNhanVien(grid.Rows[y].Cells[1].Value.ToString()))) 
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formSuaNhanVien.Owner = formBackground;
                            formSuaNhanVien.ShowDialog();
                            this.LoadAllGrid();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { formBackground.Dispose(); }
                }
                // If click delete
                if (x == 9)
                {
                    if (taiKhoan1.CapDoQuyen == 2 && this.grid.Rows[y].Cells[1].Value.ToString().StartsWith("QL"))
                    {
                        CTMessageBox.Show("You do not have permission to perform this operation.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DialogResult dialogresult = CTMessageBox.Show("Are you sure you want to delete??", "Notification",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogresult == DialogResult.Yes)
                    {
                        try
                        {
                            NhanVienBUS.Instance.RemoveNhanVien(NhanVienBUS.Instance.GetNhanVien(grid.Rows[y].Cells[1].Value.ToString()));
                            this.LoadAllGrid();
                            CTMessageBox.Show("Information deleted successfully.", "Notification",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                        }
                    }

                }
                if (x >= 0 && x <= 7)
                {
                    // If click Info
                    if (taiKhoan1.CapDoQuyen == 2 && this.grid.Rows[y].Cells[1].Value.ToString().StartsWith("QL"))
                    {
                        CTMessageBox.Show("You do not have permission to perform this operation.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        
                        using (FormThongTinNhanVien formThongTinNhanVien = new FormThongTinNhanVien(NhanVienBUS.Instance.GetNhanVien(grid.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formThongTinNhanVien.Owner = formBackground;
                            formThongTinNhanVien.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        CTMessageBox.Show("Error! An error occurred. Please try again later! Please try again.", "Notification",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { formBackground.Dispose(); }
                }
            }
        }

        private void grid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            int y = e.RowIndex, x = e.ColumnIndex;
            int[] arrX = { 1, 3, 5 };
            bool isExists = false;

            if (Array.IndexOf(arrX, x) != -1)
                isExists = true;

            if (y >= 0 && x >= 0 || y == -1 && isExists)
                grid.Cursor = Cursors.Hand;
            else
                grid.Cursor = Cursors.Default;
        }

        private void CTTextBoxTimTheoTenNhanVien__TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxNhanVien = sender as TextBox;

            if (textBoxNhanVien.Focused == false)
            {
                LoadAllGrid();
                return;
            }
            if(taiKhoan1.CapDoQuyen==2)
                this.nhanViens = NhanVienBUS.Instance.GetNhanViensWithName(textBoxNhanVien.Text).Where(p=>!p.MaNV.StartsWith("AD")).ToList();
            else
                this.nhanViens = NhanVienBUS.Instance.GetNhanViensWithName(textBoxNhanVien.Text);

            LoadGrid();
        }
        private void grid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grid.Cursor = Cursors.Default;
        }
    }
}
