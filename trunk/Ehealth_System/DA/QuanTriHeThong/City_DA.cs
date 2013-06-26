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
    public class City_DA
    {
        public static List<City_DO> GetAllCities()
        {
            List<City_DO> ListCity = new List<City_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.City_Info select u;

                foreach (var row in query)
                {
                    City_DO city = new City_DO();
                    city._CITYID = row.CITYID;
                    city._CITYNAME = row.CITYNAME;
                    city._DESCRIPTIONCITY = row.DESCRIPTIONCITY;
                    city._STATUSCITY = row.STATUSCITY;
                    ListCity.Add(city);
                }
                return ListCity;
            }
        }
        public static int add(String ID, String name, String desscription, bool status)
        {

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                Entity.City_Info city = new Entity.City_Info();
                city.CITYID = ID;
                city.CITYNAME = name;
                city.DESCRIPTIONCITY = desscription;
                city.STATUSCITY = status;
                entity.City_Info.AddObject(city);
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
