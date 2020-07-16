using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sports_Api.Models.CustomModel
{
    public class SportCountryViewModel
    {
        [Key]
        public int SportCountryId { get; set; }
        public int SportId { get; set; }
        public string SportName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }

    }
}
