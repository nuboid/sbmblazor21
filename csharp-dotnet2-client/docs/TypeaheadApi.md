# IO.Swagger.Api.TypeaheadApi

All URIs are relative to *https://api.data.amsterdam.nl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TypeaheadList**](TypeaheadApi.md#typeaheadlist) | **GET** /monumenten/typeahead/ | Given a query parameter &#x60;q&#x60;, this function returns a


<a name="typeaheadlist"></a>
# **TypeaheadList**
> void TypeaheadList (string q)

Given a query parameter `q`, this function returns a

Given a query parameter `q`, this function returns a subset of all objects that (partially) match the specified query.  *NOTE*  We assume spelling errors and therefore it is possible to have unexpected results  Autocomplete monumenten

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TypeaheadListExample
    {
        public void main()
        {
            
            var apiInstance = new TypeaheadApi();
            var q = q_example;  // string | Autocomplete complexen/monumenten (optional) 

            try
            {
                // Given a query parameter `q`, this function returns a
                apiInstance.TypeaheadList(q);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypeaheadApi.TypeaheadList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Autocomplete complexen/monumenten | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

