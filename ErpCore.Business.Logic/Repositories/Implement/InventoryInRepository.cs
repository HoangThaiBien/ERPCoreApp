using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class InventoryInRepository : IInventoryInRepository
    {
        public Task<int> Add(InventoryInModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryInModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryInModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryInModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, InventoryInModel model)
        {
            throw new NotImplementedException();
        }
    }
}
