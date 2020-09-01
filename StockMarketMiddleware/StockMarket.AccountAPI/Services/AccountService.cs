using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _repo;

        public AccountService(IAccountRepository repo) 
        {
            _repo = repo;
        }
        public void AddUser(Users item)
        {
            _repo.AddUser(item);
        }

        public Users Validate(string uname, string pwd)
        {
            return _repo.Validate(uname, pwd);
        }
        public void UpdateUser(Users item)
        {
            _repo.UpdateUser(item);
            

        }
    }
}
