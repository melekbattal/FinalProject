﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //temel mesajları buraya koy
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismki geçersiz";
        internal static List<Product> MaintenanceTime;
        internal static string ProductsListed;
    }
}
