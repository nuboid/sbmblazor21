using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITypeaheadApi
    {
        /// <summary>
        /// Given a query parameter &#x60;q&#x60;, this function returns a Given a query parameter &#x60;q&#x60;, this function returns a subset of all objects that (partially) match the specified query.  *NOTE*  We assume spelling errors and therefore it is possible to have unexpected results  Autocomplete monumenten
        /// </summary>
        /// <param name="q">Autocomplete complexen/monumenten</param>
        /// <returns></returns>
        void TypeaheadList (string q);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TypeaheadApi : ITypeaheadApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeaheadApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TypeaheadApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeaheadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TypeaheadApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Given a query parameter &#x60;q&#x60;, this function returns a Given a query parameter &#x60;q&#x60;, this function returns a subset of all objects that (partially) match the specified query.  *NOTE*  We assume spelling errors and therefore it is possible to have unexpected results  Autocomplete monumenten
        /// </summary>
        /// <param name="q">Autocomplete complexen/monumenten</param> 
        /// <returns></returns>            
        public void TypeaheadList (string q)
        {
            
    
            var path = "/monumenten/typeahead/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TypeaheadList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TypeaheadList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
