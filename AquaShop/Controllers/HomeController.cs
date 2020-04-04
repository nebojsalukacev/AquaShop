using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AquaShop.Data.Interfaces;
using AquaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AquaShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;
        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public ViewResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                PrefferedProducts = productRepository.PrefferedProducts
            };
            return View(homeViewModel);
        }
    }
}