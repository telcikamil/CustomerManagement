using customerManagement.Entities.Concrete;

namespace customerManagement.Services.Abstract
{
    public interface IRequiredMernisService
    {
        bool MernisResult(Customer customer);
    }
}
