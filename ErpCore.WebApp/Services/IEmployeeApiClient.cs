using ErpCore.Business.Logic.Dtos;

namespace ErpCore.WebApp.Services
{
    public interface IEmployeeApiClient
    {
        Task<List<EmployeeModel>> GetListEmployee();
        Task<EmployeeModel> GetEmployeeById(int id);
        Task<bool> CreateEmployee(EmployeeModel model);
        Task<bool> DeleteEmployee(int id);
    }
}
