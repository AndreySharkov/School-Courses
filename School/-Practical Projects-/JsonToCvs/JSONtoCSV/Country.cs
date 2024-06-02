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
        [JsonProperty("name")]
        public CountryName Names { get; set; }

        public string Region { get; set; }
        public string Subregion { get; set; }

        [JsonProperty("capital")]

        public string[] Capitals { get; set; }
    }
}
