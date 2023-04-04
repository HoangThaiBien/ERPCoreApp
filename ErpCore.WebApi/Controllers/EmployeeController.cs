using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Implement;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Common.Shared.Model;
using ErpCore.Database.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ErpCore.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IFileService _fileService;

        public EmployeeController(IEmployeeRepository employeeRepository, IFileService fileService)
        {
            _employeeRepository = employeeRepository;
            _fileService = fileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result =  await _employeeRepository.GetAll();
                if (result != null)
                {
                    foreach (var item in result)
                    {
                        item.Avatar = _fileService.GetFullImageUrl(item.Avatar);
                        item.CoverImage = _fileService.GetFullImageUrl(item.CoverImage);
                    }
                }

                return Ok(result);
               
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /*[Authorize(Policy = "AdminOrManager")]*/
        [HttpGet("Details/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var tag = await _employeeRepository.GetByIdWithRoleAndLocation(id);
                if (tag == null)
                {
                    return NotFound();
                }
                return Ok(tag);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetTagByName(string name)
        {
            try
            {
                var tag = await _employeeRepository.FindItem(x => x.LastName == name);
                if (tag == null)
                {
                    return NotFound();
                }
                return Ok(tag);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _employeeRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        /*[HttpPost("Create")]
        public async Task<IActionResult> Add(EmployeeModel model) 
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return Ok(new Response { Status = "Error", Message = "Please pass the valid data!" });
                }

                model.setCreateInfo("Admin", DateTime.UtcNow);
                await _employeeRepository.Add(model);
                return Ok(new Response { Status = "Success", Message = "User created successfully!" });
   
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }*/

        
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateWithImage([FromForm] EmployeeModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {  
                    return Ok(new Response { Status = "Failed", Message = "Created Avatar Fail!" });
                }
                var CoverImageResult = _fileService.SaveImage(model.CoverImageFilePath!);
                model.CoverImage = CoverImageResult;
                var AvartarResult = _fileService.SaveImage(model.AvatarFilePath!);
                model.Avatar = AvartarResult;
                await _employeeRepository.Add(model);
                return Ok(new Response { Status = "Success", Message = "Created Avartar successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("upload-image-json")]
        public async Task<IActionResult> UploadImageJson([FromForm] string dataJson, IFormFile AvatarFilePath, IFormFile CoverImageFilePath)
        {
            try
            {
                var model = JsonConvert.DeserializeObject<EmployeeModel>(dataJson);
                if (!ModelState.IsValid)
                {
                    return Ok(new Response { Status = "Failed", Message = "Created Avatar Fail!" });
                }

                var AvartarResult = _fileService.SaveImage(AvatarFilePath!);
                model!.Avatar = AvartarResult;
                var CoverImageResult = _fileService.SaveImage(CoverImageFilePath!);
                model!.CoverImage = CoverImageResult;
               
                await _employeeRepository.Add(model);
                return Ok(new Response { Status = "Success", Message = "Created Employee successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, EmployeeModel model)
        {
            try
            {
                if (model.Id != id)
                {
                    return NotFound();
                }
                await _employeeRepository.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
