using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.AccountAPI.Models;

namespace StockMarket.AccountAPI.Repositories
{
    public interface IAccountRepository
    {
        void AddUser(Users item);
        Users Validate(string uname, string pwd);

        void UpdateUser(Users item);
    }
}
