using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Repositories
{
    public interface IRepository<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        Task<TDto> GetById(int id);
        Task<IEnumerable<TDto>> GetAll();
        Task<IEnumerable<TDto>> FindItem(Expression<Func<TEntity, bool>> predicate);
        Task AddItem(TDto entity);
        Task AddRange(IEnumerable<TDto> entities);
        Task Update(TDto entity);
        Task Delete(int id);
        Task DeleteRange(IEnumerable<int> id);
    }
}
