using customerManagement.AppDbContext;
using customerManagement.Entities.Abstract;
using customerManagement.Entities.Concrete;
using customerManagement.Repositories.Abstract;

namespace customerManagement.Repositories.Concrete
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
