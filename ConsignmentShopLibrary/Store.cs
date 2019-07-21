﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string StoreName { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> items { get; set; }

        public Store()
        {
            Vendors = new List<Vendor>();
            items = new List<Item>();
        }
    }
}
