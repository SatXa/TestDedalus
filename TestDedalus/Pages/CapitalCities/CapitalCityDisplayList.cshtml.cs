using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestDedalus.Data;
using TestDedalus.ViewModels;

namespace TestDedalus.Pages.CapitalCities
{
    public class CapitalCityDisplayListModel : PageModel
    {
        private readonly TestDedalusContext _context;

        [BindProperty(SupportsGet = true)]
        public List<CapitalCityDisplayListViewModel> CapitalCitiesDisplayList { get; set; }

        public CapitalCityDisplayListModel(TestDedalusContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var repo = new CapitalCitiesRepository(_context);
            //CapitalCitiesDisplayList = (List<CapitalCitySearchViewModel>)repo.GetCapitalCities();
            CapitalCitiesDisplayList = repo.GetCapitalCities();
            return Page();
        }
    }
}
