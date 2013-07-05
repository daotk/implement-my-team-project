using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.Thu_Ngan;

namespace DA.Thu_Ngan
{
    public class CashierDA
    {
        public static List<HoaDonDO> LoadDSbenhnhan() {
            List<HoaDonDO> dsusergroup = new List<HoaDonDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Patient_Info join p in dk.Bill_Info on u.PATIENTID equals p.PATIENTID 
                            where p.BILLSTATUS == false select u;
                foreach (var row in query)
                {
                    HoaDonDO us = new HoaDonDO();
                    us.tenbenhnhan_ = row.PATIENTNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<DSbenhnhanDO> Loadbenhnhan(string mabenhnhan)
        {
            List<DSbenhnhanDO> dsusergroup = new List<DSbenhnhanDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Patient_Info
                            join p in dk.Bill_Info on u.PATIENTID equals p.PATIENTID
                            where p.BILLSTATUS == false && p.PATIENTID == mabenhnhan
                            select u;
                foreach (var row in query)
                {
                    DSbenhnhanDO us = new DSbenhnhanDO();
                    us.mabenhnhan_ = row.PATIENTID;
                    us.tenbenhnhan_ = row.PATIENTNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<ThongTinBenhNhanDO> LoadThongTinBenhNhan(string tenbenhnhan) {
            List<ThongTinBenhNhanDO> dsusergroup = new List<ThongTinBenhNhanDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Patient_Info
                            join p in dk.Bill_Info on u.PATIENTID equals p.PATIENTID
                            where u.PATIENTNAME == tenbenhnhan
                            select new {u , p.BILLID};
                foreach (var row in query)
                {
                    ThongTinBenhNhanDO us = new ThongTinBenhNhanDO();
                    us.mahoadon_ = row.BILLID;
                    us.mabenhnhan_ = row.u.PATIENTID;
                    us.tenbenhnhan_ = row.u.PATIENTNAME;
                    us.gioitinh_ = row.u.GENDER;
                    us.tuoi_ = row.u.AGE;
                    us.diachi_ = row.u.ADDRESS;
                    us.sodienthoai_ = row.u.PATIENTPHONE;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        
        }

        public static List<DSLoaiDichVuDO> LoadLoaiDichVu(string tenbenhnhan)
        {
            List<DSLoaiDichVuDO> dsusergroup = new List<DSLoaiDichVuDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info
                            join p in dk.Patient_Info on u.PATIENTID equals p.PATIENTID
                            where p.PATIENTNAME == tenbenhnhan && u.BILLSTATUS == false
                            select u;
                foreach (var row in query)
                {
                    DSLoaiDichVuDO us = new DSLoaiDichVuDO();
                    us.mahoadon_ = row.BILLID;
                    us.loaidichvu_ = row.SERVICEGROUPNAME;
                    us.dongia_ = row.BILLCOST;
                    
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;

        }

        public static void CapNhatBill(string mahoadon, bool trangthai)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.Bill_Info
                             where u.BILLID == mahoadon
                             select u).First();
                query.BILLID = mahoadon;
                query.BILLSTATUS = trangthai;
                dk.SaveChanges();
            }
        }
    }
}
