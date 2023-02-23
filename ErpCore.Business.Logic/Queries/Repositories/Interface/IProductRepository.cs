using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> GetAll();
        public Task<ProductModel> GetById(int id);
        public Task<List<ProductModel>> GetByName(string name);
        public Task<int> Add(ProductModel model); 
        public Task Update(int id, ProductModel model); 
        public Task DeleteById(int id);
    }
}
