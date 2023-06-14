using customerManagement.Entities.Concrete;
using customerManagement.Models;
using customerManagement.Repositories.Abstract;
using customerManagement.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace customerManagement.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create(Guid companyId)
        {
            CustomerCreateVM customerCreateVM = new CustomerCreateVM();
            Company company = customerService.GetById(companyId);
            customerCreateVM.CompanyId = companyId;
            customerCreateVM.CompanyName = company.Name;
            return View(customerCreateVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateVM customerCreateVM)
        {
            var result =await customerService.CustomerCreate(customerCreateVM);
            customerCreateVM.Result = result;
            return View(customerCreateVM) ;
        }
    }
}
