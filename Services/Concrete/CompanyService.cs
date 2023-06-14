using customerManagement.Entities.Concrete;
using customerManagement.Models;
using customerManagement.Repositories.Abstract;
using customerManagement.Services.Abstract;

namespace customerManagement.Services.Concrete
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }
        public IEnumerable<Company> GetAllCompanies()
        {
            return companyRepository.GetAll();
        }

        public void UpdateCompany(CompanyUpdateVM companyUpdateVM)
        {
            Company company = new Company();
            company.Id = companyUpdateVM.CompanyId;
            company.IsMernisRequired = companyUpdateVM.IsMernisRequired;
            company.Name = companyUpdateVM.Name;
            companyRepository.Update(company);

        }
    }
}
