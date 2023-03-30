using ErpCore.Business.Logic.Dtos;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http;
using System.Text;
using ErpCore.Database.Entities;
using System.Net.Http.Headers;

namespace ErpCore.WebApp.Services
{
    public class EmployeeApiClient : IEmployeeApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EmployeeApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<EmployeeModel>> GetListEmployee()
        {
            /*var sessions = _httpContextAccessor.HttpContext!.Session.GetString("access_tonken");*/
            var accessToken = _httpContextAccessor.HttpContext!.Request.Cookies["access_token"];
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refresh_token"];
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await client.GetAsync($"/api/Employee");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<EmployeeModel>>(body)!;
            return JsonConvert.DeserializeObject<List<EmployeeModel>>(body)!;
        }

        public async Task<EmployeeModel> GetEmployeeById(int id)
        {
            var sessions = _httpContextAccessor.HttpContext!.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync($"/api/users/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<EmployeeModel>(body)!;
            return JsonConvert.DeserializeObject<EmployeeModel>(body)!;
        }


    }
}
