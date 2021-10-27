# IO.Swagger.Api.SitueringenApi

All URIs are relative to *https://api.data.amsterdam.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SitueringenList**](SitueringenApi.md#situeringenlist) | **GET** /monumenten/situeringen/ | De situering van een monument. Dit is ten opzichte van andere objecten in
[**SitueringenRead**](SitueringenApi.md#situeringenread) | **GET** /monumenten/situeringen/{id}/ | De situering van een monument. Dit is ten opzichte van andere objecten in


<a name="situeringenlist"></a>
# **SitueringenList**
> void SitueringenList (int? page, int? pageSize, string monumentId, string betreftNummeraanduiding, string id)

De situering van een monument. Dit is ten opzichte van andere objecten in

De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SitueringenListExample
    {
        public void main()
        {
            
            var apiInstance = new SitueringenApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var monumentId = monumentId_example;  // string |  (optional) 
            var betreftNummeraanduiding = betreftNummeraanduiding_example;  // string |  (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                // De situering van een monument. Dit is ten opzichte van andere objecten in
                apiInstance.SitueringenList(page, pageSize, monumentId, betreftNummeraanduiding, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SitueringenApi.SitueringenList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| A page number within the paginated result set. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **monumentId** | **string**|  | [optional] 
 **betreftNummeraanduiding** | **string**|  | [optional] 
 **id** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="situeringenread"></a>
# **SitueringenRead**
> void SitueringenRead (int? id, string monumentId, string betreftNummeraanduiding, string id2)

De situering van een monument. Dit is ten opzichte van andere objecten in

De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SitueringenReadExample
    {
        public void main()
        {
            
            var apiInstance = new SitueringenApi();
            var id = 56;  // int? | A unique integer value identifying this situering.
            var monumentId = monumentId_example;  // string |  (optional) 
            var betreftNummeraanduiding = betreftNummeraanduiding_example;  // string |  (optional) 
            var id2 = id_example;  // string |  (optional) 

            try
            {
                // De situering van een monument. Dit is ten opzichte van andere objecten in
                apiInstance.SitueringenRead(id, monumentId, betreftNummeraanduiding, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SitueringenApi.SitueringenRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| A unique integer value identifying this situering. | 
 **monumentId** | **string**|  | [optional] 
 **betreftNummeraanduiding** | **string**|  | [optional] 
 **id2** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

