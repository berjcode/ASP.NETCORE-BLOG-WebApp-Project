using BlogApp.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogApp.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
            return View(); 
        }
    }
}