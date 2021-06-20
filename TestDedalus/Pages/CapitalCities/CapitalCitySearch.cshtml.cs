using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestDedalus.Data;
using TestDedalus.Models;
using TestDedalus.ViewModels;

namespace TestDedalus.Pages.CapitalCities
{
    public class CapitalCitySearchModel : PageModel
    {
        private readonly TestDedalusContext _context;

        [BindProperty(SupportsGet = true)]
        //public List<CapitalCitySearchViewModel> CapitalCitiesSearchList { get; set; }
        public IEnumerable<SelectListItem> CapitalCitiesSearchList { get; set; }

        //[BindProperty]
        public string searchString = "BO";

        public CapitalCitySearchModel(TestDedalusContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string searchString = "ES")
        {
            var repo = new CapitalCitiesRepository(_context);
            //CapitalCitiesSearchList = (List<CapitalCitySearchViewModel>)repo.GetCapitalCities();
            CapitalCitiesSearchList = repo.GetCapitalCityFromSearchString(searchString);
            return Page();
        }

        //public IActionResult OnGetCountryId()
        //{
        //    var repo = new CapitalCitiesRepository(_context);
        //    //CapitalCitiesSearchList = (List<CapitalCitySearchViewModel>)repo.GetCapitalCities();
        //    CapitalCitiesSearchList = (List<CapitalCitySearchViewModel>)repo.GetCapitalCities("ES");
        //    return Page();
        //}
    }
}
