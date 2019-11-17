using System.Linq;
using NetCoreShop.Web.Data.Entities;

namespace NetCoreShop.Web.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}