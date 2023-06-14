using customerManagement.Models;
using customerManagement.Services.Abstract;
using customerManagement.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace customerManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICompanyService companyService;

        public HomeController(ILogger<HomeController> logger,ICompanyService companyService)
        {
            _logger = logger;
            this.companyService = companyService;
        }

        public IActionResult Index()
        {
            CompanyIndexVM companyIndexVM = new CompanyIndexVM();
            companyIndexVM.Companies = companyService.GetAllCompanies();
            return View(companyIndexVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}