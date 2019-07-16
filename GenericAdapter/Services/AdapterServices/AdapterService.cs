using GenericAdapter.MockData;
using GenericAdapter.Models;
using HttpWeaver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Collections.Common.Utilities;

namespace GenericAdapter.Services.AdapterServices
{
    public class AdapterService : IAdapterService
    {
        //private readonly HttpWeaverClient _httpWeaverClient;
        private readonly IHttpClientUtil _httpWeaverClient;
        private readonly List<MerchantEndpointModel> _merchantList= MerchantAPIModel.GetData();

        //public AdapterService(HttpWeaverClient httpWeaverClient)
        public AdapterService(IHttpClientUtil httpWeaverClient)
        {
            this._httpWeaverClient = httpWeaverClient;
        }

        /// <summary>
        /// Converts XML To JSON
        /// </summary>
        /// <param name="xmlPayload"></param>
        /// <returns></returns>
        public async Task<dynamic> ConvertXmltoJson(dynamic xmlPayload)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Merchant full API
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        public async Task<string> GetAPIUrl(long merchantId, string serviceName)
        {
            var fulllUrl = string.Empty;
            var merchant = new MerchantEndpointModel();

            try
            {
                merchant = _merchantList.Where(x => x.MerchantID == merchantId && x.ServiceName == serviceName)
                             .Select(x => x).FirstOrDefault();
                if (merchant!=null)
                {
                    fulllUrl = merchant.BaseEndpoint + merchant.UrlParts + merchant.EndpointParameters;
                    return fulllUrl;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return fulllUrl;
        }

        /// <summary>
        /// Make Http call with HTTPClient
        /// </summary>
        /// <param name="endPointURL"></param>
        /// <returns></returns>
        public async Task<string> GetPayload(int Id, string serviceName)
        {            
            var response = string.Empty;
            try
            {
                var endPointURL = await GetAPIUrl(Id, serviceName);

                if (!string.IsNullOrEmpty(endPointURL))
                {
                    var clientResponse = _httpWeaverClient.GetString(endPointURL);
                    
                    response = clientResponse;
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return response;
        }
    }
}
