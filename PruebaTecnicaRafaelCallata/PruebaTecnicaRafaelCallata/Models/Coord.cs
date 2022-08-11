using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace PruebaTecnicaRafaelCallata.Models
{
    public class Coord
    {
        [JsonProperty(PropertyName = "lon")]
        public double Lon { get; set; }
        [JsonProperty(PropertyName = "lat")]
        public double Lat { get; set; }
    }
}
