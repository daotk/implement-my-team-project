using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using DO.QuanTriHeThong;
using DO;
namespace DA.QuanTriHeThong
{
    public class District_DA
    {
        public static List<District_DO> GetAllDistricts()
        {
            List<District_DO> ListDistrict = new List<District_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.District_Info select u;
                var query1 = from u in dk.City_Info
                             select u;
                foreach (var row in query)
                {
                    District_DO district = new District_DO();
                    district._DISTRICTID = row.DISTRICTID;
                    district._CITYID = row.CITYID;
                    var cityname = query1.Single(p=>p.CITYID==row.CITYID);
                    district._CITYNAME = cityname.CITYNAME;
                    district._DISTRICTNAME = row.DISTRICTNAME;
                    district._DESCRIPTIONDISTRICT = row.DISTRICTDESCRIPTION;
                    district._STATUSDISTRICT = row.DISTRICTSTATUS;
                    ListDistrict.Add(district);
                }
                return ListDistrict;
            }

        }
        public static int add(String ID, String name, String CITYID, String desscription, bool status)
        {
            
            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                Entity.District_Info district = new Entity.District_Info();
                district.DISTRICTID = ID;
                district.CITYID = CITYID;
                
                district.DISTRICTNAME = name;
                district.DISTRICTDESCRIPTION = desscription;
                district.DISTRICTSTATUS = status;
                entity.District_Info.AddObject(district);
                try
                {
                    int num = entity.SaveChanges();
                    return num;
                }
                catch
                {
                    return -1;
                }

            }
        }
        public static void edit(String ID, String name, String CITYID, String desscription, bool status)
        {
            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                var district = entity.District_Info.Single(p => p.DISTRICTID == ID);
                district.DISTRICTID = ID;
                district.CITYID = CITYID;
                district.DISTRICTNAME = name;
                district.DISTRICTDESCRIPTION = desscription;
                district.DISTRICTSTATUS = status;
                entity.SaveChanges();
            }
        }

        public static List<District_DO> SearchDistrict(string Search)
        {
            List<District_DO> timkiem = new List<District_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.District_Info where (u.DISTRICTNAME.Contains(Search)) select u;
                var query1 = from u in dk.City_Info
                             select u;
                foreach (var row in query)
                {
                    District_DO search = new District_DO();
                    search._DISTRICTID = row.DISTRICTID;
                    search._DISTRICTNAME = row.DISTRICTNAME;
                    search._CITYID = row.CITYID;
                    var cityname = query1.Single(p => p.CITYID == row.CITYID);
                    search._CITYNAME = cityname.CITYNAME;
                    search._DESCRIPTIONDISTRICT = row.DISTRICTDESCRIPTION;
                    search._STATUSDISTRICT = row.DISTRICTSTATUS;
                    timkiem.Add(search);
                }
                return timkiem;
            }
        }
        public static List<District_DO> SearchDistrictByBoth(String text,string Search)
        {
            List<District_DO> timkiem = new List<District_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.District_Info where (u.DISTRICTNAME.Contains(text)) && (u.CITYID.Contains(Search)) select u;
                var query1 = from u in dk.City_Info
                             select u;
                foreach (var row in query)
                {
                    District_DO search = new District_DO();
                    search._DISTRICTID = row.DISTRICTID;
                    search._DISTRICTNAME = row.DISTRICTNAME;
                    search._CITYID = row.CITYID;
                    var cityname = query1.Single(p => p.CITYID == row.CITYID);
                    search._CITYNAME = cityname.CITYNAME;
                    search._DESCRIPTIONDISTRICT = row.DISTRICTDESCRIPTION;
                    search._STATUSDISTRICT = row.DISTRICTSTATUS;
                    timkiem.Add(search);
                }
                return timkiem;
            }

        }
        public static List<District_DO> SearchDistrictByCity(string Search)
        {
            List<District_DO> timkiem = new List<District_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.District_Info where (u.CITYID.Contains(Search)) select u;
                var query1 = from u in dk.City_Info
                             select u;
                foreach (var row in query)
                {
                    District_DO search = new District_DO();
                    search._DISTRICTID = row.DISTRICTID;
                    search._DISTRICTNAME = row.DISTRICTNAME;
                    search._CITYID = row.CITYID;
                    var cityname = query1.Single(p => p.CITYID == row.CITYID);
                    search._CITYNAME = cityname.CITYNAME;
                    search._DESCRIPTIONDISTRICT = row.DISTRICTDESCRIPTION;
                    search._STATUSDISTRICT = row.DISTRICTSTATUS;
                    timkiem.Add(search);
                }
                return timkiem;
            }

        }

    }
}
