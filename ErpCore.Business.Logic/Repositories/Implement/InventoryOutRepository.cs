using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class InventoryOutRepository : IInventoryOutRepository
    {
        public Task<int> Add(InventoryOutModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryOutModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryOutModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryOutModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, InventoryOutModel model)
        {
            throw new NotImplementedException();
        }
    }
}
