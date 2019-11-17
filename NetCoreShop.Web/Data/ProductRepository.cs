using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreShop.Web.Data.Entities;

namespace NetCoreShop.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
