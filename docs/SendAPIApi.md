# Com.Courier.Api.SendAPIApi

All URIs are relative to *https://api.courier.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SendPost**](SendAPIApi.md#sendpost) | **POST** /send | POST /send


<a name="sendpost"></a>
# **SendPost**
> InlineResponse200 SendPost (Send send = null)

POST /send

Send a notification to a specified recipient.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class SendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.courier.com";
            // Configure HTTP basic authorization: basicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SendAPIApi(config);
            var send = new Send(); // Send |  (optional) 

            try
            {
                // POST /send
                InlineResponse200 result = apiInstance.SendPost(send);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SendAPIApi.SendPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **send** | [**Send**](Send.md)|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

