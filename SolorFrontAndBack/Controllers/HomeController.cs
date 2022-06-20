using Microsoft.AspNetCore.Mvc;
using SolorFrontAndBack.DAL;
using SolorFrontAndBack.Models;
using SolorFrontAndBack.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace SolorFrontAndBack.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.sliders=_context.sliders.ToList();
            homeVM.about=_context.About.FirstOrDefault();
            homeVM.services=_context.Services.ToList();
            homeVM.team=_context.Team.ToList();
            homeVM.team2=_context.Team2.ToList();
            return View(homeVM);
        }
    }
}
