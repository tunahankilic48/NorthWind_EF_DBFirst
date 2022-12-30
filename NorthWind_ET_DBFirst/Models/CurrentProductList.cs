using System;
using System.Collections.Generic;

namespace NorthWind_EF_DBFirst.Models
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
