using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONtoCSV
{
    public class Country
    {
        [JsonProperty("post code")]
        public string PostCode { get; set; } = null!;
       
        [JsonProperty("country")]
        public string CountryName { get; set; } = null!;
        [JsonProperty("country abbreviation")]
        public string CountryAbbr { get; set; } = null!;

        public CountryPlaces[] Places { get; set; } = null!;
 
    }
}
