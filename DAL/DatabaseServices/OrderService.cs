using Microsoft.EntityFrameworkCore;
using Order.DAL.Models;

public partial class DatabaseService
{
    #region non-async methods
    #region Get

    public IEnumerable<Order> GetOrders()
    {
        return _context.Products
            .Include(e => e.Category)
            .Include(e => e.Order)
            .ToList();
    }

    #endregion

    #region Add

    #endregion

    #region Update

    #endregion

    #region Remove

    #endregion

    #endregion

    #region async methods

    #region Get

    #endregion

    #region Add

    #endregion

    #region Update

    #endregion

    #region Remove

    #endregion

    #endregion
}
