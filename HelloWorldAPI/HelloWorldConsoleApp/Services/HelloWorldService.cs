using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HelloWorldCommon.Models;
using HelloWorldCommon.Resources;
using RestSharp;

namespace HelloWorldConsoleApp.Services
{
    public class HelloWorldService
    {

        private readonly IRestClient restClient;
        private readonly IRestRequest restRequest;

        /// <summary>
        ///     Initializes a new instance of the <see cref="HelloWorldWebService" /> class.
        /// </summary>
        /// <param name="restClient">The rest client</param>
        /// <param name="restRequest">The rest request</param>
        public HelloWorldService(IRestClient restClient,
            IRestRequest restRequest)
        {
            this.restClient = restClient;
            this.restRequest = restRequest;
        }

        public HelloWorldModel GetMessage()
        {
            HelloWorldModel model = null;
            restClient.BaseUrl = new Uri(ConfigurationManager.AppSettings.Get(AppSettings.HelloWorldApiUrl));
            restRequest.Resource = "helloworld";
            restRequest.Method = Method.GET;
            restRequest.Parameters.Clear();

            try
            {
                var helloWorldResponse = restClient.Execute<HelloWorldModel>(restRequest);
                if (helloWorldResponse != null)
                {
                    if (helloWorldResponse.Data != null)
                    {
                        model = helloWorldResponse.Data;
                    }
                }
            }
            catch(Exception ex)
            {
                //Log the exception
            }
            return model;

        }
    }
}
