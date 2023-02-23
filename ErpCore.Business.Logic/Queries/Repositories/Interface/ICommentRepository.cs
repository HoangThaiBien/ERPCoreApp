using ErpCore.Business.Logic.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Queries.Repositories.Interface
{
    public interface ICommentRepository
    {
        public Task<List<CommentModel>> GetAll();
        public Task<CommentModel> GetById(int id);
        public Task<List<CommentModel>> GetByName(string name);
        public Task<int> Add(CommentModel model);
        public Task Update(int id, CommentModel model);
        public Task DeleteById(int id);
    }
}
