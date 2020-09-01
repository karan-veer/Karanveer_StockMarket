using System;
using System.Collections.Generic;

namespace StockMarket.ExcelAPI.Models
{
    public partial class StockPrice
    {
        public int RowId { get; set; }
        public string CompanyCode { get; set; }
        public string StockExchange { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public double? CurrentPrice { get; set; }

        public virtual Company CompanyCodeNavigation { get; set; }
    }
}
