using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public interface IAccountService
    {
        void AddUser(Users item);
        Users Validate(string uname, string pwd);

        void UpdateUser(Users item);

    }
}
