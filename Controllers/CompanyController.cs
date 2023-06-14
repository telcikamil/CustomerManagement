using customerManagement.Entities.Concrete;
using customerManagement.Models;
using customerManagement.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace customerManagement.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;
        private readonly ICustomerService customerService;

        public CompanyController(ICompanyService companyService, ICustomerService customerService)
        {
            this.companyService = companyService;
            this.customerService = customerService;
        }

        [HttpGet] 
        public ActionResult Update(Guid companyId) 
        {
            CompanyUpdateVM companyUpdateVM = new CompanyUpdateVM();
            Company company = customerService.GetById(companyId);
            companyUpdateVM.IsMernisRequired = company.IsMernisRequired;
            companyUpdateVM.Name = company.Name;
            companyUpdateVM.CompanyId = companyId;
            return View(companyUpdateVM);
        }
        [HttpPost]
        public async Task<ActionResult> Update(CompanyUpdateVM companyUpdateVM)
        {
            companyService.UpdateCompany(companyUpdateVM);
            return View(companyUpdateVM);
        }


    }
}
