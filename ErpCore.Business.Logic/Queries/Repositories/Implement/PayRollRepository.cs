using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class PayRollRepository : IPayRollRepository
    {
        public Task<PayRollModel> Add(PayRollModel model)
        {
            throw new NotImplementedException();
        }

        public Task<PayRollModel> DeleteById(int id)
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

        public Task<PayRollModel> Update(int id, PayRollModel model)
        {
            throw new NotImplementedException();
        }
    }
}
