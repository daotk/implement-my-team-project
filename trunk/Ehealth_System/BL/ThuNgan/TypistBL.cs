using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.ThuNgan;
using DO.ThuNgan;
namespace BL.ThuNgan
{
    public class TypistBL
    {
        public static List<TypistDO> LoadDSServiceType()
        {
            return DA.ThuNgan.TypistDA.LoadDSServiceType();
        }
        public static List<TypistDO> LoadDSService(string maloaidichvu)
        {
            return DA.ThuNgan.TypistDA.LoadDSService(maloaidichvu);
        }
        public static List<PatientDO> LoadPatientInfo(string mabenhnhan)
        {
            return DA.ThuNgan.TypistDA.LoadPatientInfo(mabenhnhan);
        }
        public static List<CostDO> LoadServiceCost(string tendichvu)
        {
            return DA.ThuNgan.TypistDA.LoadServiceCost(tendichvu);
        }
        public static void CreateBill(string madichvu, string mabenhnhan, string manguoidung
           , string maban, string chiphihoadon, bool trangthaihoadon, string servicegroupid)
        {

             DA.ThuNgan.TypistDA.CreateBill(madichvu, mabenhnhan, manguoidung
           , maban, chiphihoadon, trangthaihoadon, servicegroupid); 
        }

        public static void CreateDetailBill( string madichvu, string chiphidichvu, string mahoadon)
        {

            DA.ThuNgan.TypistDA.CreateDetailBill( madichvu, chiphidichvu, mahoadon);
        
        }
        public static string LoadIDLoaidichvu(string tenloaidichvu, string maloaidichvu)
        {
            return DA.ThuNgan.TypistDA.LoadIDLoaidichvu(tenloaidichvu, maloaidichvu);
        }
        public static string LoadIDdichvu(string tendichvu, string madichvu)
        {
            return DA.ThuNgan.TypistDA.LoadIDdichvu(tendichvu, madichvu);
        }

        public static string LoadIDBill(string tenloaidichvu, string mabill)
        {
            return DA.ThuNgan.TypistDA.LoadIDBill(tenloaidichvu, mabill);
        }
        public static List<PatientDO> LoadDSMaBenhNhan()
        {
            return DA.ThuNgan.TypistDA.LoadDSMaBenhNhan();
        }

        public static void capnhatongtien(string maloaidichvu, string tongtien)
        {
            DA.ThuNgan.TypistDA.capnhatongtien(maloaidichvu, tongtien);
        }
    }
}
