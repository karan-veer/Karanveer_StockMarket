using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Services
{
    public interface IAdminService
    {
        void AddCompany(Company item);
        void UpdateCompany(Company item);
        void DeleteCompany(string id);
        List<Company> GetAllCompany();
        Company GetCompanyById(string id);
    }
}
