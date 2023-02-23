using ErpCore.Business.Logic.Queries.Models;
using ErpCore.Business.Logic.Queries.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Implement
{
    public class CommentRepository : ICommentRepository
    {
        public Task<CommentModel> Add(CommentModel model)
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CommentModel>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<CommentModel> Update(int id, CommentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
