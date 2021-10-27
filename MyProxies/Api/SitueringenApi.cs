using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISitueringenApi
    {
        /// <summary>
        /// De situering van een monument. Dit is ten opzichte van andere objecten in De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte
        /// </summary>
        /// <param name="page">A page number within the paginated result set.</param>
        /// <param name="pageSize">Number of results to return per page.</param>
        /// <param name="monumentId"></param>
        /// <param name="betreftNummeraanduiding"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        void SitueringenList (int? page, int? pageSize, string monumentId, string betreftNummeraanduiding, string id);
        /// <summary>
        /// De situering van een monument. Dit is ten opzichte van andere objecten in De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte
        /// </summary>
        /// <param name="id">A unique integer value identifying this situering.</param>
        /// <param name="monumentId"></param>
        /// <param name="betreftNummeraanduiding"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        void SitueringenRead (int? id, string monumentId, string betreftNummeraanduiding, string id2);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SitueringenApi : ISitueringenApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitueringenApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SitueringenApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SitueringenApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SitueringenApi(String basePath)
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
        /// De situering van een monument. Dit is ten opzichte van andere objecten in De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte
        /// </summary>
        /// <param name="page">A page number within the paginated result set.</param> 
        /// <param name="pageSize">Number of results to return per page.</param> 
        /// <param name="monumentId"></param> 
        /// <param name="betreftNummeraanduiding"></param> 
        /// <param name="id"></param> 
        /// <returns></returns>            
        public void SitueringenList (int? page, int? pageSize, string monumentId, string betreftNummeraanduiding, string id)
        {
            
    
            var path = "/monumenten/situeringen/";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (pageSize != null) queryParams.Add("page_size", ApiClient.ParameterToString(pageSize)); // query parameter
 if (monumentId != null) queryParams.Add("monument_id", ApiClient.ParameterToString(monumentId)); // query parameter
 if (betreftNummeraanduiding != null) queryParams.Add("betreft_nummeraanduiding", ApiClient.ParameterToString(betreftNummeraanduiding)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SitueringenList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SitueringenList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// De situering van een monument. Dit is ten opzichte van andere objecten in De situering van een monument. Dit is ten opzichte van andere objecten in de openbare ruimte
        /// </summary>
        /// <param name="id">A unique integer value identifying this situering.</param> 
        /// <param name="monumentId"></param> 
        /// <param name="betreftNummeraanduiding"></param> 
        /// <param name="id2"></param> 
        /// <returns></returns>            
        public void SitueringenRead (int? id, string monumentId, string betreftNummeraanduiding, string id2)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SitueringenRead");
            
    
            var path = "/monumenten/situeringen/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (monumentId != null) queryParams.Add("monument_id", ApiClient.ParameterToString(monumentId)); // query parameter
 if (betreftNummeraanduiding != null) queryParams.Add("betreft_nummeraanduiding", ApiClient.ParameterToString(betreftNummeraanduiding)); // query parameter
 if (id2 != null) queryParams.Add("id", ApiClient.ParameterToString(id2)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SitueringenRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SitueringenRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
