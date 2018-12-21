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
    public class ProductsController : Controller
    {
        private readonly IProductsRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductsController(IProductsRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Products> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(p => p.Id);
                currentCategory = "All Products";
            }
            else
            {
                if (string.Equals("Fresh Fish", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Fresh Fish")).OrderBy(p => p.Name);
                else if (string.Equals("Smoked Fish", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Smoked Fish")).OrderBy(p => p.Name);
                else if (string.Equals("Dried / Fried Fish", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Dried / Fried Fish")).OrderBy(p => p.Name);
                else if (string.Equals("Meat", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Meat")).OrderBy(p => p.Name);
                else if (string.Equals("Tubers", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Tubers")).OrderBy(p => p.Name);
                else if (string.Equals("Vegetables", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Vegetables")).OrderBy(p => p.Name);
                else if (string.Equals("Cereal", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Cereal")).OrderBy(p => p.Name);
                else if (string.Equals("Groceries", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Groceries")).OrderBy(p => p.Name);
                else
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Fruits")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ProductsListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Products> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                drinks = _drinkRepository.Drinks.OrderBy(p => p.Id);
            }
            else
            {
                drinks = _drinkRepository.Drinks.Where(p=> p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Products/List.cshtml", new ProductsListViewModel{Drinks = drinks, CurrentCategory = "All drinks" });
        }

        public ViewResult Details(int drinkId)
        {
            var drink = _drinkRepository.Drinks.FirstOrDefault(d => d.Id == drinkId);
            if (drink == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(drink);
        }
    }
}
