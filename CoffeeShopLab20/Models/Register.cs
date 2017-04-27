using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data.Entity;


namespace CoffeeShopLab20.Models
{
    public class Register
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Coffee { get; set; }
        public string Tea { get; set; }
        public string Bakery { get; set; }
    }

   
}