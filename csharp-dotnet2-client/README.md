# IO.Swagger - the C# library for the Monumenten lists

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.data.amsterdam.nl*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ComplexenApi* | [**ComplexenList**](docs/ComplexenApi.md#complexenlist) | **GET** /monumenten/complexen/ | 
*ComplexenApi* | [**ComplexenRead**](docs/ComplexenApi.md#complexenread) | **GET** /monumenten/complexen/{id}/ | 
*MonumentenApi* | [**MonumentenList**](docs/MonumentenApi.md#monumentenlist) | **GET** /monumenten/monumenten/ | 
*MonumentenApi* | [**MonumentenRead**](docs/MonumentenApi.md#monumentenread) | **GET** /monumenten/monumenten/{id}/ | 
*SearchApi* | [**SearchList**](docs/SearchApi.md#searchlist) | **GET** /monumenten/search/ | Zoek-Monumenten
*SitueringenApi* | [**SitueringenList**](docs/SitueringenApi.md#situeringenlist) | **GET** /monumenten/situeringen/ | De situering van een monument. Dit is ten opzichte van andere objecten in
*SitueringenApi* | [**SitueringenRead**](docs/SitueringenApi.md#situeringenread) | **GET** /monumenten/situeringen/{id}/ | De situering van een monument. Dit is ten opzichte van andere objecten in
*TypeaheadApi* | [**TypeaheadList**](docs/TypeaheadApi.md#typeaheadlist) | **GET** /monumenten/typeahead/ | Given a query parameter `q`, this function returns a


<a name="documentation-for-models"></a>
## Documentation for Models



<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: implicit
- **Authorization URL**: https://api.data.amsterdam.nl/oauth2/authorize
- **Scopes**: 
  - MON/RBC: Bevragen complexen
  - MON/RDM: Details monumenten

