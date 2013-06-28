using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
namespace DO.QuanTriHeThong
{
    //initialize class
    public class District_DO
    {
        public string _DISTRICTID { set; get; }
        public string _DISTRICTNAME { set; get; }
        public string _CITYID { set; get; }
        public string _CITYNAME { set; get; }
        public string _DESCRIPTIONDISTRICT { set; get; }
        public bool _STATUSDISTRICT { set; get; }
    }//end class
}//end namespace
