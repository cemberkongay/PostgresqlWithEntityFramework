using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hub.Entities;

namespace Hub.Business.Abstract
{
    public interface ICountryService
    {
        Task<List<Country>> GetAllCountries();

        Task<Country> GetCountryById(int id);
    }
}
