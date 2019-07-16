using GenericAdapter.Models;
using System.Collections.Generic;

namespace GenericAdapter.MockData
{
    public static class MerchantAPIModel
    {
        public static List<MerchantEndpointModel> GetData() => new List<MerchantEndpointModel>
        {
            new MerchantEndpointModel {
                    ID = 1,
                    MerchantID = 1,
                    BaseEndpoint = "https://reqres.in/",
                    ServiceName = "SingleUser",
                    UrlParts = "api/users/",
                    CollectionKey = "1yjj3j37v9jchcidjdp29389292",
                    EndpointParameters = "2"
            },
            new MerchantEndpointModel {
                    ID = 2,
                    MerchantID = 1,
                    BaseEndpoint = "https://reqres.in/",
                    ServiceName = "ListUser",
                    UrlParts = "api/users?",
                    CollectionKey = "yyuwu8373827822h2nkdkdj2",
                    EndpointParameters = "page=2"
            },
            new MerchantEndpointModel {
                    ID = 3,
                    MerchantID = 1,
                    BaseEndpoint = "https://reqres.in/",
                    ServiceName = "ListResource",
                    UrlParts = "api/unknown/",
                    CollectionKey = "hb38373hdnj9keyehsji22",
                    EndpointParameters = ""
            },
            new MerchantEndpointModel {
                    ID = 4,
                    MerchantID = 1,
                    BaseEndpoint = "https://reqres.in/",
                    ServiceName = "SingleResource",
                    UrlParts = "api/unknown/",
                    CollectionKey = "yyuu37883nn3737hnssuw2",
                    EndpointParameters = "2"
            },
            new MerchantEndpointModel {
                    ID = 5,
                    MerchantID = 2,
                    BaseEndpoint = "http://reg.run.edu.ng/",
                    ServiceName = "GetStudentProfile",
                    UrlParts = "get_stud_profile.php?",
                    CollectionKey = "yyuu37883nn3737hnssuw2",
                    EndpointParameters = string.Format($"mat={0}&pwd={1}")
            }


            //http://reg.run.edu.ng/get_stud_profile.php?mat=RUN/CMP/14/5798&pwd=RUN/CMP/14/5798
        };
    }
}
