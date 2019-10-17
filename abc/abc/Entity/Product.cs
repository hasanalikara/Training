﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace abc.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool isApproved { get; set; }
        public bool isHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}