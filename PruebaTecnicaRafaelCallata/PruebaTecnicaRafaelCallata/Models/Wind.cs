using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace PruebaTecnicaRafaelCallata.Models
{
    public class Wind
    {
        [JsonProperty(PropertyName = "speed")]
        public double Speed { get; set; }
        [JsonProperty(PropertyName = "deg")]
        public int Deg { get; set; }
    }
}
