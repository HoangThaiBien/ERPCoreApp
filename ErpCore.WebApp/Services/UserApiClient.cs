using ErpCore.Business.Logic.Dtos;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;

namespace ErpCore.WebApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
       

        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
           
        }
            
        public async Task<TokenModel> Authenticate(LoginModel model)
        {
            var httpContent = new StringContent(JsonSerializer.Serialize(model), Encoding.UTF8, Application.Json);
            
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            var response = await client.PostAsync("/api/Authenticate/Login", httpContent);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var tokenModel = JsonSerializer.Deserialize<TokenModel>(jsonString);
                return tokenModel!;
            }
            return null!;
            /*var json = await response.Content.ReadAsStringAsync();
            var tokenModel = JsonSerializer.Deserialize<TokenModel>(json)!;
            return json;*/
        }

    }
}
