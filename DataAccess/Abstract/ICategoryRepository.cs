using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {

        // Category GetById(int id);
        // public void Update(Category entity);
        // public void Create(Category entity);
        // public void Delete(int id);

        Category[] GetCategories();


    }
}