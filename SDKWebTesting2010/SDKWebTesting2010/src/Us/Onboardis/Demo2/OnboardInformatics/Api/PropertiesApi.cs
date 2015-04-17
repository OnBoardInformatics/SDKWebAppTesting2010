using System;
using System.Diagnostics;
using System.Collections.Generic;
using Us.Onboardis.Demo2.OnboardInformatics;

namespace Us.Onboardis.Demo2.OnboardInformatics.Api {
  public class PropertiesApi {
    string basePath;
    private readonly ApiInvoker apiInvoker = ApiInvoker.GetInstance();

    public PropertiesApi(String basePath = "http://demo2.onboardis.us")
    {
      this.basePath = basePath;
    }

    public ApiInvoker getInvoker()
    {
      return apiInvoker;
    }

    // Sets the endpoint base url for the services being accessed
    public void setBasePath(string basePath)
    {
      this.basePath = basePath;
    }

    // Gets the endpoint base url for the services being accessed
    public String getBasePath()
    {
      return basePath;
    }

    

    /// <summary>
    ///   Summaries
    /// </summary>
    /// <param name="point">Point</param>
    /// <param name="radius">Radius</param>
    /// <param name="unit">Unit</param>
    /// <param name="page">Page</param>
    /// <param name="size">Size</param>
    /// <param name="filter">Filter</param>
    /// <returns></returns>
    public string Summaries (string point, string radius, string unit, string page, string size, string filter) {
      // create path and map variables
      var path = "/properties/summaries/radius";

      // query params
      var queryParams = new Dictionary<String, String>();
      var headerParams = new Dictionary<String, String>();
      var formParams = new Dictionary<String, object>();

      if (point != null){
        queryParams.Add("point", ApiInvoker.parameterToString(point));
      }
      if (radius != null){
        queryParams.Add("radius", ApiInvoker.parameterToString(radius));
      }
      if (unit != null){
        queryParams.Add("unit", ApiInvoker.parameterToString(unit));
      }
      if (page != null){
        queryParams.Add("page", ApiInvoker.parameterToString(page));
      }
      if (size != null){
        queryParams.Add("size", ApiInvoker.parameterToString(size));
      }
      if (filter != null){
        queryParams.Add("filter", ApiInvoker.parameterToString(filter));
      }
    // authentication setting
    bool requireAuth = false;

      try {
        if (typeof(void) == typeof(byte[])) {
          var response = apiInvoker.invokeBinaryAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          Debug.Write("Summaries response: " + response.ToString());
          return response.ToString();
        } else {
          var response = apiInvoker.invokeAPI(basePath, path, "GET", queryParams, null, headerParams, formParams, requireAuth);
          if(response != null){
              return response.ToString();
          }
          else {
              return response.ToString();
          }
        }
      } catch (ApiException ex) {
        if(ex.ErrorCode == 404) {
          return ex.Message;
        }
        else {
          throw ex;
        }
      }
    }

  }
}

