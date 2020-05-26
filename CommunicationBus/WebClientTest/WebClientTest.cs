using Client;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBus
{
    [TestFixture]
    public class WebClientTest
    {
        [Test]
        public void WebClientKonstruktorDobriParametri()
        {
            WebClient webClient = new WebClient();
            Assert.AreEqual(UserRequest.Request, webClient.Request);
        }

        //[Test]
        //public void WebClientKonstruktorLosiParametri()
        //{
        //    Assert.Throws<ArgumentException>(() =>
        //    {
        //        WebClient webClient = new WebClient();
        //    }
        //    );
        //}

        [Test]
        public void ConvertToJsonTest()
        {
            string input = "GET /resurs/1";
            string output = "\n{\n  \"verb\": \"GET\",\n  \"noun\": \"/resurs/1\",\n}";
            WebClient wc = new WebClient();
            Assert.AreEqual(output, wc.ConvertToJson(input));
        }
    }
}
