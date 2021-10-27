# IO.Swagger.Api.SearchApi

All URIs are relative to *https://api.data.amsterdam.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchList**](SearchApi.md#searchlist) | **GET** /monumenten/search/ | Zoek-Monumenten


<a name="searchlist"></a>
# **SearchList**
> void SearchList (string q)

Zoek-Monumenten

Zoek-Monumenten  Given a query parameter `q`, this function returns a subset of all monument objects that match the naam elastic search query.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchListExample
    {
        public void main()
        {
            
            var apiInstance = new SearchApi();
            var q = q_example;  // string | Search complexen/monumenten (optional) 

            try
            {
                // Zoek-Monumenten
                apiInstance.SearchList(q);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SearchApi.SearchList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Search complexen/monumenten | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

