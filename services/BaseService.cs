using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.services
{
    public class BaseService
    {
        string token;
        public HttpClient httpClient;
        public BaseService(string token)
        {
            this.token = token;
            this.httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            httpClient.BaseAddress = new Uri("https://localhost:44381");
        }
    }
}
