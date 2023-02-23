using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface IPayRollRepository
    {
        public Task<List<PayRollModel>> GetAll();
        public Task<PayRollModel> GetById(int id);
        public Task<List<PayRollModel>> GetByName(string name);
        public Task<int> Add(PayRollModel model);
        public Task Update(int id, PayRollModel model);
        public Task DeleteById(int id);
    }
}
