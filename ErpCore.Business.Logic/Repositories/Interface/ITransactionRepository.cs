using ErpCore.Business.Logic.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Interface
{
    public interface ITransactionRepository
    {
        public Task<List<TransactionModel>> GetAll();
        public Task<TransactionModel> GetById(int id);
        public Task<List<TransactionModel>> GetByName(string name);
        public Task<int> Add(TransactionModel model);
        public Task Update(int id, TransactionModel model);
        public Task DeleteById(int id);
    }
}
