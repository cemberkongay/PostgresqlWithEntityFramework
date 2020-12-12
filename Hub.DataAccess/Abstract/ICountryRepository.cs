using System.Collections.Generic;
using System.Threading.Tasks;
using Hub.Entities;

namespace Hub.DataAccess.Abstract
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetAllCountries();

        Task<Country> GetCountryById(int id);
    }
}
