using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class WareHouseRepository : IWareHouseRepository
    {
        public Task<int> Add(WareHouseModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WareHouseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<WareHouseModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WareHouseModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, WareHouseModel model)
        {
            throw new NotImplementedException();
        }
    }
}
