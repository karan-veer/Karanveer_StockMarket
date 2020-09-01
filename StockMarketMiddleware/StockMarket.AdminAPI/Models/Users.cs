using System;
using System.Collections.Generic;

namespace StockMarket.AdminAPI.Models
{
    public partial class Users
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Confirmed { get; set; }
    }
}
