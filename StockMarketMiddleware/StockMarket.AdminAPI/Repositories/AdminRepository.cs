using StockMarket.AdminAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AdminAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private StockMarketDBContext _context;

        public AdminRepository(StockMarketDBContext context)
        { _context = context; }
        public void AddCompany(Company item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void DeleteCompany(string id)
        {
            Company company=_context.Company.Find(id);
            _context.Remove(company);
            _context.SaveChanges();
        }

        public List<Company> GetAllCompany()
        {
            return _context.Company.ToList();
        }

        public Company GetCompanyById(string id)
        {
            return _context.Company.Find(id);
        }

        public void UpdateCompany(Company item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
