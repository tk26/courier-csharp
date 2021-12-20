# Com.Courier.Model.PartialMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier associated with the message you wish to retrieve (results from a send). | [optional] [default to "1-5e2b2615-05efbb3acab9172f88dd3f6f"]
**Status** | **string** |  | [optional] 
**Enqueued** | **int** | A UTC timestamp at which Courier received the message request. This is stored as a millisecond representation of the Unix epoch (the time passed since January 1, 1970). | [optional] 
**Sent** | **int** | A UTC timestamp at which Courier passed the message to the Integration provider. This is stored as a millisecond representation of the Unix epoch (the time passed since January 1, 1970). | [optional] 
**Delivered** | **int** | A UTC timestamp at which the Integration provider delivered the message. This is stored as a millisecond representation of the Unix epoch (the time passed since January 1, 1970). | [optional] 
**Opened** | **int** | A UTC timestamp at which the recipient opened a message for the first time. This is stored as a millisecond representation of the Unix epoch (the time passed since January 1, 1970). | [optional] 
**Clicked** | **int** | A UTC timestamp at which the recipient clicked on a tracked link for the first time. This is stored as a millisecond representation of the Unix epoch (the time passed since January 1, 1970). | [optional] 
**Recipient** | **string** | A unique identifier associated with the recipient of the delivered message. | [optional] [default to "CC607F6E84A34305AE98B72C"]
**Event** | **string** | A unique identifier associated with the event of the delivered message. | [optional] [default to "my-event"]
**Notification** | **string** | A unique identifier associated with the notification of the delivered message. | [optional] [default to "TAFGNB3GNQ4MZVHW4WV4R8Q8ZVN4"]
**Error** | **string** | A message describing the error that occurred. | [optional] [default to "400 Bad Request"]
**Reason** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

