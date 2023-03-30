using ErpCore.Business.Logic.Dtos;
using ErpCore.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface ITagRepository : IRepository<Tag , TagModel>
    {
       /* public Task<List<TagModel>> GetAll();
        public Task<TagModel> GetById(int id);
        public Task<List<TagModel>> GetByName(string name);
        public Task<int> AddItem(TagModel model);
        public Task Update(int id, TagModel model);
        public Task DeleteById(int id);*/
    }
}
