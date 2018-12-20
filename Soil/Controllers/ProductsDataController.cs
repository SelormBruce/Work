using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    [Route("api/[controller]")]
    public class ProductsDataController : Controller
    {
        private readonly IProductsRepository _drinkRepository;

        public ProductsDataController(IProductsRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        [HttpGet]
        public IEnumerable<ProductsViewModel> LoadMoreDrinks()
        {
            IEnumerable<Products> dbDrinks = null;

            dbDrinks = _drinkRepository.Drinks.OrderBy(p => p.Id).Take(10);

            List<ProductsViewModel> drinks = new List<ProductsViewModel>();

            foreach (var dbDrink in dbDrinks)
            {
                drinks.Add(MapDbDrinkToDrinkViewModel(dbDrink));
            }
            return drinks;
        }

        private ProductsViewModel MapDbDrinkToDrinkViewModel(Products dbDrink) => new ProductsViewModel()
        {
            DrinkId = dbDrink.Id,
            Name = dbDrink.Name,
            Price = dbDrink.Price,
            ShortDescription = dbDrink.ShortDescription,
            ImageThumbnailUrl = dbDrink.ImageThumbnailUrl
        };

    }
}
