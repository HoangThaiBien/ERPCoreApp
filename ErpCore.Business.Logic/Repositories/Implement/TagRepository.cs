using AutoMapper;
using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using ErpCore.Database.EF;
using ErpCore.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class TagRepository : ITagRepository
    {
        private readonly ErpDbContext _context;
        private readonly IMapper _mapper;
        public TagRepository(ErpDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> AddById(TagModel model)
        {
            var newTag = _mapper.Map<Tag>(model);
            _context.Tags.Add(newTag);
            await _context.SaveChangesAsync();
            return newTag.Id;
        }

        public async Task DeleteById(int id)
        {
            var deleteTag = await _context.Tags.FindAsync(id);
            _context.Tags.Remove(deleteTag!);
            await _context.SaveChangesAsync();

        }

        public async Task<List<TagModel>> GetAll()
        {
            var ListTag = await _context!.Tags.ToListAsync();
            return _mapper!.Map<List<TagModel>>(ListTag);
        }

        public async Task<TagModel> GetById(int id)
        {
            var Tag = await _context!.Tags.FindAsync(id);
            return _mapper!.Map<TagModel>(Tag);
        }

        public async Task<List<TagModel>> GetByName(string name)
        {
            var ListName = await _context!.Tags.Where(x => x.Name == name).ToListAsync();
            return _mapper!.Map<List<TagModel>>(ListName);
        }

        public async Task Update(int id, TagModel model)
        {
            if (id == model.Id)
            {
                var UpdateTag = _mapper.Map<Tag>(model);
                _context.Tags.Update(UpdateTag);
                await _context.SaveChangesAsync();
            }
        }
    }
}
