using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class City_BL
    {
        public List<City_DO> GetAllCity()
        {
            return City_DA.GetAllCities();
        }

        public static int add(String ID, String name, String desscription, bool status)
        {
            return City_DA.add(ID, name, desscription, status);
        }

        public static void edit(String ID, String name, String desscription, bool status)
        {
            City_DA.edit(ID, name, desscription, status);
        }

        public static List<City_DO> SearchCity(String name)
        {
            return City_DA.SearchCity(name);
        }


    }
}
