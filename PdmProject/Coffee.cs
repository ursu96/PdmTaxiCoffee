﻿using System;
using SQLite;

namespace PdmProject
{
    [Table("Coffees")]
    public class Coffee
    {
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        [Ignore]
        public string ResourceCoffeeImg
        {
            get
            {
                return Name.ToLower().Substring(0, 2) + ".png";
            }
        }
    }      
}
