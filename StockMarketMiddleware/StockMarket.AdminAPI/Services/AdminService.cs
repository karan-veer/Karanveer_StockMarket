using StockMarket.AdminAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AdminAPI.Models;

namespace StockMarket.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private IAdminRepository _repo;
        public AdminService(IAdminRepository repo) 
        {
            _repo = repo;
        }
        public void AddCompany(Company item)
        {
            _repo.AddCompany(item);
        }

        public void DeleteCompany(string id)
        {
            _repo.DeleteCompany(id);
        }

        public List<Company> GetAllCompany()
        {
            return _repo.GetAllCompany();
        }

        public Company GetCompanyById(string id)
        {
            return _repo.GetCompanyById(id);
        }

        public void UpdateCompany(Company item)
        {
            _repo.UpdateCompany(item);
        }
    }
}
