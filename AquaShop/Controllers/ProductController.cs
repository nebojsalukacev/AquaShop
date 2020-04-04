using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using AquaShop.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly IProductRepository productRep;
        private readonly ICategoryRepository categoryRep;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository,
                                IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            productRep = productRepository;
            categoryRep = categoryRepository;
        }
        public IActionResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> product;
            string currentCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                product = productRep.GetAllProducts().OrderBy(p => p.ProductId);
                currentCategory = "All Category";
            }
            else
            {
                if (string.Equals("Aquarium", _category, StringComparison.OrdinalIgnoreCase))
                {
                    product = productRep.GetAllProducts().Where(p => p.Category.CategoryName.Equals("Aquarium")).OrderBy(p => p.Name);
                }
                else if (string.Equals("Fish", _category, StringComparison.OrdinalIgnoreCase))
                {
                    product = productRep.GetAllProducts().Where(p => p.Category.CategoryName.Equals("Fish")).OrderBy(p => p.Name);
                }
                else if (string.Equals("Plant", _category, StringComparison.OrdinalIgnoreCase))
                {
                    product = productRep.GetAllProducts().Where(p => p.Category.CategoryName.Equals("Plant")).OrderBy(p => p.Name);
                }
                else if (string.Equals("Equipment", _category, StringComparison.OrdinalIgnoreCase))
                {
                    product = productRep.GetAllProducts().Where(p => p.Category.CategoryName.Equals("Equipment")).OrderBy(p => p.Name);
                }
                else
                    product = productRep.GetAllProducts().Where(p => p.Category.CategoryName.Equals("Reef")).OrderBy(p => p.Name);

                currentCategory = _category;

            }

            var productListViewModel = new ProductListViewModel()
            {
                Products = product,
                CurrentCategory = currentCategory
            };
            return View(productListViewModel);

            //ViewBag.Title = "All shown product";

            //ProductListViewModel vm = new ProductListViewModel
            //{
            //    Products = productRep.GetAllProducts(),
            //    CurrentProduct = "ProductCategory"
            //};

            //return View(vm);


        }
        public IActionResult Details(int? id)
        {
            ProductDetailsViewModel productDetailsViewModel = new ProductDetailsViewModel()
            {
                Product = productRep.GetProductById(id ?? 1),
                PageTitle = "Product Details"
            };
            return View(productDetailsViewModel);
        }
        public IActionResult Search(string strSearch)
        {
            IEnumerable<Product> products;
            string currentCategory = "All Products";

            if (string.IsNullOrEmpty(strSearch))
            {
                products = productRep.GetAllProducts().OrderBy(p => p.ProductId);
            }
            else
            {
                products = productRep.GetAllProducts().Where(p => p.Name.ToLower().Contains(strSearch.ToLower()));
            }
            return View("~/Views/Product/List.cshtml", new ProductListViewModel { Products = products, CurrentCategory = currentCategory });
        }
    }
}
