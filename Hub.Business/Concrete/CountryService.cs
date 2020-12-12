using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hub.Business.Abstract;
using Hub.DataAccess.Abstract;
using Hub.Entities;

namespace Hub.Business.Concrete
{
    public class CountryService : ICountryService
    {
        private ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<List<Country>> GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }

        public async Task<Country> GetCountryById(int id)
        {
            if (id > 0)
                return await _countryRepository.GetCountryById(id);

            throw new Exception("Id cannot be less than 1");
        }
    }
}
