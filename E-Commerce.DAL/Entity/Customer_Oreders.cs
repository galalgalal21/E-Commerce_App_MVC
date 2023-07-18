﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Entity
{
    public class Customer_Oreders
    {
        public int id { get; set; }
        public DateTime date_order_placed { get; set; }
        public DateTime date_order_paid { get; set; }
        public float price { get; set; }
        public List<Customer_Oreders_Products>? Customer_Oreders_Products { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

    }
}
