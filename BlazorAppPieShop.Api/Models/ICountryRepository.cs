using BlazorAppPieShop.Shared;
using System.Collections.Generic;

namespace BlazorAppPieShop.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
