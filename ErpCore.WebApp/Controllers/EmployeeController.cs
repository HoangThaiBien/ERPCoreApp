using ErpCore.WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ErpCore.WebApp.Controllers
{
   
    public class EmployeeController : Controller
    {
        private readonly IEmployeeApiClient _employeeApi;
        public EmployeeController(IEmployeeApiClient employeeApiClient, ILogger<UserController> logger)
        {
            _employeeApi = employeeApiClient;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _employeeApi.GetListEmployee();
            return View(result);
        }

    }
}
