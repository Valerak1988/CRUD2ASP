﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Cities
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CityCode { get; set; }
        public DateTime AddDate { get; set; }
        public static List<Cities> GetAll()
        {
            return CitiesDAL.GetAll();
        }
        public static Cities GetById(int id)
        {
            return CitiesDAL.GetById(id);
        }
        public Cities Save(Cities city)
        {
            return CitiesDAL.Save(city);
        }
        
    }
}