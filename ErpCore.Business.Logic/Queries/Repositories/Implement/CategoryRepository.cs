using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<CategoryModel> Add(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> Update(int id, CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
