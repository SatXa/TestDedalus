using System.ComponentModel.DataAnnotations;

namespace TestDedalus.ViewModels
{
    public class CapitalCityDisplayListViewModel
    {
        [Display(Name = "Capital ID")]
        public string CapitalId { get; set; }

        [Display(Name = "Capital Name")]
        public string CapitalName { get; set; }

        [Display(Name = "Country ID")]
        public string CountryId { get; set; }

        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}
