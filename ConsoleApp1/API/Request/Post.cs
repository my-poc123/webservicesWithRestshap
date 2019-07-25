using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.API.Request
{
    public abstract class Post : RequestAbtract
    {
        protected override void CreateRequest()
        {
            request = new RestRequest(Method.POST);
        }
    }
}
