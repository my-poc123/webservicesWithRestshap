using ConsoleApp1.API.Request;
using ConsoleApp1.templatemethod;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Same client code can work with different subclasses:");

            //Client.ClientCode(new ConcretClass1("hola",1));

            //Console.Write("\n");

            //Console.WriteLine("Same client code can work with different subclasses:");
            //Client.ClientCode(new ConcretClass2cs());

            //Console.WriteLine("End");
            //////string baseurl = "https://www.pivotaltracker.com/services/v5/projects";
            //////Dictionary<string, string> headers = new Dictionary<string, string>();
            //////headers.Add("X-TrackerToken", "177fdb95f026c3fb543b20e5e8c51e46");
            //////headers.Add("Content-Type", "application/json");


            //////IRestResponse res = Client.ClientCode(new PostRest("{\n\t\"name\":\"test1234\"\n}", ParameterType.RequestBody, baseurl, headers));
            //////Console.WriteLine(res.ResponseStatus.ToString());


            var client = new RestClient("https://www.pivotaltracker.com/services/v5/projects");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Host", "www.pivotaltracker.com");
            request.AddHeader("X-TrackerToken", "177fdb95f026c3fb543b20e5e8c51e46");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\n\t\"name\":\"Executioner123\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content.ToString());

        }
    }
}
