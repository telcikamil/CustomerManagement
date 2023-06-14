using customerManagement.Entities.Concrete;
using customerManagement.Models;
using customerManagement.Repositories.Abstract;
using customerManagement.Services.Abstract;

namespace customerManagement.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ICompanyRepository companyRepository;
        private readonly IRequiredMernisService requiredMernisService;

        public CustomerService(ICustomerRepository customerRepository,ICompanyRepository companyRepository,IRequiredMernisService requiredMernisService)
        {
            this.customerRepository = customerRepository;
            this.companyRepository = companyRepository;
            this.requiredMernisService = requiredMernisService;
        }
        public async Task<string> CustomerCreate(CustomerCreateVM customerCreateVM)
        {
            var currentCompany = companyRepository.GetById(customerCreateVM.CompanyId);
            Customer customer = new Customer();
            customer.FirstName = customerCreateVM.FirstName;
            customer.LastName = customerCreateVM.LastName;
            customer.identityNumber = customerCreateVM.identityNumber;
            customer.BirtDay = customerCreateVM.BirtDay;
            customer.companies.Add(currentCompany);

            if (currentCompany.IsMernisRequired == true)
            {
                var mernisResult = requiredMernisService.MernisResult(customer);

                if (mernisResult)
                {
                    customerRepository.Add(customer);
                }
                else
                {
                    return "Mernis doğrulaması başarısız, kişi eklenemedi";
                }
            }
            else
            {
                customerRepository.Add(customer);
            }

            return "Kişi başarıyla eklendi";
        }

        public Company GetById(Guid id)
        {
            return companyRepository.GetById(id);
        }
    }
}
