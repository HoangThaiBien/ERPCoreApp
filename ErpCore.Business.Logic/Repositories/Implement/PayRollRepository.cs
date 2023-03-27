using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class PayRollRepository : IPayRollRepository
    {
        public Task<int> Add(PayRollModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PayRollModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PayRollModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PayRollModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, PayRollModel model)
        {
            throw new NotImplementedException();
        }
    }
}
