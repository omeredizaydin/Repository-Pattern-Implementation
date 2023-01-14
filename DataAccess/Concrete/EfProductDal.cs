using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using repository_pattern.DataAccess.Abstract;
using repository_pattern.Entity;

namespace repository_pattern.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {
        public void Create(Product entity)
        {
            Console.WriteLine("EFProduct - create");
        }

        public void Delete(int id)
        {
        }

        public Product GetById(int id)
        {
            return new Product();
        }

        public Product[] GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            return new Product[3];
        }

        public void Update(Product entity)
        {
            
        }
    }
}