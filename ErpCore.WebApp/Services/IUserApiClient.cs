using ErpCore.Business.Logic.Dtos;

namespace ErpCore.WebApp.Services
{
    public interface IUserApiClient
    {
        Task<TokenModel> Authenticate(LoginModel model);
    }
}
