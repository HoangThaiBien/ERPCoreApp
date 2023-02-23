using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IProductCategoryRepository
    {
        public Task<List<ProductCategoryModel>> GetAll();
        public Task<ProductCategoryModel> GetById(int id);
        public Task<List<ProductCategoryModel>> GetByName(string name);
        public Task<int> Add(ProductCategoryModel model);
        public Task Update(int id, ProductCategoryModel model);
        public Task DeleteById(int id);
    }
}
