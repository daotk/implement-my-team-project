﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
namespace DO.QuanTriHeThong
{
    public class CityDO
    {
        public string _CITYID { set; get; }
        public string _CITYNAME { set; get; }
        public string _DESCRIPTIONCITY { set; get; }
        public bool _STATUSCITY { set; get; }

    }

}
