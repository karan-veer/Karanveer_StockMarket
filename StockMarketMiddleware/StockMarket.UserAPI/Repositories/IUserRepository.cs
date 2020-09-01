using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.Models;

namespace StockMarket.UserAPI.Repositories
{
    public interface IUserRepository
    {
        List<Company> SearchCompany(string SearchText);
    }
}
