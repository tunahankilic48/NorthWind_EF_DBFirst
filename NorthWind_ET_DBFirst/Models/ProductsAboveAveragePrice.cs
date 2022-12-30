using System;
using System.Collections.Generic;

namespace NorthWind_EF_DBFirst.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
