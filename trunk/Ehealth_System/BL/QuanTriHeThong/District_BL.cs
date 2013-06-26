using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class District_BL
    {
        public List<District_DO> GetAllDistrict()
        {
            return District_DA.GetAllDistricts();
        }
        public static int add(String ID, String name, String CityID, String desscription, bool status)
        {

            return District_DA.add(ID, name, CityID, desscription, status);

        }
        public static void edit(String ID, String name, String CityID, String desscription, bool status)
        {

            District_DA.edit(ID, name, CityID, desscription, status);

        }





    }
}
