using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.Models;
using StockMarket.UserAPI.Repositories;

namespace StockMarket.UserAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repo;
        public UserService(IUserRepository repo) => _repo = repo;
        public List<Company> SearchCompany(string SearchText)
        {
            return _repo.SearchCompany(SearchText);
        }
    }
}
