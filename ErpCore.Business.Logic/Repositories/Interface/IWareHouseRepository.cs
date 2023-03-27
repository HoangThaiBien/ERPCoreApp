using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface IWareHouseRepository
    {
        public Task<List<WareHouseModel>> GetAll();
        public Task<WareHouseModel> GetById(int id);
        public Task<List<WareHouseModel>> GetByName(string name);
        public Task<int> Add(WareHouseModel model);
        public Task Update(int id, WareHouseModel model);
        public Task DeleteById(int id);


    }
}
