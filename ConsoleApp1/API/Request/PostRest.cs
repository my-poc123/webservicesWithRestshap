using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.API.Request
{
    public class PostRest : Post
    {
        public PostRest(string body, ParameterType parameterType, string baseUrl,Dictionary<string,string> headers)
        {
            base.baseUrl = baseUrl;
            base.body = body;
            base.parameterType = parameterType;
            base.headers = headers;
        }
        protected override void SetParameters(string body, ParameterType parameterType)
        {
                request.AddParameter(body, parameterType);
        }
    }
}
