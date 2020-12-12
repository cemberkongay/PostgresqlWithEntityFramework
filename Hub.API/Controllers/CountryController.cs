using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hub.Business.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hub.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountryController : Controller
    {
        private ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        /// <summary>
        /// Get all countries without provinces.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var countries = await _countryService.GetAllCountries();
            return Ok(countries);
        }

        /// <summary>
        /// Get country by id with provinces.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id < 1)
                return BadRequest();

            var country = await _countryService.GetCountryById(id);

            if (country != null)
                return Ok(country);

            return NotFound();
        }
    }
}
