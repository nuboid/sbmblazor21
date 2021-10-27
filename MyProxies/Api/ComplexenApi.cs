using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IComplexenApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="page">A page number within the paginated result set.</param>
        /// <param name="pageSize">Number of results to return per page.</param>
        /// <param name="monumentnummerComplex"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        void ComplexenList (int? page, int? pageSize, decimal? monumentnummerComplex, string id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id">A unique value identifying this complex.</param>
        /// <param name="monumentnummerComplex"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        void ComplexenRead (string id, decimal? monumentnummerComplex, string id2);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ComplexenApi : IComplexenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ComplexenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ComplexenApi(String basePath)
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
        ///  
        /// </summary>
        /// <param name="page">A page number within the paginated result set.</param> 
        /// <param name="pageSize">Number of results to return per page.</param> 
        /// <param name="monumentnummerComplex"></param> 
        /// <param name="id"></param> 
        /// <returns></returns>            
        public void ComplexenList (int? page, int? pageSize, decimal? monumentnummerComplex, string id)
        {
            
    
            var path = "/monumenten/complexen/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (monumentnummerComplex != null) queryParams.Add("monumentnummer_complex", ApiClient.ParameterToString(monumentnummerComplex)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ComplexenList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComplexenList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id">A unique value identifying this complex.</param> 
        /// <param name="monumentnummerComplex"></param> 
        /// <param name="id2"></param> 
        /// <returns></returns>            
        public void ComplexenRead (string id, decimal? monumentnummerComplex, string id2)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ComplexenRead");
            
    
            var path = "/monumenten/complexen/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (monumentnummerComplex != null) queryParams.Add("monumentnummer_complex", ApiClient.ParameterToString(monumentnummerComplex)); // query parameter
 if (id2 != null) queryParams.Add("id", ApiClient.ParameterToString(id2)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ComplexenRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ComplexenRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
