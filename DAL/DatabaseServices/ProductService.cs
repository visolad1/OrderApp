using Microsoft.EntityFrameworkCore;
using Order.DAL.Models;

namespace Order.DAL.DatabaseServices;
public partial class DatabaseService
{
    #region non-async methods
    #region Get

    public IEnumerable<Product> GetProducts()
    {
        return _context.Products
            .Include(e => e.Category)
            .Include(e => e.Order)
            .ToList();
    }

    public Product GetProductWithId(int id)
    {
        return _context.Products.FirstOrDefault(e => e.Id == id);
    }

    #endregion

    #region Add

    public int AddProduct(Product product) 
    {
        _context.Products.Add(product);
        return _context.SaveChanges();
    }

    public int AddProducts(IList<Product> products)
    {
        _context.Products.AddRange(products);
        return _context.SaveChanges();
    }

    #endregion

    #region Update

    public int UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        return _context.SaveChanges();
    }

    public int UpdateProducts(IList<Product> products)
    {
        _context.Products.UpdateRange(products);
        return _context.SaveChanges();
    }

    #endregion

    #region Remove

    public int RemoveProduct(Product product)
    {
        _context.Products.Remove(product);
        return _context.SaveChanges();
    }

    public int RemoveProductById(int id)
    {
        var resProduct = _context.Products.FirstOrDefault(e => e.Id == id);
        if (resProduct is null)
        {
            return default;
        }

        _context.Products.Remove(resProduct);
        return _context.SaveChanges();
    }

    public int RemoveProducts(IList<Product> products)
    {
        _context.Products.RemoveRange(products);
        return _context.SaveChanges();
    }

    #endregion

    #endregion

    #region async methods

    #region Get
    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _context.Products
            .Include(e => e.Category)
            .Include(e => e.Order)
            .ToListAsync();
    }

    public async Task<Product> GetProductWithIdAsync(int id)
    {
        return await _context.Products.FirstOrDefaultAsync(e => e.Id == id);
    }
    #endregion

    #region Add
    public async Task<int> AddProductAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> AddProductsAsync(IList<Product> products)
    {
        await _context.Products.AddRangeAsync(products);
        return await _context.SaveChangesAsync();
    }
    #endregion

    #region Update
    public async Task<int> UpdateProductAsync(Product product)
    {
        _context.Products.Update(product);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateProductsAsync(IList<Product> products)
    {
        _context.Products.UpdateRange(products);
        return await _context.SaveChangesAsync();
    }
    #endregion

    #region Remove
    public async Task<int> RemoveProductAsync(Product product)
    {
        _context.Products.Remove(product);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> RemoveProductByIdAsync(int id)
    {
        var resProduct = await _context.Products.FirstOrDefaultAsync(e => e.Id == id);
        if (resProduct is null)
        {
            return default;
        }

        _context.Products.Remove(resProduct);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> RemoveProductsAsync(IList<Product> products)
    {
        _context.Products.RemoveRange(products);
        return await _context.SaveChangesAsync();
    }
    #endregion

    #endregion
}
