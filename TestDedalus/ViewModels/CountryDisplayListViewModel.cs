using System.ComponentModel.DataAnnotations;

namespace TestDedalus.ViewModels
{
    public class CountryDisplayListViewModel
    {
        [Display(Name = "Country ID")]
        public string CountryId { get; set; }

        [Display(Name = "Country Name")]
        public string CountryName { get; set; }
    }
}