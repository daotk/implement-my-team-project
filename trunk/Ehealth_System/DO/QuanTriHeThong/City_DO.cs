using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
namespace DO.QuanTriHeThong
{
    //initialize class
    public class City_DO
    {
        public string _CITYID { set; get; }
        public string _CITYNAME { set; get; }
        public string _DESCRIPTIONCITY { set; get; }
        public bool _STATUSCITY { set; get; }
    }//end class
}//end constructor
