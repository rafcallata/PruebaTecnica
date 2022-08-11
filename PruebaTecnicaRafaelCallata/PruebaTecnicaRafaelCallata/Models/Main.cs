using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace PruebaTecnicaRafaelCallata.Models
{
    public class Main
    {
        [JsonProperty(PropertyName = "temp")]
        public double Temp { get; set; }
        [JsonProperty(PropertyName = "feels_like")]
        public double Feels_like { get; set; }
        [JsonProperty(PropertyName = "temp_min")]
        public double Temp_min { get; set; }
        [JsonProperty(PropertyName = "temp_max")]
        public double Temp_max { get; set; }
        [JsonProperty(PropertyName = "pressure")]
        public double Pressure { get; set; }
        [JsonProperty(PropertyName = "humidity")]
        public double Humidity { get; set; }
    }
}
