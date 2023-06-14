using customerManagement.Entities.Concrete;
using customerManagement.Repositories.Abstract;
using customerManagement.Services.Abstract;

namespace customerManagement.Services.Concrete
{
    public class RequiredMernisService : IRequiredMernisService
    {
        public bool MernisResult(Customer customer)
        {
            var client = new MernisService.KPSPublicSoapClient(MernisService.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.identityNumber), customer.FirstName, customer.LastName, customer.BirtDay.Year).Result;
            var result = response.Body.TCKimlikNoDogrulaResult;
            return result;
        }

    }
}