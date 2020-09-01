using System;
using System.Collections.Generic;

namespace StockMarket.ExcelAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            StockPrice = new HashSet<StockPrice>();
        }

        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Ceo { get; set; }

        public virtual ICollection<StockPrice> StockPrice { get; set; }
    }
}
