# Com.Courier - the C# library for the Courier API Reference

The Courier REST API.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.2

<a name="dependencies"></a>

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>

## Installation

TO BE UPDATED

<a name="usage"></a>

## Usage

TO BE UPDATED

<a name="getting-started"></a>

## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Courier.Api;
using Com.Courier.Client;
using Com.Courier.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesAPIApi.GetMessageById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>

## Documentation for API Endpoints

All URIs are relative to *https://api.courier.com*

| Class            | Method                                                                    | HTTP request                           | Description                        |
| ---------------- | ------------------------------------------------------------------------- | -------------------------------------- | ---------------------------------- |
| _MessagesAPIApi_ | [**GetMessageById**](docs/MessagesAPIApi.md#getmessagebyid)               | **GET** /messages/{message_id}         | GET /messages/{message_id}         |
| _MessagesAPIApi_ | [**GetMessageHistoryById**](docs/MessagesAPIApi.md#getmessagehistorybyid) | **GET** /messages/{message_id}/history | GET /messages/{message_id}/history |
| _MessagesAPIApi_ | [**GetMessageOutput**](docs/MessagesAPIApi.md#getmessageoutput)           | **GET** /messages/{message_id}/output  | GET /messages/{message_id}/output  |
| _MessagesAPIApi_ | [**GetMessages**](docs/MessagesAPIApi.md#getmessages)                     | **GET** /messages                      | GET /messages                      |
| _SendAPIApi_     | [**SendPost**](docs/SendAPIApi.md#sendpost)                               | **POST** /send                         | POST /send                         |

<a name="documentation-for-models"></a>

## Documentation for Models

- [Model.InlineResponse200](docs/InlineResponse200.md)
- [Model.InlineResponse2001](docs/InlineResponse2001.md)
- [Model.InlineResponse2002](docs/InlineResponse2002.md)
- [Model.InlineResponse2003](docs/InlineResponse2003.md)
- [Model.MessageOutputItem](docs/MessageOutputItem.md)
- [Model.MessageOutputItemContent](docs/MessageOutputItemContent.md)
- [Model.Paging](docs/Paging.md)
- [Model.PartialMessage](docs/PartialMessage.md)
- [Model.Send](docs/Send.md)

<a name="documentation-for-authorization"></a>

## Documentation for Authorization

<a name="basicAuth"></a>

### basicAuth

- **Type**: HTTP basic authentication

<a name="bearerAuth"></a>

### bearerAuth

- **Type**: Bearer Authentication
