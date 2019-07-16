namespace GenericAdapter.Models
{
    public class MerchantEndpointModel
    {
        public int ID { get; set; }
        public int MerchantID { get; set; }
        public string BaseEndpoint { get; set; }
        public string ServiceName { get; set; }
        public string UrlParts { get; set; }
        public string EndpointParameters { get; set; }
        public string CollectionKey { get; set; }
    }
}