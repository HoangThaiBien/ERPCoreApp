using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<TransactionModel> Add(TransactionModel model)
        {
            throw new NotImplementedException();
        }

        public Task<TransactionModel> DeleteById(int id)
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

        public Task<TransactionModel> Update(int id, TransactionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
