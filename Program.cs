using repository_pattern.DataAccess.Abstract;
using repository_pattern.DataAccess.Concrete;
using repository_pattern.Entity;

namespace repository_pattern;


class ProductManager : IProductRepository
{
    IProductRepository _repository;
    public ProductManager(IProductRepository repository)
    {
        _repository = repository;

    }
    public void Create(Product entity)
    {
        _repository.Create(entity);
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Product[] GetPopularProducts()
    {
        throw new NotImplementedException();
    }

    public Product[] GetProductsByCategory(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}
class Program
{
    static void Main(string[] args)
    {
        var efProductDal = new EfProductDal();
        var mySQLProductDal = new MySQLProductDal();

        // efProductDal.Create(new Product());
        // mySQLProductDal.Create(new Product());

        var productRepository = new ProductManager(mySQLProductDal);
        productRepository.Create(new Product());


        //injection => IProductRepository => EfProductDal()


    }
}
