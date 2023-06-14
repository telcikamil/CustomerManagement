using customerManagement.Entities.Concrete;
using customerManagement.Models;

namespace customerManagement.Services.Abstract
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAllCompanies();
        public void UpdateCompany(CompanyUpdateVM companyUpdateVM);
    }
}
