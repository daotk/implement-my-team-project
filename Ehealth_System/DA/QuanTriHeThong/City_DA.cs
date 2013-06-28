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
    //initialize class
    public class City_DA
    {
        //initialize new constructor to get all cities
        public static List<City_DO> GetAllCities()
        {
            //initialize constructor to get data from Entity model and assign them to grid view
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
                //return a list of city
                return ListCity;
            }
        }

        //initialize new constructor to save data
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
                //save changes
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

        //initialize new constructor to edit data
        public static int edit(String ID, String name, String desscription, bool status)
        {
            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                var city = entity.City_Info.Single(p => p.CITYID == ID);
                city.CITYID = ID;
                city.CITYNAME = name;
                city.DESCRIPTIONCITY = desscription;
                city.STATUSCITY = status;
                //save changes
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

        //initialize new constructor to search city
        public static List<City_DO> SearchCity(string Search)
        {
            List<City_DO> timkiem = new List<City_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.City_Info where (u.CITYNAME.Contains(Search)) select u;
                foreach (var row in query)
                {
                    City_DO search = new City_DO();
                    search._CITYID = row.CITYID;
                    search._CITYNAME = row.CITYNAME;
                    search._DESCRIPTIONCITY = row.DESCRIPTIONCITY;
                    search._STATUSCITY = row.STATUSCITY;
                    timkiem.Add(search);
                }
                //return a list of search results
                return timkiem;
            }
        }
    }//end class
}//end namespace
