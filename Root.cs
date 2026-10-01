using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Serendipity
{
    public class Root
    {
        [JsonPropertyName("element_count")]
        public int ElementCount { get; set; }
        [JsonPropertyName("near_earth_objects")]
        public Dictionary<string, List<Asteroid>> NearEarthObjects { get; set; }
    }
}
