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
    public class CityDA
    {
        public static List<CityDO> GetAllCities()
        {
            List<CityDO> ListCity = new List<CityDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.City_Info select u;

                foreach (var row in query)
                {
                    CityDO city = new CityDO();
                    city._CITYID = row.CITYID;
                    city._CITYNAME = row.CITYNAME;
                    city._DESCRIPTIONCITY = row.DESCRIPTIONCITY;
                    city._STATUSCITY = row.STATUSCITY;
                    ListCity.Add(city);
                }
                return ListCity;
            }
        }
        public static void add(String ID, String name, String desscription, bool status)
        {

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                Entity.City_Info city = new Entity.City_Info();
                city.CITYID = ID;
                city.CITYNAME = name;
                city.DESCRIPTIONCITY = desscription;
                city.STATUSCITY = status;
                entity.City_Info.Add(city);
                entity.SaveChanges();

            }
        }
        public static void edit(String ID, String name, String desscription, bool status)
        {

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                var city = entity.City_Info.Single(p => p.CITYID == ID);

                city.CITYID = ID;
                city.CITYNAME = name;
                city.DESCRIPTIONCITY = desscription;
                city.STATUSCITY = status;

                entity.SaveChanges();

            }
        }
    }
}
