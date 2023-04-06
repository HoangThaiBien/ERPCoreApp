using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Database.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Xml.Linq;

namespace ErpCore.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        public readonly ITagRepository _tagRepository;
        public TagController(ITagRepository repo)
        {
            _tagRepository = repo;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            try {
                return Ok(await _tagRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [Authorize(Policy = "AdminOrManager")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var tag = await _tagRepository.GetById(id);
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

        [Authorize]
        [HttpGet("{name}")]
        public async Task<IActionResult> GetTagByName(string name)
        {
            try
            {
                var tag = await _tagRepository.FindItem(x => x.Name == name);
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

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _tagRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Add(TagModel model)
        {
            try
            {
                model.setCreateInfo("Admin", DateTime.UtcNow);
                await _tagRepository.Add(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> Update(TagModel model)
        {
            try
            {
                await _tagRepository.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    } 
}
