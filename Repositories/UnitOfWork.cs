
using APIEcommerce.Context;

namespace APIEcommerce.Repositories;

public class UnitOfWork : IUnitOfWork
{
    //private IProductRepository? _productRepo;
    //private ICategoryRepository? _cetegoryRepo;

    public AppDbContext _context;
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    /*
    public IProductRepository ProductRepository
    {
        get
        {
            return _productRepo = _productRepo ?? new ProductRepository(_context);
            //if (_productRepo == null)
            //{
            //    _productRepo = new IProductRepository(_context);
            //}
            //return _productRepo;
        }
    }

    public ICategoryRepository CategoryRepository
    {
        get
        {
            return _cetegoryRepo = _cetegoryRepo ?? new CategoryRepository(_context);
        }
    }

    // ^ abordagem Lazy Loading -> significa adiar a obtenção dos objetos até que eles sejam realmente necessários.

    */

    public async Task CommitAsync()
    {
       await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }

}
