using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestDedalus.Models
{
    public class Country
    {
        [Key]
        [MaxLength(2)]
        public string CountryId { get; set; }

        [MaxLength(50)]
        public string CountryName { get; set; }

        public List<Capital> CountryCapital { get; set; }
    }
}