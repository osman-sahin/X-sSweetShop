using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using X_sSweetShop.Models;
using X_sSweetShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace X_sSweetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
