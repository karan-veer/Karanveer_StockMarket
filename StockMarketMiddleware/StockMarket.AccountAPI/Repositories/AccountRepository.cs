using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private StockMarketDBContext _context;

        public AccountRepository(StockMarketDBContext context) {
            _context = context;
        }
        public void AddUser(Users item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public Users Validate(string uname, string pwd)
        {
            Users user = _context.Users.SingleOrDefault(i => i.UserName == uname && i.Password == pwd);
            return user;
        }
        public void UpdateUser(Users item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
            
        }
    }
}
