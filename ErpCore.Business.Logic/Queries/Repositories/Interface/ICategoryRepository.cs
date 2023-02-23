using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryModel>> GetAll();
        public Task<CategoryModel> GetById(int id);
        public Task<List<CategoryModel>> GetByName(string name);
        public Task<int> Add(CategoryModel model);
        public Task Update(int id, CategoryModel model);
        public Task DeleteById(int id);
    }
}
