using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.DataAccess.Abstract;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        
        public void Create(Category entity)
        {
            
        }

        public void Delete(int id)
        {
            
        }

        public Category GetById(int id)
        {
            return new Category();
        }

        public Category[] GetCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}