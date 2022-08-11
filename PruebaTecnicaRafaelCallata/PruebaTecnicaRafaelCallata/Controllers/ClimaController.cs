using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaTecnicaRafaelCallata.Models;

namespace PruebaTecnicaRafaelCallata.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        HttpClient client;
        [HttpGet]
        public async Task<IActionResult> GetClima()
        {
            client = new HttpClient();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=cali&appid=19bc36c9d7db6e6df75142ba33d5bea7&lang=es";
            string response = await client.GetStringAsync(url);

            ClimaResponse newsObject = JsonConvert.DeserializeObject<ClimaResponse>(response);
            var list = new List<Clima>();
            var climaActual = new Clima();

            climaActual.Name = newsObject.Name;
            climaActual.Date = DateTime.Now.Date;
            climaActual.Temp = newsObject.Main.Temp;            
            foreach (var clima in newsObject.Weather)
            {
                climaActual.Icon = clima.Icon;
                climaActual.Description = clima.Description;
            }
            climaActual.Temp_maxi = newsObject.Main.Temp_max;
            climaActual.Temp_min = newsObject.Main.Temp_min;
            climaActual.Feels_like = newsObject.Main.Feels_like;
            climaActual.Humidity = newsObject.Main.Humidity;
            climaActual.Speed = newsObject.Wind.Speed;

            list.Add(climaActual);

            return Ok(await Task.Run(() => climaActual));
        }
    }
}
