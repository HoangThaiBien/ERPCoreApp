using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IInventoryInRepository
    {
        public Task<List<InventoryInModel>> GetAll();
        public Task<InventoryInModel> Get(int id);
        public Task<List<InventoryInModel>> GetByName(string name);
        public Task<int> Add(InventoryInModel model);
        public Task Update(int id, InventoryInModel model);
        public Task Delete(int id);
    }
}
