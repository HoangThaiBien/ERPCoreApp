using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ISupplierRepository
    {
        public Task<List<SupplierModel>> GetAll();
        public Task<SupplierModel> GetById(int id);
        public Task<List<SupplierModel>> GetByName(string name);
        public Task<int> Add(SupplierModel model);
        public Task Update(int id, SupplierModel model);
        public Task DeleteById(int id);
    }
}
