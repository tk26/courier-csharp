# Com.Courier.Api.MessagesAPIApi

All URIs are relative to *https://api.courier.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMessageById**](MessagesAPIApi.md#getmessagebyid) | **GET** /messages/{message_id} | GET /messages/{message_id}
[**GetMessageHistoryById**](MessagesAPIApi.md#getmessagehistorybyid) | **GET** /messages/{message_id}/history | GET /messages/{message_id}/history
[**GetMessageOutput**](MessagesAPIApi.md#getmessageoutput) | **GET** /messages/{message_id}/output | GET /messages/{message_id}/output
[**GetMessages**](MessagesAPIApi.md#getmessages) | **GET** /messages | GET /messages


<a name="getmessagebyid"></a>
# **GetMessageById**
> Object GetMessageById (string messageId)

GET /messages/{message_id}

Fetch the status of a message you've previously sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class GetMessageByIdExample
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

            var apiInstance = new MessagesAPIApi(config);
            var messageId = messageId_example;  // string | A unique identifier associated with the message you wish to retrieve (results from a send). (default to "1-5e2b2615-05efbb3acab9172f88dd3f6f")

            try
            {
                // GET /messages/{message_id}
                Object result = apiInstance.GetMessageById(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesAPIApi.GetMessageById: " + e.Message );
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
 **messageId** | **string**| A unique identifier associated with the message you wish to retrieve (results from a send). | [default to &quot;1-5e2b2615-05efbb3acab9172f88dd3f6f&quot;]

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagehistorybyid"></a>
# **GetMessageHistoryById**
> InlineResponse2002 GetMessageHistoryById (string messageId, string type = null)

GET /messages/{message_id}/history

Fetch the array of events of a message you've previously sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class GetMessageHistoryByIdExample
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

            var apiInstance = new MessagesAPIApi(config);
            var messageId = messageId_example;  // string | A unique identifier associated with the message you wish to retrieve (results from a send). (default to "1-5e2b2615-05efbb3acab9172f88dd3f6f")
            var type = type_example;  // string | A supported Message History type that will filter the events returned. (optional) 

            try
            {
                // GET /messages/{message_id}/history
                InlineResponse2002 result = apiInstance.GetMessageHistoryById(messageId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesAPIApi.GetMessageHistoryById: " + e.Message );
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
 **messageId** | **string**| A unique identifier associated with the message you wish to retrieve (results from a send). | [default to &quot;1-5e2b2615-05efbb3acab9172f88dd3f6f&quot;]
 **type** | **string**| A supported Message History type that will filter the events returned. | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessageoutput"></a>
# **GetMessageOutput**
> InlineResponse2003 GetMessageOutput (string messageId)

GET /messages/{message_id}/output

Fetch the output of rendered events of a message you've previously sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class GetMessageOutputExample
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

            var apiInstance = new MessagesAPIApi(config);
            var messageId = messageId_example;  // string | A unique identifier associated with the message you wish to retrieve (results from a send). (default to "1-5e2b2615-05efbb3acab9172f88dd3f6f")

            try
            {
                // GET /messages/{message_id}/output
                InlineResponse2003 result = apiInstance.GetMessageOutput(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesAPIApi.GetMessageOutput: " + e.Message );
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
 **messageId** | **string**| A unique identifier associated with the message you wish to retrieve (results from a send). | [default to &quot;1-5e2b2615-05efbb3acab9172f88dd3f6f&quot;]

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessages"></a>
# **GetMessages**
> InlineResponse2001 GetMessages (string cursor = null, string _event = null, string list = null, string messageId = null, string notification = null, string recipient = null, string status = null)

GET /messages

Fetch the statuses of messages you've previously sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class GetMessagesExample
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

            var apiInstance = new MessagesAPIApi(config);
            var cursor = MTU4OTQ5NTI1ODY4NywxLTVlYmRjNWRhLTEwODZlYWFjMWRmMjEwMTNjM2I0ZjVhMA==;  // string | A unique identifier that allows for fetching the next set of message statuses. (optional) 
            var _event = welcome-message;  // string | A unique identifier representing the event that was used to send the event. (optional) 
            var list = event-change;  // string | A unique identifier representing the list the message was sent to. (optional) 
            var messageId = 1-5fa64f03-2a3d64b92a1f1a061ab4c3c3;  // string | A unique identifier representing the `message_id` returned from either /send or /send/list. (optional) 
            var notification = 1-5fa64f03-2a3d64b92a1f1a061ab4c3c3;  // string | A unique identifier representing the notification that was used to send the event. (optional) 
            var recipient = 0460766e-8463-4905-ae98-b72c7aef41d6;  // string | A unique identifier representing the recipient associated with the requested profile. (optional) 
            var status = OPENED;  // string | An indicator of the current status of the message. Multiple status values can be passed in. (optional) 

            try
            {
                // GET /messages
                InlineResponse2001 result = apiInstance.GetMessages(cursor, _event, list, messageId, notification, recipient, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesAPIApi.GetMessages: " + e.Message );
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
 **cursor** | **string**| A unique identifier that allows for fetching the next set of message statuses. | [optional] 
 **_event** | **string**| A unique identifier representing the event that was used to send the event. | [optional] 
 **list** | **string**| A unique identifier representing the list the message was sent to. | [optional] 
 **messageId** | **string**| A unique identifier representing the &#x60;message_id&#x60; returned from either /send or /send/list. | [optional] 
 **notification** | **string**| A unique identifier representing the notification that was used to send the event. | [optional] 
 **recipient** | **string**| A unique identifier representing the recipient associated with the requested profile. | [optional] 
 **status** | **string**| An indicator of the current status of the message. Multiple status values can be passed in. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[basicAuth](../README.md#basicAuth), [bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

