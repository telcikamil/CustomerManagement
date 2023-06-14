using customerManagement.Entities.Concrete;

namespace customerManagement.Models
{
    public class CompanyIndexVM
    {
        public IEnumerable<Company> Companies { get; set; }
    }
}
