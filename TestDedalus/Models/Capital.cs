using System.ComponentModel.DataAnnotations;

namespace TestDedalus.Models
{
    public class Capital
    {
        [Key]
        [MaxLength(3)]
        public string CapitalId { get; set; }

        [Required]
        public string CapitalName{ get; set; }

        [Required]
        public string CountryId { get; set; }
        public Country Country { get; set; }
    }
}
