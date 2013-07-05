using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.Thu_Ngan;
using DA.Thu_Ngan;
namespace BL.Thu_Ngan
{
    public class CashierBL
    {
        public static List<HoaDonDO> LoadDSbenhnhan() {
            return DA.Thu_Ngan.CashierDA.LoadDSbenhnhan();
        }
        public static List<DSbenhnhanDO> Loadbenhnhan(string mabenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.Loadbenhnhan(mabenhnhan);
        }
        public static List<ThongTinBenhNhanDO> LoadThongTinBenhNhan(string tenbenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.LoadThongTinBenhNhan(tenbenhnhan);
        }
        public static List<DSLoaiDichVuDO> LoadLoaiDichVu(string tenbenhnhan)
        {
            return DA.Thu_Ngan.CashierDA.LoadLoaiDichVu(tenbenhnhan);
        }
        public static void CapNhatBill(string mahoadon, bool trangthai)
        {
            DA.Thu_Ngan.CashierDA.CapNhatBill(mahoadon,trangthai);
        }
    }
}
