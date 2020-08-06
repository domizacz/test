using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLabrary
{
    public class ApiHelper
    {
        public static HttpClient APiClient { get; set; }
    public static void InitializeClient()
        {
            APiClient = new HttpClient();
            APiClient.DefaultRequestHeaders.Accept.Clear();
            APiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
