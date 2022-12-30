using System;
using System.Collections.Generic;

namespace NorthWind_EF_DBFirst.Models
{
    public partial class VwKritikSeviyeUrunBilgileri
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public short? MinimumSiparişMiktarı { get; set; }
    }
}
