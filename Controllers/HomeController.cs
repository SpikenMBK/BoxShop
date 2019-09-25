using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BoxShop.Models;
using BoxShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoxShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGlovesRepository _glovesRepository;

        public HomeController(IGlovesRepository glovesRepository )
        {
             _glovesRepository = glovesRepository;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var gloves = _glovesRepository.GetAllGloves().OrderBy(p => p.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "VÄLKOMMEN TILL BOXINGSHOP",
                Gloves = gloves.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var gloves = _glovesRepository.GetGlovesById(id);
            if (gloves == null)
                return NotFound();
            return View(gloves);
        }
    }
}
