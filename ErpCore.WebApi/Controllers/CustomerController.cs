using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Implement;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Common.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ErpCore.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository repo)
        {
            _customerRepository = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _customerRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /*[Authorize(Policy = "AdminOrManager")]*/
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var tag = await _customerRepository.GetById(id);
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
                var tag = await _customerRepository.FindItem(x => x.LastName == name);
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
                await _customerRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerModel model)
        {
            try
            {
                model.setCreateInfo("Admin", DateTime.UtcNow);
                await _customerRepository.Add(model);
                return Ok(new Response { Status = "Success", Message = "User created successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CustomerModel model)
        {
            try
            {
                if (model.Id != id)
                {
                    return NotFound();
                }
                await _customerRepository.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }

}

