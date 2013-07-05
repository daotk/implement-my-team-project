using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO.Thu_Ngan
{
    public class HoaDonDO
    {
        public string tenbenhnhan_ { get; set; }
    }
    public class DSbenhnhanDO {
        public string mabenhnhan_ { get; set; }
        public string tenbenhnhan_ { get; set; }
    }
    public class ThongTinBenhNhanDO
    {
        public string mahoadon_ { get; set; }
        public string mabenhnhan_ { get; set; }
        public string tenbenhnhan_ { get; set; }
        public string gioitinh_ { get; set; }
        public string tuoi_ { get; set; }
        public string diachi_ { get; set; }
        public string sodienthoai_ { get; set; }
    }
    public class DSLoaiDichVuDO
    {
        public string mahoadon_ { get; set; }
        public string loaidichvu_ { get; set; }
        public string dongia_ { get; set; }
    }
    public class CapNhatBillDO
    {
        public string mahoadon_ { get; set; }
        public bool trangthai_ { get; set; }
       
    }
}
