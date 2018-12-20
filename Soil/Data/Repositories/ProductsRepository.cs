using DrinkAndGo.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkAndGo.Data.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Products> Drinks => _appDbContext.Products.Include(c => c.Category);

        public IEnumerable<Products> PreferredDrinks => _appDbContext.Products.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Products GetDrinkById(int drinkId) => _appDbContext.Products.FirstOrDefault(p => p.Id == drinkId);
    }
}
