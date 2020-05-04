using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ByPassingFilters.Models;
using ByPassingFilters.Filters;
using ByPassingFilters.Repository;

namespace ByPassingFilters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Trend()
        {
            return Content("");
        }

        [ServiceFilter(typeof(SecurityActionFilterAttribute))]
        public IActionResult Search(string search)
        {
            if(String.IsNullOrEmpty(search))
            {
                return View("Index");
            }

            ViewBag.Search = search.Trim();

            QuoteRepository repository = new QuoteRepository();
            return View("Index", repository.Search(search.Trim()));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
