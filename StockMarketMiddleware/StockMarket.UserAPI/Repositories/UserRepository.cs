using StockMarket.UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.Models;

namespace StockMarket.UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StockMarketDBContext _context;
        public UserRepository(StockMarketDBContext context) => _context = context;

        public List<Company> SearchCompany(string SearchText)
        {
            var CompanyQuery = from x in _context.Company select x;
            if (!String.IsNullOrEmpty(SearchText)) 
            {
                CompanyQuery =CompanyQuery.Where(x => x.CompanyName.Contains(SearchText)||x.CompanyCode.Contains(SearchText)||x.Ceo.Contains(SearchText));
            }
            return CompanyQuery.ToList();
        }
    }
}
