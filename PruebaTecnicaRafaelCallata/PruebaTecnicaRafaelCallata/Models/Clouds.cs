using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace PruebaTecnicaRafaelCallata.Models
{
    public class Clouds
    {
        [JsonProperty(PropertyName = "all")]
        public int All { get; set; }
    }
}
