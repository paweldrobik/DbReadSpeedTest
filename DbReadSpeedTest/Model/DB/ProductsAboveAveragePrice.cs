using System;
using System.Collections.Generic;

#nullable disable

namespace DbReadSpeedTest.Model.DB
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
