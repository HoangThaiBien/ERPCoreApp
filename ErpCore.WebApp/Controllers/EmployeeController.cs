using ErpCore.Business.Logic.Dtos;
using ErpCore.WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ErpCore.WebApp.Controllers
{
    [Authorize]
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

        public async Task<IActionResult> IndexGrid()
        {
            var result = await _employeeApi.GetListEmployee();
            return View(result);
        }

        public async Task<ActionResult> Details(int id)
        {
            var result = await _employeeApi.GetEmployeeById(id);
            return View(result);
        }

       
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmployeeModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.setCreateInfo(@User.Identity!.Name!, DateTime.UtcNow);
                    bool result = await _employeeApi.CreateEmployee(model);
                    if (result)
                    {
                        TempData["Notify"] = "Success";
                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        TempData["Notify"] = "Error";
                        return View();
                    }    
                    
                }
                TempData["Notify"] = "Warning";
                return View();
            }
            catch
            {
                return View();
            }
        }

        
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _employeeApi.GetEmployeeById(id);
            return View(result);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([FromForm] EmployeeModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.setUpdateInfo(@User.Identity!.Name!, DateTime.UtcNow);
                    bool result = await _employeeApi.UpdateEmployee(model);
                    if (result)
                    {
                        TempData["Notify"] = "Success";
                        return RedirectToAction("Index", "Employee");
                    }
                    else
                    {
                        TempData["Notify"] = "Error";
                        return View("Index", "Employee");
                    }

                }
                TempData["Notify"] = "Warning";
                return View();
            }
            catch
            {
                return View();
            }
        }


        public async Task<ActionResult> Delete(int id)
        {
            var result = await _employeeApi.GetEmployeeById(id);
            return View(result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                await _employeeApi.DeleteEmployee(id);
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}
