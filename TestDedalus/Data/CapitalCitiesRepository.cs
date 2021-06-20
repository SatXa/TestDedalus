using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestDedalus.Models;
using TestDedalus.ViewModels;

namespace TestDedalus.Data
{
    public class CapitalCitiesRepository
    {
        private readonly TestDedalusContext _context;

        public CapitalCitiesRepository(TestDedalusContext context)
        {
            _context = context;
        }

        /*
        public IEnumerable<SelectListItem> GetCapitalCities()
        {
            List<SelectListItem> capitalCities = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return capitalCities;
        }
        */

        /*
        public IEnumerable<SelectListItem> GetCapitalCities()
        {
            List<Capital> capitalCities = new List<Capital>();
            capitalCities = _context.Capitals.AsNoTracking()
                .Include(x => x.Country)
                .ToList();

            if (capitalCities != null)
            {
                List<CapitalCitySearchViewModel> capitalCitiesDisplay = new List<CapitalCitySearchViewModel>();
                foreach (var x in capitalCities)
                {
                    var capitalCityDisplay = new CapitalCitySearchViewModel()
                    {
                        CapitalId = x.CapitalId,
                        CapitalName = x.CapitalName,
                        CountryId = x.CountryId,
                        CountryName = x.Country.CountryName
                    };
                    capitalCitiesDisplay.Add(capitalCityDisplay);
                }
                return (IEnumerable<SelectListItem>)capitalCitiesDisplay; // esto esta bien?
            }
            return null;
        }
        */

        public List<CapitalCityDisplayListViewModel> GetCapitalCities()
        {
            List<Capital> capitalCities = new List<Capital>();
            capitalCities = _context.Capitals.AsNoTracking()
                .Include(x => x.Country)
                .ToList();

            if (capitalCities != null)
            {
                List<CapitalCityDisplayListViewModel> capitalCitiesDisplay = new List<CapitalCityDisplayListViewModel>();
                foreach (var x in capitalCities)
                {
                    var capitalCityDisplay = new CapitalCityDisplayListViewModel()
                    {
                        CapitalId = x.CapitalId,
                        CapitalName = x.CapitalName,
                        CountryId = x.CountryId,
                        CountryName = x.Country.CountryName
                    };
                    capitalCitiesDisplay.Add(capitalCityDisplay);
                }
                return capitalCitiesDisplay;
            }
            return null;
        }

        public IEnumerable<SelectListItem> GetCapitalCityFromSearchString(string searchString)
        {
            if (!String.IsNullOrWhiteSpace(searchString))
            {
                IEnumerable<SelectListItem> capitalCities = _context.Capitals.AsNoTracking()
                    .Where(n => n.CountryId.ToLower().Contains(searchString.ToLower()) | n.Country.CountryName.ToLower().Contains(searchString.ToLower()))
                    .OrderBy(n => n.CapitalName)
                    .Select(n =>
                        new SelectListItem
                        {
                            Value = n.CapitalId,
                            Text = n.CapitalName
                        }).ToList();
                return new SelectList(capitalCities, "Value", "Text");
            }
            return null;
        }

        //public List<CapitalCityDisplayListViewModel> GetFilteredCapitalCities(string countryId)
        //{
        //    if (!String.IsNullOrWhiteSpace(countryId))
        //    {
        //        IEnumerable<SelectListItem> capitalCities = _context.Capitals.AsNoTracking()
        //            .OrderBy(n => n.CapitalName)
        //            .Where(n => n.CountryId == countryId)
        //            .Select(n =>
        //                new SelectListItem
        //                {
        //                    Value = n.CapitalId,
        //                    Text = n.CapitalName
        //                }).ToList();
        //        return new SelectList(capitalCities, "Value", "Text");
        //    }
        //    return null;
        //}
    }
}
