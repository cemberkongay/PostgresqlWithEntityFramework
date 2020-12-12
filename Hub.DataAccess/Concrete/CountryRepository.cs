using System.Collections.Generic;
using System.Threading.Tasks;
using Hub.DataAccess;
using Hub.DataAccess.Abstract;
using Hub.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hub.DataAccess.Concrete
{
    public class CountryRepository : ICountryRepository
    {
        public async Task<List<Country>> GetAllCountries()
        {
            using var dbContext = new HubDbContext();
            return await dbContext.Countries.ToListAsync();
        }

        public async Task<Country> GetCountryById(int id)
        {
            using var dbContext = new HubDbContext();
            return await dbContext.Countries.Include("Provinces").FirstOrDefaultAsync(x=> x.Id == id);
        }
    }
}