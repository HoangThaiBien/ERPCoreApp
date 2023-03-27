using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IInventoryOutRepository
    {
        public Task<List<InventoryOutModel>> GetAll();
        public Task<InventoryOutModel> Get(int id);
        public Task<List<InventoryOutModel>> GetByName(string name);
        public Task<int> Add(InventoryOutModel model);
        public Task Update(int id, InventoryOutModel model);
        public Task Delete(int id);
    }
}
