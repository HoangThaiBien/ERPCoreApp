using ErpCore.Business.Logic.Dtos;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Net.Http;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Common.Shared.Model;
using Newtonsoft.Json;

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
            var httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, Application.Json);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            var response = await client.PostAsync($"/api/Authenticate/Login", httpContent);
            var jsonString = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<TokenModel>(jsonString)!;
            
            return JsonConvert.DeserializeObject<TokenModel>(jsonString)!;
        }

        public async Task<bool> RegisterUser(RegisterModel model)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            var httpContent = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, Application.Json);
            var response = await client.PostAsync($"/api/Authenticate/Register", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
