using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class TagRepository : ITagRepository
    {
        public Task<TagModel> Add(TagModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TagModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TagModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TagModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TagModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<TagModel> Update(int id, TagModel model)
        {
            throw new NotImplementedException();
        }
    }
}
