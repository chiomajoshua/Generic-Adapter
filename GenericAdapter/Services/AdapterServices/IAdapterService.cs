using System.Threading.Tasks;

namespace GenericAdapter.Services.AdapterServices
{
    public interface IAdapterService
    {
        Task<string> GetAPIUrl(long merchantId, string serviceName);
        Task<dynamic> ConvertXmltoJson(dynamic xmlPayload);
        //Task<dynamic> serialiazeJson(dynamic jsonPayload);

        Task<string> GetPayload(int Id, string serviceName);
    }
}
