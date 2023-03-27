﻿using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Business.Logic.Repositories;
using ErpCore.Business.Logic.Services;
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
        private readonly IUserService _userService;
        public readonly IRepository<Tag, TagModel> _tagRepository;
        public TagController(IRepository<Tag, TagModel> repo,IUserService userService)
        {
            _tagRepository = repo;
            _userService = userService;

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
                await _tagRepository.AddItem(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,TagModel model)
        {
            try
            {
                if(model.Id != id)
                {
                    return NotFound();
                }
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