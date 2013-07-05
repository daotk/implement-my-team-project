using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.Thu_Ngan;
using BL.Thu_Ngan;
namespace GUI.ThuNgan
{
    public partial class frm_Cashier : Form
    {
        public frm_Cashier()
        {
            InitializeComponent();
        }

        private void frm_Cashier_Load(object sender, EventArgs e)
        {
            LoadDSBanhNhan();
            timer1.Start();
        }

        private void LoadDSBanhNhan()
        {
            
            grd_HoaDon.Rows.Clear();
            List<HoaDonDO> xyz = BL.Thu_Ngan.CashierBL.LoadDSbenhnhan();
            int a = 1;
            if (xyz.Count != 0) {
                string[] tenbenhnhan = new string[xyz.Count];
                tenbenhnhan[0] = xyz[0].tenbenhnhan_.ToString();
                DataGridViewRow row = new DataGridViewRow();
                grd_HoaDon.Rows.Add(row);
                grd_HoaDon.Rows[0].Cells[1].Value = tenbenhnhan[0];

                for (int i = 1; i < xyz.Count; i++)
                {
                    bool test = true;
                    for (int c = 0; c < a; c++)
                    {
                        if (tenbenhnhan[c].Equals(xyz[i].tenbenhnhan_.ToString()))
                        {
                            test = false;
                        }
                    }
                    if (test)
                    {

                        tenbenhnhan[a] = xyz[i].tenbenhnhan_.ToString();
                        DataGridViewRow row1 = new DataGridViewRow();
                        grd_HoaDon.Rows.Add(row1);
                        grd_HoaDon.Rows[a].Cells[1].Value = tenbenhnhan[a];

                        a++;
                    }
                }
            }
            
            
        }
        private bool CheckBenhNhan(string mabenhnhan) {
            bool test = false;
            List<DSbenhnhanDO> abc = BL.Thu_Ngan.CashierBL.Loadbenhnhan(mabenhnhan);
            for (int i = 0; i < abc.Count; i++)
            {
                if (mabenhnhan.Equals(abc[i].mabenhnhan_))
                {
                    test = true;
                }
            }
            return test;
        }
        private void txt_TimKiemHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (txt_TimKiemHoaDon.Text == "" || txt_TimKiemHoaDon.Text == null)
                {
                    
                    LoadDSBanhNhan();
                }
                else {
                    if (CheckBenhNhan(txt_TimKiemHoaDon.Text))
                    {
                        grd_HoaDon.Rows.Clear();
                        List<DSbenhnhanDO> abc = BL.Thu_Ngan.CashierBL.Loadbenhnhan(txt_TimKiemHoaDon.Text);
                        grd_HoaDon.Rows[0].Cells[1].Value = abc[0].tenbenhnhan_;
                    }
                    else {
                        MessageBox.Show("Bệnh nhân không có trong danh sách chưa thu tiền");
                        LoadDSBanhNhan();
                    }
                }
            }
        }

        private void grd_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tenbenhnhan = grd_HoaDon.CurrentRow.Cells[1].Value.ToString();
                List<ThongTinBenhNhanDO> xyz = BL.Thu_Ngan.CashierBL.LoadThongTinBenhNhan(tenbenhnhan);
                txt_MaHoaDon.Text = xyz[0].mahoadon_;
                txt_MabenhNhan.Text = xyz[0].mabenhnhan_;
                txt_TenBenhNhan.Text = xyz[0].tenbenhnhan_;
                txt_GioiTinh.Text = xyz[0].gioitinh_;
                txt_DiaChi.Text = xyz[0].diachi_;
                txt_SDT.Text = xyz[0].sodienthoai_;

                grd_DichVu.DataSource = BL.Thu_Ngan.CashierBL.LoadLoaiDichVu(tenbenhnhan);
            }
            catch { 
                
            }
            
        }
        
        private void grd_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                
                string tongtien = grd_DichVu.CurrentRow.Cells[4].Value.ToString();
                txt_TongSoTien.Text = tongtien;
                MaHoaDon1 = grd_DichVu.CurrentRow.Cells["loaiduchvu"].Value.ToString();
            }catch
            {
                MessageBox.Show("Cell click DV");
            }
            
        }

        private void txt_SoTienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_SoTienNhan.Text == "") {
                    txt_SoTienHoanLai.Text = "";
                }
                txt_SoTienHoanLai.Text = (Convert.ToInt32(txt_SoTienNhan.Text) - Convert.ToInt32(txt_TongSoTien.Text)).ToString();
            }
            catch { 
                
            }
        }
        private string MaHoaDon1;
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            if (MaHoaDon1 == "" || MaHoaDon1 == null)
            {
                MessageBox.Show("Chưa chọn loại dịch vụ cần thanh toán");
            }
            else {
                 
                BL.Thu_Ngan.CashierBL.CapNhatBill(MaHoaDon1, true);
                grd_DichVu.DataSource = BL.Thu_Ngan.CashierBL.LoadLoaiDichVu(txt_TenBenhNhan.Text);
                MessageBox.Show("Xác nhận thu tiền thành công");
                MaHoaDon1 = "";
                LoadDSBanhNhan();
            }

        }

        private void txt_SoTienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDSBanhNhan();
            timer1.Interval = 10000;
            
        }
        
        
        
    }
}
