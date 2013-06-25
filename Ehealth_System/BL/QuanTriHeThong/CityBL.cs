using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class CityBL
    {
        public List<CityDO> GetAllCity()
        {
            return CityDA.GetAllCities();
        }
        public static int add(String ID, String name, String desscription, bool status)
        {

            return CityDA.add(ID, name, desscription, status);

        }
        public static void edit(String ID, String name, String desscription, bool status)
        {

            CityDA.edit(ID, name, desscription, status);

        }





    }
}
