using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestDedalus.ViewModels
{
    public class CapitalCitySearchViewModel
    {
        [Display(Name = "Capital ID")]
        public string CapitalId { get; set; }

        [Display(Name = "Capital Name")]
        public string CapitalName { get; set; }

        [Display(Name = "Country ID")]
        public string CountryId { get; set; }

        [Display(Name = "Country Name")]
        public string CountryName { get; set; }

        [Display(Name = "Selected Country ID")]
        public string SelectedCountryId { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
