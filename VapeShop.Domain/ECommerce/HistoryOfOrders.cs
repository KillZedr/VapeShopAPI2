﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapeShop.Domain.ECommerce
{
    public class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; } = null!;

        public virtual ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}