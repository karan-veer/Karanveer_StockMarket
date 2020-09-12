using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.ExcelAPI.Repositories;
using StockMarket.ExcelAPI.Models;

namespace StockMarket.ExcelAPI.Services
{
    public class ExcelService
    {
        private IExcelRepository _rep;

        public ExcelService(IExcelRepository rep)
        {
            _rep = rep;
        }
        public IList<StockPrice> ExcelHelper(string filePath)
        {
            return (_rep.ExcelHelper(filePath));
        }
    }
}
