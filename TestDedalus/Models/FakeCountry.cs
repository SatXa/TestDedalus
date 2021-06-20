using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDedalus.Models
{
    // NOTA: esta clase se ha creado únicamente como un clon de Country para 
    // poder usarla como un POCO en la creación del modelo en lugar de Country
    public class FakeCountry
    {
        //[Key]
        //[MaxLength(2)]
        public string CountryId { get; set; }

        //[MaxLength(50)]
        public string CountryName { get; set; }

        public List<Capital> CountryCapital { get; set; }
    }
}
