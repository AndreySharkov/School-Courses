using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONtoCSV
{
    public class CountryPlaces
    {
           [JsonProperty("place name")]
           public string PlaceName {get; set;} = null!;
           public string Longitude {get; set;} = null!;
           public string State {get; set;} = null!;
         
           [JsonProperty("state abbreviation")]
           public string StateAbbr {get; set;} = null!;
           public string Latitude {get; set;} = null!;
    }
}
