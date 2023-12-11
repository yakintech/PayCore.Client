using PayCore.Client.models.product;
using PayCore.Client.models.token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCore.Client.services
{
    public class TokenService
    {
        public async Task<LoginResponseModel> Login(LoginRequestModel model)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381");

            HttpResponseMessage response = await client.PostAsJsonAsync("/api/token", model);

            var responseData = await response.Content.ReadAsAsync<LoginResponseModel>();

            return responseData;
           
        }
    }
}
