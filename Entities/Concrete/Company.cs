using customerManagement.Entities.Abstract;

namespace customerManagement.Entities.Concrete
{
    public class Company : BaseEntity
    {
        public Company()
        {
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public bool IsMernisRequired { get; set; }
        public ICollection<Customer> Customers { get; set; }
        
    }
}
