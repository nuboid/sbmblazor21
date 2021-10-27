# IO.Swagger.Api.ComplexenApi

All URIs are relative to *https://api.data.amsterdam.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ComplexenList**](ComplexenApi.md#complexenlist) | **GET** /monumenten/complexen/ | 
[**ComplexenRead**](ComplexenApi.md#complexenread) | **GET** /monumenten/complexen/{id}/ | 


<a name="complexenlist"></a>
# **ComplexenList**
> void ComplexenList (int? page, int? pageSize, decimal? monumentnummerComplex, string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ComplexenListExample
    {
        public void main()
        {
            
            var apiInstance = new ComplexenApi();
            var page = 56;  // int? | A page number within the paginated result set. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var monumentnummerComplex = 8.14;  // decimal? |  (optional) 
            var id = id_example;  // string |  (optional) 

            try
            {
                apiInstance.ComplexenList(page, pageSize, monumentnummerComplex, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComplexenApi.ComplexenList: " + e.Message );
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
 **monumentnummerComplex** | **decimal?**|  | [optional] 
 **id** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="complexenread"></a>
# **ComplexenRead**
> void ComplexenRead (string id, decimal? monumentnummerComplex, string id2)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ComplexenReadExample
    {
        public void main()
        {
            
            var apiInstance = new ComplexenApi();
            var id = id_example;  // string | A unique value identifying this complex.
            var monumentnummerComplex = 8.14;  // decimal? |  (optional) 
            var id2 = id_example;  // string |  (optional) 

            try
            {
                apiInstance.ComplexenRead(id, monumentnummerComplex, id2);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ComplexenApi.ComplexenRead: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| A unique value identifying this complex. | 
 **monumentnummerComplex** | **decimal?**|  | [optional] 
 **id2** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

