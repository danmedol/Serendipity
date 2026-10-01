using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Serendipity
{
    public class EstimatedDiameter
    {
        [JsonPropertyName("kilometers")]
        public DiameterUnit Kilometers { get; set; }

        [JsonPropertyName("meters")]
        public DiameterUnit Meters { get; set; }

        [JsonPropertyName("miles")]
        public DiameterUnit Miles { get; set; }

        [JsonPropertyName("feet")]
        public DiameterUnit Feet { get; set; }
    }
}
