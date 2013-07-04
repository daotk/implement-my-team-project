using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    //initialize class
    public class District_BL
    {
        //initialize new constructor to get all districts
        public List<District_DO> GetAllDistrict()
        {
            return District_DA.GetAllDistricts();
        }

        public static List<DO.QuanTriHeThong.City_DO> GetAllDis1()
        {
            return District_DA.GetAllDis1();
        }

        //initialize add constructor
        public static int add(String ID, String name, String CityID, String desscription, bool status)
        {
            return District_DA.add(ID, name, CityID, desscription, status);
        }

        //initialize edit constructor
        public static int edit(String ID, String name, String CityID, String desscription, bool status)
        {
            return District_DA.edit(ID, name, CityID, desscription, status);
        }

        //initialize new constructor to search district by textbox
        public static List<District_DO> SearchDistrict(String name)
        {
            return District_DA.SearchDistrict(name);
        }

        //initialize new constructor to search district by combobox
        public static List<District_DO> SearchDistrictByCity(String city)
        {
            return District_DA.SearchDistrictByCity(city);
        }

        //initialize new constructor to search district by both textbox and combobox
        public static List<District_DO> SearchDistrictByBoth(String name, String city)
        {
            return District_DA.SearchDistrictByBoth(name, city);
        }

    }//end class
}//end namespace
