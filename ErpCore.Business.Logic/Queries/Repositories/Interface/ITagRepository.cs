using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ITagRepository
    {
        public Task<List<TagModel>> GetAll();
        public Task<TagModel> GetById(int id);
        public Task<List<TagModel>> GetByName(string name);
        public Task<int> Add(TagModel model);
        public Task Update(int id, TagModel model);
        public Task DeleteById(int id);
    }
}
