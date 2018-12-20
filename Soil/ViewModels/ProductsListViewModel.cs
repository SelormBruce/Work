using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Products> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
