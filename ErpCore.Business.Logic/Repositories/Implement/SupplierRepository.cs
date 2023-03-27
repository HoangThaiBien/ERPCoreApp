using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class SupplierRepository : ISupplierRepository
    {
        public Task<int> Add(SupplierModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SupplierModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SupplierModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SupplierModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, SupplierModel model)
        {
            throw new NotImplementedException();
        }
    }
}
