using customerManagement.Entities.Abstract;

namespace customerManagement.Entities.Concrete
{
    public class Customer:BaseEntity
    {
        public Customer()
        {
            companies = new HashSet<Company>();
        }
        public long identityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirtDay { get; set; }
        public ICollection<Company> companies { get; set; }
    }
}
