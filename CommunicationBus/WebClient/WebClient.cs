using Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClient;

namespace CommunicationBus
{
    public class WebClient : IWebClient
    {
        public string Request { get; set; }
        public string Verb { get; set; }
        public string Noun { get; set; }
        public string JsonRequest { get; set; }

        public WebClient()
        {
            Request = UserRequest.Request;
        }

        public string ConvertToJson(string req)
        {
            Verb = req.Split(' ')[0];
            Noun = req.Split(' ')[1];
            //Verb = method;
            //Noun = resource;
            JsonRequest = "\n{";
            JsonRequest += "\n  \"verb\": " + "\"" + Verb + "\",\n  " +
                "\"noun\": " + "\"" + Noun + "\",\n";
            JsonRequest += "}";
            return JsonRequest;
        }
    }
}
