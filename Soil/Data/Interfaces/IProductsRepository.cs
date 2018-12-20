using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Interfaces
{
    public interface IProductsRepository
    {
        IEnumerable<Products> Drinks { get; }
        IEnumerable<Products> PreferredDrinks { get; }
        Products GetDrinkById(int drinkId);
    }
}
