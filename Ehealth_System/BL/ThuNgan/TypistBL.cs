﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.Thu_Ngan;
using DO.Thu_Ngan;
namespace BL.Thu_Ngan
{
    public class TypistBL
    {
        public static List<TypistDO> LoadDSServiceType()
        {
            return DA.Thu_Ngan.TypistDA.LoadDSServiceType();
        }
        public static List<TypistDO> LoadDSService(string maloaidichvu)
        {
            return DA.Thu_Ngan.TypistDA.LoadDSService(maloaidichvu);
        }
        public static List<PatientDO> LoadPatientInfo(string mabenhnhan)
        {
            return DA.Thu_Ngan.TypistDA.LoadPatientInfo(mabenhnhan);
        }
        public static List<CostDO> LoadServiceCost(string tendichvu)
        {
            return DA.Thu_Ngan.TypistDA.LoadServiceCost(tendichvu);
        }
        public static void CreateBill(string madichvu, string mabenhnhan, string manguoidung
           , string maban, string chiphihoadon, bool trangthaihoadon, string servicegroupid)
        {

             DA.Thu_Ngan.TypistDA.CreateBill(madichvu, mabenhnhan, manguoidung
           , maban, chiphihoadon, trangthaihoadon, servicegroupid); 
        }

        public static void CreateDetailBill( string madichvu, string chiphidichvu, string mahoadon)
        {

            DA.Thu_Ngan.TypistDA.CreateDetailBill( madichvu, chiphidichvu, mahoadon);
        
        }
        public static string LoadIDLoaidichvu(string tenloaidichvu, string maloaidichvu)
        {
            return DA.Thu_Ngan.TypistDA.LoadIDLoaidichvu(tenloaidichvu, maloaidichvu);
        }
        public static string LoadIDdichvu(string tendichvu, string madichvu)
        {
            return DA.Thu_Ngan.TypistDA.LoadIDdichvu(tendichvu, madichvu);
        }

        public static string LoadIDBill(string tenloaidichvu, string mabill)
        {
            return DA.Thu_Ngan.TypistDA.LoadIDBill(tenloaidichvu, mabill);
        }
        public static List<PatientDO> LoadDSMaBenhNhan()
        {
            return DA.Thu_Ngan.TypistDA.LoadDSMaBenhNhan();
        }

        public static void capnhatongtien(string maloaidichvu, string tongtien)
        {
            DA.Thu_Ngan.TypistDA.capnhatongtien(maloaidichvu, tongtien);
        }
    }
}
