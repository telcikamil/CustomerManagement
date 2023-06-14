using customerManagement.AppDbContext;
using customerManagement.Entities.Concrete;
using customerManagement.Repositories.Abstract;

namespace customerManagement.Repositories.Concrete
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        private readonly ApplicationDbContext db;

        public CustomerRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
