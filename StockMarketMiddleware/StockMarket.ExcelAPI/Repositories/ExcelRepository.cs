﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OfficeOpenXml;
using StockMarket.ExcelAPI.Models;

namespace StockMarket.ExcelAPI.Repositories
{
    public class ExcelRepository :IExcelRepository
    {
        private StockMarketDBContext _context;

        public AdminRepository(StockMarketDBContext context)
        { _context = context; }
        public IList<StockPrice> ExcelHelper(string filePath)
        {
            FileInfo file = new FileInfo(@filePath);
            string fileName = file.Name;
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                //int totalRows = worksheet.Dimension.Rows;
                int totalRows = worksheet.Dimension.Rows;

                List<StockPrice> stockPrices = new List<StockPrice>();
                for (int i = 2; i <= totalRows; i++)
                {
                    stockPrices.Add(new StockPrice
                    {
                        CompanyCode = worksheet.Cells[i, 1].Value.ToString().Trim(),
                        StockExchange = worksheet.Cells[i, 2].Value.ToString().Trim(),
                        CurrentPrice = double.Parse(worksheet.Cells[i, 3].Value.ToString().Trim()),
                        Date = DateTime.Parse(worksheet.Cells[i, 4].Value.ToString().Trim()),
                        Time = worksheet.Cells[i, 5].Value.ToString().Trim()
                    });
                }
                context.StockPrices.AddRange(stockPrices);
                context.SaveChanges();
                return stockPrices;
            }
        }
}
