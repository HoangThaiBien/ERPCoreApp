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
            var accessToken = _httpContextAccessor.HttpContext!.Request.Cookies["access_token"];
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refresh_token"];
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await client.GetAsync($"/api/Employee/Details/{id}");
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<EmployeeModel>(body)!;
            return JsonConvert.DeserializeObject<EmployeeModel>(body)!;
        }


        public async Task<bool> CreateEmployee(EmployeeModel model)
        {
            var accessToken = _httpContextAccessor.HttpContext!.Request.Cookies["access_token"];
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refresh_token"];
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var requestContent = new MultipartFormDataContent();

            if (model.CoverImageFilePath != null)
            {
                using var ms = new MemoryStream();
                await model.CoverImageFilePath.CopyToAsync(ms);
                var coverImageContent = new ByteArrayContent(ms.ToArray());
                requestContent.Add(coverImageContent, "CoverImageFilePath", model.CoverImageFilePath.FileName);
            }

            if (model.AvatarFilePath != null)
            {
                using var ms = new MemoryStream();
                await model.AvatarFilePath.CopyToAsync(ms);
                var avatarContent = new ByteArrayContent(ms.ToArray());
                requestContent.Add(avatarContent, "AvatarFilePath", model.AvatarFilePath.FileName);
            }

            requestContent.Add(new StringContent(model.FirstName ?? string.Empty), "FirstName");
            requestContent.Add(new StringContent(model.LastName ?? string.Empty), "LastName");
            requestContent.Add(new StringContent(model.Description ?? string.Empty), "Description");
            requestContent.Add(new StringContent(model.Address ?? string.Empty), "Address");
            requestContent.Add(new StringContent(model.PhoneNumber ?? string.Empty), "PhoneNumber");
            requestContent.Add(new StringContent(model.Email ?? string.Empty), "Email");
            requestContent.Add(new StringContent(model.AcademicLevel ?? string.Empty), "AcademicLevel");
            requestContent.Add(new StringContent(model.WorkExperience ?? string.Empty), "WorkExperience");
            requestContent.Add(new StringContent(model.Department.ToString()), "Department");
            requestContent.Add(new StringContent(model.Role.ToString()), "Role");
            requestContent.Add(new StringContent(model.Gender.ToString() ?? string.Empty), "Gender");
            requestContent.Add(new StringContent(model.DateOfBirth?.ToString("yyyy-MM-dd") ?? string.Empty), "DateOfBirth");
            requestContent.Add(new StringContent(model.CreatedBy ?? string.Empty), "CreatedBy");
            requestContent.Add(new StringContent(model.CreatedAt?.ToString("yyyy-MM-dd") ?? string.Empty), "CreatedAt");

            var response = await client.PostAsync("/api/Employee/Create", requestContent);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateEmployee(EmployeeModel model)
        {
            var accessToken = _httpContextAccessor.HttpContext!.Request.Cookies["access_token"];
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refresh_token"];
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var requestContent = new MultipartFormDataContent();

            if (model.CoverImageFilePath != null)
            {
                using var ms = new MemoryStream();
                await model.CoverImageFilePath.CopyToAsync(ms);
                var coverImageContent = new ByteArrayContent(ms.ToArray());
                requestContent.Add(coverImageContent, "CoverImageFilePath", model.CoverImageFilePath.FileName);
            }

            if (model.AvatarFilePath != null)
            {
                using var ms = new MemoryStream();
                await model.AvatarFilePath.CopyToAsync(ms);
                var avatarContent = new ByteArrayContent(ms.ToArray());
                requestContent.Add(avatarContent, "AvatarFilePath", model.AvatarFilePath.FileName);
            }

            requestContent.Add(new StringContent(model.Id.ToString()), "Id");
            requestContent.Add(new StringContent(model.FirstName ?? string.Empty), "FirstName");
            requestContent.Add(new StringContent(model.LastName ?? string.Empty), "LastName");
            requestContent.Add(new StringContent(model.Description ?? string.Empty), "Description");
            requestContent.Add(new StringContent(model.Address ?? string.Empty), "Address");
            requestContent.Add(new StringContent(model.PhoneNumber ?? string.Empty), "PhoneNumber");
            requestContent.Add(new StringContent(model.Email ?? string.Empty), "Email");
            requestContent.Add(new StringContent(model.AcademicLevel ?? string.Empty), "AcademicLevel");
            requestContent.Add(new StringContent(model.WorkExperience ?? string.Empty), "WorkExperience");
            requestContent.Add(new StringContent(model.Department.ToString()), "Department");
            requestContent.Add(new StringContent(model.Role.ToString()), "Role");
            requestContent.Add(new StringContent(model.Gender.ToString() ?? string.Empty), "Gender");
            requestContent.Add(new StringContent(model.DateOfBirth?.ToString("yyyy-MM-dd") ?? string.Empty), "DateOfBirth");
            requestContent.Add(new StringContent(model.LastUpdateBy ?? string.Empty), "LastUpdateBy");
            requestContent.Add(new StringContent(model.LastUpdateAt?.ToString("yyyy-MM-dd") ?? string.Empty), "LastUpdateAt");
            var response = await client.PutAsync("/api/Employee/Update", requestContent);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteEmployee(int id)
        {
            var accessToken = _httpContextAccessor.HttpContext!.Request.Cookies["access_token"];
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refresh_token"];
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:7277");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var response = await client.DeleteAsync("/api/Employee/{id}");
            var body = await response.Content.ReadAsStringAsync();
            return response.IsSuccessStatusCode;
        }

    }
}
