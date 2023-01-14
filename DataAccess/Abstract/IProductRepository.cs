using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        // Product GetById(int id);
        // void Update(Product entity);
        //  void Create(Product entity);
        //  void Delete(int id);

    
         Product[] GetProductsByCategory(int id);
        Product[] GetPopularProducts();

    }
}