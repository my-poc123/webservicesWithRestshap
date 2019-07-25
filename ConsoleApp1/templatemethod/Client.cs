using ConsoleApp1.API.Request;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.templatemethod
{
    class Client
    {
        public static void ClientCode(AbstractTemplateMethod abstractClass)
        {
            // ...
            abstractClass.TemplateMethod();
            // ...
        }

        public static IRestResponse ClientCode(RequestAbtract abstractClass)
        {
            // ...
            IRestResponse response = abstractClass.DoRequest();
            // ...
            return response;
        }
    }
}
