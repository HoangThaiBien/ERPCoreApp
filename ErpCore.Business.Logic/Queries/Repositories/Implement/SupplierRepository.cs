using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class SupplierRepository : ISupplierRepository
    {
        public Task<SupplierModel> Add(SupplierModel model)
        {
            throw new NotImplementedException();
        }

        public Task<SupplierModel> DeleteById(int id)
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

        public Task<SupplierModel> Update(int id, SupplierModel model)
        {
            throw new NotImplementedException();
        }
    }
}
