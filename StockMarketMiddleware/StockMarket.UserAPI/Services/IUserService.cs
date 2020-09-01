using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StockMarket.UserAPI.Models;

namespace StockMarket.UserAPI.Services
{
    public interface IUserService
    {
        List<Company> SearchCompany(string SearchText);
    }
}
