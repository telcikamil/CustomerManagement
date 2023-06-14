using customerManagement.Entities.Concrete;
using customerManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace customerManagement.Services.Abstract
{
    public interface ICustomerService
    {
        public Task<string> CustomerCreate(CustomerCreateVM customerCreateVM);
        Company GetById(Guid id);
    }

}
