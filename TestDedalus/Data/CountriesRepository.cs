using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TestDedalus.Data
{
    public class CountriesRepository
    {
        private readonly TestDedalusContext _context;
        public CountriesRepository(TestDedalusContext context)
        {
            _context = context;
        }

        public IEnumerable<SelectListItem> GetCountries()
        {
            // Nota: AsNoTracking() hace que la BD no "siga" los datos; como en este caso no se van a modificar, no es necesario seguirlos para actualizarlos. Guay.
            List<SelectListItem> countries = _context.Countries.AsNoTracking()
                .OrderBy(n => n.CountryName)
                .Select(n =>
                    new SelectListItem
                    {
                        Value = n.CountryId.ToString(),
                        Text = n.CountryName
                    }).ToList();
            // primera opción
            var countryTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select country ---"
            };
            countries.Insert(0, countryTip);
            return new SelectList(countries, "Value", "Text");
        }

        // este es el que queremos: pasamos el código ISO del país
        public IEnumerable<SelectListItem> GetCountriesFromSearchFilter(string searchFilter)
        {
            if (!String.IsNullOrWhiteSpace(searchFilter))
            {
                IEnumerable<SelectListItem> countries = _context.Countries.AsNoTracking()
                    .OrderBy(n => n.CountryId)
                    .Where(n => n.CountryId.Contains(searchFilter) || n.CountryName.Contains(searchFilter)) // no hay que tener en cuenta las mayúsculas / caracteres especiales?
                    .Select(n =>
                        new SelectListItem
                        {
                            Value = n.CountryId,
                            Text = n.CountryId + " - " + n.CountryName
                        }).ToList();
                return new SelectList(countries, "Value", "Text");
            }
            return null;
        }
    }
}
