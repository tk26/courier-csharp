# Com.Courier.Model.Send

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | A unique identifier that can be mapped to an individual Notification. This could be the \&quot;Notification ID” on Notification detail pages (see the [Notifications page](https://app.courier.com/designer/notifications) in the Courier app) or a custom string mapped to the event in [settings](https://app.courier.com/settings/events). | [default to "EXAMPLE_NOTIFICATION"]
**Recipient** | **string** | A unique identifier associated with the recipient of the delivered message. | [default to "8ec8c99a-c5f7-455b-9f60-8222b8a27056"]
**Brand** | **string** | A unique identifier that represents the brand that should be used for rendering the notification. | [optional] [default to "W50NC77P524K14M5300PGPEK4JMJ"]
**Data** | **string** | An object that includes any data you want to pass to a message template. The data will populate the corresponding template variables. | [optional] 
**Override** | **string** | An object that is merged into the request sent by Courier to the provider to override properties or to gain access to features in the provider API that are not natively supported by Courier. | [optional] 
**Preferences** | **string** | An object that includes any preferences for the recipient. | [optional] 
**Profile** | **string** | An object that includes any key-value pairs required by your chosen Integrations (see our [Provider Documentation](https://docs.courier.com/docs) for the requirements for each Integration.) If profile information is included in the request and that information already exists in the profile for the recipientId, that information will be merged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

