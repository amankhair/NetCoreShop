using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreShop.Web.Data.Entities;

namespace NetCoreShop.Web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {
        }
    }
}
