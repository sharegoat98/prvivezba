using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public interface IWebClient
    {
        string Request { get; set; }
        string Verb { get; set; }
        string Noun { get; set; }

        string JsonRequest { get; set; }

        string ConvertToJson(string req);
    }
}
