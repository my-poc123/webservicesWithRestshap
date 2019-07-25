using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.API.Request
{
    public abstract class RequestAbtract
    {
        public RestClient client { get; set; }

        public RestRequest request { get; set; }

        public Dictionary<string, string> headers { get; set; }
        public ParameterType parameterType { get;  set; }
        public string body { get; set; }

        public string  baseUrl { get; set; }

        public IRestResponse DoRequest()
        {
            this.CreateClient(baseUrl);
            this.CreateRequest();
            this.SetHeaders(headers);
            this.SetParameters(body, parameterType);
           return  this.ExecuteRequest();
        }

        protected void CreateClient(string url)
        {
            client = new RestClient(url);
        }

        protected abstract void CreateRequest();

        protected void SetHeaders(Dictionary<string,string> headers)
        {
            foreach (var pair in headers)
            {
                request.AddHeader(pair.Key, pair.Value);
            }
        }

        protected abstract void SetParameters(string body, ParameterType parameterType);

        protected IRestResponse ExecuteRequest()
        {
            var response = client.Execute(request);
            return response;
        }
    }
}
