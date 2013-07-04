using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.ThuNgan;
namespace DA.ThuNgan
{
    public class TypistDA
    {
        public static List<DO.ThuNgan.TypistDO> LoadDSServiceType()
        {
            List<TypistDO> dsusergroup = new List<TypistDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info select u;
                foreach (var row in query)
                {
                    TypistDO us = new TypistDO();
                    us.servicetypeid = row.SERVICEGROUPID;
                    us.servicetypename = row.SERVICEGROUPNAME;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        public static List<TypistDO> LoadDSService(string maloaidichvu)
        {
            List<TypistDO> dsuser = new List<TypistDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Service_Info where u.SERVICEGROUPID == maloaidichvu   select u;
                foreach (var row in query)
                {
                    TypistDO us = new TypistDO();
                    us.serviceid_ = row.SERVICEID;
                    us.servicename_ = row.SERVICENAME;
                    dsuser.Add(us);
                }
            }
            return dsuser;
        }
        public static List<PatientDO> LoadDSMaBenhNhan()
        {
            List<PatientDO> patientinfo = new List<PatientDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Patient_Info  select u;
                foreach (var row in query)
                {
                    PatientDO us = new PatientDO();
                    us.patientid_ = row.PATIENTID;
                    patientinfo.Add(us);
                }
            }
            return patientinfo;
        
        }
        public static List<PatientDO> LoadPatientInfo(string mabenhnhan)
        {
            List<PatientDO> patientinfo = new List<PatientDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Patient_Info where u.PATIENTID == mabenhnhan select u;
                foreach (var row in query)
                {
                    PatientDO us = new PatientDO();
                    us.patientid_ = row.PATIENTID;
                    us.patientname_ = row.PATIENTNAME;
                    us.gender_ = row.GENDER;
                    us.address_ = row.ADDRESS;
                    us.phone_ = row.PATIENTPHONE;
                    us.age_ = row.AGE;
                    patientinfo.Add(us);
                }
            }
            return patientinfo;
        }

        public static List<CostDO> LoadServiceCost(string tendichvu)
        {
            List<CostDO> patientinfos = new List<CostDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Service_Info where u.SERVICEID == tendichvu select u;
                foreach (var row in query)
                {
                    CostDO us = new CostDO();
                    us.serviceid_ = row.SERVICEID;
                    us.servicecost_ = row.SERVICECOST;
                    patientinfos.Add(us);
                }
            }
            return patientinfos;
        }

        public static void CreateBill(string madichvu, string mabenhnhan, string manguoidung
            , string maban, string chiphihoadon, bool trangthaihoadon, string servicegroupid)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                dk.sp_TaoHoaDon(madichvu, mabenhnhan, manguoidung, maban, chiphihoadon, trangthaihoadon, servicegroupid);
            }
        }

        public static void CreateDetailBill( string madichvu, string chiphidichvu, string mahoadon)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.DetailBill_Info user = new Entity.DetailBill_Info();
                
                user.SERVICEID = madichvu;
                user.SERVICECOST = chiphidichvu;
                user.BILLID = mahoadon;
                
                dk.DetailBill_Info.AddObject(user);
                dk.SaveChanges();
            }
        }
        public static string LoadIDdichvu(string tendichvu,string madichvu) {
            
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Service_Info where u.SERVICENAME == tendichvu select u;
                foreach (var row in query)
                {
                    madichvu = row.SERVICEID;
                    
                }
            }
            return madichvu;
        }
        public static string LoadIDLoaidichvu(string tenloaidichvu, string maloaidichvu)
        {

            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info where u.SERVICEGROUPNAME == tenloaidichvu select u;
                foreach (var row in query)
                {
                    maloaidichvu = row.SERVICEGROUPID;

                }
            }
            return maloaidichvu;
        } 

        public static string LoadIDBill(string tenloaidichvu, string mabill){
             using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info where u.SERVICEGROUPNAME == tenloaidichvu select u;
                foreach (var row in query)
                {
                    mabill = row.BILLID;
                    
                }
            }
            return mabill;
        }

        public static void capnhatongtien(string maloaidichvu,string tongtien) {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.Bill_Info
                             where u.BILLID == maloaidichvu
                             select u).First();
                query.BILLID = maloaidichvu;
                query.BILLCOST = tongtien;
                dk.SaveChanges();
            }
        }

    }
}
