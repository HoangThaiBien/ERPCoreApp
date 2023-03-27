using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<int> Add(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
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

        public Task Update(int id, CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
