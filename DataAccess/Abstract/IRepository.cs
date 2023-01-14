using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        public TEntity GetById(int id);
        public void Update(TEntity entity);
        public void Create(TEntity entity);
        public void Delete(int id);
    }
}