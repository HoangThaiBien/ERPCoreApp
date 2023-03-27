using ErpCore.Business.Logic.Dtos;
using ErpCore.Business.Logic.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories.Implement
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<int> Add(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TransactionModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, TransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
