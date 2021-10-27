# IO.Swagger.Api.MonumentenApi

All URIs are relative to *https://api.data.amsterdam.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MonumentenList**](MonumentenApi.md#monumentenlist) | **GET** /monumenten/monumenten/ | 
[**MonumentenRead**](MonumentenApi.md#monumentenread) | **GET** /monumenten/monumenten/{id}/ | 


<a name="monumentenlist"></a>
# **MonumentenList**
> void MonumentenList (int? page, int? pageSize, string betreftPand, string locatie, string complexId, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MonumentenListExample
    {
        public void main()
        {
            
            var apiInstance = new MonumentenApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var betreftPand = betreftPand_example;  // string |  (optional) 
            var locatie = locatie_example;  // string |  (optional) 
            var complexId = complexId_example;  // string |  (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                apiInstance.MonumentenList(page, pageSize, betreftPand, locatie, complexId, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonumentenApi.MonumentenList: " + e.Message );
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
 **betreftPand** | **string**|  | [optional] 
 **locatie** | **string**|  | [optional] 
 **complexId** | **string**|  | [optional] 
 **id** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monumentenread"></a>
# **MonumentenRead**
> void MonumentenRead (string id, string betreftPand, string locatie, string complexId, string id2)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MonumentenReadExample
    {
        public void main()
        {
            
            var apiInstance = new MonumentenApi();
            var id = id_example;  // string | A unique value identifying this monument.
            var betreftPand = betreftPand_example;  // string |  (optional) 
            var locatie = locatie_example;  // string |  (optional) 
            var complexId = complexId_example;  // string |  (optional) 
            var id2 = id_example;  // string |  (optional) 

            try
            {
                apiInstance.MonumentenRead(id, betreftPand, locatie, complexId, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonumentenApi.MonumentenRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this monument. | 
 **betreftPand** | **string**|  | [optional] 
 **locatie** | **string**|  | [optional] 
 **complexId** | **string**|  | [optional] 
 **id2** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

