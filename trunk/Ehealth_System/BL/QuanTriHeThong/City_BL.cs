using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    //initialize class
    public class City_BL
    {
        //initialize new constructor to get all cities
        public List<City_DO> GetAllCity()
        {
            return City_DA.GetAllCities();
        }

        //initialize add constructor
        public static int add(String ID, String name, String desscription, bool status)
        {
            return City_DA.add(ID, name, desscription, status);
        }

        //initialize edit constructor
        public static int edit(String ID, String name, String desscription, bool status)
        {
            return City_DA.edit(ID, name, desscription, status);
        }

        //initialize new constructor to search city by textbox
        public static List<City_DO> SearchCity(String name)
        {
            return City_DA.SearchCity(name);
        }

    }//end class
}//end namespace
