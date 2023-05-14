using Microsoft.EntityFrameworkCore;
using Order.DAL.Models;
namespace Order.DAL.DatabaseServices;

public partial class DatabaseService
{
    #region non-async methods
    #region Get
    public IEnumerable<Category> Categories()
    {
        return _context.Categories
            .Include(e => e.)
            .ToList();
    }

    public Actor GetActorById(int id)
    {
        return _context.Actors.FirstOrDefault(e => e.ActorId == id);
    }

    public Actor GetActorByName(string name)
    {
        return _context.Actors.FirstOrDefault(e => e.Name.Equals(name));
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
